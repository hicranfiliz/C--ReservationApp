using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rezervasyonuygulaması
{
    public class Rapormanager
    {
        private RaportBuilder Builder;
        public Rapormanager(RaportBuilder builder) { Builder = builder; }
        public string build() { string product = Builder.buildoutput();return product; }
        public string buildupsidedown() { string product = Builder.buildfooter();product += Builder.buildcontents();product += Builder.buildheader(); return product; }
    }
}
