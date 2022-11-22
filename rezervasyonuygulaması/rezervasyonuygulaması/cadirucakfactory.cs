using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rezervasyonuygulaması
{
    public class cadirucakfactory:ProgramCesitFactory
    {
        public override IKonaklama KonaklamaOlustur()
        {
            return new Cadir();
        }
        public override IUlasim UlasimOlustur()
        {
            return new Ucak();
        }
    }
}
