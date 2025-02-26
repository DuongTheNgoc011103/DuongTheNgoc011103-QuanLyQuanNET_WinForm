using DA1_QLQuanNET.DAO;
using DA1_QLQuanNET.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using static DA1_QLQuanNET.frmHoaDon;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DA1_QLQuanNET
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            frmMenu.HandleClosing(e);
            base.OnClosing(e);
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadDS();
        }

        //LoadDGV Hóa Đơn
        public void LoadDS()
        {
            dgvHoaDon.Rows.Clear();
            txtMaHD.Text = "";
            int stt = 0;
            int tongHD = 0;
            List<HOADONDTO> l = HOADONDAO.Instance.loadDSHD();
            foreach (HOADONDTO i in l)
            {
                stt++;
                KHACHHANGDTO kh = KHACHHANGDAO.Instance.getBySDT(i.SDT);
                string txt = "";
                if (i.TrangThaiHD == "Chưa Thanh Toán")
                {
                    txt = "Chưa";
                }
                else
                {
                    txt = i.TGKetThuc.ToString("dd/MM/yyyy HH:mm:ss"); ;
                }

                dgvHoaDon.Rows.Add(stt, i.MaHD, i.MaMay, kh.TenKH, i.TGBatDau.ToString("dd/MM/yyyy HH:mm:ss"), txt,
                Functions.Instance.getDinhDanhHangNghin(i.TongTien) + " VNĐ", i.TrangThaiHD);
                tongHD += i.TongTien;
            }
            txtTongHD.Text = Functions.Instance.getDinhDanhHangNghin(tongHD) + " VNĐ";

            tlSoLuong.Text = dgvHoaDon.Rows.Count.ToString();

            txtTrangThaiHD.Enabled = false;
            txtMaHD.Enabled = false;
            txtMaMay.Enabled = false;
            txtTenMay.Enabled = false;
            txtTenKH.Enabled = false;
            txtTongHD.Enabled = false;
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HOADONDTO hd = HOADONDAO.Instance.getByMaHD(txtMaHD.Text);
            if (hd == null)
            {
                MessageBox.Show("Hãy chọn hóa đơn cần xóa trước !", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTrangThaiHD.Text.Trim() == "Đã Thanh Toán")
            {
                if (MessageBox.Show("Mọi dữ liệu của " + hd.MaHD + " sẽ bị mất.", "Xác nhận XÓA?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    HOADONDAO.Instance.XoaHD(hd.MaHD);
                    LoadDS();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Hóa đơn " + hd.MaHD + " CHƯA THANH TOÁN.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadDS();

            txtMaHD.Text = "";
            txtMaMay.Text = "";
            txtTenMay.Text = "";
            txtTenKH.Text = "";
            txtTrangThaiHD.Text = "";
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = dgvHoaDon.CurrentRow.Cells[1].Value.ToString();
            txtMaMay.Text = dgvHoaDon.CurrentRow.Cells[2].Value.ToString();

            string maMay = dgvHoaDon.CurrentRow.Cells[2].Value.ToString();
            MAYDTO may = MAYDAO.Instance.getByMaMay(maMay);
            txtTenMay.Text = may.TenMay;

            txtTenKH.Text = dgvHoaDon.CurrentRow.Cells[3].Value.ToString();

            txtTrangThaiHD.Text = dgvHoaDon.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnXemCT_Click(object sender, EventArgs e)
        {
            HOADONDTO hd = HOADONDAO.Instance.getByMaHD(txtMaHD.Text);
            if (hd == null)
            {
                MessageBox.Show("Hãy chọn hóa đơn xem chi tiết trước !", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmCTHOADON ct = new frmCTHOADON(hd.MaHD);
            ct.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpTimeBD.Value;
            DateTime endDate = dtpTimeKT.Value;

            // Kiểm tra logic nếu cần
            if (startDate > endDate)
            {
                MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc.");
                return;
            }

            // Truy vấn cơ sở dữ liệu và lấy dữ liệu
            List<HOADONDTO> dshdByTime = HOADONDAO.Instance.loadDSHDByTime(startDate, endDate);

            // Kiểm tra danh sách có phần tử hay không
            if (dshdByTime.Count == 0)
            {
                MessageBox.Show("Không tìm thấy hóa đơn nào trong khoảng thời gian này.");
                return;
            }
            else
            {
                // Ẩn form hiện tại và hiển thị form THONGKE với dữ liệu hóa đơn
                this.Hide();
                THONGKE tk = new THONGKE(dshdByTime);
                tk.ShowDialog();
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDS();
        }
    }
}