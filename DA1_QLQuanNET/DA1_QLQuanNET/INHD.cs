using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using DA1_QLQuanNET.DAO;
using DA1_QLQuanNET.DTO;

namespace DA1_QLQuanNET
{
    public partial class INHD : Form
    {
        private List<HOADONDTO> _maHD;

        public INHD(List<HOADONDTO> maHD)
        {
            InitializeComponent();
            _maHD = maHD;
            this.WindowState = FormWindowState.Maximized;
        }

        private void INHD_Load(object sender, EventArgs e)
        {
            Model1 InHDcs = new Model1();

            // Lấy danh sách các mã hóa đơn từ _maHD
            List<string> maHDs = _maHD.Select(hd => hd.MaHD).ToList();

            // Lọc các chi tiết hóa đơn theo các mã hóa đơn
            List<CTHOADON> listCT = InHDcs.CTHOADONs.Where(ct => maHDs.Contains(ct.MaHD)).ToList();
            List<ClassINHD> listInHD = new List<ClassINHD>();

            foreach (CTHOADON ct in listCT)
            {
                ClassINHD temp = new ClassINHD();
                temp.MaHD = ct.MaHD;
                temp.TenDV = ct.DICHVU.TenDV;
                temp.DonGia = ct.DICHVU.DonGia.ToString();
                temp.SoLuong = ct.SoLuong.ToString();
                temp.TongTien = Functions.Instance.getDinhDanhHangNghin(ct.HOADON.TongTien.HasValue ? ct.HOADON.TongTien.Value : 0) + " VNĐ";
                temp.TenKH = ct.HOADON.KHACHHANG.TenKH;

                listInHD.Add(temp);
            }

            rptHD.LocalReport.ReportPath = "INHD.rdlc";

            var rptsource = new ReportDataSource("DataSet1", listInHD);

            rptHD.LocalReport.DataSources.Clear(); // Hiển thị thông tin mới tránh trùng lặp
            rptHD.LocalReport.DataSources.Add(rptsource);

            this.rptHD.RefreshReport();
        }

        private void rptHD_Load(object sender, EventArgs e)
        {

        }
    }
}