using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _05liczbae
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            int n;

            Console.Write("Podaj wartość x: ");
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Nieprawidłowa wartość x. Podaj poprawną wartość.");
                Console.Write("Podaj wartość x: ");
            }

            Console.Write("Podaj liczbę wyrazów n: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("Nieprawidłowa liczba wyrazów n. Podaj poprawną wartość.");
                Console.Write("Podaj liczbę wyrazów n: ");
            }

            double result = ObliczWykladnik(x, n);

            Console.WriteLine("Szacowana wartość e^x: " + result);
            Console.ReadKey();
        }

        static double ObliczWykladnik(double x, int n)
        {
            double sum = 1.0; // Pierwszy wyraz szeregu to 1.0

            for (int i = 1; i <= n; i++)
            {
                double wyraz = Math.Pow(x, i) / Silnia(i);
                sum += wyraz;
            }

            return sum;
        }

        static double Silnia(int pom)
        {
            if (pom == 0)
                return 1;

            double result = 1;

            for (int i = 1; i <= pom; i++)
            {
                result *= i;
            }

            return result;
        }
    }

}
