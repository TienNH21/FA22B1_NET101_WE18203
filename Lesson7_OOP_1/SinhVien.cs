using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7_OOP_1
{
    internal class SinhVien
    {
        private String hoTen;
        private String ma;
        private String chuyenNganh;

        public SinhVien()
        {

        }

        public String HoTen // Properties
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public SinhVien(String ten, String ma, String cNganh)
        {
            this.hoTen = ten;
            this.ma = ma;
            this.chuyenNganh = cNganh;
        }

        public void diHoc()
        {
            Console.WriteLine("Đi học");
        }
        public void diChoi()
        {
            Console.WriteLine("Đi chơi");
        }
        public void diHocLai()
        {
            Console.WriteLine("Đi học lại");
        }
    }
}
