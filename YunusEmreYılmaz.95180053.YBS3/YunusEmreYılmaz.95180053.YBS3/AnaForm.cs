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
    public partial class anaForm : Form
    {
        public anaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calisanTanimi calisan = new calisanTanimi();
            calisan.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            receteTanimi recete = new receteTanimi();
            recete.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isİstasyonu_Tanimi isİstasyonu = new isİstasyonu_Tanimi();
            isİstasyonu.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operasyonTanimi operasyon = new operasyonTanimi();
            operasyon.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
