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
    public partial class FormProsedurTest : Form
    {
        public FormProsedurTest()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=.;Database=HastaneRandevuDB;Trusted_Connection=True;");
        private void FormProsedurTest_Load(object sender, EventArgs e)
        {
            string[] saatler = { "09:00", "09:30", "10:00", "10:30", "11:00", "13:00", "13:30", "14:00", "14:30" };
            cmbSaat.Items.AddRange(saatler);
            RandevulariYenile();
        }
        void RandevulariYenile()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"
        SELECT r.RandevuID, h.AdSoyad AS Hasta, d.AdSoyad AS Doktor, r.Tarih, r.Saat
        FROM Randevular r
        JOIN Hastalar h ON h.HastaID = r.HastaID
        JOIN Doktorlar d ON d.DoktorID = r.DoktorID
        ORDER BY r.Tarih DESC", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbSaat.SelectedItem == null)
            {
                MessageBox.Show("Lütfen saat seçin.");
                return;
            }

            if (!int.TryParse(txtHastaID.Text, out int hastaID))
            {
                MessageBox.Show("Geçerli bir Hasta ID girin.");
                return;
            }
            if (!int.TryParse(txtDoktorID.Text, out int doktorID))
            {
                MessageBox.Show("Geçerli bir Doktor ID girin.");
                return;
            }

            SqlCommand komut = new SqlCommand("sp_RandevuEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@HastaID", int.Parse(txtHastaID.Text));
            komut.Parameters.AddWithValue("@DoktorID", int.Parse(txtDoktorID.Text));
            komut.Parameters.AddWithValue("@Tarih", dtTarih.Value.Date);
            komut.Parameters.AddWithValue("@Saat", TimeSpan.Parse(cmbSaat.SelectedItem.ToString()));


            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Randevu eklendi (SP)");
            RandevulariYenile();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            SqlCommand komut = new SqlCommand("sp_RandevuSil", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@RandevuID", id);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Randevu silindi (SP)");
            RandevulariYenile();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            SqlCommand komut = new SqlCommand("sp_RandevuGuncelle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@RandevuID", id);
            komut.Parameters.AddWithValue("@YeniTarih", dtTarih.Value.Date);
            komut.Parameters.AddWithValue("@YeniSaat", cmbSaat.SelectedItem.ToString());

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Randevu güncellendi (SP)");
            RandevulariYenile();
        }
    }
}
