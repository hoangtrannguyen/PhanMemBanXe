using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBanXe
{
    internal class NguoiThue : TaiKhoan
    {
        public NguoiThue()
        {
        }

        public NguoiThue(string tenDN, string pass, string ten, int id, string sdt, string role) : base(tenDN, pass, ten, id, sdt, role)
        {
        }

    }
}
