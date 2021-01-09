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
    public partial class StokDuzenle : Form
    {
        public StokDuzenle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;" +
            "port=5432; Database=dbmobilya; user ID=postgres; password=5241886");
        private void temizle()
        {
            urunidTextBox.Clear();
            kategoriTextBox.Clear();
            urunturTextBox.Clear();
            markaTextBox.Clear();
            fiyatTextBox.Clear();
            
        }
       
        //geçersiz kılınan girişleri etkinleştirir
        private void enabled()
        {
            kategoriTextBox.Enabled = true;
            miktarTextBox.Enabled = true;
            fiyatTextBox.Enabled = true;
        }

        //bazı girişleri geçersiz kılar
        private void disabled()
        {
            kategoriTextBox.Enabled = false;
            miktarTextBox.Enabled = false;
            fiyatTextBox.Enabled = false;
        }

        //seçilen işlem tipine göre girişleri ayarlar
        private void islemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = islemComboBox.SelectedIndex;
            switch(index)
            {
                case 0:
                    temizle();
                    enabled();
                    break;
                case 1:
                    temizle();
                    disabled();
                    break;
                case 2:
                    temizle();
                    enabled();
                    break;
                
            }
            
        }

        private void kaydetButton_Click_1(object sender, EventArgs e)
        {
            int index = islemComboBox.SelectedIndex;
            //yeni stok ekleme
            if (index == 0)
            {
                try
                {
                    baglanti.Open();
                    NpgsqlCommand komut = new NpgsqlCommand("insert into stok values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                    komut.Parameters.AddWithValue("@p1", urunidTextBox.Text);
                    komut.Parameters.AddWithValue("@p2", kategoriTextBox.Text);
                    komut.Parameters.AddWithValue("@p3", urunturTextBox.Text);
                    komut.Parameters.AddWithValue("@p4", markaTextBox.Text);
                    komut.Parameters.AddWithValue("@p5", int.Parse(miktarTextBox.Text));
                    komut.Parameters.AddWithValue("@p6", int.Parse(fiyatTextBox.Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Başarıyla eklendi", "Veritabanı işlemleri");

                }
                catch (Exception ex)
                {
                    baglanti.Close();
                    MessageBox.Show(ex.Message, "Lütfen düzgün giriş yapınız");
                }
            }
            //stok silme
            else if(index == 1)
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Silmek istediğinize emin misiniz!", "Veritabanı işlemleri", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                try
                {
                    if (dr == DialogResult.Yes)
                    {
                        baglanti.Open();
                        NpgsqlCommand komut = new NpgsqlCommand("delete from stok where stokid=@p1", baglanti);
                        komut.Parameters.AddWithValue("@p1", urunidTextBox.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    else
                    {
                        baglanti.Close();
                    }
                    
                }
                catch (Exception ex)
                {

                    baglanti.Close();
                    MessageBox.Show(ex.Message, "Lütfen düzgün giriş yapınız");
                }
            }
            //stok güncelleme
            else if(index == 2)
            {
                try
                {
                    baglanti.Open();
                    NpgsqlCommand komut = new NpgsqlCommand("uptade stok set urun kategoriid=@p1," +
                        "mobilyatur=@p2,marka=@p3,stokadedi=@p4,birimfiyati=@p5 where stokid=@p6",baglanti);
                    komut.Parameters.AddWithValue("@p6", urunidTextBox.Text);
                    komut.Parameters.AddWithValue("@p1", kategoriTextBox.Text);
                    komut.Parameters.AddWithValue("@p2", urunturTextBox.Text);
                    komut.Parameters.AddWithValue("@p3", markaTextBox.Text);
                    komut.Parameters.AddWithValue("@p4", int.Parse(miktarTextBox.Text));
                    komut.Parameters.AddWithValue("@p5", int.Parse(fiyatTextBox.Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Başarıyla güncellendi", "Veritabanı işlemleri",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    baglanti.Close();
                    MessageBox.Show(ex.Message, "Lütfen düzgün giriş yapınız");
                }
            }
        }
    }
}
