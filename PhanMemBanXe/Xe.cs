using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBanXe
{
    internal class Xe
    {
        private string tenXe;
        private string mau;
        private int soCho;
        private string bienKiemSoat;
        private int soKm;
        private int tinhTrangXe;
        private int namLanBanh;
        private NguoiChoThue chuXe;

        public Xe(string tenXe, string mau, int soCho, string bienKiemSoat, int soKm, int tinhTrangXe, int namLangBanh, NguoiChoThue chuXe)
        {
            this.tenXe = tenXe;
            this.mau = mau;
            this.soCho = soCho;
            this.bienKiemSoat = bienKiemSoat;
            this.soKm = soKm;
            this.tinhTrangXe = tinhTrangXe;
            this.namLanBanh = namLanBanh;
            this.chuXe = chuXe;
        }


        public void themXe(NguoiChoThue chuXe)
        {
            Console.WriteLine("Nhap ten xe");
            tenXe = Console.ReadLine();
            Console.WriteLine("Nhap mau xe");
            mau = Console.ReadLine();
            Console.WriteLine("Nhap so cho");
            soCho = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so KM cua xe");
            soKm = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam lan banh");
            namLanBanh = Int32.Parse(Console.ReadLine());
            this.chuXe = chuXe;
            tinhTrangXe = 0;
        }
        public void xoaXe()
        {

        }
        public void suaXe()
        {

        }
    }
}
