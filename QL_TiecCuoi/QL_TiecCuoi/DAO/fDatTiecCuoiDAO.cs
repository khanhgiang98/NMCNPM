using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QL_TiecCuoi.DAO
{
    class DatTiecCuoiDAO
    {
        private DatTiecCuoiDAO() { }

        private static DatTiecCuoiDAO instance;

        public static DatTiecCuoiDAO Instance
        {
            get
            {
                if (instance == null) instance = new DatTiecCuoiDAO(); return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public string LayDonGiaMonAn(string MaMonAn)
        {
            string query = "select mDonGia from MON_AN where sMaMonAn = '" + MaMonAn + "'";
            return DataProvider.Instance.ExecuteReader(query);
        }

        public string LayDonGiaDichVu(string MaDichVu)
        {
            string query = "select mDonGia from DICH_VU where sMaDichVu = '" + MaDichVu + "'";
            return DataProvider.Instance.ExecuteReader(query);
        }

        public string LaySoBanToiDa(string MaSanh)
        {
            string query = "select iSoLuongBanToiDa from DANH_SACH_SANH where sMaSanh ='" + MaSanh + "'";
            return DataProvider.Instance.ExecuteReader(query);
        }

        public string LayMaLoaiSanh(string MaSanh)
        {
            string query = "select sMaLoaiSanh from DANH_SACH_SANH where sMaSanh = '" + MaSanh + "'";
            return DataProvider.Instance.ExecuteReader(query);
        }

        public string LayDonGiaBanToiThieu(string MaLoaiSanh)
        {
            string query = "select mDonGiaBanTT from LOAI_SANH where sMaLoaiSanh ='" + MaLoaiSanh + "'";
            return DataProvider.Instance.ExecuteReader(query);
        }

        public string LayTenMonAn(string MaMonAn)
        {
            string query = "select sTenMonAn from MON_AN where sMaMonAn = '" + MaMonAn + "'";
            return DataProvider.Instance.ExecuteReader(query);
        }

        public string LayTenDichVu(string MaDichVu)
        {
            string query = "select sTenDichVu from DICH_VU where sMaDichVu = '" + MaDichVu + "'";
            return DataProvider.Instance.ExecuteReader(query);
        }

        public List<string> LayDSLoaiSanh()
        {
            string query = "select sMaLoaiSanh from LOAI_SANH where sTenLoaiSanh <> ''";
            return DataProvider.Instance.ExecuteReaderListString(query);
        }

        public List<string> LayDSCa()
        {
            string query = "select sMaCa from CA where sTenCa <> ''";
            return DataProvider.Instance.ExecuteReaderListString(query);
        }
        public List<string> LayDSMaMonAn()
        {
            string query = "select sMaMonAn from MON_AN where sTenMonAn <> ''";
            return DataProvider.Instance.ExecuteReaderListString(query);
        }

        public List<string> LayDSMaDichVu()
        {
            string query = "select sMaDichVu from DICH_VU where sTenDichVu <> ''";
            return DataProvider.Instance.ExecuteReaderListString(query);
        }

        public string ThemTiecCuoi(string MaTC, string TenCR, string TenCD, string SDT, string NgayDaiTiec, string NgayDatTiec, string MaSanh, string MaCa, string TienDC, string SLB, string SLBDT)
        {
            string query = "INSERT INTO TIEC_CUOI VALUES('" + MaTC + "','" + NgayDatTiec + "','" + TenCR + "','" + TenCD + "','" + SDT + "','" + NgayDaiTiec + "','" + MaCa + "','" + MaSanh + "','" + TienDC + "','" + SLB + "','" + SLBDT + "')";
            return DataProvider.Instance.ExecuteReader(query);
        }

        public string ThemMon(string MaTC, string MaMonAn, string DonGia, string GhiChu)
        {
            string query = "INSERT INTO DAT_MON VALUES ('" + MaTC + "','" + MaMonAn + "','" + DonGia + "','" + GhiChu + "')";
            return DataProvider.Instance.ExecuteReader(query);
        }

        public string ThemDichVu(string MaTc, string MaDichVu, string DonGia, string SoLuong)
        {
            string query = "INSERT INTO DAT_DICH_VU VALUES ('" + MaTc + "','" + MaDichVu + "','" + SoLuong + "','" + DonGia + "')";
            return DataProvider.Instance.ExecuteReader(query);
        }
    }
}