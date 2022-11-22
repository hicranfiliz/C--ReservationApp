using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace rezervasyonuygulaması
{
   class kullanıcıgiris
    {
        Database db = new Database();
        public void KullaniciGirisYap(string KullaniciAdi, string KullaniciSifre)
        {

            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand login = new SqlCommand("select MKullaniciAd,MSifre from tblmusteri where MKullaniciAd=@p1 and MSifre=@p2", db.baglanti);
                login.Parameters.AddWithValue("@p1", KullaniciAdi);
                login.Parameters.AddWithValue("@p2", KullaniciSifre);
                SqlDataReader read = login.ExecuteReader();
                if (read.Read())
                {
                   // MusteriRezervasyon rez = new MusteriRezervasyon();
                    //rez.Show();
                }
                else
                {
                    MessageBox.Show("Kullanici adi veya şifre yanlış!");
                }


            }
            catch { }
            finally
            {
                db.baglanti.Close();
            }
        }

    }

    

}




