using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_czySilnia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.Write("Podaj liczbę x: ");
            while (!int.TryParse(Console.ReadLine(), out x) || x < 0)
            {
                Console.WriteLine("Nieprawidłowa wartość x. Podaj poprawną wartość.");
                Console.Write("Podaj liczbę x: ");
            }

            int n = SzukajSilnia(x);

            if (n != -1)
            {
                Console.WriteLine($"Liczba {x} jest silnią liczby {n}.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Liczba {x} nie jest silnią żadnej liczby.");
                Console.ReadKey();
            }
        }

        static int SzukajSilnia(int x)
        {
            int n = 0;
            int silnia = 1;

            while (silnia <= x)
            {
                n++;
                silnia *= n;

                if (silnia == x)
                {
                    return n;
                }
            }

            return -1;
        }
    }
}
    

