using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan.Model
{
    internal class SoHoKhauThanhVienRow
    {
        public string Id { get; set; }
        public string HoTen { get; set; }
        public string QuanHe { get; set; }
        public string NgheNghiepNoiLamViec { get; set; }
        public string NoiThuongTruTruoc { get; set; }
        public string CanBoDangKy { get; set; }
        public string NgayDangKy { get; set; }

        public SoHoKhauThanhVienRow(CongDan_SoHoKhau thanhVien)
        {
            this.Id = thanhVien.CongDan.ID_CongDan.ToString();
            this.HoTen = thanhVien.CongDan.HoTen;
            this.QuanHe = thanhVien.QuanHe;
            this.NgheNghiepNoiLamViec = thanhVien.NgheNghiep_NoiLamViec;
            this.NoiThuongTruTruoc = thanhVien.NoiThuongTruTruoc;
            this.CanBoDangKy = thanhVien.CanBoDangKy;
            this.NgayDangKy = thanhVien.NgayDangKy?.ToShortDateString();
        }
    }
}
