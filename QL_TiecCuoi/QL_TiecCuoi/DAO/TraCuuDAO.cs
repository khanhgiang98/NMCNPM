using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TiecCuoi.DAO
{
    class TraCuuDAO
    {
        private TraCuuDAO() { }
        private static TraCuuDAO instance;
        public static TraCuuDAO Instance
        {
            get
            {
                if (instance == null) instance = new TraCuuDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        public DataTable LoadTT()
        {
            string query = "select b.sMaTiecCuoi, sTenChuRe,sTenCoDau,dNgayDatTiec,dNgayDaiTiec,sDienThoai,a.sTenca,mTienDatCoc,iSLBan,iSoBanDuTru, c.sTenSanh from CA a, TIEC_CUOI b, DANH_SACH_SANH c where a.sMaCa = b.sMaCa and c.sMaSanh = b.sMaSanh";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable TimKiemTheoTen(string ten)
        {
            string query = "select b.sMaTiecCuoi, sTenChuRe,sTenCoDau,dNgayDatTiec,dNgayDaiTiec,sDienThoai,a.sTenca,mTienDatCoc,iSLBan,iSoBanDuTru, c.sTenSanh from CA a, TIEC_CUOI b, DANH_SACH_SANH c where a.sMaCa = b.sMaCa and c.sMaSanh = b.sMaSanh and  sTenChuRe='" + ten + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable TimKiemTheoTenCD(string ten)
        {
            string query = "select b.sMaTiecCuoi, sTenChuRe,sTenCoDau,dNgayDatTiec,dNgayDaiTiec,sDienThoai,a.sTenca,mTienDatCoc,iSLBan,iSoBanDuTru, c.sTenSanh from CA a, TIEC_CUOI b, DANH_SACH_SANH c where a.sMaCa = b.sMaCa and c.sMaSanh = b.sMaSanh and  sTenCoDau='" + ten + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable TimKiemTheoSDT(string dt)
        {
            string query = "select b.sMaTiecCuoi, sTenChuRe,sTenCoDau,dNgayDatTiec,dNgayDaiTiec,sDienThoai,a.sTenca,mTienDatCoc,iSLBan,iSoBanDuTru, c.sTenSanh from CA a, TIEC_CUOI b, DANH_SACH_SANH c where a.sMaCa = b.sMaCa and c.sMaSanh = b.sMaSanh and  sDienThoai='" + dt + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
