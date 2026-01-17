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
    public partial class FormBransRapor : Form
    {
        SqlConnection baglanti = new SqlConnection("Server=GÜNEL_Saraç;Database=HastaneRandevuDB;Trusted_Connection=True;");

        public FormBransRapor()
        {
            InitializeComponent();
        }

        private void FormBransRapor_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(@"
        SELECT TOP 1 
            b.BransAdi,
            COUNT(r.RandevuID) AS RandevuSayisi
        FROM Randevular r
        JOIN Doktorlar d ON r.DoktorID = d.DoktorID
        JOIN Branslar b ON d.BransID = b.BransID
        GROUP BY b.BransAdi
        ORDER BY RandevuSayisi DESC
    ", baglanti);

            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                lblBrans.Text = "En yoğun branş: " + dr["BransAdi"].ToString() + " (" + dr["RandevuSayisi"].ToString() + " randevu)";
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
