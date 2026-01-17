using System;
using System.Collections;
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
    public partial class FormRandevuListele : Form
    {
        SqlConnection baglanti = new SqlConnection("Server=.;Database=HastaneRandevuDB;Trusted_Connection=True;");

        public FormRandevuListele()
        {
            InitializeComponent();
        }
        void RandevulariListele()
        {
            string query = @"
        SELECT 
            r.RandevuID,
            h.AdSoyad AS Hasta,
            d.AdSoyad AS Doktor,
            b.BransAdi AS Brans,
            r.Tarih,
            r.Saat
        FROM Randevular r
        JOIN Hastalar h ON r.HastaID = h.HastaID
        JOIN Doktorlar d ON r.DoktorID = d.DoktorID
        JOIN Branslar b ON d.BransID = b.BransID";

            if (GirisBilgileri.Yetki == "hasta" && GirisBilgileri.HastaID.HasValue)
            {
                query += " WHERE r.HastaID = @hastaID";
            }

            SqlCommand komut = new SqlCommand(query, baglanti);

            if (GirisBilgileri.Yetki == "hasta" && GirisBilgileri.HastaID.HasValue)
            {
                komut.Parameters.AddWithValue("@hastaID", GirisBilgileri.HastaID.Value);
            }

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        int seciliRandevuID = -1;
        private void FormRandevuListele_Load(object sender, EventArgs e)
        {
            string[] saatler = { "09:00", "09:30", "10:00", "10:30", "11:00", "13:00", "13:30", "14:00", "14:30", "15:00" };
            cmbYeniSaat.Items.AddRange(saatler);
            RandevulariListele();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            RandevulariListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliRandevuID == -1)
            {
                MessageBox.Show("Lütfen önce silinecek randevuyu seçin.");
                return;
            }

            SqlCommand komut = new SqlCommand("sp_RandevuSil", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@RandevuID", seciliRandevuID);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Randevu silindi.");
            RandevulariListele(); 
            seciliRandevuID = -1;
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliRandevuID == -1)
            {
                MessageBox.Show("Lütfen önce güncellenecek randevuyu seçin.");
                return;
            }

            DateTime yeniTarih = dtYeniTarih.Value.Date;
            string yeniSaat = cmbYeniSaat.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(yeniSaat))
            {
                MessageBox.Show("Lütfen saat seçiniz.");
                return;
            }

            SqlCommand komut = new SqlCommand("sp_RandevuGuncelle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@RandevuID", seciliRandevuID);
            komut.Parameters.AddWithValue("@YeniTarih", yeniTarih);
            komut.Parameters.AddWithValue("@YeniSaat", yeniSaat);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Randevu güncellendi.");
            RandevulariListele();
            seciliRandevuID = -1;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    seciliRandevuID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                }
                else
                {
                    seciliRandevuID = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seçim hatası: " + ex.Message);
            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    seciliRandevuID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                }
                else
                {
                    seciliRandevuID = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seçim hatası: " + ex.Message);
            }
        }
    }
}
