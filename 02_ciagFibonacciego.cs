using System;

public class Fibonacciego
{ 
    public static void Main(string[] args)
    {

        int n ; // Liczba elementów ciągu do wygenerowania
        Console.WriteLine("Podaj liczbę ile elementów ciągu chcesz obliczyć ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Ciąg Fibonacciego: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write(ciag(i) + " ");
        }
        Console.ReadLine();
    }
    public static int ciag(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return ciag(n - 1) + ciag(n - 2);
        }
    }
}
