using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBanXe
{
    internal class NguoiChoThue : TaiKhoan
    {
        public NguoiChoThue()
        {
        }

        public NguoiChoThue(string tenDN, string pass, string ten, int id, string sdt, string role) : base(tenDN, pass, ten, id, sdt, role)
        {
        }

        public void ThemXeChoThue() { }
        public void RutXeChoThue() { }

        //Khong cần làm hàm xuatthongtin vì taikhoan đã có rồi,
        //chủ xe với thuê xe ko có thay đổi về thuộc tính so với
        //taikhoan nên ko cần override hàm này

    }
}
