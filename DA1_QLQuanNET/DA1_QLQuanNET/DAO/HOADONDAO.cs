using DA1_QLQuanNET.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA1_QLQuanNET.DAO
{
    public class HOADONDAO
    {
        private static HOADONDAO instance;

        public static HOADONDAO Instance
        {
            get
            {
                if (instance == null) HOADONDAO.instance = new HOADONDAO();
                return HOADONDAO.instance;
            }
            private set
            {
                HOADONDAO.instance = value;
            }
        }

        public HOADONDTO getNowByMaMay(string maMay)
        {
            DataTable data = Functions.Instance.RunQuery("SELECT* FROM HOADON WHERE MaMay = '" + maMay + "' AND TrangThaiHD = N'Chưa Thanh Toán'");
            if (data.Rows.Count > 0)
            {
                HOADONDTO hd = new HOADONDTO(data.Rows[0]);
                return hd;
            }
            return null;
        }

        public HOADONDTO getNowBySDT(string SDT)
        {
            DataTable data = Functions.Instance.RunQuery("SELECT * FROM HOADON WHERE SDT = '" + SDT + "' AND TrangThaiHD = N'Chưa Thanh Toán'");
            if (data.Rows.Count > 0)
            {
                HOADONDTO hd = new HOADONDTO(data.Rows[0]);
                return hd;
            }
            return null;
        }

        public List<HOADONDTO> loadDSHDBySDT(string sdt)
        {
            List<HOADONDTO> dsHD = new List<HOADONDTO>();
            DataTable data = Functions.Instance.RunQuery("SELECT * FROM HOADON WHERE SDT = '" + sdt + "'");
            foreach (DataRow item in data.Rows)
            {
                HOADONDTO b = new HOADONDTO(item);
                dsHD.Add(b);
            }
            return dsHD;
        }

        public List<HOADONDTO> loadDSHDByMaMay(string maMay)
        {
            List<HOADONDTO> dsHD = new List<HOADONDTO>();
            DataTable data = Functions.Instance.RunQuery("SELECT * FROM HOADON WHERE MaMay = '" + maMay + "'");
            foreach (DataRow item in data.Rows)
            {
                HOADONDTO b = new HOADONDTO(item);
                dsHD.Add(b);
            }
            return dsHD;
        }

        public List<HOADONDTO> loadDSHDByTime(DateTime startDate, DateTime endDate)
        {
            List<HOADONDTO> dsHD = new List<HOADONDTO>();
            string query = "SELECT * FROM HOADON WHERE TGBatDau >= @StartDate AND TGKetThuc <= @EndDate";
            DataTable data = Functions.Instance.RunQuery(query, new object[] { startDate, endDate });

            foreach (DataRow item in data.Rows)
            {
                HOADONDTO b = new HOADONDTO(item);
                dsHD.Add(b);
            }
            return dsHD;
        }

        public HOADONDTO getByMaHD(string maHD)
        {
            DataTable data = Functions.Instance.RunQuery("SELECT * FROM HOADON WHERE MaHD = '" + maHD + "'");
            foreach (DataRow item in data.Rows)
            {
                HOADONDTO hd = new HOADONDTO(item);
                return hd;
            }
            return null;
        }

        public List<HOADONDTO> loadDSHD()
        {
            List<HOADONDTO> dsHD = new List<HOADONDTO>();
            DataTable data = Functions.Instance.RunQuery("SELECT * FROM HOADON");
            foreach (DataRow item in data.Rows)
            {
                HOADONDTO b = new HOADONDTO(item);
                dsHD.Add(b);
            }
            return dsHD;
        }

        public void ThemHD(HOADONDTO i)
        {
            Functions.Instance.RunQuery("INSERT INTO HOADON (MaMay,SDT,TGBatDau, TGKetThuc, TongTien, TrangThaiHD) VALUES ('" + i.MaMay + "', '" + i.SDT + "', '" + i.TGBatDau + "', '" + i.TGKetThuc + "', '" + i.TongTien + "', N'" + i.TrangThaiHD + "')");
        }

        public void thanhToan(string maHD)
        {
            HOADONDTO i = HOADONDAO.instance.getByMaHD(maHD);
            Functions.Instance.RunQuery("UPDATE MAY SET TrangThaiMay = N'Trống' WHERE MaMay = '" + i.MaMay + "'");
            Functions.Instance.RunQuery("UPDATE HOADON SET TrangThaiHD = N'Đã Thanh Toán', TGKetThuc = GETDATE() WHERE MaHD = '" + maHD + "'");
        }

        public void XoaHD(string maHD)
        {
            HOADONDTO i = HOADONDAO.instance.getByMaHD(maHD);
            Functions.Instance.RunQuery("UPDATE MAY SET TrangThaiMay = N'Trống' WHERE MaMay = '" + i.MaMay + "'");
            Functions.Instance.RunQuery("DELETE FROM CTHOADON WHERE MaHD = '" + maHD + "'");
            Functions.Instance.RunQuery("DELETE FROM HOADON WHERE MaHD = '" + maHD + "'");
        }

        public void capNhatTongTien(string maHD)
        {
            List<CTHOADONDTO> l = CTHOADONDAO.Instance.loadDSByMaHD(maHD);
            float tong = 0;
            foreach (CTHOADONDTO i in l)
            {
                tong += i.SoLuong * i.DonGia;
            }
            Functions.Instance.RunQuery("UPDATE HOADON SET TongTien = " + (int)tong + " WHERE MaHD = '" + maHD + "'");
        }

        public void capNhatTime(string maHD, float thoiGian)
        {
            CTHOADONDTO ct = CTHOADONDAO.Instance.getByMaHD_MaDV(maHD, "DV001");

            if (ct == null)
            {
                // Xử lý trường hợp không tìm thấy dữ liệu
                Console.WriteLine("Không tìm thấy dữ liệu CTHOADON với MaHD: " + maHD);
                return; // Dừng hàm nếu không có dữ liệu
            }

            // Chỉ thực hiện cập nhật nếu ct không phải null
            Functions.Instance.RunQuery("UPDATE CTHOADON SET SoLuong = " + thoiGian + " WHERE MaCTHD = '" + ct.MaCTHD + "'");
            capNhatTongTien(maHD);
        }

    }
}