using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11_Lab5
{
    internal class SinhVienService
    {
        private List<SinhVienPoly> listSv;

        public SinhVienService()
        {
            this.listSv = new List<SinhVienPoly>();

            SinhVienPoly sv1 = new SinhVienIT(8, 6, 6, "Ng Van A", "PTPM");
            SinhVienPoly sv2 = new SinhVienBiz(7, 7, "Tran Thi B", "Digital");

            this.listSv.Add(sv1);
            this.listSv.Add(sv2);
        }
    }
}
