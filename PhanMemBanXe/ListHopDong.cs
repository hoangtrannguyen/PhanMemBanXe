using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBanXe
{
    internal class ListHopDong
    {
        public List<HopDong> listHopDong = new List<HopDong>();
        
        public void themHopDong(Xe xe)
        {
            HopDong hopDong = new HopDong();
            hopDong.TaoHopDong(xe);
            listHopDong.Add(hopDong);   
        }
        public void xoaHopDong(HopDong hopDong)
        {
            listHopDong.Remove(hopDong);
        }
        public void showHD()
        {
            foreach (HopDong hopDong in listHopDong)
            {
                hopDong.ShowHopDong();
            }
        }
    }
}
