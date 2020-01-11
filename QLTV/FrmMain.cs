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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public static string TaiKhoan;
        private void FrmMain_Load(object sender, EventArgs e)
        {
            KhoaDieuKien();
            FormLoad();
            lbltaikhoan.Text = TaiKhoan;
        }
        void KhoaDieuKien()
        {
            tbtnDangNhap.Enabled = true;
            tbtnDanhSachSach.Enabled = false;
            tbtnDocGia.Enabled = false;
            tbtnSach.Enabled = false;
            tbtnBaocaoII.Enabled = false;
            tbtnBaocao.Enabled = false;
        }

        void MoDieuKien()
        {
            tbtnDangNhap.Enabled = true;
            tbtnDanhSachSach.Enabled = true;
            tbtnDocGia.Enabled = true;
            tbtnSach.Enabled = true;
            tbtnBaocaoII.Enabled = true;
            tbtnBaocao.Enabled = true;
        }
        private void FormLoad()
        {
            if(lbltaikhoan.Text == "")
            {
                tbtnDangNhap.Text = "Đăng xuất";
                MoDieuKien();
            }
        }
        private void tbtnDocGia_Click(object sender, EventArgs e)
        {
            FrmDocGia dg = new FrmDocGia();
            this.Hide();
            dg.ShowDialog();
        }

        private void tbtnSach_Click(object sender, EventArgs e)
        {
            FrmSach sc = new FrmSach();
            this.Hide();
            sc.ShowDialog();
        }

        private void DSS_Click(object sender, EventArgs e)
        {
            FrmDanhSachSach frmdss = new FrmDanhSachSach();
            this.Hide();
            frmdss.ShowDialog();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            FrmBaoCaoI frmbci = new FrmBaoCaoI();
            this.Hide();
            frmbci.ShowDialog();
        }

        private void BaoCaoII_Click(object sender, EventArgs e)
        {
            FrmBaoCaoII frmbaocao = new FrmBaoCaoII();
            this.Hide();
            frmbaocao.ShowDialog();
        }

        private void TbtnDangNhap_Click(object sender, EventArgs e)
        {
            DialogResult tinhtrang;
            if(tbtnDangNhap.Text == "Đăng xuất")
            {
               tinhtrang = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(tinhtrang == DialogResult.Yes)
                {
                    MessageBox.Show("Đăng xuất thành công!", "Thông Báo");
                    FrmDangNhap dn = new FrmDangNhap();
                    this.Hide();
                    dn.Show();
                }
            }
        }
    }
}
