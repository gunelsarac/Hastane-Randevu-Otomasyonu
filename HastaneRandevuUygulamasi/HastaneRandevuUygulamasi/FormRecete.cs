using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuUygulamasi
{
    public partial class FormRecete : Form
    {
        SqlConnection baglanti = new SqlConnection("Server=GÜNEL_Saraç;Database=HastaneRandevuDB;Trusted_Connection=True;");

        public FormRecete()
        {
            InitializeComponent();
        }

        private void FormRecete_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(@"
        SELECT r.RandevuID, h.AdSoyad + ' - ' + d.AdSoyad + ' - ' + CONVERT(VARCHAR, r.Tarih) + ' ' + r.Saat AS Bilgi
        FROM Randevular r
        JOIN Hastalar h ON r.HastaID = h.HastaID
        JOIN Doktorlar d ON r.DoktorID = d.DoktorID", baglanti);

            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbRandevu.Items.Add(new ComboBoxItem
                {
                    Text = dr["Bilgi"].ToString(),
                    Value = dr["RandevuID"]
                });
            }
            baglanti.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbRandevu.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir randevu seç aşkım 💖");
                return;
            }

            int randevuID = ((ComboBoxItem)cmbRandevu.SelectedItem).Value is int id ? id : 0;

            SqlCommand komut = new SqlCommand("INSERT INTO Receteler (RandevuID, Ilac, Aciklama) VALUES (@r, @i, @a)", baglanti);
            komut.Parameters.AddWithValue("@r", randevuID);
            komut.Parameters.AddWithValue("@i", txtIlac.Text);
            komut.Parameters.AddWithValue("@a", rchAciklama.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Reçete kaydedildi ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAnaMenü_Click(object sender, EventArgs e)
        {
            var anaMenu = Application.OpenForms["Form1"];
            if (anaMenu != null)
            {
                anaMenu.Show();
            }
            else
            {
                Form1 frm = new Form1();
                frm.Show();
            }

            this.Close();
        }
    }
}
