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
    public partial class FormHastaListele : Form
    {
        SqlConnection baglanti = new SqlConnection("Server=.;Database=HastaneRandevuDB;Trusted_Connection=True;");

        public FormHastaListele()
        {
            InitializeComponent();
        }
        void HastaListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hastalar", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FormHastaListele_Load(object sender, EventArgs e)
        {
            HastaListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilen].Cells["HastaID"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.Rows[secilen].Cells["AdSoyad"].Value.ToString();
            txtTC.Text = dataGridView1.Rows[secilen].Cells["TcKimlikNo"].Value.ToString();
            dtDogumTarihi.Value = Convert.ToDateTime(dataGridView1.Rows[secilen].Cells["DogumTarihi"].Value);
            mskTelefon.Text = dataGridView1.Rows[secilen].Cells["Telefon"].Value.ToString();
            cmbCinsiyet.Text = dataGridView1.Rows[secilen].Cells["Cinsiyet"].Value.ToString();
            cmbKanGrubu.Text = dataGridView1.Rows[secilen].Cells["KanGrubu"].Value.ToString();
            rchAdres.Text = dataGridView1.Rows[secilen].Cells["Adres"].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[secilen].Cells["Email"].Value.ToString();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM Hastalar WHERE HastaID = @id", baglanti);
            komut.Parameters.AddWithValue("@id", txtID.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hasta silindi.");
            HastaListele(); // Güncelle list
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand(@"
            UPDATE Hastalar
            SET 
                AdSoyad = @ad,
                TcKimlikNo = @tc,
                DogumTarihi = @dt,
                Telefon = @tel,
                Cinsiyet = @cins,
                KanGrubu = @kan,
                Adres = @adres,
                Email = @mail
            WHERE HastaID = @id", baglanti);

                komut.Parameters.AddWithValue("@ad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@tc", txtTC.Text);
                komut.Parameters.AddWithValue("@dt", dtDogumTarihi.Value);
                komut.Parameters.AddWithValue("@tel", mskTelefon.Text);
                komut.Parameters.AddWithValue("@cins", cmbCinsiyet.Text);
                komut.Parameters.AddWithValue("@kan", cmbKanGrubu.Text);
                komut.Parameters.AddWithValue("@adres", rchAdres.Text);
                komut.Parameters.AddWithValue("@mail", txtEmail.Text);
                komut.Parameters.AddWithValue("@id", txtID.Text); 

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Hasta bilgileri başarıyla güncellendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oldu : " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
