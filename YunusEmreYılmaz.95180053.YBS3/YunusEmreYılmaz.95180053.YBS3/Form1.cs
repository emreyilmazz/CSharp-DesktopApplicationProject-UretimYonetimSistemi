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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        UretimYonetimSistemiEntities uys = new UretimYonetimSistemiEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text != string.Empty && txtSifre.Text != string.Empty)
            {
                var kullanici = uys.users.FirstOrDefault(a => a.kullanici_adi.Equals(txtKullaniciAdi.Text));

                if (kullanici.kullanici_adi.Equals(txtKullaniciAdi.Text) && kullanici.sifre.Equals(txtSifre.Text))
                {
                    MessageBox.Show("Başarıyla Giriş Yapıldı");
                    anaForm ana = new anaForm();
                    this.Hide();
                    ana.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

        