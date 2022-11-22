using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace rezervasyonuygulaması
{
    public class KullaniciKayit
    {
        
        public void MusteriKayitAl(string Adi, string kullaniciAd, string sifre, string TC)
        {

           
            Database db = new Database();

            db.baglanti.Open();
            //verileri database e insert etmek için:
            SqlCommand kayitAl = new SqlCommand("insert into tblmusteri(MAd,MKullaniciAd,MSifre,MTC) values(@p1,@p2,@p4,@p5)", db.baglanti);
            kayitAl.Parameters.AddWithValue("@p1", Adi);
            kayitAl.Parameters.AddWithValue("@p2", kullaniciAd);
            kayitAl.Parameters.AddWithValue("@p4", sifre);
            kayitAl.Parameters.AddWithValue("@p5", TC);
            kayitAl.ExecuteNonQuery();
            MessageBox.Show("Müşteri kaydınız başarıyla yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
    }
}
