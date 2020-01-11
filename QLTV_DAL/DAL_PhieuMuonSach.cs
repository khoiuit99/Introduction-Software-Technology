using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_Entity;

namespace QLTV_DAL
{
    public class DAL_PhieuMuonSach
    {
        KetNoiDB cn = new KetNoiDB();

        // Thêm Dữ Liệu
        public void ThemDuLieu(E_PhieuMuonSach et)
        {
            cn.ThucThiCauLenh(@"INSERT INTO PhieuMuonSach (masach, iddocgia, tensach, theloai, tacgia, hoten, ngaymuon) VALUES  ('" + et.masach + "',N'" + et.iddocgia + "',N'" + et.tensach + "',N'" + et.theloai + "',N'" + et.tacgia + "',N'" + et.hoten + "',N'" + et.ngaymuon + "')");
        }
        public void ThemDuLieu2(E_PhieuMuonSach et)
        {
            cn.ThucThiCauLenh(@"INSERT INTO PhieuMuonSach( theloai, ngaymuon) VALUES  ('"+ et.theloai + "',N'" + et.ngaymuon + "')");
        }
        //Xoá
        public void XoaDuLieu(string a)
        {
            cn.ThucThiCauLenh(@"DELETE FROM PhieuMuonSach  Where masach='" + a + "'");
        }
        //Lấy Dữ Liệu
        //TaoBang("") select * from tblKhachHang where MaKH ='1'( ví dụ)
        public DataTable TaoBang(string a)
        {
            return cn.GetDataTablePhieuMuon(a, "Select * from #TableTemp ");
        }
        public DataTable LayThongtinHT(string DieuKien)
        {
           return cn.GetDataTable("Select hoten from DocGia " + DieuKien);
        }
        public DataTable Check(string a)
        {
            return cn.GetDataTable(@"Select masach from DanhSachSach where tinhtrang = 'Yes' AND masach = '" + a + "'");
        }
        public void updatetinhtrang(string DieuKien)
        {
            cn.ThucThiCauLenh("UPDATE DanhSachSach SET tinhtrang = 'No' where masach='" + DieuKien+"'");
        }
        public void updatetinhtrang2(string DieuKien)
        {
            cn.ThucThiCauLenh("UPDATE DanhSachSach SET tinhtrang = 'Yes' where masach='" + DieuKien + "'");
        }
        public string getvalue(string a)
        {
            return cn.GetValue("select tinhtrang from DanhSachSach where masach='"+a+"'");
        }
    }
}
