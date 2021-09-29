create table Movie(
	mID int primary key,
	title varchar(200) unique,
	myear int unique,
	check(myear>1900),
	director varchar(200))

create table Reviewer(
	rID int primary key,
	name varchar(200) not null)

create table Rating(
	mID int foreign key(mID) references Movie(mID),
	rID int foreign key(rID) references Reviewer(rID), 
	Stars int not null, 
	rDate int, check(Stars>=1 and Stars<=5 and rDate>2000))
	 
insert into Movie values(1,'Inception',2010,'Christopher Nolan')
insert into Movie values(2,'Tenet',2021,'Christopher Nolan')
insert into Movie values(3,'Avengers',2014,'Stan Lee')
insert into Reviewer values(1,'Nagendra')
insert into Reviewer values(2,'Subbu')
insert into Rating values(3,1,4,2021)
insert into Rating values(2,2,5,2022)


select * from Movie;
select * from Reviewer;
select * from Rating;
