using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11_Lab5
{
    internal class SinhVienIT : SinhVienPoly
    {
        private double java;
        private double html;
        private double css;

        public SinhVienIT()
        {
        }

        public SinhVienIT(double java, double html, double css, string hoten, string nganh)
            : base(hoten, nganh)
        {
            this.java = java;
            this.html = html;
            this.css = css;
        }

        public double Java { get => java; set => java = value; }
        public double Html { get => html; set => html = value; }
        public double Css { get => css; set => css = value; }

        public new double getDiem()
        {
            return (this.java * 2 + this.html + this.css) / 4;
        }
    }
}
