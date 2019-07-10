using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_TiecCuoi.DAO;

namespace QL_TiecCuoi
{
    public partial class FBCDoanhThu : Form
    {
        public FBCDoanhThu()
        {
            InitializeComponent();
        }
        public void loadBC()
        {
            dtgvBC.DataSource = BaoCaoDAO.Instance.loadBC(cbbThang.Text, txtNam.Text);
            double tong = 0;
            for (int i = 0; i < dtgvBC.Rows.Count - 1; i++)
            {
                tong += Double.Parse(dtgvBC.Rows[i].Cells[3].Value.ToString());
            }
            txtDoanhThu.Text = tong.ToString();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (txtNam.Text == "")
                MessageBox.Show("Vui lòng nhập năm");
            else if (IsNumber(txtNam.Text) == false)
                MessageBox.Show("Năm phải là số nguyên");
     
            else
                loadBC();
        }
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        public bool IsNumber1(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0 - 9] *\.?[0 - 9] +$");
            return regex.IsMatch(pText);
        }

        private void dtgvBC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FHoaDon f = new FHoaDon();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
