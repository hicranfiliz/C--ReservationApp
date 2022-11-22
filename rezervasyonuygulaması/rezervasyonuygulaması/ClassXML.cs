using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rezervasyonuygulaması
{
    public class ClassXML:RaportBuilder
    {
        public ClassXML(RaporInfo raporInfo) : base(raporInfo) { }
        public override string buildheader()
        {
            return string.Format("<Header>{0}</Header>", this.Info.title);
        }
        public override string buildfooter()
        {
            return string.Format("<Footer>{0}</Footer>", this.Info.totalcost);
        }
        public override string buildcontents()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var expense in base.Info.expenses)
            {
                sb.Append(string.Format("<Expense name='{0}'</>", expense));
            }
            return sb.ToString();
        }
    }
}
