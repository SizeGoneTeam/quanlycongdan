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
        private DateTime ngayVao;
        private long luong;
        private bool trangThai;


        // Hàm khởi tạo mặc định
        public CongTy() { }

        // Hàm khởi tạo với tham số
        public CongTy(int id, string name, DateTime date, long salary, bool status)
        {
            id_CongTy = id;
            tenCongTy = name;
            ngayVao = date;
            luong = salary;
            trangThai = status;
        }

        public bool TrangThai { get => trangThai; set => trangThai = value; }
        public long Luong { get => luong; set => luong = value; }
        public int Id_CongTy { get => id_CongTy; set => id_CongTy = value; }
        public string TenCongTy { get => tenCongTy; set => tenCongTy = value; }
        public DateTime NgayVao { get => ngayVao; set => ngayVao = value; }
    }
}
