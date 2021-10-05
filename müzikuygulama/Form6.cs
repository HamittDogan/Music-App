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
    public partial class Form6 : Form
    {
        public Form6()
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

        }
        private void Form6_Load(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.table_AlbumTableAdapter.Fill(this.prolab3DataSet6.Table_Album);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand islem = new SqlCommand("insert into Table_Album (AlbumAdi,SanatciID,Tarih,Tur) values (@p1,@p2,@p3,@p4)", baglanti);
            islem.Parameters.AddWithValue("@p1", textBox1.Text);
            islem.Parameters.AddWithValue("@p2", textBox2.Text);
            islem.Parameters.AddWithValue("@p3", textBox3.Text);
            islem.Parameters.AddWithValue("@p4", textBox4.Text);
            islem.ExecuteNonQuery();
            MessageBox.Show("Albüm Başarıyla Eklendi.");
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand islemsil = new SqlCommand("Delete From Table_Album Where AlbumAdi=@k1", baglanti);
            islemsil.Parameters.AddWithValue("@k1", textBox1.Text);
            islemsil.ExecuteNonQuery();
            MessageBox.Show("Albüm başarıyla Silindi.");
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand islemgüncelle = new SqlCommand("Update Table_Album Set AlbumAdi=@a1, SanatciID=@a2, Tarih=@a3, Tur=@a4 where AlbumAdi=@a5", baglanti);
            islemgüncelle.Parameters.AddWithValue("@a1", textBox1.Text);
            islemgüncelle.Parameters.AddWithValue("@a2", textBox2.Text);
            islemgüncelle.Parameters.AddWithValue("@a3", textBox3.Text);
            islemgüncelle.Parameters.AddWithValue("@a4", textBox4.Text);
            islemgüncelle.Parameters.AddWithValue("@a5", textBox1.Text);
            islemgüncelle.ExecuteNonQuery();
            MessageBox.Show("Veriler Güncellendi.");
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            
        }
    }
}
