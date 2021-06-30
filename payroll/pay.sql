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

select sum(Salary) from EmpPayroll where Gender='Male'; 
select avg(Salary) from EmpPayroll;
select min(Salary) from EmpPayroll;
select max(Salary) from EmpPayroll;
select count(EmployeeId) from EmpPayroll;

alter table EmpPayroll
add PhoneNumber varchar(255)
update EmpPayroll set PhoneNumber='1234567890' where EmployeeName='William';
alter table EmpPayroll
add Address varchar(255)
update EmpPayroll set Address='India' where EmployeeName='William';
alter table EmpPayroll
add Department varchar(255)
update EmpPayroll set Department='Digital Marketing' where EmployeeName='William';

alter table EmpPayroll
add Basic_Pay float;
alter table EmpPayroll
add Deductions float;
alter table EmpPayroll
add Taxable_Pay float;
alter table EmpPayroll
add Net_Pay float;
alter table EmpPayroll
add Income_Tax float;


select * from EmpPayroll;

