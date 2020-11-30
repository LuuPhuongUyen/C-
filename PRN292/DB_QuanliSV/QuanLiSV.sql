CREATE DATABASE [QuanLiSV]
GO
USE [QuanLiSV]
CREATE TABLE [Lop]
(Malop char(10) NOT NULL  primary key,
Tenlop nvarchar(50),
Nam int )
GO
INSERT INTO [Lop](Malop,Tenlop,Nam)
VALUES
('LT01',N'Lập trình Mobile 1801',2018),
('LT02',N'Lập trình Hệ thống 1701',2017),
('MM01',N'Quản trị mạng 1901',2019)
GO
CREATE TABLE [SinhVien]
(Masv char(10) NOT NULL primary key,
Hoten nvarchar(50),
Malop char(10))
GO
INSERT INTO [SinhVien](Masv,Hoten,Malop)
VALUES
('sv01',N'Nguyễn Văn An','LT01'),
('sv02',N'Nguyễn Như Vũ ','LT01'),
('sv03',N'Ngô Hải Quỳnh','MM01'),
('sv04',N'Nguyễn Thùy Dương','MM01'),
('sv05',N'Trần Văn Nam','LT02')
