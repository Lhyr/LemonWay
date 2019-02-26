using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class WinForm : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private const int cfrFibonacci = 10;
        public WinForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Lorsque l'on clique sur le bouton "Compute Fibonacci (10)"
        /// On ouvre une popup d'attente, et on effectue le calcul.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnFibonacci_Click(object sender, EventArgs e)
        {
            log.Info("début du calcul de Fibonacci");
            BusyForm bs = new BusyForm();
            ((Button)sender).Enabled = false;

            Task<int> tkRes = Task.Run(() => new Fibonacci.SwFibonacci().Fibonacci(cfrFibonacci));
            tkRes.GetAwaiter().OnCompleted(() => bs.Dispose());

            bs.ShowDialog(this);
            bs.StartPosition = FormStartPosition.CenterParent;

            int resultat = -1;
            try
            {
                resultat = await tkRes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK);
                log.Error(ex.Message + " " + ex.StackTrace);
                return;
            }
            finally
            {
                ((Button)sender).Enabled = true;
            }

            MessageBox.Show($"The result is {resultat}", "Fibonacci sequence result", MessageBoxButtons.OK);
            log.Info("fin du calcul de Fibonacci");
        }
    }
}
