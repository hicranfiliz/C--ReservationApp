using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rezervasyonuygulaması
{
    public abstract class ProgramCesitFactory
    {
        public abstract IKonaklama KonaklamaOlustur();
        public abstract IUlasim UlasimOlustur();
        

    }
}
