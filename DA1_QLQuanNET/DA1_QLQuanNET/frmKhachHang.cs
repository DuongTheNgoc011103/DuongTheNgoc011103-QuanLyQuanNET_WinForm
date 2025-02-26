using DA1_QLQuanNET.DAO;
using DA1_QLQuanNET.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using static DA1_QLQuanNET.frmKhachHang;
using static DA1_QLQuanNET.frmMay;

namespace DA1_QLQuanNET
{
    public partial class frmKhachHang : Form
    {
        private DataTable tblKH;

        public frmKhachHang()
        {
            InitializeComponent();
        }

        public void LoadDGV()
        {
            string chuoiLenh = "SELECT * from KHACHHANG";
            tblKH = Functions.GetDataToTable(chuoiLenh);
            this.dgvKhachHang.DataSource = tblKH;

            // Sắp xếp DataTable theo tên khách hàng

            // Tạo một DataView từ DataTable tblKH
            DataView dv = tblKH.DefaultView;

            // Thiết lập trường cần sắp xếp là "TenKH"
            dv.Sort = "TenKH";

            // Tạo một DataTable mới chứa dữ liệu đã được sắp xếp từ DataView
            DataTable sortedDataTable = dv.ToTable();

            dgvKhachHang.Columns[0].HeaderText = "Số Điện Thoại";
            dgvKhachHang.Columns[0].Width = 150;

            dgvKhachHang.Columns[1].HeaderText = "Tên Khách Hàng";
            dgvKhachHang.Columns[1].Width = 250;

            dgvKhachHang.Columns[2].HeaderText = "Địa Chỉ";
            dgvKhachHang.Columns[2].Width = 300;

            dgvKhachHang.AllowUserToAddRows = false; //Điều này ngăn DataGridView tự động thêm một hàng mới dưới cùng của bảng.
            dgvKhachHang.EditMode = DataGridViewEditMode.EditProgrammatically; //Điều này đặt chế độ chỉnh sửa của DataGridView thành chỉ chỉnh sửa thông qua mã lập trình.

            tlSoLuong.Text = tblKH.Rows.Count.ToString();
        }

        private void ResetValues()
        {
            txtSDT.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtSearch.Text = "";
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            btnEDIT.Visible = false;
            btnSAVE.Enabled = true;
            btnADD.Enabled = false;
            ResetValues();
            txtSDT.Enabled = true;
            txtSDT.Focus();
            btnDEL.Visible = false;
            txtSearch.Enabled = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            frmMenu.HandleClosing(e);
            base.OnClosing(e);
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            txtSDT.Enabled = false;
            btnSAVE.Enabled = false;
            LoadDGV();
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            //xem SDT đã đúng quy định chưa
            if (!Functions.CheckSDT(txtSDT.Text.Trim()))
            {
                MessageBox.Show("Số Điện Thoại này không hợp lệ, vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                txtSDT.Text = "";
                return;
            }
            //xem SDT đã tồn tại chưa
            if (KHACHHANGDAO.Instance.getBySDT(txtSDT.Text) != null)
            {
                MessageBox.Show("Số Điện Thoại này đã tồn tại, hãy kiểm tra lại SDT.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                txtSDT.Text = "";
                return;
            }
            if (txtTenKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKH.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }

            KHACHHANGDAO.Instance.ThemKH(txtSDT.Text, txtTenKH.Text, txtDiaChi.Text);
            LoadDGV();
            ResetValues();

            btnDEL.Visible = true;
            btnEDIT.Visible = true;
            btnADD.Enabled = true;
            btnSAVE.Enabled = false;
            txtSDT.Enabled = false;
            txtSearch.Enabled = true;
        }

        //click vào dgv thì hiện thị thông tin ra textbox
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSDT.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            KHACHHANGDTO i = KHACHHANGDAO.Instance.getBySDT(txtSDT.Text);
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Chưa chọn đối tượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtSDT.Enabled = true;

            KHACHHANGDAO.Instance.SuaKH(i.SDT, txtTenKH.Text, txtDiaChi.Text);

            LoadDGV();
            ResetValues();
            txtSDT.Enabled = false;
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.ShowDialog();
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            KHACHHANGDTO i = KHACHHANGDAO.Instance.getBySDT(txtSDT.Text);
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn đối tượng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Kiểm tra xem có hóa đơn nào chứa SDT không

            if (HOADONDAO.Instance.getNowBySDT(i.SDT) != null)
            {
                // Nếu có, xác nhận xóa hóa đơn trước
                if (MessageBox.Show("" + txtTenKH.Text.Trim() + " đã được sử dụng trong hóa đơn. Bạn có muốn xóa hóa đơn trước khi xóa khách hàng này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Xóa hóa đơn chứa SDT tương ứng
                    KHACHHANGDAO.Instance.XoaKH(txtSDT.Text);
                    LoadDGV();
                }
                else
                {
                    // Nếu người dùng không muốn xóa hóa đơn, thoát phương thức
                    return;
                }
            }
            if (MessageBox.Show("Xác nhận xóa khách hàng: " + txtTenKH.Text.Trim() + " ?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                //câu lệnh xóa KH thông qua SDT
                KHACHHANGDAO.Instance.XoaKH(txtSDT.Text);

                LoadDGV();
                ResetValues();
            }
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtSearch.Text.Trim();

            // Tạo DataTable để lưu kết quả từ truy vấn
            DataTable dataTable = new DataTable();

            // Thực hiện truy vấn SQL để lấy thông tin từ bảng KhachHang dựa trên từ khóa tìm kiếm
            string chuoiLenh = "SELECT * FROM KHACHHANG WHERE SDT LIKE '%" + tuKhoa + "%' OR TenKH LIKE N'%" + tuKhoa + "%' OR DiaChi LIKE N'%" + tuKhoa + "%'";
            dataTable = Functions.GetDataToTable(chuoiLenh);

            // Hiển thị kết quả trên DataGridView
            dgvKhachHang.DataSource = dataTable;

            tlSoLuong.Text = dgvKhachHang.Rows.Count.ToString();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSDT.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDGV();
            txtSearch.Clear();
            txtSDT.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
        }
    }
}