using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBanXe
{
    internal class UuDai
    {
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private int phanTramUuDai;
        private string tenUuDai;
        private string mieuTa;

        public DateTime NgayBatDau { get { return ngayBatDau; } set { ngayBatDau = value; } }
        public DateTime NgayKetThuc { get { return ngayKetThuc; } set { ngayKetThuc = value; } }
        public int PhanTramUuDai { get { return phanTramUuDai; } set { phanTramUuDai = value;} }
        public string TenUuDai { get { return tenUuDai;} set { tenUuDai = value; } }
        public string MieuTa { get { return mieuTa; } set { mieuTa = value; } }

    }
}
