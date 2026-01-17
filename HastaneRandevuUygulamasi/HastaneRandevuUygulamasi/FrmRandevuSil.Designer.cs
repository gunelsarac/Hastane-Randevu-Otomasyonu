namespace HastaneRandevuUygulamasi
{
    partial class FrmRandevuSil
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.txtRandevuID = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridViewLog = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLog)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(627, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silinecek Randevu ID";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(656, 382);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(60, 16);
            this.lblDurum.TabIndex = 1;
            this.lblDurum.Text = "lblDurum";
            // 
            // txtRandevuID
            // 
            this.txtRandevuID.Location = new System.Drawing.Point(299, 324);
            this.txtRandevuID.Name = "txtRandevuID";
            this.txtRandevuID.Size = new System.Drawing.Size(100, 22);
            this.txtRandevuID.TabIndex = 2;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(299, 393);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dataGridViewLog
            // 
            this.dataGridViewLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLog.Location = new System.Drawing.Point(-1, 3);
            this.dataGridViewLog.Name = "dataGridViewLog";
            this.dataGridViewLog.RowHeadersWidth = 51;
            this.dataGridViewLog.RowTemplate.Height = 24;
            this.dataGridViewLog.Size = new System.Drawing.Size(778, 301);
            this.dataGridViewLog.TabIndex = 4;
            // 
            // FrmRandevuSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewLog);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtRandevuID);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.label1);
            this.Name = "FrmRandevuSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRandevuSil";
            this.Load += new System.EventHandler(this.FrmRandevuSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.TextBox txtRandevuID;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridViewLog;
    }
}