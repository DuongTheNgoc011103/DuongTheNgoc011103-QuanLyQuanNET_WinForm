using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA1_QLQuanNET.DAO;
using DA1_QLQuanNET.DTO;

namespace DA1_QLQuanNET
{
    public partial class frmCTHOADON : Form
    {
        private string _maHD;

        public frmCTHOADON(string maHD)
        {
            InitializeComponent();
            _maHD = maHD;
            LoadDGV(maHD);
            ShowCTHD(maHD);
        }

        public void LoadDGV(string maHD)
        {
            dgvCTHD.Rows.Clear();
            HOADONDTO hd = HOADONDAO.Instance.getByMaHD(maHD);
            List<CTHOADONDTO> l = CTHOADONDAO.Instance.loadDSByMaHD(hd.MaHD);
            int stt = 0;
            foreach (CTHOADONDTO i in l)
            {
                stt++;
                DICHVUDTO dv = DICHVUDAO.Instance.getByMaDV(i.MaDV);
                dgvCTHD.Rows.Add(stt, dv.TenDV, dv.DVTinh, i.SoLuong, Functions.Instance.getDinhDanhHangNghin((int)i.DonGia), Functions.Instance.getDinhDanhHangNghin((int)(i.SoLuong * i.DonGia)) + " VNĐ");
            }
        }

        private void ShowCTHD(string maHD)
        {
            HOADONDTO hd = HOADONDAO.Instance.getByMaHD(maHD);
            KHACHHANGDTO kh = KHACHHANGDAO.Instance.getBySDT(hd.SDT);
            lblSDT.Text = kh.SDT;
            lblTenKH.Text = kh.TenKH;
            lblTimeStart.Text = hd.TGBatDau.ToString("dd/MM/yyyy HH:mm:ss");
            if (hd.TrangThaiHD == "Chưa Thanh Toán")
                lblTimeEnd.Text = "Chưa";
            else
                lblTimeEnd.Text = hd.TGKetThuc.ToString("dd/MM/yyyy HH:mm:ss");
            lblTTHD.Text = hd.TrangThaiHD;
            lblMaHD.Text = hd.MaHD;
            lblTongHD.Text = Functions.Instance.getDinhDanhHangNghin(hd.TongTien) + " VNĐ";
        }

        private void btnINHD_Click(object sender, EventArgs e)
        {
            HOADONDTO hoadon = HOADONDAO.Instance.getByMaHD(_maHD);
            if (hoadon.TrangThaiHD == "Chưa Thanh Toán")
            {
                MessageBox.Show("Hóa Đơn hiện chưa được thanh toán.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<HOADONDTO> dshd = new List<HOADONDTO>();
                dshd.Add(HOADONDAO.Instance.getByMaHD(_maHD));

                INHD inhd = new INHD(dshd);
                inhd.ShowDialog();
                this.Hide();
            }
        }

        private void lblHeaderCTHD_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMaHD_Click(object sender, EventArgs e)
        {

        }
    }
}