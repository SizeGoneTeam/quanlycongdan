using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan.Model
{
    internal class CCCD
    {
        private string idcc;
        private string idcd;
        private string socc;
        private DateTime ngayCap;
        private string add;

        public string IDCC { get => idcc; set => idcc = value; }
        public string IDCD { get => idcd; set => idcd = value; }
        public string SoCC { get => socc; set => socc = value; }
        public DateTime NgayCap { get => ngayCap; set => ngayCap = value; }
        public string ADD { get => add; set => add = value; }

        public CCCD (string idcc,string idcd, string socc, DateTime ngayCap, string add)
        {
            this.idcc = idcc;
            this.idcd = idcd;
            this.socc = socc;
            this.ngayCap = ngayCap;
            this.add = add;
        }

        public CCCD(string idcd, string socc, DateTime ngayCap, string add)
        {
            this.idcd = idcd;
            this.socc = socc;
            this.ngayCap = ngayCap;
            this.add = add;
        }
        public CCCD()
        { }
    }
}
