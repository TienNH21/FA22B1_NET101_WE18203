using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Lesson11_Lab5
{
    internal class SinhVienService
    {
        private List<SinhVienPoly> listSv;

        public SinhVienService()
        {
            // Khởi tạo đối tượng List
            this.listSv = new List<SinhVienPoly>();

            // Khởi tạo & thêm 2 sinh viên ảo vào List
            SinhVienPoly sv1 = new SinhVienIT(8, 6, 6, "Ng Van A", "IT");
            SinhVienPoly sv2 = new SinhVienBiz(7, 7, "Tran Thi B", "BIZ");

            this.listSv.Add(sv1);
            this.listSv.Add(sv2);
        }

        public void themDSSV()
        {
            Console.WriteLine("Nhap so sinh vien: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Chon chuyen nganh (1-IT, 2-Biz): ");
                int cNganh = int.Parse(Console.ReadLine());

                if (cNganh != 1 && cNganh != 2)
                {
                    // Nguoi dung chon sai.
                    Console.WriteLine("Nhap sai");

                    continue;
                }

                // Nguoi dung chon 1 - IT hoac 2 - Biz
                Console.WriteLine("Nhap ten:");
                string ten = Console.ReadLine();

                SinhVienPoly sv;
                if (cNganh == 1)
                {
                    Console.WriteLine("Nhap vao diem Java - HTML - CSS:");
                    double java = double.Parse(Console.ReadLine());
                    double html = double.Parse(Console.ReadLine());
                    double css = double.Parse(Console.ReadLine());

                    sv = new SinhVienIT(java, html, css, ten, "IT");
                } else
                {
                    Console.WriteLine("Nhap vao diem Java - HTML - CSS:");
                    double sale = double.Parse(Console.ReadLine());
                    double marketing = double.Parse(Console.ReadLine());

                    sv = new SinhVienBiz(marketing, sale, ten, "BIZ");
                }

                this.listSv.Add(sv);
            }
        }

        public void xuatDSSV()
        {
            for (int i = 0; i < this.listSv.Count; i++)
            {
                SinhVienPoly sv = this.listSv[i];
                if (sv.Nganh.Equals("IT"))
                {
                    SinhVienIT svIT = (SinhVienIT) sv;
                    Console.WriteLine(svIT.HoTen + "|" + svIT.Nganh
                        + "|" + svIT.Java + "|" + svIT.Html
                        + "|" + svIT.Css);
                } else
                {
                    SinhVienBiz svBiz = (SinhVienBiz)sv;

                    Console.WriteLine(svBiz.HoTen + "|" + svBiz.Nganh
                        + "|" + svBiz.Marketing + "|" + svBiz.Sales);
                }
            }
        }

        public void xuatDSSVGioi()
        {
            for (int i = 0; i < this.listSv.Count; i++)
            {
                SinhVienPoly sv;
                if (this.listSv[i].Nganh.Equals("IT"))
                {
                    sv = (SinhVienIT)this.listSv[i];
                }
                else
                {
                    sv = (SinhVienBiz)this.listSv[i];
                }

                if (sv.getHocLuc() == "Hoc luc Gioi")
                {
                    sv.xuat();
                }
            }
        }
    }
}
