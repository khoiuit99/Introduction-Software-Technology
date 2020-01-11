namespace QLTV
{
    partial class FrmSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSach));
            this.function = new System.Windows.Forms.ToolStrip();
            this.btnMuonsach = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvdanhsachsach = new System.Windows.Forms.DataGridView();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namsx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaxuatban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trigia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtnamxb = new System.Windows.Forms.DateTimePicker();
            this.txtnhaxuatban = new System.Windows.Forms.TextBox();
            this.txttacgia = new System.Windows.Forms.TextBox();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.lbnxb = new System.Windows.Forms.Label();
            this.lbtacgia = new System.Windows.Forms.Label();
            this.lbnamxuatban = new System.Windows.Forms.Label();
            this.lbtheloai = new System.Windows.Forms.Label();
            this.lbidsach = new System.Windows.Forms.Label();
            this.lbtensach = new System.Windows.Forms.Label();
            this.lbngaynhap = new System.Windows.Forms.Label();
            this.lbtrigia = new System.Windows.Forms.Label();
            this.txttrigia = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnxoa = new System.Windows.Forms.Button();
            this.lbllimittime = new System.Windows.Forms.Label();
            this.btnchinhsua = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.dtngaynhap = new System.Windows.Forms.DateTimePicker();
            this.cbtls = new System.Windows.Forms.ComboBox();
            this.lbfind = new System.Windows.Forms.Label();
            this.function.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachsach)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // function
            // 
            this.function.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("function.BackgroundImage")));
            this.function.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.function.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMuonsach,
            this.toolStripButton3});
            this.function.Location = new System.Drawing.Point(0, 0);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(918, 27);
            this.function.TabIndex = 0;
            this.function.Text = "toolStrip1";
            // 
            // btnMuonsach
            // 
            this.btnMuonsach.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMuonsach.Image = ((System.Drawing.Image)(resources.GetObject("btnMuonsach.Image")));
            this.btnMuonsach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMuonsach.Name = "btnMuonsach";
            this.btnMuonsach.Size = new System.Drawing.Size(95, 24);
            this.btnMuonsach.Text = "Mượn Sách";
            this.btnMuonsach.Click += new System.EventHandler(this.BtnMuonsach_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(81, 24);
            this.toolStripButton3.Text = "Trả Sách";
            this.toolStripButton3.Click += new System.EventHandler(this.TraSach_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvdanhsachsach);
            this.groupBox1.Location = new System.Drawing.Point(0, 181);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(918, 239);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "`";
            // 
            // dgvdanhsachsach
            // 
            this.dgvdanhsachsach.BackgroundColor = System.Drawing.Color.Tan;
            this.dgvdanhsachsach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvdanhsachsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsachsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masach,
            this.tensach,
            this.theloai,
            this.namsx,
            this.tacgia,
            this.nhaxuatban,
            this.ngaynhap,
            this.trigia});
            this.dgvdanhsachsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdanhsachsach.Location = new System.Drawing.Point(2, 15);
            this.dgvdanhsachsach.Margin = new System.Windows.Forms.Padding(2);
            this.dgvdanhsachsach.Name = "dgvdanhsachsach";
            this.dgvdanhsachsach.Size = new System.Drawing.Size(914, 222);
            this.dgvdanhsachsach.TabIndex = 0;
            this.dgvdanhsachsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdanhsachsach_CellClick);
            // 
            // masach
            // 
            this.masach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.masach.DataPropertyName = "masach";
            this.masach.HeaderText = "Mã Sách";
            this.masach.MinimumWidth = 10;
            this.masach.Name = "masach";
            this.masach.Width = 75;
            // 
            // tensach
            // 
            this.tensach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tensach.DataPropertyName = "tensach";
            this.tensach.HeaderText = "Tên Sách";
            this.tensach.Name = "tensach";
            this.tensach.Width = 79;
            // 
            // theloai
            // 
            this.theloai.DataPropertyName = "theloai";
            this.theloai.HeaderText = "Thể loại";
            this.theloai.Name = "theloai";
            // 
            // namsx
            // 
            this.namsx.DataPropertyName = "namsx";
            this.namsx.HeaderText = "Năm sản xuất";
            this.namsx.Name = "namsx";
            // 
            // tacgia
            // 
            this.tacgia.DataPropertyName = "tacgia";
            this.tacgia.HeaderText = "Tác giả";
            this.tacgia.Name = "tacgia";
            // 
            // nhaxuatban
            // 
            this.nhaxuatban.DataPropertyName = "nhaxuatban";
            this.nhaxuatban.HeaderText = "Nhà xuất bản";
            this.nhaxuatban.Name = "nhaxuatban";
            // 
            // ngaynhap
            // 
            this.ngaynhap.DataPropertyName = "ngaynhap";
            this.ngaynhap.HeaderText = "Ngày nhập";
            this.ngaynhap.Name = "ngaynhap";
            // 
            // trigia
            // 
            this.trigia.DataPropertyName = "trigia";
            this.trigia.HeaderText = "Trị giá";
            this.trigia.Name = "trigia";
            // 
            // dtnamxb
            // 
            this.dtnamxb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtnamxb.Location = new System.Drawing.Point(392, 43);
            this.dtnamxb.Margin = new System.Windows.Forms.Padding(2);
            this.dtnamxb.Name = "dtnamxb";
            this.dtnamxb.Size = new System.Drawing.Size(213, 20);
            this.dtnamxb.TabIndex = 27;
            // 
            // txtnhaxuatban
            // 
            this.txtnhaxuatban.Location = new System.Drawing.Point(392, 101);
            this.txtnhaxuatban.Margin = new System.Windows.Forms.Padding(2);
            this.txtnhaxuatban.Name = "txtnhaxuatban";
            this.txtnhaxuatban.Size = new System.Drawing.Size(213, 20);
            this.txtnhaxuatban.TabIndex = 25;
            // 
            // txttacgia
            // 
            this.txttacgia.Location = new System.Drawing.Point(392, 72);
            this.txttacgia.Margin = new System.Windows.Forms.Padding(2);
            this.txttacgia.Name = "txttacgia";
            this.txttacgia.Size = new System.Drawing.Size(213, 20);
            this.txttacgia.TabIndex = 24;
            // 
            // txttensach
            // 
            this.txttensach.Location = new System.Drawing.Point(108, 69);
            this.txttensach.Margin = new System.Windows.Forms.Padding(2);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(175, 20);
            this.txttensach.TabIndex = 23;
            // 
            // txtmasach
            // 
            this.txtmasach.Location = new System.Drawing.Point(108, 43);
            this.txtmasach.Margin = new System.Windows.Forms.Padding(2);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(175, 20);
            this.txtmasach.TabIndex = 22;
            // 
            // lbnxb
            // 
            this.lbnxb.AutoSize = true;
            this.lbnxb.BackColor = System.Drawing.Color.Transparent;
            this.lbnxb.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbnxb.Location = new System.Drawing.Point(298, 103);
            this.lbnxb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnxb.Name = "lbnxb";
            this.lbnxb.Size = new System.Drawing.Size(88, 16);
            this.lbnxb.TabIndex = 20;
            this.lbnxb.Text = "Nhà xuất bản:";
            // 
            // lbtacgia
            // 
            this.lbtacgia.AutoSize = true;
            this.lbtacgia.BackColor = System.Drawing.Color.Transparent;
            this.lbtacgia.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbtacgia.Location = new System.Drawing.Point(298, 76);
            this.lbtacgia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtacgia.Name = "lbtacgia";
            this.lbtacgia.Size = new System.Drawing.Size(53, 16);
            this.lbtacgia.TabIndex = 19;
            this.lbtacgia.Text = "Tác Giả:";
            // 
            // lbnamxuatban
            // 
            this.lbnamxuatban.AutoSize = true;
            this.lbnamxuatban.BackColor = System.Drawing.Color.Transparent;
            this.lbnamxuatban.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbnamxuatban.Location = new System.Drawing.Point(298, 46);
            this.lbnamxuatban.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnamxuatban.Name = "lbnamxuatban";
            this.lbnamxuatban.Size = new System.Drawing.Size(90, 16);
            this.lbnamxuatban.TabIndex = 18;
            this.lbnamxuatban.Text = "Năm xuất bản:";
            // 
            // lbtheloai
            // 
            this.lbtheloai.AutoSize = true;
            this.lbtheloai.BackColor = System.Drawing.Color.Transparent;
            this.lbtheloai.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbtheloai.Location = new System.Drawing.Point(38, 101);
            this.lbtheloai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtheloai.Name = "lbtheloai";
            this.lbtheloai.Size = new System.Drawing.Size(59, 16);
            this.lbtheloai.TabIndex = 17;
            this.lbtheloai.Text = "Thể loại:";
            // 
            // lbidsach
            // 
            this.lbidsach.AutoSize = true;
            this.lbidsach.BackColor = System.Drawing.Color.Transparent;
            this.lbidsach.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbidsach.Location = new System.Drawing.Point(40, 44);
            this.lbidsach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbidsach.Name = "lbidsach";
            this.lbidsach.Size = new System.Drawing.Size(57, 16);
            this.lbidsach.TabIndex = 16;
            this.lbidsach.Text = "Mã Sách:";
            // 
            // lbtensach
            // 
            this.lbtensach.AutoSize = true;
            this.lbtensach.BackColor = System.Drawing.Color.Transparent;
            this.lbtensach.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbtensach.Location = new System.Drawing.Point(38, 70);
            this.lbtensach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtensach.Name = "lbtensach";
            this.lbtensach.Size = new System.Drawing.Size(61, 16);
            this.lbtensach.TabIndex = 15;
            this.lbtensach.Text = "Tên Sách:";
            // 
            // lbngaynhap
            // 
            this.lbngaynhap.AutoSize = true;
            this.lbngaynhap.BackColor = System.Drawing.Color.Transparent;
            this.lbngaynhap.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbngaynhap.Location = new System.Drawing.Point(629, 73);
            this.lbngaynhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbngaynhap.Name = "lbngaynhap";
            this.lbngaynhap.Size = new System.Drawing.Size(72, 16);
            this.lbngaynhap.TabIndex = 29;
            this.lbngaynhap.Text = "Ngày nhập:";
            // 
            // lbtrigia
            // 
            this.lbtrigia.AutoSize = true;
            this.lbtrigia.BackColor = System.Drawing.Color.Transparent;
            this.lbtrigia.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbtrigia.Location = new System.Drawing.Point(629, 102);
            this.lbtrigia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtrigia.Name = "lbtrigia";
            this.lbtrigia.Size = new System.Drawing.Size(45, 16);
            this.lbtrigia.TabIndex = 30;
            this.lbtrigia.Text = "Trị giá:";
            // 
            // txttrigia
            // 
            this.txttrigia.Location = new System.Drawing.Point(705, 101);
            this.txttrigia.Margin = new System.Windows.Forms.Padding(2);
            this.txttrigia.Name = "txttrigia";
            this.txttrigia.Size = new System.Drawing.Size(151, 20);
            this.txttrigia.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnxoa);
            this.panel1.Controls.Add(this.lbllimittime);
            this.panel1.Controls.Add(this.btnchinhsua);
            this.panel1.Controls.Add(this.btnthoat);
            this.panel1.Controls.Add(this.btnsua);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Location = new System.Drawing.Point(0, 141);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 36);
            this.panel1.TabIndex = 33;
            // 
            // btnxoa
            // 
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnxoa.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(355, 5);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(54, 29);
            this.btnxoa.TabIndex = 39;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.Btnxoa_Click);
            // 
            // lbllimittime
            // 
            this.lbllimittime.AutoSize = true;
            this.lbllimittime.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbllimittime.Location = new System.Drawing.Point(629, 10);
            this.lbllimittime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllimittime.Name = "lbllimittime";
            this.lbllimittime.Size = new System.Drawing.Size(148, 16);
            this.lbllimittime.TabIndex = 38;
            this.lbllimittime.Text = "Thời hạn của sách: 8 năm";
            // 
            // btnchinhsua
            // 
            this.btnchinhsua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnchinhsua.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchinhsua.Location = new System.Drawing.Point(466, 5);
            this.btnchinhsua.Margin = new System.Windows.Forms.Padding(2);
            this.btnchinhsua.Name = "btnchinhsua";
            this.btnchinhsua.Size = new System.Drawing.Size(75, 29);
            this.btnchinhsua.TabIndex = 38;
            this.btnchinhsua.Text = "Chỉnh sửa";
            this.btnchinhsua.UseVisualStyleBackColor = true;
            this.btnchinhsua.Click += new System.EventHandler(this.Btnchinhsua_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthoat.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnthoat.Location = new System.Drawing.Point(241, 5);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(56, 29);
            this.btnthoat.TabIndex = 37;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnsua
            // 
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsua.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnsua.Location = new System.Drawing.Point(125, 5);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(56, 29);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthem.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnthem.Location = new System.Drawing.Point(17, 5);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(56, 29);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(686, 11);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(210, 20);
            this.txttimkiem.TabIndex = 35;
            this.txttimkiem.TextChanged += new System.EventHandler(this.Txttimkiem_TextChanged);
            this.txttimkiem.Leave += new System.EventHandler(this.Txttimkiem_Leave);
            // 
            // dtngaynhap
            // 
            this.dtngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaynhap.Location = new System.Drawing.Point(705, 72);
            this.dtngaynhap.Margin = new System.Windows.Forms.Padding(2);
            this.dtngaynhap.Name = "dtngaynhap";
            this.dtngaynhap.Size = new System.Drawing.Size(151, 20);
            this.dtngaynhap.TabIndex = 36;
            // 
            // cbtls
            // 
            this.cbtls.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbtls.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbtls.FormattingEnabled = true;
            this.cbtls.Location = new System.Drawing.Point(108, 99);
            this.cbtls.Margin = new System.Windows.Forms.Padding(2);
            this.cbtls.Name = "cbtls";
            this.cbtls.Size = new System.Drawing.Size(175, 21);
            this.cbtls.TabIndex = 37;
            // 
            // lbfind
            // 
            this.lbfind.AutoSize = true;
            this.lbfind.BackColor = System.Drawing.Color.Transparent;
            this.lbfind.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbfind.Location = new System.Drawing.Point(621, 12);
            this.lbfind.Name = "lbfind";
            this.lbfind.Size = new System.Drawing.Size(60, 16);
            this.lbfind.TabIndex = 38;
            this.lbfind.Text = "Tìm kiếm:";
            // 
            // FrmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(918, 430);
            this.Controls.Add(this.lbfind);
            this.Controls.Add(this.cbtls);
            this.Controls.Add(this.dtngaynhap);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txttrigia);
            this.Controls.Add(this.lbtrigia);
            this.Controls.Add(this.lbngaynhap);
            this.Controls.Add(this.dtnamxb);
            this.Controls.Add(this.txtnhaxuatban);
            this.Controls.Add(this.txttacgia);
            this.Controls.Add(this.txttensach);
            this.Controls.Add(this.txtmasach);
            this.Controls.Add(this.lbnxb);
            this.Controls.Add(this.lbtacgia);
            this.Controls.Add(this.lbnamxuatban);
            this.Controls.Add(this.lbtheloai);
            this.Controls.Add(this.lbidsach);
            this.Controls.Add(this.lbtensach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.function);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSach";
            this.Text = "Quản lý Sách";
            this.Load += new System.EventHandler(this.FrmSach_Load);
            this.function.ResumeLayout(false);
            this.function.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachsach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip function;
        private System.Windows.Forms.ToolStripButton btnMuonsach;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtnamxb;
        private System.Windows.Forms.TextBox txtnhaxuatban;
        private System.Windows.Forms.TextBox txttacgia;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.Label lbnxb;
        private System.Windows.Forms.Label lbtacgia;
        private System.Windows.Forms.Label lbnamxuatban;
        private System.Windows.Forms.Label lbtheloai;
        private System.Windows.Forms.Label lbidsach;
        private System.Windows.Forms.Label lbtensach;
        private System.Windows.Forms.Label lbngaynhap;
        private System.Windows.Forms.Label lbtrigia;
        private System.Windows.Forms.TextBox txttrigia;
        private System.Windows.Forms.DataGridView dgvdanhsachsach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.DateTimePicker dtngaynhap;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.ComboBox cbtls;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn theloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn namsx;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaxuatban;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn trigia;
        private System.Windows.Forms.Label lbllimittime;
        private System.Windows.Forms.Button btnchinhsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Label lbfind;
    }
}