using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan.Model
{
    internal class Thue
    {
        private int id_thue;
        private int id_congDan;

        public int IDThue { get => id_thue; set => id_thue = value; }
        public int IDCongDan { get => id_congDan; set => id_congDan = value; }

        public Thue(int idCD)
        {
            this.id_congDan = idCD;
        }

        public Thue(int id_thue, int id_congDan)
        {
            this.id_congDan = id_congDan;
            this.id_thue = id_thue;
        }
    }
}
