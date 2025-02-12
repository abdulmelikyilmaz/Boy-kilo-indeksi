namespace boy_Kilo_Indeksi
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Baslik = new System.Windows.Forms.Label();
            this.lbl_sonuclanacak = new System.Windows.Forms.Label();
            this.lbl_Sonuc = new System.Windows.Forms.Label();
            this.lbl_Ulusal = new System.Windows.Forms.Label();
            this.lstbx_DurumListe = new System.Windows.Forms.ListBox();
            this.lbl_Durum = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vücutKitleİndeksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vücutKitleİndeksiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vücutKitleİndeksiNedirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vücutKitleİndeksiNasılHesaplanırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vücutKitleİndeksiKaçOlmalıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vücutKitleİndeksiSonuçlarıNeAnlamaGelirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vKİyiDoğruHesaplamakİçinİpuçlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detaylıVücutKitleİndeksiİleObeziteHesaplamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaşaGöreVücutKitleİndeksiVKİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sıkçaSorualnSorularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vKİFazlaVeyaDüşükÇıkarsaNeYapmalıyımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boyKiloEndeksiHesaplamaNedenÖnemlidirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vücutKitleİndeksiTekBaşınaSağlığıGösterirMiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vücutKitleİndeksiNasılOrtayaÇıktıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boyKiloEndeksiDoktorlarTarafındanKullanılıyorMuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Baslik
            // 
            this.lbl_Baslik.AutoSize = true;
            this.lbl_Baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Baslik.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Baslik.Location = new System.Drawing.Point(208, 33);
            this.lbl_Baslik.Name = "lbl_Baslik";
            this.lbl_Baslik.Size = new System.Drawing.Size(385, 37);
            this.lbl_Baslik.TabIndex = 0;
            this.lbl_Baslik.Text = "Hesaplama tamamlandı!";
            // 
            // lbl_sonuclanacak
            // 
            this.lbl_sonuclanacak.AutoSize = true;
            this.lbl_sonuclanacak.Location = new System.Drawing.Point(60, 132);
            this.lbl_sonuclanacak.Name = "lbl_sonuclanacak";
            this.lbl_sonuclanacak.Size = new System.Drawing.Size(160, 20);
            this.lbl_sonuclanacak.TabIndex = 1;
            this.lbl_sonuclanacak.Text = "Vücut kitle indeksiniz:";
            // 
            // lbl_Sonuc
            // 
            this.lbl_Sonuc.AutoSize = true;
            this.lbl_Sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sonuc.Location = new System.Drawing.Point(273, 123);
            this.lbl_Sonuc.Name = "lbl_Sonuc";
            this.lbl_Sonuc.Size = new System.Drawing.Size(0, 25);
            this.lbl_Sonuc.TabIndex = 2;
            // 
            // lbl_Ulusal
            // 
            this.lbl_Ulusal.AutoSize = true;
            this.lbl_Ulusal.Location = new System.Drawing.Point(60, 234);
            this.lbl_Ulusal.Name = "lbl_Ulusal";
            this.lbl_Ulusal.Size = new System.Drawing.Size(288, 20);
            this.lbl_Ulusal.TabIndex = 3;
            this.lbl_Ulusal.Text = "Uluslararası vücut kitle indeksi değerleri:";
            // 
            // lstbx_DurumListe
            // 
            this.lstbx_DurumListe.FormattingEnabled = true;
            this.lstbx_DurumListe.ItemHeight = 20;
            this.lstbx_DurumListe.Items.AddRange(new object[] {
            "0-18.4: Zayıf",
            "18.5-24.9: İdeal kilol",
            "25.0-29.9: Hafif kilolu",
            "30.0-34.9: Şişman I. derece",
            "35-44.9: Şişman II. derece",
            "45 ve üstü: Şişman III. derece"});
            this.lstbx_DurumListe.Location = new System.Drawing.Point(440, 234);
            this.lstbx_DurumListe.Name = "lstbx_DurumListe";
            this.lstbx_DurumListe.Size = new System.Drawing.Size(281, 124);
            this.lstbx_DurumListe.TabIndex = 4;
            // 
            // lbl_Durum
            // 
            this.lbl_Durum.AutoSize = true;
            this.lbl_Durum.Location = new System.Drawing.Point(60, 181);
            this.lbl_Durum.Name = "lbl_Durum";
            this.lbl_Durum.Size = new System.Drawing.Size(96, 20);
            this.lbl_Durum.TabIndex = 5;
            this.lbl_Durum.Text = "Durumunuz:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vücutKitleİndeksiToolStripMenuItem,
            this.sıkçaSorualnSorularToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vücutKitleİndeksiToolStripMenuItem
            // 
            this.vücutKitleİndeksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vücutKitleİndeksiToolStripMenuItem1,
            this.vücutKitleİndeksiNedirToolStripMenuItem,
            this.vücutKitleİndeksiNasılHesaplanırToolStripMenuItem,
            this.vücutKitleİndeksiKaçOlmalıToolStripMenuItem,
            this.vücutKitleİndeksiSonuçlarıNeAnlamaGelirToolStripMenuItem,
            this.vKİyiDoğruHesaplamakİçinİpuçlarıToolStripMenuItem,
            this.detaylıVücutKitleİndeksiİleObeziteHesaplamaToolStripMenuItem,
            this.yaşaGöreVücutKitleİndeksiVKİToolStripMenuItem});
            this.vücutKitleİndeksiToolStripMenuItem.Name = "vücutKitleİndeksiToolStripMenuItem";
            this.vücutKitleİndeksiToolStripMenuItem.Size = new System.Drawing.Size(170, 29);
            this.vücutKitleİndeksiToolStripMenuItem.Text = "Vücut kitle indeksi";
            // 
            // vücutKitleİndeksiToolStripMenuItem1
            // 
            this.vücutKitleİndeksiToolStripMenuItem1.Name = "vücutKitleİndeksiToolStripMenuItem1";
            this.vücutKitleİndeksiToolStripMenuItem1.Size = new System.Drawing.Size(498, 34);
            this.vücutKitleİndeksiToolStripMenuItem1.Text = "Vücut kitle indeksi";
            this.vücutKitleİndeksiToolStripMenuItem1.Click += new System.EventHandler(this.vücutKitleİndeksiToolStripMenuItem1_Click);
            // 
            // vücutKitleİndeksiNedirToolStripMenuItem
            // 
            this.vücutKitleİndeksiNedirToolStripMenuItem.Name = "vücutKitleİndeksiNedirToolStripMenuItem";
            this.vücutKitleİndeksiNedirToolStripMenuItem.Size = new System.Drawing.Size(498, 34);
            this.vücutKitleİndeksiNedirToolStripMenuItem.Text = "Vücut kitle indeksi nedir?";
            this.vücutKitleİndeksiNedirToolStripMenuItem.Click += new System.EventHandler(this.vücutKitleİndeksiNedirToolStripMenuItem_Click);
            // 
            // vücutKitleİndeksiNasılHesaplanırToolStripMenuItem
            // 
            this.vücutKitleİndeksiNasılHesaplanırToolStripMenuItem.Name = "vücutKitleİndeksiNasılHesaplanırToolStripMenuItem";
            this.vücutKitleİndeksiNasılHesaplanırToolStripMenuItem.Size = new System.Drawing.Size(498, 34);
            this.vücutKitleİndeksiNasılHesaplanırToolStripMenuItem.Text = "Vücut kitle indeksi nasıl hesaplanır?";
            this.vücutKitleİndeksiNasılHesaplanırToolStripMenuItem.Click += new System.EventHandler(this.vücutKitleİndeksiNasılHesaplanırToolStripMenuItem_Click);
            // 
            // vücutKitleİndeksiKaçOlmalıToolStripMenuItem
            // 
            this.vücutKitleİndeksiKaçOlmalıToolStripMenuItem.Name = "vücutKitleİndeksiKaçOlmalıToolStripMenuItem";
            this.vücutKitleİndeksiKaçOlmalıToolStripMenuItem.Size = new System.Drawing.Size(498, 34);
            this.vücutKitleİndeksiKaçOlmalıToolStripMenuItem.Text = "Vücut kitle indeksi kaç olmalı?";
            this.vücutKitleİndeksiKaçOlmalıToolStripMenuItem.Click += new System.EventHandler(this.vücutKitleİndeksiKaçOlmalıToolStripMenuItem_Click);
            // 
            // vücutKitleİndeksiSonuçlarıNeAnlamaGelirToolStripMenuItem
            // 
            this.vücutKitleİndeksiSonuçlarıNeAnlamaGelirToolStripMenuItem.Name = "vücutKitleİndeksiSonuçlarıNeAnlamaGelirToolStripMenuItem";
            this.vücutKitleİndeksiSonuçlarıNeAnlamaGelirToolStripMenuItem.Size = new System.Drawing.Size(498, 34);
            this.vücutKitleİndeksiSonuçlarıNeAnlamaGelirToolStripMenuItem.Text = "Vücut Kitle İndeksi Sonuçları Ne Anlama Gelir?";
            this.vücutKitleİndeksiSonuçlarıNeAnlamaGelirToolStripMenuItem.Click += new System.EventHandler(this.vücutKitleİndeksiSonuçlarıNeAnlamaGelirToolStripMenuItem_Click);
            // 
            // vKİyiDoğruHesaplamakİçinİpuçlarıToolStripMenuItem
            // 
            this.vKİyiDoğruHesaplamakİçinİpuçlarıToolStripMenuItem.Name = "vKİyiDoğruHesaplamakİçinİpuçlarıToolStripMenuItem";
            this.vKİyiDoğruHesaplamakİçinİpuçlarıToolStripMenuItem.Size = new System.Drawing.Size(498, 34);
            this.vKİyiDoğruHesaplamakİçinİpuçlarıToolStripMenuItem.Text = "VKİ\'yi Doğru Hesaplamak İçin İpuçları";
            this.vKİyiDoğruHesaplamakİçinİpuçlarıToolStripMenuItem.Click += new System.EventHandler(this.vKİyiDoğruHesaplamakİçinİpuçlarıToolStripMenuItem_Click);
            // 
            // detaylıVücutKitleİndeksiİleObeziteHesaplamaToolStripMenuItem
            // 
            this.detaylıVücutKitleİndeksiİleObeziteHesaplamaToolStripMenuItem.Name = "detaylıVücutKitleİndeksiİleObeziteHesaplamaToolStripMenuItem";
            this.detaylıVücutKitleİndeksiİleObeziteHesaplamaToolStripMenuItem.Size = new System.Drawing.Size(498, 34);
            this.detaylıVücutKitleİndeksiİleObeziteHesaplamaToolStripMenuItem.Text = "Detaylı Vücut Kitle İndeksi ile Obezite Hesaplama";
            this.detaylıVücutKitleİndeksiİleObeziteHesaplamaToolStripMenuItem.Click += new System.EventHandler(this.detaylıVücutKitleİndeksiİleObeziteHesaplamaToolStripMenuItem_Click);
            // 
            // yaşaGöreVücutKitleİndeksiVKİToolStripMenuItem
            // 
            this.yaşaGöreVücutKitleİndeksiVKİToolStripMenuItem.Name = "yaşaGöreVücutKitleİndeksiVKİToolStripMenuItem";
            this.yaşaGöreVücutKitleİndeksiVKİToolStripMenuItem.Size = new System.Drawing.Size(498, 34);
            this.yaşaGöreVücutKitleİndeksiVKİToolStripMenuItem.Text = "Yaşa Göre Vücut Kitle İndeksi (VKİ)";
            this.yaşaGöreVücutKitleİndeksiVKİToolStripMenuItem.Click += new System.EventHandler(this.yaşaGöreVücutKitleİndeksiVKİToolStripMenuItem_Click);
            // 
            // sıkçaSorualnSorularToolStripMenuItem
            // 
            this.sıkçaSorualnSorularToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vKİFazlaVeyaDüşükÇıkarsaNeYapmalıyımToolStripMenuItem,
            this.boyKiloEndeksiHesaplamaNedenÖnemlidirToolStripMenuItem,
            this.vücutKitleİndeksiTekBaşınaSağlığıGösterirMiToolStripMenuItem,
            this.vücutKitleİndeksiNasılOrtayaÇıktıToolStripMenuItem,
            this.boyKiloEndeksiDoktorlarTarafındanKullanılıyorMuToolStripMenuItem});
            this.sıkçaSorualnSorularToolStripMenuItem.Name = "sıkçaSorualnSorularToolStripMenuItem";
            this.sıkçaSorualnSorularToolStripMenuItem.Size = new System.Drawing.Size(194, 29);
            this.sıkçaSorualnSorularToolStripMenuItem.Text = "Sıkça Sorulan Sorular";
            // 
            // vKİFazlaVeyaDüşükÇıkarsaNeYapmalıyımToolStripMenuItem
            // 
            this.vKİFazlaVeyaDüşükÇıkarsaNeYapmalıyımToolStripMenuItem.Name = "vKİFazlaVeyaDüşükÇıkarsaNeYapmalıyımToolStripMenuItem";
            this.vKİFazlaVeyaDüşükÇıkarsaNeYapmalıyımToolStripMenuItem.Size = new System.Drawing.Size(533, 34);
            this.vKİFazlaVeyaDüşükÇıkarsaNeYapmalıyımToolStripMenuItem.Text = "VKİ fazla veya düşük çıkarsa ne yapmalıyım?";
            this.vKİFazlaVeyaDüşükÇıkarsaNeYapmalıyımToolStripMenuItem.Click += new System.EventHandler(this.vKİFazlaVeyaDüşükÇıkarsaNeYapmalıyımToolStripMenuItem_Click);
            // 
            // boyKiloEndeksiHesaplamaNedenÖnemlidirToolStripMenuItem
            // 
            this.boyKiloEndeksiHesaplamaNedenÖnemlidirToolStripMenuItem.Name = "boyKiloEndeksiHesaplamaNedenÖnemlidirToolStripMenuItem";
            this.boyKiloEndeksiHesaplamaNedenÖnemlidirToolStripMenuItem.Size = new System.Drawing.Size(533, 34);
            this.boyKiloEndeksiHesaplamaNedenÖnemlidirToolStripMenuItem.Text = "Boy kilo endeksi hesaplama neden önemlidir?";
            this.boyKiloEndeksiHesaplamaNedenÖnemlidirToolStripMenuItem.Click += new System.EventHandler(this.boyKiloEndeksiHesaplamaNedenÖnemlidirToolStripMenuItem_Click);
            // 
            // vücutKitleİndeksiTekBaşınaSağlığıGösterirMiToolStripMenuItem
            // 
            this.vücutKitleİndeksiTekBaşınaSağlığıGösterirMiToolStripMenuItem.Name = "vücutKitleİndeksiTekBaşınaSağlığıGösterirMiToolStripMenuItem";
            this.vücutKitleİndeksiTekBaşınaSağlığıGösterirMiToolStripMenuItem.Size = new System.Drawing.Size(533, 34);
            this.vücutKitleİndeksiTekBaşınaSağlığıGösterirMiToolStripMenuItem.Text = "Vücut kitle indeksi tek başına sağlığı gösterir mi?";
            this.vücutKitleİndeksiTekBaşınaSağlığıGösterirMiToolStripMenuItem.Click += new System.EventHandler(this.vücutKitleİndeksiTekBaşınaSağlığıGösterirMiToolStripMenuItem_Click);
            // 
            // vücutKitleİndeksiNasılOrtayaÇıktıToolStripMenuItem
            // 
            this.vücutKitleİndeksiNasılOrtayaÇıktıToolStripMenuItem.Name = "vücutKitleİndeksiNasılOrtayaÇıktıToolStripMenuItem";
            this.vücutKitleİndeksiNasılOrtayaÇıktıToolStripMenuItem.Size = new System.Drawing.Size(533, 34);
            this.vücutKitleİndeksiNasılOrtayaÇıktıToolStripMenuItem.Text = "Vücut kitle indeksi nasıl ortaya çıktı?";
            this.vücutKitleİndeksiNasılOrtayaÇıktıToolStripMenuItem.Click += new System.EventHandler(this.vücutKitleİndeksiNasılOrtayaÇıktıToolStripMenuItem_Click);
            // 
            // boyKiloEndeksiDoktorlarTarafındanKullanılıyorMuToolStripMenuItem
            // 
            this.boyKiloEndeksiDoktorlarTarafındanKullanılıyorMuToolStripMenuItem.Name = "boyKiloEndeksiDoktorlarTarafındanKullanılıyorMuToolStripMenuItem";
            this.boyKiloEndeksiDoktorlarTarafındanKullanılıyorMuToolStripMenuItem.Size = new System.Drawing.Size(533, 34);
            this.boyKiloEndeksiDoktorlarTarafındanKullanılıyorMuToolStripMenuItem.Text = "Boy kilo endeksi doktorlar tarafından kullanılıyor mu?";
            this.boyKiloEndeksiDoktorlarTarafındanKullanılıyorMuToolStripMenuItem.Click += new System.EventHandler(this.boyKiloEndeksiDoktorlarTarafındanKullanılıyorMuToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Durum);
            this.Controls.Add(this.lstbx_DurumListe);
            this.Controls.Add(this.lbl_Ulusal);
            this.Controls.Add(this.lbl_Sonuc);
            this.Controls.Add(this.lbl_sonuclanacak);
            this.Controls.Add(this.lbl_Baslik);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Baslik;
        private System.Windows.Forms.Label lbl_sonuclanacak;
        private System.Windows.Forms.Label lbl_Sonuc;
        private System.Windows.Forms.Label lbl_Ulusal;
        private System.Windows.Forms.ListBox lstbx_DurumListe;
        private System.Windows.Forms.Label lbl_Durum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vücutKitleİndeksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vücutKitleİndeksiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vücutKitleİndeksiNedirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vücutKitleİndeksiNasılHesaplanırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vücutKitleİndeksiKaçOlmalıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vücutKitleİndeksiSonuçlarıNeAnlamaGelirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vKİyiDoğruHesaplamakİçinİpuçlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detaylıVücutKitleİndeksiİleObeziteHesaplamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yaşaGöreVücutKitleİndeksiVKİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sıkçaSorualnSorularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vKİFazlaVeyaDüşükÇıkarsaNeYapmalıyımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boyKiloEndeksiHesaplamaNedenÖnemlidirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vücutKitleİndeksiTekBaşınaSağlığıGösterirMiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vücutKitleİndeksiNasılOrtayaÇıktıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boyKiloEndeksiDoktorlarTarafındanKullanılıyorMuToolStripMenuItem;
    }
}