using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinForm
{
    public partial class WinForm : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //private const int cfrFibonacci = 10;

        public WinForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Permet d'effectuer des opération récurrentes sur les deux boutons.
        /// Comme l'affichage d'une progressBar qui est commune aux deux actions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="tkRes"></param>
        /// <param name="titre"></param>
        /// <returns></returns>
        private async Task CalculLongSurBoutonAsync(object sender, Task<string> tkRes, string titre) {
            BusyForm bs = new BusyForm();
            ((Button)sender).Enabled = false;

            tkRes.GetAwaiter().OnCompleted(() => bs.Dispose());

            bs.StartPosition = FormStartPosition.CenterParent;
            bs.ShowDialog(this);

            string resultat;
            try
            {
                resultat = await tkRes;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ((Button)sender).Enabled = true;
            }

            MessageBox.Show($"The result is {resultat}", titre, MessageBoxButtons.OK);
        }


        /// <summary>
        /// Lorsque l'on clique sur le bouton "Compute Fibonacci"
        /// On ouvre une popup d'attente, et on effectue le calcul.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnFibonacci_Click(object sender, EventArgs e)
        {
            log.Info("début du calcul de Fibonacci");

            int cfrFibonacci;

            if (!int.TryParse(txtFibonacci.Text, out cfrFibonacci)){
                log.Error("The value passed for the Fibonacci sequence is not correct.");
                MessageBox.Show($"{txtFibonacci.Text} is not an expected value.", "Error", MessageBoxButtons.OK);
                return;
            }

            Task<string> tkRes = Task.Run(() => new Fibonacci.SwFibonacci().Fibonacci(cfrFibonacci));            

            try
            {
                await CalculLongSurBoutonAsync(sender, tkRes, "Fibonacci sequence result");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK);
                log.Error(ex.Message + " " + ex.StackTrace);
                return;
            }

            log.Info("fin du calcul de Fibonacci");
        }

        /// <summary>
        /// Lorsque le texte de la boite de Fibonacci change.
        /// Si c'est un entier qui est entré, on affiche le texte avec l'entier entré.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtFibonacci_TextChanged(object sender, EventArgs e)
        {            
            if (int.TryParse(txtFibonacci.Text, out int cfrFibonacci)){
                btnFibonacci.Text = $"Compute Fibonacci ({cfrFibonacci})";
            }
        }

        /// <summary>
        /// Lorsque l'on clique sur le bouton "Convert XML to JSon"
        /// On ouvre une popup d'attente, et on effectue la conversion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnCvrtXML2JSon_Click(object sender, EventArgs e)
        {
            log.Info("début de la conversion du XML en Json");

            Task<string> tkRes = Task.Run(() => new XmlToJson.SwXmlToJson().XmlToJson(txtXML2JSon.Text));

            try
            {
                await CalculLongSurBoutonAsync(sender, tkRes, "XML To JSon convert result");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK);
                log.Error(ex.Message + " " + ex.StackTrace);
                return;
            }

            log.Info("fin de la conversion du XML en Json");
        }

        /// <summary>
        /// formatage du XML quand on tape le texte.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtXML2JSon_TextChanged(object sender, EventArgs e)
        {

            XElement xElem;
            try
            {
                xElem = XElement.Parse(txtXML2JSon.Text);
            }
            catch (Exception)
            {
                return;
            }

            var stringBuilder = new StringBuilder();
            var settings = new System.Xml.XmlWriterSettings();
            settings.OmitXmlDeclaration = true;
            settings.Indent = true;
            settings.NewLineOnAttributes = true;

            using (var xmlWriter = System.Xml.XmlWriter.Create(stringBuilder, settings))
            {
                xElem.Save(xmlWriter);
            }

            txtXML2JSon.Text = stringBuilder.ToString();
        }
    }
}
