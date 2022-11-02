using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBanXe
{
    internal class TaiKhoan
    {
        protected string tenDN;
        protected string pass;
        protected string ten;
        protected int id;
        protected int sdt;
        protected bool role;

        public TaiKhoan(string tenDN, string pass, string ten, int id, int sdt, bool role)
        {
            this.tenDN = tenDN;
            this.pass = pass; this.ten = ten;
            this.id = id;
            this.sdt = sdt;
            this.role = role;
        }

        public void taoTK()
        {
            Console.WriteLine("Nhap ten nguoi dung :");
            ten = Console.ReadLine();
            Console.WriteLine("Nhap so CCCD :");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten SDT :");
            sdt = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten dang nhap :");
            tenDN = Console.ReadLine();
            Console.WriteLine("Nhap mat khau :");
            pass = Console.ReadLine();
            Console.WriteLine("Nhap role :");
            role = bool.Parse(Console.ReadLine());
        }
        public void danhSach() { }
        public void doiMk()
        {
            string mkc;
            Console.WriteLine("Nhap vao mat khau cu: ");
            mkc = Console.ReadLine();
            if (mkc == pass)
            {
                Console.WriteLine("Ban da nhap dung mat khau cu, gio ban hay nhap mat khau moi!");
                pass = Console.ReadLine();
                Console.WriteLine("Doi mat khau thanh cong");
            }
            else
            {
                Console.WriteLine("Ban da nhap sai mat khau cu, vui long nhap lai!");
                Console.ReadKey();
                doiMk();
            }
        }
        public void suaTt()
        {
        }
        public void xoaTk() { }
        public void thongTin() { }
    }
}