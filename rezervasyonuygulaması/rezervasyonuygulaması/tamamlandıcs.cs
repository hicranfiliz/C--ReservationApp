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
    public partial class tamamlandıcs : Form
    {
        public tamamlandıcs()
        {
            InitializeComponent();
        }

        private void tamamlandıcs_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RaporInfo ınfo = new RaporInfo();
            ınfo.title = "rapor";
            ınfo.totalcost =1000;
            ınfo.expenses = new List<string>();
            ınfo.expenses.Add(Form1.KullaniciAd);
            ınfo.expenses.Add(rezervasyon.Nereden);
            ınfo.expenses.Add(rezervasyon.Nereye);
            ınfo.expenses.Add(rezervasyon.GidisTarihi);
            ınfo.expenses.Add(rezervasyon.DonusTarihi);

            RaportBuilder builder = new ClassHTML(ınfo);
            Rapormanager mng = new Rapormanager(builder);
            string str = mng.buildupsidedown();
            MessageBox.Show(str);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RaporInfo ınfo = new RaporInfo();
            ınfo.title = "rapor";
            ınfo.totalcost = 1000;
            ınfo.expenses = new List<string>();
            ınfo.expenses.Add(Form1.KullaniciAd);
            ınfo.expenses.Add(rezervasyon.Nereden);
            ınfo.expenses.Add(rezervasyon.Nereye);
            ınfo.expenses.Add(rezervasyon.GidisTarihi);
            ınfo.expenses.Add(rezervasyon.DonusTarihi);

            RaportBuilder builder = new ClassXML(ınfo);
            Rapormanager mng = new Rapormanager(builder);
            string str = mng.buildupsidedown();
            MessageBox.Show(str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
