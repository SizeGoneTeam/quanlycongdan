using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan.Model
{
    internal class KhaiTu
    {
        private int iD;
        private int iDCongDan;
        private int iDNguoiYeuCau;
        private string quanHe;
        private DateTime thoiGianChet;
        private string noiChet;
        private string nguyenNhan;
        private string noiDangKy;
        private DateTime ngayThucHien;

        public KhaiTu()
        {
        }

        public KhaiTu(int iDCongDan, int iDNguoiYeuCau, string quanHe, DateTime thoiGianChet, string noiChet, string nguyenNhan, string noiDangKy, DateTime ngayThucHien)
        {
            IDCongDan = iDCongDan;
            IDNguoiYeuCau = iDNguoiYeuCau;
            QuanHe = quanHe;
            ThoiGianChet = thoiGianChet;
            NoiChet = noiChet;
            NguyenNhan = nguyenNhan;
            NoiDangKy = noiDangKy;
            NgayThucHien = ngayThucHien;
        }

        public KhaiTu(int iD, int iDCongDan, int iDNguoiYeuCau, string quanHe, DateTime thoiGianChet, string noiChet, string nguyenNhan, string noiDangKy, DateTime ngayThucHien)
        {
            ID = iD;
            IDCongDan = iDCongDan;
            IDNguoiYeuCau = iDNguoiYeuCau;
            QuanHe = quanHe;
            ThoiGianChet = thoiGianChet;
            NoiChet = noiChet;
            NguyenNhan = nguyenNhan;
            NoiDangKy = noiDangKy;
            NgayThucHien = ngayThucHien;
        }

        public int ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }

        public int IDCongDan
        {
            get
            {
                return iDCongDan;
            }

            set
            {
                iDCongDan = value;
            }
        }

        public int IDNguoiYeuCau
        {
            get
            {
                return iDNguoiYeuCau;
            }

            set
            {
                iDNguoiYeuCau = value;
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

        public DateTime ThoiGianChet
        {
            get
            {
                return thoiGianChet;
            }

            set
            {
                thoiGianChet = value;
            }
        }

        public string NoiChet
        {
            get
            {
                return noiChet;
            }

            set
            {
                noiChet = value;
            }
        }

        public string NguyenNhan
        {
            get
            {
                return nguyenNhan;
            }

            set
            {
                nguyenNhan = value;
            }
        }

        public string NoiDangKy
        {
            get
            {
                return noiDangKy;
            }

            set
            {
                noiDangKy = value;
            }
        }

        public DateTime NgayThucHien
        {
            get
            {
                return ngayThucHien;
            }

            set
            {
                ngayThucHien = value;
            }
        }
    }
}
