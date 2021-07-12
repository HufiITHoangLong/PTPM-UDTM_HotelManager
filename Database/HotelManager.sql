Create Database Hotel_Manager
GO
USE Hotel_Manager
GO
Create table LOAIPHONG
(
	MALOAIPHONG int,
	TENLOAIPHONG nvarchar(30),
	DONGIA int,
	NGAYCAPNHAT Datetime,
	NGUOICAPNHAT varchar(20),
	PRIMARY KEY (MALOAIPHONG)
)
Create table PHONG
(
	MAPHONG char(10) not null,
	TRANGTHAI INT,
	SUCCHUA INT,
	MALOAIPHONG int,
	PRIMARY KEY (MAPHONG),
	FOREIGN KEY (MALOAIPHONG) REFERENCES LOAIPHONG
)
Create table NHANVIEN
(
	USERNAME varchar(20) not null,
	PASSWORD varchar(20),
	HOTENNV nvarchar(50),
	DIENTHOAI char(11),
	DIACHI nvarchar(30),
	QUYEN varchar(10)
	PRIMARY KEY (USERNAME)
)

DROP TABLE PHONG

INSERT INTO LOAIPHONG
Values (2, N'Phòng đôi', '600000', null, null),
(3, N'Phòng VIP', '900000', null, null)
(1, N'Phòng đơn', '400000', null, null),

select * from LOAIPHONG

INSERT INTO PHONG
VALUES ('P1', 0, 2, 1),
('P2', 0, 1, 1),
('PD1', 0, 4, 2),
('PD2', 0, 5, 2),
('PV1', 0, 1, 3),
('PV2', 0, 2, 3)

select * from NHANVIEN

INSERT INTO NHANVIEN 
VALUES ('admin', '123', N'Admin test', '0987123456', N'TPHCM', 'Admin'),
('staff', '12345', N'Staff test', '0987543612', N'Hà Nội', 'Staff')

select TenLoaiPhong 
from LOAIPHONG
WHERE MALOAIPHONG = 2

Create table CT_NHANPHONG
(
	MAPHIEUNHAP char(10) not null,
	TENKH nvarchar(50),
	LOAIPHONG nvarchar(50),
	CMND char (14),
	GIOITINH nvarchar(6),
	NGAYNHAN datetime,
	NGAYTRA datetime,
	GIAPHONG int,
	MADV char(10),
	TENDV nvarchar(50),
	SOLUONGDV int
	PRIMARY KEY(MAPHIEUNHAP),
	Constraint FK_DV FOREIGN KEY (MADV) references DICHVU (MADV)
)

Create table DICHVU
(
	MADV char(10) not null,
	TENDV nvarchar(50),
	DONGIA int,
	PRIMARY KEY (MADV)
)
