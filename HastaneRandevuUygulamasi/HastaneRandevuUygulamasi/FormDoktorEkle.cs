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
    public partial class FormDoktorEkle : Form
    {
        public FormDoktorEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=.;Database=HastaneRandevuDB;Trusted_Connection=True;");


        public class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }


        private void FormDoktorEkle_Load(object sender, EventArgs e)
        {
           
            cmbBrans.Items.Clear();
            SqlCommand komut1 = new SqlCommand("SELECT * FROM Branslar", baglanti);
            baglanti.Open();
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                cmbBrans.Items.Add(new ComboBoxItem
                {
                    Text = dr1["BransAdi"].ToString(),
                    Value = dr1["BransID"]
                });
            }
            baglanti.Close();

            
            cmbOda.Items.Clear();
            SqlCommand komut2 = new SqlCommand("SELECT * FROM Odalar", baglanti);
            baglanti.Open();
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbOda.Items.Add(new ComboBoxItem
                {
                    Text = $"Kat {dr2["KatNo"]} - Oda {dr2["OdaNo"]}",
                    Value = dr2["OdaID"]
                });
            }
            baglanti.Close();
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int bransID = ((ComboBoxItem)cmbBrans.SelectedItem).Value is int val1 ? val1 : 0;
            int odaID = ((ComboBoxItem)cmbOda.SelectedItem).Value is int val2 ? val2 : 0;

            SqlCommand komut = new SqlCommand("INSERT INTO Doktorlar (AdSoyad, BransID, OdaID) VALUES (@ad, @brans, @oda)", baglanti);
            komut.Parameters.AddWithValue("@ad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@brans", bransID);
            komut.Parameters.AddWithValue("@oda", odaID);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Doktor başarıyla eklendi ");
            txtAdSoyad.Clear();
            cmbBrans.SelectedIndex = -1;
            cmbOda.SelectedIndex = -1;
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
