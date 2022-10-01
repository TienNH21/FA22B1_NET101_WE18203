using System;

namespace Lesson6_Mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int[] a = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
            /* for(int i= 0; i<a.Length; i++)
            {
                for (int j = i +1; j<a.Length-1; j++)
                {
                    if (a[i] > a[j])
                    {
                        int t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
            } */
            int[] a = { 89, 54, 76, 2, 44, 1, 60 };
            Array.Sort(a);
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }

            Array.Reverse(a);
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }

        }
    }
}
