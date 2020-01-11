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
    public partial class FrmChinhSuaDG : Form
    {
        public FrmChinhSuaDG()
        {
            InitializeComponent();
        }

        private void Btnluu_Click(object sender, EventArgs e)
        {         
            DialogResult trangthai;
            trangthai = (MessageBox.Show("Bạn có chắc chắc muốn chỉnh sửa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if(trangthai == DialogResult.Yes)
            {
                FrmDocGia.minage = txtminage.Text;
                FrmDocGia.maxage = txtmaxage.Text;
                FrmDocGia.limittime = txtlimittime.Text;
                FrmPhieuMuonSach.limitimethe = txtlimittime.Text;
                MessageBox.Show("Lưu thành công!!!","Thông Báo");
                FrmDocGia dg = new FrmDocGia();
                this.Hide();
                dg.Show();
            }
        }

        private void Btnquaylai_Click(object sender, EventArgs e)
        {
            FrmDocGia dg = new FrmDocGia();
            this.Hide();
            dg.ShowDialog();
        }
    }
}
