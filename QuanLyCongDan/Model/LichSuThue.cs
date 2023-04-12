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
        private DateTime ngayTao;
        private string tenCongTy;
        private decimal soTien;
        private bool trangThai;

        public LichSuThue(int iD_CongDan, string tenCongTy, decimal soTien, DateTime ngayTao)
        {
            this.iD_CongDan = iD_CongDan;
            this.ngayTao = ngayTao;
            this.tenCongTy = tenCongTy;
            this.soTien = soTien;
            trangThai = false;
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

        public string TenCongTy
        {
            get { return tenCongTy; }
            set { tenCongTy = value; }
        }

        public decimal SoTien
        {
            get { return soTien; }
            set { soTien = value; }
        }

        public bool TrangThai { get => trangThai; set => trangThai = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
    }
}
