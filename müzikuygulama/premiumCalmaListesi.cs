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
    public partial class premiumCalmaListesi : Form
    {
        public String isimm { get; set; }
        public String isim { get; set; }
        public String isim2 { get; set; }
        public int SarkiID { get; set; }
        public int TurID { get; set; }
        public int ID { get; set; }
        public int ID2 { get; set; }
        public int ID3 { get; set; }
        public String SarkiURL { get; set; }
        public premiumCalmaListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-VH5HU6EO;Initial Catalog=prolab3;Integrated Security=True");
        Boolean sarkiVarmi(int x)
        {
            //baglanti.Close();

            baglanti.Open();
            SqlCommand kontrol = new SqlCommand("select * from Table_SarkiListe where SarkiID=@k1 and KullaniciID=@l1", baglanti);
            kontrol.Parameters.AddWithValue("@k1", x);
            kontrol.Parameters.AddWithValue("@l1", ID);
            SqlDataReader oku = kontrol.ExecuteReader();
            if (oku.Read())
            {
                baglanti.Close();
                return true;

            }
            else
            {
                baglanti.Close();
                return false;

            }

        }
        private void premiumCalmaListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'prolab3DataSet19.Table_Kullanici' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.table_KullaniciTableAdapter.Fill(this.prolab3DataSet19.Table_Kullanici);
            label7.Text = isimm;
            label15.Text = isim2;
            baglanti.Open();
            SqlCommand kullanici = new SqlCommand("select KullanıciID from Table_Kullanici where KullaniciAdi=@k1", baglanti);
            kullanici.Parameters.AddWithValue("@k1", isimm);
            SqlDataReader oku = kullanici.ExecuteReader();

            while (oku.Read())
            {
                ID = (int)oku[0];
            }

            baglanti.Close();
            baglanti.Open();
            SqlCommand sarkiEkle = new SqlCommand("select SarkiAdi from Table_SarkiListe INNER JOIN Table_Sarki ON Table_SarkiListe.SarkiID=Table_Sarki.SarkiID where TurID=1 and KullaniciID=@l1", baglanti);
            SqlCommand sarkiEkle1 = new SqlCommand("select SarkiAdi from Table_SarkiListe INNER JOIN Table_Sarki ON Table_SarkiListe.SarkiID=Table_Sarki.SarkiID where TurID=2 and KullaniciID=@m1", baglanti);
            SqlCommand sarkiEkle2 = new SqlCommand("select SarkiAdi from Table_SarkiListe INNER JOIN Table_Sarki ON Table_SarkiListe.SarkiID=Table_Sarki.SarkiID where TurID=3 and KullaniciID=@p1", baglanti);
            SqlCommand arkadasEkle = new SqlCommand("select KullaniciAdi  from  Table_Kullanici INNER JOIN Table_Arkadas ON Table_Kullanici.KullanıciID=Table_Arkadas.ArkadasID where  Table_Arkadas.KullaniciID=@a2", baglanti);
            SqlCommand premiumlar = new SqlCommand("select KullaniciAdi from Table_Kullanici where KullaniciAbonelikturu=1", baglanti);
            sarkiEkle.Parameters.AddWithValue("@l1", ID);
            sarkiEkle1.Parameters.AddWithValue("@m1", ID);
            sarkiEkle2.Parameters.AddWithValue("@p1", ID);
            arkadasEkle.Parameters.AddWithValue("@a2", ID);       
            baglanti.Close();
            baglanti.Open();
            SqlDataReader read8 = premiumlar.ExecuteReader();
            while (read8.Read())
            {

                listBox8.Items.Add(read8[0]);
            }
            baglanti.Close();
            baglanti.Open();
            SqlDataReader read3 = arkadasEkle.ExecuteReader();
            while (read3.Read())
            {

                listBox4.Items.Add(read3[0]);
            }
            baglanti.Close();
            baglanti.Open();
            SqlDataReader read = sarkiEkle.ExecuteReader();
            while (read.Read())
            {

                listBox1.Items.Add(read[0]);
            }
            baglanti.Close();
            baglanti.Open();

            SqlDataReader read1 = sarkiEkle1.ExecuteReader();

            while (read1.Read())
            {

                listBox2.Items.Add(read1[0]);
            }
            baglanti.Close();
            baglanti.Open();

            SqlDataReader read2 = sarkiEkle2.ExecuteReader();

            while (read2.Read())
            {

                listBox3.Items.Add(read2[0]);
            }
            baglanti.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand arkadasekle = new SqlCommand("insert into Table_Arkadas (KullaniciID,ArkadasID) values (@b1,@b2)", baglanti);
            arkadasekle.Parameters.AddWithValue("@b1", ID);
            arkadasekle.Parameters.AddWithValue("@b2", ID2);
            arkadasekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Arkadaş eklendi.");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            //baglanti.Open();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            SarkiID = (int)dataGridView1.Rows[secilen].Cells[0].Value;
            TurID = (int)dataGridView1.Rows[secilen].Cells[5].Value;
            if (sarkiVarmi(SarkiID) == true)
            {
                MessageBox.Show("Bu şarkı listenizde var.");

            }

            else
            {
                baglanti.Open();
                SqlCommand sarkiEkle = new SqlCommand("insert into Table_SarkiListe (KullaniciID,SarkiID,TurID) values (@k1,@k2,@k3)", baglanti);
                sarkiEkle.Parameters.AddWithValue("@k1", ID);
                sarkiEkle.Parameters.AddWithValue("@k2", SarkiID);
                sarkiEkle.Parameters.AddWithValue("@k3", TurID);
                sarkiEkle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Şarkınız eklendi.");
            }
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'prolab3DataSet14.Table_Sarki' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.table_SarkiTableAdapter.Fill(this.prolab3DataSet14.Table_Sarki);
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox8_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            baglanti.Open();
            SqlCommand kullanici = new SqlCommand("select KullanıciID from Table_Kullanici where KullaniciAdi=@k1", baglanti);
            kullanici.Parameters.AddWithValue("@k1", listBox8.SelectedItem.ToString());
            SqlDataReader oku = kullanici.ExecuteReader();

            while (oku.Read())
            {
                ID2 = (int)oku[0];
            }
            baglanti.Close();
        }

        private void listBox4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            isim2 = listBox4.SelectedItem.ToString();
            label15.Text = isim2;
            baglanti.Open();
            SqlCommand kullanici2 = new SqlCommand("select KullanıciID from Table_Kullanici where KullaniciAdi=@k1", baglanti);
            kullanici2.Parameters.AddWithValue("@k1", isim2);
            SqlDataReader oku4 = kullanici2.ExecuteReader();
            while (oku4.Read())
            {
                ID3 = (int)oku4[0];
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand sarkiEkle3 = new SqlCommand("select SarkiAdi from Table_SarkiListe INNER JOIN Table_Sarki ON Table_SarkiListe.SarkiID=Table_Sarki.SarkiID where TurID=1 and KullaniciID=@l1", baglanti);
            SqlCommand sarkiEkle4 = new SqlCommand("select SarkiAdi from Table_SarkiListe INNER JOIN Table_Sarki ON Table_SarkiListe.SarkiID=Table_Sarki.SarkiID where TurID=2 and KullaniciID=@m1", baglanti);
            SqlCommand sarkiEkle5 = new SqlCommand("select SarkiAdi from Table_SarkiListe INNER JOIN Table_Sarki ON Table_SarkiListe.SarkiID=Table_Sarki.SarkiID where TurID=3 and KullaniciID=@p1", baglanti);
            sarkiEkle3.Parameters.AddWithValue("@l1", ID3);
            sarkiEkle4.Parameters.AddWithValue("@m1", ID3);
            sarkiEkle5.Parameters.AddWithValue("@p1", ID3);
            baglanti.Close();
            baglanti.Open();
            SqlDataReader read5 = sarkiEkle3.ExecuteReader();
            while (read5.Read())
            {

                listBox5.Items.Add(read5[0]);
            }
            baglanti.Close();
            baglanti.Open();
            SqlDataReader read6 = sarkiEkle4.ExecuteReader();
            while (read6.Read())
            {

                listBox6.Items.Add(read6[0]);
            }
            baglanti.Close();
            baglanti.Open();
            SqlDataReader read7 = sarkiEkle5.ExecuteReader();
            while (read7.Read())
            {

                listBox7.Items.Add(read7[0]);
            }
            baglanti.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox8.Items.Clear();
            // TODO: Bu kod satırı 'prolab3DataSet19.Table_Kullanici' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.table_KullaniciTableAdapter.Fill(this.prolab3DataSet19.Table_Kullanici);
            label7.Text = isimm;
            label15.Text = isim2;
            baglanti.Open();
            SqlCommand kullanici = new SqlCommand("select KullanıciID from Table_Kullanici where KullaniciAdi=@k1", baglanti);
            kullanici.Parameters.AddWithValue("@k1", isimm);
            SqlDataReader oku = kullanici.ExecuteReader();

            while (oku.Read())
            {
                ID = (int)oku[0];
            }

            baglanti.Close();
            baglanti.Open();
            SqlCommand sarkiEkle = new SqlCommand("select SarkiAdi from Table_SarkiListe INNER JOIN Table_Sarki ON Table_SarkiListe.SarkiID=Table_Sarki.SarkiID where TurID=1 and KullaniciID=@l1", baglanti);
            SqlCommand sarkiEkle1 = new SqlCommand("select SarkiAdi from Table_SarkiListe INNER JOIN Table_Sarki ON Table_SarkiListe.SarkiID=Table_Sarki.SarkiID where TurID=2 and KullaniciID=@m1", baglanti);
            SqlCommand sarkiEkle2 = new SqlCommand("select SarkiAdi from Table_SarkiListe INNER JOIN Table_Sarki ON Table_SarkiListe.SarkiID=Table_Sarki.SarkiID where TurID=3 and KullaniciID=@p1", baglanti);
            SqlCommand arkadasEkle = new SqlCommand("select KullaniciAdi  from  Table_Kullanici INNER JOIN Table_Arkadas ON Table_Kullanici.KullanıciID=Table_Arkadas.ArkadasID where  Table_Arkadas.KullaniciID=@a2", baglanti);
            SqlCommand premiumlar = new SqlCommand("select KullaniciAdi from Table_Kullanici where KullaniciAbonelikturu=1", baglanti);
            sarkiEkle.Parameters.AddWithValue("@l1", ID);
            sarkiEkle1.Parameters.AddWithValue("@m1", ID);
            sarkiEkle2.Parameters.AddWithValue("@p1", ID);
            arkadasEkle.Parameters.AddWithValue("@a2", ID);
            baglanti.Close();
            baglanti.Open();
            SqlDataReader read8 = premiumlar.ExecuteReader();
            while (read8.Read())
            {

                listBox8.Items.Add(read8[0]);
            }
            baglanti.Close();
            baglanti.Open();
            SqlDataReader read3 = arkadasEkle.ExecuteReader();
            while (read3.Read())
            {

                listBox4.Items.Add(read3[0]);
            }
            baglanti.Close();
            baglanti.Open();
            SqlDataReader read = sarkiEkle.ExecuteReader();
            while (read.Read())
            {

                listBox1.Items.Add(read[0]);
            }
            baglanti.Close();
            baglanti.Open();

            SqlDataReader read1 = sarkiEkle1.ExecuteReader();

            while (read1.Read())
            {

                listBox2.Items.Add(read1[0]);
            }
            baglanti.Close();
            baglanti.Open();

            SqlDataReader read2 = sarkiEkle2.ExecuteReader();

            while (read2.Read())
            {

                listBox3.Items.Add(read2[0]);
            }
            baglanti.Close();


        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            baglanti.Open();
            SqlCommand kullanici = new SqlCommand("select SarkiID from Table_Sarki where SarkiAdi=@k1", baglanti);
            SqlCommand sarki = new SqlCommand("select SarkıURL from Table_Sarki where SarkiID=@k2", baglanti);
            kullanici.Parameters.AddWithValue("@k1", listBox1.SelectedItem.ToString());
            SqlDataReader oku = kullanici.ExecuteReader();

            while (oku.Read())
            {
                ID2 = (int)oku[0];
            }
            baglanti.Close();
            baglanti.Open();
            sarki.Parameters.AddWithValue("@k2", ID2);
            oku = sarki.ExecuteReader();

            while (oku.Read())
            {
                SarkiURL = oku[0].ToString();
            }

            baglanti.Close();
            axWindowsMediaPlayer1.URL = SarkiURL;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            baglanti.Open();
            SqlCommand kullanici = new SqlCommand("select SarkiID from Table_Sarki where SarkiAdi=@k1", baglanti);
            SqlCommand sarki = new SqlCommand("select SarkıURL from Table_Sarki where SarkiID=@k2", baglanti);
            kullanici.Parameters.AddWithValue("@k1", listBox2.SelectedItem.ToString());
            SqlDataReader oku = kullanici.ExecuteReader();

            while (oku.Read())
            {
                ID2 = (int)oku[0];
            }
            baglanti.Close();
            baglanti.Open();
            sarki.Parameters.AddWithValue("@k2", ID2);
            oku = sarki.ExecuteReader();

            while (oku.Read())
            {
                SarkiURL = oku[0].ToString();
            }

            baglanti.Close();
            axWindowsMediaPlayer1.URL = SarkiURL;
        }

        private void listBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            baglanti.Open();
            SqlCommand kullanici = new SqlCommand("select SarkiID from Table_Sarki where SarkiAdi=@k1", baglanti);
            SqlCommand sarki = new SqlCommand("select SarkıURL from Table_Sarki where SarkiID=@k2", baglanti);
            kullanici.Parameters.AddWithValue("@k1", listBox3.SelectedItem.ToString());
            SqlDataReader oku = kullanici.ExecuteReader();

            while (oku.Read())
            {
                ID2 = (int)oku[0];
            }
            baglanti.Close();
            baglanti.Open();
            sarki.Parameters.AddWithValue("@k2", ID2);
            oku = sarki.ExecuteReader();

            while (oku.Read())
            {
                SarkiURL = oku[0].ToString();
            }

            baglanti.Close();
            axWindowsMediaPlayer1.URL = SarkiURL;
        }
    }
}
