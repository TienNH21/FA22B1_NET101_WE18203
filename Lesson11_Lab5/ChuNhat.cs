using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11_Lab5
{
    internal class ChuNhat
    {
        private double dai;
        private double rong;

        public ChuNhat()
        {
        }

        public ChuNhat(double dai, double rong)
        {
            this.dai = dai;
            this.rong = rong;
        }

        public double Dai { get => dai; set => dai = value; }
        public double Rong { get => rong; set => rong = value; }
        
        public double getChuVi()
        {
            return (this.dai + this.rong) * 2;
        }

        public double getDienTich()
        {
            return this.dai * this.rong;
        }

        public void xuat()
        {
            Console.WriteLine(this.dai + "|" + this.rong + "|" +
                this.getChuVi() + "|" + this.getDienTich());
        }
    }
}
