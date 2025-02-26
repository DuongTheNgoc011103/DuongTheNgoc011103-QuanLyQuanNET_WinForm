using Microsoft.Reporting.WinForms;
namespace DA1_QLQuanNET
{
    partial class INHD
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
            this.rptHD = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptHD
            // 
            this.rptHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rptHD.LocalReport.ReportEmbeddedResource = "DA1_QLQuanNET.INHD.rdlc";
            this.rptHD.Location = new System.Drawing.Point(0, 0);
            this.rptHD.Margin = new System.Windows.Forms.Padding(2);
            this.rptHD.Name = "rptHD";
            this.rptHD.ServerReport.BearerToken = null;
            this.rptHD.Size = new System.Drawing.Size(834, 588);
            this.rptHD.TabIndex = 0;
            this.rptHD.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            this.rptHD.Load += new System.EventHandler(this.rptHD_Load);
            // 
            // INHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 587);
            this.Controls.Add(this.rptHD);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "INHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INHD";
            this.Load += new System.EventHandler(this.INHD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ReportViewer rptHD;
    }
}