using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan.Model
{
    internal class CongTyNhanVien
    {
        private int id_CongTyNhanVien;
        private int id_CongTy;
        private int id_NhanVien;
        private decimal luong;
        private DateTime ngayVao;
        private Boolean trangThai;

        public CongTyNhanVien(int idct, int idnv, decimal lg)
        {
            id_CongTy = idct;
            id_NhanVien = idnv;
            luong = lg;
            ngayVao = DateTime.Now;
            trangThai = true;
        }

        public int Id_CongTyNhanVien { get => id_CongTyNhanVien; }
        public int Id_CongTy { get => id_CongTy; }
        public int Id_NhanVien { get => id_NhanVien; }
        public decimal Luong { get => luong; set => luong = value; }
        public DateTime NgayVao { get => ngayVao; set => ngayVao = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }

        public override string ToString()
        {
            return string.Format("ID CongTyNhanVien: {0}, ID CongTy: {1}, ID NhanVien: {2}, Luong: {3}, NgayVao: {4}", id_CongTyNhanVien, id_CongTy, id_NhanVien, luong, ngayVao.ToString("yyyy-MM-dd"));
        }
    }
}
