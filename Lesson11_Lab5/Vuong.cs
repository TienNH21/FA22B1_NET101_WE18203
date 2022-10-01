using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11_Lab5
{
    internal class Vuong : ChuNhat
    {
        public Vuong()
        {
        }

        public Vuong(double canh) : base(canh, canh)
        {
        }

        public new void xuat()
        {
            Console.WriteLine(this.Rong + "|" + this.getChuVi() + "|" + this.getDienTich());
        }
    }
}
