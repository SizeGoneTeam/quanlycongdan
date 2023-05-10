using QuanLyCongDan.DAO;
using QuanLyCongDan.Model;
using QuanLyCongDan.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongDan.View
{
    public partial class FSoHoKhau : Form
    {
        private SoHoKhau soHoKhau;

        private SoHoKhauDAO soHoKhauDAO = new SoHoKhauDAO();
        private SoHoKhauThanhVienDAO thanhVienDAO = new SoHoKhauThanhVienDAO();

        private FThanhVien fThanhVien = new FThanhVien();

        private bool isAddMode;

        public FSoHoKhau()
        {
            InitializeComponent();
        }

        #region Methods
        private void updateGridView()
        {
            if (fThanhVien.DanhSachThanhVien is null)
            {
                gvThanhVien.DataSource = null;
            }
            else
            {
                List<SoHoKhauThanhVienRow> rows = fThanhVien.DanhSachThanhVien.Select(tv => new SoHoKhauThanhVienRow(tv)).ToList();
                gvThanhVien.DataSource = rows;

                // Set HeaderText for each column
                gvThanhVien.Columns[nameof(SoHoKhauThanhVienRow.HoTen)].HeaderText = "Họ tên";
                gvThanhVien.Columns[nameof(SoHoKhauThanhVienRow.QuanHe)].HeaderText = "Quan hệ";
                gvThanhVien.Columns[nameof(SoHoKhauThanhVienRow.NgheNghiepNoiLamViec)].HeaderText = "Nghề nghiệp / Nơi làm việc";
                gvThanhVien.Columns[nameof(SoHoKhauThanhVienRow.NoiThuongTruTruoc)].HeaderText = "Nơi thường trú trước";
                gvThanhVien.Columns[nameof(SoHoKhauThanhVienRow.CanBoDangKy)].HeaderText = "Cán bộ đăng ký";
                gvThanhVien.Columns[nameof(SoHoKhauThanhVienRow.NgayDangKy)].HeaderText = "Ngày đăng ký";

                // Hide ID_CongDan column
                gvThanhVien.Columns[nameof(SoHoKhauThanhVienRow.Id)].Visible = false;
            }
        }

        private void getListOfThanhVien()
        {
            fThanhVien.DanhSachThanhVien = thanhVienDAO.LayDanhSach(soHoKhau.ID);
        }

        private bool setListOfThanhVien()
        {
            if (!isAddMode)
            {
                thanhVienDAO.Xoa(soHoKhau.ID);
            }
            fThanhVien.DanhSachThanhVien.ForEach(tv => thanhVienDAO.Them(soHoKhau.ID, tv));
            return true;
        }

        private void switchToAddMode()
        {
            isAddMode = true;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            clear();
            updateContent();
        }

        private void switchToEditMode()
        {
            isAddMode = false;

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void updateContent()
        {
            txtTimKiem.Text = "";
            txtIDHoSoHoKhau.Text = soHoKhau is null ? "" : soHoKhau.IDHoSoHoKhau.ToString();
            txtNoiThuongTru.Text = soHoKhau is null ? "" : soHoKhau.NoiThuongTru;
            txtID.Text = soHoKhau is null ? "" : soHoKhau.ID.ToString();
            txtIDSoDangKyThuongTru.Text = soHoKhau is null ? "" : soHoKhau.IDSoDangKyThuongTru;
            txtIDToSo.Text = soHoKhau is null ? "" : soHoKhau.IDToSo;
            pkNgayDangKy.Value = soHoKhau is null ? DateTime.Now : soHoKhau.NgayDangKy;

            updateGridView();
        }

        private void updateFromContent()
        {
            if (isAddMode && soHoKhau is null && fThanhVien.DanhSachThanhVien is null)
            {
                soHoKhau = new SoHoKhau();
                fThanhVien.DanhSachThanhVien = new List<SoHoKhauThanhVien>();
            }
            if (int.TryParse(txtIDHoSoHoKhau.Text, out int id))
            {
                soHoKhau.IDHoSoHoKhau = id;
            }
            soHoKhau.NoiThuongTru = txtNoiThuongTru.Text;
            soHoKhau.IDSoDangKyThuongTru = txtIDSoDangKyThuongTru.Text;
            soHoKhau.IDToSo = txtIDToSo.Text;
            soHoKhau.NgayDangKy = pkNgayDangKy.Value;
        }

        private bool isEnoughContent()
        {
            if (fThanhVien.DanhSachThanhVien.Count > 0)
            {
                return true;
            }
            MessageBox.Show("Thiếu thông tin!");
            return false;
        }

        private void clear()
        {
            soHoKhau = null;
            fThanhVien.DanhSachThanhVien = null;
        }
        #endregion

        #region Events
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int id;

            if (int.TryParse(txtTimKiem.Text, out id))
            {
                soHoKhau = soHoKhauDAO.TimKiem(id);
                if (soHoKhau is null)
                {
                    MessageBox.Show("Không tìm thấy!");
                }
                else
                {
                    fThanhVien.DanhSachThanhVien = thanhVienDAO.LayDanhSach(soHoKhau.ID);
                    switchToEditMode();
                }
            }
            else
            {
                MessageBox.Show("ID không hợp lệ!");
                clear();
            }
            updateContent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (isAddMode)
            {
                updateFromContent();
                if (isEnoughContent())
                {
                    if (soHoKhauDAO.Them(soHoKhau))
                    {
                        soHoKhau.ID = soHoKhauDAO.getLatestRowIndex();
                        if (setListOfThanhVien())
                        {
                            MessageBox.Show("Thêm thành công!");
                            soHoKhau = soHoKhauDAO.TimKiem(soHoKhau.ID);
                            switchToEditMode();
                            updateContent();
                        } 
                        else
                        {
                            MessageBox.Show("Thêm thất bại!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!");
                    }
                }
            }
            else
            {
                switchToAddMode();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            updateFromContent();
            if (!isAddMode && isEnoughContent())
            {
                if (soHoKhauDAO.Sua(soHoKhau) && setListOfThanhVien())
                {
                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (isAddMode)
            {
                MessageBox.Show("Đang ở add mode!");
            }
            else
            {
                if (isEnoughContent())
                {
                    if (thanhVienDAO.Xoa(soHoKhau.ID) && soHoKhauDAO.Xoa(soHoKhau.ID))
                    {
                        MessageBox.Show("Xóa thành công!");
                        soHoKhau = null;
                        fThanhVien.DanhSachThanhVien = null;
                        updateContent();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
            }
        }

        private void btnThemThanhVien_Click(object sender, EventArgs e)
        {
            fThanhVien.ModeAdd();
            fThanhVien.ShowDialog();
            updateGridView();
        }

        private void gvThanhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                fThanhVien.ModeUpdate(gvThanhVien.Rows[e.RowIndex].Cells[0].Value.ToString());
                fThanhVien.ShowDialog();
                updateGridView();
            }
        }

        private void FSoHoKhau_Load(object sender, EventArgs e)
        {
            switchToAddMode();
            updateFromContent();
        }
        #endregion
    }
}
