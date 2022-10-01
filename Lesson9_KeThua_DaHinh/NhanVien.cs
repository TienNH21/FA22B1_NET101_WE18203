using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9_KeThua_DaHinh
{
    public class NhanVien : Nguoi
    {
        private String bangCap;

        public NhanVien()
        {
            //
        }

        public NhanVien(String bangCap, String ten, String diaChi, String email, String sdt)
            : base(ten, diaChi, email, sdt)
        {
            this.bangCap = bangCap;

            /*
             * Lớp con được thừa hưởng các thuộc tính & phương thức KHÔNG PRIVATE của lớp cha.
             */
        }

        public String BangCap
        {
            get { return this.bangCap; }
            set { this.bangCap = value; }
        }

        public new void xuatThongTin()
        {
            base.xuatThongTin();
            Console.WriteLine(this.bangCap);
        }

        public void xuatThongTin(String trangThaiHD)
        {
            Console.WriteLine(trangThaiHD);
        }
    }
}
