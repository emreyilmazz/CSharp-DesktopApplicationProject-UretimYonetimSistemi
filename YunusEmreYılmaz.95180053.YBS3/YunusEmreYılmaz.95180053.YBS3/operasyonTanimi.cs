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
    public partial class operasyonTanimi : Form
    {
        public operasyonTanimi()
        {
            InitializeComponent();
        }

        UretimYonetimSistemiEntities2 uys2 = new UretimYonetimSistemiEntities2();

        public void Liste()
        {
            dataGridView1.DataSource = uys2.Operasyon_Tanimi.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            anaForm ana = new anaForm();
            ana.Show();
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Operasyon_Tanimi opr = new Operasyon_Tanimi();
            opr.Operasyon_kodu = txtOperasyonKod.Text;
            opr.Toplam_operasyon_suresi = txtToplamOperasyonSuresi.Text;
            opr.Islem_suresi = txtIslemSuresi.Text;
            opr.Bekleme_suresi = txtBeklemeSuresi.Text;
            opr.Tasima_suresi = txtTasimaSuresi.Text;
            opr.Operasyon_aciklamasi = txtOperasyonAciklamasi.Text;

            uys2.Operasyon_Tanimi.Add(opr);
            uys2.SaveChanges();
            MessageBox.Show("Kayıt Başarıyla Oluşturuldu!");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Liste();
        }
    }
}
