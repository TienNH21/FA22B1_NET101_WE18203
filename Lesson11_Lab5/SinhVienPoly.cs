using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11_Lab5
{
    internal class SinhVienPoly
    {
        private String hoTen;
        private String nganh;

        public SinhVienPoly()
        {
        }

        public SinhVienPoly(string hoTen, string nganh)
        {
            this.hoTen = hoTen;
            this.nganh = nganh;
        }

        public string Nganh { get => nganh; set => nganh = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }

        public double getDiem()
        {
            return 0;
        }

        public string getHocLuc()
        {
            if (this.getDiem() < 5)
            {
                return "Hoc luc Yeu";
            } else if (this.getDiem() < 6.5)
            {
                return "Hoc luc Trung binh";
            }
            else if (this.getDiem() < 7.5)
            {
                return "Hoc luc Kha";
            }
            else if (this.getDiem() < 9)
            {
                return "Hoc luc Gioi";
            }
            else
            {
                return "Hoc luc Xuat sac";
            }
        }

        public void xuat()
        {
            Console.WriteLine(this.hoTen + "|" + this.nganh + "|" + this.getHocLuc());
        }
    }
}
