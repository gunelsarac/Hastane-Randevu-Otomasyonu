namespace HastaneRandevuUygulamasi
{
    partial class FormHastaEkle
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
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.dtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.cmbKanGrubu = new System.Windows.Forms.ComboBox();
            this.rchAdres = new System.Windows.Forms.RichTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAnaMenü = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(227, 63);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtAdSoyad.TabIndex = 0;
            this.txtAdSoyad.Text = "Ad Soyad";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(227, 91);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 22);
            this.txtTC.TabIndex = 1;
            this.txtTC.Text = "TC Kimlik No";
            // 
            // dtDogumTarihi
            // 
            this.dtDogumTarihi.Location = new System.Drawing.Point(227, 285);
            this.dtDogumTarihi.Name = "dtDogumTarihi";
            this.dtDogumTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtDogumTarihi.TabIndex = 2;
            this.dtDogumTarihi.Tag = "";
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(227, 244);
            this.mskTelefon.Mask = "000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(100, 22);
            this.mskTelefon.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(246, 353);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(96, 63);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet Butonu";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(227, 129);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(121, 24);
            this.cmbCinsiyet.TabIndex = 5;
            this.cmbCinsiyet.Text = "Cinsiyet";
            // 
            // cmbKanGrubu
            // 
            this.cmbKanGrubu.FormattingEnabled = true;
            this.cmbKanGrubu.Location = new System.Drawing.Point(227, 195);
            this.cmbKanGrubu.Name = "cmbKanGrubu";
            this.cmbKanGrubu.Size = new System.Drawing.Size(121, 24);
            this.cmbKanGrubu.TabIndex = 6;
            this.cmbKanGrubu.Text = "Kan Grubu";
            // 
            // rchAdres
            // 
            this.rchAdres.Location = new System.Drawing.Point(559, 108);
            this.rchAdres.Name = "rchAdres";
            this.rchAdres.Size = new System.Drawing.Size(100, 96);
            this.rchAdres.TabIndex = 7;
            this.rchAdres.Text = "Adres";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(559, 261);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Text = "E-posta";
            // 
            // btnAnaMenü
            // 
            this.btnAnaMenü.Location = new System.Drawing.Point(627, 353);
            this.btnAnaMenü.Name = "btnAnaMenü";
            this.btnAnaMenü.Size = new System.Drawing.Size(125, 63);
            this.btnAnaMenü.TabIndex = 9;
            this.btnAnaMenü.Text = "Ana Menü";
            this.btnAnaMenü.UseVisualStyleBackColor = true;
            this.btnAnaMenü.Click += new System.EventHandler(this.btnAnaMenü_Click);
            // 
            // FormHastaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnaMenü);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.rchAdres);
            this.Controls.Add(this.cmbKanGrubu);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.dtDogumTarihi);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtAdSoyad);
            this.Name = "FormHastaEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHastaEkle";
            this.Load += new System.EventHandler(this.FormHastaEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.DateTimePicker dtDogumTarihi;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.ComboBox cmbKanGrubu;
        private System.Windows.Forms.RichTextBox rchAdres;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAnaMenü;
    }
}