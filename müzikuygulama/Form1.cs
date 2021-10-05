using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace müzikuygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 kayitol = new Form2();
            kayitol.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 admin = new Form9();
            admin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 kullaniciGiris = new Form7();
            kullaniciGiris.Show();
        }
    }
}
