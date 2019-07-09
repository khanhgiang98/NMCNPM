using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TiecCuoi.DAO
{
    class HoaDonDAO
    {
        private HoaDonDAO() { }

        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null) instance = new HoaDonDAO(); return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public DataTable LoaddsHD()
        {
            string query = "select sMaTiecCuoi,dNgayThanhToan,mTongTienBan,mTTDichVu,TinhTrang,sNguoiLap,dNgayThanhToan from HOA_DON ";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public List<string> LayDSMaTC()
        {
            string query = "select sMaTiecCuoi from  TIEC_CUOI ";
            return DataProvider.Instance.ExecuteReaderListString(query);
        }
        public string layTenCoDau(string matc)
        {
            string query = "select sTenCoDau from  TIEC_CUOI  where  sMaTiecCuoi='"+matc+"'";
            return DataProvider.Instance.ExecuteReader(query);
        }
        public string layTenChuRe (string matc)
        {
            string query = "select sTenChuRe from  TIEC_CUOI  where sMaTiecCuoi='" + matc + "'";
            return DataProvider.Instance.ExecuteReader(query);
        }
        public string layTHD(string matc)
        {
            string query = "select a.mTTHoaDon from HOA_DON a, TIEC_CUOI b where a.sMaTiecCuoi=b.sMaTiecCuoi and a.sMaTiecCuoi='" + matc + "'";
            return DataProvider.Instance.ExecuteReader(query);
        }
        public string ThemHD(string matc, string nguoilap, string ngaythanhtoan)
        {
            string query = "INSERT INTO HOA_DON(sMaTiecCuoi,sNguoiLap,dNgayThanhToan) VALUES('" + matc + "','" + nguoilap + "','" + ngaythanhtoan + "')";
            return DataProvider.Instance.ExecuteReader(query);
        }
        public string XoaHD(string matc)
        {
            string query = "DELETE FROM HOA_DON WHERE sMaTiecCuoi='" + matc + "'";
            return DataProvider.Instance.ExecuteReader(query);
        }
        public string updateTT(string matc, string ngaytt)
        {
            string query = "UPDATE HOA_DON SET TinhTrang='0', dNgayThanhToan='"+ngaytt+"' Where sMaTiecCuoi='" + matc + "'";
            return DataProvider.Instance.ExecuteReader(query);
        }
    }
}
