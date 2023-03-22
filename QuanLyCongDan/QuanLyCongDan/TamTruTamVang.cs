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
        private string idcd;
        private DateTime come;
        private DateTime leave;
        private string add;
        private string why;


        public string IDCD { get => idcd; set => idcd = value; }
        public DateTime Come { get => come; set => come = value; }
        public DateTime Leave { get => leave; set => leave = value; }
        public string Add { get => add; set => add = value; }
        public string Why { get => why; set => why = value; }
        public TamTruTamVang(string idcd, DateTime come, DateTime leave, string add, string why)
        {
            this.idcd = idcd;
            this.come = come;
            this.leave = leave;
            this.add = add;
            this.why = why;
        }
        public TamTruTamVang(DateTime come, DateTime leave, string add, string why)
        {
            this.come = come;
            this.leave = leave;
            this.add = add;
            this.why = why;
        }
        public TamTruTamVang()
        {
        }
    }
}
