namespace QLTV
{
    partial class FrmChinhSuaS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChinhSuaS));
            this.label1 = new System.Windows.Forms.Label();
            this.lbadd = new System.Windows.Forms.Label();
            this.lbtimelimit = new System.Windows.Forms.Label();
            this.txbtheloai = new System.Windows.Forms.TextBox();
            this.txblimittime = new System.Windows.Forms.TextBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(76, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chỉnh sửa các thông số của sách";
            // 
            // lbadd
            // 
            this.lbadd.AutoSize = true;
            this.lbadd.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbadd.Location = new System.Drawing.Point(77, 83);
            this.lbadd.Name = "lbadd";
            this.lbadd.Size = new System.Drawing.Size(105, 18);
            this.lbadd.TabIndex = 1;
            this.lbadd.Text = "Thêm thể loại:";
            // 
            // lbtimelimit
            // 
            this.lbtimelimit.AutoSize = true;
            this.lbtimelimit.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbtimelimit.Location = new System.Drawing.Point(77, 127);
            this.lbtimelimit.Name = "lbtimelimit";
            this.lbtimelimit.Size = new System.Drawing.Size(145, 18);
            this.lbtimelimit.TabIndex = 2;
            this.lbtimelimit.Text = "Thời hạn nhận sách:";
            // 
            // txbtheloai
            // 
            this.txbtheloai.Location = new System.Drawing.Point(188, 83);
            this.txbtheloai.Name = "txbtheloai";
            this.txbtheloai.Size = new System.Drawing.Size(146, 20);
            this.txbtheloai.TabIndex = 3;
            // 
            // txblimittime
            // 
            this.txblimittime.Location = new System.Drawing.Point(234, 125);
            this.txblimittime.Name = "txblimittime";
            this.txblimittime.Size = new System.Drawing.Size(100, 20);
            this.txblimittime.TabIndex = 4;
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.Color.Transparent;
            this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnluu.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnluu.Location = new System.Drawing.Point(107, 165);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 34);
            this.btnluu.TabIndex = 5;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.Btnluu_Click);
            // 
            // btnquaylai
            // 
            this.btnquaylai.BackColor = System.Drawing.Color.Transparent;
            this.btnquaylai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnquaylai.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnquaylai.Location = new System.Drawing.Point(234, 165);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(75, 34);
            this.btnquaylai.TabIndex = 6;
            this.btnquaylai.Text = "Quay lại";
            this.btnquaylai.UseVisualStyleBackColor = false;
            this.btnquaylai.Click += new System.EventHandler(this.Btnquaylai_Click);
            // 
            // FrmChinhSuaS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(409, 211);
            this.Controls.Add(this.btnquaylai);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.txblimittime);
            this.Controls.Add(this.txbtheloai);
            this.Controls.Add(this.lbtimelimit);
            this.Controls.Add(this.lbadd);
            this.Controls.Add(this.label1);
            this.Name = "FrmChinhSuaS";
            this.Text = "Chỉnh sửa sách";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbadd;
        private System.Windows.Forms.Label lbtimelimit;
        private System.Windows.Forms.TextBox txbtheloai;
        private System.Windows.Forms.TextBox txblimittime;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnquaylai;
    }
}