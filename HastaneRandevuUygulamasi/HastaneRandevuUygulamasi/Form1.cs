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
using static HastaneRandevuUygulamasi.Program;


namespace HastaneRandevuUygulamasi
{
    

    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Server=GÜNEL_Saraç;Database=HastaneRandevuDB;Trusted_Connection=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblKullanici.Text = "Hoş geldin, " + GirisBilgileri.KullaniciAdi;
             


            if (KullaniciBilgi.Rol?.ToLower() == "kullanici" || KullaniciBilgi.Rol?.ToLower() == "hasta")
            {
               
                button1.Visible = false;             
                DoktorRandevuRaporu.Visible = false;
                btnRecete.Visible = false;
                btnHastaEkle.Visible = false;
                btnRandevuListesi.Visible = false;
                btnRandevuSil.Visible = false;
                btnBransRapor.Visible = false;
                btnDoktorEkle.Visible = false;
                btnRandevuSayisiGoster.Visible = false;
                btnRandevularim.Visible = true;
            }
            btnRandevularim.Visible = (KullaniciBilgi.Rol == "admin");

        }

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            FormHastaEkle frm = new FormHastaEkle();
            frm.Show();
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            FormDoktorEkle frm = new FormDoktorEkle();
            frm.Show();
        }

        private void btnRandevual_Click(object sender, EventArgs e)
        {
            FormRandevuAl frm = new FormRandevuAl();
            frm.Show();
        }

        private void btnRandevuListesi_Click(object sender, EventArgs e)
        {
            FormRandevuListele frm = new FormRandevuListele();
            frm.Show();
        }

        private void btnKullanıcıGiris_Click(object sender, EventArgs e)
        {

        }

        private void btnRecete_Click(object sender, EventArgs e)
        {
            FormReceteListele frm = new FormReceteListele();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDoktorRapor frm = new FormDoktorRapor();
            frm.Show();
        }

        private void btnBransRapor_Click(object sender, EventArgs e)
        {
            FormBransRapor frm = new FormBransRapor();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormProsedurTest frm = new FormProsedurTest();
            frm.Show();
        }

        private void btnRandevuSayisiGoster_Click(object sender, EventArgs e)
        {
            FrmRandevuSayisiSorgula frm = new FrmRandevuSayisiSorgula();
            frm.Show();
        }

        private void btnRandevuSil_Click(object sender, EventArgs e)
        {
            FrmRandevuSil frm = new FrmRandevuSil();
            frm.Show();
        }

        private void btnRandevularim_Click(object sender, EventArgs e)
        {
            FormRandevularim frm = new FormRandevularim();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmRandevuView frm = new FrmRandevuView();
            frm.Show();

        }
    }
}
