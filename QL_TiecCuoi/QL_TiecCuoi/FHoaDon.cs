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
    public partial class FHoaDon : Form
    {
        public FHoaDon()
        {
            InitializeComponent();
            LayDSMaTC();
            loadHD();
            
            
            
        }
        public void loadHD()
        {
            
            dtgvHD.DataSource = HoaDonDAO.Instance.LoaddsHD();
            DatTen();
        }

        private void cbbMaTiec_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayTenCD();
            LayTenCR();
        }
        public void LayDSMaTC()
        {
            cbbMaTiec.DataSource = HoaDonDAO.Instance.LayDSMaTC();
        }
        public void LayTenCD()
        {
            txtTenCD.Text = HoaDonDAO.Instance.layTenCoDau(cbbMaTiec.Text);
        }
        public void LayTenCR()
        {
            txtTCR.Text = HoaDonDAO.Instance.layTenChuRe(cbbMaTiec.Text);
        }
        string day = DateTime.Now.Day.ToString();
        string month = DateTime.Now.Month.ToString();
        string year = DateTime.Now.Year.ToString();

        private void dtgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dtgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            cbbMaTiec.Text = dtgvHD.Rows[row].Cells[0].Value.ToString();
            if((dtgvHD.Rows[row].Cells[4].Value.ToString())=="1")
            {
                txtTinhTrang.Text = "Chưa thanh toán";
            }
            else
            {
                txtTinhTrang.Text = "Đã thanh toán";
            }
            txtTT.Text = HoaDonDAO.Instance.layTHD(cbbMaTiec.Text);
            txtNgaytt.Text= dtgvHD.Rows[row].Cells[6].Value.ToString();

        }

        public void DatTen()
        {
            dtgvHD.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvHD.Columns[0].HeaderText = "Mã TC";
            dtgvHD.Columns[0].Width = 30;
            dtgvHD.Columns[0].Frozen = true;

            dtgvHD.Columns[1].HeaderText = "Ngày lập";
            dtgvHD.Columns[1].Width = 75;

            dtgvHD.Columns[2].HeaderText = "Tiền bàn";
            dtgvHD.Columns[2].Width = 100;

            dtgvHD.Columns[3].HeaderText = "Tiền dịch vụ";
            dtgvHD.Columns[3].Width = 110;

            dtgvHD.Columns[4].HeaderText = "TT";
            dtgvHD.Columns[4].Width = 30;

            dtgvHD.Columns[5].HeaderText = "Người lập";
            dtgvHD.Columns[5].Width = 75;

            dtgvHD.Columns[6].HeaderText = "Ngày thanh toán";
            dtgvHD.Columns[6].Width = 100;
        }

       
        private void btnThemhd_Click(object sender, EventArgs e)
        {

            try
            {
                HoaDonDAO.Instance.ThemHD(cbbMaTiec.Text, txtNL.Text,day+"/"+month+"/"+year );
                loadHD();
                
            }
            catch ( Exception )
            {
                MessageBox.Show("Đã có trong danh sách hóa đơn không thể thêm nữa!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTinhTrang.Text=="Chưa thanh toán")
                {
                    DialogResult dlr = MessageBox.Show("Hóa đơn này chưa thanh toán bạn có muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(dlr==DialogResult.Yes)
                    {
                        HoaDonDAO.Instance.XoaHD(cbbMaTiec.Text);
                        loadHD();
                    }
                }
                else if(txtTinhTrang.Text=="Đã thanh toán")
                {
                    MessageBox.Show("Hóa đơn đã thanh toán không thể xóa!");
                }
            }catch(Exception)
            {
                MessageBox.Show("Lỗi dữ liệu!");
            }
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTinhTrang.Text=="Đã thanh toán")
                {
                    MessageBox.Show("Hóa đơn này đã thanh toán rồi!!");
                }
                else if(txtTinhTrang.Text=="Chưa thanh toán")
                {
                    DialogResult dlr = MessageBox.Show("Bạn muốn thanh toán hóa đơn này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        HoaDonDAO.Instance.updateTT(cbbMaTiec.Text,txtNgaytt.Text);
                        loadHD();
                    }    
                }
            }catch(Exception)
            {
                MessageBox.Show("Lỗi dữ liệu!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadHD();
        }
    }
}
