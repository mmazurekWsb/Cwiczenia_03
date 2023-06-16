using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01potegowanie
{
    internal class Program
    {
        
            static int Oblicz(int podstawa, int wykladnik)
            {
                int result = 1;

                for (int i = 0; i < wykladnik; i++)
                {
                    result *= podstawa;
                }

                return result;
            }

        static void Main(string[] args)
        {
            {
                Console.WriteLine("Podaj liczbę jako podstawę potęgi:");
                int podstawa = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Podaj liczbę jako wykładnik potęgi:");
                int wykladnik  = Convert.ToInt32(Console.ReadLine());

                int wynik = Oblicz(podstawa, wykladnik);
                Console.WriteLine($"Wynik potęgowania: {wynik}");

                Console.ReadKey();
            }
        }
    }
}
