using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBanXe
{
    internal class ListTaiKhoan 
    {
        public ListTaiKhoan()
        {

        }
        //Khoi tao list tk
        public List<TaiKhoan> listTaiKhoan = new List<TaiKhoan>
        {
            new TaiKhoan("a", "1", "a", 1, "123456789", "Chu Xe"),
            new TaiKhoan("b", "2", "b", 2, "123456789", "Chu Xe"),
            new TaiKhoan("c", "3", "c", 3, "123456789", "Chu Xe"),
            new TaiKhoan("d", "4", "d", 4, "123456789", "Chu Xe"),
            new TaiKhoan("e", "5", "e", 5, "123456789", "Chu Xe"), 
            new TaiKhoan("f", "6", "f", 6, "123456789", "Nguoi Thue"),
            new TaiKhoan("g", "7", "g", 7, "123456789", "Nguoi Thue"),
            new TaiKhoan("h", "8", "h", 8, "123456789", "Nguoi Thue"),
            new TaiKhoan("i", "9", "i", 9, "123456789", "Nguoi Thue"),
            new TaiKhoan("j", "10", "j", 10, "123456789", "Nguoi Thue")
        };




        //Ham them tai khoan nguoi cho thue vao list
        public void ThemTKNguoiChoThue(TaiKhoan objTK)
        {
            TaiKhoan tk = new TaiKhoan();
            objTK = tk.taoTKNguoiChoThue();
            listTaiKhoan.Add(objTK);
        }
        //Ham them tai khoan nguoi thue vao list
        public void ThemTKNguoiThue(TaiKhoan objTK)
        {
            TaiKhoan tk = new TaiKhoan();
            objTK = tk.taoTKNguoiThue();
            listTaiKhoan.Add(objTK);
        }
        //Ham them tai khoan nguoi thue vao list
        public void ThemTK(TaiKhoan objTK)
        {
            TaiKhoan tk = new TaiKhoan();
            objTK = tk.taoTK();
            listTaiKhoan.Add(objTK);
        }




        //Ham hien thi danh sach tai khoan
        public void HienDanhSach()
        {
            foreach(TaiKhoan taiKhoan in listTaiKhoan)
            {
                taiKhoan.ThongTinTaiKhoan();
            }
        }
        //Ham hien danh sach nguoi cho thue
        public List<TaiKhoan> listTaiKhoanNguoiChoThue = new List<TaiKhoan>();
        public void HienDanhSachNguoiChoThue()
        {
            foreach (TaiKhoan taiKhoan in listTaiKhoan)
            {
                if(taiKhoan.Role == "Chu Xe")
                {
                    listTaiKhoanNguoiChoThue.Add(taiKhoan);
                }
            }
            foreach(TaiKhoan taiKhoan1 in listTaiKhoanNguoiChoThue)
            {
                taiKhoan1.ThongTinTaiKhoan();
            }
        }
        //Ham hien danh sach nguoi thue
        public List<TaiKhoan> listTaiKhoanNguoiThue = new List<TaiKhoan>();
        public void HienDanhSachNguoiThue()
        {
            foreach (TaiKhoan taiKhoan in listTaiKhoan)
            {
                if (taiKhoan.Role == "Nguoi Thue")
                {
                    listTaiKhoanNguoiThue.Add(taiKhoan);
                }
            }
            foreach (TaiKhoan taiKhoan1 in listTaiKhoanNguoiThue)
            {
                taiKhoan1.ThongTinTaiKhoan();
            }
        }






        public bool CheckTK(string username, string password)
        {
            foreach (TaiKhoan tk in listTaiKhoan)
            {
                
                if ((tk.TenDN == username) && (tk.Pass == password))
                {
                    return true;
                }    
            }
            return false;
        }
        public string GetRole(string username, string password)
        {
            foreach (TaiKhoan tk in listTaiKhoan)
            {
                if (tk.TenDN == username && tk.Pass == password)
                {
                    return tk.Role;
                }
            }
            return "";
        }
        public string DangNhap()
        {
            Console.WriteLine("Nhap ten dang nhap :");
            string tenDN_in = Console.ReadLine();
            Console.WriteLine("Nhap mat khau :");
            string pass_in = Console.ReadLine();
            int count = 0;
            bool check = CheckTK(tenDN_in, pass_in);
            
            if (check)
            {
                count++;
            }            

            if (count!=0)
            {
                Console.WriteLine("Dang nhap thanh cong");
            }
            else
            {
                Console.WriteLine("Dang nhap that bai, vui long nhap lai");
            }
            string role = GetRole(tenDN_in, pass_in);
            return role;
        }



        public void XoaTaiKhoan(int CMND)
        {
            int count = 0;
            foreach (TaiKhoan tk in listTaiKhoan.ToList())
            {
                if (tk.ID == CMND)
                {
                    listTaiKhoan.Remove(tk);
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
        public void SuaTaiKhoan(int CMND)
        {

            foreach (TaiKhoan tk in listTaiKhoan)
            {
                if (tk.ID == CMND)
                {
                    Console.WriteLine("Nhap lai ten nguoi dung :");
                    tk.Ten = Console.ReadLine();
                    Console.WriteLine("Nhap lai so CCCD :");
                    tk.ID = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap lai ten SDT :");
                    tk.Sdt = Console.ReadLine();
                    Console.WriteLine("Nhap lai ten dang nhap :");
                    tk.TenDN = Console.ReadLine();
                    Console.WriteLine("Nhap lai mat khau :");
                    tk.Pass = Console.ReadLine();
                    Console.WriteLine("Nhap lai role :");
                    tk.Role = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Khong co tai khoan nay");
                }
            }
        }

    }
}
