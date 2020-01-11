using QLTV_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    
    public class BUS_BaoCaoII
    {
        DAL_BaoCaoII sql = new DAL_BaoCaoII();
        public void truyendl()
        {
            sql.truyendl();
        }
        public void update(string DK)
        {
            sql.update(DK);
        }
    }
}
