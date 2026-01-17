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
    public partial class FormRandevularim : Form
    {
        SqlConnection baglanti = new SqlConnection("Server=.;Database=HastaneRandevuDB;Trusted_Connection=True;");
        public FormRandevularim()
        {
            InitializeComponent();
        }

        private void FormRandevularim_Load(object sender, EventArgs e)
        {
            int hastaID = (int)GirisBilgileri.HastaID;

            SqlDataAdapter da = new SqlDataAdapter(@"
                SELECT 
                    r.Tarih,
                    r.Saat,
                    d.AdSoyad AS Doktor,
                    b.BransAdi AS Brans
                FROM Randevular r
                INNER JOIN Doktorlar d ON r.DoktorID = d.DoktorID
                INNER JOIN Branslar b ON d.BransID = b.BransID
                WHERE r.HastaID = @id
                ORDER BY r.Tarih DESC, r.Saat", baglanti);

            da.SelectCommand.Parameters.AddWithValue("@id", hastaID);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }
    }
}
