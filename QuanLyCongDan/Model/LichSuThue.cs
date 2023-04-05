using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan.Model
{
    internal class LichSuThue
    {
        private int iD_LichSuThue;
        private int iD_CongDan;
        private int iD_Thue;
        private DateTime ngayNop;
        private string nguoiNop;
        private decimal soTien;

        public LichSuThue(int iD_CongDan, int iD_Thue, string nguoiNop, decimal soTien)
        {
            this.iD_CongDan = iD_CongDan;
            this.iD_Thue = iD_Thue;
            this.ngayNop = DateTime.Now;
            this.nguoiNop = nguoiNop;
            this.soTien = soTien;
        }

        public int ID_LichSuThue
        {
            get { return iD_LichSuThue; }
            set { iD_LichSuThue = value; }
        }

        public int ID_CongDan
        {
            get { return iD_CongDan; }
            set { iD_CongDan = value; }
        }

        public int ID_Thue
        {
            get { return iD_Thue; }
            set { iD_Thue = value; }
        }

        public DateTime NgayNop
        {
            get { return ngayNop; }
            set { ngayNop = value; }
        }

        public string NguoiNop
        {
            get { return nguoiNop; }
            set { nguoiNop = value; }
        }

        public decimal SoTien
        {
            get { return soTien; }
            set { soTien = value; }
        }
    }
}
