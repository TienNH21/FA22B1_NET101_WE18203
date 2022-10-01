using System;
using System.Data;

namespace Lesson4_Condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            demoSwitch();
        }

        static void ktraSoDuong()
        {
            Console.WriteLine("Nhap 1 so nguyen: ");
            String s = Console.ReadLine();
            int i = int.Parse(s);

            if (i > 0)
            {
                Console.WriteLine(i + " la so duong");
            } else if (i == 0)
            {
                Console.WriteLine(i + "  = 0");
            } else
            {
                Console.WriteLine(i + " la so am");
            }
        }

        static void ptbac2()
        {
            int a;
            int b;
            int c;
            Console.WriteLine("nhapbien a");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                // Nếu a == 0 thì pt trở thành pt bậc 1: bx + c = 0
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phuong trinh vo so nghiem");
                    }
                    else
                    {
                        Console.WriteLine("PT vo nghiem");
                    }
                }
                else
                {
                    float x = -((float)c) / b;
                    Console.WriteLine("PT co 1 nghiem: " + x);
                }
            }
            else
            {
                // Neu a != 0, pt bac 2
                float delta = (float)b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("PT vo nghiem");
                }
                else if (delta == 0)
                {
                    float x = (float)-b / (2 * a);
                    Console.WriteLine("PT co nghiem kep: " + x);
                }
                else
                {
                    double sqrtDelta = (double)delta;
                    double x1 = ((float)-b + Math.Sqrt(sqrtDelta)) / (2 * a);
                    double x2 = ((float)-b - Math.Sqrt(sqrtDelta)) / (2 * a);
                    //...
                }
            }
        }

        static void demoSwitch()
        {
            int i = 1;
            switch(i)
            {
                case 0:
                    Console.WriteLine("Khong");
                    break;
                case 1:
                    Console.WriteLine("Mot");
                    break;
                case 2:
                    Console.WriteLine("Hai");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
        }
    }
}
