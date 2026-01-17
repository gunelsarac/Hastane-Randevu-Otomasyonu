using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneRandevuUygulamasi
{
    public partial class FormHastaEkle : Form
    {
        SqlConnection baglanti = new SqlConnection("Server=.;Database=HastaneRandevuDB;Trusted_Connection=True;");

        public FormHastaEkle()
        {
            InitializeComponent();
        }

        private void FormHastaEkle_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.Add("Erkek");
            cmbCinsiyet.Items.Add("Kadın");

            cmbKanGrubu.Items.Add("A+");
            cmbKanGrubu.Items.Add("A-");
            cmbKanGrubu.Items.Add("B+");
            cmbKanGrubu.Items.Add("B-");
            cmbKanGrubu.Items.Add("AB+");
            cmbKanGrubu.Items.Add("AB-");
            cmbKanGrubu.Items.Add("0+");
            cmbKanGrubu.Items.Add("0-");


            btnKaydet.BackColor = Color.WhiteSmoke;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            btnKaydet.ForeColor = Color.DarkSlateGray;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(@"INSERT INTO Hastalar 
(AdSoyad, TcKimlikNo, DogumTarihi, Telefon, Cinsiyet, KanGrubu, Adres, Email, KayitTarihi) 
VALUES (@ad, @tc, @dt, @tel, @cins, @kan, @adres, @mail, @kayit)", baglanti);

                komut.Parameters.AddWithValue("@ad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@tc", txtTC.Text);
                komut.Parameters.AddWithValue("@dt", dtDogumTarihi.Value);
                komut.Parameters.AddWithValue("@tel", mskTelefon.Text);
                komut.Parameters.AddWithValue("@cins", cmbCinsiyet.Text);
                komut.Parameters.AddWithValue("@kan", cmbKanGrubu.Text);
                komut.Parameters.AddWithValue("@adres", rchAdres.Text);
                komut.Parameters.AddWithValue("@mail", txtEmail.Text);
                komut.Parameters.AddWithValue("@kayit", DateTime.Now);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Hasta başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DateTime kayitTarihi = DateTime.Now;


                txtAdSoyad.Clear();
                txtTC.Clear();
                mskTelefon.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
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
    }
}
