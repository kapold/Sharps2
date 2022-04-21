USE master;

DROP DATABASE universityDB;
GO
-- Создаем БД
CREATE DATABASE universityDB;
GO

-- Добавляем таблицы
USE universityDB;

-- Table [Addresses]
CREATE TABLE Addresses(
    ID int NOT NULL primary key,
    City nvarchar(50) NULL,
    C_Index int NULL,
    Street nvarchar(50) NULL,
    Home nvarchar(50) NULL
)
GO

-- Table [Students]
CREATE TABLE Students(
	StudentID int IDENTITY(1, 1) NOT NULL primary key,
    AddressID int foreign key references Addresses(ID),
	Name nvarchar(32) NULL,
	Surname nvarchar(32) NULL,
	Patronymic nvarchar(32) NULL,
    Speciality nvarchar(30) NULL,
    Birthday date NULL,
    Course int NULL check(Course > 0),
    GroupNumber int NULL check(GroupNumber > 0),
    Gender nvarchar(20) NULL,
	PhoneNumber char(12) NULL,
	ImageSrc nvarchar(MAX) NULL
)
GO

-- delete from Students where StudentID = 2;
-- delete from Addresses where id = 2;