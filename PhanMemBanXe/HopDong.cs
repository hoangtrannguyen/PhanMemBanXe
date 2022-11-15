using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBanXe
{
    internal class HopDong
    {
        private string cMNDChuXe;
        private string cMNDNguoiThue;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private string mucDich;
        private int soTien;

        public HopDong()
        {
        }

        public string CMNDChuXe { get { return cMNDChuXe; } set { cMNDChuXe = value; } }
        public string CMNDNguoiThue { get { return cMNDNguoiThue; } set { cMNDNguoiThue = value; } }
        public DateTime NgayBatDau { get { return ngayBatDau; } set { ngayBatDau = value; } }
        public DateTime NgayKetThuc { get { return ngayKetThuc; } set { ngayKetThuc = value;  } }
        public int SoTien { get { return soTien; } set { soTien = value; } }
        public string MucDich { get { return mucDich; } set { mucDich = value; } }

        public HopDong(string cMNDChuXe, string cMNDNguoiThue, DateTime ngayBatDau, DateTime ngayKetThuc, string mucDich, int soTien)
        {
            CMNDChuXe = cMNDChuXe;
            CMNDNguoiThue = cMNDNguoiThue;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            MucDich = mucDich;
            SoTien = soTien;//Tong tien bang xe.giathue*thoigianhopdong
        }
        public HopDong TaoHopDong(Xe xe)
        {
            HopDong hopDong = new HopDong();
            Console.WriteLine("Nhap CMND chu xe :");
            hopDong.cMNDChuXe = Console.ReadLine();
            Console.WriteLine("Nhap CMND nguoi thue :");
            hopDong.cMNDNguoiThue = Console.ReadLine();
            Console.WriteLine("Nhap muc dich :");
            hopDong.mucDich = Console.ReadLine();   
            Console.WriteLine("Nhap ngay thue :");
            int tDay = Int32.Parse(Console.ReadLine());
            int tThang = Int32.Parse(Console.ReadLine());
            int tNam = Int32.Parse(Console.ReadLine());
            hopDong.ngayBatDau = new DateTime(tNam, tThang, tDay);
            Console.WriteLine("Nhap ngay tra :");
            int gDay = Int32.Parse(Console.ReadLine());
            int gThang = Int32.Parse(Console.ReadLine());
            int gNam = Int32.Parse(Console.ReadLine());
            hopDong.ngayKetThuc = new DateTime(gNam, gThang, gDay);
            TimeSpan Time = hopDong.ngayKetThuc - hopDong.ngayBatDau;
            int soNgayThue = Time.Days;
            hopDong.SoTien = xe.GiaThue * soNgayThue;
            Console.WriteLine("Gia thue : {0}",hopDong.SoTien);
            return hopDong;
        }
        public void ShowHopDong()
        {
            Console.WriteLine("=============");
            Console.WriteLine("CMND chu xe : {0}",cMNDChuXe);
            Console.WriteLine("CMND nguoi thue : {0}",cMNDNguoiThue);
            Console.WriteLine("Muc dich :",MucDich);
            Console.WriteLine("Ngay thue :",NgayBatDau.Date);
            Console.WriteLine("Ngay tra :",NgayKetThuc.Date);
            Console.WriteLine("Gia :",SoTien);
            Console.WriteLine("=============");
        }
    }
}
