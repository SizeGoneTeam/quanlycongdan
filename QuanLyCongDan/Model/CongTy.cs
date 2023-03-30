using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan.Model
{
    internal class CongTy
    {
        private int id_CongTy;
        private string tenCongTy;
        private DateTime ngayTao;



        // Hàm khởi tạo mặc định
        public CongTy() { }

        // Hàm khởi tạo với tham số
        public CongTy(string name)
        {
            tenCongTy = name;
            ngayTao = DateTime.Now;
        }

        public CongTy(int id_CongTy, string tenCongTy, DateTime ngayTao)
        {
            this.id_CongTy = id_CongTy;
            this.tenCongTy = tenCongTy;
            this.ngayTao = ngayTao;
        }

        public int Id_CongTy { get => id_CongTy; set => id_CongTy = value; }
        public string TenCongTy { get => tenCongTy; set => tenCongTy = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
    }
}
