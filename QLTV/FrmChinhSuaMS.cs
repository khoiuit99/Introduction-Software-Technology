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
    public partial class FrmChinhSuaMS : Form
    {
        public FrmChinhSuaMS()
        {
            InitializeComponent();
        }

        private void FrmChinhSuaMS_Load(object sender, EventArgs e)
        {

        }

        private void Btnquaylai_Click(object sender, EventArgs e)
        {
            FrmPhieuMuonSach pms = new FrmPhieuMuonSach();
            this.Hide();
            pms.Show();
        }

        private void Btnluu_Click(object sender, EventArgs e)
        {
            DialogResult trangthai;
            trangthai = (MessageBox.Show("Bạn có chắc chắc muốn chỉnh sửa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (trangthai == DialogResult.Yes)
            {
                //FrmPhieuMuonSach.days = txbtimelimit.Text;
                FrmPhieuMuonSach.soluotmuontoida = txbmax.Text;
                MessageBox.Show("Lưu thành công!!!", "Thông Báo");
                FrmPhieuMuonSach fms = new FrmPhieuMuonSach();
                this.Hide();
                fms.Show();
            }
        }
    }
}
