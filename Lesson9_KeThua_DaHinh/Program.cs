using System;

namespace Lesson9_KeThua_DaHinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NhanVien nv = new NhanVien("CN", "Ng Van A", "HN", "abc@gmail.com", "0123");
            nv.xuatThongTin();
        }
    }
}
