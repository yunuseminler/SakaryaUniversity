using Npgsql;
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

namespace Proje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=proje; user ID=postgres; Password=1140");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            button3.Enabled = true;
            personel.Enabled = false;
            kasa.Enabled = false;
            magaza.Enabled = false;
            label9.Visible = false;
            button1.Enabled = false;
            label6.Text = personel.Text;
            label8.Text = DateTime.Now.ToString("yyyy-MM-dd");
            NpgsqlCommand kasaAc = new NpgsqlCommand("INSERT INTO \"Kasa\" VALUES(@p1,@p2,@p3,@p4)", baglanti);
            kasaAc.Parameters.AddWithValue("@p1", kasa.Text);
            kasaAc.Parameters.AddWithValue("@p2", DateTime.Now.Date);
            kasaAc.Parameters.AddWithValue("@p3", personel.Text);
            kasaAc.Parameters.AddWithValue("@p4", magaza.Text);
            kasaAc.ExecuteNonQuery();
            baglanti.Close();
        }

        private void listele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "SELECT * FROM \"musterisatis\"('" + musteri.Text + "')";
            NpgsqlDataAdapter listele = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            listele.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand bitir = new NpgsqlCommand("SELECT * FROM \"sonlandir\"('2020-12-29',@p2,@p3)", baglanti);
            bitir.Parameters.AddWithValue("@p2", kasa.Text); 
            bitir.Parameters.AddWithValue("@p3", magaza.Text);
            bitir.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            button1.Enabled = true;
            button3.Enabled = false;
            personel.Enabled = true;
            kasa.Enabled = true;
            magaza.Enabled = true;
            label9.Visible = true;
            string sorgu = "DELETE FROM \"Kasa\" WHERE \"kasaNo\" = @p1  AND \"gunTarihi\" = @p2";
            NpgsqlCommand kasaSil = new NpgsqlCommand(sorgu, baglanti);
            kasaSil.Parameters.AddWithValue("@p1", kasa.Text);
            kasaSil.Parameters.AddWithValue("@p2", DateTime.Now.Date);
            kasaSil.ExecuteNonQuery();
            baglanti.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "UPDATE \"Musteri\" SET \"musteriNo\" = @p1  WHERE \"musteriNo\" = @p2";
            NpgsqlCommand kasaSil = new NpgsqlCommand(sorgu, baglanti);
            kasaSil.Parameters.AddWithValue("@p1", yeni.Text);
            kasaSil.Parameters.AddWithValue("@p2", eski.Text);
            kasaSil.ExecuteNonQuery();
            label12.Text = "Musteri no degistirilmiştir.";
            yeni.Text = "";
            eski.Text = "";
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            int sayi = Convert.ToInt32(miktar.Text);
            string sorgu = "SELECT * FROM \"satilanEkle\"(@p1,@p2)";
            NpgsqlCommand kasaSil = new NpgsqlCommand(sorgu, baglanti);
            kasaSil.Parameters.AddWithValue("@p1", urun.Text);
            kasaSil.Parameters.AddWithValue("@p2", sayi);
            kasaSil.ExecuteNonQuery();
            label15.Text = "Urun Satisi Gerceklesmiştir";
            urun.Text = "";
            miktar.Text = "";
            baglanti.Close();
        }
    }
}
