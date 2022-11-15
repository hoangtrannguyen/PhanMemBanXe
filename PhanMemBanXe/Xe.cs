using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBanXe
{
    internal class Xe
    {
        private string loaiXe;
        private string hangXe;
        private int soCho;
        private string bienKiemSoatXe;
        private int namLanBanh;
        private int soKm;
        private string cMNDChuXe;
        private bool coBaoHiem;
        private int phanTramBaoHiem;
        private int giaThue;

        public Xe()
        {
        }

        public Xe(string loaiXe, string hangXe, int soCho, string bienKiemSoatXe, int namLanBanh, int soKm, string cMNDChuXe, bool coBaoHiem, int phanTramBaoHiem, int giaThue)
        {
            LoaiXe = loaiXe;
            HangXe = hangXe;
            SoCho = soCho;
            BienKiemSoatXe = bienKiemSoatXe;
            NamLanBanh = namLanBanh;
            SoKM = soKm;
            CMNDChuXe = cMNDChuXe;
            CoBaoHiem = coBaoHiem;
            PhanTramBaoHiem = phanTramBaoHiem;
            GiaThue = giaThue;
        }

        public string LoaiXe { get { return loaiXe; } set { loaiXe = value; } }
        public string HangXe { get { return hangXe; } set { hangXe = value; } }
        public int SoCho { get { return soCho; } set { soCho = value; } }        
        public string BienKiemSoatXe { get { return bienKiemSoatXe; } set { bienKiemSoatXe = value; } }
        public int NamLanBanh { get { return namLanBanh; } set { namLanBanh = value; } }
        public int SoKM { get { return soKm; } set { soKm = value; } }
        public string CMNDChuXe { get { return cMNDChuXe; } set { cMNDChuXe = value; } }
        public bool CoBaoHiem { get { return coBaoHiem; } set { coBaoHiem = value; } }
        public int PhanTramBaoHiem { get { return phanTramBaoHiem;} set { phanTramBaoHiem= value; } }
        public int GiaThue { get { return giaThue; } set { giaThue = value; } }

        public void ThongTinXe()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Loai xe: " + loaiXe);
            Console.WriteLine("Hang xe:" + hangXe);
            Console.WriteLine("So cho: " + soCho);
            Console.WriteLine("Bien kiem soat: " + bienKiemSoatXe);
            Console.WriteLine("Nam lan banh: " + namLanBanh);
            Console.WriteLine("So kilomet da chay: " + soKm);
            Console.WriteLine("CMND cua chu xe: " + cMNDChuXe);
            Console.WriteLine("Co bao hiem khong ?"+ coBaoHiem);
            Console.WriteLine("Phan tram bao hiem chi tra: " + phanTramBaoHiem);
            Console.WriteLine("Gia thue xe theo thang: " + giaThue);

        }

        public Xe TaoDoiTuongXe()
        {
            Console.WriteLine("Nhap loai xe: ");
            this.loaiXe = Console.ReadLine();
            Console.WriteLine("Nhap hang xe:");
            this.hangXe = Console.ReadLine();
            Console.WriteLine("Nhap so cho: ");
            this.soCho = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap bien kiem soat: ");
            this.bienKiemSoatXe = Console.ReadLine();
            Console.WriteLine("Nhap nam lan banh: ");
            this.namLanBanh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so kilomet da chay: ");
            this.soKm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap CMND cua chu xe: ");
            this.cMNDChuXe = Console.ReadLine();
            Console.WriteLine("Co bao hiem khong ?");
            this.coBaoHiem = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Nhap phan tram bao hiem chi tra: ");
            this.phanTramBaoHiem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap gia thue xe theo thang: ");
            this.giaThue = Convert.ToInt32(Console.ReadLine());

            //Tao 1 obj cua TaiKhoan tu du lieu tren
            Xe objXe = new Xe(loaiXe,hangXe,soCho,bienKiemSoatXe,namLanBanh,soKm,cMNDChuXe,coBaoHiem,phanTramBaoHiem,giaThue);
            //Tra ve obj đó
            return objXe;
        }   
    }
}
