create database QLCongDan;
GO
use QLCongDan;

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
    DiaChi nvarchar(100),
	LiDo NVARCHAR(100),
    FOREIGN KEY (ID_CongDan) REFERENCES CongDan(ID_CongDan)
);

-- Tạo bảng CCCD
CREATE TABLE CCCD (
    ID_CCCD INT IDENTITY(1,1) PRIMARY KEY,
    ID_CongDan INT,
    SoCCCD nvarchar(100),
    NgayCap DATE,
    NoiCap nvarchar(100),
    FOREIGN KEY (ID_CongDan) REFERENCES CongDan(ID_CongDan)
);

-- Tạo bảng Thuế
CREATE TABLE Thue (
    ID_Thue INT IDENTITY(1,1) PRIMARY KEY,
    ID_CongDan INT,
    MaSoThue nvarchar(10),
    NgayCapNhat DATE,
    FOREIGN KEY (ID_CongDan) REFERENCES CongDan(ID_CongDan)
);

-- Tạo bảng Sổ hộ khẩu
CREATE TABLE SoHoKhau (
    ID_SoHoKhau INT IDENTITY(1,1),
    ID_CongDan INT,
    SoHoKhau nvarchar(12),
    NgayCapNhat DATE,
	QuanHe NVARCHAR(100),
	NgayDangKy DATE,
	PRIMARY KEY(ID_SoHoKhau,ID_CongDan),
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

-- Tạo bảng Hôn nhân
CREATE TABLE HonNhan (
    ID_HonNhan INT IDENTITY(1,1) PRIMARY KEY,
    ID_Chong INT,
    ID_Vo INT,
    NgayDangKy DATE,
    NoiDangKy nvarchar(100),
	TrangThai Boolen,
    FOREIGN KEY (ID_Chong) REFERENCES CongDan(ID_CongDan),
    FOREIGN KEY (ID_Vo) REFERENCES CongDan(ID_CongDan)
);


-- Insert into CongDan table

INSERT INTO CongDan (HoTen, GioiTinh, NgaySinh, QueQuan, NoiSinh, NoiThuongTru, DanToc, TonGiao, SDT, Email, QuocTich) 
VALUES 
('Nguyễn Văn A', 'Nam', '1990-01-01', 'Thanh Hoá', 'Thanh Hoá', 'Hà Nội', 'Kinh', 'Phật giáo', '0123456789', 'nguyenvana@gmail.com', 'Việt Nam'),
('Lê Thị B', 'Nữ', '1995-05-15', 'Hà Nội', 'Hà Nội', 'Hà Nội', 'Kinh', 'Không', '0987654321', 'lethib@gmail.com', 'Việt Nam'),
('Trần Văn C', 'Nam', '1985-07-10', 'Hải Phòng', 'Hải Phòng', 'Hải Phòng', 'Kinh', 'Cao Đài', '0123456789', 'tranvanc@gmail.com', 'Việt Nam'),
('Nguyễn Thị D', 'Nữ', '2000-02-28', 'Hà Nội', 'Hà Nội', 'Hà Nội', 'Kinh', 'Không', '0987654321', 'nguyenthid@gmail.com', 'Việt Nam'),
('Phạm Văn E', 'Nam', '1992-11-25', 'Hải Dương', 'Hải Dương', 'Hà Nội', 'Kinh', 'Hòa Hảo', '0123456789', 'phamvane@gmail.com', 'Việt Nam'),
('Vũ Thị F', 'Nữ', '1998-08-20', 'Hà Nội', 'Hà Nội', 'Hà Nội', 'Kinh', 'Không', '0987654321', 'vuthif@gmail.com', 'Việt Nam'),
('Đỗ Văn G', 'Nam', '1987-12-11', 'Nghệ An', 'Nghệ An', 'Hà Nội', 'Kinh', 'Tin lành', '0123456789', 'dovang@gmail.com', 'Việt Nam'),
('Trần Thị H', 'Nữ', '1994-03-18', 'Hà Nội', 'Hà Nội', 'Hà Nội', 'Kinh', 'Không', '0987654321', 'tranthih@gmail.com', 'Việt Nam'),
('Nguyễn Văn I', 'Nam', '1996-06-30', 'Hà Nội', 'Hà Nội', 'Hà Nội', 'Kinh', 'Cao Đài', '0123456789', 'nguyenvani@gmail.com', 'Việt Nam'),
('Lê Thị K', 'Nữ', '1991-09-22', 'Hà Nội', 'Hà Nội', 'Hà Nội', 'Kinh', 'Không', '0987654321', 'lethik@gmail.com', 'Việt Nam');

-- Insert into TamTruTamVang table
INSERT INTO TamTruTamVang (ID_CongDan, NgayDen, DiaChi, LiDo) 
VALUES 
(1, '2022-01-01', '123 đường ABC, Hà Nội', 'Làm việc tại Hà Nội'),
(2, '2022-02-01', '456 đường XYZ, Hà Nội', 'Học tập tại Hà Nội'),
(3, '2022-03-01', '789 đường DEF, Hà Nội', 'Làm việc tại Hà Nội'),
(4, '2022-04-01', '1011 đường GHI, Hà Nội', 'Học tập tại Hà Nội'),
(5, '2022-05-01', '1213 đường JKL, Hà Nội', 'Làm việc tại Hà Nội'),
(6, '2022-06-01', '1415 đường MNO, Hà Nội', 'Học tập tại Hà Nội'),
(7, '2022-07-01', '1617 đường PQR, Hà Nội', 'Làm việc tại Hà Nội'),
(8, '2022-08-01', '1819 đường STU, Hà Nội', 'Học tập tại Hà Nội'),
(9, '2022-09-01', '2021 đường VWX, Hà Nội', 'Làm việc tại Hà Nội'),
(10, '2022-10-01', '2223 đường YZ, Hà Nội', 'Học tập tại Hà Nội');

-- Insert into CCCD table
INSERT INTO CCCD (ID_CongDan, SoCCCD, NgayCap, NoiCap) 
VALUES 
(1, '012345678901', '2020-01-01', 'Cục Cảnh sát quản lý xuất nhập cảnh'),
(2, '123456789012', '2019-02-02', 'Cục Cảnh sát quản lý xuất nhập cảnh'),
(3, '234567890123', '2018-03-03', 'Cục Cảnh sát quản lý xuất nhập cảnh'),
(4, '345678901234', '2017-04-04', 'Cục Cảnh sát quản lý xuất nhập cảnh'),
(5, '456789012345', '2016-05-05', 'Cục Cảnh sát quản lý xuất nhập cảnh'),
(6, '567890123456', '2015-06-06', 'Cục Cảnh sát quản lý xuất nhập cảnh'),
(7, '678901234567', '2014-07-07', 'Cục Cảnh sát quản lý xuất nhập cảnh'),
(8, '789012345678', '2013-08-08', 'Cục Cảnh sát quản lý xuất nhập cảnh'),
(9, '890123456789', '2012-09-09', 'Cục Cảnh sát quản lý xuất nhập cảnh'),
(10, '901234567890', '2011-10-10', 'Cục Cảnh sát quản lý xuất nhập cảnh');

-- Insert into Thue table
INSERT INTO Thue (ID_CongDan, MaSoThue, NgayCapNhat) 
VALUES 
(1, '1234567890', '2022-01-01'),
(2, '2345678901', '2022-02-01'),
(3, '3456789012', '2022-03-01'),
(4, '4567890123', '2022-04-01'),
(5, '5678901234', '2022-05-01'),
(6, '6789012345', '2022-06-01'),
(7, '7890123456', '2022-07-01'),
(8, '8901234567', '2022-08-01'),
(9, '9012345678', '2022-09-01'),
(10, '0123456789', '2022-10-01');

-- Insert into SoHoKhau table
INSERT INTO SoHoKhau (ID_CongDan, SoHoKhau, NgayCapNhat, QuanHe, NgayDangKy) 
VALUES 
(1, '123456789012', '2022-01-01', 'Chủ hộ', '2022-01-01'),
(2, '234567890123', '2022-02-02', 'Con', '2022-02-02'),
(3, '345678901234', '2022-03-03', 'Vợ', '2022-03-03'),
(4, '456789012345', '2022-04-04', 'Con', '2022-04-04'),
(5, '567890123456', '2022-05-05', 'Con', '2022-05-05'),
(6, '678901234567', '2022-06-06', 'Vợ', '2022-06-06'),
(7, '789012345678', '2022-07-07', 'Chủ hộ', '2022-07-07'),
(8, '890123456789', '2022-08-08', 'Con', '2022-08-08'),
(9, '901234567890', '2022-09-09', 'Vợ', '2022-09-09'),
(10, '012345678901', '2022-10-10', 'Con', '2022-10-10');

-- Insert into KhaiSinh table
INSERT INTO KhaiSinh (ID_CongDan, ID_NguoiYeuCau, ID_Cha, ID_Me, NoiDangKy, NgayThucHien) 
VALUES 
(1, NULL, NULL, NULL, 'Thành phố Hồ Chí Minh', '2022-01-01'),
(2, NULL, 1, 6, 'Thành phố Hồ Chí Minh', '2022-02-02'),
(3, NULL, 4, 7, 'Thành phố Hồ Chí Minh', '2022-03-03'),
(4, NULL, NULL, NULL, 'Thành phố Hồ Chí Minh', '2022-04-04'),
(5, NULL, 3, 8, 'Thành phố Hồ Chí Minh', '2022-05-05'),
(6, NULL, 10, 9, 'Thành phố Hồ Chí Minh', '2022-06-06'),
(7, NULL, NULL, NULL, 'Thành phố Hồ Chí Minh', '2022-07-07'),
(8, NULL, 2, 5, 'Thành phố Hồ Chí Minh', '2022-08-08'),
(9, NULL, NULL, NULL, 'Thành phố Hồ Chí Minh', '2022-09-09'),
(10, NULL, 1, 4, 'Thành phố Hồ Chí Minh', '2022-10-10');

-- Insert into HonNhan table
INSERT INTO HonNhan (ID_Chong, ID_Vo, NgayDangKy, NoiDangKy, TrangThai) 
VALUES 
(1, 2, '2022-01-01', 'Thành phố Hồ Chí Minh', 1),
(3, 4, '2022-02-02', 'Thành phố Hồ Chí Minh', 1),
(5, 6, '2022-03-03', 'Thành phố Hồ Chí Minh', 1),
(7, 8, '2022-04-04', 'Thành phố Hồ Chí Minh', 1),
(9, 10, '2022-05-05', 'Thành phố Hồ Chí Minh', 1),
(2, 1, '2022-06-06', 'Thành phố Hồ Chí Minh', 1),
(4, 3, '2022-07-07', 'Thành phố Hồ Chí Minh', 1),
(6, 5, '2022-08-08', 'Thành phố Hồ Chí Minh', 1),
(8, 7, '2022-09-09', 'Thành phố Hồ Chí Minh', 1),
(10, 9, '2022-10-10', 'Thành phố Hồ Chí Minh', 1);

