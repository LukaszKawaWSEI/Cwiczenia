using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prostokat
{
    class Program
    {
        static void Prostokat(int n, int m)
        {
            // n-krotnie wypisz gwiazdkę
            // na koniec postaw ENTER
            for (int i = 1; i <= n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            // wykonaj m-2 razy
            for (int j = 1; j <= m - 2; j++)
            {
                Console.Write("*");
                for (int i = 1; i <= n - 2; i++)
                {
                    Console.Write(".");
                }
                Console.WriteLine("*");
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

        }

        static void LiniaGwiazdek(int k)
        {
            for (int i = 1; i <= k; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        static void GwiazdkaSpacjeGwiazdka(int k)
        {
            Console.Write("*");
            for (int i = 1; i <= k - 2; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine("*");
        }

        static void Prostokat1(int n, int m)
        {
            LiniaGwiazdek(n);
            for (int j = 1; j <= m - 2; j++)
                GwiazdkaSpacjeGwiazdka(n);
            LiniaGwiazdek(n);
        }


        static void Main(string[] args)
        {
            Prostokat1(15, 7);
        }
    }
}
