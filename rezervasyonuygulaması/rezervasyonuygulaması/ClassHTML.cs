using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rezervasyonuygulaması
{
    public class ClassHTML:RaportBuilder    {
        public ClassHTML(RaporInfo raporinfo) : base(raporinfo) { }
        public override string buildheader()
        {
            return string.Format("<h1>{0}</h1>", this.Info.title);
        }
        public override string buildfooter()
        {
            return string.Format("<h5>{0}</h5>", this.Info.totalcost);
        }
        public override string buildcontents()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var expense in base.Info.expenses)
            {
                sb.Append(string.Format("<div> class='contentItem'>{0}</div>", expense));
            }
            return sb.ToString();
        }
    }
}
