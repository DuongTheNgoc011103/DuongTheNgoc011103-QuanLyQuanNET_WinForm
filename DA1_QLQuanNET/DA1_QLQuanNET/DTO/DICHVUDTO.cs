using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA1_QLQuanNET.DTO
{
    public class DICHVUDTO
    {
        private string maDV;
        private string tenDV;
        private string donViTinh;
        private int donGia;
        private float soLuong;
        private string hinhAnh;

        public string MaDV { get => maDV; set => maDV = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public string DVTinh { get => donViTinh; set => donViTinh = value; }
        public float SoLuong { get => soLuong; set => soLuong = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }

        public DICHVUDTO()
        { }

        public DICHVUDTO(string maDV, string tenDV, string donViTinh, int donGia, float soLuong, string hinhAnh)
        {
            this.maDV = maDV;
            this.tenDV = tenDV;
            this.donViTinh = donViTinh;
            this.donGia = donGia;
            this.soLuong = soLuong;
            this.hinhAnh = hinhAnh;
        }

        public DICHVUDTO(DataRow d)
        {
            MaDV = d["MaDV"].ToString();
            TenDV = d["TenDV"].ToString();
            DVTinh = d["DVTinh"].ToString();
            DonGia = (int)d["DonGia"];
            SoLuong = float.Parse(d["SoLuong"].ToString());
            HinhAnh = d["HinhAnh"].ToString();
        }
    }
}