using DA1_QLQuanNET.DAO;
using DA1_QLQuanNET.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace DA1_QLQuanNET
{
    public partial class frmTrangChu : Form
    {
        private string maMay;

        //Khai báo hàm timer để load dữ liệu liên tục
        private Timer timer;

        public frmTrangChu()
        {
            InitializeComponent();
            // Khởi tạo timer
            timer = new Timer();
            timer.Interval = 1000; //đặt interval là 1000 milliseconds(1 giây)
            timer.Tick += Timer_Tick;

            // Bắt đầu timer
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Gọi hàm cập nhật tổng thời gian mỗi giây
            ShowHoaDon();
        }

        //load ds khách hàng vào combobox
        private void loadCBKH()
        {
            //lấy dữ liệu từ KHACHHANG
            string chuoiLenh = "SELECT * FROM KHACHHANG";
            //đưa vào dạng datatable
            DataTable dsKH = Functions.GetDataToTable(chuoiLenh);

            // Tạo một DataView từ DataTable để sắp xếp dữ liệu theo cột "TenKH"
            DataView dv = dsKH.DefaultView;
            dv.Sort = "TenKH ASC"; // Sắp xếp theo tên khách hàng theo thứ tự tăng dần

            foreach (DataRowView dt in dv) // lặp qua các đối tượng có trong datatable
            {
                string tenKH_SDT = dt["TenKH"] + " - " + dt["SDT"]; //lấy TenKH và SDT
                cbkhachhang.Items.Add(tenKH_SDT);
            }

            cbkhachhang.SelectedIndex = 0;//lấy vị trí đầu tiên hiện ra combobox
        }

        //load ds dịch vụ vào combobox
        private void loadCBDV()
        {
            string chuoiLenh = "SELECT * FROM DICHVU";
            DataTable dsDV = Functions.GetDataToTable(chuoiLenh);

            for (int i = 1; i < dsDV.Rows.Count; i++) //lấy danh sách dichvu từ vị trí 1 trở đi
                                                      //vì dichvu NET tự động thêm khi mở máy
            {
                DataRow row = dsDV.Rows[i];
                cbDichVu.Items.Add(row["TenDV"]);
            }

            cbDichVu.Text = cbDichVu.Items[0].ToString();
        }

        //Load DS Máy
        private void LoadDSMAY()
        {
            flpnMay.Controls.Clear(); //làm sạch lại các dữ liệu

            //Lấy ds Máy từ Data
            string chuoiLenh = "SELECT * FROM MAY";
            DataTable danhSachMay = Functions.GetDataToTable(chuoiLenh);

            foreach (DataRow row in danhSachMay.Rows)
            {
                // 1 máy là 1 btn
                Button bt = new Button() { Width = 150, Height = 100, Margin = new Padding(15) };
                bt.Text = row["TenMay"].ToString() + "\n\n" + row["TrangThaiMay"].ToString();

                //thêm sự kiện click vào các button
                bt.Click += bt_Click;
                bt.Tag = row["MaMay"].ToString();

                //đổi màu cho các button theo trạng thái máy
                string trangThaiMay = row["TrangThaiMay"].ToString();
                if (trangThaiMay == "Đang dùng")
                    bt.BackColor = Color.Aqua;
                else
                    bt.BackColor = Color.Gray;

                flpnMay.Controls.Add(bt);
            }
        }

        public void bt_Click(object sender, EventArgs e)
        {
            maMay = (sender as Button).Tag as string;
            // Lấy trạng thái của máy từ cơ sở dữ liệu
            string chuoiLenh = "SELECT TrangThaiMay FROM MAY WHERE MaMay = '" + maMay + "'";
            DataTable dt = Functions.GetDataToTable(chuoiLenh);

            string trangThaiMay = dt.Rows[0]["TrangThaiMay"].ToString();

            // Kiểm tra nếu máy đang trống
            if (trangThaiMay == "Trống")
            {
                // Thực hiện clear các textbox
                Clear_TB();
            }
            else
            {
                // Hiển thị hóa đơn của máy
                ShowHoaDon();
            }
        }

        // clear textbox khi bt_click vào máy trống
        private void Clear_TB()
        {
            txtKhachHang.Clear();
            txtTimeBD.Clear();
            txtTimeToTal.Clear();
            txTongTien.Clear();
            txtTimKiem.Clear();
        }

        //Show HÓA ĐƠN
        private void ShowHoaDon()
        {
            dgvCTHD.Rows.Clear(); //xóa các dgv cũ khi show mới

            HOADONDTO hd = HOADONDAO.Instance.getNowByMaMay(maMay); //lấy mã máy trong hóa đơn(TrangThaiHD = Chưa Thanh Toán)
            if (hd == null) //nếu không có hoặc TrangThaiHD = Đã Thanh Toán
                return;

            KHACHHANGDTO kh = KHACHHANGDAO.Instance.getBySDT(hd.SDT); //lấy SDT từ KHACHHANG
            txtKhachHang.Text = kh.TenKH + " - " + kh.SDT; //lấy TenKH và SDT hiển thị ở txtKhachHang

            txtTimeBD.Text = hd.TGBatDau.ToString(); //giá trị hiện ra ở txtTimeBD

            //TimeSpan giúp tính thời gian giữa hai khoảng TG
            TimeSpan total = DateTime.Now - hd.TGBatDau;
            txtTimeToTal.Text = total.Hours + total.Days * 24 + " Giờ " + total.Minutes + ":" + total.Seconds;

            //Tính Theo Giờ
            float soGio = total.Hours + (float)(total.Minutes / 60.0);
            HOADONDAO.Instance.capNhatTime(hd.MaHD, soGio);

            HOADONDAO.Instance.getByMaHD(hd.MaHD); //lấy MaHD tồn tại trong HOADON
            List<CTHOADONDTO> l = CTHOADONDAO.Instance.loadDSByMaHD(hd.MaHD); //load dgvCTHOADON thông qua MaHD
            int stt = 0;
            foreach (CTHOADONDTO i in l)
            {
                stt++;
                DICHVUDTO dv = DICHVUDAO.Instance.getByMaDV(i.MaDV); //lấy MaDV
                //Thêm vào dgvCTHOADON
                dgvCTHD.Rows.Add(stt, dv.TenDV, dv.DVTinh, i.SoLuong, Functions.Instance.getDinhDanhHangNghin((int)i.DonGia), Functions.Instance.getDinhDanhHangNghin((int)(i.SoLuong * i.DonGia)) + " VNĐ");
            }
            txTongTien.Text = Functions.Instance.getDinhDanhHangNghin(hd.TongTien);
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            loadCBKH();

            loadCBDV();

            Clear_TB();

            LoadDSMAY();
        }

        //BtnBACK đưa về trang trước đó
        private void btnBACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
        }

        // Sự kiện khi chọn máy và thực hiện mở máy
        private void btnMoMay_Click(object sender, EventArgs e)
        {
            //lấy mã máy
            MAYDTO m = MAYDAO.Instance.getByMaMay(maMay);
            if (m == null) //nếu chưa có thì báo lỗi
            {
                MessageBox.Show("Hãy chọn máy cần mở trước !", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (m.TrangThaiMay == "Đang Dùng") //nếu đang dùng thì thông báo cần đổi máy khác
            {
                MessageBox.Show("Máy hiện tại đang sử dụng !", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Lấy giá trị SDT từ chuỗi TenKH và SDT của cbkhachhang
            string kh = cbkhachhang.Text; //tạo kh lấy giá trị của cbkhachhang
            string sdt = ""; // tạo biến sdt với chuỗi rỗng để lưu trữ
            for (int j = kh.Length - 1; j >= 0; j--)
            {
                if (kh[j] == ' ') //lặp khi gặp khoảng cách
                    break; //thì dừng
                sdt = kh[j] + sdt; // lấy giá trị từ sau dấu cách đó gán cho sdt
            }

            if (HOADONDAO.Instance.getNowBySDT(sdt) != null)//nếu SDT tồn tại và TrangThaiHD = Chưa Thanh Toán
            {
                MessageBox.Show("Khách hàng này đang sử dụng 1 máy khác !", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            KHACHHANGDTO k = KHACHHANGDAO.Instance.getBySDT(sdt);//lấy khách hàng thông qua số điện thoại
            if (MessageBox.Show("Xác nhận mở máy '" + m.TenMay + "' cho khách hàng '" + k.TenKH + "'? !", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                // Khách hàng chưa tồn tại trong hóa đơn, tiến hành mở máy
                Functions.Instance.RunQuery("UPDATE MAY SET TrangThaiMay = N'Đang dùng' WHERE MaMay = '" + maMay + "'");

                //Thêm vào HOADON
                HOADONDAO.Instance.ThemHD(new HOADONDTO(null, sdt, maMay, DateTime.Now, DateTime.Now, 0, "Chưa Thanh Toán"));

                //Lấy MaHD đó
                HOADONDTO hd = HOADONDAO.Instance.getNowByMaMay(maMay);
                //Thêm vào CTHOADON với loại DICHVU là NET
                /*Functions.Instance.RunQuery("INSERT INTO CTHOADON(MaHD,MaDV,SoLuong,DonGia) VALUES ('" + hd.MaHD + "', 'DV001', 0, " + DICHVUDAO.Instance.getByMaDV("DV001").DonGia + ")");*/

                LoadDSMAY();
                ShowHoaDon();
                MessageBox.Show("Mở máy thành công !", "Thông báo");
            }
            radOFF.Checked = false;
            radOFF.Checked = false;
        }

        //Thanh Toán HOADON
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            //thực hiện đóng máy
            MAYDTO may = MAYDAO.Instance.getByMaMay(maMay);
            if (may == null)//nếu chưa có chọn
            {
                MessageBox.Show("Hãy chọn máy cần thanh toán trước !", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (may.TrangThaiMay == "Trống") //nếu máy trống thì thông báo đổi
            {
                MessageBox.Show("Máy hiện tại chưa sử dụng !", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (may.TrangThaiMay == "Đang dùng") //nếu đang dùng thì thực hiện mở máy
            {
                if (MessageBox.Show("Xác nhận THANH TOÁN máy '" + may.TenMay + "'?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    HOADONDTO hd = HOADONDAO.Instance.getNowByMaMay(maMay);//lấy mã máy từ hóa đơn đang tồn tại
                    HOADONDAO.Instance.thanhToan(hd.MaHD); //thanh toán hóa đơn chứa mã máy đó
                    LoadDSMAY();
                    ShowHoaDon();
                    MessageBox.Show("Thanh toán thành công !", "Thông báo");
                }
            }
            Clear_TB();
            radON.Checked = false;
            radOFF.Checked = false;
            LoadDSMAY();
        }

        // Sự kiện đóng form
        protected override void OnClosing(CancelEventArgs e)
        {
            frmMenu.HandleClosing(e);
            base.OnClosing(e);
        }

        //Hủy Hóa Đơn
        private void btnHuy_Click(object sender, EventArgs e)
        {
            //thực hiện hủy máy
            MAYDTO may = MAYDAO.Instance.getByMaMay(maMay); //lấy mã máy ở button
            HOADONDTO hd = HOADONDAO.Instance.getNowByMaMay(maMay);

            if (may == null) //nếu chưa chọn thì thông báo
            {
                MessageBox.Show("Hãy chọn máy cần HỦY trước !", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (may.TrangThaiMay == "Trống") //máy trống thì thông báo
            {
                MessageBox.Show("Máy hiện tại chưa sử dụng !", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (may.TrangThaiMay == "Đang dùng") //nếu đang dùng thì thực hiện
            {
                DialogResult result = MessageBox.Show("Xác nhận HỦY '" + may.TenMay + "' ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    HOADONDAO.Instance.XoaHD(hd.MaHD); //xóa hóa đơn chứa mã máy đó
                    Clear_TB();
                    // Tải lại danh sách máy
                    LoadDSMAY();
                    // Hiển thị thông báo
                    MessageBox.Show("Đã hủy : " + may.TenMay, "Thông báo", MessageBoxButtons.OK);
                }
            }

            Clear_TB();
            radON.Checked = false;
            radOFF.Checked = false;
            LoadDSMAY();
        }

        //Thêm DICHVU cho MAY
        private void btnthemDV_Click(object sender, EventArgs e)
        {
            HOADONDTO hd = HOADONDAO.Instance.getNowByMaMay(maMay); // lấy mã máy đang dùng ở hóa đơn
            if (hd == null) // nếu chưa chọn hóa đơn
            {
                MessageBox.Show("Hãy chọn máy có hóa đơn trước!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DICHVUDTO dv = DICHVUDAO.Instance.getByTenDV(cbDichVu.Text); // lấy tên dịch vụ
            if (dv == null) // nếu chưa chọn dịch vụ
            {
                MessageBox.Show("Hãy chọn dịch vụ trước!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numSoLuongDV.Value == 0) // nếu số lượng đang là 0
            {
                MessageBox.Show("Số lượng phải khác 0!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dv.SoLuong < (float)numSoLuongDV.Value)
            {
                MessageBox.Show("Không đủ số lượng cần thêm.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dv.SoLuong >= (float)numSoLuongDV.Value)
            {
                // thêm dịch vụ vào chi tiết hóa đơn của hóa đơn với trạng thái chưa thanh toán
                CTHOADONDAO.Instance.ThemCTHD(new CTHOADONDTO(null, hd.MaHD, dv.MaDV, dv.DonGia, (int)numSoLuongDV.Value));

                ShowHoaDon();
            }

            // reset lại giá trị về 0
            numSoLuongDV.Value = 0;
        }

        //Tìm KHACHHANG bằng SDT
        private void btnTim_Click(object sender, EventArgs e)
        {
            radOFF.Checked = false;
            radOFF.Checked = false;
            string timKiem = txtTimKiem.Text.Trim(); //gán biến vào txtTimKiem

            // Xóa tất cả các button đã tồn tại trong FlowLayoutPanel
            flpnMay.Controls.Clear();

            // Truy vấn SQL để lấy danh sách máy theo SDT và trạng thái hóa đơn chưa thanh toán
            DataTable danhSachMayBy = MAYDAO.Instance.getMayNowBySDT(timKiem);

            if (danhSachMayBy.Rows.Count != 0)
            {
                foreach (DataRow row in danhSachMayBy.Rows)
                {
                    // Tạo mới một button cho mỗi máy
                    Button bt = new Button() { Width = 150, Height = 100, Margin = new Padding(15) };
                    bt.Text = row["TenMay"].ToString() + "\n\n" + row["TrangThaiMay"].ToString();

                    bt.Click += bt_Click; // Gắn sự kiện click cho button
                    bt.Tag = row["MaMay"].ToString(); // Lưu trữ mã máy vào Tag của button
                    bt.BackColor = Color.Aqua; // Đặt màu nền cho button

                    // Thêm button vào FlowLayoutPanel
                    flpnMay.Controls.Add(bt);
                }
            }
            else
            {
                KHACHHANGDAO.Instance.getBySDT(timKiem);//lấy sdt ở txtTimKiem tìm ở KHACHHANG
                MessageBox.Show("KHông tìm thấy khách hàng có SDT : '" + timKiem + "'", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSMAY();
            }
        }

        //load lại DSMAY
        private void btnReload_Click(object sender, EventArgs e)
        {
            Clear_TB();
            radON.Checked = false;
            radOFF.Checked = false;
            LoadDSMAY();
        }

        private void radON_CheckedChanged(object sender, EventArgs e)
        {
            flpnMay.Controls.Clear();
            // Truy vấn SQL để lấy danh sách máy theo SDT và trạng thái hóa đơn chưa thanh toán
            DataTable danhSachMayON = MAYDAO.Instance.getMayNow("Đang Dùng");

            if (danhSachMayON.Rows.Count != 0)
            {
                foreach (DataRow row in danhSachMayON.Rows)
                {
                    // Tạo mới một button cho mỗi máy
                    Button bt = new Button() { Width = 150, Height = 100, Margin = new Padding(15) };
                    bt.Text = row["TenMay"].ToString() + "\n\n" + row["TrangThaiMay"].ToString();

                    bt.Click += bt_Click; // Gắn sự kiện click cho button
                    bt.Tag = row["MaMay"].ToString(); // Lưu trữ mã máy vào Tag của button
                    bt.BackColor = Color.Aqua; // Đặt màu nền cho button

                    // Thêm button vào FlowLayoutPanel
                    flpnMay.Controls.Add(bt);
                }
            }
        }

        private void radOFF_CheckedChanged(object sender, EventArgs e)
        {
            flpnMay.Controls.Clear();
            // Truy vấn SQL để lấy danh sách máy theo SDT và trạng thái hóa đơn chưa thanh toán
            DataTable danhSachMayON = MAYDAO.Instance.getMayNow("Trống");

            if (danhSachMayON.Rows.Count != 0)
            {
                foreach (DataRow row in danhSachMayON.Rows)
                {
                    // Tạo mới một button cho mỗi máy
                    Button bt = new Button() { Width = 150, Height = 100, Margin = new Padding(15) };
                    bt.Text = row["TenMay"].ToString() + "\n\n" + row["TrangThaiMay"].ToString();

                    bt.Click += bt_Click; // Gắn sự kiện click cho button
                    bt.Tag = row["MaMay"].ToString(); // Lưu trữ mã máy vào Tag của button
                    bt.BackColor = Color.Gray; // Đặt màu nền cho button

                    // Thêm button vào FlowLayoutPanel
                    flpnMay.Controls.Add(bt);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}