create database MovieDetails
use MovieDetails
create table movie(M_Id int identity primary key,Name varchar(100),MovieType Varchar(100),MovieDesc varchar(max))
create table MovieShowTime(S_Id int identity primary key,MovieId int references movie(M_Id),StartTime varchar(20),ShowDate date)
Select * from movie