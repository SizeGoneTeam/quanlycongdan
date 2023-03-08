create database QLCongDan;
use QLCongDan;

-- Tạo bảng Công dân
CREATE TABLE CongDan (
    ID_CongDan INT IDENTITY(1,1) PRIMARY KEY,
    HoTen varchar(100),
    GioiTinh varchar(100),
    NgaySinh DATE,
    QueQuan varchar(100),
    DiaChi varchar(100),
    QuocTich varchar(100),
    DanToc varchar(100),
    TonGiao varchar(100),
	SDT varchar(100),
	Email varchar(100)
);

-- Tạo bảng tạm trú tạm vắng
CREATE TABLE TamTruTamVang (
    ID_TamTru INT IDENTITY(1,1) PRIMARY KEY,
    ID_CongDan INT,
    NgayDen DATE,
    NgayDi DATE,
    DiaChi varchar(100),
    FOREIGN KEY (ID_CongDan) REFERENCES CongDan(ID_CongDan)
);

-- Tạo bảng CCCD
CREATE TABLE CCCD (
    ID_CCCD INT IDENTITY(1,1) PRIMARY KEY,
    ID_CongDan INT,
    SoCCCD varchar(100),
    NgayCap DATE,
    NoiCap varchar(100),
    FOREIGN KEY (ID_CongDan) REFERENCES CongDan(ID_CongDan)
);

-- Tạo bảng Thuế
CREATE TABLE Thue (
    ID_Thue INT IDENTITY(1,1) PRIMARY KEY,
    ID_CongDan INT,
    MaSoThue varchar(100),
    NgayCapNhat DATE,
    FOREIGN KEY (ID_CongDan) REFERENCES CongDan(ID_CongDan)
);

-- Tạo bảng Sổ hộ khẩu
CREATE TABLE SoHoKhau (
    ID_SoHoKhau INT IDENTITY(1,1) PRIMARY KEY,
    ID_CongDan INT,
    SoHoKhau varchar(100),
    NgayCapNhat DATE,
    FOREIGN KEY (ID_CongDan) REFERENCES CongDan(ID_CongDan)
);

-- Tạo bảng Khai sinh
CREATE TABLE KhaiSinh (
    ID_KhaiSinh INT IDENTITY(1,1) PRIMARY KEY,
    ID_CongDan INT,
    ID_NguoiYeuCau INT,
    ID_Cha INT,
    ID_Me INT,
    NoiDangKy NVARCHAR(100),
    NgayThucHien DATE,

    FOREIGN KEY (ID_CongDan) REFERENCES CongDan(ID_CongDan),
    FOREIGN KEY (ID_NguoiYeuCau) REFERENCES CongDan(ID_CongDan),
    FOREIGN KEY (ID_Cha) REFERENCES CongDan(ID_CongDan),
    FOREIGN KEY (ID_Me) REFERENCES CongDan(ID_CongDan)
);

-- Tạo bảng Hôn nhân
CREATE TABLE HonNhan (
    ID_HonNhan INT IDENTITY(1,1) PRIMARY KEY,
    ID_CongDan1 INT,
    ID_CongDan2 INT,
    NgayDangKy DATE,
    NoiDangKy varchar(100),
    FOREIGN KEY (ID_CongDan1) REFERENCES CongDan(ID_CongDan),
    FOREIGN KEY (ID_CongDan2) REFERENCES CongDan(ID_CongDan)
);


-- Insert into CongDan table
INSERT INTO CongDan ( HoTen, GioiTinh, NgaySinh, QueQuan, DiaChi, QuocTich, DanToc, TonGiao, SDT, Email)
VALUES ('Nguyen Van A', 'Nam', '2000-01-01', 'TP.HCM', '123 Nguyen Van Cu, Quan 1, TP.HCM', 'Viet Nam', 'Kinh', 'Khong' , '0986596214', 'giotocdo@gmail.com'),
('Tran Thi B', 'Nu', '2000-02-01', 'Ha Noi', '456 Nguyen Van Cu, Quan 2, TP.HCM', 'Viet Nam', 'Kinh', 'Khong', '0986592314', 'cantho2@gmail.com');


-- Insert into TamTruTamVang table
INSERT INTO TamTruTamVang (ID_CongDan, NgayDen, NgayDi, DiaChi)
VALUES (1, '2022-01-01', '2022-01-15', '123 Nguyen Van Cu, Quan 1, TP.HCM'),
(2, '2022-02-01', '2022-02-28', '456 Nguyen Van Cu, Quan 2, TP.HCM');


-- Insert into CCCD table
INSERT INTO CCCD (ID_CongDan, SoCCCD, NgayCap, NoiCap)
VALUES (1, '123456789', '2020-01-01', 'TP.HCM'),
(2, '987654321', '2020-02-01', 'TP.HCM');

-- Insert into Thue table
INSERT INTO Thue (ID_CongDan, MaSoThue, NgayCapNhat)
VALUES (1, '1234567890', '2022-01-01'),
(2, '0987654321', '2022-02-01');

-- Insert into SoHoKhau table
INSERT INTO SoHoKhau (ID_CongDan, SoHoKhau, NgayCapNhat)
VALUES (1, '1234/ABC', '2022-01-01'),
(2, '5678/DEF', '2022-02-01');

-- Insert into KhaiSinh table
--INSERT INTO KhaiSinh (ID_CongDan, HoTen, GioiTinh, NgaySinh, NoiSinh, QuocTich, DanToc, TonGiao)
--VALUES (1, 'Nguyen Van A', 'Nam', '2022-01-01', 'TP.HCM', 'Viet Nam', 'Kinh', 'Khong'),
--(2, 'Tran Thi B', 'Nu', '2022-02-01', 'Ha Noi', 'Viet Nam', 'Kinh', 'Khong');

-- Insert into HonNhan table
INSERT INTO HonNhan (ID_CongDan1, ID_CongDan2, NgayDangKy, NoiDangKy)
VALUES (1, 2, '2022-01-01', 'TP.HCM'),
(2, 1, '2022-02-01', 'TP.HCM');

select * from CCCD