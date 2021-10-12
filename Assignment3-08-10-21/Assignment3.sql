Create database EmployeeManagement;

use EmployeeManagement;

Create table Project (project_number numeric(5) primary key identity,
						proj_name varchar(50) not null,
						startdate date not null  
						);

Create table Department (dept_number numeric(5) primary key identity(100,1),
						dept_name varchar(50) not null
						);

Create table Employee (emp_id numeric(10) primary key identity(1000,1),
						title varchar(20) not null,
						first_name varchar(20) not null,
						last_name varchar(20) not null,
						gender varchar(10) not null,
						DOB date not null,
						Hired_date date not null,
						dept_number numeric(5) references Department(dept_number) on delete cascade ,
						project_number numeric(5) references Project(project_number) on delete cascade
						);
drop table Employee
drop table Department

insert into Project values('proj1','2012-10-10');
insert into Project values('Data science','2021-07-26');
insert into Project values('Digit recognition','2020-09-17');
insert into Project values('DSA','2021-05-19');
insert into Project values('Face recognition','2020-01-10');
insert into Project values('Machine learning','2021-06-26');

insert into Department values('IT');
insert into Department values('HR');
insert into Department values('Security');
insert into Department values('Marketing');
insert into Department values('Administration');

insert into Employee values('ASE', 'Rakesh', 'Thakur','Male','1999-06-27', '2021-09-02', 100, 3);
insert into Employee values('ASE', 'Nagendra', 'Sai','Male','1999-08-10', '2021-09-02', 100, 2);
insert into Employee values('ASE', 'Sanket', 'V','Male','1999-10-15', '2021-09-02', 100, 6);
insert into Employee values('ASE', 'Sneha', 'Lalita','Female','1999-05-06', '2021-09-02', 100, 5)
Select * from Project