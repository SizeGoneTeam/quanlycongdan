using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan
{
    internal class CCCD
    {
        private String cd;
        private String idcc;
        private String add;
        private DateTime ngayCap;
        private String soCCCD;

        public string CD { get => cd; set => cd = value; }
        public string IDCC { get => idcc;set =>idcc = value; }
        public String Add { get => add; set => add = value; }
        public DateTime NgayCap { get => ngayCap; set => ngayCap = value; }
        public string SoCCCD { get => soCCCD; set => soCCCD = value; }

        public CCCD (string cd, string idcc, string add, DateTime ngayCap)
        {
            this.cd = cd;
            this.idcc = idcc;
            this.add = add;
            this.ngayCap = ngayCap;
        }

        public CCCD(string cd, string idcc, string add, DateTime ngayCap, string soCCCD)
        {
            this.cd = cd;
            this.idcc = idcc;
            this.add = add;
            this.ngayCap = ngayCap;
            this.soCCCD = soCCCD;
        }
        public CCCD()
        { }
    }
}
