using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBanXe
{
    internal class TaiKhoan
    {
        private string tenDN;
        private string pass;
        private string ten;
        private int id;//cMND
        private string sdt;
        private string role;



        public string TenDN { get { return tenDN; } set { tenDN = value; } }
        public string Pass { get { return pass; } set { pass = value; } }
        public string Ten { get { return ten; } set { ten = value; } }
        public int ID { get { return id; } set { id = value; } }
        public string Sdt { get { return sdt; } set { sdt = value; } }

        public string Role { get { return role; } set { role = value; } }
        public TaiKhoan()
        {
        }

        public TaiKhoan(string tenDN, string pass, string ten, int id, string sdt, string role)
        {
            TenDN = tenDN;
            Pass = pass;
            Ten = ten;
            ID = id;
            Sdt = sdt;
            Role = role;            
        }

        //=========================================Tao tai khoan=================
        public TaiKhoan taoTK()
        {
            Console.WriteLine("Nhap ten nguoi dung :");
            this.ten = Console.ReadLine();
            Console.WriteLine("Nhap so CCCD :");
            this.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten SDT :");
            this.sdt = Console.ReadLine();
            Console.WriteLine("Nhap ten dang nhap :");
            this.tenDN = Console.ReadLine();
            Console.WriteLine("Nhap mat khau :");
            this.pass = Console.ReadLine();
            Console.WriteLine("Nhap role :");
            this.role = Console.ReadLine();
            //Tao 1 obj cua TaiKhoan tu du lieu tren
            TaiKhoan objTK=new TaiKhoan(tenDN,pass,ten,id,sdt,role);
            //Tra ve obj đó
            return objTK;
        }

        public TaiKhoan taoTKNguoiChoThue()
        {
            Console.WriteLine("Nhap ten nguoi dung :");
            this.ten = Console.ReadLine();
            Console.WriteLine("Nhap so CCCD :");
            this.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten SDT :");
            this.sdt = Console.ReadLine();
            Console.WriteLine("Nhap ten dang nhap :");
            this.tenDN = Console.ReadLine();
            Console.WriteLine("Nhap mat khau :");
            this.pass = Console.ReadLine();
            this.role = "Chu Xe";
            //Tao 1 obj cua TaiKhoan tu du lieu tren
            TaiKhoan objTK = new TaiKhoan(tenDN, pass, ten, id, sdt, role);
            //Tra ve obj đó
            return objTK;
        }
        public TaiKhoan taoTKNguoiThue()
        {
            Console.WriteLine("Nhap ten nguoi dung :");
            this.ten = Console.ReadLine();
            Console.WriteLine("Nhap so CCCD :");
            this.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten SDT :");
            this.sdt = Console.ReadLine();
            Console.WriteLine("Nhap ten dang nhap :");
            this.tenDN = Console.ReadLine();
            Console.WriteLine("Nhap mat khau :");
            this.pass = Console.ReadLine();
            this.role = "Nguoi Thue";
            //Tao 1 obj cua TaiKhoan tu du lieu tren
            TaiKhoan objTK = new TaiKhoan(tenDN, pass, ten, id, sdt, role);
            //Tra ve obj đó
            return objTK;
        }

        //=========================================Tao tai khoan=================

        public void ThongTinTaiKhoan() {
            Console.WriteLine("=========================");
            Console.WriteLine("Ten dang nhap: " + tenDN);
            Console.WriteLine("Mat khau: " + pass);
            Console.WriteLine("Ho va ten: " + ten);
            Console.WriteLine("CCCD: " + id);
            Console.WriteLine("So dien thoai: " + sdt);
            Console.WriteLine("Role: " + role);
        }
        
        
               
    }
}