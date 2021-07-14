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

select * from PHONG

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


Create table HOADONPH
(
	MAHD char(10) not null,
	MAKH char(10),
	MADV char(10),
	SOLUONGDV int,
	DONGIADV int,
	MAPH char (10),
	DONGIAP int,	
	NGAYVAO datetime,
	NGAYRA datetime,
	PRIMARY KEY(MAHD),
	CONSTRAINT FK_DVNP FOREIGN KEY (MADV) REFERENCES DICHVU (MADV),
	CONSTRAINT FK_KH FOREIGN KEY (MAKH) REFERENCES KHACHHANG (MAKH),
	CONSTRAINT FK_P FOREIGN KEY (MAPH) REFERENCES PHONG (MAPHONG),
)

select * from HOADONPH

DROP TABLE HOADONPH

Create table DICHVU
(
	MADV char(10),
	TENDV nvarchar(50),
	DONGIA int,
	PRIMARY KEY (MADV)
)

INSERT INTO DICHVU
VALUES ('DV01', N'Giặt ủi quần áo', 50000),
('DV02', N'Thuê phương tiện di chuyển', 150000),
('DV03', N'Ăn sáng', 75000),
('DV04', 'Pepsi', 20000),
('DV05', N'Nước ép các loại', 40000)

select * from DICHVU

DROP TABLE DICHVU

Create table KHACHHANG
(
	MAKH char(10) not null,
	TENKH nvarchar(50),
	CMND char(14),
	GIOITINH nvarchar(6),
	DTHOAI char(10),
	DCHI nvarchar(50),
	PRIMARY KEY (MAKH)
)

Select * from KHACHHANG

INSERT INTO KHACHHANG
VALUES ('KH01', N'Nguyễn Văn Phú', '2509281932','Nam', '0985326741', N'Quận 4, Thành phố Hồ Chí Minh'),
('KH02', N'Lê Thị Mỹ Vân', '3002486612',N'Nữ', '0153692874', N'Quận Tân Bình, Thành phố Hồ Chí Minh'),
('KH03', N'Trần Đức Ninh', '369281751','Nam', '0659182741', N'Đức Hòa, Long An'),
('KH04', N'Ngô Thành Nam', '326281699','Nam' ,'0362951847', N'Quận 2, Thành phố Hồ Chí Minh')

INSERT INTO KHACHHANG
VALUES ('KH05', N'Khách vãng lai', null, null, null,null)

select * from HOADONPH


Create table CHITIETHD
(
	MAHD char(10),
	TONGTIENDV int,
	TONGTIENPHONG int,
	THANHTIEN int
	PRIMARY KEY (MAHD),	
)

DROP TABLE CHITIETHD

select * from CHITIETHD

 




