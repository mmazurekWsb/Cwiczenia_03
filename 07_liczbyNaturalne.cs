using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_liczbyNaturalne
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                int n;

                Console.Write("Podaj liczbę n: ");
                while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
                {
                    Console.WriteLine("Nieprawidłowa wartość n. Podaj poprawną wartość.");
                    Console.Write("Podaj liczbę n: ");
                
                }

                Console.WriteLine($"Pary liczb naturalnych o sumie {n}:");
                ParyLiczb(n);


            Console.ReadKey();
        }

            static void ParyLiczb(int n)
            {
                for (int i = 1; i <= n / 2; i++)
                {
                    int j = n - i;
                    Console.WriteLine($"({i}, {j})");
                }
            }
        

    }
}

