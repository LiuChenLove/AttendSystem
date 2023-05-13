--建立資料庫
create database AttendSystem
use AttendSystem
--建立使用者資料表
create table UserTable(
	id int identity(0,1) ,
	GU_ID uniqueidentifier  default NEWID() primary key,
	name nvarchar(20) not null,
	account varchar(100) not null,
	password varchar(100) not null,
	email varchar(100) not null,
	nick_name nvarchar(20),
	gender char(1) not null,
	create_time datetime default getdate() not null,
	create_sid int not null,
	update_time datetime default getdate() not null,
	update_sid int not null,
	deleted bit default 0
)
SELECT * FROM UserTable