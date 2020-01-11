using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;
using QLTV_DAL;

namespace QLTV
{
    public partial class FrmDangNhap : Form
    {
        string A, B, C, D, E, F;
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        KetNoiDB db = new KetNoiDB();

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            A = lbteacher.Text;
            B = lbnametc.Text;
            C = lbstudent.Text;
            D = lbname1.Text;
            E = lbname2.Text;
            F = lbname3.Text;
            lbteacher.Text = "";
            lbnametc.Text = "";
            lbstudent.Text = "";
            lbname1.Text = "";
            lbname2.Text = "";
            lbname3.Text = "";
            timer1.Start();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn huỷ đăng nhập?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (thongbao == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void Btndn_Click(object sender, EventArgs e)
        {
            string strcon = @"Server=.; Database=QLTV ;Integrated Security=SSPI;";
            //string user = txttnd.Text.Trim();
            //string pass = txtmk.Text.Trim();
            //DataTable dt = SqlHelper.ExecuteDataset(strcon, "DangNhap_Login", user, pass).Tables[0];

            //if (dt.Rows.Count > 0)
            //{
            //    MessageBox.Show("Bạn đã đăng nhập thành công.", "Thông Báo");
            //    this.Hide();
            //    FrmMain.TaiKhoan = txttnd.Text;
            //}
            //else
            //{
            //    MessageBox.Show("Sai tài khoản hoặc mật khẩu?", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    this.txttnd.Focus();
            //    txttnd.Text = txtmk.Text = "";
            //}
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            using (SqlCommand StrQuer = new SqlCommand("SELECT * FROM DangNhap WHERE USERNAME=@userid AND PASS=@password", con))
            {
                StrQuer.Parameters.AddWithValue("@userid", txttnd.Text);
                StrQuer.Parameters.AddWithValue("@password", txtmk.Text);
                
                SqlDataReader dr = StrQuer.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông Báo");
                    FrmMain.TaiKhoan = txttnd.Text;
                    FrmMain main = new FrmMain();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int d = 0, x;
            x = A.Length;
            d++;
            string a = A.Substring(0, 1);
            A = A.Substring(1, A.Length - 1);
            lbteacher.Text = lbteacher.Text + a;
            if(d == x)
            {
                timer1.Stop();
                timer2.Start();
            }
        }


        private void Timer2_Tick(object sender, EventArgs e)
        {
            int d = 0, x;
            x = B.Length;
            d++;
            string a = B.Substring(0, 1);
            B = B.Substring(1, B.Length - 1);
            lbnametc.Text = lbnametc.Text + a;
            if (d == x)
            {
                timer2.Stop();
                timer3.Start();
            }
        }
        private void Timer3_Tick(object sender, EventArgs e)
        {
            int d = 0, x;
            x = C.Length;
            d++;
            string a = C.Substring(0, 1);
            C = C.Substring(1, C.Length - 1);
            lbstudent.Text = lbstudent.Text + a;
            if (d == x)
            {
                timer3.Stop();
                timer4.Start();
                timer5.Start();
                timer6.Start();
            }
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            int d = 0, x;
            x = D.Length;
            d++;
            string a = D.Substring(0, 1);
            D = D.Substring(1, D.Length - 1);
            lbname1.Text = lbname1.Text + a;
            if (d == x)
            {
                timer4.Stop();
            }
        }

        private void Timer5_Tick(object sender, EventArgs e)
        {
            int d = 0, x;
            x = E.Length;
            d++;
            string a = E.Substring(0, 1);
            E = E.Substring(1, E.Length - 1);
            lbname2.Text = lbname2.Text + a;
            if (d == x)
            {
                timer5.Stop();
            }
        }

        private void Timer6_Tick_1(object sender, EventArgs e)
        {
            int d = 0, x;
            x = F.Length;
            d++;
            string a = F.Substring(0, 1);
            F = F.Substring(1, F.Length - 1);
            lbname3.Text = lbname3.Text + a;
            if (d == x)
            {
                timer6.Stop();
            }
        }

    }
}
