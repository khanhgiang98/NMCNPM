using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TiecCuoi.DAO
{
    class BaoCaoDAO
    {
        private BaoCaoDAO() { }

        private static BaoCaoDAO instance;

        public static BaoCaoDAO Instance
        {
            get
            {
                if (instance == null) instance = new BaoCaoDAO(); return instance;
            }

            private set
            {
                instance = value;
            }
        }
        public DataTable loadBC(string th, string nam)
        {
            string query = "SELECT * FROM DOANH_THU_NGAY where MONTH(dNgay)='" + th + "' and YEAR(dNgay)='" + nam + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
