using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeDeneme
{
    public partial class SatisVeStok : Form
    {
        public SatisVeStok()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;" +
            "port=5432; Database=dbmobilya; user ID=postgres; password=5241886");
        //marka combobox ı için
        private void marka_yukle()
        {
            
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select DISTINCT marka from stok", baglanti);
            DataTable dt = new DataTable();
            markaComboBox.DisplayMember = "marka";
            markaComboBox.ValueMember = "marka";
            da.Fill(dt);
            markaComboBox.DataSource = dt;
            
        }
        //kategori comboboxı için
        private void kategori_yukle()
        {
            
            NpgsqlCommand komut = new NpgsqlCommand("select DISTINCT kategoriad from stok where marka=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", markaComboBox.SelectedValue);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataTable dt = new DataTable();
            kategoriComboBox.DisplayMember = "kategoriad";
            kategoriComboBox.ValueMember = "kategoriad";
            da.Fill(dt);
            kategoriComboBox.DataSource = dt;
         
        }

        //mobilya  comboboxı için
        private void mobilya_yukle()
        {
            NpgsqlCommand komut = new NpgsqlCommand("select DISTINCT mobilyatur from stok where kategoriad=@p1 and marka=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", kategoriComboBox.SelectedValue);
            komut.Parameters.AddWithValue("@p2", markaComboBox.SelectedValue);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataTable dt = new DataTable();
            turComboBox.DisplayMember = "mobilyatur";
            turComboBox.ValueMember = "mobilyatur";
            da.Fill(dt);
            turComboBox.DataSource = dt;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(207, 218, 200);
            marka_yukle();
            tablo.Columns.Add("Müsteri ad", typeof(string));
            tablo.Columns.Add("Marka", typeof(string));
            tablo.Columns.Add("Kategori", typeof(string));
            tablo.Columns.Add("Mobilya Türü", typeof(string));
            tablo.Columns.Add("Satış Adedi", typeof(string));
            tablo.Columns.Add("Satış Fiyatı", typeof(string));
            tablo.Columns.Add("ÜrünID", typeof(string));

            satisAdediKontrol();

        }


        //sepete ekler
        private void sepetButton_Click(object sender, EventArgs e)
        {

            Boolean var_mi = false;
            string  ad_soyad;
            string marka, kategori, mobilya_tur;
            string satis_adedi, satis_fiyati;

            ad_soyad = adSoyadTextBox.Text;
            marka = markaComboBox.SelectedValue.ToString();
            kategori = kategoriComboBox.SelectedValue.ToString();
            mobilya_tur = turComboBox.SelectedValue.ToString();
            satis_adedi = satisadediNumericUpDown.Value.ToString();
            satis_fiyati = satisfiyatiNumericUpDown.Text;
           
            //aynı müşteri için marka,kategori ve mobilya türü aynı olan 2.bir ürün eklenmesini istemiyoruz
            for (int i = 0; i < sepetDataGridView.Rows.Count; i++)
            {
                //aynı üründen var mı kontrol ediliyor
                if (sepetDataGridView.Rows[i].Cells[1].Value.ToString() != marka || 
                    sepetDataGridView.Rows[i].Cells[2].Value.ToString() != kategori ||
                    sepetDataGridView.Rows[i].Cells[3].Value.ToString() != mobilya_tur)
                {
                    var_mi = false;
                    
                }
                else
                {
                    var_mi = true;
                    break;
                }
            }
            
            //aynı üründen yoksa ekleniyor
            if (!var_mi)
            {

                tablo.Rows.Add(ad_soyad, marka, kategori, mobilya_tur, satis_adedi, satis_fiyati,satisAdediKontrol());
                sepetDataGridView.DataSource = tablo;
                sepetDataGridView.Columns["ÜrünID"].Visible = false;
                ekran_temizle();
            }
            else
            {
                MessageBox.Show("Bu üründen daha önce eklemiştiniz.", "Sepet İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ekran_temizle();
            }
            //satisAdediKontrol();
        }

       //seçili olanları sepetten çıkarır
        private void sepettenCikarButton_Click_1(object sender, EventArgs e)
        {
            List<DataGridViewRow> toBeDeleted = new List<DataGridViewRow>();
            foreach (DataGridViewRow item in sepetDataGridView.SelectedRows)
            {
                toBeDeleted.Add(item);
            }
            foreach (DataGridViewRow item in toBeDeleted)
            {
                sepetDataGridView.Rows.Remove(item);
            }
        }
        
        //girilen üründen satılabilecek maksimum adetle sınırlanır ve seçilen ürünün id sini döndürür
        private string satisAdediKontrol()
        {
            NpgsqlCommand komut = new NpgsqlCommand("select stokadedi,stokid from stok where marka=@p1 and kategoriad=@p2 and mobilyatur=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", markaComboBox.SelectedValue);
            komut.Parameters.AddWithValue("@p2", kategoriComboBox.SelectedValue);
            komut.Parameters.AddWithValue("@p3", turComboBox.SelectedValue);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataSet dt = new DataSet();
            da.Fill(dt);
            satisadediNumericUpDown.Maximum = Convert.ToInt32(dt.Tables[0].Rows[0][0]);
            return Convert.ToString(dt.Tables[0].Rows[0][1]);
        }
        private void ekran_temizle()
        {
            satisadediNumericUpDown.Value = 0;
            satisfiyatiNumericUpDown.Value = 0; 
        }

        //stok listeleme ekranı açmak için
        private void stokListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokListesi listesi = new StokListesi();
            listesi.ShowDialog();
        }

        //stok düzenleme ekranı açmak için 
        private void stokDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokDuzenle duzenle = new StokDuzenle();
            duzenle.ShowDialog();
        }

        //TODO: satış listesi ve alış listesini paket yap
        private void satışListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SatisEkrani satisEkrani = new SatisEkrani();
            satisEkrani.ShowDialog();
        }

        //alış listesi formu açar
        private void alışListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlisListesi alisListesi = new AlisListesi();
            alisListesi.ShowDialog();
        }

        //müsteri listesi formu açmak için
        private void müşteriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MüsteriListesi müsteri = new MüsteriListesi();
            müsteri.ShowDialog();
        }

        //müsteri düzenle formu açmak için
        private void müşteriDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MüsteriDuzenle duzenle = new MüsteriDuzenle();
            duzenle.ShowDialog();
        }

        //kategoriyi seçince mobilya türleri yüklensin
        private void kategoriComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ekran_temizle();
            mobilya_yukle();
            
        }

        //markayı seçince kategori combobox ı dolsun
        private void markaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ekran_temizle();
            kategori_yukle();
           
        }

        private void turComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            satisAdediKontrol();
        }
        //satış yap butonunun işlemlerini halleder
        private void satisButton_Click(object sender, EventArgs e)
        {
            int satisfiyat;
            int satisadedi;
            string musteriid,stokid;
            for (int rows = 0; rows < sepetDataGridView.Rows.Count; rows++)
            {
               // satisfiyat = int.Parse(sepetDataGridView.Rows[rows].Cells[5].ToString());
                satisadedi = Convert.ToInt32(sepetDataGridView.Rows[rows].Cells[4].Value.ToString());
                //musteriid = sepetDataGridView.Rows[rows].Cells[0].ToString();
                stokid = sepetDataGridView.Rows[rows].Cells[6].Value.ToString();
                stok_guncelle(stokid, satisadedi);
            }
        }
        //Satış yapılınca stoktan adet ekiltilsin
        private void stok_guncelle(string stokid,int stokadet)
        {
            
            int yenistokadeti;
            try
            {
                yenistokadeti = Convert.ToInt32(satisadediNumericUpDown.Maximum) - stokadet;
                baglanti.Open();
                NpgsqlCommand komut = new NpgsqlCommand("update stok set stokadedi=@p2 where stokid=@p1" ,baglanti);
                komut.Parameters.AddWithValue("@p1", stokid);
                komut.Parameters.AddWithValue("@p2", yenistokadeti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show(ex.Message+" "+stokadet, "Veritabanı işlemleri!!!");   
            }
            MessageBox.Show("Satış başarıyla gerçekleştirildi.", "Satış İşlemleri");
            Sepeti_temizle();

        }
        //sepetteki ürünleri temizler
        private void temizleButton_Click(object sender, EventArgs e)
        {
            Sepeti_temizle();
        }
        //Sepetteki ürünlerin hepsini temizler
        private void Sepeti_temizle()
        {
            List<DataGridViewRow> toBeDeleted = new List<DataGridViewRow>();
            foreach (DataGridViewRow item in sepetDataGridView.Rows)
            {
                toBeDeleted.Add(item);
            }
            foreach (DataGridViewRow item in toBeDeleted)
            {
                sepetDataGridView.Rows.Remove(item);
            }
        }
    }
}
