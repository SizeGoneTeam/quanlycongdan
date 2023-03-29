using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan.Model
{
    internal class Thue
    {
        private string id_thue;
        private string id_congDan;
        private string maso;

        public string IDThue { get => id_thue; set => id_thue = value; }
        public string IDCongDan { get => id_congDan; set => id_congDan = value; }
        public string Maso { get => maso; set => maso = value; }

        public Thue(string idCD, string maso)
        {
            this.id_congDan = idCD;
            this.maso = maso;
        }
    }
}
