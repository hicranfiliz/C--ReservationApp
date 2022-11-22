using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rezervasyonuygulaması
{
    public partial class ödemebilgileri : Form
    {
        public ödemebilgileri()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rezervasyon r = new rezervasyon();
            r.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tamamlandıcs tm = new tamamlandıcs();
            tm.Show();
            this.Hide();
        }
    }
}
