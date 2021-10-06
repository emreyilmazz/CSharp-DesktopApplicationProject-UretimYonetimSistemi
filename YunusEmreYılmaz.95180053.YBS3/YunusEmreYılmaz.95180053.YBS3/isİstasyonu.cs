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
    public partial class isİstasyonu_Tanimi : Form
    {
        public isİstasyonu_Tanimi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaForm ana = new anaForm();
            ana.Show();
            this.Hide();
        }
        UretimYonetimSistemiEntities1 uys = new UretimYonetimSistemiEntities1();

        public void Liste()
        {
            dgwIs.DataSource = uys.Is_Istasyon_Tanimi.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Is_Istasyon_Tanimi isTanimi = new Is_Istasyon_Tanimi();
            isTanimi.Istasyon_kod = txtIsIstasyonKod.Text;
            isTanimi.Istasyon_aciklama = txtIstasyonAciklama.Text;
            isTanimi.Hammadde_ambari = txtHammaddeAmbar.Text;
            isTanimi.Istasyon_maaliyet = txtIstasyonMaaliyet.Text;


            uys.Is_Istasyon_Tanimi.Add(isTanimi);
            uys.SaveChanges();
            MessageBox.Show("Kayıt Başarıyla Oluşturuldu!");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            String tc = dgwIs.CurrentRow.Cells[1].Value.ToString();
            var sil = uys.Is_Istasyon_Tanimi.Where(a => a.Istasyon_kod == tc).FirstOrDefault();

            uys.Is_Istasyon_Tanimi.Remove(sil);
            uys.SaveChanges();
            MessageBox.Show("Kayıt Başarıyla Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            String tc = dgwIs.CurrentRow.Cells[1].Value.ToString();
            var guncelle = uys.Is_Istasyon_Tanimi.Where(a => a.Istasyon_kod == tc).FirstOrDefault();
            guncelle.Istasyon_kod = txtIsIstasyonKod.Text;
            guncelle.Istasyon_aciklama = txtIstasyonAciklama.Text;
            guncelle.Hammadde_ambari = txtHammaddeAmbar.Text;
            guncelle.Istasyon_maaliyet = txtIstasyonMaaliyet.Text;


            uys.SaveChanges();
            MessageBox.Show("Kayıt Başarıyla Güncellendi!");
        }
    }
}
