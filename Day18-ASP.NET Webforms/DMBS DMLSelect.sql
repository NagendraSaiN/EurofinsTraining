create table Customer(
	customer_ID numeric(5) primary key,
	cust_Name varchar(30),
	city varchar(15),
	grade numeric(3),
	salesman_ID numeric(5)references Salesman(salesman_ID))

create table Salesman(
	salesman_ID numeric(5) primary key,
	Name varchar(30),
	City varchar(15),
	Commission decimal(5,2))
	
create table Orders(
	ord_no numeric(5) primary key,
	purch_amt decimal(8,2),
	ord_date Date,
	customer_ID numeric(5)Foreign Key (customer_ID) references Customer(customer_ID),
	salesman_ID numeric(5)Foreign Key (salesman_ID) references Salesman(salesman_ID))



insert into Customer values(3002,'Nick Rimando','New York',100,5001);
insert into Customer values(3007,'Brad Davis','New York',200,5001);
insert into Customer values(3005,'Graham Zusi','California',200,5002);
insert into Customer values(3008,'Julian Green','London',300,5002);
insert into Customer values(3004,'Fabian Johnson','Paris',300,5006);
insert into Customer values(3009,'Geoff Cameron','Berlin',100,5003);
insert into Customer values(3003,'Jozy Altidor','Moscow',200,5007);
insert into Customer values(3001,'Brad Guzon','London',NULL,5005);

insert into Salesman values(5001,'James Hoog','New York',0.15);
insert into Salesman values(5002,'Nail Knite','paris',0.13);
insert into Salesman values(5005,'Pit Alex','London',0.11);
insert into Salesman values(5006,'Mc Lyon','Paris',0.14);
insert into Salesman values(5007,'Paul Adam','Rome',0.13);
insert into Salesman values(5003,'Lauson Hen','San Jose',0.12);

insert into Orders values(70001,150.5,'2012-10-05',3005,5002);
insert into Orders values(70009,270.65,'2012-09-10',3001,5005);
insert into Orders values(70002,65.26,'2012-10-05',3002,5001);
insert into Orders values(70004,110.5,'2012-08-17',3009,5003);
insert into Orders values(70007,948.5,'2012-09-10',3005,5002);
insert into Orders values(70005,2400.6,'2012-07-27',3007,5001);
insert into Orders values(70008,5760,'2012-09-10',3002,5001);
insert into Orders values(70010,1983.43,'2012-10-10',3004,5006);
insert into Orders values(70003,2480.4,'2012-10-10',3009,5003);
insert into Orders values(70012,250.45,'2012-06-27',3008,5002);
insert into Orders values(70011,75.29,'2012-08-17',3003,5007);
insert into Orders values(70013,3045.6,'2012-04-25',3002,5001);



Select * from Salesman;
Select name,commission from salesman;
select ord_date,salesman_ID,ord_no,purch_amt from Orders;
Select distinct salesman_ID from Salesman;
Select Name, City from Salesman where City = 'Paris';
Select customer_ID, cust_name, City,grade,salesman_ID from Customer where grade =200;
Select ord_no,ord_date,purch_amt from Orders where salesman_ID = 5001;
Select customer_ID, cust_name, City,grade,salesman_ID from Customer where grade >100;
Select customer_ID, cust_name, City,grade,salesman_ID from Customer where grade >100 and city = 'New York';
Select customer_ID, cust_name, City,grade,salesman_ID from Customer where grade >100 or city = 'New York';
Select customer_ID, cust_name, City,grade,salesman_ID from Customer where grade !>100 and city != 'New York';
Select ord_no,purch_amt,ord_date,customer_ID,salesman_ID from Orders where ord_date='2012-09-10' and salesman_ID>5005 or purch_amt>1000; 
Select salesman_id,Name,City,Commission from Salesman where 0.10<=Commission and Commission<=0.12;
Select SUM(purch_amt) 'Total Purchase amount' from Orders;
Select AVG(purch_amt) 'Average Purchase amount' from Orders;
Select COUNT(distinct Name) 'Number of SalesPeople' from Salesman;
Select COUNT(cust_Name) 'Number of Customers' from Customer;
Select COUNT(cust_Name) 'Number of Customers' from Customer where grade is not null;
Select MAX(purch_amt) 'Maximum Purchase Amount' from Orders;
Select MIN(purch_amt) 'Minimum Purchase Amount' from Orders;
Select customer_ID,ord_date,MAX(purch_amt) from Orders Group By customer_ID,ord_date Having MAX(purch_amt)>2000.00; 
Select customer_ID,ord_date,MAX(purch_amt) from Orders Group By customer_ID,ord_date Having MAX(purch_amt) Between 2000 and 6000;
Select customer_ID,ord_date,MAX(purch_amt) from Orders Group By customer_ID,ord_date Having MAX(purch_amt) = 2000 or MAX(purch_amt) = 3000 or MAX(purch_amt) = 5760 or MAX(purch_amt) = 6000;
Select customer_ID,MAX(purch_amt) from Orders Group By customer_ID Having customer_ID between 3002 and 3007;

