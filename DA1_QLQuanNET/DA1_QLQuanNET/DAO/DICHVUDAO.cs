using DA1_QLQuanNET.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA1_QLQuanNET.DAO
{
    public class DICHVUDAO
    {
        private static DICHVUDAO instance;

        public static DICHVUDAO Instance
        {
            get
            {
                if (instance == null)
                    DICHVUDAO.instance = new DICHVUDAO();
                return DICHVUDAO.instance;
            }
            private set
            {
                DICHVUDAO.instance = value;
            }
        }

        //getByTenDV
        public DICHVUDTO getByTenDV(string tenDV)
        {
            DataTable d = Functions.Instance.RunQuery("SELECT * FROM DICHVU WHERE TenDV = N'" + tenDV + "'");
            foreach (DataRow item in d.Rows)
            {
                DICHVUDTO dv = new DICHVUDTO(item);
                return dv;
            }
            return null;
        }

        public DICHVUDTO getByMaDV(string maDV)
        {
            DataTable d = Functions.Instance.RunQuery("SELECT * FROM DICHVU WHERE MaDV = '" + maDV + "'");
            foreach (DataRow item in d.Rows)
            {
                DICHVUDTO dv = new DICHVUDTO(item);
                return dv;
            }
            return null;
        }

        public List<DICHVUDTO> loadDSDV()
        {
            List<DICHVUDTO> dsDv = new List<DICHVUDTO>();
            DataTable d = Functions.Instance.RunQuery("SELECT * FROM DICHVU");
            foreach (DataRow item in d.Rows)
            {
                DICHVUDTO dv = new DICHVUDTO(item);
                dsDv.Add(dv);
            }
            return dsDv;
        }

        public void ThemDV(DICHVUDTO i)
        {
            string q = "INSERT INTO DICHVU(TenDV, DVTinh, DonGia, SoLuong, HinhAnh) VALUES (N'" + i.TenDV + "', N'" + i.DVTinh + "', " + i.DonGia + ", N'" + i.SoLuong + "', N'" + i.HinhAnh + "')";
            Functions.Instance.RunQuery(q);
        }

        public void SuaDV(DICHVUDTO i)
        {
            Functions.Instance.RunQuery("UPDATE DICHVU SET TenDV = N'" + i.TenDV + "', DVTinh = N'" + i.DVTinh + "', DonGia = " + i.DonGia + ", SoLuong = N'" + i.SoLuong + "', HinhAnh = N'" + i.HinhAnh + "' WHERE MaDV = '" + i.MaDV + "'");
        }

        public void XoaDV(string maDV)
        {
            List<CTHOADONDTO> l = CTHOADONDAO.Instance.loadDSByMaDV(maDV);
            foreach (CTHOADONDTO i in l)
            {
                CTHOADONDAO.Instance.XoaCTHD(i.MaCTHD);
            }
            Functions.Instance.RunQuery("DELETE FROM DICHVU WHERE MaDV = '" + maDV + "'");
        }
    }
}