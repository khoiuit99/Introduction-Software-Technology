namespace QLTV
{
    partial class FrmChinhSuaDG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChinhSuaDG));
            this.label1 = new System.Windows.Forms.Label();
            this.lbminage = new System.Windows.Forms.Label();
            this.lbmaxage = new System.Windows.Forms.Label();
            this.lblimittime = new System.Windows.Forms.Label();
            this.txtminage = new System.Windows.Forms.TextBox();
            this.txtmaxage = new System.Windows.Forms.TextBox();
            this.txtlimittime = new System.Windows.Forms.TextBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chỉnh sửa các thông số của độc giả";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbminage
            // 
            this.lbminage.AutoSize = true;
            this.lbminage.BackColor = System.Drawing.Color.Transparent;
            this.lbminage.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbminage.Location = new System.Drawing.Point(106, 96);
            this.lbminage.Name = "lbminage";
            this.lbminage.Size = new System.Drawing.Size(93, 16);
            this.lbminage.TabIndex = 1;
            this.lbminage.Text = "Tuổi nhỏ nhất:";
            // 
            // lbmaxage
            // 
            this.lbmaxage.AutoSize = true;
            this.lbmaxage.BackColor = System.Drawing.Color.Transparent;
            this.lbmaxage.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbmaxage.Location = new System.Drawing.Point(105, 138);
            this.lbmaxage.Name = "lbmaxage";
            this.lbmaxage.Size = new System.Drawing.Size(89, 16);
            this.lbmaxage.TabIndex = 2;
            this.lbmaxage.Text = "Tuổi lớn nhất:";
            // 
            // lblimittime
            // 
            this.lblimittime.AutoSize = true;
            this.lblimittime.BackColor = System.Drawing.Color.Transparent;
            this.lblimittime.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblimittime.Location = new System.Drawing.Point(105, 176);
            this.lblimittime.Name = "lblimittime";
            this.lblimittime.Size = new System.Drawing.Size(109, 16);
            this.lblimittime.TabIndex = 3;
            this.lblimittime.Text = "Thời hạn của thẻ:";
            // 
            // txtminage
            // 
            this.txtminage.Location = new System.Drawing.Point(220, 95);
            this.txtminage.Name = "txtminage";
            this.txtminage.Size = new System.Drawing.Size(100, 20);
            this.txtminage.TabIndex = 4;
            // 
            // txtmaxage
            // 
            this.txtmaxage.Location = new System.Drawing.Point(220, 137);
            this.txtmaxage.Name = "txtmaxage";
            this.txtmaxage.Size = new System.Drawing.Size(100, 20);
            this.txtmaxage.TabIndex = 5;
            // 
            // txtlimittime
            // 
            this.txtlimittime.Location = new System.Drawing.Point(220, 175);
            this.txtlimittime.Name = "txtlimittime";
            this.txtlimittime.Size = new System.Drawing.Size(100, 20);
            this.txtlimittime.TabIndex = 6;
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.Color.Transparent;
            this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnluu.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnluu.Location = new System.Drawing.Point(109, 211);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 31);
            this.btnluu.TabIndex = 7;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.Btnluu_Click);
            // 
            // btnquaylai
            // 
            this.btnquaylai.BackColor = System.Drawing.Color.Transparent;
            this.btnquaylai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnquaylai.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnquaylai.Location = new System.Drawing.Point(245, 211);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(75, 31);
            this.btnquaylai.TabIndex = 8;
            this.btnquaylai.Text = "Quay lại";
            this.btnquaylai.UseVisualStyleBackColor = false;
            this.btnquaylai.Click += new System.EventHandler(this.Btnquaylai_Click);
            // 
            // FrmChinhSuaDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(409, 246);
            this.Controls.Add(this.btnquaylai);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.txtlimittime);
            this.Controls.Add(this.txtmaxage);
            this.Controls.Add(this.txtminage);
            this.Controls.Add(this.lblimittime);
            this.Controls.Add(this.lbmaxage);
            this.Controls.Add(this.lbminage);
            this.Controls.Add(this.label1);
            this.Name = "FrmChinhSuaDG";
            this.Text = "Chỉnh sửa độc giả";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbminage;
        private System.Windows.Forms.Label lbmaxage;
        private System.Windows.Forms.Label lblimittime;
        private System.Windows.Forms.TextBox txtminage;
        private System.Windows.Forms.TextBox txtmaxage;
        private System.Windows.Forms.TextBox txtlimittime;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnquaylai;
    }
}