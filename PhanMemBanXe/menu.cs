using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBanXe
{
    internal class menu
    {
        public static void dangNhap()
        {
            ListXe SV = new ListXe();
            ListNguoiChoThue GV = new ListNguoiChoThue();
            ListNguoiThue MH = new ListNguoiThue();
/*            MH.dataTest();
            SV.dataTest();
            GV.dataTest();*/
            bool test = true;
            while (test)
            {
                Console.Clear();
                Console.WriteLine("\nCHUONG TRINH QUAN LY THUE XE C#");
                Console.WriteLine("********************MENU********************");
                Console.WriteLine("** 1. Dang nhap                           **");
                Console.WriteLine("** 2. Tao tai khoan                       **");
                Console.WriteLine("** 0. Thoat                               **");
                Console.WriteLine("********************************************");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.Clear();
                        SV.nhapSV();
                        Console.WriteLine("------NHAP THANH CONG------\n" +
                                          " Nhan nut bat ki de tro ve");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        GV.nhapGV();
                        Console.WriteLine("------NHAP THANH CONG------\n" +
                                          " Nhan nut bat ki de tro ve");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        SV.xuatSV();
                        Console.WriteLine();
                        Console.WriteLine("---NHAN NUT BAT KI DE TRO VE---");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        GV.xuatGV();
                        Console.WriteLine();
                        Console.WriteLine("---NHAN NUT BAT KI DE TRO VE---");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        SV.xuatSV();
                        Console.WriteLine("---Chon sinh vien so---");
                        int key2 = Int32.Parse(Console.ReadLine());
                        sinhVien selectSV = SV.laySinhVien(key2);
                        menu2(selectSV, MH);
                        break;
                    case 6:
                        Console.Clear();
                        GV.xuatGV();
                        Console.WriteLine("---Chon giao vien so---");
                        int key3 = Int32.Parse(Console.ReadLine());
                        giaoVien selectGV = GV.layGiaoVien(key3);
                        menu3(selectGV, MH);
                        break;
                    case 7:
                        Console.Clear();
                        MH.xuatMH();
                        Console.WriteLine("---NHAN NUT BAT KI DE TRO VE---");
                        Console.ReadKey();
                        break;
                    case 0:
                        return;
                    default:
                        break;

                }

            }
        }
    }
}
