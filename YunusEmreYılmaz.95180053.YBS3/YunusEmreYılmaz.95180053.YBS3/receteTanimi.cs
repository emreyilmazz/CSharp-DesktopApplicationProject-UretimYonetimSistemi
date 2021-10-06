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
    public partial class receteTanimi : Form
    {
        public receteTanimi()
        {
            InitializeComponent();
        }
        UretimYonetimSistemiEntities1 uys = new UretimYonetimSistemiEntities1();
        public void Listele()
        {
            dgwRecete.DataSource = uys.Recete_Tanimi.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            anaForm ana = new anaForm();
            ana.Show();
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Recete_Tanimi rct = new Recete_Tanimi();
            rct.Ana_urun_kodu = txtUrunKodu.Text;
            rct.Recete_aciklama = txtAciklama.Text;
            rct.Satir_sayisi = txtSatirSayisi.Text;
            rct.Recete_miktar = txtMiktar.Text;

            uys.Recete_Tanimi.Add(rct);
            uys.SaveChanges();
            MessageBox.Show("Kayıt Başarıyla Oluşturuldu!");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }


        private void btnSil_Click_1(object sender, EventArgs e)
        {
            String silme = dgwRecete.CurrentRow.Cells[1].Value.ToString();
            var sil = uys.Recete_Tanimi.Where(a => a.Ana_urun_kodu == silme).FirstOrDefault();

            uys.Recete_Tanimi.Remove(sil);
            uys.SaveChanges();
            MessageBox.Show("Kayıt Başarıyla Silindi");
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            String tc = dgwRecete.CurrentRow.Cells[1].Value.ToString();
            var guncelle = uys.Recete_Tanimi.Where(a => a.Ana_urun_kodu == tc).FirstOrDefault();
            guncelle.Ana_urun_kodu = txtUrunKodu.Text;
            guncelle.Recete_aciklama = txtAciklama.Text;
            guncelle.Satir_sayisi = txtSatirSayisi.Text;
            guncelle.Recete_miktar = txtMiktar.Text;

            uys.SaveChanges();
            MessageBox.Show("Kayıt Başarıyla Güncellendi!");
        }
    }
}

