using DA1_QLQuanNET.DAO;
using DA1_QLQuanNET.DTO;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace DA1_QLQuanNET
{
    public partial class frmMay : Form
    {
        //Closing
        protected override void OnClosing(CancelEventArgs e)
        {
            frmMenu.HandleClosing(e);
            base.OnClosing(e);
        }

        private DataTable tblMay;

        public frmMay()
        {
            InitializeComponent();
        }

        private void frmMay_Load(object sender, EventArgs e)
        {
            txtMaMay.Enabled = false;

            LoadDGV();

            // Thiết lập giá trị mặc định cho cbTrangThai
            cbTrangThai.Items.Add("Đang dùng");
            cbTrangThai.Items.Add("Trống");

            cbTrangThai.Enabled = false;
            btnHUY.Visible = false;
            btnSAVE.Visible = false;
        }

        public void LoadDGV()
        {
            string chuoiLenh = "SELECT * from MAY";
            tblMay = Functions.GetDataToTable(chuoiLenh);
            this.dgvMay.DataSource = tblMay;

            dgvMay.Columns[0].HeaderText = "Mã Máy";
            dgvMay.Columns[0].Width = 200;

            dgvMay.Columns[1].HeaderText = "Tên Máy";
            dgvMay.Columns[1].Width = 200;

            dgvMay.Columns[2].HeaderText = "Trạng thái Máy";
            dgvMay.Columns[2].Width = 200;

            dgvMay.AllowUserToAddRows = false; //Điều này ngăn DataGridView tự động thêm một hàng mới dưới cùng của bảng.
            dgvMay.EditMode = DataGridViewEditMode.EditProgrammatically; //Điều này đặt chế độ chỉnh sửa của DataGridView thành chỉ chỉnh sửa thông qua mã lập trình.

            tlSoLuong.Text = tblMay.Rows.Count.ToString();
        }

        private void ResetValues()
        {
            txtMaMay.Text = "";
            txtTenMay.Text = "";
            cbTrangThai.Text = null;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            btnEDIT.Visible = false;
            btnSAVE.Visible = true;
            ResetValues();
            txtMaMay.Enabled = false;
            txtTenMay.Focus();
            btnDEL.Visible = false;
            cbTrangThai.Enabled = true;
            btnADD.Visible = false;
            btnHUY.Visible = true;
            dgvMay.Enabled = false;
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            MAYDTO i = MAYDAO.Instance.getByMaMay(txtMaMay.Text);
            if (txtMaMay.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn đối tượng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Xác nhận xóa máy '" + i.TenMay + "' ?\nMọi dữ liệu liên quan sẽ bị mất !", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                MAYDAO.Instance.xoa(i.MaMay);
                LoadDGV();

                ResetValues();
            }
        }

        private void dgvMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMay.Text = dgvMay.CurrentRow.Cells[0].Value.ToString();
            txtTenMay.Text = dgvMay.CurrentRow.Cells[1].Value.ToString();
            cbTrangThai.Text = dgvMay.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            if (txtTenMay.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên Máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenMay.Focus();
                return;
            }
            if (MAYDAO.Instance.getMayByTenMay(txtTenMay.Text) != null)
            {
                MessageBox.Show("Tên Máy này đã tồn tại. Hãy nhập Tên Máy khác!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenMay.Focus();
                txtTenMay.Clear();
                return;
            }
            MAYDAO.Instance.themMay(txtTenMay.Text);
            LoadDGV();
            MessageBox.Show("Thêm Máy thành công.", "Thông báo", MessageBoxButtons.OK);
            ResetValues();

            btnDEL.Visible = true;
            btnEDIT.Visible = true;
            btnADD.Visible = true;
            btnSAVE.Visible = false;
            btnHUY.Visible = false;
            txtMaMay.Enabled = false;
            dgvMay.Enabled = true;
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            MAYDTO i = MAYDAO.Instance.getByMaMay(txtMaMay.Text);
            if (txtMaMay.Text == "")
            {
                MessageBox.Show("Chưa chọn đối tượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtMaMay.Enabled = true;

            MAYDTO i_ = MAYDAO.Instance.getMayByTenMay(txtTenMay.Text);
            if (i_ != null && i_.MaMay != i.MaMay)
            {
                MessageBox.Show("Tên máy đã được máy khác sử dụng !", "Nhắc nhở");
                txtTenMay.Focus();
                return;
            }
            MAYDAO.Instance.SuaMay(i.MaMay, txtTenMay.Text);
            LoadDGV();
            ResetValues();
            txtMaMay.Enabled = false;
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            // Đặt các nút radio về trạng thái không được chọn
            rdHD.Checked = false;
            rdTrong.Checked = false;

            // Tải lại dữ liệu vào DataGridView
            LoadDGV();
        }

        private void LoadTTMay(string maMay)
        {
            string chuoiLenh = "SELECT * FROM MAY WHERE TrangThaiMay = N'" + maMay + "'";
            DataTable dt = Functions.GetDataToTable(chuoiLenh);
            dgvMay.DataSource = dt;

            tlSoLuong.Text = dgvMay.Rows.Count.ToString();
        }

        private void rdHD_CheckedChanged(object sender, EventArgs e)
        {
            LoadTTMay("Đang dùng");
            txtMaMay.Clear();
            txtTenMay.Clear();
            cbTrangThai.SelectedIndex = -1;
        }

        private void rdTrong_CheckedChanged(object sender, EventArgs e)
        {
            LoadTTMay("Trống");
            txtMaMay.Clear();
            txtTenMay.Clear();
            cbTrangThai.SelectedIndex = -1;
        }

        private void btnHUY_Click(object sender, EventArgs e)
        {
            ResetValues();
            LoadDGV();
            btnHUY.Visible = false;
            btnDEL.Visible = true;
            btnEDIT.Visible = true;
            btnADD.Visible = true;
            btnSAVE.Visible = false;
            txtMaMay.Enabled = false;
        }
    }
}