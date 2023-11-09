CREATE DATABASE BOOKDB;
USE BOOKDB;
CREATE TABLE tblBook(ID int,BookName nvarchar(200));
SELECT * FROM tblBook
INSERT INTO tblBook(ID,BookName) values(1,'LETS LEARN SQL');
INSERT INTO tblBook(ID,BookName) values(2,'LETS LEARN SQL 1 ');
INSERT INTO tblBook(ID,BookName) values(3,'LETS LEARN SQL 2');
INSERT INTO tblBook(ID,BookName) values(4,'LETS LEARN SQL 3');

Update tblBook set BookName='Vikash' where ID=1
DELETE tblBook  where ID=1;

ALTER TABLE tblBook ADD QUANTITY int;

Update tblBook set QUANTITY=5 ;

ALTER TABLE tblBook DROP COLUMN QUANTITY;

ALTER TABLE tblBook ALTER COLUMN QUANTITY nvarchar(6);

SELECT * FROM tblBook

Drop table tblBook
-- ALTER TABLE tblBook ALTER COLUMN INVENTORU nvarchar(6);


CREATE TABLE tblBook(ID int identity(1,2),BookName nvarchar(200));
insert into tblBook values('Vikash')
insert into tblBook values('Vikash 2 ')
insert into tblBook values('Vikash 3')

select * from tblBook where BookName like 'h'
select * from tblBook where BookName like '%h'
select * from tblBook where concat(BookName,Description) like 'LeTS%'

INSERT INTO tblBook values(' A smile in the mind'),('The Power of Now'),
('The Brain That Changes Itself.'),('Andrea Agassis OPEN');


ALTER TABLE tblBook ADD Description nvarchar(500);

select concat(BookName,Description) as BookDescription from tblBook

select * from tblBook where id in (1,2,3,4)
select * from tblBook where id not in (1,2,3,4)

select * from tblBook where Id BETWEEN 1 AND 7

select * from tblBook where Id >1 AND Id <7;

select * from tblBook where Id >1 OR Id <10;

select * from tblBook order by id asc

select * from tblBook order by id desc

select Top 5 * from tblBook
update tblBook set BookName='Vikash 2 ' where id=1;

select distinct Top 5 BookName from tblBook;
select distinct BookName from tblBook;
select BookName from tblBook;

select count(*) from tblBook;
select Min(Id) from tblBook;
select Max(Id) from tblBook;
select SUM(Id) from tblBook;
select AVG(Id) from tblBook;

create table employee(id int identity(1,1),employeename nvarchar(200),Salary decimal(18,2),DepartmentId int);
create table department(id int identity(1,1),DepartmentName nvarchar(200));

select * from employee;
select * from department;

select * from employee as emp join department as dep on emp.DepartmentId=dep.id; --inner join
select * from employee as emp left join department as dep on emp.DepartmentId=dep.id;--left join
select * from employee as emp right join department as dep on emp.DepartmentId=dep.id;-- right join
select * from employee as emp FULL outer join department as dep on emp.DepartmentId=dep.id;-- outer join

select * from tblCustomer c join tblCustomer b on c.ID <> b.ID  and
c.city=b.city-- self join

select city,count(*) from tblCustomer group by city

select GETDATE()

select * from tblOrders
select * from employee

select emp.employeename,count(o.OrderID) As NoOFOrders from
(tblOrders o inner join employee emp on o.EmlopyeeID=emp.id)
group by employeename having count(o.OrderID) >1