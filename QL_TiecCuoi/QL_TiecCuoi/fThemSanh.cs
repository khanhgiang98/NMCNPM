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
    public partial class fThemSanh : Form
    {
        public fThemSanh()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fThemSanh_Load(object sender, EventArgs e)
        {
            LoaddsSanh();
            btnThemSanh.Enabled = false;
            btnSuaSanh.Enabled = false;
            DatTen();
        }

        public void DatTen()
        {
            dgvThongTinSanh.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvThongTinSanh.Columns[0].HeaderText = "Mã Sảnh";
            dgvThongTinSanh.Columns[0].Name = "sMaSanh";
            dgvThongTinSanh.Columns[0].Width = 60;
            dgvThongTinSanh.Columns[0].Frozen = true;

            dgvThongTinSanh.Columns[1].HeaderText = "Tên Sảnh";
            dgvThongTinSanh.Columns[1].Name = "sTenSanh";
            dgvThongTinSanh.Columns[1].Width = 140;

            dgvThongTinSanh.Columns[2].HeaderText = "Loại Sảnh";
            dgvThongTinSanh.Columns[2].Name = "sLoaiSanh";
            dgvThongTinSanh.Columns[2].Width = 60;

            dgvThongTinSanh.Columns[3].HeaderText = "Số Lượng Bàn Tối Đa";
            dgvThongTinSanh.Columns[3].Name = "iSLBanToiDa";
            dgvThongTinSanh.Columns[3].Width = 60;

            dgvThongTinSanh.Columns[4].HeaderText = "Ghi Chú";
            dgvThongTinSanh.Columns[4].Name = "sGhiChu";
            dgvThongTinSanh.Columns[4].Width = 180;
        }
        public void LoaddsSanh()
        {
            dgvThongTinSanh.DataSource = ThongTinSanhDAO.Instance.LoaddsSanh();
        }
        public void LayDSLoaiSanh()
        {
            cbbLoaiSanh.DataSource = ThongTinSanhDAO.Instance.LayDSLoaiSanh();
        }

        private void cbbTenSanh_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

     
        private void dgvThongTinSanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaSanh.Text = dgvThongTinSanh.Rows[e.RowIndex].Cells["sMaSanh"].Value.ToString();
            txbTenSanh.Text = dgvThongTinSanh.Rows[e.RowIndex].Cells["sTenSanh"].Value.ToString();
            cbbLoaiSanh.Text = dgvThongTinSanh.Rows[e.RowIndex].Cells["sLoaiSanh"].Value.ToString();
            txbSLBanTD.Text = dgvThongTinSanh.Rows[e.RowIndex].Cells["iSLBanToiDa"].Value.ToString();
            txbGhiChu.Text = dgvThongTinSanh.Rows[e.RowIndex].Cells["sGhiChu"].Value.ToString();
            txbMaSanh.Enabled = false;
            btnThemSanh.Enabled = false;
            btnSuaSanh.Enabled = true;
        }

        private void txbLoaiSanh_TextChanged(object sender, EventArgs e)
        {
            
        }
       
        private void btnThemSanh_Click(object sender, EventArgs e)
        {
            try
            {
                ThongTinSanhDAO.Instance.ThemSanh(txbMaSanh.Text,txbTenSanh.Text,cbbLoaiSanh.Text,txbSLBanTD.Text,txbGhiChu.Text);
                MessageBox.Show("Thêm thành công!");
                LoaddsSanh();
                txbMaSanh.Text = "";
                txbTenSanh.Text = "";
                cbbLoaiSanh.Text = "";
                txbSLBanTD.Text = "";
                txbGhiChu.Text = "";
                txbMaSanh.Enabled = true;
                btnThemSanh.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi dữ liệu!!");
            }
        }

        private void txbMaSanh_TextChanged(object sender, EventArgs e)
        {
            btnThemSanh.Enabled = true;
            LayDSLoaiSanh();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaSanh_Click(object sender, EventArgs e)
        {
            try
            {
                ThongTinSanhDAO.Instance.SuaSanh(txbMaSanh.Text, txbTenSanh.Text, cbbLoaiSanh.Text, txbSLBanTD.Text, txbGhiChu.Text);
                MessageBox.Show("Thêm thành công!");
                LoaddsSanh();
                txbMaSanh.Text = "";
                txbTenSanh.Text = "";
                cbbLoaiSanh.Text = "";
                txbSLBanTD.Text = "";
                txbGhiChu.Text = "";
                txbMaSanh.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi dữ liệu!!");
            }
            

        }
    }
}
