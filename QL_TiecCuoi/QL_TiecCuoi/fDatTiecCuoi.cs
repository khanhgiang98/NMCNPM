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
            btDatTiec.Enabled = false;
            tmNgay.Start();
            LayDSLoaiSanh();
            LayDSCa();
            LayDSMaMonAN();
            LayDSMaDichVu();
        }

        private void txbTenChuRe_TextChanged(object sender, EventArgs e)
        {
            btDatTiec.Enabled = true;
        }


        public bool KiemTraSLBan()
        {
            string SLBanToiDa = DatTiecCuoiDAO.Instance.LaySoBanToiDa(cbbSanh.Text);
            int SLBanTD = Convert.ToInt32(SLBanToiDa);
            int SLBan = Convert.ToInt32(txbSoLuongBan.Text);
            int SLBanDT = Convert.ToInt32(txbSoLuonngBanDuTru.Text);
            if (SLBanTD < (SLBan + SLBanDT))
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

            MessageBox.Show(TongTienMonAn.ToString());

            if (TongTienMonAn > DGBanTT)
                return true;
            else
                return false;
        }

        public void LayDSLoaiSanh()
        {
            cbbSanh.DataSource = DatTiecCuoiDAO.Instance.LayDSLoaiSanh();
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

                    for (int i = 0; i < DGV_DatMon.Rows.Count - 1; i++)
                    {
                        DatTiecCuoiDAO.Instance.ThemMon(txbMaTiecCuoi.Text,DGV_DatMon.Rows[i].Cells[0].Value.ToString(), DGV_DatMon.Rows[i].Cells[2].Value.ToString(), DGV_DatMon.Rows[i].Cells[3].Value.ToString());
                    }

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        DatTiecCuoiDAO.Instance.ThemDichVu(txbMaTiecCuoi.Text,dataGridView1.Rows[i].Cells[0].Value.ToString(), dataGridView1.Rows[i].Cells[3].Value.ToString(), dataGridView1.Rows[i].Cells[2].Value.ToString());
                    }

                    MessageBox.Show("Thêm Thành Công!!!");
                    txbMaTiecCuoi.Clear();
                    txbTenChuRe.Clear();
                    txbTenCoDau.Clear();
                    txbSoDienThoai.Clear();
                    txbTienDatCoc.Clear();
                    txbSoLuongBan.Clear();
                    txbSoLuonngBanDuTru.Clear();
                    DGV_DatMon.ClearSelection();
                    dataGridView1.ClearSelection();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi dữ liệu!!!");
                }
            }
        }
    }
}
