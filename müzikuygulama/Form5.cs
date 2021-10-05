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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-VH5HU6EO;Initial Catalog=prolab3;Integrated Security=True");

        void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";

        }
       
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand islem = new SqlCommand("insert into Table_Sarki (SarkiAdi,Tarih,SanatciID,Album,Tur,Sure,DinlenmeSayisi,SarkıURL) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
            islem.Parameters.AddWithValue("@p1", textBox1.Text);
            islem.Parameters.AddWithValue("@p2", textBox2.Text);
            islem.Parameters.AddWithValue("@p3", textBox3.Text);
            islem.Parameters.AddWithValue("@p4", textBox4.Text);
            islem.Parameters.AddWithValue("@p5", textBox5.Text);
            islem.Parameters.AddWithValue("@p6", textBox6.Text);
            islem.Parameters.AddWithValue("@p7", textBox7.Text);
            islem.Parameters.AddWithValue("@p8", textBox8.Text);
            islem.ExecuteNonQuery();
            MessageBox.Show("Şarkı Başarıyla Eklendi.");
            baglanti.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.table_SarkiTableAdapter.Fill(this.prolab3DataSet5.Table_Sarki);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand islemsil = new SqlCommand("Delete From Table_Sarki Where SarkiAdi=@k1", baglanti);
            islemsil.Parameters.AddWithValue("@k1", textBox1.Text);
            islemsil.ExecuteNonQuery();
            MessageBox.Show("Şarkı başarıyla Silindi.");
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand islemgüncelle = new SqlCommand("Update Table_Sarki Set SarkiAdi=@a1, Tarih=@a2, SanatciID=@a3, Album=@a4, Tur=@a5, Sure=@a6, DinlenmeSayisi=@a7, SarkıURL=@a8 where SarkiAdi=@a9", baglanti);
            islemgüncelle.Parameters.AddWithValue("@a1", textBox1.Text);
            islemgüncelle.Parameters.AddWithValue("@a2", textBox2.Text);
            islemgüncelle.Parameters.AddWithValue("@a3", textBox3.Text);
            islemgüncelle.Parameters.AddWithValue("@a4", textBox4.Text);
            islemgüncelle.Parameters.AddWithValue("@a5", textBox5.Text);
            islemgüncelle.Parameters.AddWithValue("@a6", textBox6.Text);
            islemgüncelle.Parameters.AddWithValue("@a7", textBox7.Text);
            islemgüncelle.Parameters.AddWithValue("@a8", textBox8.Text);
            islemgüncelle.Parameters.AddWithValue("@a9", textBox1.Text);
            islemgüncelle.ExecuteNonQuery();
            MessageBox.Show("Veriler Güncellendi.");
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
