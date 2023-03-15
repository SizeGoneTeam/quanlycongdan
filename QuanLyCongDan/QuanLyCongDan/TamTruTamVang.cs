using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan
{
    internal class TamTruTamVang
    {
        private string idtt;
        private string idcd;
        private DateTime come;
        private string add;
        private string why;

        public string IDTT { get => idtt; set => idtt = value; }
        public string IDCD { get => idcd; set => idcd = value; }
        public DateTime Come { get => come; set => come = value; }
        public string Add { get => add; set => add = value; }
        public string Why { get => why; set => why = value; }
        public TamTruTamVang(string idtt, string idcd, DateTime come, string add, string why)
        {
            this.idtt = idtt;
            this.idcd = idcd;
            this.come = come;
            this.add = add;
            this.why = why;
        }
    }
}
