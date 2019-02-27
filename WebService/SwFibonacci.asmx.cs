using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Description résumée de Fibonacci
    /// </summary>
    [System.Web.Script.Services.ScriptService]
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class SwFibonacci : System.Web.Services.WebService
    {

        private static readonly log4net.ILog log
           = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Permet de calculer itérativement le Neme élement de la suite de Fibonacci,
        /// suivant ce qui est entré en paramètre.
        /// </summary>
        /// <param name="nombre">l'élément à calculer.</param>
        /// <returns></returns>
        private System.Numerics.BigInteger FibIteratif(int nombre) {

            System.Numerics.BigInteger[] tabFib = new System.Numerics.BigInteger[nombre];

            tabFib[0] = 1;

            if (nombre > 1)
                tabFib[1] = 1;

            for (int i = 2; i < nombre; i++) {
                tabFib[i] = tabFib[i - 2] + tabFib[i - 1];
            }

            return tabFib[nombre - 1];
        }

        /// <summary>
        /// Fonction qui prend en paramètre un nombre compris entre 1 et 100
        /// et retourne en résultat le calcul de la suite de Fibonacci.
        /// </summary>
        /// <param name="n">le nombre que l'on souhaite dans la suite</param>
        /// <returns>le calcul de la suite.</returns>
        [WebMethod(Description = "Permet de calculer la suite de Fibonacci, avec un nombre donné, compris entre 1 et 100")]
        public string Fibonacci(int n)
        {
            log.Info(HttpContext.Current.Request.Url + " " + HttpContext.Current.Request.UserHostAddress + " " + n.ToString());
            if (n < 1 || n > 100)
            {
                return "-1";
            }

            System.Numerics.BigInteger res = FibIteratif(n);

            log.Info("résultat : " + res.ToString());

            return res.ToString();
        }


        /// <summary>
        /// Fonction qui prend en paramètre un nombre compris entre 1 et 100
        /// et retourne en résultat le calcul de la suite de Fibonacci.
        /// </summary>
        /// <param name="n">le nombre que l'on souhaite dans la suite</param>
        /// <returns>le calcul de la suite.</returns>
        [WebMethod(Description = "Permet de calculer la suite de Fibonacci, avec un nombre donné, compris entre 1 et 100")]
        [System.Web.Script.Services.ScriptMethod(UseHttpGet = true, ResponseFormat = System.Web.Script.Services.ResponseFormat.Json)]
        public string FibonacciJSon(int n)
        {
            log.Info(HttpContext.Current.Request.Url + " " + HttpContext.Current.Request.UserHostAddress + " " + n.ToString());
            if (n < 1 || n > 100)
            {
                return "-1";
            }

            System.Numerics.BigInteger res = FibIteratif(n);

            log.Info("résultat : " + res.ToString());

            return new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(res.ToString());
        }
    }
}
