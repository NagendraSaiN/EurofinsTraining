create table StrProc(
	Name varchar(50),
	Age numeric,
	Gender varchar(10),
	Number numeric(10),
	Amount decimal(8,2))
insert into StrProc values('Nagendra',21,'Male',8074857565,100);
insert into StrProc values('Jithu',19,'Male',8074857666,200);
insert into StrProc values('Subbu',39,'FeMale',8074857777,300);
insert into StrProc values('Nageswar',45,'Male',8074857888,400);
insert into StrProc values('Thor',100,'Male',8074857999,600);
insert into StrProc values('SpiderMan',50,'Male',8074857111,300);
insert into StrProc values('IronMan',47,'Male',8074857222,1000);
insert into StrProc values('Joker',25,'Male',8074857333,900);
insert into StrProc values('Hulk',99,'Male',8074857444,10000);
insert into StrProc values('AntMan',15,'Male',8074857555,400);
--To create a tore proc

Alter Proc spExam
As
Begin
	Select Name,Gender,amount from StrProc where Age>45 
End



sp_helptext spExam
drop Proc spExam






alter Procedure spExample
As
Begin
	Select Name,Gender,Amount from StrProc where age>40
End

spExample
execute spExample
sp_helptext spExample
