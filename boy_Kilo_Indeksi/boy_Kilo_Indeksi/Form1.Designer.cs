namespace boy_Kilo_Indeksi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Baslik = new System.Windows.Forms.Label();
            this.txt_BoyGirisi = new System.Windows.Forms.TextBox();
            this.txt_KiloGirisi = new System.Windows.Forms.TextBox();
            this.btn_Hesapla = new System.Windows.Forms.Button();
            this.lbl_Boy = new System.Windows.Forms.Label();
            this.lbl_Kilo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Baslik
            // 
            this.lbl_Baslik.AutoSize = true;
            this.lbl_Baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Baslik.ForeColor = System.Drawing.Color.Red;
            this.lbl_Baslik.Location = new System.Drawing.Point(48, 24);
            this.lbl_Baslik.Name = "lbl_Baslik";
            this.lbl_Baslik.Size = new System.Drawing.Size(199, 29);
            this.lbl_Baslik.TabIndex = 0;
            this.lbl_Baslik.Text = "Boy-kilo indeksi";
            // 
            // txt_BoyGirisi
            // 
            this.txt_BoyGirisi.Location = new System.Drawing.Point(196, 52);
            this.txt_BoyGirisi.Name = "txt_BoyGirisi";
            this.txt_BoyGirisi.Size = new System.Drawing.Size(100, 30);
            this.txt_BoyGirisi.TabIndex = 1;
            // 
            // txt_KiloGirisi
            // 
            this.txt_KiloGirisi.Location = new System.Drawing.Point(196, 101);
            this.txt_KiloGirisi.Name = "txt_KiloGirisi";
            this.txt_KiloGirisi.Size = new System.Drawing.Size(100, 30);
            this.txt_KiloGirisi.TabIndex = 2;
            // 
            // btn_Hesapla
            // 
            this.btn_Hesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Hesapla.Location = new System.Drawing.Point(196, 156);
            this.btn_Hesapla.Name = "btn_Hesapla";
            this.btn_Hesapla.Size = new System.Drawing.Size(100, 32);
            this.btn_Hesapla.TabIndex = 3;
            this.btn_Hesapla.Text = "Hesapla";
            this.btn_Hesapla.UseVisualStyleBackColor = true;
            this.btn_Hesapla.Click += new System.EventHandler(this.btn_Hesapla_Click);
            // 
            // lbl_Boy
            // 
            this.lbl_Boy.AutoSize = true;
            this.lbl_Boy.Location = new System.Drawing.Point(29, 52);
            this.lbl_Boy.Name = "lbl_Boy";
            this.lbl_Boy.Size = new System.Drawing.Size(161, 25);
            this.lbl_Boy.TabIndex = 4;
            this.lbl_Boy.Text = "Boyunuzu giriniz:";
            // 
            // lbl_Kilo
            // 
            this.lbl_Kilo.AutoSize = true;
            this.lbl_Kilo.Location = new System.Drawing.Point(26, 101);
            this.lbl_Kilo.Name = "lbl_Kilo";
            this.lbl_Kilo.Size = new System.Drawing.Size(149, 25);
            this.lbl_Kilo.TabIndex = 5;
            this.lbl_Kilo.Text = "Kilonuzu giriniz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(769, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "Aşağıdaki hesaplama aracında beden kitle endeksini öğrenmek istediğiniz kişinin s" +
    "antim\r\ncinsinden boyu ile kilogram cinsinden ağırlığını giriniz ve hesapla buton" +
    "una basınız.";
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(34, 156);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(75, 32);
            this.btn_Sil.TabIndex = 8;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Kilo);
            this.groupBox1.Controls.Add(this.btn_Sil);
            this.groupBox1.Controls.Add(this.lbl_Boy);
            this.groupBox1.Controls.Add(this.btn_Hesapla);
            this.groupBox1.Controls.Add(this.txt_BoyGirisi);
            this.groupBox1.Controls.Add(this.txt_KiloGirisi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(22, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 302);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vücut kitle indeksi hesaplama ";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImage = global::boy_Kilo_Indeksi.Properties.Resources.vucut_kitle_indeksi_780x4701;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.panel1.Location = new System.Drawing.Point(361, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 293);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(846, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Baslik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DockChanged += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Baslik;
        private System.Windows.Forms.TextBox txt_BoyGirisi;
        private System.Windows.Forms.TextBox txt_KiloGirisi;
        private System.Windows.Forms.Button btn_Hesapla;
        private System.Windows.Forms.Label lbl_Boy;
        private System.Windows.Forms.Label lbl_Kilo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

