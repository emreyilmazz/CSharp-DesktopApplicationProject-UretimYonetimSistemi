using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YunusEmreYılmaz._95180053.YBS3
{
    public partial class calisanTanimi : Form
    {
        public calisanTanimi()
        {
            InitializeComponent();
        }
        UretimYonetimSistemiEntities1 uys = new UretimYonetimSistemiEntities1();
        public void Listele()
        {
            dgwCalisan.DataSource = uys.Calisan_Tanimi.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            anaForm ana = new anaForm();
            ana.Show();
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Calisan_Tanimi calisan = new Calisan_Tanimi();
            calisan.Calisan_tc = txtTc.Text;
            calisan.Calisan_ad = txtAd.Text;
            calisan.Calisan_soyad = txtSoyad.Text;
            calisan.Calisan_gorevi = txtGorev.Text;
            calisan.Calisan_saat_maaliyet = txtSaatMaaliyeti.Text;
            calisan.Calisan_aylik_maaliyet = txtMaaliyet.Text;

            uys.Calisan_Tanimi.Add(calisan);
            uys.SaveChanges();
            MessageBox.Show("Kayıt Başarıyla Oluşturuldu!");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            String tc = dgwCalisan.CurrentRow.Cells[1].Value.ToString();
            var sil = uys.Calisan_Tanimi.Where(a => a.Calisan_tc == tc).FirstOrDefault();

            uys.Calisan_Tanimi.Remove(sil);
            uys.SaveChanges();
            MessageBox.Show("Kayıt Başarıyla Silindi");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtAra.Text != string.Empty)
            {
                var ara = uys.Calisan_Tanimi.Where(x => x.Calisan_ad.Contains(txtAra.Text));
                dgwCalisan.DataSource = ara.ToList();
            }
            else
            {
                dgwCalisan.DataSource = uys.Calisan_Tanimi.ToList();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            String tc = dgwCalisan.CurrentRow.Cells[1].Value.ToString();
            var guncelle = uys.Calisan_Tanimi.Where(a => a.Calisan_tc == tc).FirstOrDefault();
            guncelle.Calisan_tc = txtTc.Text;
            guncelle.Calisan_ad = txtAd.Text;
            guncelle.Calisan_soyad = txtSoyad.Text;
            guncelle.Calisan_gorevi = txtGorev.Text;
            guncelle.Calisan_saat_maaliyet = txtSaatMaaliyeti.Text;
            guncelle.Calisan_aylik_maaliyet = txtMaaliyet.Text;

            uys.SaveChanges();
            MessageBox.Show("Kayıt Başarıyla Güncellendi!");
            
            



        }
    }
}

