using QLTV_DAL;
using QLTV_Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    public class BUS_BaoCaoI
    {
        DAL_BaoCaoI sql = new DAL_BaoCaoI();

        public DataTable Check(string Dkthang)
        {
            return sql.Check(Dkthang);
        }
        public void truyendl()
        {
            sql.truyendl();
        }
    }
}
