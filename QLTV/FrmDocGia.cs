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
using QLTV_BUS;

namespace QLTV
{
    public partial class FrmDocGia : Form
    {
        int day = DateTime.Now.Day;
        int year = DateTime.Now.Year;
        int month = DateTime.Now.Month;
        int c,d;
        public static string minage = "18";
        public static string maxage = "55";
        public static string limittime = "6";
        public static int nlt;
        public FrmDocGia()
        {
            InitializeComponent();
        }
        KetNoiDB db = new KetNoiDB();
        BUS_DocGia bus = new BUS_DocGia();
        E_DocGia ec = new E_DocGia();
        //bool themmoi;

        void KhoaDieuKien()
        {
            txtdiachi.Enabled = false;
            txtemail.Enabled = false;
            txthoten.Enabled = false;
            txtiddocgia.Enabled = false;

            dtngaylapthe.Enabled = false;
            dtngaysinh.Enabled = false;
            cbldg.Enabled = false;

        }

        void MoDieuKien()
        {
            txtdiachi.Enabled = true;
            txtemail.Enabled = true;
            txthoten.Enabled = true;
            txtiddocgia.Enabled = false;

            dtngaylapthe.Enabled = true;
            dtngaysinh.Enabled = true;
            cbldg.Enabled = true;
        }

        void setnull()
        {
            txtdiachi.Text = "";
            txtemail.Text = "";
            txthoten.Text = "";
            txtiddocgia.Text = "";
            cbldg.Text = "";
            dtngaylapthe.Text = "";
            dtngaysinh.Text = "";
        }

        void HienThi(string where)
        {
            dgvDocgia.DataSource = bus.TaoBang(where);
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtiddocgia.Text = dgvDocgia.Rows[dong].Cells[0].Value.ToString();
                txthoten.Text = dgvDocgia.Rows[dong].Cells[1].Value.ToString();
                cbldg.Text = dgvDocgia.Rows[dong].Cells[2].Value.ToString();
                dtngaysinh.Text = dgvDocgia.Rows[dong].Cells[3].Value.ToString();
                txtdiachi.Text = dgvDocgia.Rows[dong].Cells[4].Value.ToString();
                dtngaylapthe.Text = dgvDocgia.Rows[dong].Cells[6].Value.ToString();
                txtemail.Text = dgvDocgia.Rows[dong].Cells[5].Value.ToString();

            }
            catch
            {

            }
        }
        private void FrmDocGia_Load(object sender, EventArgs e)
        {
            nlt = int.Parse(dtngaylapthe.Value.Month.ToString());
            cbldg.DataSource = bus.LayThongtinLDG("");
            cbldg.ValueMember = "loaidocgia";
            cbldg.DisplayMember = "loaidocgia";
            KhoaDieuKien();
            HienThi("");
            lblminage.Text = "Tuổi nhỏ nhất: " + minage;
            lblmaxage.Text = "Tuổi lớn nhất: " + maxage;
            lbllimittime.Text = "Thời hạn của thẻ: " + limittime + " tháng";
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = btnsua.Enabled = false;
            if (btnthem.Text == "Thêm")
            {
                MoDieuKien();
                setnull();
                txtiddocgia.Focus();
                btnthem.Text = "Lưu";
                MaTuTang();
                FrmPhieuMuonSach.ngaylamthe = dtngaylapthe.Value.Month.ToString();
            }
            else if(btnthem.Text=="Lưu")
            {
                int yearinput = int.Parse(dtngaysinh.Value.Year.ToString());
                int monthinput = int.Parse(dtngaylapthe.Value.Month.ToString());
                c = year - yearinput;
                d = month - monthinput;
                int ma = Convert.ToInt32(minage);
                int ma1 = Convert.ToInt32(maxage);
                int lt = Convert.ToInt32(limittime);
                if (txtiddocgia.Text == "" || txthoten.Text == "" || cbldg.Text == "")
                {
                    MessageBox.Show("Xin mời nhập đầy đủ thông tin", "Thông Báo");
                    return;
                }
                else if (c < ma || c > ma1)
                {
                    MessageBox.Show("Tuổi không hợp lệ.", "Thông Báo");
                    return;
                }
                else if(d > lt)
                {
                    MessageBox.Show("Thẻ đã hết hạn vui lòng gia hạn.", "Thông Báo");
                    return;
                }
                else
                {
                    try
                    {
                        ec.diachi = txtdiachi.Text;
                        ec.email = txtemail.Text;
                        ec.hoten = txthoten.Text;
                        ec.iddocgia = txtiddocgia.Text;
                        ec.loaidocgia = cbldg.Text;
                        ec.ngaylapthe = dtngaylapthe.Value.ToString();
                        ec.ngaysinh = dtngaysinh.Value.ToString();
                        bus.ThemDuLieu(ec);
                        MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo");

                    }
                    catch
                    {
                        MessageBox.Show("Báo lỗi", "Thông báo");
                        return;
                    }
                }
                btnthem.Text = "Thêm";
                KhoaDieuKien();
                HienThi("");
            }
          
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = btnxoa.Enabled = false;
            if (btnsua.Text == "Sửa")
            {
                MoDieuKien();
                txtiddocgia.Focus();
                btnsua.Text = "Lưu";
            }
            else if (btnsua.Text == "Lưu")
            {
                int yearinput = int.Parse(dtngaysinh.Value.Year.ToString());
                int monthinput = int.Parse(dtngaylapthe.Value.Month.ToString());
                c = year - yearinput;
                d = month - monthinput;
                int ma = Convert.ToInt32(minage);
                int ma1 = Convert.ToInt32(maxage);
                int lt = Convert.ToInt32(limittime);
                if (txtiddocgia.Text == "" || txthoten.Text == "" || cbldg.Text == "")
                {
                    MessageBox.Show("Xin mời nhập đầy đủ thông tin", "Thông Báo");
                    return;
                }
                else if (c < ma || c > ma1)
                {
                    MessageBox.Show("Tuổi không hợp lệ.", "Thông Báo");
                    return;
                }
                else if (d > lt)
                {
                    MessageBox.Show("Thẻ đã hết hạn vui lòng gia hạn.", "Thông Báo");
                    return;
                }
                else
                {
                    try
                    {
                        ec.diachi = txtdiachi.Text;
                        ec.email = txtemail.Text;
                        ec.hoten = txthoten.Text;
                        ec.iddocgia = txtiddocgia.Text;
                        ec.loaidocgia = cbldg.Text;
                        ec.ngaylapthe = dtngaylapthe.Value.ToString();
                        ec.ngaysinh = dtngaysinh.Value.ToString();
                        bus.SuaDuLieu(ec);
                        MessageBox.Show("Sửa dữ liệu thành công!", "Thông báo");

                    }
                    catch
                    {
                        MessageBox.Show("Báo lỗi", "Thông báo");
                        return;
                    }
                }
                KhoaDieuKien();
                HienThi("");
                btnsua.Text = "Sửa";
            }
          
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.iddocgia = txtiddocgia.Text;
                bus.XoaDuLieu(ec);
                MessageBox.Show("Xóa thành công!");
                KhoaDieuKien();
                HienThi("");
            }
            catch
            {
                MessageBox.Show("Không thể xóa!");
            }

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            FrmMain main = new FrmMain();
            this.Hide();
            main.Show();
        }

        private void Btnchinhsuu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmChinhSuaDG cs = new FrmChinhSuaDG();
            cs.ShowDialog();
        }

        private void Txtfind_TextChanged(object sender, EventArgs e)
        {
            (dgvDocgia.DataSource as DataTable).DefaultView.RowFilter = string.Format("hoten LIKE '{0}%'", txtfind.Text);
        }

        private void Txtfind_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtfind.Text))
            {
                (dgvDocgia.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (dgvDocgia.DataSource as DataTable).DefaultView.RowFilter = string.Format("hoten='{0}'", txtfind.Text);
            }
        }

        private void MaTuTang()
        {
            DataTable dt = db.GetDataTable("Select * from DocGia");
            string h = "";

            if (dt.Rows.Count <= 0) 
            {
                h = "DG00001";
            }

            else
            {
                int k;//lấy giá trị số trong chuỗi mã nhân viên đã có
                h = "DG";//ký tự mặc định của mã nhân viên
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 5));
                k = k + 1;
                if (k < 10)

                    h = h + "0000";
                else if (k < 100)
                    h = h + "000";
                else if (k < 1000)
                    h = h + "00";
                else if (k < 10000)
                    h = h + "0";
                h = h + k.ToString();

            }
            txtiddocgia.Text = h;
        }
    }
}
