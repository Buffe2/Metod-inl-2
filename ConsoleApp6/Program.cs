using System;
namespace Metod_inl_2
{
    class Program
    {
        static int största(int tal1, int tal2)
        {
            if (tal1 < tal2)
            {
                return tal2;
            }

            else if (tal1 > tal2)
            {
                return tal1;
            }

            else
            {
                return (tal1 + tal2)    /2;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in 2 heltal");
            Console.WriteLine("Tal 1");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tal 2");
            int y = Convert.ToInt32(Console.ReadLine());
            int summa = största(x, y);
            Console.WriteLine("Det största talet är " + summa);
        }
    }
}


