using System;

namespace QuanLyCongDan.Model
{
    internal class SoHoKhauThanhVien
    {
        private int iDSoHoKhau;
        private CongDan congDan;
        private string quanHe;
        private string ngheNghiepNoiLamViec;
        private string noiThuongTruTruoc;
        private string canBoDangKy;
        private DateTime ngayDangKy;

        public SoHoKhauThanhVien()
        {
        }

        public SoHoKhauThanhVien(int iDSoHoKhau, CongDan congDan, string quanHe, string ngheNghiepNoiLamViec, string noiThuongTruTruoc, string canBoDangKy, DateTime ngayDangKy)
        {
            IDSoHoKhau = iDSoHoKhau;
            CongDan = congDan;
            QuanHe = quanHe;
            NgheNghiepNoiLamViec = ngheNghiepNoiLamViec;
            NoiThuongTruTruoc = noiThuongTruTruoc;
            CanBoDangKy = canBoDangKy;
            NgayDangKy = ngayDangKy;
        }

        public int IDSoHoKhau
        {
            get
            {
                return iDSoHoKhau;
            }

            set
            {
                iDSoHoKhau = value;
            }
        }

        public CongDan CongDan
        {
            get
            {
                return congDan;
            }

            set
            {
                congDan = value;
            }
        }

        public string QuanHe
        {
            get
            {
                return quanHe;
            }

            set
            {
                quanHe = value;
            }
        }

        public string NgheNghiepNoiLamViec
        {
            get
            {
                return ngheNghiepNoiLamViec;
            }

            set
            {
                ngheNghiepNoiLamViec = value;
            }
        }

        public string NoiThuongTruTruoc
        {
            get
            {
                return noiThuongTruTruoc;
            }

            set
            {
                noiThuongTruTruoc = value;
            }
        }

        public string CanBoDangKy
        {
            get
            {
                return canBoDangKy;
            }

            set
            {
                canBoDangKy = value;
            }
        }

        public DateTime NgayDangKy
        {
            get
            {
                return ngayDangKy;
            }

            set
            {
                ngayDangKy = value;
            }
        }

    }
}
