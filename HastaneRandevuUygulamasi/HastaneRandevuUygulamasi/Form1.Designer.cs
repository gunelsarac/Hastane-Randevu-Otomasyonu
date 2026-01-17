namespace HastaneRandevuUygulamasi
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
            this.btnHastaEkle = new System.Windows.Forms.Button();
            this.btnDoktorEkle = new System.Windows.Forms.Button();
            this.btnRandevual = new System.Windows.Forms.Button();
            this.btnRandevuListesi = new System.Windows.Forms.Button();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.btnRecete = new System.Windows.Forms.Button();
            this.DoktorRandevuRaporu = new System.Windows.Forms.Button();
            this.btnBransRapor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRandevuSayisiGoster = new System.Windows.Forms.Button();
            this.btnRandevuSil = new System.Windows.Forms.Button();
            this.btnRandevularim = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHastaEkle
            // 
            this.btnHastaEkle.Location = new System.Drawing.Point(20, 373);
            this.btnHastaEkle.Name = "btnHastaEkle";
            this.btnHastaEkle.Size = new System.Drawing.Size(86, 65);
            this.btnHastaEkle.TabIndex = 0;
            this.btnHastaEkle.Text = "Hasta Ekle";
            this.btnHastaEkle.UseVisualStyleBackColor = true;
            this.btnHastaEkle.Click += new System.EventHandler(this.btnHastaEkle_Click);
            // 
            // btnDoktorEkle
            // 
            this.btnDoktorEkle.Location = new System.Drawing.Point(263, 373);
            this.btnDoktorEkle.Name = "btnDoktorEkle";
            this.btnDoktorEkle.Size = new System.Drawing.Size(104, 52);
            this.btnDoktorEkle.TabIndex = 1;
            this.btnDoktorEkle.Text = "Doktor Ekle";
            this.btnDoktorEkle.UseVisualStyleBackColor = true;
            this.btnDoktorEkle.Click += new System.EventHandler(this.btnDoktorEkle_Click);
            // 
            // btnRandevual
            // 
            this.btnRandevual.Location = new System.Drawing.Point(267, 229);
            this.btnRandevual.Name = "btnRandevual";
            this.btnRandevual.Size = new System.Drawing.Size(104, 50);
            this.btnRandevual.TabIndex = 2;
            this.btnRandevual.Text = "Randevu Al\r\n";
            this.btnRandevual.UseVisualStyleBackColor = true;
            this.btnRandevual.Click += new System.EventHandler(this.btnRandevual_Click);
            // 
            // btnRandevuListesi
            // 
            this.btnRandevuListesi.Location = new System.Drawing.Point(267, 301);
            this.btnRandevuListesi.Name = "btnRandevuListesi";
            this.btnRandevuListesi.Size = new System.Drawing.Size(104, 49);
            this.btnRandevuListesi.TabIndex = 3;
            this.btnRandevuListesi.Text = "Randevu Listesi";
            this.btnRandevuListesi.UseVisualStyleBackColor = true;
            this.btnRandevuListesi.Click += new System.EventHandler(this.btnRandevuListesi_Click);
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Location = new System.Drawing.Point(26, 20);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(44, 16);
            this.lblKullanici.TabIndex = 4;
            this.lblKullanici.Text = "label1";
            // 
            // btnRecete
            // 
            this.btnRecete.Location = new System.Drawing.Point(20, 300);
            this.btnRecete.Name = "btnRecete";
            this.btnRecete.Size = new System.Drawing.Size(86, 50);
            this.btnRecete.TabIndex = 5;
            this.btnRecete.Text = "Reçeteler";
            this.btnRecete.UseVisualStyleBackColor = true;
            this.btnRecete.Click += new System.EventHandler(this.btnRecete_Click);
            // 
            // DoktorRandevuRaporu
            // 
            this.DoktorRandevuRaporu.Location = new System.Drawing.Point(12, 229);
            this.DoktorRandevuRaporu.Name = "DoktorRandevuRaporu";
            this.DoktorRandevuRaporu.Size = new System.Drawing.Size(83, 50);
            this.DoktorRandevuRaporu.TabIndex = 6;
            this.DoktorRandevuRaporu.Text = "Doktor Rapor";
            this.DoktorRandevuRaporu.UseVisualStyleBackColor = true;
            this.DoktorRandevuRaporu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBransRapor
            // 
            this.btnBransRapor.Location = new System.Drawing.Point(144, 373);
            this.btnBransRapor.Name = "btnBransRapor";
            this.btnBransRapor.Size = new System.Drawing.Size(94, 65);
            this.btnBransRapor.TabIndex = 7;
            this.btnBransRapor.Text = "Brans Rapor";
            this.btnBransRapor.UseVisualStyleBackColor = true;
            this.btnBransRapor.Click += new System.EventHandler(this.btnBransRapor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hastane Randevu Sistemi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 67);
            this.button1.TabIndex = 10;
            this.button1.Text = "Stored Procedure Testi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnRandevuSayisiGoster
            // 
            this.btnRandevuSayisiGoster.Location = new System.Drawing.Point(144, 229);
            this.btnRandevuSayisiGoster.Name = "btnRandevuSayisiGoster";
            this.btnRandevuSayisiGoster.Size = new System.Drawing.Size(92, 50);
            this.btnRandevuSayisiGoster.TabIndex = 11;
            this.btnRandevuSayisiGoster.Text = "Randevu Sayısı Sorgula";
            this.btnRandevuSayisiGoster.UseVisualStyleBackColor = true;
            this.btnRandevuSayisiGoster.Click += new System.EventHandler(this.btnRandevuSayisiGoster_Click);
            // 
            // btnRandevuSil
            // 
            this.btnRandevuSil.Location = new System.Drawing.Point(144, 300);
            this.btnRandevuSil.Name = "btnRandevuSil";
            this.btnRandevuSil.Size = new System.Drawing.Size(83, 50);
            this.btnRandevuSil.TabIndex = 12;
            this.btnRandevuSil.Text = "Randevu Sil";
            this.btnRandevuSil.UseVisualStyleBackColor = true;
            this.btnRandevuSil.Click += new System.EventHandler(this.btnRandevuSil_Click);
            // 
            // btnRandevularim
            // 
            this.btnRandevularim.Location = new System.Drawing.Point(258, 128);
            this.btnRandevularim.Name = "btnRandevularim";
            this.btnRandevularim.Size = new System.Drawing.Size(113, 53);
            this.btnRandevularim.TabIndex = 13;
            this.btnRandevularim.Text = "Randevularım";
            this.btnRandevularim.UseVisualStyleBackColor = true;
            this.btnRandevularim.Click += new System.EventHandler(this.btnRandevularim_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 55);
            this.button2.TabIndex = 14;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HastaneRandevuUygulamasi.Properties.Resources.ChatGPT_Image_25_Nis_2025_18_20_46;
            this.pictureBox1.Location = new System.Drawing.Point(373, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRandevularim);
            this.Controls.Add(this.btnRandevuSil);
            this.Controls.Add(this.btnRandevuSayisiGoster);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBransRapor);
            this.Controls.Add(this.DoktorRandevuRaporu);
            this.Controls.Add(this.btnRecete);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.btnRandevuListesi);
            this.Controls.Add(this.btnRandevual);
            this.Controls.Add(this.btnDoktorEkle);
            this.Controls.Add(this.btnHastaEkle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHastaEkle;
        private System.Windows.Forms.Button btnDoktorEkle;
        private System.Windows.Forms.Button btnRandevual;
        private System.Windows.Forms.Button btnRandevuListesi;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Button btnRecete;
        private System.Windows.Forms.Button DoktorRandevuRaporu;
        private System.Windows.Forms.Button btnBransRapor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRandevuSayisiGoster;
        private System.Windows.Forms.Button btnRandevuSil;
        private System.Windows.Forms.Button btnRandevularim;
        private System.Windows.Forms.Button button2;
    }
}

