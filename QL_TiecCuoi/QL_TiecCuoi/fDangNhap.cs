using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_TiecCuoi
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        DAO.DataProvider conn = new DAO.DataProvider();

        private void fDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
            {
                Application.Exit();
            }  
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string cmd = "select * from TAI_KHOAN where sTenDangNhap = '" + txbDangNhap.Text + "' and sMatKhau = '" + txbMatKhau.Text + "'";
            SqlDataReader dr = conn.getDataReader(cmd);
            if (dr.Read() == false)
            {
                panel2.BackColor = Color.Red;
                MessageBox.Show("Vui lòng nhập đúng Tên Đăng Nhập và Mật Khẩu!");
            }
            else
            {
                panel2.BackColor = Color.Empty;
                fQL_TiecCuoi f = new fQL_TiecCuoi();
                txbDangNhap.Text= "";
                txbMatKhau.Text = "";
                this.Hide();
                f.ShowDialog();
            }
        }

    }
}
