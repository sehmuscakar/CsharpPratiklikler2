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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // formun bazı özelikleri vardır 
            //Name:nesnenin kodlama yapısı içerisinde kulanılacak olan isimidir 
            //text:nesnenin kulanıcı tarafında gürüntülenecek olan ismidir 
            //backcolor:zemin rengini belirler
            //enabled:nesnenin aktif veya pasif olacağını belirler
            // font : yazı tipi özeliklerini belirler
            //visible:nesneyi görünür yada gürünmez yapar 
            // location :nesnenin konumunu belirler 
            //size:nesnenin boyutunu belirler

            button1.Text = "Mesaj";// bunu ayarladan değilde kod olarak değiştirdik 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();// nesne oluşturduk 
            frm2.Show();

            this.Visible = false;
            Form2 frm3 = new Form2();
            frm3.Visible = true;
        }
    }
}
