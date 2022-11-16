using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBanXe
{
    internal class ListXe
    {
        public ListXe()
        {

        }

        public List<Xe> listXe = new List<Xe>
        {
            //new Xe(LoaiXe,HangXe,SoCho,BienKiemsoat,namLanBanh,SoKM,cmndChuXe,BaoHiem,PhanTrmBaoHiem,GiaThue)
            new Xe("a","a",5,"1",2,1000,"1",true,5,1000000),
            new Xe("b","b",8,"2",2,500,"2",true,10,1500000),
            new Xe("c","c",15,"3",3,3000,"3",false,15,3000000),
            new Xe("d","d",20,"4",4,2000,"4",true,20,5000000),
            new Xe("e","e",20,"5",3,1500,"5",true,20,5000000),
        };


        public void ThemXe(Xe xe)
        {
            Xe objXe = new Xe();
            xe=objXe.TaoDoiTuongXe();
            listXe.Add(xe);

        }

        public void HienDanhSachXe()
        {
            foreach (Xe objXe in listXe)
            {
                objXe.ThongTinXe();
            }
        }
        public void XoaXe(string bienKiemSoatXe_in)
        {
            int count = 0;
            foreach (Xe xe in listXe.ToList())
            {
                if (xe.BienKiemSoatXe == bienKiemSoatXe_in)
                {
                    listXe.Remove(xe);
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Khong co tai khoan nay");
            }
            else
            {
                Console.WriteLine("Xoa tai khoan thanh cong");
            }
        }
        public void SuaThongTinXe(string bienKiemSoatXe_in)
        {

            foreach (Xe xe in listXe)
            {
                if (xe.BienKiemSoatXe == bienKiemSoatXe_in)
                {
                    Console.WriteLine("Nhap lai loai xe: ");
                    xe.LoaiXe=Console.ReadLine();
                    Console.WriteLine("Nhap lai hang xe:");
                    xe.HangXe = Console.ReadLine();
                    Console.WriteLine("Nhap lai so cho: ");
                    xe.SoCho = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap lai bien kiem soat: ");
                    xe.BienKiemSoatXe = Console.ReadLine();
                    Console.WriteLine("Nhap lai nam lan banh: ");
                    xe.NamLanBanh = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap lai so kilomet da chay: ");
                    xe.SoKM = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap lai CMND cua chu xe: ");
                    xe.CMNDChuXe = Console.ReadLine();
                    Console.WriteLine("Co bao hiem khong ?");
                    xe.CoBaoHiem = Convert.ToBoolean(Console.ReadLine());
                    Console.WriteLine("Nhap lai phan tram bao hiem chi tra: ");
                    xe.PhanTramBaoHiem = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap lai gia thue xe theo thang: ");
                    xe.GiaThue = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Khong co tai khoan nay");
                }
            }
        }
        public Xe ChonXe(int i)
        {
            Xe sltXe = new Xe();
            int j = 0;
            foreach (Xe lXe in listXe)
            {
                if (i == j) return lXe;
                else j++;
            }
            return sltXe;
        }
    }
}
