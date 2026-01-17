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
    public partial class FormDoktorRapor : Form
    {
        SqlConnection baglanti = new SqlConnection("Server=GÜNEL_Saraç;Database=HastaneRandevuDB;Trusted_Connection=True;");

        public FormDoktorRapor()
        {
            InitializeComponent();
        }
        void DoktorRandevuRaporu()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"
        SELECT 
            d.AdSoyad AS Doktor,
            COUNT(r.RandevuID) AS RandevuSayisi
        FROM Randevular r
        JOIN Doktorlar d ON r.DoktorID = d.DoktorID
        GROUP BY d.AdSoyad
        ORDER BY RandevuSayisi DESC
    ", baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormDoktorRapor_Load(object sender, EventArgs e)
        {
            DoktorRandevuRaporu();
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
