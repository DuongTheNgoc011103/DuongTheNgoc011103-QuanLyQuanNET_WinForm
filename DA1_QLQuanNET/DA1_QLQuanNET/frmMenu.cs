using DA1_QLQuanNET.DAO;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DA1_QLQuanNET
{
    public partial class frmMenu : Form
    {
        private Color originalColor = HexToColor("#2D9596");
        private Color originalColor2 = HexToColor("#003C43");

        public frmMenu()
        {
            InitializeComponent();
            btnMay.BackColor = originalColor;
            btnHoadon.BackColor = originalColor;
            btnKhachhang.BackColor = originalColor;
            btnDichvu.BackColor = originalColor;

            button5.BackColor = originalColor2;
        }

        //btn MÁY
        private void btnMay_MouseEnter(object sender, EventArgs e)
        {
            btnMay.BackColor = Color.White;
            btnMay.ForeColor = Color.Black;
        }

        private void btnMay_MouseLeave(object sender, EventArgs e)
        {
            btnMay.BackColor = originalColor;
        }

        //btn KHÁCH HÀNG
        private void btnKhachHang_MouseEnter(object sender, EventArgs e)
        {
            btnKhachhang.BackColor = Color.White;
            btnKhachhang.ForeColor = Color.Black;
        }

        private void btnKhachHang_MouseLeave(object sender, EventArgs e)
        {
            btnKhachhang.BackColor = originalColor;
        }

        //btn DỊCH VỤ
        private void btnDichvu_MouseEnter(object sender, EventArgs e)
        {
            btnDichvu.BackColor = Color.White;
            btnDichvu.ForeColor = Color.Black;
        }

        private void btnDichvu_MouseLeave(object sender, EventArgs e)
        {
            btnDichvu.BackColor = originalColor;
        }

        //btn HÓA ĐƠN
        private void btnHoadon_MouseEnter(object sender, EventArgs e)
        {
            btnHoadon.BackColor = Color.White;
            btnHoadon.ForeColor = Color.Black;
        }

        private void btnHoadon_MouseLeave(object sender, EventArgs e)
        {
            btnHoadon.BackColor = originalColor;
        }

        //btn TRANG CHỦ
        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
            button5.ForeColor = Color.Black;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = originalColor2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrangChu main = new frmTrangChu();
            main.ShowDialog();
        }

        private void btnMay_Click(object sender, EventArgs e)
        {
            frmMay may = new frmMay();
            this.Hide();
            may.ShowDialog();
        }

        // Hàm chuyển đổi chuỗi HEX sang Color
        public static Color HexToColor(string hex)
        {
            // Kiểm tra chuỗi hex có hợp lệ không
            if (!hex.StartsWith("#") || (hex.Length != 7 && hex.Length != 9))
            {
                throw new ArgumentException("Invalid HEX color string.");
            }

            byte a = 255; // Mặc định giá trị alpha là 255 (đối với mã HEX 7 ký tự)
            if (hex.Length == 9) // Nếu mã HEX có 9 ký tự, chiều dài của alpha channel
            {
                a = Convert.ToByte(hex.Substring(1, 2), 16); // Lấy giá trị alpha từ HEX
                hex = hex.Substring(3); // Loại bỏ phần alpha khỏi chuỗi HEX
            }

            // Chuyển đổi giá trị RGB từ chuỗi HEX
            byte r = Convert.ToByte(hex.Substring(1, 2), 16);
            byte g = Convert.ToByte(hex.Substring(3, 2), 16);
            byte b = Convert.ToByte(hex.Substring(5, 2), 16);

            // Tạo và trả về đối tượng Color
            return Color.FromArgb(a, r, g, b);
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            this.Hide();
            kh.ShowDialog();
        }

        public static bool IsAppExitting = false;

        public static void HandleClosing(CancelEventArgs e)
        {
            if (!IsAppExitting)
            {
                DialogResult result;
                result = MessageBox.Show("Bạn muốn thoát chương trình.", "Thông báo.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {
                    IsAppExitting = true;
                    Application.Exit();
                }
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            frmMenu.HandleClosing(e);
            base.OnClosing(e);
        }

        private void btnDichvu_Click(object sender, EventArgs e)
        {
            frmDichVu dv = new frmDichVu();
            this.Hide();
            dv.ShowDialog();
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            frmHoaDon hd = new frmHoaDon();
            this.Hide();
            hd.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Functions.Disconnect();
        }

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin ad = new frmAdmin();
            this.Hide();
            ad.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            DataTable data = Functions.Instance.RunQuery("SELECT AnhAD FROM TAIKHOAN");

            string anhAD = data.Rows[0]["AnhAD"]?.ToString();
            if (!string.IsNullOrEmpty(anhAD))
            {
                picAnhAD.Image = Image.FromFile(anhAD);
            }
            else
            {
                MessageBox.Show("Không có ảnh đại diện được lưu trong cơ sở dữ liệu.");
            }

        }

        private void picAnhAD_Click(object sender, EventArgs e)
        {
            frmAdmin ad = new frmAdmin();
            this.Hide();
            ad.ShowDialog();
        }
    }
}