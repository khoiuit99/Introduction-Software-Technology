using QLTV_BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV_DAL;
using QLTV_Entity;

namespace QLTV
{
    public partial class FrmDanhSachSach : Form
    {
        BUS_DanhSachSach busds = new BUS_DanhSachSach();
        KetNoiDB db = new KetNoiDB();
        E_DanhSachSach eds = new E_DanhSachSach();
        public FrmDanhSachSach()
        {
            InitializeComponent();
        }

        private void frmDanhSachSach_Load(object sender, EventArgs e)
        {
            HienThi("");
        }
        void HienThi(string where)
        {
           
            dgvDSS.DataSource = busds.TaoBang(where);

        }

        private void Btnquaylai_Click(object sender, EventArgs e)
        {
            FrmMain fm = new FrmMain();
            this.Hide();
            fm.Show();
        }

        private void Btnquaylai_Click_1(object sender, EventArgs e)
        {
            FrmMain main = new FrmMain();
            this.Hide();
            main.Show();
        }

        private void Btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                eds.masach = txbmasach.Text;
                busds.XoaDuLieu(eds);
                MessageBox.Show("Xoa thanh cong!");
                HienThi("");
            }
            catch
            {
                MessageBox.Show("That bai");
            }
        }
        private void DgvDSS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txbmasach.Text = dgvDSS.Rows[dong].Cells[1].Value.ToString();
        }
    }
}
