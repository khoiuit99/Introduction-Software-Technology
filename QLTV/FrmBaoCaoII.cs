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

namespace QLTV
{
    public partial class FrmBaoCaoII : Form
    {
        BUS_BaoCaoII bus = new BUS_BaoCaoII();
        KetNoiDB db = new KetNoiDB();
        public string time1;
        int day = DateTime.Now.Day;
        int month = DateTime.Now.Month;
        int year = DateTime.Now.Year;
        public FrmBaoCaoII()
        {
            InitializeComponent();
        }
        private void FrmBaoCaoII_Load(object sender, EventArgs e)
        {
            txtngay.Text = "'" + month + "/" + day + "/" + year + "'";
            bus.truyendl();
        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            bus.update(txtngay.Text);
            string show = "select bc2.masach, bc2.tensach, bc2.ngaymuon, songaytratre from BaoCaoII bc2, PhieuMuonSach pms where bc2.masach = pms.masach";
            db.LoadData2DataGridView(dataGridView1, show);
        }
        private void Btnquaylai_Click(object sender, EventArgs e)
        {
            FrmMain main = new FrmMain();
            this.Hide();
            main.Show();
 
        }
    }
}
