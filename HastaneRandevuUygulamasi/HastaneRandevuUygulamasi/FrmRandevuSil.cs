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
    public partial class FrmRandevuSil : Form
    {
        public FrmRandevuSil()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=HastaneRandevuDB;Integrated Security=True;"))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Randevular WHERE RandevuID = @id", con);
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtRandevuID.Text));

                    con.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        lblDurum.Text = "Randevu silindi ve log’a kaydedildi.";
                    }
                    else
                    {
                        lblDurum.Text = "Silinecek randevu bulunamadı.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void FrmRandevuSil_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Server=.;Database=HastaneRandevuDB;Trusted_Connection=True;");

            SqlDataAdapter da = new SqlDataAdapter(@"
        SELECT RandevuID, HastaID, DoktorID, SilinmeZamani 
        FROM RandevuLog
        ORDER BY SilinmeZamani DESC", baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewLog.DataSource = dt;
        }
    }
}
