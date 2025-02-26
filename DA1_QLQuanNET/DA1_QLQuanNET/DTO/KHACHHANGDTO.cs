using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA1_QLQuanNET.DTO
{
    public class KHACHHANGDTO
    {
        private string sDT;
        private string tenKH;
        private string diaChi;

        public string SDT { get => sDT; set => sDT = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }

        public KHACHHANGDTO()
        {
        }

        public KHACHHANGDTO(string sDT, string tenKH, string diaChi)
        {
            this.SDT = sDT;
            this.TenKH = tenKH;
            this.DiaChi = diaChi;
        }

        public KHACHHANGDTO(DataRow d)
        {
            SDT = d["SDT"].ToString();
            TenKH = d["TenKH"].ToString();
            DiaChi = d["DiaChi"].ToString();
        }
    }
}