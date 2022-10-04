using System;

namespace Lesson11_Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinhVienService service = new SinhVienService();
            
            while (true)
            {
                Console.WriteLine("Nhap:");
                Console.WriteLine("\t1. Nhap danh sach sinh vien");
                Console.WriteLine("\t2. Xuat thong tin danh sach sinh vien");
                Console.WriteLine("\t3. Xuat danh sach sinh vien co hoc luc gioi");
                Console.WriteLine("\t4. Sap xep danh sach sinh vien theo diem");
                Console.WriteLine("\t5. Thoat");

                int chon = int.Parse(Console.ReadLine());

                if (chon == 5)
                {
                    break;
                }

                switch (chon)
                {
                    case 1:
                        Console.WriteLine("Nhap danh sach sinh vien");
                        service.themDSSV();
                        break;
                    case 2:
                        Console.WriteLine("Xuat thong tin danh sach sinh vien");
                        service.xuatDSSV();
                        break;
                    case 3:
                        Console.WriteLine("Xuat danh sach sinh vien co hoc luc gioi");
                        service.xuatDSSVGioi();
                        break;
                    case 4:
                        Console.WriteLine("Sap xep danh sach sinh vien theo diem");
                        break;
                    default:
                        Console.WriteLine("Nhap sai.");
                        break;
                }
            }
        }
    }
}
