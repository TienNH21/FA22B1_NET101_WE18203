using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11_Lab5
{
    internal class SinhVienBiz : SinhVienPoly
    {
        private double marketing;
        private double sales;

        public SinhVienBiz()
        {
        }

        public SinhVienBiz(double marketing, double sales, string hoTen, string nganh)
            : base(hoTen, nganh)
        {
            this.marketing = marketing;
            this.sales = sales;
        }

        public double Marketing { get => marketing; set => marketing = value; }
        public double Sales { get => sales; set => sales = value; }
        public new double getDiem()
        {
            return (this.marketing * 2 + this.sales) / 3;
        }
    }
}
