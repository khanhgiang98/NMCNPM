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
using System.Data.SqlClient;

namespace QL_TiecCuoi
{
    public partial class FLogin : Form
    {
        
        public FLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtTK.Text;
            string passWord = txtMK.Text;
            if(DangNhap(userName,passWord))
            {
                fQL_TiecCuoi f = new fQL_TiecCuoi();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!!");
            }
        }
        bool DangNhap(string userName, string passWord)
        {
            return AccountDAO.Instance.DangNhap(userName, passWord);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
