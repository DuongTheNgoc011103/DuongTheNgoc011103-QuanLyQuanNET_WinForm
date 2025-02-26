namespace DA1_QLQuanNET
{
    partial class frmMay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMay));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSoLuong = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlSoLuong = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenMay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaMay = new System.Windows.Forms.TextBox();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.btnDEL = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.lblmaMay = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBACK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.rdHD = new System.Windows.Forms.RadioButton();
            this.rdTrong = new System.Windows.Forms.RadioButton();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHUY = new System.Windows.Forms.Button();
            this.dgvMay = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(254)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 571);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 43);
            this.panel2.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolSoLuong,
            this.tlSoLuong});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(783, 43);
            this.statusStrip1.TabIndex = 0;
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
            this.toolStripSplitButton1.Size = new System.Drawing.Size(6, 41);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(71, 6);
            // 
            // toolSoLuong
            // 
            this.toolSoLuong.Name = "toolSoLuong";
            this.toolSoLuong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolSoLuong.Size = new System.Drawing.Size(103, 37);
            this.toolSoLuong.Text = "Số Lượng :";
            // 
            // tlSoLuong
            // 
            this.tlSoLuong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlSoLuong.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlSoLuong.ForeColor = System.Drawing.Color.Firebrick;
            this.tlSoLuong.Name = "tlSoLuong";
            this.tlSoLuong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tlSoLuong.Size = new System.Drawing.Size(23, 37);
            this.tlSoLuong.Text = "0";
            // 
            // btnEDIT
            // 
            this.btnEDIT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEDIT.BackgroundImage")));
            this.btnEDIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEDIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEDIT.Location = new System.Drawing.Point(628, 146);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(130, 49);
            this.btnEDIT.TabIndex = 3;
            this.btnEDIT.UseVisualStyleBackColor = true;
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(93)))), ((int)(((byte)(102)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trạng Thái";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenMay
            // 
            this.txtTenMay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTenMay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenMay.Location = new System.Drawing.Point(230, 79);
            this.txtTenMay.Multiline = true;
            this.txtTenMay.Name = "txtTenMay";
            this.txtTenMay.Size = new System.Drawing.Size(358, 36);
            this.txtTenMay.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(93)))), ((int)(((byte)(102)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Máy";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaMay
            // 
            this.txtMaMay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaMay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaMay.Location = new System.Drawing.Point(230, 11);
            this.txtMaMay.Multiline = true;
            this.txtMaMay.Name = "txtMaMay";
            this.txtMaMay.Size = new System.Drawing.Size(358, 36);
            this.txtMaMay.TabIndex = 1;
            // 
            // btnSAVE
            // 
            this.btnSAVE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSAVE.BackgroundImage")));
            this.btnSAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSAVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSAVE.Location = new System.Drawing.Point(628, 114);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(130, 49);
            this.btnSAVE.TabIndex = 13;
            this.btnSAVE.UseVisualStyleBackColor = true;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // btnDEL
            // 
            this.btnDEL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDEL.BackgroundImage")));
            this.btnDEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDEL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDEL.Location = new System.Drawing.Point(628, 210);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(130, 49);
            this.btnDEL.TabIndex = 4;
            this.btnDEL.UseVisualStyleBackColor = true;
            this.btnDEL.Click += new System.EventHandler(this.btnDEL_Click);
            // 
            // btnADD
            // 
            this.btnADD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnADD.BackgroundImage")));
            this.btnADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnADD.Location = new System.Drawing.Point(628, 79);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(130, 49);
            this.btnADD.TabIndex = 1;
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // lblmaMay
            // 
            this.lblmaMay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(93)))), ((int)(((byte)(102)))));
            this.lblmaMay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblmaMay.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaMay.ForeColor = System.Drawing.Color.White;
            this.lblmaMay.Location = new System.Drawing.Point(28, 11);
            this.lblmaMay.Name = "lblmaMay";
            this.lblmaMay.Size = new System.Drawing.Size(181, 36);
            this.lblmaMay.TabIndex = 0;
            this.lblmaMay.Text = "Mã Máy";
            this.lblmaMay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnBACK);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(783, 73);
            this.panel4.TabIndex = 1;
            // 
            // btnBACK
            // 
            this.btnBACK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBACK.BackgroundImage")));
            this.btnBACK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBACK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBACK.Location = new System.Drawing.Point(12, 12);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(130, 49);
            this.btnBACK.TabIndex = 7;
            this.btnBACK.UseVisualStyleBackColor = true;
            this.btnBACK.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(783, 73);
            this.label3.TabIndex = 6;
            this.label3.Text = "QUẢN LÝ MÁY";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.panel5.Controls.Add(this.btnReload);
            this.panel5.Controls.Add(this.rdHD);
            this.panel5.Controls.Add(this.rdTrong);
            this.panel5.Controls.Add(this.cbTrangThai);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtTenMay);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.txtMaMay);
            this.panel5.Controls.Add(this.lblmaMay);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 73);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(602, 235);
            this.panel5.TabIndex = 2;
            // 
            // btnReload
            // 
            this.btnReload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReload.BackgroundImage")));
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReload.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(230, 194);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(49, 31);
            this.btnReload.TabIndex = 15;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // rdHD
            // 
            this.rdHD.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rdHD.Location = new System.Drawing.Point(294, 194);
            this.rdHD.Name = "rdHD";
            this.rdHD.Size = new System.Drawing.Size(144, 31);
            this.rdHD.TabIndex = 13;
            this.rdHD.TabStop = true;
            this.rdHD.Text = "Đang Dùng";
            this.rdHD.UseVisualStyleBackColor = true;
            this.rdHD.CheckedChanged += new System.EventHandler(this.rdHD_CheckedChanged);
            // 
            // rdTrong
            // 
            this.rdTrong.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTrong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rdTrong.Location = new System.Drawing.Point(444, 194);
            this.rdTrong.Name = "rdTrong";
            this.rdTrong.Size = new System.Drawing.Size(144, 31);
            this.rdTrong.TabIndex = 14;
            this.rdTrong.TabStop = true;
            this.rdTrong.Text = "Trống";
            this.rdTrong.UseVisualStyleBackColor = true;
            this.rdTrong.CheckedChanged += new System.EventHandler(this.rdTrong_CheckedChanged);
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new System.Drawing.Point(230, 146);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(358, 32);
            this.cbTrangThai.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 308);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.panel3.Controls.Add(this.btnSAVE);
            this.panel3.Controls.Add(this.btnHUY);
            this.panel3.Controls.Add(this.btnDEL);
            this.panel3.Controls.Add(this.btnADD);
            this.panel3.Controls.Add(this.btnEDIT);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(783, 308);
            this.panel3.TabIndex = 0;
            // 
            // btnHUY
            // 
            this.btnHUY.BackColor = System.Drawing.Color.Red;
            this.btnHUY.ForeColor = System.Drawing.Color.White;
            this.btnHUY.Location = new System.Drawing.Point(628, 179);
            this.btnHUY.Name = "btnHUY";
            this.btnHUY.Size = new System.Drawing.Size(130, 48);
            this.btnHUY.TabIndex = 12;
            this.btnHUY.Text = "HỦY";
            this.btnHUY.UseVisualStyleBackColor = false;
            this.btnHUY.Click += new System.EventHandler(this.btnHUY_Click);
            // 
            // dgvMay
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMay.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMay.EnableHeadersVisualStyles = false;
            this.dgvMay.Location = new System.Drawing.Point(0, 308);
            this.dgvMay.Name = "dgvMay";
            this.dgvMay.RowHeadersWidth = 51;
            this.dgvMay.RowTemplate.Height = 24;
            this.dgvMay.Size = new System.Drawing.Size(783, 263);
            this.dgvMay.TabIndex = 7;
            this.dgvMay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMay_CellClick);
            // 
            // frmMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 614);
            this.Controls.Add(this.dgvMay);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMay";
            this.Load += new System.EventHandler(this.frmMay_Load);
            this.panel2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenMay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaMay;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Button btnDEL;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Label lblmaMay;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Button btnBACK;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolSoLuong;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel tlSoLuong;
        private System.Windows.Forms.DataGridView dgvMay;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.RadioButton rdHD;
        private System.Windows.Forms.RadioButton rdTrong;
        private System.Windows.Forms.Button btnHUY;
    }
}