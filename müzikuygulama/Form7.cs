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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-VH5HU6EO;Initial Catalog=prolab3;Integrated Security=True");
       
        private void label2_Click(object sender, EventArgs e)
        {

        }
       
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "False";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Table_Kullanici where KullaniciAdi=@p1 and KullaniciSifre=@p2 and KullaniciAbonelikturu=@p3", baglanti);
            
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", label5.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (label5.Text == "True")
                {
                    Form10 premiumEkran = new Form10();
                    premiumEkran.isim = textBox1.Text;
                    premiumEkran.Show();
                    this.Hide();
                }
                else
                {
                    
                    Form8 kullaniciEkran = new Form8();
                    kullaniciEkran.isim = textBox1.Text;
                    kullaniciEkran.Show();
                    this.Hide();

                }
            }
            
            else
            {
                MessageBox.Show("Kullanıcı Mail, Şifre ya da Abonelik Türü Hatalı");
            }
            baglanti.Close();
            

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            label5.Text = "True";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
