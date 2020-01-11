namespace QLTV
{
    partial class FrmDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDocGia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbldg = new System.Windows.Forms.ComboBox();
            this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.dtngaylapthe = new System.Windows.Forms.DateTimePicker();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtiddocgia = new System.Windows.Forms.TextBox();
            this.lbngaylapthe = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.lbngaysinh = new System.Windows.Forms.Label();
            this.lbloaidocgia = new System.Windows.Forms.Label();
            this.lbiddocgia = new System.Windows.Forms.Label();
            this.lbhoten = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDocgia = new System.Windows.Forms.DataGridView();
            this.iddocgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaidocgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylapthe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbllimittime = new System.Windows.Forms.Label();
            this.lblmaxage = new System.Windows.Forms.Label();
            this.lblminage = new System.Windows.Forms.Label();
            this.btnchinhsuu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocgia)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.txtfind);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbldg);
            this.panel1.Controls.Add(this.dtngaysinh);
            this.panel1.Controls.Add(this.dtngaylapthe);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txtdiachi);
            this.panel1.Controls.Add(this.txthoten);
            this.panel1.Controls.Add(this.txtiddocgia);
            this.panel1.Controls.Add(this.lbngaylapthe);
            this.panel1.Controls.Add(this.lbemail);
            this.panel1.Controls.Add(this.lbdiachi);
            this.panel1.Controls.Add(this.lbngaysinh);
            this.panel1.Controls.Add(this.lbloaidocgia);
            this.panel1.Controls.Add(this.lbiddocgia);
            this.panel1.Controls.Add(this.lbhoten);
            this.panel1.Name = "panel1";
            // 
            // txtfind
            // 
            resources.ApplyResources(this.txtfind, "txtfind");
            this.txtfind.Name = "txtfind";
            this.txtfind.TextChanged += new System.EventHandler(this.Txtfind_TextChanged);
            this.txtfind.Leave += new System.EventHandler(this.Txtfind_Leave);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Name = "label8";
            // 
            // cbldg
            // 
            this.cbldg.FormattingEnabled = true;
            this.cbldg.Items.AddRange(new object[] {
            resources.GetString("cbldg.Items"),
            resources.GetString("cbldg.Items1")});
            resources.ApplyResources(this.cbldg, "cbldg");
            this.cbldg.Name = "cbldg";
            // 
            // dtngaysinh
            // 
            resources.ApplyResources(this.dtngaysinh, "dtngaysinh");
            this.dtngaysinh.Name = "dtngaysinh";
            // 
            // dtngaylapthe
            // 
            resources.ApplyResources(this.dtngaylapthe, "dtngaylapthe");
            this.dtngaylapthe.Name = "dtngaylapthe";
            // 
            // txtemail
            // 
            resources.ApplyResources(this.txtemail, "txtemail");
            this.txtemail.Name = "txtemail";
            // 
            // txtdiachi
            // 
            resources.ApplyResources(this.txtdiachi, "txtdiachi");
            this.txtdiachi.Name = "txtdiachi";
            // 
            // txthoten
            // 
            resources.ApplyResources(this.txthoten, "txthoten");
            this.txthoten.Name = "txthoten";
            // 
            // txtiddocgia
            // 
            resources.ApplyResources(this.txtiddocgia, "txtiddocgia");
            this.txtiddocgia.Name = "txtiddocgia";
            // 
            // lbngaylapthe
            // 
            resources.ApplyResources(this.lbngaylapthe, "lbngaylapthe");
            this.lbngaylapthe.BackColor = System.Drawing.Color.Transparent;
            this.lbngaylapthe.Name = "lbngaylapthe";
            // 
            // lbemail
            // 
            resources.ApplyResources(this.lbemail, "lbemail");
            this.lbemail.BackColor = System.Drawing.Color.Transparent;
            this.lbemail.Name = "lbemail";
            // 
            // lbdiachi
            // 
            resources.ApplyResources(this.lbdiachi, "lbdiachi");
            this.lbdiachi.BackColor = System.Drawing.Color.Transparent;
            this.lbdiachi.Name = "lbdiachi";
            // 
            // lbngaysinh
            // 
            resources.ApplyResources(this.lbngaysinh, "lbngaysinh");
            this.lbngaysinh.BackColor = System.Drawing.Color.Transparent;
            this.lbngaysinh.Name = "lbngaysinh";
            // 
            // lbloaidocgia
            // 
            resources.ApplyResources(this.lbloaidocgia, "lbloaidocgia");
            this.lbloaidocgia.BackColor = System.Drawing.Color.Transparent;
            this.lbloaidocgia.Name = "lbloaidocgia";
            // 
            // lbiddocgia
            // 
            resources.ApplyResources(this.lbiddocgia, "lbiddocgia");
            this.lbiddocgia.BackColor = System.Drawing.Color.Transparent;
            this.lbiddocgia.Name = "lbiddocgia";
            // 
            // lbhoten
            // 
            resources.ApplyResources(this.lbhoten, "lbhoten");
            this.lbhoten.BackColor = System.Drawing.Color.Transparent;
            this.lbhoten.Name = "lbhoten";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDocgia);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // dgvDocgia
            // 
            this.dgvDocgia.BackgroundColor = System.Drawing.Color.Tan;
            this.dgvDocgia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDocgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocgia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddocgia,
            this.hoten,
            this.loaidocgia,
            this.ngaysinh,
            this.diachi,
            this.ngaylapthe,
            this.email});
            resources.ApplyResources(this.dgvDocgia, "dgvDocgia");
            this.dgvDocgia.Name = "dgvDocgia";
            this.dgvDocgia.RowTemplate.Height = 24;
            this.dgvDocgia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // iddocgia
            // 
            this.iddocgia.DataPropertyName = "iddocgia";
            resources.ApplyResources(this.iddocgia, "iddocgia");
            this.iddocgia.Name = "iddocgia";
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            resources.ApplyResources(this.hoten, "hoten");
            this.hoten.Name = "hoten";
            // 
            // loaidocgia
            // 
            this.loaidocgia.DataPropertyName = "loaidocgia";
            resources.ApplyResources(this.loaidocgia, "loaidocgia");
            this.loaidocgia.Name = "loaidocgia";
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            resources.ApplyResources(this.ngaysinh, "ngaysinh");
            this.ngaysinh.Name = "ngaysinh";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            resources.ApplyResources(this.diachi, "diachi");
            this.diachi.Name = "diachi";
            // 
            // ngaylapthe
            // 
            this.ngaylapthe.DataPropertyName = "ngaylapthe";
            resources.ApplyResources(this.ngaylapthe, "ngaylapthe");
            this.ngaylapthe.Name = "ngaylapthe";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            resources.ApplyResources(this.email, "email");
            this.email.Name = "email";
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnthem, "btnthem");
            this.btnthem.Name = "btnthem";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnxoa, "btnxoa");
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnsua, "btnsua");
            this.btnsua.Name = "btnsua";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnthoat, "btnthoat");
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.lbllimittime);
            this.panel2.Controls.Add(this.lblmaxage);
            this.panel2.Controls.Add(this.lblminage);
            this.panel2.Controls.Add(this.btnchinhsuu);
            this.panel2.Controls.Add(this.btnthoat);
            this.panel2.Controls.Add(this.btnsua);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Name = "panel2";
            // 
            // lbllimittime
            // 
            resources.ApplyResources(this.lbllimittime, "lbllimittime");
            this.lbllimittime.BackColor = System.Drawing.Color.Transparent;
            this.lbllimittime.Name = "lbllimittime";
            // 
            // lblmaxage
            // 
            resources.ApplyResources(this.lblmaxage, "lblmaxage");
            this.lblmaxage.BackColor = System.Drawing.Color.Transparent;
            this.lblmaxage.Name = "lblmaxage";
            // 
            // lblminage
            // 
            resources.ApplyResources(this.lblminage, "lblminage");
            this.lblminage.BackColor = System.Drawing.Color.Transparent;
            this.lblminage.Name = "lblminage";
            // 
            // btnchinhsuu
            // 
            this.btnchinhsuu.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnchinhsuu, "btnchinhsuu");
            this.btnchinhsuu.Name = "btnchinhsuu";
            this.btnchinhsuu.UseVisualStyleBackColor = false;
            this.btnchinhsuu.Click += new System.EventHandler(this.Btnchinhsuu_Click);
            // 
            // FrmDocGia
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmDocGia";
            this.Load += new System.EventHandler(this.FrmDocGia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocgia)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbhoten;
        private System.Windows.Forms.ComboBox cbldg;
        private System.Windows.Forms.DateTimePicker dtngaysinh;
        private System.Windows.Forms.DateTimePicker dtngaylapthe;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtiddocgia;
        private System.Windows.Forms.Label lbngaylapthe;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbdiachi;
        private System.Windows.Forms.Label lbngaysinh;
        private System.Windows.Forms.Label lbloaidocgia;
        private System.Windows.Forms.Label lbiddocgia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDocgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddocgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaidocgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylapthe;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnchinhsuu;
        private System.Windows.Forms.Label lbllimittime;
        private System.Windows.Forms.Label lblmaxage;
        private System.Windows.Forms.Label lblminage;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.Label label8;
    }
}