using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_TiecCuoi.DAO;

namespace QL_TiecCuoi
{
    public partial class fDatTiecCuoi : Form
    {
        public fDatTiecCuoi()
        {
            InitializeComponent();
        }

        private void lbTenCoDau_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tmNgay_Tick(object sender, EventArgs e)
        {
            lbNgay.Text = DateTime.Now.ToShortDateString();
        }

        private void fDatTiecCuoi_Load(object sender, EventArgs e)
        {
            txbSoLuongBan.Text = "0";
            txbSoLuonngBanDuTru.Text = "0";
            btDatTiec.Enabled = false;
            tmNgay.Start();
            LayDSSanh();
            LayDSCa();
            LayDSMaMonAN();
            LayDSMaDichVu();
        }

        private void txbTenChuRe_TextChanged(object sender, EventArgs e)
        {
            
        }


        public bool KiemTraSLBan()
        {
            string SLBanToiDa = DatTiecCuoiDAO.Instance.LaySoBanToiDa(cbbSanh.Text);
            int SLBanTD = Convert.ToInt32(SLBanToiDa);
            int SLBan = Convert.ToInt32(txbSoLuongBan.Text);
            int SLBanDT = Convert.ToInt32(txbSoLuonngBanDuTru.Text);
            if ((SLBanTD < (SLBan + SLBanDT))&&(SLBan + SLBanDT > 0))
            {
                return false;
            }

            else return true;
        }

        public bool KiemTraTongBan()
        {
            string DGBanToiThieu = DatTiecCuoiDAO.Instance.LayDonGiaBanToiThieu(DatTiecCuoiDAO.Instance.LayMaLoaiSanh(cbbSanh.Text));
            double DGBanTT = Convert.ToDouble(DGBanToiThieu);
            double TongTienMonAn= 0.0;
            for (int i = 0; i < DGV_DatMon.Rows.Count - 1; i++)
            {
                TongTienMonAn += Convert.ToDouble(DGV_DatMon.Rows[i].Cells[2].Value.ToString());
            }

            //MessageBox.Show(TongTienMonAn.ToString());

            if (TongTienMonAn > DGBanTT)
                return true;
            else
                return false;
        }

        public void LayDSSanh()
        {
            cbbSanh.DataSource = DatTiecCuoiDAO.Instance.LayDSSanh();
        }

        public void LayDSCa()
        {
            cbbCa.DataSource = DatTiecCuoiDAO.Instance.LayDSCa();
        }

        public void LayDSMaMonAN()
        {
            dgv_maMaMonAn.DataSource = DatTiecCuoiDAO.Instance.LayDSMaMonAn();
        }

        public void LayDSMaDichVu()
        {
            dgv_dvMaDichVu.DataSource = DatTiecCuoiDAO.Instance.LayDSMaDichVu();
        }

        private void DGV_DatMon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //--------------------------------------
        public string LayTenMonAn(string MaMonAn)
        {
            return DatTiecCuoiDAO.Instance.LayTenMonAn(MaMonAn);
        }

        public string LayDonGiaMonAn(string MaMonAn)
        {
            return DatTiecCuoiDAO.Instance.LayDonGiaMonAn(MaMonAn);
        }
        private void grvcmbProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmbprocess = (ComboBox)sender;
            if (cmbprocess.SelectedValue != null)
            {
                //MessageBox.Show(cmbprocess.SelectedValue.ToString());
                DGV_DatMon.CurrentRow.Cells[1].Value = LayTenMonAn(cmbprocess.SelectedValue.ToString());
                DGV_DatMon.CurrentRow.Cells[2].Value = LayDonGiaMonAn(cmbprocess.SelectedValue.ToString());
            }

        }

        private void DGV_DatMon_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (DGV_DatMon.Columns[DGV_DatMon.CurrentCell.ColumnIndex].Name.Equals("dgv_maMaMonAn"))
            {
                ComboBox cmbprocess = e.Control as ComboBox;
                cmbprocess.SelectedIndexChanged += new EventHandler(grvcmbProcess_SelectedIndexChanged);
            }
        }

        //---------------------------------

        public string LayTenDichVu(string MaDichVu)
        {
            return DatTiecCuoiDAO.Instance.LayTenDichVu(MaDichVu);
        }

        public string LayDonGiaDichVu(string MaDichVu)
        {
            return DatTiecCuoiDAO.Instance.LayDonGiaDichVu(MaDichVu);
        }

        private void grvcmbProcess1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmbprocess = (ComboBox)sender;
            if (cmbprocess.SelectedValue != null)
            {
                //MessageBox.Show(cmbprocess.SelectedValue.ToString());
                dataGridView1.CurrentRow.Cells[1].Value = LayTenDichVu(cmbprocess.SelectedValue.ToString());
                dataGridView1.CurrentRow.Cells[3].Value = LayDonGiaDichVu(cmbprocess.SelectedValue.ToString());
            }

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name.Equals("dgv_dvMaDichVu"))
            {
                ComboBox cmbprocess = e.Control as ComboBox;
                cmbprocess.SelectedIndexChanged += new EventHandler(grvcmbProcess1_SelectedIndexChanged);
            }
        }

        private void btDatTiec_Click(object sender, EventArgs e)
        {
            if (KiemTraSLBan() == false)
            {
                MessageBox.Show("Số lượng bàn lớn hơn qui định!!!");
            }
            else if (KiemTraTongBan() == false)
            {
                MessageBox.Show("Tổng tiền bàn nhỏ hơn qui định!!! Mời đặt thêm món!!! :))");
            }
            else
            {
                try
                {
                    DatTiecCuoiDAO.Instance.ThemTiecCuoi(txbMaTiecCuoi.Text, txbTenChuRe.Text, txbTenCoDau.Text, txbSoDienThoai.Text, dtNgayDaiTiec.Value.ToShortDateString(), lbNgay.Text, cbbSanh.Text, cbbCa.Text, txbTienDatCoc.Text, txbSoLuongBan.Text, txbSoLuonngBanDuTru.Text);
                    MessageBox.Show("Thêm Tiệc Cưới Thành Công!!!");
                    txbMaTiecCuoi.Clear();
                    txbTenChuRe.Clear();
                    txbTenCoDau.Clear();
                    txbSoDienThoai.Clear();
                    txbTienDatCoc.Clear();
                    txbSoLuongBan.Clear();
                    txbSoLuonngBanDuTru.Clear();
                    DGV_DatMon.DataSource = "";
                    dataGridView1.DataSource = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi dữ liệu Tiệc Cưới!!!");
                }
                //-----------------------------------
                try
                {
                    for (int i = 0; i < DGV_DatMon.Rows.Count - 1; i++)
                    {
                        string MaMA = DGV_DatMon.Rows[i].Cells["dgv_maMaMonAn"].Value.ToString();
                        long DG = Convert.ToInt64(DGV_DatMon.Rows[i].Cells["dgv_maDonGia"].Value.ToString());
                        string GC = DGV_DatMon.Rows[i].Cells["dgv_maGhiChu"].Value.ToString();
                        DatTiecCuoiDAO.Instance.ThemMon(txbMaTiecCuoi.Text, MaMA, DG.ToString(), GC);
                    }
                    MessageBox.Show("Thêm Đặt Món thành công!!!");
                    DGV_DatMon.DataSource = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi dữ liệu Đặt Món!!!");
                }
                //-----------------------------------
                try
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        string MaDV = dataGridView1.Rows[i].Cells["dgv_dvMaDichVu"].Value.ToString();
                        string SL = dataGridView1.Rows[i].Cells["dgv_dvSoLuong"].Value.ToString();
                        long DG = Convert.ToInt64(dataGridView1.Rows[i].Cells["dgv_dvDonGia"].Value.ToString());
                        DatTiecCuoiDAO.Instance.ThemDichVu(txbMaTiecCuoi.Text, MaDV, SL, DG.ToString());
                    }
                    MessageBox.Show("Thêm Đặt Dịch Vụ thành công!!!");
                    dataGridView1.DataSource = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi dữ liệu Đặt Dịch Vụ!!!");
                }
            }
        }

        private void txbMaTiecCuoi_TextChanged(object sender, EventArgs e)
        {
            btDatTiec.Enabled = true;
        }
    }
}
