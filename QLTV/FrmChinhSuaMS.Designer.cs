namespace QLTV
{
    partial class FrmChinhSuaMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChinhSuaMS));
            this.btnquaylai = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.txbmax = new System.Windows.Forms.TextBox();
            this.txbtimelimit = new System.Windows.Forms.TextBox();
            this.lbmax = new System.Windows.Forms.Label();
            this.lbtimelimit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnquaylai
            // 
            this.btnquaylai.BackColor = System.Drawing.Color.Transparent;
            this.btnquaylai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnquaylai.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnquaylai.Location = new System.Drawing.Point(228, 177);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(75, 34);
            this.btnquaylai.TabIndex = 13;
            this.btnquaylai.Text = "Quay lại";
            this.btnquaylai.UseVisualStyleBackColor = false;
            this.btnquaylai.Click += new System.EventHandler(this.Btnquaylai_Click);
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.Color.Transparent;
            this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnluu.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnluu.Location = new System.Drawing.Point(99, 177);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 34);
            this.btnluu.TabIndex = 12;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.Btnluu_Click);
            // 
            // txbmax
            // 
            this.txbmax.Location = new System.Drawing.Point(218, 142);
            this.txbmax.Name = "txbmax";
            this.txbmax.Size = new System.Drawing.Size(146, 20);
            this.txbmax.TabIndex = 11;
            // 
            // txbtimelimit
            // 
            this.txbtimelimit.Enabled = false;
            this.txbtimelimit.Location = new System.Drawing.Point(218, 93);
            this.txbtimelimit.Name = "txbtimelimit";
            this.txbtimelimit.Size = new System.Drawing.Size(146, 20);
            this.txbtimelimit.TabIndex = 10;
            // 
            // lbmax
            // 
            this.lbmax.AutoSize = true;
            this.lbmax.BackColor = System.Drawing.Color.Transparent;
            this.lbmax.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbmax.Location = new System.Drawing.Point(47, 143);
            this.lbmax.Name = "lbmax";
            this.lbmax.Size = new System.Drawing.Size(165, 16);
            this.lbmax.TabIndex = 9;
            this.lbmax.Text = "Số lượng sách mượn tối đa:";
            // 
            // lbtimelimit
            // 
            this.lbtimelimit.AutoSize = true;
            this.lbtimelimit.BackColor = System.Drawing.Color.Transparent;
            this.lbtimelimit.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbtimelimit.Location = new System.Drawing.Point(47, 97);
            this.lbtimelimit.Name = "lbtimelimit";
            this.lbtimelimit.Size = new System.Drawing.Size(127, 16);
            this.lbtimelimit.TabIndex = 8;
            this.lbtimelimit.Text = "Thời hạn mượn sách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chỉnh sửa các thông số của việc mượn sách";
            // 
            // FrmChinhSuaMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(409, 211);
            this.Controls.Add(this.btnquaylai);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.txbmax);
            this.Controls.Add(this.txbtimelimit);
            this.Controls.Add(this.lbmax);
            this.Controls.Add(this.lbtimelimit);
            this.Controls.Add(this.label1);
            this.Name = "FrmChinhSuaMS";
            this.Text = "Chỉnh sửa mượn sách";
            this.Load += new System.EventHandler(this.FrmChinhSuaMS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.TextBox txbmax;
        private System.Windows.Forms.TextBox txbtimelimit;
        private System.Windows.Forms.Label lbmax;
        private System.Windows.Forms.Label lbtimelimit;
        private System.Windows.Forms.Label label1;
    }
}