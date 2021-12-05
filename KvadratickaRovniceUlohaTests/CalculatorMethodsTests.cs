using KvadratickaRovniceUloha;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvadratickaRovniceUloha.Tests
{
    [TestClass()]
    public class CalculatorMethodsTests
    {
        [TestMethod()]
        public void SolveEquationWhenDiscriminantIsBiggerThanZeroTest()
        {
            double a = 2;
            double b = 9;
            double D = 49;
            double[] solution = CalculatorMethods.SolveEquationWhenDiscriminantIsBiggerThanZero(D, b, a);
            Assert.AreEqual(solution[0], -0.5);
            Assert.AreEqual(solution[1], -4);
        }
        [TestMethod()]
        public void CalculateDiscriminant()
        {
            double D = CalculatorMethods.CalculateDiscriminant(2, 4, 2);
            Assert.AreEqual(D, 0);
        }
        [TestMethod()]
        public void SolveEquationWhenDiscriminantIsZero()
        {
            double result = CalculatorMethods.SolveEquationWhenDiscriminantIsZero(2, 4);
            Assert.AreEqual(result, -1);
        }
    }
}