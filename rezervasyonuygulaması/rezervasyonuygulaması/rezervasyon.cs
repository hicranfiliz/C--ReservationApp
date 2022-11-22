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

namespace rezervasyonuygulaması
{
    public partial class rezervasyon : Form
    {
        public rezervasyon()
        {
            InitializeComponent();
        }
        public static string Nereden = "";
        public static string Nereye = "";
        public static string GidisTarihi = "";
        public static string DonusTarihi = "";
        public string kulad = Form1.KullaniciAd;

        Database db = new Database();
        private void button1_Click(object sender, EventArgs e)
        {
            db.baglanti.Open();
            SqlCommand komut = new SqlCommand("update tblmusteri set MGidisTarihi=@p1,MDonusTarihi=@p2,MNereden=@p3,MNereye=@p4,MUlasim=@p5,MKonaklama=@p6 where MKullaniciAd=@p7", db.baglanti);
            komut.Parameters.AddWithValue("@p1", pickergidis.Value.Date);
            komut.Parameters.AddWithValue("@p2", pickerdonus.Value.Date);
            komut.Parameters.AddWithValue("@p3", cmbnereden.Text);
            komut.Parameters.AddWithValue("@p4", cmbnereye.Text);
            komut.Parameters.AddWithValue("@p5", cmbulasim.Text);
            komut.Parameters.AddWithValue("@p6", cmbkonaklama.Text);
            komut.Parameters.AddWithValue("@p7", kulad);
            komut.ExecuteNonQuery();
            MessageBox.Show("Rezervasyon kaydedildi..");
            ödemebilgileri ödemebilgileri = new ödemebilgileri();
            ödemebilgileri.Show();
            this.Hide();
            Nereden = cmbnereden.Text;
            Nereye = cmbnereye.Text;
            GidisTarihi = pickergidis.Value.Date.ToString();
            DonusTarihi = pickerdonus.Value.Date.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Otel o = new Otel();
            //o.Konakla();
            //cmboteller.Items.Add(o.Konakla);
           


           

        }

        private void rezervasyon_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbkonaklama_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbkonaklama.SelectedIndex == 0)
            {
                Otel o = new Otel();
                o.Konakla();
            }
            else if (cmbkonaklama.SelectedIndex == 1)
            {
                Cadir c = new Cadir();
                c.Konakla();
            }
        }

        private void cmbulasim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbulasim.SelectedIndex == 0)
            {
                Ucak u = new Ucak();
                u.Ulas();
            }
            else if (cmbulasim.SelectedIndex == 1)
            {
                Otobus oto = new Otobus();
                oto.Ulas();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            reziptal rez = new reziptal();
            rez.Show();
            this.Hide();
        }
    }
}
