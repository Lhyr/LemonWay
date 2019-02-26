using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebService_testUnitaire
{
    [TestClass]
    public class SwFibonacciTst
    {
        [TestMethod]
        public void Fibonacci_Valeur_Un_Retour_Un()
        {
            int valeur = new SwFibonacci.SwFibonacci().Fibonacci(1);
            Assert.AreEqual(1, valeur);
        }

        [TestMethod]
        public void Fibonacci_Valeur_Deux_Retour_Un()
        {
            int valeur = new SwFibonacci.SwFibonacci().Fibonacci(2);
            Assert.AreEqual(1, valeur);
        }

        [TestMethod]
        public void Fibonacci_Valeur_Trois_Retour_Deux()
        {
            int valeur = new SwFibonacci.SwFibonacci().Fibonacci(3);
            Assert.AreEqual(2, valeur);
        }

        [TestMethod]
        public void Fibonacci_Valeur_Quatre_Retour_Trois()
        {
            int valeur = new SwFibonacci.SwFibonacci().Fibonacci(4);
            Assert.AreEqual(3, valeur);
        }

        [TestMethod]
        public void Fibonacci_Valeur_Cinq_Retour_Cinq()
        {
            int valeur = new SwFibonacci.SwFibonacci().Fibonacci(5);
            Assert.AreEqual(5, valeur);
        }

        [TestMethod]
        public void Fibonacci_Valeur_Six_Retour_Huit()
        {
            int valeur = new SwFibonacci.SwFibonacci().Fibonacci(6);
            Assert.AreEqual(8, valeur);
        }

        [TestMethod]
        public void Fibonacci_Valeur_MoinsCentUn_Retour_MoinsUn()
        {
            int valeur = new SwFibonacci.SwFibonacci().Fibonacci(-101);
            Assert.AreEqual(-1, valeur);
        }

        [TestMethod]
        public void Fibonacci_Valeur_Mille_Retour_MoinsUn()
        {
            int valeur = new SwFibonacci.SwFibonacci().Fibonacci(1000);
            Assert.AreEqual(-1, valeur);
        }
    }
}
