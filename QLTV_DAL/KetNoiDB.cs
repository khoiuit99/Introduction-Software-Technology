using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace QLTV_DAL
{
    public class KetNoiDB
    {
        public static SqlConnection connect;
        SqlCommand sqlCom;
        SqlDataReader sqlRea;
        SqlDataAdapter sqlAdap;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        public void MoKetNoi()
        {

            if (KetNoiDB.connect == null)
                KetNoiDB.connect = new SqlConnection("Server=.; Database=QLTV ;Integrated Security=SSPI;");

            if (KetNoiDB.connect.State != ConnectionState.Open)
                KetNoiDB.connect.Open();
        }

        public void DongKetNoi()
        {
            if (KetNoiDB.connect != null)
            {

                if (KetNoiDB.connect.State == ConnectionState.Open)
                    KetNoiDB.connect.Close();
            }

        }
        //insert update delete 
        public void ThucThiCauLenh(string strSQL)
        {
            try
            {
                MoKetNoi();
                SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
                sqlcmd.ExecuteNonQuery();
                DongKetNoi();
            }
            catch
            {

            }
        }

        public DataTable GetDataTable(string strSQL)//lệnh select.....
        {
            try
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, connect);
                sqlda.Fill(dt);
                DongKetNoi();
                return dt;

            }
            catch
            {
                return null;
            }
        }
        public static string _ChuoiKetNoi = (@"Server=.; Database=QLTV ;Integrated Security=SSPI");
        public static DataTable GetDanhSach(string strSQL)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(_ChuoiKetNoi);
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = strSQL;
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable GetDataTableDSS(string strSQL)//lệnh select.....
        {
            try
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlCommand sqlcmd = new SqlCommand(@"SELECT IDENTITY(INT,1,1) AS stt, masach, tensach, theloai, tacgia, tinhtrang INTO #TableTemp FROM DanhSachSach", connect);
                sqlcmd.ExecuteNonQuery();
                SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, connect);
                sqlda.Fill(dt);
                DongKetNoi();
                return dt;

            }
            catch
            {
                return null;
            }
        }
        public DataTable GetDataTablePhieuMuon(string a, string strSQL)//lệnh select.....
        {
            try
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlCommand sqlcmd = new SqlCommand(@"SELECT IDENTITY(INT,1,1) AS stt, masach, tensach, theloai, tacgia INTO #TableTemp FROM PhieuMuonSach where iddocgia='" + a + "'", connect);
                sqlcmd.ExecuteNonQuery();
                SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, connect);
                sqlda.Fill(dt);
                DongKetNoi();
                return dt;

            }
            catch
            {
                return null;
            }
        }
        public string GetValue(string strSQL)//lệnh select..... lấy dữ liệu ở 1 cột trong bảng!
        {
            string temp = null;
            MoKetNoi();
            SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            while (sqldr.Read())
                temp = sqldr[0].ToString();
            DongKetNoi();
            return temp;
        }
        /// <param name="cb">Tên của  Combobox</param>
        /// <param name="strSelect">Câu lệnh Select cần lấy dữ liệu cho Combobox</param>
        public void LoadData2Combobox(ComboBox cb, string strSelect)
        {
            cb.Items.Clear();
            //Kết nối
            MoKetNoi();
            //Thực thi
            sqlCom = new SqlCommand(strSelect, connect);
            sqlRea = sqlCom.ExecuteReader();
            //Load dữ liệu vào Combobox
            while (sqlRea.Read())
            {
                cb.Items.Add(sqlRea[0].ToString());
            }
            //Đóng kết nối
            DongKetNoi();
        }
        public void LoadData2DataGridView(DataGridView dg, string strSelect)
        {
            dt.Clear();
            //Fill vào DataTable
            sqlAdap = new SqlDataAdapter(strSelect, connect);
            sqlAdap.Fill(dt);
            dg.DataSource = dt;
        }
        public void LoadData2Label(Label lb, string strSelect)
        {
            lb.Text = "";
            MoKetNoi();
            sqlCom = new SqlCommand(strSelect, connect);
            sqlRea = sqlCom.ExecuteReader();
            while (sqlRea.Read())
            {
                lb.Text = sqlRea[0].ToString();
            }
            DongKetNoi();
        }
        public int soluotmuon(string a, int days)
        {
            SqlConnection sqlConnection = new SqlConnection(_ChuoiKetNoi);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select count(*) from PhieuMuonSach inner join DocGia on PhieuMuonSach.iddocgia = DocGia.iddocgia where PhieuMuonSach.ngaymuon between GETDATE()-4 and GETDATE() and PhieuMuonSach.iddocgia = '" + a + "'");
            sqlCommand.Connection = sqlConnection;
            int result;
            return result = Convert.ToInt32(sqlCommand.ExecuteScalar());
        }
    }
}