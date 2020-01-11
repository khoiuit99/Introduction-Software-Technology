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
using QLTV_BUS;
using QLTV_Entity;

namespace QLTV
{
    public partial class FrmSach : Form
    {
        public static string Time = "8";
        //Random rand = new Random();
        public FrmSach()
        {
            InitializeComponent();
        }
        KetNoiDB db = new KetNoiDB();
        BUS_Sach bus = new BUS_Sach();
        E_Sach ec = new E_Sach();
        E_DanhSachSach ecds = new E_DanhSachSach();
        BUS_DanhSachSach busds = new BUS_DanhSachSach();
        DataTable dt = new DataTable();
        int year = DateTime.Now.Year;
        void KhoaDieuKien()
        {
            txtmasach.Enabled = false;
            txtnhaxuatban.Enabled = false;
            txttacgia.Enabled = false;
            txttensach.Enabled = false;
            txttrigia.Enabled = false;
            txttensach.Enabled = false;
            dtnamxb.Enabled = false;
            dtngaynhap.Enabled = false;
            cbtls.Enabled = false;

        }

        void MoDieuKien()
        {
            txtmasach.Enabled = false;
            txtnhaxuatban.Enabled = true;
            txttacgia.Enabled = true;
            txttensach.Enabled = true;
            txttrigia.Enabled = true;
            txttensach.Enabled = true;
            dtnamxb.Enabled = true;
            dtngaynhap.Enabled = true;
            cbtls.Enabled = true;

        }
        void setnull()
        {
            txttrigia.Text = "";
            txttimkiem.Text = "";
            txttensach.Text = "";
            txttacgia.Text = "";
            txtnhaxuatban.Text = "";
            txtmasach.Text = "";
            dtnamxb.Text = "";
            dtngaynhap.Text = "";
            cbtls.Text = "";
        }
        void HienThi(string where)
        {
            dgvdanhsachsach.DataSource = bus.TaoBang(where);
        }
        private void dgvdanhsachsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtmasach.Text = dgvdanhsachsach.Rows[dong].Cells[0].Value.ToString();
                txttensach.Text = dgvdanhsachsach.Rows[dong].Cells[1].Value.ToString();
                cbtls.Text = dgvdanhsachsach.Rows[dong].Cells[2].Value.ToString();
                dtnamxb.Text = dgvdanhsachsach.Rows[dong].Cells[4].Value.ToString();
                txttacgia.Text = dgvdanhsachsach.Rows[dong].Cells[3].Value.ToString();
                txtnhaxuatban.Text = dgvdanhsachsach.Rows[dong].Cells[5].Value.ToString();
                dtngaynhap.Text = dgvdanhsachsach.Rows[dong].Cells[6].Value.ToString();
                txttrigia.Text = dgvdanhsachsach.Rows[dong].Cells[7].Value.ToString();
            }
            catch
            {

            }
        }
        private void FrmSach_Load(object sender, EventArgs e)
        {
            string show = "select DISTINCT theloai from Sach where theloai is not null";
            db.LoadData2Combobox(cbtls, show);
            KhoaDieuKien();
            HienThi("");
            lbllimittime.Text = "Thời hạn của sách: " + Time + " năm";
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            if (btnthem.Text == "Thêm")
            {
                MoDieuKien();
                setnull();
                txtmasach.Focus();
                btnthem.Text = "Lưu";
                MaTuTang();
            }
            else if (btnthem.Text == "Lưu")
            {
                int yearinput = int.Parse(dtnamxb.Value.Year.ToString());
                int c = year - yearinput;
                int lt = Convert.ToInt32(Time);
                if (txttacgia.Text == "" || txttensach.Text == "" || cbtls.Text == "")
                {
                    MessageBox.Show("Xin mời nhập đầy đủ thông tin", "Thông Báo");
                    return;
                }
                else if (c > lt)
                {
                    MessageBox.Show("Sách đã quá hạn.", "Thông Báo");
                    return;
                }
                else
                {
                    try
                    {
                        ec.masach = txtmasach.Text;
                        ec.namsx = dtnamxb.Value.ToString();
                        ec.ngaynhap = dtngaynhap.Value.ToString();
                        ec.nhaxuatban = txtnhaxuatban.Text;
                        ec.tacgia = txttacgia.Text;
                        ec.tensach = txttensach.Text;
                        ec.theloai = cbtls.Text;
                        ec.trigia = txttrigia.Text;
                        bus.ThemDuLieu(ec);
                        ecds.masach = txtmasach.Text;
                        ecds.tensach = txttensach.Text;
                        ecds.theloai = cbtls.Text;
                        ecds.tacgia = txttacgia.Text;
                        busds.ThemDuLieu(ecds);


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
            string show = "select DISTINCT theloai from Sach where theloai is not null";
            db.LoadData2Combobox(cbtls, show);
        }
        private void MaTuTang()
        {
            DataTable dt = db.GetDataTable("Select * from Sach");
            string h = "";

            if (dt.Rows.Count <= 0)
            {
                h = "BK00001";
            }

            else
            {
                int k;//lấy giá trị số trong chuỗi mã nhân viên đã có
                h = "BK";//ký tự mặc định của mã nhân viên
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
            txtmasach.Text = h;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = false;
            if (btnsua.Text == "Sửa")
            {

                MoDieuKien();
                txtmasach.Focus();
                btnsua.Text = "Lưu";
            }
            else if (btnsua.Text == "Lưu")
            {
                int yearinput = int.Parse(dtnamxb.Value.Year.ToString());
                int c = year - yearinput;
                int lt = Convert.ToInt32(Time);
                if (txtmasach.Text == "" || txttensach.Text == "" || cbtls.Text == "")
                {
                    MessageBox.Show("Xin mời nhập đầy đủ thông tin", "Thông Báo");
                    return;
                }
                else if (c > lt)
                {
                    MessageBox.Show("Sách đã quá hạn.", "Thông Báo");
                    return;
                }
                else
                {
                    try
                    {
                        ec.masach = txtmasach.Text;
                        ec.namsx = dtnamxb.Value.ToString();
                        ec.ngaynhap = dtngaynhap.Value.ToString();
                        ec.nhaxuatban = txtnhaxuatban.Text;
                        ec.tacgia = txttacgia.Text;
                        ec.tensach = txttensach.Text;
                        ec.theloai = cbtls.Text;
                        ec.trigia = txttrigia.Text;
                        bus.SuaDuLieu(ec);
                        ecds.masach = txtmasach.Text;
                        ecds.tensach = txttensach.Text;
                        ecds.tacgia = txttacgia.Text;
                        ecds.theloai = cbtls.Text;
                        busds.SuaDuLieu(ecds);

                        MessageBox.Show("Sửa dữ liệu thành công!", "Thông báo");

                    }
                    catch
                    {
                        MessageBox.Show("Báo lỗi", "Thông báo");
                        return;
                    }
                }
                btnsua.Text = "Sửa";
                KhoaDieuKien();
                HienThi("");
            }
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            FrmMain main = new FrmMain();
            this.Hide();
            main.Show();
        }
        private void BtnMuonsach_Click(object sender, EventArgs e)
        {
            frmIDDG DG = new frmIDDG();
            this.Hide();
            DG.FLag = "Muon";
            DG.Show();
        }

        private void TraSach_Click(object sender, EventArgs e)
        {
            frmIDDG DG = new frmIDDG();
            DG.FLag = "Tra";
            this.Hide();
            DG.Show();
        }

        private void Btnchinhsua_Click(object sender, EventArgs e)
        {
            FrmChinhSuaS css = new FrmChinhSuaS();
            if (css.ShowDialog() == DialogResult.OK)
            {
                cbtls.Items.Add(css.Value);
                lbllimittime.Text = "Thời hạn của sách: " + Time + " năm";
            }
        }
        private void Txttimkiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txttimkiem.Text))
            {
                (dgvdanhsachsach.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (dgvdanhsachsach.DataSource as DataTable).DefaultView.RowFilter = string.Format("tensach='{0}'", txttimkiem.Text);
            }
        }

        private void Txttimkiem_TextChanged(object sender, EventArgs e)
        {
            (dgvdanhsachsach.DataSource as DataTable).DefaultView.RowFilter = string.Format("hoten LIKE '{0}%'", txttimkiem.Text);
        }

        private void Btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.masach = txtmasach.Text;
                bus.XoaDuLieu(ec);
                MessageBox.Show("Xóa thành công!");
                KhoaDieuKien();
                HienThi("");
            }
            catch
            {
                MessageBox.Show("Thất bại!");
            }
        }

    }
}
