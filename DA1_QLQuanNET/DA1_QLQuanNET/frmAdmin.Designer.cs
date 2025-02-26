namespace DA1_QLQuanNET
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.lblADMIN = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNO = new System.Windows.Forms.Label();
            this.lblYES = new System.Windows.Forms.Label();
            this.txtAnhAD = new System.Windows.Forms.TextBox();
            this.lblDoiTT = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.btnMatKhau = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.picAnhAD = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBACK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhAD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblADMIN
            // 
            this.lblADMIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblADMIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblADMIN.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblADMIN.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblADMIN.ForeColor = System.Drawing.Color.White;
            this.lblADMIN.Location = new System.Drawing.Point(0, 0);
            this.lblADMIN.Name = "lblADMIN";
            this.lblADMIN.Size = new System.Drawing.Size(552, 62);
            this.lblADMIN.TabIndex = 51;
            this.lblADMIN.Text = "          TÀI KHOẢN ADMIN";
            this.lblADMIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNO);
            this.panel1.Controls.Add(this.lblYES);
            this.panel1.Controls.Add(this.txtAnhAD);
            this.panel1.Controls.Add(this.lblDoiTT);
            this.panel1.Controls.Add(this.txtMK);
            this.panel1.Controls.Add(this.txtTK);
            this.panel1.Controls.Add(this.btnMatKhau);
            this.panel1.Controls.Add(this.btnTaiKhoan);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.picAnhAD);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 330);
            this.panel1.TabIndex = 52;
            // 
            // lblNO
            // 
            this.lblNO.BackColor = System.Drawing.Color.Red;
            this.lblNO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNO.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNO.ForeColor = System.Drawing.Color.White;
            this.lblNO.Location = new System.Drawing.Point(204, 170);
            this.lblNO.Name = "lblNO";
            this.lblNO.Size = new System.Drawing.Size(123, 45);
            this.lblNO.TabIndex = 31;
            this.lblNO.Text = "NO";
            this.lblNO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNO.Click += new System.EventHandler(this.lblNO_Click);
            // 
            // lblYES
            // 
            this.lblYES.BackColor = System.Drawing.Color.SteelBlue;
            this.lblYES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblYES.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYES.ForeColor = System.Drawing.Color.White;
            this.lblYES.Location = new System.Drawing.Point(45, 170);
            this.lblYES.Name = "lblYES";
            this.lblYES.Size = new System.Drawing.Size(123, 45);
            this.lblYES.TabIndex = 30;
            this.lblYES.Text = "YES";
            this.lblYES.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblYES.Click += new System.EventHandler(this.lblYES_Click);
            // 
            // txtAnhAD
            // 
            this.txtAnhAD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnhAD.Location = new System.Drawing.Point(349, 272);
            this.txtAnhAD.Multiline = true;
            this.txtAnhAD.Name = "txtAnhAD";
            this.txtAnhAD.Size = new System.Drawing.Size(191, 55);
            this.txtAnhAD.TabIndex = 29;
            // 
            // lblDoiTT
            // 
            this.lblDoiTT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDoiTT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoiTT.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDoiTT.Location = new System.Drawing.Point(155, 170);
            this.lblDoiTT.Name = "lblDoiTT";
            this.lblDoiTT.Size = new System.Drawing.Size(123, 45);
            this.lblDoiTT.TabIndex = 28;
            this.lblDoiTT.Text = "THAY ĐỔI";
            this.lblDoiTT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDoiTT.Click += new System.EventHandler(this.lblDoiTT_Click);
            // 
            // txtMK
            // 
            this.txtMK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMK.Location = new System.Drawing.Point(155, 121);
            this.txtMK.Multiline = true;
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(191, 34);
            this.txtMK.TabIndex = 27;
            // 
            // txtTK
            // 
            this.txtTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTK.Location = new System.Drawing.Point(155, 73);
            this.txtTK.Multiline = true;
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(191, 34);
            this.txtTK.TabIndex = 26;
            // 
            // btnMatKhau
            // 
            this.btnMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(93)))), ((int)(((byte)(102)))));
            this.btnMatKhau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnMatKhau.Location = new System.Drawing.Point(12, 114);
            this.btnMatKhau.Name = "btnMatKhau";
            this.btnMatKhau.Size = new System.Drawing.Size(137, 41);
            this.btnMatKhau.TabIndex = 25;
            this.btnMatKhau.Text = "Mật Khẩu :";
            this.btnMatKhau.UseVisualStyleBackColor = false;
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(93)))), ((int)(((byte)(102)))));
            this.btnTaiKhoan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.Location = new System.Drawing.Point(12, 67);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(137, 41);
            this.btnTaiKhoan.TabIndex = 24;
            this.btnTaiKhoan.Text = "Tài Khoản :";
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            // 
            // btnReload
            // 
            this.btnReload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReload.BackgroundImage")));
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReload.Location = new System.Drawing.Point(352, 221);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(59, 45);
            this.btnReload.TabIndex = 23;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblName.Location = new System.Drawing.Point(417, 221);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(123, 45);
            this.lblName.TabIndex = 2;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picAnhAD
            // 
            this.picAnhAD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picAnhAD.Location = new System.Drawing.Point(352, 15);
            this.picAnhAD.Name = "picAnhAD";
            this.picAnhAD.Size = new System.Drawing.Size(188, 200);
            this.picAnhAD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnhAD.TabIndex = 1;
            this.picAnhAD.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(93)))), ((int)(((byte)(102)))));
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(334, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PHẦN MỀM QUẢN LÝ QUÁN NET";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBACK
            // 
            this.btnBACK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBACK.BackgroundImage")));
            this.btnBACK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBACK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBACK.Location = new System.Drawing.Point(0, 0);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(130, 62);
            this.btnBACK.TabIndex = 53;
            this.btnBACK.UseVisualStyleBackColor = true;
            this.btnBACK.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 392);
            this.Controls.Add(this.btnBACK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblADMIN);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ADMIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN";
            this.Load += new System.EventHandler(this.ADMIN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhAD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblADMIN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBACK;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picAnhAD;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnMatKhau;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label lblDoiTT;
        private System.Windows.Forms.TextBox txtAnhAD;
        private System.Windows.Forms.Label lblNO;
        private System.Windows.Forms.Label lblYES;
    }
}