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
    public partial class formlar : Form
    {
        public formlar()
        {
            InitializeComponent();
        }

        private void formlar_Load(object sender, EventArgs e)
        {
            this.Text = " yeni form";
        }
    }
}
