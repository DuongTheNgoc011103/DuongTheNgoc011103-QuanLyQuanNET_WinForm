using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA1_QLQuanNET.DTO
{
    public class CTHOADONDTO
    {
        private string maCTHD;
        private string maHD;
        private string maDV;
        private int donGia;
        private float soLuong;

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaDV { get => maDV; set => maDV = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public float SoLuong { get => soLuong; set => soLuong = value; }
        public string MaCTHD { get => maCTHD; set => maCTHD = value; }

        public CTHOADONDTO()
        {
        }

        public CTHOADONDTO(string maCTHD, string maHD, string maDV, int donGia, float soLuong)
        {
            this.MaCTHD = maCTHD;
            this.MaHD = maHD;
            this.MaDV = maDV;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
        }

        public CTHOADONDTO(DataRow r)
        {
            MaCTHD = r["MaCTHD"].ToString();
            MaHD = r["MaHD"].ToString();
            MaDV = r["MaDV"].ToString();
            DonGia = (int)r["DonGia"];
            SoLuong = float.Parse(r["SoLuong"].ToString());
        }
    }
}