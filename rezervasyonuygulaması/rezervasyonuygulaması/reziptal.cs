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

namespace rezervasyonuygulaması
{
    public partial class reziptal : Form
    {
        public reziptal()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void reziptal_Load(object sender, EventArgs e)
        {
            db.baglanti.Open();
            string Query = "select * from tblmusteri where MKullaniciAd="+Form1.KullaniciAd+"";

            SqlDataAdapter sda = new SqlDataAdapter(Query, db.baglanti);
            SqlCommandBuilder buildeer = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            db.baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.baglanti.Open();
            SqlCommand komutsil = new SqlCommand("update tblmusteri set MGidisTarihi=NULL,MDonusTarihi=NULL,MNereden=NULL,MNereye=NULL,MUlasim=NULL,MKonaklama=NULL where MKullaniciAd="+Form1.KullaniciAd+"", db.baglanti);
            //komutsil.Parameters.AddWithValue("@p1", rezervasyon.Nereden);
            komutsil.ExecuteNonQuery();
            db.baglanti.Close();
            MessageBox.Show("Rezervasyon Silindi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rezervasyon RE = new rezervasyon();
            RE.Show();
            this.Hide();
        }
    }
}
