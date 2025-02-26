namespace DA1_QLQuanNET
{
    partial class frmDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDichVu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDV = new System.Windows.Forms.Label();
            this.btnBACK = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSoLuong = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlSoLuong = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHUY = new System.Windows.Forms.Button();
            this.txtSoLuongDV = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblHinhAnh = new System.Windows.Forms.Label();
            this.txtHinhAnh = new System.Windows.Forms.TextBox();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.picHA = new System.Windows.Forms.PictureBox();
            this.btnDEL = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDVTinh = new System.Windows.Forms.TextBox();
            this.lblDVTinh = new System.Windows.Forms.Label();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.lblTenDV = new System.Windows.Forms.Label();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.lblMaDV = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDV
            // 
            this.lblDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblDV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDV.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDV.ForeColor = System.Drawing.Color.White;
            this.lblDV.Location = new System.Drawing.Point(0, 0);
            this.lblDV.Name = "lblDV";
            this.lblDV.Size = new System.Drawing.Size(943, 73);
            this.lblDV.TabIndex = 7;
            this.lblDV.Text = "QUẢN LÝ DỊCH VỤ";
            this.lblDV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDV.Click += new System.EventHandler(this.lblDV_Click);
            // 
            // btnBACK
            // 
            this.btnBACK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBACK.BackgroundImage")));
            this.btnBACK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBACK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBACK.Location = new System.Drawing.Point(12, 12);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(130, 49);
            this.btnBACK.TabIndex = 8;
            this.btnBACK.UseVisualStyleBackColor = true;
            this.btnBACK.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolSoLuong,
            this.tlSoLuong});
            this.statusStrip1.Location = new System.Drawing.Point(0, 648);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(943, 38);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.BackColor = System.Drawing.Color.Black;
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripSplitButton1.DropDownButtonWidth = 1;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(6, 36);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(57, 6);
            // 
            // toolSoLuong
            // 
            this.toolSoLuong.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.toolSoLuong.Name = "toolSoLuong";
            this.toolSoLuong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolSoLuong.Size = new System.Drawing.Size(84, 33);
            this.toolSoLuong.Text = "Số Lượng :";
            // 
            // tlSoLuong
            // 
            this.tlSoLuong.AutoSize = false;
            this.tlSoLuong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlSoLuong.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlSoLuong.ForeColor = System.Drawing.Color.Firebrick;
            this.tlSoLuong.Name = "tlSoLuong";
            this.tlSoLuong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tlSoLuong.Size = new System.Drawing.Size(21, 33);
            this.tlSoLuong.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 575);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDichVu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 281);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(943, 294);
            this.panel3.TabIndex = 1;
            // 
            // dgvDichVu
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDichVu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDichVu.EnableHeadersVisualStyles = false;
            this.dgvDichVu.Location = new System.Drawing.Point(0, 0);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.RowTemplate.Height = 24;
            this.dgvDichVu.Size = new System.Drawing.Size(943, 294);
            this.dgvDichVu.TabIndex = 0;
            this.dgvDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.panel2.Controls.Add(this.btnHUY);
            this.panel2.Controls.Add(this.txtSoLuongDV);
            this.panel2.Controls.Add(this.lblSoLuong);
            this.panel2.Controls.Add(this.txtDonGia);
            this.panel2.Controls.Add(this.lblHinhAnh);
            this.panel2.Controls.Add(this.txtHinhAnh);
            this.panel2.Controls.Add(this.btnSAVE);
            this.panel2.Controls.Add(this.picHA);
            this.panel2.Controls.Add(this.btnDEL);
            this.panel2.Controls.Add(this.btnADD);
            this.panel2.Controls.Add(this.btnEDIT);
            this.panel2.Controls.Add(this.lblDonGia);
            this.panel2.Controls.Add(this.txtDVTinh);
            this.panel2.Controls.Add(this.lblDVTinh);
            this.panel2.Controls.Add(this.txtTenDV);
            this.panel2.Controls.Add(this.lblTenDV);
            this.panel2.Controls.Add(this.txtMaDV);
            this.panel2.Controls.Add(this.lblMaDV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 281);
            this.panel2.TabIndex = 0;
            // 
            // btnHUY
            // 
            this.btnHUY.BackColor = System.Drawing.Color.Red;
            this.btnHUY.ForeColor = System.Drawing.Color.White;
            this.btnHUY.Location = new System.Drawing.Point(801, 159);
            this.btnHUY.Name = "btnHUY";
            this.btnHUY.Size = new System.Drawing.Size(130, 48);
            this.btnHUY.TabIndex = 11;
            this.btnHUY.Text = "HỦY";
            this.btnHUY.UseVisualStyleBackColor = false;
            this.btnHUY.Click += new System.EventHandler(this.btnHUY_Click);
            // 
            // txtSoLuongDV
            // 
            this.txtSoLuongDV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSoLuongDV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuongDV.Location = new System.Drawing.Point(209, 221);
            this.txtSoLuongDV.Multiline = true;
            this.txtSoLuongDV.Name = "txtSoLuongDV";
            this.txtSoLuongDV.Size = new System.Drawing.Size(135, 36);
            this.txtSoLuongDV.TabIndex = 51;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(93)))), ((int)(((byte)(102)))));
            this.lblSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSoLuong.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.White;
            this.lblSoLuong.Location = new System.Drawing.Point(13, 221);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(175, 36);
            this.lblSoLuong.TabIndex = 50;
            this.lblSoLuong.Text = "Số Lượng";
            this.lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonGia.Location = new System.Drawing.Point(209, 169);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(135, 36);
            this.txtDonGia.TabIndex = 49;
            // 
            // lblHinhAnh
            // 
            this.lblHinhAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(93)))), ((int)(((byte)(102)))));
            this.lblHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHinhAnh.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHinhAnh.ForeColor = System.Drawing.Color.White;
            this.lblHinhAnh.Location = new System.Drawing.Point(361, 208);
            this.lblHinhAnh.Name = "lblHinhAnh";
            this.lblHinhAnh.Size = new System.Drawing.Size(110, 49);
            this.lblHinhAnh.TabIndex = 48;
            this.lblHinhAnh.Text = "Chọn Ảnh";
            this.lblHinhAnh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHinhAnh.Click += new System.EventHandler(this.lblHinhAnh_Click);
            // 
            // txtHinhAnh
            // 
            this.txtHinhAnh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHinhAnh.Location = new System.Drawing.Point(477, 169);
            this.txtHinhAnh.Multiline = true;
            this.txtHinhAnh.Name = "txtHinhAnh";
            this.txtHinhAnh.Size = new System.Drawing.Size(282, 88);
            this.txtHinhAnh.TabIndex = 47;
            // 
            // btnSAVE
            // 
            this.btnSAVE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSAVE.BackgroundImage")));
            this.btnSAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSAVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSAVE.Location = new System.Drawing.Point(801, 62);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(130, 49);
            this.btnSAVE.TabIndex = 46;
            this.btnSAVE.UseVisualStyleBackColor = true;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // picHA
            // 
            this.picHA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picHA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picHA.Location = new System.Drawing.Point(477, 13);
            this.picHA.Name = "picHA";
            this.picHA.Size = new System.Drawing.Size(282, 143);
            this.picHA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHA.TabIndex = 42;
            this.picHA.TabStop = false;
            // 
            // btnDEL
            // 
            this.btnDEL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDEL.BackgroundImage")));
            this.btnDEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDEL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDEL.Location = new System.Drawing.Point(801, 208);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(130, 49);
            this.btnDEL.TabIndex = 45;
            this.btnDEL.UseVisualStyleBackColor = true;
            this.btnDEL.Click += new System.EventHandler(this.btnDEL_Click);
            // 
            // btnADD
            // 
            this.btnADD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnADD.BackgroundImage")));
            this.btnADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnADD.Location = new System.Drawing.Point(801, 13);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(130, 49);
            this.btnADD.TabIndex = 43;
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnEDIT
            // 
            this.btnEDIT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEDIT.BackgroundImage")));
            this.btnEDIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEDIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEDIT.Location = new System.Drawing.Point(801, 111);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(130, 49);
            this.btnEDIT.TabIndex = 44;
            this.btnEDIT.UseVisualStyleBackColor = true;
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // lblDonGia
            // 
            this.lblDonGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(93)))), ((int)(((byte)(102)))));
            this.lblDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDonGia.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.ForeColor = System.Drawing.Color.White;
            this.lblDonGia.Location = new System.Drawing.Point(13, 169);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(175, 36);
            this.lblDonGia.TabIndex = 38;
            this.lblDonGia.Text = "Đơn Giá";
            this.lblDonGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDVTinh
            // 
            this.txtDVTinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDVTinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDVTinh.Location = new System.Drawing.Point(209, 117);
            this.txtDVTinh.Multiline = true;
            this.txtDVTinh.Name = "txtDVTinh";
            this.txtDVTinh.Size = new System.Drawing.Size(227, 36);
            this.txtDVTinh.TabIndex = 35;
            // 
            // lblDVTinh
            // 
            this.lblDVTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(93)))), ((int)(((byte)(102)))));
            this.lblDVTinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDVTinh.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDVTinh.ForeColor = System.Drawing.Color.White;
            this.lblDVTinh.Location = new System.Drawing.Point(12, 117);
            this.lblDVTinh.Name = "lblDVTinh";
            this.lblDVTinh.Size = new System.Drawing.Size(176, 36);
            this.lblDVTinh.TabIndex = 34;
            this.lblDVTinh.Text = "Đơn Vị Tính";
            this.lblDVTinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenDV
            // 
            this.txtTenDV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTenDV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDV.Location = new System.Drawing.Point(209, 65);
            this.txtTenDV.Multiline = true;
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(227, 36);
            this.txtTenDV.TabIndex = 33;
            // 
            // lblTenDV
            // 
            this.lblTenDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(93)))), ((int)(((byte)(102)))));
            this.lblTenDV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTenDV.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDV.ForeColor = System.Drawing.Color.White;
            this.lblTenDV.Location = new System.Drawing.Point(12, 65);
            this.lblTenDV.Name = "lblTenDV";
            this.lblTenDV.Size = new System.Drawing.Size(176, 36);
            this.lblTenDV.TabIndex = 32;
            this.lblTenDV.Text = "Tên Dịch Vụ";
            this.lblTenDV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaDV
            // 
            this.txtMaDV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaDV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaDV.Location = new System.Drawing.Point(209, 13);
            this.txtMaDV.Multiline = true;
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(227, 36);
            this.txtMaDV.TabIndex = 31;
            // 
            // lblMaDV
            // 
            this.lblMaDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(93)))), ((int)(((byte)(102)))));
            this.lblMaDV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaDV.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDV.ForeColor = System.Drawing.Color.White;
            this.lblMaDV.Location = new System.Drawing.Point(12, 13);
            this.lblMaDV.Name = "lblMaDV";
            this.lblMaDV.Size = new System.Drawing.Size(176, 36);
            this.lblMaDV.TabIndex = 30;
            this.lblMaDV.Text = "Mã Dịch Vụ";
            this.lblMaDV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 686);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnBACK);
            this.Controls.Add(this.lblDV);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDichVu";
            this.Load += new System.EventHandler(this.frmDichVu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDV;
        private System.Windows.Forms.Button btnBACK;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel toolSoLuong;
        private System.Windows.Forms.ToolStripStatusLabel tlSoLuong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Button btnDEL;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.PictureBox picHA;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDVTinh;
        private System.Windows.Forms.Label lblDVTinh;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.Label lblTenDV;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label lblMaDV;
        private System.Windows.Forms.Label lblHinhAnh;
        private System.Windows.Forms.TextBox txtHinhAnh;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuongDV;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Button btnHUY;
    }
}