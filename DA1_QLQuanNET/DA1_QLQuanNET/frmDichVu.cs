using DA1_QLQuanNET.DAO;
using DA1_QLQuanNET.DTO;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DA1_QLQuanNET
{
    public partial class frmDichVu : Form
    {
        private DataTable tblDV;

        public frmDichVu()
        {
            InitializeComponent();
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.ShowDialog();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            frmMenu.HandleClosing(e);
            base.OnClosing(e);
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            LoadDGV();
            txtMaDV.Enabled = false;
            btnHUY.Visible = false;
            btnSAVE.Visible = false;

            btnSAVE.Visible = false;
            btnHUY.Visible = false;
        }

        //LoadDGV Dịch Vụ
        public void LoadDGV()
        {
            string chuoiLenh = "SELECT * FROM DICHVU";
            tblDV = Functions.GetDataToTable(chuoiLenh);
            this.dgvDichVu.DataSource = tblDV;

            dgvDichVu.Columns[0].HeaderText = "Mã Dịch Vụ";
            dgvDichVu.Columns[0].Width = 120;

            dgvDichVu.Columns[1].HeaderText = "Tên Dịch Vụ";
            dgvDichVu.Columns[1].Width = 230;

            dgvDichVu.Columns[2].HeaderText = "Đơn Vị Tính";
            dgvDichVu.Columns[2].Width = 130;

            dgvDichVu.Columns[3].HeaderText = "Đơn Giá";
            dgvDichVu.Columns[3].Width = 110;

            dgvDichVu.Columns[4].HeaderText = "Số Lượng";
            dgvDichVu.Columns[4].Width = 100;

            dgvDichVu.Columns[5].HeaderText = "Hình Ảnh";
            dgvDichVu.Columns[5].Width = 200;

            dgvDichVu.AllowUserToAddRows = false; //Điều này ngăn DataGridView tự động thêm một hàng mới dưới cùng của bảng.
            dgvDichVu.EditMode = DataGridViewEditMode.EditProgrammatically; //Điều này đặt chế độ chỉnh sửa của DataGridView thành chỉ chỉnh sửa thông qua mã lập trình.

            tlSoLuong.Text = tblDV.Rows.Count.ToString();
        }

        private void ResetValues()
        {
            txtMaDV.Text = "";
            txtTenDV.Text = "";
            txtDVTinh.Text = "";
            txtSoLuongDV.Text = "";
            txtDonGia.Text = "";
            txtHinhAnh.Text = "";
            picHA.Image = null;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            btnEDIT.Visible = false;
            btnADD.Visible = false;
            ResetValues();
            txtMaDV.Enabled = false;
            btnDEL.Visible = false;
            txtTenDV.Focus();

            btnSAVE.Visible = true;
            btnHUY.Visible = true;
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDV.Text = dgvDichVu.CurrentRow.Cells[0].Value.ToString();
            txtTenDV.Text = dgvDichVu.CurrentRow.Cells[1].Value.ToString();
            txtDVTinh.Text = dgvDichVu.CurrentRow.Cells[2].Value.ToString();
            txtDonGia.Text = dgvDichVu.CurrentRow.Cells[3].Value.ToString();
            txtSoLuongDV.Text = dgvDichVu.CurrentRow.Cells[4].Value.ToString();
            txtHinhAnh.Text = dgvDichVu.CurrentRow.Cells[5].Value.ToString();

            string chuoiLenh = "SELECT HinhAnh FROM DICHVU WHERE MaDV = '" + txtMaDV.Text + "'";
            txtHinhAnh.Text = Functions.GetFieldValues(chuoiLenh);
            picHA.Image = Image.FromFile(txtHinhAnh.Text);
        }

        private void lblHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog(); // khởi tạo
            dlgOpen.Filter = "JPEG(*.jpg)|*.jpg|PNG(*.png)|*.png|All files(*.*)|*.*";
            //các loại file ảnh

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picHA.Image = Image.FromFile(dlgOpen.FileName);
                txtHinhAnh.Text = dlgOpen.FileName;
            }
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (txtMaDV.Text == "")
            {
                MessageBox.Show("Chưa chọn đối tượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTenDV.Text == "NET")
            {
                MessageBox.Show("KHÔNG ĐƯỢC XÓA DICHV VỤ NÀY.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("Xác nhận xóa dịch vụ: " + txtTenDV.Text.Trim() + " ?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                DICHVUDAO.Instance.XoaDV(txtMaDV.Text);
                LoadDGV();
                ResetValues();
            }
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            if (txtTenDV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên dịch vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDV.Focus();
                return;
            }
            if (DICHVUDAO.Instance.getByTenDV(txtTenDV.Text) != null)
            {
                MessageBox.Show("Tên dịch vụ đã được tồn tại !", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDV.Focus();
                return;
            }
            if (txtDVTinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn vị tính của dịch vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDVTinh.Focus();
                return;
            }
            if (txtSoLuongDV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng của dịch vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuongDV.Focus();
                return;
            }
            if (txtHinhAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải cung cấp hình ảnh của dịch vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHinhAnh.Focus();
                return;
            }

            DICHVUDAO.Instance.ThemDV(new DICHVUDTO(null, txtTenDV.Text, txtDVTinh.Text, int.Parse(txtDonGia.Text), float.Parse(txtSoLuongDV.Text), txtHinhAnh.Text));

            LoadDGV();
            ResetValues();
            btnDEL.Visible = true;
            btnEDIT.Visible = true;
            btnADD.Visible = true;
            btnSAVE.Visible = false;
            txtMaDV.Enabled = false;
            btnHUY.Visible = false;
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (txtMaDV.Text == "")
            {
                MessageBox.Show("Chưa chọn đối tượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtMaDV.Enabled = true;

            /*string chuoiLenh = "UPDATE DICHVU SET TenDV = N'" + txtTenDV.Text.Trim() + "', DVTinh = N'" + txtDVTinh.Text.Trim() + "', DonGia = '" + txtDonGia.Text.Trim() + "', SoLuong = N'" + txtSoLuongDV.Text.Trim() + "', HinhAnh = '" + txtHinhAnh.Text.Trim() + "' WHERE MaDV = '" + txtMaDV.Text.Trim() + "'";
            Functions.RunSQL(chuoiLenh);*/
            DICHVUDTO i = DICHVUDAO.Instance.getByMaDV(txtMaDV.Text);
            if (i.MaDV == "DV000001")
                i = new DICHVUDTO(i.MaDV, i.TenDV, i.DVTinh, int.Parse(txtDonGia.Text), float.Parse(txtSoLuongDV.Text), txtHinhAnh.Text);
            else
                i = new DICHVUDTO(i.MaDV, txtTenDV.Text, txtDVTinh.Text, int.Parse(txtDonGia.Text), float.Parse(txtSoLuongDV.Text), txtHinhAnh.Text);
            DICHVUDAO.Instance.SuaDV(i);
            LoadDGV();
            ResetValues();
            txtMaDV.Enabled = false;
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
            txtMaDV.Enabled = false;
        }

        private void lblDV_Click(object sender, EventArgs e)
        {

        }
    }
}