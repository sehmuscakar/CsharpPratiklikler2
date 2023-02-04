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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1(); // nesne oluşturduk 
            frm1.Show();

            this.Visible = false;
            Form1 frm3 = new Form1();
            frm3.Visible = true;
        }
    }
}
