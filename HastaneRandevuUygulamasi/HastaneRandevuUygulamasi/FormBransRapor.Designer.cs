namespace HastaneRandevuUygulamasi
{
    partial class FormBransRapor
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
            this.lblBrans = new System.Windows.Forms.Label();
            this.bntAnaMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBrans
            // 
            this.lblBrans.AutoSize = true;
            this.lblBrans.Location = new System.Drawing.Point(313, 82);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(56, 16);
            this.lblBrans.TabIndex = 0;
            this.lblBrans.Text = "lblBrans";
            // 
            // bntAnaMenu
            // 
            this.bntAnaMenu.Location = new System.Drawing.Point(647, 349);
            this.bntAnaMenu.Name = "bntAnaMenu";
            this.bntAnaMenu.Size = new System.Drawing.Size(141, 89);
            this.bntAnaMenu.TabIndex = 1;
            this.bntAnaMenu.Text = "Ana Menü";
            this.bntAnaMenu.UseVisualStyleBackColor = true;
            this.bntAnaMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBransRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntAnaMenu);
            this.Controls.Add(this.lblBrans);
            this.Name = "FormBransRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBransRapor";
            this.Load += new System.EventHandler(this.FormBransRapor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrans;
        private System.Windows.Forms.Button bntAnaMenu;
    }
}