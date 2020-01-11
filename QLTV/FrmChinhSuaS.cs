using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class FrmChinhSuaS : Form
    {
        public string Value { get; set; }
        public FrmChinhSuaS()
        {
            InitializeComponent();
        }

        private void Btnluu_Click(object sender, EventArgs e)
        {
            this.Value = txbtheloai.Text;
            this.DialogResult = DialogResult.OK;
            FrmSach.Time = txblimittime.Text;
            this.Hide();
            MessageBox.Show("Lưu thành công!", "Thông Báo");
        }
        private void Btnquaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
