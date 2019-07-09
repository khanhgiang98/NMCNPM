using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TiecCuoi.DAO
{
    class AccountDAO
    {
        private AccountDAO() { }

        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO(); return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public bool DangNhap(string tk, string mk)
        {
            
            string query = "select * from TAI_KHOAN where sTenDangNhap ='" + tk + "' and sMatKhau='" + mk + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        
    }
}
