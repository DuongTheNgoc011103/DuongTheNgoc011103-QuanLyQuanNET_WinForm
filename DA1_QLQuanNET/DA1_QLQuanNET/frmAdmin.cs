using DA1_QLQuanNET.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA1_QLQuanNET
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void ADMIN_Load(object sender, EventArgs e)
        {
            LoadTTADMIN();
        }

        //Load thông tin Admin
        public void LoadTTADMIN()
        {
            DataTable data = Functions.Instance.RunQuery("SELECT * FROM TAIKHOAN");

            // Bước 2: Truy cập giá trị cụ thể từ DataTable
            if (data.Rows.Count > 0)
            {
                string taiKhoan = data.Rows[0]["TaiKhoan"].ToString();
                string matKhau = data.Rows[0]["MatKhau"].ToString();
                string anhAD = data.Rows[0]["AnhAD"].ToString();

                lblName.Text = taiKhoan;
                txtTK.Text = taiKhoan;
                txtMK.Text = matKhau;
                txtAnhAD.Text = anhAD;
                picAnhAD.Image = Image.FromFile(txtAnhAD.Text);
            }
            txtTK.Enabled = false;
            txtMK.Enabled = false;
            txtAnhAD.Visible = false;
            lblYES.Visible = false;
            lblNO.Visible = false;
            btnReload.Enabled = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            frmMenu.HandleClosing(e);
            base.OnClosing(e);
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog(); // khởi tạo
            dlgOpen.Filter = "JPEG(*.jpg)|*.jpg|PNG(*.png)|*.png|All files(*.*)|*.*";
            //các loại file ảnh

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnhAD.Image = Image.FromFile(dlgOpen.FileName);
                txtAnhAD.Text = dlgOpen.FileName;
            }
        }

        private void lblDoiTT_Click(object sender, EventArgs e)
        {
            txtTK.Enabled = true;
            txtMK.Enabled = true;
            lblDoiTT.Visible = false;
            lblYES.Visible = true;
            lblNO.Visible = true;
            btnReload.Enabled = true;
        }

        private void lblNO_Click(object sender, EventArgs e)
        {
            LoadTTADMIN();
            lblDoiTT.Visible = true;
        }

        private void lblYES_Click(object sender, EventArgs e)
        {
            if (txtTK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTK.Focus();
                return;
            }
            if (txtMK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMK.Focus();
                return;
            }
            if (MessageBox.Show("Xác nhận thay đổi thông tin?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                TAIKHOANDAO.Instance.SuaTTADMIN(txtTK.Text, txtMK.Text, txtAnhAD.Text);
                LoadTTADMIN();
                lblDoiTT.Visible = true;
            }
        }
    }
}