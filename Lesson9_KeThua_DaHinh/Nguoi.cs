using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9_KeThua_DaHinh
{
    public class Nguoi
    {
        private String ten;
        private String diaChi;
        private String email;
        private String sdt;

        public Nguoi()
        {
            //
        }

        public Nguoi(String ten, String diaChi, String email, String sdt)
        {
            this.ten = ten;
            this.diaChi = diaChi;
            this.email = email;
            this.sdt = sdt;
        }

        public String Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public string DiaChi
        {
            get { return diaChi;}
            set { diaChi = value; }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }

        public String Sdt
        {
            get { return sdt; }
            set
            {
                sdt = value;
            }
        }

        public void xuatThongTin()
        {
            Console.WriteLine(this.ten + "|" + this.diaChi + "|" +
                this.email + "|" + this.sdt);
        }
    }
}
