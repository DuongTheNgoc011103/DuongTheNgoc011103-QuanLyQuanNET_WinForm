using DA1_QLQuanNET.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA1_QLQuanNET.DAO
{
    public class CTHOADONDAO
    {
        private static CTHOADONDAO instance;

        public static CTHOADONDAO Instance
        {
            get
            {
                if (instance == null)
                    CTHOADONDAO.instance = new CTHOADONDAO();
                return CTHOADONDAO.instance;
            }
            private set
            {
                CTHOADONDAO.instance = value;
            }
        }

        public CTHOADONDTO getByMaHD_MaDV(string maHD, string maDV)
        {
            DataTable d = Functions.Instance.RunQuery("SELECT * FROM CTHOADON WHERE MaDV = '" + maDV + "' AND MaHD = '" + maHD + "'");
            foreach (DataRow item in d.Rows)
            {
                CTHOADONDTO ct = new CTHOADONDTO(item);
                return ct;
            }
            return null;
        }

        public List<CTHOADONDTO> loadDSByMaDV(string maDV)
        {
            List<CTHOADONDTO> l = new List<CTHOADONDTO>();
            DataTable d = Functions.Instance.RunQuery("SELECT * FROM CTHOADON WHERE MaDV = '" + maDV + "'");
            foreach (DataRow item in d.Rows)
            {
                CTHOADONDTO i = new CTHOADONDTO(item);
                l.Add(i);
            }
            return l;
        }

        public List<CTHOADONDTO> loadDSByMaHD(string maHD)
        {
            List<CTHOADONDTO> l = new List<CTHOADONDTO>();
            DataTable d = Functions.Instance.RunQuery("SELECT * FROM CTHOADON WHERE MaHD = '" + maHD + "'");
            foreach (DataRow item in d.Rows)
            {
                CTHOADONDTO i = new CTHOADONDTO(item);
                l.Add(i);
            }
            return l;
        }

        public void XoaCTHD(string maCTHD)
        {
            CTHOADONDTO ct = getByMaCTHD(maCTHD);
            Functions.Instance.RunQuery("DELETE FROM CTHOADON WHERE MaCTHD = '" + maCTHD + "'");
            HOADONDAO.Instance.capNhatTongTien(ct.MaHD);
        }

        public CTHOADONDTO getByMaHD_MaSP_DonGia(string maHD, string maDV, int donGia)
        {
            DataTable d = Functions.Instance.RunQuery("SELECT * FROM CTHOADON WHERE MaHD = '" + maHD + "' AND MaDV = '" + maDV + "' AND DonGia =" + donGia);
            foreach (DataRow item in d.Rows)
            {
                CTHOADONDTO ct = new CTHOADONDTO(item);
                return ct;
            }
            return null;
        }

        public CTHOADONDTO getByMaHD_MaSP_SoLuong(string maHD, string maDV, float SoLuong)
        {
            DataTable d = Functions.Instance.RunQuery("SELECT * FROM CTHOADON WHERE MaHD = '" + maHD + "' AND MaDV = '" + maDV + "' AND SoLuong = '" + SoLuong + "'");
            foreach (DataRow item in d.Rows)
            {
                CTHOADONDTO ct = new CTHOADONDTO(item);
                return ct;
            }
            return null;
        }

        public void ThemCTHD(CTHOADONDTO i)
        {
            if (i.SoLuong == 0)
                return;

            // Lấy thông tin dịch vụ và hóa đơn chi tiết hiện có
            CTHOADONDTO ct_ = getByMaHD_MaSP_DonGia(i.MaHD, i.MaDV, i.DonGia);
            DICHVUDTO dv = DICHVUDAO.Instance.getByMaDV(i.MaDV);

            if (ct_ != null)
            {
                // Cập nhật số lượng mới cho bản ghi CTHOADON hiện có
                float soLuongNew = ct_.SoLuong + i.SoLuong;
                if (soLuongNew <= 0)
                {
                    XoaCTHD(ct_.MaCTHD);
                }
                else
                {
                    Functions.Instance.RunQuery("UPDATE CTHOADON SET SoLuong = " + soLuongNew + " WHERE MaCTHD = '" + ct_.MaCTHD + "'");
                }
            }
            else
            {
                // Thêm mới bản ghi CTHOADON
                if (i.SoLuong < 0)
                    return;

                Functions.Instance.RunQuery("INSERT INTO CTHOADON(MaHD, MaDV, SoLuong, DonGia) VALUES ('" + i.MaHD + "', '" + i.MaDV + "', " + i.SoLuong + ", " + i.DonGia + ")");
            }

            // Cập nhật số lượng dịch vụ trong DICHVU
            float soLuongDVNew = dv.SoLuong - i.SoLuong;
            Functions.Instance.RunQuery("UPDATE DICHVU SET SoLuong = " + soLuongDVNew + " WHERE MaDV = '" + dv.MaDV + "'");

            // Cập nhật tổng tiền hóa đơn
            HOADONDAO.Instance.capNhatTongTien(i.MaHD);
        }

        public CTHOADONDTO getByMaCTHD(string maCTHD)
        {
            DataTable d = Functions.Instance.RunQuery("SELECT * FROM CTHOADON WHERE MaCTHD = '" + maCTHD + "'");
            foreach (DataRow item in d.Rows)
            {
                CTHOADONDTO ct = new CTHOADONDTO(item);
                return ct;
            }
            return null;
        }
    }
}