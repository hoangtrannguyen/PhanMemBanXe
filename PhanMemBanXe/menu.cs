using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBanXe
{
    internal class Menu
    {
        ListTaiKhoan objlistTaiKhoan = new ListTaiKhoan();
        public ListXe objlistXe = new ListXe();
        ListHopDong objlistHopDong = new ListHopDong();
        ListYKien objlistYKien = new ListYKien();
        public void Menu1()
        {            
            bool test = true;
            while (test)
            {
                Console.Clear();
                Console.WriteLine("\nCHUONG TRINH QUAN LY THUE XE C#");
                Console.WriteLine("********************MENU********************");
                Console.WriteLine("** 1. Dang nhap                           **");
                Console.WriteLine("** 2. Tao tai khoan                       **");
                Console.WriteLine("** 3. Hien danh sach tai khoan            **");
                Console.WriteLine("** 4. Thoat                               **");
                Console.WriteLine("********************************************");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.Clear();
                        string role = objlistTaiKhoan.DangNhap();
                        switch (role)
                        {
                            case "Chu Xe":
                                MenuNguoiChoThue();
                                break;
                            case "Nguoi Thue":
                                MenuNguoiThue();
                                break;
                            default:
                                break;

                        }

                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        TaiKhoan tkNew = new TaiKhoan();
                        objlistTaiKhoan.ThemTK(tkNew);
                        break;
                    case 3:
                        Console.Clear();
                        objlistTaiKhoan.HienDanhSach();
                        Console.ReadKey();
                        break;
                    case 4:
                        test = false;
                        break;
                    default:
                        break;
                }
            }
        }
        public void MenuNguoiChoThue()
        {
            bool test = true;
            while (test)
            {
                Console.Clear();
                Console.WriteLine("\nCHUONG TRINH QUAN LY THUE XE C#");
                Console.WriteLine("********************MENU********************");
                Console.WriteLine("** 1. Hien danh sach nguoi cho thue       **");
                Console.WriteLine("** 2. Them tai khoan nguoi cho thue       **");
                Console.WriteLine("** 3. Xoa tai khoan nguoi cho thue        **");
                Console.WriteLine("** 4. Sua tai khoan nguoi cho thue        **");
                Console.WriteLine("** 5. Them xe cho thue                    **");
                Console.WriteLine("** 6. Xoa xe  cho thue                    **");
                Console.WriteLine("** 7. Sua xe  cho thue                    **");
                Console.WriteLine("** 8. Hien danh sach xe da cho thue       **");
                Console.WriteLine("** 9. Quay lai trang chu                  **");
                Console.WriteLine("** 10. Thoat                              **");
                Console.WriteLine("********************************************");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.Clear();
                        objlistTaiKhoan.HienDanhSachNguoiChoThue();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        TaiKhoan tkNew = new TaiKhoan();
                        objlistTaiKhoan.ThemTKNguoiChoThue(tkNew);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Id tai khoan muon xoa:");
                        int cmndXoa = Convert.ToInt32(Console.ReadLine());
                        objlistTaiKhoan.XoaTaiKhoan(cmndXoa);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Id tai khoan muon sua:");
                        int cmndSua = Convert.ToInt32(Console.ReadLine());
                        objlistTaiKhoan.SuaTaiKhoan(cmndSua);
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Xe xe = new Xe();
                        objlistXe.ThemXe(xe);
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Bien so xe muon xoa:");
                        string biensoXoa = Console.ReadLine();
                        objlistXe.XoaXe(biensoXoa);
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Bien so xe muon sua:");
                        string biensoSua = Console.ReadLine();
                        objlistXe.SuaThongTinXe(biensoSua);
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();
                        objlistXe.HienDanhSachXe();
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();
                        Menu1();
                        break;
                    case 10:
                        test = false;
                        break;
                    default:
                        test = false;
                        break;
                }
            }
        }
        public void MenuNguoiThue()
        {

            ListTaiKhoan objlistTaiKhoan = new ListTaiKhoan();
            bool test = true;
            while (test)
            {
                Console.Clear();
                Console.WriteLine("\nCHUONG TRINH QUAN LY THUE XE C#");
                Console.WriteLine("********************MENU********************");
                Console.WriteLine("** 1. Hien danh sach nguoi thue           **");
                Console.WriteLine("** 2. Tao tai khoan nguoi thue            **");
                Console.WriteLine("** 3. Hien danh sach tai khoan            **");
                Console.WriteLine("** 4. Them y kien                         **");
                Console.WriteLine("** 5. Hien thi y kien                     **");
                Console.WriteLine("** 6. Them hop dong                       **");
                Console.WriteLine("** 7. Hien thi hop dong                   **");                              
                Console.WriteLine("** 8. Thoat                               **");
                Console.WriteLine("********************************************");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.Clear();
                        objlistTaiKhoan.HienDanhSachNguoiThue();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        TaiKhoan tkNew = new TaiKhoan();
                        objlistTaiKhoan.ThemTKNguoiThue(tkNew);
                        break;
                    case 3:
                        Console.Clear();
                        objlistTaiKhoan.HienDanhSach();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        //objlistYKien.themYKien();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        objlistYKien.showYKien();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        objlistXe.HienDanhSachXe();
                        Console.WriteLine("Chon xe so : ");
                        int selectNum = Int32.Parse(Console.ReadLine());
                        Xe selectXe = objlistXe.ChonXe(selectNum);
                        objlistHopDong.themHopDong(selectXe);
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        objlistHopDong.showHD();
                        Console.ReadKey();
                        break;
                    case 8:
                        test = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
