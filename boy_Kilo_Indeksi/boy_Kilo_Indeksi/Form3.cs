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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text;

            // Resmi dinamik olarak yazının içine ekleyelim
            string resimYolu = @"C:\Users\melik\OneDrive\Resimler\Ekran Görüntüleri\Ekran görüntüsü 2025-02-12 214137.png"; // Resim dosya yolu

            // Resmi ekle
            InsertImageAtCursor(resimYolu);

            richTextBox1.AppendText("\nVücut Kitle İndeksi Sonuçları Ne Anlama Gelir?\r\n\r\nVücut kitle indeksi hesaplamasında yağ oranı, vücut tipi, yağ ve kas dokusu gibi etmenler yer almaz. Bu nedenle,\n" +
                " uzmanlar ideal kilo hesaplamada beden kitle indeksi ve bel çevresinin ölçümü dışında, metabolizma hızı ölçümü ve detaylı vücut analizleriyle de kişinin eğer kilo sorunu hakkında daha\n" +
                " ayrıntılı bilgi elde ederler. Kişinin ideal kilosunun altında ya da üstünde olması; diğer etmenlerle birlikte hekim tarafından değerlendirilmelidir. Mevcut sağlık sorunlarını gidermek ve\n" +
                " olası sağlık sorunlarını önlemek için hekimle birlikte hareket edilmelidir.\r\n\r\nErkeklerde bel çevresi 94 cm’yi geçerse artmış risk, 102 cm’yi geçerse yüksek risk olarak görülür. Bu\n" +
                " oran kadınlarda ise 80 cm’yi geçerse artmış risk, 88 cm’yi geçerse yüksek risk olarak kabul edilir.\r\n\r\nVKİ'yi Doğru Hesaplamak İçin İpuçları\r\nVKİ hesaplamasını doğru yapmak için\n" +
                " boy ve kilo ölçümlerinizi doğru girmeniz gerekir. Verileri girmeden önce boyunuzu çıplak ayakla ve düz bir zeminde ölçebilirsiniz. Sabah aç karnına kilonuzu ölçmek ise en doğru sonucu\n" +
                " sağlayacaktır.\r\n\r\nDetaylı Vücut Kitle İndeksi ile Obezite Hesaplama\r\n\r\nDetaylı vücut kitle indeksi ile obezite hesaplamada yaşı ve cinsiyet de dikkate alınarak kilonun, vücut\n" +
                " yağ yüzdesinin ve bel çevre ölçüsünün normal değerlerde olup olmadığını öğrenilebilir.\r\n\r\nÖncelikle yağ dokusunun vücudun neresinde toplandığını bilmek, obezitenin tanı ve tedavisi\n" +
                " için oldukça önemlidir. Yağ dokusunun vücutta birikme şekli; elma tip ve armut tip olmak üzere ikiye ayrılabilir.\r\n\r\nElma tip obezitede yağ göbek çevresinde birikmektedir. Armut tip\n" +
                " obezitede ise kalça ve basenlerde biriktiği gözlemlenir. Fakat göbek çevresinde biriken yağın, kalça ve basenlere göre daha tehlikeli ve kalp hastalıklarına yakalanma riskinin daha\n" +
                " yüksek olduğu kabul edilir.\r\n\r\nYaşa Göre Vücut Kitle İndeksi (VKİ)\r\nÇocuklar ve gençler için de VKİ hesaplama uygulanabilir. Bu yöntemle bir çocuğun veya gencin zayıf, sağlıklı\n" +
                " kiloda, aşırı kilolu veya obez olup olmadığı tespit edilebilir. Bir çocuğun vücut yağı yaşla birlikte değişir. Kız ve erkek çocukları olgunlaştıkça vücut yağ miktarlarında farklılık\n" +
                " oluşur. Bu nedenle, çocuklar için boy kilo endeksi değerlendirmesinde yaş faktörü önemlidir.");

            string resimYolu2 = @"C:\Users\melik\OneDrive\Resimler\Ekran Görüntüleri\Ekran görüntüsü 2025-02-12 220233.png";

            // İkinci resmi yazının sonuna ekle
            InsertImageAtCursor(resimYolu2);

        }

        private void InsertImageAtCursor(string resimYolu)
        {
            Image img = Image.FromFile(resimYolu);

            Clipboard.SetDataObject(img, true);

            richTextBox1.AppendText("\n");  // Bir satır boşluk ekle (isteğe bağlı)
            richTextBox1.Paste();  // Resmi ekle
        }

        
    }
}
