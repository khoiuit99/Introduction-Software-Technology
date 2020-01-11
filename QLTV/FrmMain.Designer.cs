namespace QLTV
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnDangNhap = new System.Windows.Forms.ToolStripButton();
            this.tbtnDocGia = new System.Windows.Forms.ToolStripButton();
            this.tbtnSach = new System.Windows.Forms.ToolStripButton();
            this.tbtnDanhSachSach = new System.Windows.Forms.ToolStripButton();
            this.tbtnBaocao = new System.Windows.Forms.ToolStripButton();
            this.tbtnBaocaoII = new System.Windows.Forms.ToolStripButton();
            this.lbshowaccount = new System.Windows.Forms.Label();
            this.lbltaikhoan = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnDangNhap,
            this.tbtnDocGia,
            this.tbtnSach,
            this.tbtnDanhSachSach,
            this.tbtnBaocao,
            this.tbtnBaocaoII});
            this.toolStrip1.Location = new System.Drawing.Point(0, 350);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(676, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnDangNhap
            // 
            this.tbtnDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("tbtnDangNhap.Image")));
            this.tbtnDangNhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDangNhap.Name = "tbtnDangNhap";
            this.tbtnDangNhap.Size = new System.Drawing.Size(89, 24);
            this.tbtnDangNhap.Text = "Đăng nhập";
            this.tbtnDangNhap.Click += new System.EventHandler(this.TbtnDangNhap_Click);
            // 
            // tbtnDocGia
            // 
            this.tbtnDocGia.Image = ((System.Drawing.Image)(resources.GetObject("tbtnDocGia.Image")));
            this.tbtnDocGia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDocGia.Name = "tbtnDocGia";
            this.tbtnDocGia.Size = new System.Drawing.Size(72, 24);
            this.tbtnDocGia.Text = "Độc Giả";
            this.tbtnDocGia.Click += new System.EventHandler(this.tbtnDocGia_Click);
            // 
            // tbtnSach
            // 
            this.tbtnSach.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSach.Image")));
            this.tbtnSach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSach.Name = "tbtnSach";
            this.tbtnSach.Size = new System.Drawing.Size(56, 24);
            this.tbtnSach.Text = "Sách";
            this.tbtnSach.Click += new System.EventHandler(this.tbtnSach_Click);
            // 
            // tbtnDanhSachSach
            // 
            this.tbtnDanhSachSach.Image = ((System.Drawing.Image)(resources.GetObject("tbtnDanhSachSach.Image")));
            this.tbtnDanhSachSach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDanhSachSach.Name = "tbtnDanhSachSach";
            this.tbtnDanhSachSach.Size = new System.Drawing.Size(115, 24);
            this.tbtnDanhSachSach.Text = "Danh Sách Sách";
            this.tbtnDanhSachSach.Click += new System.EventHandler(this.DSS_Click);
            // 
            // tbtnBaocao
            // 
            this.tbtnBaocao.Image = ((System.Drawing.Image)(resources.GetObject("tbtnBaocao.Image")));
            this.tbtnBaocao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnBaocao.Name = "tbtnBaocao";
            this.tbtnBaocao.Size = new System.Drawing.Size(81, 24);
            this.tbtnBaocao.Text = "Báo Cáo I";
            this.tbtnBaocao.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // tbtnBaocaoII
            // 
            this.tbtnBaocaoII.Image = ((System.Drawing.Image)(resources.GetObject("tbtnBaocaoII.Image")));
            this.tbtnBaocaoII.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnBaocaoII.Name = "tbtnBaocaoII";
            this.tbtnBaocaoII.Size = new System.Drawing.Size(84, 24);
            this.tbtnBaocaoII.Text = "Báo Cáo II";
            this.tbtnBaocaoII.Click += new System.EventHandler(this.BaoCaoII_Click);
            // 
            // lbshowaccount
            // 
            this.lbshowaccount.AutoSize = true;
            this.lbshowaccount.BackColor = System.Drawing.Color.Gray;
            this.lbshowaccount.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbshowaccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbshowaccount.Location = new System.Drawing.Point(19, 24);
            this.lbshowaccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbshowaccount.Name = "lbshowaccount";
            this.lbshowaccount.Size = new System.Drawing.Size(82, 19);
            this.lbshowaccount.TabIndex = 11;
            this.lbshowaccount.Text = "Tài khoản:";
            this.lbshowaccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbltaikhoan
            // 
            this.lbltaikhoan.AutoSize = true;
            this.lbltaikhoan.BackColor = System.Drawing.Color.Gray;
            this.lbltaikhoan.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaikhoan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltaikhoan.Location = new System.Drawing.Point(103, 24);
            this.lbltaikhoan.Name = "lbltaikhoan";
            this.lbltaikhoan.Size = new System.Drawing.Size(0, 19);
            this.lbltaikhoan.TabIndex = 12;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(676, 377);
            this.Controls.Add(this.lbltaikhoan);
            this.Controls.Add(this.lbshowaccount);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnDocGia;
        private System.Windows.Forms.ToolStripButton tbtnSach;
        private System.Windows.Forms.ToolStripButton tbtnDanhSachSach;
        private System.Windows.Forms.ToolStripButton tbtnBaocao;
        private System.Windows.Forms.ToolStripButton tbtnBaocaoII;
        private System.Windows.Forms.Label lbshowaccount;
        private System.Windows.Forms.Label lbltaikhoan;
        private System.Windows.Forms.ToolStripButton tbtnDangNhap;
    }
}

