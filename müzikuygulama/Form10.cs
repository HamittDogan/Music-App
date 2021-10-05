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
    public partial class Form10 : Form
    {
        public String isim { get; set; }
       
        public Form10()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-VH5HU6EO;Initial Catalog=prolab3;Integrated Security=True");
        private void Form10_Load(object sender, EventArgs e)
        {
            label1.Text = isim;
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select SarkiAdi from Table_Sarki where Tur=1 ORDER BY DinlenmeSayisi DESC", baglanti);
            SqlDataReader read = komut1.ExecuteReader();
            int l = 0;
            while(read.Read() && l<10)
            {
                listBox1.Items.Add(read[0]);
                l++;

            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select SarkiAdi from Table_Sarki where Tur=2 ORDER BY DinlenmeSayisi DESC", baglanti);
            SqlDataReader read2 = komut2.ExecuteReader();
            int k = 0;
            while (read2.Read() && k<10)
            {
                listBox2.Items.Add(read2[0]);
                k++;

            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select SarkiAdi from Table_Sarki where Tur=3 ORDER BY DinlenmeSayisi DESC", baglanti);
            SqlDataReader read3 = komut3.ExecuteReader();
            int j = 0;
            while (read3.Read() && j<10)
            {
                listBox3.Items.Add(read3[0]);
                j++;
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select SarkiAdi from Table_Sarki  ORDER BY DinlenmeSayisi DESC", baglanti);
            SqlDataReader read4 = komut4.ExecuteReader();
            int i = 0;
            while (read4.Read() && i<10)
            {
               
               listBox4.Items.Add(read4[0]);
                i++;
           
            }
            
            baglanti.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void asffs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            premiumCalmaListesi prcalmalistesi = new premiumCalmaListesi();
            prcalmalistesi.isimm = label1.Text;
            prcalmalistesi.Show();
        }
    }
}
