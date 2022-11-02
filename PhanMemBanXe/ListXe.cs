using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBanXe
{
    internal class ListXe
    {
            private List<Xe> listXe = new List<Xe>();
            private NguoiChoThue nguoiChu;

            public void themXe()
            {
                Xe xe = new Xe();
                xe.themXe(nguoiChu);
                listXe.Add(xe);

            }
        /* public void dataTest()
         {
             listXe.Add(new Xe(20110686, "Hoang Tran Nguyen", 17, 11, 2002, "quan 9,TP Thu Duc", 7, 2020, "CLC"));
             listXe.Add(new Xe(20110886, "Hoang Cong Nguyen", 18, 12, 2002, "quan 8,TP Thu Duc", 10, 2021, "CLC"));
             listXe.Add(new Xe(20110986, "Hoang Chien Nguyen", 19, 10, 2012, "quan 1,TP Thu Duc", 3, 2023, "Dai tra"));
             listXe.Add(new Xe(19133019, "Vo Thanh Dat", 05, 06, 2001, "Tp Thu Duc", 7.5, 2019, "Dai tra"));
             listXe.Add(new Xe(19133027, "Nguyen Pham Duy Khiem", 26, 02, 2001, "Tp Thu Duc", 6.5, 2019, "CLC"));
         }*/
       /* (string tenXe, string mau, int soCho, string bienKiemSoat, int soKm, int tinhTrangXe, int namLangBanh, NguoiChoThue chuXe)*/
            public void hienXe()
            {
                int i = 1;
                Console.WriteLine("{0, -10} {1, -26} {2, -12} {3, -27} {4, -10} {5, -15} {6,-10}",
                "Ten xe", "Mau", "SoCho", "Bien Kiem Soat", "Nam lan banh", "Chu xe","Tinh trang xe");
                foreach (Xe xe in listXe)
                {
                    Console.Write("{0,-2}.", i);
                    xe.inThongTin();
                    Console.WriteLine();
                    ++i;
                }
            }
            public Xe laySinhVien(int a)
            {
                Xe selectXe = new Xe();
                int i = 1;
                foreach (Xe xe in listXe)
                {
                    if (i == a)
                    {
                        selectXe = xe;
                        return selectXe;
                    }
                    ++i;
                }
                return null;
            }

    }
}
