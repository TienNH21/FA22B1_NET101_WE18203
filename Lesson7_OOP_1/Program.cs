using System;

namespace Lesson7_OOP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Khởi tạo đối tượng SinhVien bằng cách dùng từ khóa new, gọi đến hàm khởi tạo của class SinhVien
             * sau đó lưu đối tượng mới tạo vào biến sv có kiểu dữ liệu SinhVien
             */
            SinhVien sv = new SinhVien("Ng Van A", "PH12345", "PTPM");
            Console.WriteLine("Hello, " + sv.HoTen);
        }
    }
}
