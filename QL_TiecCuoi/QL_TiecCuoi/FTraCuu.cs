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
    public partial class FTraCuu : Form
    {
        public FTraCuu()
        {
            InitializeComponent();
            LoadTraCuu();
            
        }
        public void LoadTraCuu()
        {
            dtgvTraCuu.DataSource = TraCuuDAO.Instance.LoadTT();
            DatTen();

        }

        public void LoadTraCuuTheoTen()
        {
            dtgvTraCuu.DataSource = TraCuuDAO.Instance.TimKiemTheoTen(txtTraCuu.Text);
        }
        public void DatTen()
        {
            dtgvTraCuu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvTraCuu.Columns[0].HeaderText = "Mã TC";
            dtgvTraCuu.Columns[0].Width = 30;
            dtgvTraCuu.Columns[0].Frozen = true;

            dtgvTraCuu.Columns[1].HeaderText = "Chú rễ";
            dtgvTraCuu.Columns[1].Width = 110;

            dtgvTraCuu.Columns[2].HeaderText = "Cô dâu";
            dtgvTraCuu.Columns[2].Width = 110;

            dtgvTraCuu.Columns[3].HeaderText = "Ngày đặt tiệc";
            dtgvTraCuu.Columns[3].Width = 75;

            dtgvTraCuu.Columns[4].HeaderText = "Ngày đãi tiệc";
            dtgvTraCuu.Columns[4].Width = 75;

            dtgvTraCuu.Columns[5].HeaderText = "ĐT";
            dtgvTraCuu.Columns[5].Width = 75;

            dtgvTraCuu.Columns[6].HeaderText = "Ca";
            dtgvTraCuu.Columns[6].Width = 30;

            dtgvTraCuu.Columns[7].HeaderText = "Đặt cọc";
            dtgvTraCuu.Columns[7].Width = 100;

            dtgvTraCuu.Columns[8].HeaderText = "SL bàn";
            dtgvTraCuu.Columns[8].Width = 50;

            dtgvTraCuu.Columns[9].HeaderText = "Bàn DT";
            dtgvTraCuu.Columns[9].Width = 30;

            dtgvTraCuu.Columns[10].HeaderText = "Sảnh";
            dtgvTraCuu.Columns[10].Width = 50;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadTraCuu();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (cbbTK.Text == "Tên chú rễ")
            {
                dtgvTraCuu.DataSource = TraCuuDAO.Instance.TimKiemTheoTen(txtTraCuu.Text);
            }
            if (cbbTK.Text == "Tên cô dâu")
            {
                dtgvTraCuu.DataSource = TraCuuDAO.Instance.TimKiemTheoTenCD(txtTraCuu.Text);
            }
            if (cbbTK.Text == "Số điện thoại")
            {
                dtgvTraCuu.DataSource = TraCuuDAO.Instance.TimKiemTheoSDT(txtTraCuu.Text);
            }
            if(cbbTK.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin để tìm kiếm!!!!");
            }
        }
    }
}
