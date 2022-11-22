using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rezervasyonuygulaması
{
    public abstract class RaportBuilder
    {
        protected RaporInfo Info;
        public RaportBuilder(RaporInfo raporInfo) { Info = raporInfo; }
        public string buildoutput() { string output = buildheader();
            output += buildcontents();
            output += buildfooter();
            return output;
        }
        public abstract string buildheader();
        public abstract string buildcontents();
        public abstract string buildfooter();

    }
}
