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

namespace ProjeDeneme
{
    public partial class StokListesi : Form
    {
        public StokListesi()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;" +
            "port=5432; Database=dbmobilya; user ID=postgres; password=5241886");


        //tüm ürünleri listeleyen metod
        private void stok_listele()
        {
            
            NpgsqlDataAdapter komut = new NpgsqlDataAdapter("select * from stok", baglanti);
            DataSet dt = new DataSet();
            komut.Fill(dt);
            stoklisteDataGridView.DataSource = dt.Tables[0];
            stoklisteDataGridView.Columns["stokid"].HeaderText = "StokID";
            stoklisteDataGridView.Columns["kategoriad"].HeaderText = "Kategori";
            stoklisteDataGridView.Columns["mobilyatur"].HeaderText = "Mobilya";
            stoklisteDataGridView.Columns["marka"].HeaderText = "Marka";
            stoklisteDataGridView.Columns["stokadedi"].HeaderText = "Stok Adedi";
            stoklisteDataGridView.Columns["birimfiyati"].HeaderText = "Birim Fiyatı";
            
        }

        //aramadan sonra ekran girdilerini temizleyen metod
        private void temizle()
        {
            stokidTextBox.Clear();
            kategoriTextBox.Clear();
            markaTextBox.Clear();
            urunturTextBox.Clear();
        }

        
        private void StokListesi_Load(object sender, EventArgs e)
        {
            
            stok_listele();
        }

        //listele butonuna tıklayınca ekrana listeleyen metod
        private void stokListelebutton_Click(object sender, EventArgs e)
        {
            
            if (stokidTextBox.Text != "")
            {
                NpgsqlCommand komut = new NpgsqlCommand("select * from stok where stokid=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", stokidTextBox.Text);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                stoklisteDataGridView.DataSource = dt;
            }
            if (kategoriTextBox.Text != "" && markaTextBox.Text != "" && urunturTextBox.Text != "")
            {
                NpgsqlCommand komut = new NpgsqlCommand("select * from stok where kategoriad=@p1,mobilyatur=@p2," +
                    "marka=@p3", baglanti);
                komut.Parameters.AddWithValue("@p1", kategoriTextBox.Text);
                komut.Parameters.AddWithValue("@p2", urunturTextBox.Text);
                komut.Parameters.AddWithValue("@p3", markaTextBox.Text);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                stoklisteDataGridView.DataSource = dt;
            }
            else if (markaTextBox.Text != "")
            {
                NpgsqlCommand komut = new NpgsqlCommand("select * from stok where marka=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", markaTextBox.Text);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                stoklisteDataGridView.DataSource = dt;
            }
            else if (kategoriTextBox.Text != "")
            {
                NpgsqlCommand komut = new NpgsqlCommand("select * from stok where kategoriad=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", kategoriTextBox.Text);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                stoklisteDataGridView.DataSource = dt;
            }
            else if(urunturTextBox.Text != "")
            {
                NpgsqlCommand komut = new NpgsqlCommand("select * from stok where mobilyatur=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", urunturTextBox.Text);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                stoklisteDataGridView.DataSource = dt;
            }
            temizle();

        }

        //tüm stok kaydını listeleyen metod
        private void hepsiListeleButton_Click(object sender, EventArgs e)
        { 
            stok_listele();
            temizle();
        }
    }
}
