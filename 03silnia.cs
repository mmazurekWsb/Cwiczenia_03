using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03silnia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, k;

            do
            {
                Console.Write("Podaj liczbę naturalną większą od 5: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 5);

            do
            {
                Console.Write("Podaj liczbę naturalną większą od 5: ");
            } while (!int.TryParse(Console.ReadLine(), out k) || k < 5);

            int m = Oblicz(n, k);

            Console.WriteLine("Wynik: " + m);
            Console.ReadKey();

        }
        static int Oblicz(int n, int k)
        {
            int nSilnia = ObliczSilnie(n);
            int kSilnia = ObliczSilnie(k);

            return (nSilnia - kSilnia) / kSilnia;
        }

        static int ObliczSilnie(int pomocnicza)
        {
            if (pomocnicza == 0)
                return 1;

            int silnia = 1;
            for (int i = 2; i <= pomocnicza; i++)
            {
                silnia *= i;
            }

            return silnia;
        }
    }
}
