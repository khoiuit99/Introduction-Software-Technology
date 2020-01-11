namespace QLTV
{
    partial class FrmPhieuMuonSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhieuMuonSach));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbmasach = new System.Windows.Forms.Label();
            this.lbtensach = new System.Windows.Forms.Label();
            this.cbHoTen = new System.Windows.Forms.ComboBox();
            this.lbtacgia = new System.Windows.Forms.Label();
            this.dtngaymuon = new System.Windows.Forms.DateTimePicker();
            this.lbtheloai = new System.Windows.Forms.Label();
            this.lbngaymuon = new System.Windows.Forms.Label();
            this.lbhoten = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbcount = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.btnchinhsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuMuonSach = new System.Windows.Forms.DataGridView();
            this.cbmasach = new System.Windows.Forms.ComboBox();
            this.cbtensach = new System.Windows.Forms.ComboBox();
            this.cbtheloai = new System.Windows.Forms.ComboBox();
            this.cbtacgia = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuonSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lbmasach);
            this.panel1.Controls.Add(this.lbtensach);
            this.panel1.Controls.Add(this.cbHoTen);
            this.panel1.Controls.Add(this.lbtacgia);
            this.panel1.Controls.Add(this.dtngaymuon);
            this.panel1.Controls.Add(this.lbtheloai);
            this.panel1.Controls.Add(this.lbngaymuon);
            this.panel1.Controls.Add(this.lbhoten);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 133);
            this.panel1.TabIndex = 0;
            // 
            // lbmasach
            // 
            this.lbmasach.AutoSize = true;
            this.lbmasach.BackColor = System.Drawing.Color.Transparent;
            this.lbmasach.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbmasach.Location = new System.Drawing.Point(41, 75);
            this.lbmasach.Name = "lbmasach";
            this.lbmasach.Size = new System.Drawing.Size(57, 16);
            this.lbmasach.TabIndex = 7;
            this.lbmasach.Text = "Mã Sách:";
            // 
            // lbtensach
            // 
            this.lbtensach.AutoSize = true;
            this.lbtensach.BackColor = System.Drawing.Color.Transparent;
            this.lbtensach.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbtensach.Location = new System.Drawing.Point(41, 107);
            this.lbtensach.Name = "lbtensach";
            this.lbtensach.Size = new System.Drawing.Size(61, 16);
            this.lbtensach.TabIndex = 10;
            this.lbtensach.Text = "Tên Sách:";
            // 
            // cbHoTen
            // 
            this.cbHoTen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbHoTen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbHoTen.FormattingEnabled = true;
            this.cbHoTen.Location = new System.Drawing.Point(106, 21);
            this.cbHoTen.Name = "cbHoTen";
            this.cbHoTen.Size = new System.Drawing.Size(169, 21);
            this.cbHoTen.TabIndex = 17;
            // 
            // lbtacgia
            // 
            this.lbtacgia.AutoSize = true;
            this.lbtacgia.BackColor = System.Drawing.Color.Transparent;
            this.lbtacgia.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbtacgia.Location = new System.Drawing.Point(320, 107);
            this.lbtacgia.Name = "lbtacgia";
            this.lbtacgia.Size = new System.Drawing.Size(53, 16);
            this.lbtacgia.TabIndex = 9;
            this.lbtacgia.Text = "Tác Giả:";
            // 
            // dtngaymuon
            // 
            this.dtngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaymuon.Location = new System.Drawing.Point(385, 21);
            this.dtngaymuon.Margin = new System.Windows.Forms.Padding(2);
            this.dtngaymuon.Name = "dtngaymuon";
            this.dtngaymuon.Size = new System.Drawing.Size(183, 20);
            this.dtngaymuon.TabIndex = 16;
            // 
            // lbtheloai
            // 
            this.lbtheloai.AutoSize = true;
            this.lbtheloai.BackColor = System.Drawing.Color.Transparent;
            this.lbtheloai.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbtheloai.Location = new System.Drawing.Point(320, 75);
            this.lbtheloai.Name = "lbtheloai";
            this.lbtheloai.Size = new System.Drawing.Size(63, 16);
            this.lbtheloai.TabIndex = 8;
            this.lbtheloai.Text = "Thể Loại:";
            // 
            // lbngaymuon
            // 
            this.lbngaymuon.AutoSize = true;
            this.lbngaymuon.BackColor = System.Drawing.Color.Transparent;
            this.lbngaymuon.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbngaymuon.Location = new System.Drawing.Point(306, 24);
            this.lbngaymuon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbngaymuon.Name = "lbngaymuon";
            this.lbngaymuon.Size = new System.Drawing.Size(75, 16);
            this.lbngaymuon.TabIndex = 3;
            this.lbngaymuon.Text = "Ngày mượn:";
            // 
            // lbhoten
            // 
            this.lbhoten.AutoSize = true;
            this.lbhoten.BackColor = System.Drawing.Color.Transparent;
            this.lbhoten.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbhoten.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbhoten.Location = new System.Drawing.Point(8, 24);
            this.lbhoten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbhoten.Name = "lbhoten";
            this.lbhoten.Size = new System.Drawing.Size(97, 16);
            this.lbhoten.TabIndex = 2;
            this.lbhoten.Text = "Họ tên Độc giả:";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.lbcount);
            this.panel2.Controls.Add(this.lbid);
            this.panel2.Controls.Add(this.btnchinhsua);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.btnthoat);
            this.panel2.Location = new System.Drawing.Point(3, 130);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 33);
            this.panel2.TabIndex = 1;
            // 
            // lbcount
            // 
            this.lbcount.AutoSize = true;
            this.lbcount.BackColor = System.Drawing.Color.Transparent;
            this.lbcount.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbcount.Location = new System.Drawing.Point(465, 10);
            this.lbcount.Name = "lbcount";
            this.lbcount.Size = new System.Drawing.Size(92, 16);
            this.lbcount.TabIndex = 42;
            this.lbcount.Text = "Số lượt mượn:";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.BackColor = System.Drawing.Color.Transparent;
            this.lbid.Location = new System.Drawing.Point(361, 13);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(0, 13);
            this.lbid.TabIndex = 41;
            // 
            // btnchinhsua
            // 
            this.btnchinhsua.BackColor = System.Drawing.Color.Transparent;
            this.btnchinhsua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnchinhsua.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnchinhsua.Location = new System.Drawing.Point(239, 7);
            this.btnchinhsua.Margin = new System.Windows.Forms.Padding(2);
            this.btnchinhsua.Name = "btnchinhsua";
            this.btnchinhsua.Size = new System.Drawing.Size(86, 24);
            this.btnchinhsua.TabIndex = 39;
            this.btnchinhsua.Text = "Chỉnh sửa";
            this.btnchinhsua.UseVisualStyleBackColor = false;
            this.btnchinhsua.Click += new System.EventHandler(this.Btnchinhsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Transparent;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthem.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnthem.Location = new System.Drawing.Point(18, 7);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(56, 24);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.Them_click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Transparent;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthoat.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnthoat.Location = new System.Drawing.Point(115, 7);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(79, 24);
            this.btnthoat.TabIndex = 38;
            this.btnthoat.Text = "Quay lại";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.Btnthoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPhieuMuonSach);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(3, 167);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(594, 189);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách mượn";
            // 
            // dgvPhieuMuonSach
            // 
            this.dgvPhieuMuonSach.BackgroundColor = System.Drawing.Color.Tan;
            this.dgvPhieuMuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuonSach.Location = new System.Drawing.Point(6, 18);
            this.dgvPhieuMuonSach.Name = "dgvPhieuMuonSach";
            this.dgvPhieuMuonSach.Size = new System.Drawing.Size(579, 166);
            this.dgvPhieuMuonSach.TabIndex = 0;
            // 
            // cbmasach
            // 
            this.cbmasach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbmasach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbmasach.FormattingEnabled = true;
            this.cbmasach.Location = new System.Drawing.Point(109, 72);
            this.cbmasach.Name = "cbmasach";
            this.cbmasach.Size = new System.Drawing.Size(121, 21);
            this.cbmasach.TabIndex = 3;
            // 
            // cbtensach
            // 
            this.cbtensach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbtensach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbtensach.FormattingEnabled = true;
            this.cbtensach.Location = new System.Drawing.Point(109, 104);
            this.cbtensach.Name = "cbtensach";
            this.cbtensach.Size = new System.Drawing.Size(121, 21);
            this.cbtensach.TabIndex = 4;
            // 
            // cbtheloai
            // 
            this.cbtheloai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbtheloai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbtheloai.FormattingEnabled = true;
            this.cbtheloai.Location = new System.Drawing.Point(388, 72);
            this.cbtheloai.Name = "cbtheloai";
            this.cbtheloai.Size = new System.Drawing.Size(121, 21);
            this.cbtheloai.TabIndex = 5;
            // 
            // cbtacgia
            // 
            this.cbtacgia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbtacgia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbtacgia.FormattingEnabled = true;
            this.cbtacgia.Location = new System.Drawing.Point(388, 104);
            this.cbtacgia.Name = "cbtacgia";
            this.cbtacgia.Size = new System.Drawing.Size(121, 21);
            this.cbtacgia.TabIndex = 6;
            // 
            // FrmPhieuMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.cbtacgia);
            this.Controls.Add(this.cbtheloai);
            this.Controls.Add(this.cbtensach);
            this.Controls.Add(this.cbmasach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPhieuMuonSach";
            this.Text = "Phiếu Mượn sách";
            this.Load += new System.EventHandler(this.frmPhieuMuonSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuonSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbngaymuon;
        private System.Windows.Forms.Label lbhoten;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtngaymuon;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.ComboBox cbHoTen;
        private System.Windows.Forms.ComboBox cbmasach;
        private System.Windows.Forms.ComboBox cbtensach;
        private System.Windows.Forms.ComboBox cbtheloai;
        private System.Windows.Forms.ComboBox cbtacgia;
        private System.Windows.Forms.Label lbmasach;
        private System.Windows.Forms.Label lbtheloai;
        private System.Windows.Forms.Label lbtacgia;
        private System.Windows.Forms.Label lbtensach;
        private System.Windows.Forms.Button btnchinhsua;
        private System.Windows.Forms.DataGridView dgvPhieuMuonSach;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label lbcount;
    }
}