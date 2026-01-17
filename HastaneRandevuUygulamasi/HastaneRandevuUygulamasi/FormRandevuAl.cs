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
    public partial class FormRandevuAl : Form
    {
        SqlConnection baglanti = new SqlConnection("Server=GÜNEL_Saraç;Database=HastaneRandevuDB;Trusted_Connection=True;");

        public FormRandevuAl()
        {
            InitializeComponent();
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }


        private void FormRandevuAl_Load(object sender, EventArgs e)
        {
            btnKaydet.Visible = false; 
            
            SqlCommand komut1 = new SqlCommand("SELECT * FROM Hastalar", baglanti);
            baglanti.Open();
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                cmbHasta.Items.Add(new ComboBoxItem
                {
                    Text = dr1["AdSoyad"].ToString(),
                    Value = dr1["HastaID"]
                });
            }
            baglanti.Close();

            
            SqlCommand komut2 = new SqlCommand("SELECT d.DoktorID, d.AdSoyad, b.BransAdi FROM Doktorlar d INNER JOIN Branslar b ON d.BransID = b.BransID", baglanti);
            baglanti.Open();
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbDoktor.Items.Add(new ComboBoxItem
                {
                    Text = dr2["AdSoyad"].ToString() + " - " + dr2["BransAdi"].ToString(),
                    Value = dr2["DoktorID"]
                });
            }
            baglanti.Close();

            
            string[] saatler = { "09:00", "09:30", "10:00", "10:30", "11:00", "13:00", "13:30", "14:00", "14:30", "15:00" };
            cmbSaat.Items.AddRange(saatler);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int hastaID = ((ComboBoxItem)cmbHasta.SelectedItem).Value is int val1 ? val1 : 0;
            int doktorID = ((ComboBoxItem)cmbDoktor.SelectedItem).Value is int val2 ? val2 : 0;
            string saat = cmbSaat.SelectedItem.ToString();
            DateTime tarih = dtTarih.Value.Date;

            
            SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM Randevular WHERE DoktorID = @d AND Tarih = @t AND Saat = @s", baglanti);
            kontrolKomut.Parameters.AddWithValue("@d", doktorID);
            kontrolKomut.Parameters.AddWithValue("@t", tarih);
            kontrolKomut.Parameters.AddWithValue("@s", saat);

            baglanti.Open();
            int randevuSayisi = (int)kontrolKomut.ExecuteScalar();
            baglanti.Close();

            if (randevuSayisi > 0)
            {
                MessageBox.Show("Bu doktor bu saatte zaten dolu Lütfen başka bir saat seç ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            SqlCommand komut = new SqlCommand("INSERT INTO Randevular (HastaID, DoktorID, Tarih, Saat) VALUES (@h, @d, @t, @s)", baglanti);
            komut.Parameters.AddWithValue("@h", hastaID);
            komut.Parameters.AddWithValue("@d", doktorID);
            komut.Parameters.AddWithValue("@t", tarih);
            komut.Parameters.AddWithValue("@s", saat);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Randevu başarıyla alındı ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmbHasta.SelectedIndex = -1;
            cmbDoktor.SelectedIndex = -1;
            cmbSaat.SelectedIndex = -1;
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

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            if (cmbDoktor.SelectedItem == null || cmbSaat.SelectedItem == null)
            {
                MessageBox.Show("Lütfen doktor ve saat seçiniz.");
                return;
            }

            int hastaID;

            if (KullaniciBilgi.Rol.ToLower() == "admin")

            {
                if (cmbHasta.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir hasta seçiniz.");
                    return;
                }

                hastaID = (int)((ComboBoxItem)cmbHasta.SelectedItem).Value;
            }
            else
            {
                hastaID = (int)GirisBilgileri.HastaID;
            }

            int doktorID = ((ComboBoxItem)cmbDoktor.SelectedItem).Value is int val ? val : 0;
            DateTime secilenTarih = dtTarih.Value.Date;
            string secilenSaat = cmbSaat.SelectedItem.ToString();

            SqlConnection baglanti = new SqlConnection("Server=.;Database=HastaneRandevuDB;Trusted_Connection=True;");
            SqlCommand komut = new SqlCommand("sp_RandevuEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@HastaID", hastaID);
            komut.Parameters.AddWithValue("@DoktorID", doktorID);
            komut.Parameters.AddWithValue("@Tarih", secilenTarih);
            komut.Parameters.AddWithValue("@Saat", secilenSaat);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Randevu başarıyla alındı.");
        }
    }
}
