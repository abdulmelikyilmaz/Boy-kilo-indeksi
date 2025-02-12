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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Vücut Kitle İndeksi (VKİ) Hakkında Sıkça Sorulan Sorular\r\nVKİ değeri kaç olmalı?\r\nSağlıklı bir VKİ aralığı" +
                "18.5 ile 24.9 arasındadır. Bu değerlerin dışında kalanlar zayıf, fazla kilolu veya obez olarak sınıflandırılır.\r\n\r\nVKİ fazla" +
                "veya düşük çıkarsa ne yapmalıyım?\r\n" +
                "VKİ’niz yüksekse dengeli bir diyet ve egzersizle kilo vermeyi hedefleyebilirsiniz. Düşük VKİ için ise, yeterli ve dengeli\n" +
                "beslenme konusunda bir uzmana danışmanız faydalı olacaktır.\r\n\r\nBoy kilo endeksi hesaplama neden önemlidir?\r\n" +
                "VKİ, bir kişinin genel sağlık durumunu anlamak ve kilo ile ilgili risk faktörlerini belirlemek için kolay bir yöntemdir.\n" +
                "VKİ, özellikle obezite ve yetersiz beslenme gibi sağlık sorunlarının erken tespitine yardımcı olur.\r\n\r\nVücut kitle" +
                "indeksi tek başına sağlığı gösterir mi?\r\nVKİ, sağlık durumunu anlamak için tek başına yeterli değildir çünkü vücut yağ" +
                "oranı, kas kütlesi ve yağın vücutta nerede\ntoplandığı gibi faktörleri hesaba katmaz.\r\n\r\nVücut kitle indeksi nasıl" +
                "ortaya çıktı?\r\nVücut kitle indeksi 1830'larda Belçikalı bir matematikçi ve sosyal istatistikçi olan Adolphe Quetelet" +
                "tarafından geliştirilmiştir.\nHesap ve istatistik alanındaki becerilerini popülasyonlarda boy ve kilo arasındaki ilişkiyi" +
                "analiz etmek için kullandı ve\n140 yıl boyunca Quetelet Endeksi olarak bilinen formülü formüle etti. 1972 yılında Amerikalı" +
                "biyolog ve fizyolog\nAncel Keys endeksin geçerliliğini destekleyen bir makale yayınladı ve bu süreçte endeksi yeniden " +
                "adlandırarak\nVücut Kitle Endeksi olarak popüler hale getirdi.\r\n\r\nBoy kilo endeksi doktorlar tarafından kullanılıyor mu?\r\n\r\n" +
                "Evet, genel pratisyenlikten uzmanlık seviyesine kadar doktorlar tarafından kullanılmaktadır. Tıp alanındaki kullanımı\n" +
                "doktorlarla sınırlı olmayıp hemşireler, diyetisyenler, beslenme uzmanları, epidemiyologlar ve araştırmacı bilim insanları da\n" +
                "dahil olmak üzere çok çeşitli sağlık profesyonellerini kapsamaktadır.");
        }
        private void bilgiVermeFonksiyonu()
        {

        }
    }
}
