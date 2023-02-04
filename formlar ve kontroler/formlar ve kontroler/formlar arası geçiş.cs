using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formlar_ve_kontroler
{
    public partial class formlar_arası_geçiş : Form
    {
        public formlar_arası_geçiş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
