using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA1_QLQuanNET.DTO
{
    public class HOADONDTO
    {
        private string maHD;
        private string sDT;
        private string maMay;
        private DateTime tgBatDau;
        private DateTime tgKetThuc;
        private int tongTien;
        private string trangThaiHD;

        public string MaHD { get => maHD; set => maHD = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string MaMay { get => maMay; set => maMay = value; }
        public DateTime TGBatDau { get => tgBatDau; set => tgBatDau = value; }
        public DateTime TGKetThuc { get => tgKetThuc; set => tgKetThuc = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public string TrangThaiHD { get => trangThaiHD; set => trangThaiHD = value; }

        public HOADONDTO()
        {
        }

        public HOADONDTO(string maHD, string sDTKH, string maMay, DateTime tgBatDau, DateTime tgKetThuc, int tongTien, string trangThaiHD)
        {
            MaHD = maHD;
            SDT = sDTKH;
            MaMay = maMay;
            TGBatDau = tgBatDau;
            TGKetThuc = tgKetThuc;
            TongTien = tongTien;
            TrangThaiHD = trangThaiHD;
        }

        public HOADONDTO(DataRow d)
        {
            MaHD = d["MaHD"].ToString();
            SDT = d["SDT"].ToString();
            MaMay = d["MaMay"].ToString();
            TGBatDau = (DateTime)d["TGBatDau"];
            object tgKetThucValue = d["TGKetThuc"];
            if (tgKetThucValue != DBNull.Value) // Kiểm tra xem giá trị không phải là DBNull
            {
                TGKetThuc = (DateTime)tgKetThucValue; // Ép kiểu sau khi đã kiểm tra
            }
            TongTien = (int)d["TongTien"];
            TrangThaiHD = d["TrangThaiHD"].ToString();
        }
    }
}