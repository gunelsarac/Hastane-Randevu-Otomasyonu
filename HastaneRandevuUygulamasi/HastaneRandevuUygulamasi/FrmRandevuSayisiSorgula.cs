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
    public partial class FrmRandevuSayisiSorgula : Form
    {
        public FrmRandevuSayisiSorgula()
        {
            InitializeComponent();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Server=GÜNEL_Saraç;Database=HastaneRandevuDB;Trusted_Connection=True;"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT dbo.GetDoctorAppointmentCount(@DoctorID, @Date)", con);
                    cmd.Parameters.AddWithValue("@DoctorID", int.Parse(txtDoktorID.Text));
                    cmd.Parameters.AddWithValue("@Date", dtpTarih.Value.Date);

                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    lblSonuc.Text = "Toplam randevu sayısı: " + count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void FrmRandevuSayisiSorgula_Load(object sender, EventArgs e)
        {

        }
    }
}
