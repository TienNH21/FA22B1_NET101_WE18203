using System;

namespace Lesson5_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            demo();
        }

        static void demo()
        {
            int i = 1;
            while (i <= 100)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        static void bai1()
        {
            int i = 25;
            while (i <= 50)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static void bai2()
        {
            int i = 30;
            while (i >= 10)
            {
                Console.WriteLine(i);
                i--;
            }
        }
        static void bai()
        {
            int i = 10;
            while (i <= 60)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

                i++;  
            }
        }
    }
}
