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
    public partial class FormReceteListele : Form
    {
        public FormReceteListele()
        {
            InitializeComponent();
        }
        int seciliReceteID = -1;
        SqlConnection baglanti = new SqlConnection("Server=.;Database=HastaneRandevuDB;Trusted_Connection=True;");
        void ReceteleriListele()
        {
            string query = @"
        SELECT 
            re.ReceteID,
            h.AdSoyad AS Hasta,
            d.AdSoyad AS Doktor,
            re.Ilac,
            re.Aciklama
        FROM Receteler re
        JOIN Randevular r ON re.RandevuID = r.RandevuID
        JOIN Hastalar h ON r.HastaID = h.HastaID
        JOIN Doktorlar d ON r.DoktorID = d.DoktorID";

            
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


        private void FormReceteListele_Load(object sender, EventArgs e)
        {
            ReceteleriListele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                seciliReceteID = Convert.ToInt32(row.Cells[0].Value);
                txtIlac.Text = row.Cells["Ilac"].Value.ToString();
                rchAciklama.Text = row.Cells["Aciklama"].Value.ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliReceteID == -1)
            {
                MessageBox.Show("Lütfen bir reçete seç ");
                return;
            }

            SqlCommand komut = new SqlCommand("UPDATE Receteler SET Ilac = @i, Aciklama = @a WHERE ReceteID = @id", baglanti);
            komut.Parameters.AddWithValue("@i", txtIlac.Text);
            komut.Parameters.AddWithValue("@a", rchAciklama.Text);
            komut.Parameters.AddWithValue("@id", seciliReceteID);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Reçete güncellendi");
            ReceteleriListele();
            seciliReceteID = -1;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliReceteID == -1)
            {
                MessageBox.Show("Reçete seç");
                return;
            }

            SqlCommand komut = new SqlCommand("DELETE FROM Receteler WHERE ReceteID = @id", baglanti);
            komut.Parameters.AddWithValue("@id", seciliReceteID);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Reçete silindi ");
            ReceteleriListele();
            seciliReceteID = -1;
        }
        
        private void txtIlac_TextChanged(object sender, EventArgs e)
        {

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
