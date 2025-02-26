using DA1_QLQuanNET.DAO;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace DA1_QLQuanNET
{
    public partial class frmDangNhap : Form
    {
        private Color originalColor;

        public frmDangNhap()
        {
            InitializeComponent();
            btn_dangNhap.BackColor = originalColor;
        }

        public bool DangNhap(string taiKhoan, string matKhau)
        {
            DataTable data = Functions.Instance.RunQuery("SELECT * FROM TAIKHOAN WHERE TaiKhoan = N'" + taiKhoan + "' AND MatKhau = N'" + matKhau + "'");
            foreach (DataRow row in data.Rows)
            {
                return true;
            }
            return false;
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            //so sánh giá trị đã khai báo với giá trị trên textbox
            if (DangNhap(txtTaiKhoan.Text, txtMatKhau.Text) == true)
            {
                Functions.Connect();
                frmTrangChu main = new frmTrangChu();
                this.Hide(); // form đăng nhập ẩn đi
                main.Show(); // form main hiển thị ra
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_HienThi_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = chk_HienThi.Checked ? '\0' : '*'; // nếu kiểu trong textbox mật khẩu là paswordchar thì khi check vào sẽ hiện ra mật khẩu, ngược lại
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            frmMenu.HandleClosing(e);
            base.OnClosing(e);
        }

        // thực hiện enter thay cho click btn_DangNhap
        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_dangNhap.PerformClick();
            }
        }

        private void btn_dangNhap_MouseEnter(object sender, EventArgs e)
        {
            btn_dangNhap.BackColor = Color.Blue;
        }

        private void btn_dangNhap_MouseLeave(object sender, EventArgs e)
        {
            btn_dangNhap.BackColor = originalColor;
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // Run the query to get the DataTable
            DataTable dt = Functions.Instance.RunQuery("SELECT * FROM TAIKHOAN");

            // Check if the DataTable has rows and retrieve the first row's TaiKhoan value
            if (dt.Rows.Count > 0)
            {
                string taiKhoan = dt.Rows[0]["TaiKhoan"].ToString();
                string matKhau = dt.Rows[0]["MatKhau"].ToString();
                txtTaiKhoan.Text = taiKhoan;
                txtMatKhau.Text = matKhau;
            }
        }
    }
}