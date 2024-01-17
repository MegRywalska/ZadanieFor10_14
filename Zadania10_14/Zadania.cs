using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania10_14
{
    internal class Zadania
    {

        public static void Zadanie10()
        {
            int liczbaLiczbPodzielnych = Convert.ToInt32(Console.ReadLine());

            for (int i = 7; i <= liczbaLiczbPodzielnych; i++)
            {
                if (i % 7 == 0) Console.WriteLine(i);
            }
        }
        public static void Zadanie11()
        {
            Console.WriteLine("Podaj liczbe do której chcesz zsumować wszytkie liczby nieparzyste od zera: ");
            int liczba = Convert.ToInt32(Console.ReadLine());

            int suma = 0;

            for (int i = 0; i <= liczba; i++) {

                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                    suma += i;
                }
            }

            Console.WriteLine(suma);
        }

        public static void Zadanie12()
        {
            Console.WriteLine("Podaj liczbe rzedow: ");
            int iloscRzedow = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= iloscRzedow; i++)
            {
                int liczba = i;

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(liczba + " ");
                    liczba += i;
                }
                Console.WriteLine();
            } 
        }

        public static void Zadanie13()
        {
            Console.WriteLine("Podaj wysokosc trojkata prostokatnego: ");
            int h = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= h ; i++)
            {
                int liczbaSpacji = h - 1;

                for (int j = 0; j <= h - 1 ; j++)
                {
                    if (j == h - i)
                        Console.Write("x");
                    else if (i == h)
                        Console.Write("x");
                    else if (j == h - 1)
                        Console.Write("x");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine("");
            }
        }

        public static void Zadanie14()
        {
            Console.WriteLine("Podaj dolny zakres przedzialu: ");
            int min = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Podaj gorny zakres przedzialu: ");
            int max = Convert.ToInt32(Console.ReadLine());

            for (int a = min; a <= max; a++)
            {
                for (int b = a + 1; b <= max; b++)
                {
                    double c = Math.Sqrt(a * a + b * b);

                    if (c % 1 == 0 && c <= max)
                    {
                        Console.WriteLine("{0}, {1}, {2}", a, b, (int)c);
                    }
                }
            }

        }

    }
}
