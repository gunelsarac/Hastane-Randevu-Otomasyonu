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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Server=.;Database=HastaneRandevuDB;Trusted_Connection=True;");
            SqlCommand komut = new SqlCommand("SELECT Yetki, HastaID FROM Kullanicilar WHERE KullaniciAdi = @kadi AND Sifre = @sifre", baglanti);
            komut.Parameters.AddWithValue("@kadi", txtKullanici.Text);
            komut.Parameters.AddWithValue("@sifre", txtSifre.Text);

            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                GirisBilgileri.KullaniciAdi = txtKullanici.Text;
                GirisBilgileri.Yetki = dr["Yetki"].ToString();


                KullaniciBilgi.Rol = dr["Yetki"].ToString();  

                if (!dr.IsDBNull(dr.GetOrdinal("HastaID")))
                {
                    GirisBilgileri.HastaID = Convert.ToInt32(dr["HastaID"]);
                }

                baglanti.Close();

                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                baglanti.Close();
                MessageBox.Show("Hatalı giriş ");
            }
        }

        private void FormGiris_Load(object sender, EventArgs e)
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
