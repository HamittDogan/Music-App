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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-VH5HU6EO;Initial Catalog=prolab3;Integrated Security=True");
        
        void temizle()
        {

            textBox1.Text = "";
            textBox2.Text = "";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Table_Sanatci (SanatciAdi,SanatciÜlkesi) values (@p1,@p2)", baglanti);

            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Sanatçı Başarıyla Eklendi.");
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.table_SanatciTableAdapter1.Fill(this.prolab3DataSet3.Table_Sanatci);

            this.table_SanatciTableAdapter.Fill(this.prolab3DataSet2.Table_Sanatci);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Table_Sanatci Where SanatciAdi=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", textBox1.Text);
            komutsil.ExecuteNonQuery();
            MessageBox.Show("Sanatçı başarıyla Silindi.");
            baglanti.Close(); 
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutgüncelle = new SqlCommand("Update Table_Sanatci Set SanatciAdi=@a1, SanatciÜlkesi=@a2 where SanatciAdi=@a3", baglanti);
            komutgüncelle.Parameters.AddWithValue("@a1", textBox1.Text);
            komutgüncelle.Parameters.AddWithValue("@a2", textBox2.Text);
            komutgüncelle.Parameters.AddWithValue("@a3", textBox1.Text);
            komutgüncelle.ExecuteNonQuery();
            MessageBox.Show("Veriler Güncellendi.");
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }
    }
}
