using Newtonsoft.Json;
using System.ComponentModel;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Linq;
using System.Xml.Linq;

namespace WebService
{
    /// <summary>
    /// Description résumée de XmlToJson
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class SwXmlToJson : System.Web.Services.WebService
    {

        private static readonly log4net.ILog log
           = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Cette fonction prend en paramètre une chaine de caractères formatée en XML et retourne
        /// une chaine de caractères formatée en JSon. Utilise la librairie NewtonSoft.
        /// </summary>
        /// <param name="xml">la chaine XML à transformer en JSon.</param>
        /// <returns></returns>
        [WebMethod(Description = "Permet de convertir une chaine XML en une chaine JSon possédant les mêmes caractéristiques.")]
        public string XmlToJson(string xml)
        {
            log.Info(HttpContext.Current.Request.Url + " " + HttpContext.Current.Request.UserHostAddress + " " + xml);
            XElement xmlDoc;
            try
            {
                xmlDoc = XElement.Parse(xml);
                xmlDoc.Descendants().Where(e => string.IsNullOrEmpty(e.Value)).Remove();
            }
            catch (XmlException)
            {
                log.Info("Bad Xml format");

                return "Bad Xml format";
            }

            string strRes = JsonConvert.SerializeXNode(xmlDoc);

            log.Info("résultat : " + strRes);

            return strRes;
        }
    }
}
