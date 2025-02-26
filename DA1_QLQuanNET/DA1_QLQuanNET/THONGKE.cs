using DA1_QLQuanNET.DAO;
using DA1_QLQuanNET.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DA1_QLQuanNET
{
    public partial class THONGKE : Form
    {
        private List<HOADONDTO> _dshdByTime;

        public THONGKE(List<HOADONDTO> dshdByTime)
        {
            InitializeComponent();
            _dshdByTime = dshdByTime;
        }

        private void THONGKE_Load(object sender, EventArgs e)
        {
            LoadTTThongKe();
        }

        private void LoadTTThongKe()
        {
            if (_dshdByTime != null && _dshdByTime.Count > 0)
            {
                int tongTien = 0;
                foreach (var hoadon in _dshdByTime)
                {
                    ChartBDC.Series["ChartBDC"].Points.AddXY(hoadon.MaHD, hoadon.TongTien);
                    tongTien += hoadon.TongTien;
                }
                soluong.Text = _dshdByTime.Count.ToString() + " Hóa Đơn";
                tongtien.Text = Functions.Instance.getDinhDanhHangNghin(tongTien) + " VNĐ";
            }
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHoaDon hd = new frmHoaDon();
            hd.ShowDialog();
        }

        private void ChartBDC_Click(object sender, EventArgs e)
        {

        }

        private void soluong_Click(object sender, EventArgs e)
        {

        }
    }
}