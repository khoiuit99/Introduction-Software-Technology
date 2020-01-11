using QLTV_Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAL
{
    public class DAL_BaoCaoI
    {
        KetNoiDB cn = new KetNoiDB();

        public DataTable Check(string DKthang)
        {
            return cn.GetDataTable("Select * from BaoCaoI where thang ='" + DKthang + "'");
        }
        public void truyendl()
        {
            cn.ThucThiCauLenh("insert into BaoCaoI(masach, theloai, thang) select masach, theloai, month(ngaymuon) from PhieuMuonSach pms where not exists (select masach from BaoCaoI bc1 where bc1.masach = pms.masach)");
        }
    }
}
