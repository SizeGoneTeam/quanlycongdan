using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan.Model
{
    internal class SoHoKhau
    {
        private int iD;
        private int iDHoSoHoKhau;
        private String iDSoDangKyThuongTru;
        private String iDToSo;
        private String noiThuongTru;
        private DateTime ngayDangKy;

        public SoHoKhau()
        {
        }

        public SoHoKhau(int iDHoSoHoKhau, string iDSoDangKyThuongTru, string iDToSo, string noiThuongTru, DateTime ngayDangKy)
        {
            IDHoSoHoKhau = iDHoSoHoKhau;
            IDSoDangKyThuongTru = iDSoDangKyThuongTru;
            IDToSo = iDToSo;
            NoiThuongTru = noiThuongTru;
            NgayDangKy = ngayDangKy;
        }

        public SoHoKhau(int iD, int iDHoSoHoKhau, string iDSoDangKyThuongTru, string iDToSo, string noiThuongTru, DateTime ngayDangKy)
        {
            ID = iD;
            IDHoSoHoKhau = iDHoSoHoKhau;
            IDSoDangKyThuongTru = iDSoDangKyThuongTru;
            IDToSo = iDToSo;
            NoiThuongTru = noiThuongTru;
            NgayDangKy = ngayDangKy;
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

        public int IDHoSoHoKhau
        {
            get
            {
                return iDHoSoHoKhau;
            }

            set
            {
                iDHoSoHoKhau = value;
            }
        }

        public string IDSoDangKyThuongTru
        {
            get
            {
                return iDSoDangKyThuongTru;
            }

            set
            {
                iDSoDangKyThuongTru = value;
            }
        }

        public string IDToSo
        {
            get
            {
                return iDToSo;
            }

            set
            {
                iDToSo = value;
            }
        }

        public string NoiThuongTru
        {
            get
            {
                return noiThuongTru;
            }

            set
            {
                noiThuongTru = value;
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
