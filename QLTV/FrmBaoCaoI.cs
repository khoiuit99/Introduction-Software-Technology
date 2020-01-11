using QLTV_BUS;
using QLTV_Entity;
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
    
    public partial class FrmBaoCaoI : Form
    {
        BUS_BaoCaoI bus = new BUS_BaoCaoI();
        E_BaoCaoI et = new E_BaoCaoI();
        KetNoiDB db = new KetNoiDB();
        public FrmBaoCaoI()
        {
            InitializeComponent();          
        }
        private void FrmBaoCaoI_Load(object sender, EventArgs e)
        {
            string loadthang = "select distinct thang from BaoCaoI";
            db.LoadData2Combobox(cbThang, loadthang);
            bus.truyendl();
        }

        private void Btnquaylai_Click(object sender, EventArgs e)
        {
            FrmMain main = new FrmMain();
            this.Hide();
            main.Show();
        }
        private void Button1_Click(object sender, EventArgs e)
        {           

            if (bus.Check(cbThang.Text).Rows.Count > 0)
            {
                string show = "select theloai as 'Thể loại', count (*) as 'Số lượt mượn', count(*) * 100.0 / sum(count(*)) over() as 'Tỷ lệ' " +
                              "from BaoCaoI where thang = '"+ cbThang.Text +"' group by theloai";
                db.LoadData2DataGridView(dgvBaoCaoI, show);
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
            
        }
        private void DgvBaoCaoI_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != this.dgvBaoCaoI.NewRowIndex && e.ColumnIndex == 2)
            {
                this.dgvBaoCaoI.InvalidateRow(this.dgvBaoCaoI.NewRowIndex);
            }
        }
        private void DgvBaoCaoI_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == this.dgvBaoCaoI.NewRowIndex)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.CellStyle.ForeColor = Color.Red;
                switch (e.ColumnIndex)
                {
                    case 0:
                        e.Value = "Tổng số lượt mượn: ";
                        break;

                    case 2:
                        var sum = 0.0d;
                        for (int i = 0; i < this.dgvBaoCaoI.NewRowIndex; i++)
                        {
                            var value = this.dgvBaoCaoI[2, i].Value;
                            sum += ((int)value);

                        }
                        e.Value = Math.Round(sum, 2);
                        break;
                        // Single line version of case 2 would be
                        //e.Value = this.dgvBaoCaoI.Rows.Cast<DataGridViewRow>().Where(a => a.Index != a.DataGridView.NewRowIndex).Select(a => (double)a.Cells[2].Value).Sum().ToString("N2");
                }
            }
        }
    }
      
}
