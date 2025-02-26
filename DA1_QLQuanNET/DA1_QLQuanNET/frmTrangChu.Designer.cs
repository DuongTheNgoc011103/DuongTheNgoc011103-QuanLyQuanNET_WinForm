namespace DA1_QLQuanNET
{
    partial class frmTrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.flpnMay = new System.Windows.Forms.FlowLayoutPanel();
            this.radOFF = new System.Windows.Forms.RadioButton();
            this.radON = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.txtTimeToTal = new System.Windows.Forms.TextBox();
            this.lblTimeStart = new System.Windows.Forms.Label();
            this.txtTimeBD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnthemDV = new System.Windows.Forms.Button();
            this.numSoLuongDV = new System.Windows.Forms.NumericUpDown();
            this.cbkhachhang = new System.Windows.Forms.ComboBox();
            this.cbDichVu = new System.Windows.Forms.ComboBox();
            this.btnMoMay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtVND = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBACK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongDV)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1412, 764);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(976, 716);
            this.panel3.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(976, 716);
            this.panel5.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dgvCTHD);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 504);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(976, 212);
            this.panel9.TabIndex = 2;
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AllowUserToAddRows = false;
            this.dgvCTHD.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenDV,
            this.DVTinh,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTHD.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTHD.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCTHD.EnableHeadersVisualStyles = false;
            this.dgvCTHD.Location = new System.Drawing.Point(0, 0);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersWidth = 51;
            this.dgvCTHD.RowTemplate.Height = 24;
            this.dgvCTHD.Size = new System.Drawing.Size(976, 212);
            this.dgvCTHD.TabIndex = 3;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 117;
            // 
            // TenDV
            // 
            this.TenDV.HeaderText = "Tên Dịch Vụ";
            this.TenDV.MinimumWidth = 6;
            this.TenDV.Name = "TenDV";
            this.TenDV.Width = 250;
            // 
            // DVTinh
            // 
            this.DVTinh.HeaderText = "Đơn Vị Tính";
            this.DVTinh.MinimumWidth = 6;
            this.DVTinh.Name = "DVTinh";
            this.DVTinh.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 200;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 240;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnReload);
            this.panel8.Controls.Add(this.flpnMay);
            this.panel8.Controls.Add(this.radOFF);
            this.panel8.Controls.Add(this.radON);
            this.panel8.Controls.Add(this.button1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(976, 504);
            this.panel8.TabIndex = 0;
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReload.BackgroundImage")));
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReload.Location = new System.Drawing.Point(915, 62);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(55, 42);
            this.btnReload.TabIndex = 22;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // flpnMay
            // 
            this.flpnMay.AutoScroll = true;
            this.flpnMay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(254)))), ((int)(((byte)(247)))));
            this.flpnMay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnMay.Location = new System.Drawing.Point(0, 110);
            this.flpnMay.Name = "flpnMay";
            this.flpnMay.Size = new System.Drawing.Size(976, 394);
            this.flpnMay.TabIndex = 1;
            // 
            // radOFF
            // 
            this.radOFF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radOFF.AutoSize = true;
            this.radOFF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.radOFF.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOFF.ForeColor = System.Drawing.Color.White;
            this.radOFF.Location = new System.Drawing.Point(842, 76);
            this.radOFF.Name = "radOFF";
            this.radOFF.Size = new System.Drawing.Size(70, 28);
            this.radOFF.TabIndex = 18;
            this.radOFF.TabStop = true;
            this.radOFF.Text = "OFF";
            this.radOFF.UseVisualStyleBackColor = false;
            this.radOFF.CheckedChanged += new System.EventHandler(this.radOFF_CheckedChanged);
            // 
            // radON
            // 
            this.radON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radON.AutoSize = true;
            this.radON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.radON.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radON.ForeColor = System.Drawing.Color.White;
            this.radON.Location = new System.Drawing.Point(775, 76);
            this.radON.Name = "radON";
            this.radON.Size = new System.Drawing.Size(61, 28);
            this.radON.TabIndex = 17;
            this.radON.TabStop = true;
            this.radON.Text = "ON";
            this.radON.UseVisualStyleBackColor = false;
            this.radON.CheckedChanged += new System.EventHandler(this.radON_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(976, 110);
            this.button1.TabIndex = 16;
            this.button1.Text = "DANH SÁCH MÁY";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.btnTim);
            this.panel4.Controls.Add(this.btnthemDV);
            this.panel4.Controls.Add(this.numSoLuongDV);
            this.panel4.Controls.Add(this.cbkhachhang);
            this.panel4.Controls.Add(this.cbDichVu);
            this.panel4.Controls.Add(this.btnMoMay);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lbl2);
            this.panel4.Controls.Add(this.txtTimKiem);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.lbl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(976, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(436, 716);
            this.panel4.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.grpThongTin);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 371);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(436, 235);
            this.panel6.TabIndex = 21;
            // 
            // grpThongTin
            // 
            this.grpThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.grpThongTin.Controls.Add(this.label2);
            this.grpThongTin.Controls.Add(this.txtKhachHang);
            this.grpThongTin.Controls.Add(this.txtTimeToTal);
            this.grpThongTin.Controls.Add(this.lblTimeStart);
            this.grpThongTin.Controls.Add(this.txtTimeBD);
            this.grpThongTin.Controls.Add(this.label3);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpThongTin.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTin.Location = new System.Drawing.Point(0, 0);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(436, 235);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông Tin";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(22, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "Khách Hàng :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.BackColor = System.Drawing.SystemColors.Menu;
            this.txtKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKhachHang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhachHang.ForeColor = System.Drawing.Color.Firebrick;
            this.txtKhachHang.Location = new System.Drawing.Point(21, 165);
            this.txtKhachHang.Multiline = true;
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(394, 33);
            this.txtKhachHang.TabIndex = 6;
            this.txtKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTimeToTal
            // 
            this.txtTimeToTal.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTimeToTal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimeToTal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeToTal.ForeColor = System.Drawing.Color.Firebrick;
            this.txtTimeToTal.Location = new System.Drawing.Point(237, 75);
            this.txtTimeToTal.Multiline = true;
            this.txtTimeToTal.Name = "txtTimeToTal";
            this.txtTimeToTal.Size = new System.Drawing.Size(178, 33);
            this.txtTimeToTal.TabIndex = 13;
            this.txtTimeToTal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTimeStart
            // 
            this.lblTimeStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimeStart.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeStart.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTimeStart.Location = new System.Drawing.Point(26, 39);
            this.lblTimeStart.Name = "lblTimeStart";
            this.lblTimeStart.Size = new System.Drawing.Size(202, 33);
            this.lblTimeStart.TabIndex = 9;
            this.lblTimeStart.Text = "Bắt Đầu :";
            this.lblTimeStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimeBD
            // 
            this.txtTimeBD.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTimeBD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimeBD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeBD.ForeColor = System.Drawing.Color.Firebrick;
            this.txtTimeBD.Location = new System.Drawing.Point(26, 75);
            this.txtTimeBD.Multiline = true;
            this.txtTimeBD.Name = "txtTimeBD";
            this.txtTimeBD.Size = new System.Drawing.Size(202, 33);
            this.txtTimeBD.TabIndex = 10;
            this.txtTimeBD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(237, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 33);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tổng Thời gian :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(93)))), ((int)(((byte)(102)))));
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(298, 29);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(117, 45);
            this.btnTim.TabIndex = 20;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnthemDV
            // 
            this.btnthemDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(93)))), ((int)(((byte)(102)))));
            this.btnthemDV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemDV.ForeColor = System.Drawing.Color.White;
            this.btnthemDV.Location = new System.Drawing.Point(320, 277);
            this.btnthemDV.Name = "btnthemDV";
            this.btnthemDV.Size = new System.Drawing.Size(95, 33);
            this.btnthemDV.TabIndex = 19;
            this.btnthemDV.Text = "Thêm ";
            this.btnthemDV.UseVisualStyleBackColor = false;
            this.btnthemDV.Click += new System.EventHandler(this.btnthemDV_Click);
            // 
            // numSoLuongDV
            // 
            this.numSoLuongDV.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoLuongDV.ForeColor = System.Drawing.Color.Red;
            this.numSoLuongDV.Location = new System.Drawing.Point(320, 316);
            this.numSoLuongDV.Name = "numSoLuongDV";
            this.numSoLuongDV.Size = new System.Drawing.Size(95, 32);
            this.numSoLuongDV.TabIndex = 18;
            this.numSoLuongDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbkhachhang
            // 
            this.cbkhachhang.DropDownHeight = 120;
            this.cbkhachhang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkhachhang.FormattingEnabled = true;
            this.cbkhachhang.IntegralHeight = false;
            this.cbkhachhang.ItemHeight = 24;
            this.cbkhachhang.Location = new System.Drawing.Point(26, 158);
            this.cbkhachhang.Name = "cbkhachhang";
            this.cbkhachhang.Size = new System.Drawing.Size(389, 32);
            this.cbkhachhang.TabIndex = 17;
            // 
            // cbDichVu
            // 
            this.cbDichVu.DropDownHeight = 120;
            this.cbDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDichVu.FormattingEnabled = true;
            this.cbDichVu.IntegralHeight = false;
            this.cbDichVu.Location = new System.Drawing.Point(26, 316);
            this.cbDichVu.Name = "cbDichVu";
            this.cbDichVu.Size = new System.Drawing.Size(288, 32);
            this.cbDichVu.TabIndex = 16;
            // 
            // btnMoMay
            // 
            this.btnMoMay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(93)))), ((int)(((byte)(102)))));
            this.btnMoMay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoMay.ForeColor = System.Drawing.Color.White;
            this.btnMoMay.Location = new System.Drawing.Point(137, 207);
            this.btnMoMay.Name = "btnMoMay";
            this.btnMoMay.Size = new System.Drawing.Size(163, 45);
            this.btnMoMay.TabIndex = 15;
            this.btnMoMay.Text = "Mở Máy";
            this.btnMoMay.UseVisualStyleBackColor = false;
            this.btnMoMay.Click += new System.EventHandler(this.btnMoMay_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(26, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Loại Dịch Vụ :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl2
            // 
            this.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl2.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl2.Location = new System.Drawing.Point(26, 122);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(156, 33);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "Khách Hàng :";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Location = new System.Drawing.Point(22, 77);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(393, 33);
            this.txtTimKiem.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel7.Controls.Add(this.txtVND);
            this.panel7.Controls.Add(this.btnThanhToan);
            this.panel7.Controls.Add(this.btnHuy);
            this.panel7.Controls.Add(this.txTongTien);
            this.panel7.Controls.Add(this.lblTongTien);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 606);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(436, 110);
            this.panel7.TabIndex = 1;
            // 
            // txtVND
            // 
            this.txtVND.BackColor = System.Drawing.SystemColors.Menu;
            this.txtVND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVND.Enabled = false;
            this.txtVND.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVND.Location = new System.Drawing.Point(331, 16);
            this.txtVND.Multiline = true;
            this.txtVND.Name = "txtVND";
            this.txtVND.Size = new System.Drawing.Size(84, 33);
            this.txtVND.TabIndex = 6;
            this.txtVND.Text = "VNĐ";
            this.txtVND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Green;
            this.btnThanhToan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(239, 63);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(176, 39);
            this.btnThanhToan.TabIndex = 5;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Red;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(21, 63);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(175, 39);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txTongTien
            // 
            this.txTongTien.BackColor = System.Drawing.SystemColors.Menu;
            this.txTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txTongTien.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTongTien.Location = new System.Drawing.Point(156, 16);
            this.txTongTien.Multiline = true;
            this.txTongTien.Name = "txTongTien";
            this.txTongTien.Size = new System.Drawing.Size(169, 33);
            this.txTongTien.TabIndex = 3;
            this.txTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(18, 16);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(132, 33);
            this.lblTongTien.TabIndex = 2;
            this.lblTongTien.Text = "Tổng Tiền :";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl1.Location = new System.Drawing.Point(22, 41);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(160, 33);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Tìm Kiếm :";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.btnBACK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1412, 48);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnBACK
            // 
            this.btnBACK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBACK.BackgroundImage")));
            this.btnBACK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBACK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBACK.Location = new System.Drawing.Point(0, -1);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(134, 49);
            this.btnBACK.TabIndex = 8;
            this.btnBACK.UseVisualStyleBackColor = true;
            this.btnBACK.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 764);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongDV)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnMoMay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimeToTal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimeBD;
        private System.Windows.Forms.Label lblTimeStart;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnthemDV;
        private System.Windows.Forms.NumericUpDown numSoLuongDV;
        private System.Windows.Forms.ComboBox cbkhachhang;
        private System.Windows.Forms.ComboBox cbDichVu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBACK;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.FlowLayoutPanel flpnMay;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.TextBox txtVND;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.RadioButton radOFF;
        private System.Windows.Forms.RadioButton radON;
    }
}

