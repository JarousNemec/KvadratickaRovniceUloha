using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvadratickaRovniceUloha
{
    public class CalculatorMethods
    {
        public static double[] SolveEquationWhenDiscriminantIsBiggerThanZero(double D, double b, double a)
        {
            return new double[] { (-b + Math.Sqrt(D)) / (2 * a), (-b - Math.Sqrt(D)) / (2 * a) };
        }
        public static double SolveEquationWhenDiscriminantIsZero(double a, double b)
        {
            return (-b / (2 * a));
        }
        public static double CalculateDiscriminant(double a, double b, double c)
        {
            return (b * b) - (4 * a * c);
        }
    }
}
