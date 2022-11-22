namespace rezervasyonuygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string KullaniciAd = "";
        //public static string adsoyad = "";

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kullanıcıgiris grs = new kullanıcıgiris();
            grs.KullaniciGirisYap(txtkullaniciad.Text,txtsifre.Text);
            KullaniciAd = txtkullaniciad.Text;
            rezervasyon rz = new rezervasyon();
            rz.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kullanıcıkayıt kullanıcıkayıt = new kullanıcıkayıt();   
            kullanıcıkayıt.Show();
            this.Hide(); 
        }
    }
}