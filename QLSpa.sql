CREATE DATABASE QLSpa
GO

USE QLSpa
GO

CREATE TABLE NhanVien
(
	MaNV VARCHAR(20) PRIMARY KEY,
	TenNV NVARCHAR(100),

)

 CREATE TABLE DichVu
 (
	MaDV VARCHAR(20) PRIMARY KEY,
	TenDV NVARCHAR(100),
	ThoiGianDV INT,
	GiaDV INT,
 )

 CREATE TABLE ThangDemo
 (
	STT INT PRIMARY KEY IDENTITY(1,1),
	Ngay DATETIME DEFAULT(GETDATE()),
	MaNV VARCHAR(20) FOREIGN KEY REFERENCES dbo.NhanVien(MaNV),
	MaDV VARCHAR(20) FOREIGN KEY REFERENCES dbo.DichVu(MaDV),
	ThoiGianDV INT DEFAULT(0),
	TienCer INT DEFAULT (0),
	TienMat INT DEFAULT(0),
 )

 INSERT dbo.NhanVien VALUES ('',N'')
 UPDATE dbo.NhanVien SET TenNV = N'' WHERE MaNV = ''
 DELETE dbo.NhanVien WHERE MaNV = ''

 DROP TABLE dbo.NhanVien
 DROP TABLE dbo.DichVu
 DROP TABLE dbo.ThangDemo
 DROP TABLE dbo.ThangDemo 

 SELECT * FROM dbo.DichVu
 SELECT * FROM dbo.NhanVien
 SELECT * FROM dbo.ThangDemo

 INSERT INTO 

 INSERT INTO dbo.ThangDemo VALUES (,'','', 0,0,0)

 INSERT INTO dbo.ThangDemo
 (
     Ngay,
     MaNV,
     MaDV,
     ThoiGianDV,
     TienCer,
     TienMat
 )
 VALUES
 (   '20180307', -- Ngay - datetime
     'MANH',        -- MaNV - varchar(20)
     'TT',        -- MaDV - varchar(20)
     75,         -- ThoiGianDV - int
     2200,         -- TienCer - int
     0          -- TienMat - int
     )
DELETE dbo.ThangDemo WHERE MaNV = 'DUC'



SELECT ThoiGianDV FROM dbo.DichVu WHERE MaDV = 'LD'
 
CREATE TABLE TaoThang (MaThang NVARCHAR(30) PRIMARY KEY,TenThang NVARCHAR(50))
DROP TABLE dbo.Tha


CREATE TABLE ThangDemo ( STT INT PRIMARY KEY IDENTITY(1,1), Ngay DATETIME DEFAULT(GETDATE()), MaNV VARCHAR(20) FOREIGN KEY REFERENCES dbo.NhanVien(MaNV), MaDV VARCHAR(20) FOREIGN KEY REFERENCES dbo.DichVu(MaDV), ThoiGianDV INT DEFAULT(0), TienCer INT DEFAULT (0), TienMat INT DEFAULT(0), )

CREATE TABLE ThongKeThang 
(
	TenBang VARCHAR(50),
)

INSERT INTO dbo.ThongKeThang VALUES ('')

SELECT TenBang FROM dbo.ThongKeThang
select * from dbo.ThongKeThang

DROP TABLE dbo.ThongKeThang


SELECT * FROM Thang4
SELECT * FROM Thang3 WHERE Ngay = '03/09/18'
DELETE thang4 WHERE STT = 2
DROP TABLE 
SELECT * FROM dbo.ThangDemo WHERE Ngay = '' MaDV LIKE '%%' OR MaNV LIKE '%%'
SELECT * FROM " + _TenBang + " WHERE Ngay = '" + _Ngay + "' AND MaDV LIKE '%" + id + "%' OR Ngay = '" + _Ngay + "' AND MaNV LIKE '%" + id + "%'

SELECT * FROM dbo.NhanVien

SELECT nv.MaNV,SUM(thang.ThoiGianDV) AS ThoiGian, SUM(thang.TienCer) AS TienCer, SUM(thang.TienMat) AS TienMat,SUM(thang.TienCer) + SUM(thang.TienMat) AS TongTien FROM Thang3 AS thang, dbo.NhanVien AS nv
WHERE thang.MaNV = nv.MaNV
GROUP BY nv.MaNV


, thang.TienMat, (thang.TienCer + thang.TienMat)