using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan.Model
{
    internal class Thue
    {
        private string thue;
        private string id;
        private string maso;
        private DateTime ngayUp;

        public string IDThue { get => thue; set => thue = value; }
        public string ID { get => id; set => id = value; }
        public string Mso { get => maso; set => maso = value; }
        public DateTime NgayUp { get => ngayUp; set => ngayUp = value; }

        public Thue(string thue, string id, string maso, DateTime ngayUp)
        {
            this.thue = thue;
            this.id = id;
            this.maso = maso;
            this.ngayUp = ngayUp;
        }
    }
}
