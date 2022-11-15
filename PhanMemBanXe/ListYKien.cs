using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBanXe
{
    internal class ListYKien
    {
        List<YKienDanhGia> listYKien = new List<YKienDanhGia>();
        public void themYKien(string IDChu, string IDKhach, string soKiemSoatXe)
        {
            YKienDanhGia yKien = new YKienDanhGia();
            yKien.themYKien( IDChu,  IDKhach,  soKiemSoatXe);
            listYKien.Add(yKien);
        }
        public void showYKien()
        {
            foreach (YKienDanhGia yKien in listYKien)
            {
                yKien.showYKien();
            }
        }
    }
}
