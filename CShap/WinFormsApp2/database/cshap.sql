﻿use master 
go
drop database if exists CShap
create database CShap
go
use CShap
go

drop table if exists Student
create table Student (
	Id int primary key identity,
	FirstName nvarchar(50),
	LastName nvarchar(50),
	Gender bit,
	Dob date
)
go

insert into Student ( FirstName, LastName , Gender, Dob) values (N'Kha',N'Kiều',1,'2003-06-16')
go 10