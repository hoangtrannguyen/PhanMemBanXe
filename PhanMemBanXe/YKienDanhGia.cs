using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBanXe
{
    internal class YKienDanhGia
    {
        private string cMNDKhachHang;
        private string cMNDChuXe;
        private string soKiemSoatXe;
        private int soSao;
        private string noiDung;

        public string CMNDKhachHang { get { return cMNDKhachHang; } set { cMNDKhachHang = value; } }    
        public string CMNDChuXe { get { return cMNDChuXe; } set { cMNDChuXe = value; } }
        public int SoSao { get { return soSao; } set { soSao = value; } }

        public string NoiDung { get { return noiDung; } set { noiDung = value; } }

        public string SoKiemSoatXe { get { return soKiemSoatXe; } set { SoKiemSoatXe = value; } }

        public void themYKien(string IDChu,string IDKhach,string soKiemSoatXe)
        {
            cMNDChuXe = IDChu;
            cMNDKhachHang = IDKhach;
            SoKiemSoatXe = soKiemSoatXe ;
            Console.WriteLine("Nhap so sao: 1 2 3 4 5");
            soSao = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap noi dung ");
            noiDung = Console.ReadLine();
        }
        public void showYKien()
        {
            Console.WriteLine("==============");
            Console.WriteLine("So kiem soat xe : {0} ",SoKiemSoatXe);
            Console.WriteLine("So CMND chu : {0}",CMNDChuXe); 
            Console.WriteLine("So sao :",SoSao); 
            Console.WriteLine("Danh gia :",NoiDung); 
            Console.WriteLine("Nguoi danh gia :",CMNDKhachHang); 
            Console.WriteLine("==============");
        }
    }
}
