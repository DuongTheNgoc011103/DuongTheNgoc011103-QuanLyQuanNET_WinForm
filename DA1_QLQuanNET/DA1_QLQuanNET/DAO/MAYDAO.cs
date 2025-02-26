using DA1_QLQuanNET.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace DA1_QLQuanNET.DAO
{
    public class MAYDAO
    {
        private static MAYDAO instance;

        public static MAYDAO Instance
        {
            get
            {
                if (instance == null) MAYDAO.instance = new MAYDAO();
                return MAYDAO.instance;
            }
            private set
            {
                MAYDAO.instance = value;
            }
        }

        public void SuaMay(string maMay, string tenMay)
        {
            string q = "UPDATE MAY SET TenMay = N'" + tenMay + "' WHERE MaMay = '" + maMay + "'";
            Functions.Instance.RunQuery(q);
        }

        public void xoa(string maMay)
        {
            List<HOADONDTO> l = HOADONDAO.Instance.loadDSHDByMaMay(maMay);
            foreach (HOADONDTO i in l)
            {
                HOADONDAO.Instance.XoaHD(i.MaHD);
            }
            Functions.Instance.RunQuery("DELETE FROM MAY WHERE MaMay = '" + maMay + "'");
        }

        public void themMay(string tenMay)
        {
            string q = "INSERT INTO MAY(TenMay, TrangThaiMay) VALUES(N'" + tenMay + "', N'Trống')";
            Functions.Instance.RunQuery(q);
        }

        public MAYDTO getMayByTenMay(string ten)
        {
            DataTable d = Functions.Instance.RunQuery("SELECT * FROM MAY WHERE TenMay = N'" + ten + "'");
            foreach (DataRow item in d.Rows)
            {
                MAYDTO may = new MAYDTO(item);
                return may;
            }
            return null;
        }

        public DataTable getMayNowBySDT(string sdt)
        {
            // Truy vấn SQL để lấy danh sách máy theo SDT và trạng thái hóa đơn chưa thanh toán
            DataTable d = Functions.Instance.RunQuery("SELECT * FROM MAY WHERE MaMay IN (SELECT MaMay FROM HOADON WHERE SDT = '" + sdt + "' AND TrangThaiHD = N'Chưa Thanh Toán')");
            return d;
        }

        public DataTable getMayNow(string trangthaiMay)
        {
            // Truy vấn SQL để lấy danh sách máy theo SDT và trạng thái hóa đơn chưa thanh toán
            DataTable d = Functions.Instance.RunQuery("SELECT * FROM MAY WHERE TrangThaiMay = N'" + trangthaiMay + "'");
            return d;
        }

        public MAYDTO getByMaMay(string ma)
        {
            DataTable d = Functions.Instance.RunQuery("SELECT * FROM MAY WHERE MaMay = '" + ma + "'");
            foreach (DataRow item in d.Rows)
            {
                MAYDTO may = new MAYDTO(item);
                return may;
            }
            return null;
        }
    }
}