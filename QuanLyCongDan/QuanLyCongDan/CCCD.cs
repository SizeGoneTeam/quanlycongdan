using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan
{
    internal class CCCD
    {
        private string idcd;
        private String socc;
        private String add;
        private DateTime ngayCap;

        public string IDCD { get => idcd; set => idcd = value; }
        public string SoCC { get => socc; set => socc = value; }
        public String Add { get => add; set => add = value; }
        public DateTime NgayCap { get => ngayCap; set => ngayCap = value; }

        public CCCD (string idcd, string socc, string add, DateTime ngayCap)
        {
            this.idcd = idcd;
            this.socc = socc;
            this.add = add;
            this.ngayCap = ngayCap;
        }

        public CCCD(string idcd, string socc, string add, DateTime ngayCap, string soCCCD)
        {
            this.idcd = idcd;
            this.socc = socc;
            this.add = add;
            this.ngayCap = ngayCap;
        }
        public CCCD()
        { }
    }
}
