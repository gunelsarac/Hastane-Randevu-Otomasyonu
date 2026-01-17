namespace HastaneRandevuUygulamasi
{
    partial class FormRecete
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
            this.cmbRandevu = new System.Windows.Forms.ComboBox();
            this.txtIlac = new System.Windows.Forms.TextBox();
            this.rchAciklama = new System.Windows.Forms.RichTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnAnaMenü = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbRandevu
            // 
            this.cmbRandevu.FormattingEnabled = true;
            this.cmbRandevu.Location = new System.Drawing.Point(317, 12);
            this.cmbRandevu.Name = "cmbRandevu";
            this.cmbRandevu.Size = new System.Drawing.Size(121, 24);
            this.cmbRandevu.TabIndex = 0;
            // 
            // txtIlac
            // 
            this.txtIlac.Location = new System.Drawing.Point(317, 83);
            this.txtIlac.Name = "txtIlac";
            this.txtIlac.Size = new System.Drawing.Size(100, 22);
            this.txtIlac.TabIndex = 1;
            // 
            // rchAciklama
            // 
            this.rchAciklama.Location = new System.Drawing.Point(317, 151);
            this.rchAciklama.Name = "rchAciklama";
            this.rchAciklama.Size = new System.Drawing.Size(100, 96);
            this.rchAciklama.TabIndex = 2;
            this.rchAciklama.Text = "";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(317, 325);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(121, 63);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnAnaMenü
            // 
            this.btnAnaMenü.Location = new System.Drawing.Point(559, 325);
            this.btnAnaMenü.Name = "btnAnaMenü";
            this.btnAnaMenü.Size = new System.Drawing.Size(125, 63);
            this.btnAnaMenü.TabIndex = 4;
            this.btnAnaMenü.Text = "Ana Menü";
            this.btnAnaMenü.UseVisualStyleBackColor = true;
            this.btnAnaMenü.Click += new System.EventHandler(this.btnAnaMenü_Click);
            // 
            // FormRecete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnaMenü);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.rchAciklama);
            this.Controls.Add(this.txtIlac);
            this.Controls.Add(this.cmbRandevu);
            this.Name = "FormRecete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRecete";
            this.Load += new System.EventHandler(this.FormRecete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRandevu;
        private System.Windows.Forms.TextBox txtIlac;
        private System.Windows.Forms.RichTextBox rchAciklama;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnAnaMenü;
    }
}