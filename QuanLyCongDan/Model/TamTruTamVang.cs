using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan.Model
{
    internal class TamTruTamVang
    {
        private string idtt;
        private string idcd;
        private DateTime come;
        private DateTime leave;
        private string add;

        public string IDTT { get => idtt; set => idtt = value; }
        public string IDCD { get => idcd; set => idcd = value; }
        public DateTime Come { get => come; set => come = value; }
        public DateTime Leave { get => leave; set => leave = value; }
        public string Add { get => add; set => add = value; }
        public TamTruTamVang(string idtt, string idcd, DateTime come, DateTime leave, string add)
        {
            this.idtt = idtt;
            this.idcd = idcd;
            this.come = come;
            this.leave = leave;
            this.add = add;
        }
    }
}
