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

        public void taoTK() {
            Console.Write("Nhap ten nguoi dung");
            Console.Write("Nhap tuoi");
            Console.Write("Nhap so CCCD");
            Console.Write("Nhap ten nguoi dung");
            Console.Write("Nhap ten nguoi dung");
            Console.Write("Nhap ten nguoi dung");
        }
        public void danhSach() { }
        public void doiMk() { }
        public void suaTt() { }
        public void xoaTk() { }
        public void thongTin() { }
    }
}
