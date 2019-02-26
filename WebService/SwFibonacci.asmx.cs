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
        /// Fonction qui calcule récursivement la suite de Fibonacci et renvoie le résultat.
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        private int Fib(int nombre)
        {
            if (nombre < 2)
            {
                return nombre;
            }
            return Fib(nombre - 1) + Fib(nombre - 2);
        }

        /// <summary>
        /// Fonction qui prend en paramètre un nombre compris entre 1 et 100
        /// et retourne en résultat le calcul de la suite de Fibonacci.
        /// </summary>
        /// <param name="n">le nombre que l'on souhaite dans la suite</param>
        /// <returns>le calcul de la suite.</returns>
        [WebMethod(Description = "Permet de calculer la suite de Fibonacci, avec un nombre donné, compris entre 1 et 100")]
        public int Fibonacci(int n)
        {
            log.Info(HttpContext.Current.Request.Url + " " + HttpContext.Current.Request.UserHostAddress + " " + n.ToString());
            if (n < 1 || n > 100)
            {
                return -1;
            }

            int res = Fib(n);

            log.Info("résultat : " + res.ToString());

            return res;
        }
    }
}
