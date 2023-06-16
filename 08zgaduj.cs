using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_zgaduj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poczatek = 1;
            int koniec = 20;
            int srodek;
            bool odgadniete = false;

            Console.WriteLine("Pomyśl liczbę z zakresu od 1 do 20.");
            Console.WriteLine("Naciśnij dowolny klawisz, aby rozpocząć zgadywanie.");
            Console.ReadKey();

            while (!odgadniete)
            {
                srodek = (poczatek + koniec) / 2;

                Console.WriteLine($"Czy Twoja liczba to {srodek}? Odpowiedz: podaj liczbę ujemną jeśli jest mniejsza od szukanej, dodatnią jeśli jest wieksza od szukanej lub wpisz 0 jeśli zgadłam.");

                int odpowiedz = Convert.ToInt32(Console.ReadLine());

                if (odpowiedz < 0)
                {
                    koniec = srodek - 1;
                }
                else if (odpowiedz > 0)
                {
                    poczatek = srodek + 1;
                }
                else
                {
                    Console.WriteLine("Zgadłam liczbę!");
                    odgadniete = true;
                }
            }

            Console.ReadKey();
        }
    }
}
