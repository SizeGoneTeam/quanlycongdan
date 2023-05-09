using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan.Model
{
    public class CongDan
    {
        private String id;
        private String hoTen;
        private String queQuan;
        private String gioiTinh;
        private DateTime ngaySinh;
        private String danToc;
        private String tonGiao;
        private String sdt;
        private String email;
        private String noiThuongTru;
        private String noiSinh;

        public string Id { get => id; set => id = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DanToc { get => danToc; set => danToc = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string TonGiao { get => tonGiao; set => tonGiao = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string NoiThuongTru { get => noiThuongTru; set => noiThuongTru = value; }
        public string NoiSinh { get => noiSinh; set => noiSinh = value; }


        public CongDan(string id, string hoTen, string queQuan, string gioiTinh, DateTime ngaySinh, string danToc, string tonGiao, string sdt, string email, string noiThuongTru, string noiSinh)
        {
            this.id = id;
            this.hoTen = hoTen;
            this.queQuan = queQuan;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.danToc = danToc;
            this.tonGiao = tonGiao;
            this.sdt = sdt;
            this.email = email;
            this.noiThuongTru = noiThuongTru;
            this.noiSinh = noiSinh;
        }

        public CongDan(string hoTen, string queQuan, string gioiTinh, DateTime ngaySinh, string danToc, string tonGiao, string sdt, string email, string noiThuongTru, string noiSinh)
        {
            this.hoTen = hoTen;
            this.queQuan = queQuan;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.danToc = danToc;
            this.tonGiao = tonGiao;
            this.sdt = sdt;
            this.email = email;
            this.noiThuongTru = noiThuongTru;
            this.noiSinh = noiSinh;
        }

        public CongDan(string hoTen, string queQuan, string gioiTinh, DateTime ngaySinh, string danToc, string tonGiao, string sdt, string email)
        {
            this.hoTen = hoTen;
            this.queQuan = queQuan;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.danToc = danToc;
            this.tonGiao = tonGiao;
            this.sdt = sdt;
            this.email = email;
        }
        public CongDan(String id, string hoTen, string queQuan, string gioiTinh, DateTime ngaySinh, string danToc, string tonGiao, string sdt, string email)
        {
            this.id = id;
            this.hoTen = hoTen;
            this.queQuan = queQuan;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.danToc = danToc;
            this.tonGiao = tonGiao;
            this.sdt = sdt;
            this.email = email;
        }
        public CongDan()
        {
        }
    }
}
