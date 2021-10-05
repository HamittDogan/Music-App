using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace müzikuygulama
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-VH5HU6EO;Initial Catalog=prolab3;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "True";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "False";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Table_Kullanici (KullaniciAdi,KullaniciMail,KullaniciSifre,KullaniciAbonelikturu,KullaniciUlke) values (@p1,@p2,@p3,@p4,@p5)", baglanti);

            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", textBox3.Text);
            komut.Parameters.AddWithValue("@p4", label6.Text);
            komut.Parameters.AddWithValue("@p5", textBox4.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Oldunuz");
            this.Hide();
            baglanti.Close();
        }
    }
}
