using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace rezervasyonuygulaması
{
    public class Otel:IKonaklama
    {
        Database db = new Database();
        //public string Ad { get; set; }
        public void Konakla()
        {

            //db.baglanti.Open();
            //SqlCommand cmd = new SqlCommand("select * from Otel", db.baglanti);
            //SqlDataReader dr;
            //dr = cmd.ExecuteReader();
            //db.baglanti.Close();

            MessageBox.Show("Otel seçildi.");
        }
    }
}
