namespace QLTV
{
    partial class FrmDangNhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            this.btnthoat = new System.Windows.Forms.Button();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txttnd = new System.Windows.Forms.TextBox();
            this.matkhau = new System.Windows.Forms.Label();
            this.taikhoan = new System.Windows.Forms.Label();
            this.lbwelcome = new System.Windows.Forms.Label();
            this.btndn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbname3 = new System.Windows.Forms.Label();
            this.lbname2 = new System.Windows.Forms.Label();
            this.lbname1 = new System.Windows.Forms.Label();
            this.lbstudent = new System.Windows.Forms.Label();
            this.lbnametc = new System.Windows.Forms.Label();
            this.lbteacher = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(302, 193);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(72, 29);
            this.btnthoat.TabIndex = 21;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(197, 138);
            this.txtmk.Margin = new System.Windows.Forms.Padding(2);
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '*';
            this.txtmk.Size = new System.Drawing.Size(185, 20);
            this.txtmk.TabIndex = 19;
            this.txtmk.UseWaitCursor = true;
            // 
            // txttnd
            // 
            this.txttnd.Location = new System.Drawing.Point(197, 99);
            this.txttnd.Margin = new System.Windows.Forms.Padding(2);
            this.txttnd.Name = "txttnd";
            this.txttnd.Size = new System.Drawing.Size(185, 20);
            this.txttnd.TabIndex = 18;
            this.txttnd.UseWaitCursor = true;
            // 
            // matkhau
            // 
            this.matkhau.AutoSize = true;
            this.matkhau.BackColor = System.Drawing.Color.Transparent;
            this.matkhau.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhau.ForeColor = System.Drawing.Color.Black;
            this.matkhau.Location = new System.Drawing.Point(91, 135);
            this.matkhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(92, 23);
            this.matkhau.TabIndex = 17;
            this.matkhau.Text = "Mật khẩu:";
            this.matkhau.UseWaitCursor = true;
            // 
            // taikhoan
            // 
            this.taikhoan.AutoSize = true;
            this.taikhoan.BackColor = System.Drawing.Color.Transparent;
            this.taikhoan.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.taikhoan.ForeColor = System.Drawing.Color.Black;
            this.taikhoan.Location = new System.Drawing.Point(91, 99);
            this.taikhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Size = new System.Drawing.Size(92, 23);
            this.taikhoan.TabIndex = 16;
            this.taikhoan.Text = "Tài khoản:";
            this.taikhoan.UseWaitCursor = true;
            // 
            // lbwelcome
            // 
            this.lbwelcome.AutoSize = true;
            this.lbwelcome.BackColor = System.Drawing.Color.Transparent;
            this.lbwelcome.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbwelcome.ForeColor = System.Drawing.Color.Transparent;
            this.lbwelcome.Location = new System.Drawing.Point(23, 46);
            this.lbwelcome.Name = "lbwelcome";
            this.lbwelcome.Size = new System.Drawing.Size(443, 27);
            this.lbwelcome.TabIndex = 22;
            this.lbwelcome.Text = "Chào mừng đến với phần mềm quản lý thư viện";
            // 
            // btndn
            // 
            this.btndn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndn.Image = ((System.Drawing.Image)(resources.GetObject("btndn.Image")));
            this.btndn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndn.Location = new System.Drawing.Point(197, 193);
            this.btndn.Margin = new System.Windows.Forms.Padding(2);
            this.btndn.Name = "btndn";
            this.btndn.Size = new System.Drawing.Size(101, 29);
            this.btndn.TabIndex = 23;
            this.btndn.Text = "Đăng nhập";
            this.btndn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndn.UseVisualStyleBackColor = true;
            this.btndn.Click += new System.EventHandler(this.Btndn_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lbwelcome);
            this.panel1.Controls.Add(this.btnthoat);
            this.panel1.Controls.Add(this.btndn);
            this.panel1.Controls.Add(this.taikhoan);
            this.panel1.Controls.Add(this.matkhau);
            this.panel1.Controls.Add(this.txtmk);
            this.panel1.Controls.Add(this.txttnd);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 249);
            this.panel1.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.lbname3);
            this.groupBox1.Controls.Add(this.lbname2);
            this.groupBox1.Controls.Add(this.lbname1);
            this.groupBox1.Controls.Add(this.lbstudent);
            this.groupBox1.Controls.Add(this.lbnametc);
            this.groupBox1.Controls.Add(this.lbteacher);
            this.groupBox1.Location = new System.Drawing.Point(490, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 249);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // lbname3
            // 
            this.lbname3.AutoSize = true;
            this.lbname3.BackColor = System.Drawing.Color.Transparent;
            this.lbname3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbname3.Location = new System.Drawing.Point(105, 209);
            this.lbname3.Name = "lbname3";
            this.lbname3.Size = new System.Drawing.Size(107, 16);
            this.lbname3.TabIndex = 5;
            this.lbname3.Text = "Quách Thế Tường";
            // 
            // lbname2
            // 
            this.lbname2.AutoSize = true;
            this.lbname2.BackColor = System.Drawing.Color.Transparent;
            this.lbname2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbname2.Location = new System.Drawing.Point(105, 170);
            this.lbname2.Name = "lbname2";
            this.lbname2.Size = new System.Drawing.Size(103, 16);
            this.lbname2.TabIndex = 4;
            this.lbname2.Text = "Hoàng Xuân Tùng";
            // 
            // lbname1
            // 
            this.lbname1.AutoSize = true;
            this.lbname1.BackColor = System.Drawing.Color.Transparent;
            this.lbname1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbname1.Location = new System.Drawing.Point(105, 135);
            this.lbname1.Name = "lbname1";
            this.lbname1.Size = new System.Drawing.Size(74, 16);
            this.lbname1.TabIndex = 3;
            this.lbname1.Text = "Hà Huy Khôi";
            // 
            // lbstudent
            // 
            this.lbstudent.AutoSize = true;
            this.lbstudent.BackColor = System.Drawing.Color.Transparent;
            this.lbstudent.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbstudent.Location = new System.Drawing.Point(22, 109);
            this.lbstudent.Name = "lbstudent";
            this.lbstudent.Size = new System.Drawing.Size(127, 16);
            this.lbstudent.TabIndex = 2;
            this.lbstudent.Text = "Danh sách thành viên:";
            // 
            // lbnametc
            // 
            this.lbnametc.AutoSize = true;
            this.lbnametc.BackColor = System.Drawing.Color.Transparent;
            this.lbnametc.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbnametc.Location = new System.Drawing.Point(105, 82);
            this.lbnametc.Name = "lbnametc";
            this.lbnametc.Size = new System.Drawing.Size(115, 16);
            this.lbnametc.TabIndex = 1;
            this.lbnametc.Text = "Nguyễn Công Hoan";
            // 
            // lbteacher
            // 
            this.lbteacher.AutoSize = true;
            this.lbteacher.BackColor = System.Drawing.Color.Transparent;
            this.lbteacher.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbteacher.Location = new System.Drawing.Point(22, 56);
            this.lbteacher.Name = "lbteacher";
            this.lbteacher.Size = new System.Drawing.Size(138, 16);
            this.lbteacher.TabIndex = 0;
            this.lbteacher.Text = "Giảng viên hướng dẫn:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.Timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.Timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.Timer6_Tick_1);
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnthoat;
            this.ClientSize = new System.Drawing.Size(720, 252);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txttnd;
        private System.Windows.Forms.Label matkhau;
        private System.Windows.Forms.Label taikhoan;
        private System.Windows.Forms.Label lbwelcome;
        private System.Windows.Forms.Button btndn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbname3;
        private System.Windows.Forms.Label lbname2;
        private System.Windows.Forms.Label lbname1;
        private System.Windows.Forms.Label lbstudent;
        private System.Windows.Forms.Label lbnametc;
        private System.Windows.Forms.Label lbteacher;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
    }
}