namespace DA1_QLQuanNET
{
    partial class THONGKE
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(THONGKE));
            this.ChartBDC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBACK = new System.Windows.Forms.Button();
            this.soluong = new System.Windows.Forms.Label();
            this.tongtien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBDC)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartBDC
            // 
            this.ChartBDC.BackColor = System.Drawing.Color.Silver;
            chartArea2.Name = "ChartArea1";
            this.ChartBDC.ChartAreas.Add(chartArea2);
            this.ChartBDC.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.ChartBDC.Legends.Add(legend2);
            this.ChartBDC.Location = new System.Drawing.Point(0, 0);
            this.ChartBDC.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ChartBDC.Name = "ChartBDC";
            this.ChartBDC.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.SteelBlue;
            series2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.LabelBackColor = System.Drawing.Color.White;
            series2.LabelForeColor = System.Drawing.Color.Teal;
            series2.LabelFormat = "#,##0";
            series2.Legend = "Legend1";
            series2.LegendText = "Biểu Đồ Cột";
            series2.Name = "ChartBDC";
            this.ChartBDC.Series.Add(series2);
            this.ChartBDC.Size = new System.Drawing.Size(890, 505);
            this.ChartBDC.TabIndex = 0;
            this.ChartBDC.Text = "chart1";
            title2.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.SteelBlue;
            title2.Name = "BIỂU ĐỒ THỐNG KÊ";
            title2.Text = "BIỂU ĐỒ THỐNG KÊ";
            this.ChartBDC.Titles.Add(title2);
            this.ChartBDC.Click += new System.EventHandler(this.ChartBDC_Click);
            // 
            // btnBACK
            // 
            this.btnBACK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBACK.BackgroundImage")));
            this.btnBACK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBACK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBACK.Location = new System.Drawing.Point(12, 12);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(134, 49);
            this.btnBACK.TabIndex = 9;
            this.btnBACK.UseVisualStyleBackColor = true;
            this.btnBACK.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // soluong
            // 
            this.soluong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.soluong.BackColor = System.Drawing.Color.White;
            this.soluong.Enabled = false;
            this.soluong.ForeColor = System.Drawing.Color.Black;
            this.soluong.Location = new System.Drawing.Point(729, 157);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(132, 31);
            this.soluong.TabIndex = 10;
            this.soluong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.soluong.Click += new System.EventHandler(this.soluong_Click);
            // 
            // tongtien
            // 
            this.tongtien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tongtien.BackColor = System.Drawing.Color.White;
            this.tongtien.Enabled = false;
            this.tongtien.ForeColor = System.Drawing.Color.Black;
            this.tongtien.Location = new System.Drawing.Point(729, 233);
            this.tongtien.Name = "tongtien";
            this.tongtien.Size = new System.Drawing.Size(132, 31);
            this.tongtien.TabIndex = 11;
            this.tongtien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // THONGKE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(890, 505);
            this.Controls.Add(this.tongtien);
            this.Controls.Add(this.soluong);
            this.Controls.Add(this.btnBACK);
            this.Controls.Add(this.ChartBDC);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "THONGKE";
            this.Text = "THONGKE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.THONGKE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartBDC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartBDC;
        private System.Windows.Forms.Button btnBACK;
        private System.Windows.Forms.Label soluong;
        private System.Windows.Forms.Label tongtien;
    }
}