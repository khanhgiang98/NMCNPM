using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QL_TiecCuoi.DAO
{
    class ThongTinSanhDAO
    {
        private ThongTinSanhDAO() { }

        private static ThongTinSanhDAO instance;

        public static ThongTinSanhDAO Instance
        {
            get
            {
                if (instance == null) instance = new ThongTinSanhDAO(); return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public DataTable LoaddsSanh()
        {
            string query = "select * from DANH_SACH_SANH";
            return DataProvider.Instance.ExecuteQuery(query);
        }


        public List<string> LayDSLoaiSanh()
        {
            string query = "select sMaLoaiSanh from LOAI_SANH where sTenLoaiSanh <> ''";
            return DataProvider.Instance.ExecuteReaderListString(query);
        }

        public string ThemSanh(string MaSanh,string TenSanh, string LoaiSanh, string SLBTD, string GhiChu)
        {
            string query = "INSERT INTO DANH_SACH_SANH VALUES('" + MaSanh + "','" + TenSanh + "','" + LoaiSanh + "','" + SLBTD +"','" + GhiChu + "')";
            return DataProvider.Instance.ExecuteReader(query);
        }

        public string SuaSanh(string MaSanh, string TenSanh, string LoaiSanh, string SLBTD, string GhiChu)
        {
            string query = "UPDATE DANH_SACH_SANH SET sTenSanh ='" + TenSanh + "',sMaLoaiSanh ='" + LoaiSanh + "',iSoLuongBanToiDa ='" + SLBTD + "',sGhiChu ='" + GhiChu + "' where sMaSanh ='" + MaSanh +"'";
            return DataProvider.Instance.ExecuteReader(query);
        }

    }
}