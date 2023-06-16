using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04oszczednosci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal kwotaPoczatkowa;
            decimal oprocentowanie;
            int liczbaMiesiecy;

            Console.Write("Podaj kwotę początkową: ");
            while (!decimal.TryParse(Console.ReadLine(), out kwotaPoczatkowa) || kwotaPoczatkowa < 0)
            {
                Console.WriteLine("Nieprawidłowa kwota. Podaj poprawną wartość.");
                Console.Write("Podaj kwotę początkową: ");
            }

            Console.Write("Podaj oprocentowanie w skali roku: ");
            while (!decimal.TryParse(Console.ReadLine(), out oprocentowanie) || oprocentowanie < 0)
            {
                Console.WriteLine("Nieprawidłowe oprocentowanie. Podaj poprawną wartość.");
                Console.Write("Podaj oprocentowanie w skali roku: ");
            }

            Console.Write("Podaj liczbę miesięcy oszczędzania: ");
            while (!int.TryParse(Console.ReadLine(), out liczbaMiesiecy) || liczbaMiesiecy < 0)
            {
                Console.WriteLine("Nieprawidłowa liczba miesięcy. Podaj poprawną wartość.");
                Console.Write("Podaj liczbę miesięcy oszczędzania: ");
            }

            decimal oprocentowanieMiesieczne = oprocentowanie / 12 / 100;
            decimal kwotaZarobiona1 = kwotaPoczatkowa * (1 + oprocentowanieMiesieczne) * liczbaMiesiecy;
            decimal kwotaZarobiona2 = kwotaPoczatkowa * (decimal)Math.Pow(1 + 1.0 / (12 * 100), liczbaMiesiecy);

            decimal podatekBelki = 0.19m * (kwotaZarobiona2 - kwotaPoczatkowa); // Stawka podatku Belki wynosi 19%
            decimal kwotaZarobionaPoPodatku = kwotaZarobiona2 - podatekBelki;

            Console.WriteLine("Kwota zarobiona (metoda 1): " + kwotaZarobiona1);
            Console.WriteLine("Kwota zarobiona (metoda 2): " + kwotaZarobiona2);
            Console.WriteLine("Kwota zarobiona po opodatkowaniu: " + kwotaZarobionaPoPodatku);
            Console.ReadKey();
        }
       
        
    }
}
