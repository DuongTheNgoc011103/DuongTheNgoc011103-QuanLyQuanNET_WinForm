using DA1_QLQuanNET.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA1_QLQuanNET.DAO
{
    public class KHACHHANGDAO
    {
        private static KHACHHANGDAO instance;

        public static KHACHHANGDAO Instance
        {
            get
            {
                if (instance == null)
                    KHACHHANGDAO.instance = new KHACHHANGDAO();
                return KHACHHANGDAO.instance;
            }
            private set
            {
                KHACHHANGDAO.instance = value;
            }
        }

        //getBySDT
        public KHACHHANGDTO getBySDT(string sdt)
        {
            DataTable d = Functions.Instance.RunQuery("SELECT * FROM KHACHHANG WHERE SDT = '" + sdt + "'");
            foreach (DataRow item in d.Rows)
            {
                KHACHHANGDTO i = new KHACHHANGDTO(item);
                return i;
            }
            return null;
        }

        public List<KHACHHANGDTO> TimDSKH(string tuKhoa)
        {
            List<KHACHHANGDTO> dsKh = new List<KHACHHANGDTO>();
            DataTable d = Functions.Instance.RunQuery("SELECT * FROM KHANHHANG WHERE " + " SDT LIKE '%" + tuKhoa + "%' OR TenKH LIKE N'%" + tuKhoa + "%' OR DiaChi LIKE N'%" + tuKhoa + "%'");
            foreach (DataRow item in d.Rows)
            {
                KHACHHANGDTO kh = new KHACHHANGDTO(item);
                dsKh.Add(kh);
            }
            return dsKh;
        }

        public void ThemKH(string sdt, string tenKH, string diaChi)
        {
            Functions.Instance.RunQuery("INSERT INTO KHACHHANG(SDT,TenKH,DiaChi) VALUES('" + sdt + "', N'" + tenKH + "', N'" + diaChi + "')");
        }

        public void XoaKH(string sdt)
        {
            List<HOADONDTO> l = HOADONDAO.Instance.loadDSHDBySDT(sdt);
            foreach (HOADONDTO i in l)
            {
                HOADONDAO.Instance.XoaHD(i.MaHD);
            }
            Functions.Instance.RunQuery("DELETE FROM KHACHHANG WHERE SDT = '" + sdt + "'");
        }

        public void SuaKH(string sdt, string tenKH, string diaChi)
        {
            Functions.Instance.RunQuery("UPDATE KHACHHANG SET TenKH = N'" + tenKH + "', DiaChi = N'" + diaChi + "' WHERE SDT = '" + sdt + "'");
        }
    }
}