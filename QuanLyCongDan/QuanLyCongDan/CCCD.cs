using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan
{
    internal class CCCD
    {
        private String id;
        private String cd;
        private String idcc;
        private String add;
        private DateTime ngayCap;

        public string ID { get => id;set => id = value; }
        public string CD { get => cd; set => cd = value; }
        public string IDCC { get => idcc;set =>idcc = value; }
        public String Add { get => add; set => add = value; }
        public DateTime NgayCap { get => ngayCap; set => ngayCap = value; }
        public CCCD (string id,string cd, string idcc, string add, DateTime ngayCap)
        {
            this.id = id;
            this.cd = cd;
            this.idcc = idcc;
            this.add = add;
            this.ngayCap = ngayCap;
        }
    }
}
