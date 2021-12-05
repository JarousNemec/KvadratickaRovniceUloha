using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvadratickaRovniceUloha
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            Console.WriteLine("Zadaní rovnice: a*x*x + b*x + c = 0 \n \n");

            double a = GetNumberFromUser("a");
            double b = GetNumberFromUser("b");
            double c = GetNumberFromUser("c");

            Console.Clear();

            if (a == 0 && b == 0)
            {
                PrintResultAndExitProgram(new string[] { "Neřešitelné zadání" });
            }

            if (a == 0)
            {
                PrintResultAndExitProgram(new string[] { $"Linéární rovnice x = -c/b = {(-c / b)}" });
            }

            double D = CalculatorMethods.CalculateDiscriminant(a, b, c);
            Console.WriteLine("Diskriminant D je " + D);

            if (D < 0)
            {
                string text1 = "D < 0";
                string text2 = "Rovnice namá řešení v Reálných číslech";
                PrintResultAndExitProgram(new string[] { text1, text2 });
            }

            if (D == 0)
            {
                string text1 = "D = 0";
                string text2 = "Rovnice x = -b/2*a = " + CalculatorMethods.SolveEquationWhenDiscriminantIsZero(a, b);
                PrintResultAndExitProgram(new string[] { text1, text2 });
            }
            {
                string text1 = "D > 0";
                string text2 = "Rovnice má dvě řešení: ";
                double[] solution = CalculatorMethods.SolveEquationWhenDiscriminantIsBiggerThanZero(D, b, a);
                string text3 = $"1) x1 = (-b + Math.Sqrt(D)) / (2*a)) = {solution[0]}";
                string text4 = $"2) x2 = (-b - Math.Sqrt(D)) / (2*a)) = {solution[1]}";
                PrintResultAndExitProgram(new string[] { text1, text2, text3, text4 });
            }
        }

        private void PrintResultAndExitProgram(string[] text)
        {
            foreach (string s in text)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
            Environment.Exit(0);
        }
        private double GetNumberFromUser(string numChar)
        {
            double number;
            Console.WriteLine($"Zadejte číslo {numChar}:");
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine($"Zadejte číslo {numChar}:");
            }
            return number;
        }
    }
}
