using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rezervasyonuygulaması
{
    public class Otobus : IUlasim
    {
        private DateTime gidisTarihi;
        private DateTime donusTarihi;

        public DateTime getGidisTarihi()
        {
            return gidisTarihi;
        }
        public DateTime getDonusTarihi()
        {
            return donusTarihi;
        }
        public void setGidisTarihi(DateTime tarih)
        {
            gidisTarihi = tarih;
        }

        public void Ulas()
        {
            MessageBox.Show("Otobüs seçildi.");
        }
    }
}
