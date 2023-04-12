IF NOT EXISTS(SELECT name FROM sys.databases WHERE name = 'QLCongDan')
    CREATE DATABASE QLCongDan;
GO

USE QLCongDan;

-- Tạo bảng Công dân
CREATE TABLE CongDan (
    ID_CongDan INT IDENTITY(1,1) PRIMARY KEY,
    HoTen nvarchar(100),
    GioiTinh nvarchar(100),
    NgaySinh DATE,
    QueQuan nvarchar(100),
	NoiSinh nvarchar(100),
	NoiThuongTru nvarchar(100),
    DanToc nvarchar(100),
    TonGiao nvarchar(100),
	SDT nvarchar(100),
	Email nvarchar(100),
	QuocTich nvarchar(100)
);

-- Tạo bảng tạm trú tạm vắng
CREATE TABLE TamTruTamVang (
    ID_TamTru INT IDENTITY(1,1) PRIMARY KEY,
    ID_CongDan INT,
    NgayDen DATE,
	NgayDi DATE,
    DiaChi nvarchar(100),
	LiDo NVARCHAR(100),
    FOREIGN KEY (ID_CongDan) REFERENCES CongDan(ID_CongDan)
);

-- Tạo bảng CCCD
CREATE TABLE CCCD (
    ID_CCCD INT IDENTITY(1,1) PRIMARY KEY,
    ID_CongDan INT,
    SoCCCD NVARCHAR(100),
    NgayCap DATE,
    NoiCap nvarchar(100),
    FOREIGN KEY (ID_CongDan) REFERENCES CongDan(ID_CongDan)
);



-- Tạo bảng Sổ hộ khẩu
CREATE TABLE SoHoKhau (
    ID_SoHoKhau INT IDENTITY(1,1),
    ID_HoSoHoKhau INT,
    ID_SoDangKyThuongTru NVARCHAR(50),
    ID_SoDangKyThuongTru_ToSo NVARCHAR(50),
    NoiThuongTru NVARCHAR(100),
    NgayDangKy DATE,
	PRIMARY KEY(ID_SoHoKhau),
);

CREATE TABLE CongDan_SoHoKhau(
    ID_SoHoKhau INT,
    ID_CongDan INT,
    QuanHe NVARCHAR(50),
    NgheNghiep_NoiLamViec NVARCHAR(100),
    NoiThuongTruTruoc NVARCHAR(100),
    CanBoDangKy NVARCHAR(100),
    NgayDangKy DATE,
    PRIMARY KEY (ID_SoHoKhau, ID_CongDan),
    FOREIGN KEY (ID_SoHoKhau) REFERENCES SoHoKhau(ID_SoHoKhau),
    FOREIGN KEY (ID_CongDan) REFERENCES CongDan(ID_CongDan)
);

-- Tạo bảng Khai sinh
CREATE TABLE KhaiSinh (
    ID_KhaiSinh INT IDENTITY(1,1) PRIMARY KEY,
    ID_CongDan INT,
    ID_NguoiYeuCau INT,
    ID_Cha INT,
    ID_Me INT,
    NoiDangKy nvarchar(100),
    NgayThucHien DATE,
    FOREIGN KEY (ID_CongDan) REFERENCES CongDan(ID_CongDan),
    FOREIGN KEY (ID_NguoiYeuCau) REFERENCES CongDan(ID_CongDan),
    FOREIGN KEY (ID_Cha) REFERENCES CongDan(ID_CongDan),
    FOREIGN KEY (ID_Me) REFERENCES CongDan(ID_CongDan)
);

CREATE TABLE KhaiTu (
    ID_KhaiTu INT IDENTITY(1, 1) PRIMARY KEY,
    ID_CongDan INT,
    ID_NguoiYeuCau INT,
    QuanHe NVARCHAR(100),
    ThoiGianChet DateTime,
    NoiChet NVARCHAR(100),
    NguyenNhan NVARCHAR(100),
    NoiDangKy NVARCHAR(100),
    NgayThucHien Date,
    FOREIGN KEY (ID_CongDan) REFERENCES CongDan(ID_CongDan),
    FOREIGN KEY (ID_NguoiYeuCau) REFERENCES CongDan(ID_CongDan)
);

-- Tạo bảng Hôn nhân
CREATE TABLE HonNhan (
    ID_HonNhan INT IDENTITY(1,1) PRIMARY KEY,
    ID_Chong INT,
    ID_Vo INT,
    NgayDangKy DATE,
    NoiDangKy nvarchar(100),
	TrangThai BIT,
    FOREIGN KEY (ID_Chong) REFERENCES CongDan(ID_CongDan),
    FOREIGN KEY (ID_Vo) REFERENCES CongDan(ID_CongDan)
);

---
CREATE TABLE CongTy (
    ID_CongTy INT IDENTITY(1,1) PRIMARY KEY,
    TenCongTy nvarchar(100),
    NgayTao DATE
);

CREATE TABLE CongTy_NhanVien (
    ID_CongTyNhanVien INT IDENTITY(1,1) PRIMARY KEY,
    ID_CongTy INT REFERENCES CongTy(ID_CongTy),
    ID_NhanVien INT REFERENCES CongDan(ID_CongDan),
	Luong DECIMAL(18,2),
	TrangThai BIT,
    NgayVao DATE
);

-- Tạo bảng Thuế
CREATE TABLE Thue (
    ID_Thue INT IDENTITY(1,1) PRIMARY KEY,
    ID_CongDan INT,
    FOREIGN KEY (ID_CongDan) REFERENCES CongDan(ID_CongDan)
);

---

CREATE TABLE LichSuThue (
    ID_LichSuThue INT IDENTITY(1,1) PRIMARY KEY,
    ID_CongDan INT REFERENCES CongDan(ID_CongDan),
    ID_Thue INT REFERENCES Thue(ID_Thue),
    NgayNop DATE,
	TrangThai BIT,
    SoTien DECIMAL(18,2)
);


-- Insert into CongDan table

INSERT INTO CongDan (HoTen, GioiTinh, NgaySinh, QueQuan, NoiSinh, NoiThuongTru, DanToc, TonGiao, SDT, Email, QuocTich)
VALUES
(N'Nguyễn Văn A', N'Nam', '1990-01-01', N'Thanh Hoá', N'Thanh Hoá', N'Hà Nội', N'Kinh', N'Phật giáo', '0123456789', 'nguyenvana@gmail.com', N'Việt Nam'),
(N'Lê Thị B', N'Nữ', '1995-05-15', N'Hà Nội', N'Hà Nội', N'Hà Nội', N'Kinh', N'Không', '0987654321', 'lethib@gmail.com', N'Việt Nam'),
(N'Trần Văn C', N'Nam', '1985-07-10', N'Hải Phòng', N'Hải Phòng', N'Hải Phòng', N'Kinh', N'Cao Đài', '0123456789', 'tranvanc@gmail.com', N'Việt Nam'),
(N'Nguyễn Thị D', N'Nữ', '2000-02-28', N'Hà Nội', N'Hà Nội', N'Hà Nội', N'Kinh', N'Không', '0987654321', 'nguyenthid@gmail.com', N'Việt Nam'),
(N'Phạm Văn E', N'Nam', '1992-11-25', N'Hải Dương', N'Hải Dương', N'Hà Nội', N'Kinh', N'Hòa Hảo', '0123456789', 'phamvane@gmail.com', N'Việt Nam'),
(N'Vũ Thị F', N'Nữ', '1998-08-20', N'Hà Nội', N'Hà Nội', N'Hà Nội', N'Kinh', N'Không', '0987654321', 'vuthif@gmail.com', N'Việt Nam'),
(N'Đỗ Văn G', N'Nam', '1987-12-11', N'Nghệ An', N'Nghệ An', N'Hà Nội', N'Kinh', N'Tin lành', '0123456789', 'dovang@gmail.com', N'Việt Nam'),
(N'Trần Thị H', N'Nữ', '1994-03-18', N'Hà Nội', N'Hà Nội', N'Hà Nội', N'Kinh', N'Không', '0987654321', 'tranthih@gmail.com', N'Việt Nam'),
(N'Nguyễn Văn I', N'Nam', '1996-06-30', N'Hà Nội', N'Hà Nội', N'Hà Nội', N'Kinh', N'Cao Đài', '0123456789', 'nguyenvani@gmail.com', N'Việt Nam'),
(N'Lê Thị K', N'Nữ', '1991-09-22', N'Hà Nội', N'Hà Nội', N'Hà Nội', N'Kinh', N'Không', '0987654321', 'lethik@gmail.com', N'Việt Nam');

-- Insert into TamTruTamVang table
INSERT INTO TamTruTamVang (ID_CongDan, NgayDen, NgayDi, DiaChi, LiDo)
VALUES 
(1, '2022-01-01', '2022-01-10', N'123 Đường A, Quận 1, TP.HCM', N'Du lịch'),
(2, '2022-02-01', '2022-02-10', N'456 Đường B, Quận 2, TP.HCM', N'Công tác'),
(3, '2022-03-01', '2022-03-10', N'789 Đường C, Quận 3, TP.HCM', N'Học tập'),
(4, '2022-04-01', '2022-04-10', N'321 Đường D, Quận 4, TP.HCM', N'Y tế'),
(5, '2022-05-01', '2022-05-10', N'654 Đường E, Quận 5, TP.HCM', N'Du lịch'),
(6, '2022-06-01', '2022-06-10', N'987 Đường F, Quận 6, TP.HCM', N'Công tác'),
(7, '2022-07-01', '2022-07-10', N'135 Đường G, Quận 7, TP.HCM', N'Học tập'),
(8, '2022-08-01', '2022-08-10', N'246 Đường H, Quận 8, TP.HCM', N'Y tế'),
(9, '2022-09-01', '2022-09-10', N'357 Đường I, Quận 9, TP.HCM', N'Du lịch'),
(10, '2022-10-01', '2022-10-10', N'468 Đường K, Quận 10, TP.HCM', N'Công tác');

-- Insert into CCCD table
INSERT INTO CCCD (ID_CongDan, SoCCCD, NgayCap, NoiCap)
VALUES
(1, '312345678901', '2020-01-01', N'Cục Cảnh sát quản lý xuất nhập cảnh'),
(2, '123456789012', '2019-02-02', N'Cục Cảnh sát quản lý xuất nhập cảnh'),
(3, '234567890123', '2018-03-03', N'Cục Cảnh sát quản lý xuất nhập cảnh'),
(4, '345678901234', '2017-04-04', N'Cục Cảnh sát quản lý xuất nhập cảnh'),
(5, '456789012345', '2016-05-05', N'Cục Cảnh sát quản lý xuất nhập cảnh'),
(6, '567890123456', '2015-06-06', N'Cục Cảnh sát quản lý xuất nhập cảnh'),
(7, '678901234567', '2014-07-07', N'Cục Cảnh sát quản lý xuất nhập cảnh'),
(8, '789012345678', '2013-08-08', N'Cục Cảnh sát quản lý xuất nhập cảnh'),
(9, '890123456789', '2012-09-09', N'Cục Cảnh sát quản lý xuất nhập cảnh'),
(10, '901234567890', '2011-10-10', N'Cục Cảnh sát quản lý xuất nhập cảnh');

INSERT INTO SoHoKhau (ID_HoSoHoKhau, ID_SoDangKyThuongTru, ID_SoDangKyThuongTru_ToSo, NoiThuongTru, NgayDangKy)
VALUES (1, '012345', '0123', '123 ABC Street, District 1, Ho Chi Minh City', '2022-01-01'),
(2, '543210', '5432', '456 XYZ Street, District 2, Ho Chi Minh City', '2022-02-01'),
(3, '987654', '9876', '789 DEF Street, District 3, Ho Chi Minh City', '2022-03-01'),
(4, '654321', '6543', '321 GHI Street, District 4, Ho Chi Minh City', '2022-04-01'),
(5, '135790', '1357', '246 JKL Street, District 5, Ho Chi Minh City', '2022-05-01');

INSERT INTO CongDan_SoHoKhau (ID_SoHoKhau, ID_CongDan, QuanHe, NgheNghiep_NoiLamViec, NoiThuongTruTruoc, CanBoDangKy, NgayDangKy)
VALUES (1, 1, 'Chủ hộ', 'Giáo viên', '123 XYZ Street, District 1, Ho Chi Minh City', 'Nguyen Van A', '2022-01-01'),
(1, 2, 'Vợ', 'Bác sĩ', '789 DEF Street, District 3, Ho Chi Minh City', 'Tran Thi B', '2022-01-01'),
(2, 3, 'Chủ hộ', 'Kỹ sư', '456 XYZ Street, District 2, Ho Chi Minh City', 'Le Van C', '2022-02-01'),
(2, 4, 'Vợ', 'Nhân viên văn phòng', '321 GHI Street, District 4, Ho Chi Minh City', 'Pham Thi D', '2022-02-01'),
(3, 5, 'Chủ hộ', 'Nhà báo', '789 DEF Street, District 3, Ho Chi Minh City', 'Vo Van E', '2022-03-01');

-- Insert into KhaiSinh table
INSERT INTO KhaiSinh (ID_CongDan, ID_NguoiYeuCau, ID_Cha, ID_Me, NoiDangKy, NgayThucHien)
VALUES
(1, NULL, NULL, NULL, N'Thành phố Hồ Chí Minh', '2022-01-01'),
(2, NULL, 1, 6, N'Thành phố Hồ Chí Minh', '2022-02-02'),
(3, NULL, 4, 7, N'Thành phố Hồ Chí Minh', '2022-03-03'),
(4, NULL, NULL, NULL, N'Thành phố Hồ Chí Minh', '2022-04-04'),
(5, NULL, 3, 8, N'Thành phố Hồ Chí Minh', '2022-05-05'),
(6, NULL, 10, 9, N'Thành phố Hồ Chí Minh', '2022-06-06'),
(7, NULL, NULL, NULL, N'Thành phố Hồ Chí Minh', '2022-07-07'),
(8, NULL, 2, 5, N'Thành phố Hồ Chí Minh', '2022-08-08'),
(9, NULL, NULL, NULL, N'Thành phố Hồ Chí Minh', '2022-09-09'),
(10, NULL, 1, 4, N'Thành phố Hồ Chí Minh', '2022-10-10');

-- Insert into HonNhan table
INSERT INTO HonNhan (ID_Chong, ID_Vo, NgayDangKy, NoiDangKy, TrangThai)
VALUES
(1, 2, '2022-01-01', N'Thành phố Hồ Chí Minh', 1),
(3, 4, '2022-02-02', N'Thành phố Hồ Chí Minh', 1),
(5, 6, '2022-03-03', N'Thành phố Hồ Chí Minh', 1),
(7, 8, '2022-04-04', N'Thành phố Hồ Chí Minh', 1),
(9, 10, '2022-05-05', N'Thành phố Hồ Chí Minh', 1),
(2, 1, '2022-06-06', N'Thành phố Hồ Chí Minh', 1),
(4, 3, '2022-07-07', N'Thành phố Hồ Chí Minh', 1),
(6, 5, '2022-08-08', N'Thành phố Hồ Chí Minh', 1),
(8, 7, '2022-09-09', N'Thành phố Hồ Chí Minh', 1),
(10, 9, '2022-10-10', N'Thành phố Hồ Chí Minh', 1);

-- Thêm bản ghi vào bảng CongTy
INSERT INTO CongTy (TenCongTy, NgayTao)
VALUES ('Công ty ABC', '2020-01-01');

-- Thêm bản ghi vào bảng CongTy_NhanVien
INSERT INTO CongTy_NhanVien (ID_CongTy, ID_NhanVien, Luong, NgayVao, TrangThai)
VALUES (1, 1, 5000000, '2022-01-01', 1),
       (1, 2, 4500000, '2022-01-02', 1),
       (1, 3, 4000000, '2022-01-03', 1),
       (1, 4, 3500000, '2022-01-04', 1);

-- Thêm bản ghi vào bảng Thue
INSERT INTO Thue (ID_CongDan)
VALUES (1),
       (2),
       (3),
       (4);

-- Thêm bản ghi vào bảng LichSuThue
INSERT INTO LichSuThue (ID_CongDan, ID_Thue, NgayNop, NguoiNop, SoTien)
VALUES (1, 1, '2022-02-01', 'Công ty ABC', 1000000.50),
       (2, 2, '2022-02-02', 'Công ty ABC', 1200000.75),
       (3, 3, '2022-02-03', 'Công ty ABC', 800000.00),
       (4, 4, '2022-02-04', 'Công ty ABC', 1500000.25);

