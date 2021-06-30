create database PayrollService;
use PayrollService;
create table EmpPayroll(
EmployeeId int identity(1,1) primary key,
EmployeeName varchar(255),
Salary float,
StartingDate Date
);
insert into EmpPayroll(EmployeeName, Salary, StartingDate)
values('William', 100000, convert (date,'2010-8-19'));

select * from EmpPayroll;
select Salary from EmpPayroll where EmployeeName='William';
select * from EmpPayroll where StartingDate between cast('2005-8-19' as date) and cast('2015-8-19' as date); 

alter table EmpPayroll
add Gender varchar(255);
update EmpPayroll set Gender='Female' where EmployeeName = 'Smithi' or EmployeeName='Mandana';
update EmpPayroll set Gender='Male'where EmployeeName='William';
