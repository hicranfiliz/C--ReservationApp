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
    public partial class kullanıcıkayıt : Form
    {
        public kullanıcıkayıt()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T0S9Q1K;Initial Catalog=rezervasyonuygulaması;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullaniciKayit kyt = new KullaniciKayit();
            kyt.MusteriKayitAl(adisoyaditxt.Text, kuladitxt.Text, sifretxt.Text, tctxt.Text);
            adisoyaditxt.Clear();
            kuladitxt.Clear();
            tctxt.Clear();
            sifretxt.Clear();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tctxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
