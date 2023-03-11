using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan
{
    internal class HonNhan
    {
        private int idHonNhan;
        private int idChong;
        private int idVo;
        private DateTime ngayDangKy;
        private string noiDangKy;
        private bool trangThai;

        public HonNhan()
        {
        }

        public HonNhan(int idHonNhan, int idChong, int idVo, DateTime ngayDangKy, string noiDangKy, bool trangThai)
        {
            this.idHonNhan = idHonNhan;
            this.idChong = idChong;
            this.idVo = idVo;
            this.ngayDangKy = ngayDangKy;
            this.noiDangKy = noiDangKy;
            this.trangThai = trangThai;
        }

        public bool TrangThai { get => trangThai; set => trangThai = value; }
        public string NoiDangKy { get => noiDangKy; set => noiDangKy = value; }
        public int IdHonNhan { get => idHonNhan; set => idHonNhan = value; }
        public int IdChong { get => idChong; set => idChong = value; }
        public int IdVo { get => idVo; set => idVo = value; }
        public DateTime NgayDangKy { get => ngayDangKy; set => ngayDangKy = value; }

    }
}
