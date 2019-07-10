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
    public partial class fQL_TiecCuoi : Form
    {
        public fQL_TiecCuoi()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void fQL_TiecCuoi_Load(object sender, EventArgs e)
        {
            tmThoiGian.Start();
            tmNgay.Start();
        }

        private void tmThoiGian_Tick(object sender, EventArgs e)
        {
            lbThoiGian.Text = DateTime.Now.ToLongTimeString();
        }

        private void tmNgay_Tick(object sender, EventArgs e)
        {
            lbNgay.Text = DateTime.Now.ToShortDateString();
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            FHoaDon f = new FHoaDon();
            f.ShowDialog();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            FTraCuu f = new FTraCuu();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FBCDoanhThu f = new FBCDoanhThu();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fThemSanh f = new fThemSanh();
            f.ShowDialog();
        }
    }
}
