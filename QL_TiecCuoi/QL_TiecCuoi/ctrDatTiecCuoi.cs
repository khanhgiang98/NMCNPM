using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TiecCuoi
{
    public partial class ctrDatTiecCuoi : UserControl
    {
        public ctrDatTiecCuoi()
        {
            InitializeComponent();
        }

        private void tmNgay_DTC_Tick(object sender, EventArgs e)
        {
            lbNgay.Text = DateTime.Now.ToLongDateString();
        }

        private void ctrDatTiecCuoi_Load(object sender, EventArgs e)
        {
            tmNgay_DTC.Start();
        }

        private void lbNgay_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
