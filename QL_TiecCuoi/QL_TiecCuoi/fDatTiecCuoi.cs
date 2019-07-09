using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            lbNgay.Text = DateTime.Now.ToLongDateString();
        }

        private void fDatTiecCuoi_Load(object sender, EventArgs e)
        {
            tmNgay.Start();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbTrangChu_Click(object sender, EventArgs e)
        {

        }
    }
}
