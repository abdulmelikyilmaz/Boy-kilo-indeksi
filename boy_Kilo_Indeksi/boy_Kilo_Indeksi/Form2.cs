using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boy_Kilo_Indeksi
{
    public partial class Form2 : Form
    {
        double hesaplanan;
        public Form2(double hesaplama)
        {
            InitializeComponent();
            hesaplanan=hesaplama;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_Sonuc.Text= Convert.ToString(hesaplanan);
            if(hesaplanan>=0 && hesaplanan<=18.4000)
            {
                lbl_Durum.Text+=" Zayıf";
                lstbx_DurumListe.SelectedIndex=0;
            }
            else if(hesaplanan>18.4000 && hesaplanan<=24.9000)
            {
                lbl_Durum.Text+=" İdeal kilo";
                lstbx_DurumListe.SelectedIndex=1;
            }
            else if (hesaplanan>24.9000 && hesaplanan<=29.9000)
            {
                lbl_Durum.Text+=" Hafif kilolu";
                lstbx_DurumListe.SelectedIndex=2;
            }
            else if (hesaplanan>29.9000 && hesaplanan<=34.9000)
            {
                lbl_Durum.Text+=" I. derece kilolu";
                lstbx_DurumListe.SelectedIndex=3;
            }
            else if(hesaplanan>34.9000 && hesaplanan<=44.9000)
            {
                lbl_Durum.Text+=" II. derece kilolu";
                lstbx_DurumListe.SelectedIndex=4;
            }
            else if (hesaplanan>44.9000)
            {
                lbl_Durum.Text+=" III. derece kilolu";
                lstbx_DurumListe.SelectedIndex=5;
            }
        }

        private void sayfaBilgiVermeFonksiyonu()
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            
        }

        private void sayfaBilgiVermeFonksiyonu2()
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
            
        }
        private void vücutKitleİndeksiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sayfaBilgiVermeFonksiyonu();
        }


        private void vücutKitleİndeksiNedirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sayfaBilgiVermeFonksiyonu();
        }

        private void vücutKitleİndeksiNasılHesaplanırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sayfaBilgiVermeFonksiyonu();
        }

        private void vücutKitleİndeksiKaçOlmalıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sayfaBilgiVermeFonksiyonu();
        }

        private void vücutKitleİndeksiSonuçlarıNeAnlamaGelirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sayfaBilgiVermeFonksiyonu();
        }

        private void vKİyiDoğruHesaplamakİçinİpuçlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sayfaBilgiVermeFonksiyonu();
        }

        private void detaylıVücutKitleİndeksiİleObeziteHesaplamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sayfaBilgiVermeFonksiyonu();
        }

        private void yaşaGöreVücutKitleİndeksiVKİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sayfaBilgiVermeFonksiyonu();
        }

        private void vKİFazlaVeyaDüşükÇıkarsaNeYapmalıyımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sayfaBilgiVermeFonksiyonu2();
        }

        private void boyKiloEndeksiHesaplamaNedenÖnemlidirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sayfaBilgiVermeFonksiyonu2();
        }

        private void vücutKitleİndeksiTekBaşınaSağlığıGösterirMiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sayfaBilgiVermeFonksiyonu2();
        }

        private void vücutKitleİndeksiNasılOrtayaÇıktıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sayfaBilgiVermeFonksiyonu2();
        }

        private void boyKiloEndeksiDoktorlarTarafındanKullanılıyorMuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sayfaBilgiVermeFonksiyonu2();
        }
    }
}
