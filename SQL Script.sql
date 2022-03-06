CREATE DATABASE HotelManagementSystem;

USE HotelManagementSystem;

CREATE TABLE UserInfo(
	UserID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	UserName varchar(50) not null unique,
	email varchar(50) not null unique,
	pass varchar(50) not null,
	UserRole varchar(50) default 'User',
	ClientID int NOT NULL FOREIGN KEY REFERENCES ClientInfo(ClientID)
);
INSERT INTO UserInfo VALUES('admin', 'admin', 'admin', 'Administrator', 1);

CREATE TABLE ClientInfo(
	ClientID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	ClientN varchar(50) NOT NULL,
	ClientLN varchar(50) NOT NULL,
	ClientPhone varchar(50) NOT NULL UNIQUE,
	ClientAddress varchar(200) NOT NULL UNIQUE
);

CREATE TABLE RoomTable(
	RoomNumber int NOT NULL PRIMARY KEY IDENTITY(1,1),
	RoomType varchar(50) NOT NULL,
	RoomPhone varchar(50) NOT NULL,
	RoomFree varchar(3) NOT NULL
);
INSERT INTO RoomTable VALUES('Single','1938291831','Yes'),('Double','123131','Yes'),('Family','123','Yes'),('Suite','18321','Yes');

CREATE TABLE ReservationTable(
	ReservationID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ReservationRoomType varchar(50) NOT NULL,
	ReservationRoomNumber varchar(20) NOT NULL,
	ReservationClientID INT UNIQUE NOT NULL,
	ReservationIN varchar(50) NOT NULL,
	ReservationOUT varchar(50) NOT NULL,
	RoomNumber INT NOT NULL DEFAULT 1 FOREIGN KEY REFERENCES RoomTable(RoomNumber),
	ClientID INT NOT NULL DEFAULT 1 FOREIGN KEY REFERENCES ClientInfo(ClientID)
);