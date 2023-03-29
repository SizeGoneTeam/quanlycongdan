using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan.Model
{
    internal class KhaiSinh
    {
        #region Fields and Properties
        private int iD;
        private int iDCongDan;
        private int iDNguoiYeuCau;
        private int iDCha;
        private int iDMe;
        private String noiDangKy;
        private DateTime ngayThucHien;

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

        public int IDCha
        {
            get
            {
                return iDCha;
            }

            set
            {
                iDCha = value;
            }
        }

        public int IDMe
        {
            get
            {
                return iDMe;
            }

            set
            {
                iDMe = value;
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
        #endregion

        #region Constructors
        public KhaiSinh()
        {

        }

        public KhaiSinh(int iDCongDan, int iDNguoiYeuCau, int iDCha, int iDMe, string noiDangKy, DateTime ngayThucHien)
        {
            IDCongDan = iDCongDan;
            IDNguoiYeuCau = iDNguoiYeuCau;
            IDCha = iDCha;
            IDMe = iDMe;
            NoiDangKy = noiDangKy;
            NgayThucHien = ngayThucHien;
        }

        public KhaiSinh(int iD, int iDCongDan, int iDNguoiYeuCau, int iDCha, int iDMe, string noiDangKy, DateTime ngayThucHien)
        {
            ID = iD;
            IDCongDan = iDCongDan;
            IDNguoiYeuCau = iDNguoiYeuCau;
            IDCha = iDCha;
            IDMe = iDMe;
            NoiDangKy = noiDangKy;
            NgayThucHien = ngayThucHien;
        }

        #endregion

    }
}
