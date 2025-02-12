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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public double boy;
        public double kilo;

        private void btn_Hesapla_Click(object sender, EventArgs e)
        {
            boy=Convert.ToDouble(txt_BoyGirisi.Text);
            kilo=Convert.ToDouble(txt_KiloGirisi.Text);

            if (boy==0 || boy<0)
            {
                MessageBox.Show("Gecerli bir deger giriniz.");
            }
            else if (kilo==0 || kilo<0)
            {
                MessageBox.Show("Gecerli bir deger giriniz.");
            }
            else if(boy==0 && kilo==0 )
            {
                MessageBox.Show("Gecerli bir deger giriniz.");
            }
            else
            {
            double hesaplama = kilo/(Math.Pow(boy, 2)/10000);
            Form2 f2 = new Form2(hesaplama);
            f2.ShowDialog();
            }
           


        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if(txt_BoyGirisi.Text!="" && txt_KiloGirisi.Text!="")
            {
                txt_BoyGirisi.Text="";
                txt_KiloGirisi.Text="";
            }
            else if (txt_BoyGirisi.Text!="")
            {
                txt_BoyGirisi.Text="";
            }
            else if (txt_KiloGirisi.Text!="")
            {
                txt_KiloGirisi.Text="";
            }
            else
            {
                MessageBox.Show("Silinecek herhangi bir veri yok.");
            }
        }
    }
}
