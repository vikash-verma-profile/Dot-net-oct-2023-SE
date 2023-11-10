create function  GetFullName(@ID int)
returns varchar(200)
as
Begin
return (select concat(first_name,' ',last_name) from salespersons 
where salesperson_id=@ID );
END

select dbo.GetFullName(salesperson_id) as Name from salespersons

select * from salespersons;


select * from address;
select * from salespersons;

select concat(s.first_name,' ',s.last_name) NAME,
a.city,a.state,a.country from salespersons s left join 
address a on s.salesperson_id=a.address_id;


Create View GetData as
select dbo.GetFullName(s.salesperson_id) NAME,
a.city,a.state,a.country from salespersons s left join 
address a on s.salesperson_id=a.address_id;

select * from GetData;

-- EMP001
/*
[id]
      ,[employeename]
      ,[Salary]
      ,[DepartmentId]
      ,[EmpID]
*/
create proc InsertData(@employeename nvarchar(200),@Salary decimal(18,2)
,@DepartmentId int)
as 
BEGIN
insert into employee values(@employeename,@Salary,@DepartmentId,null);
update employee set [EmpID]=CONCAT('EMP',@@IDENTITY);
END

exec InsertData 'Vikash Verma',10000.00,1

select * from salespersons;
select * from address

select * from address where salesperson_id in (select salesperson_id 
from  salespersons)

create Index ind_sales on salespersons(salesperson_id)

alter proc testdata(@id int)
As
begin TRY
	select @id/0;
END TRY
BEGIN CATCH
PRINT 'ERRPR';
END CATCH
GO
exec testdata 1

create TRigger trg_sales on salespersons AFTER INSERT
AS BEGIN
insert into tblAudit values('New value inserted')

END


--select sum(amount) from tblemi where userid=1 group by userid 

DECLARE 
@NAME VARCHAR(MAX)
DECLARE spl_cur CURSOR for select first_name from salespersons;

OPEN spl_cur;
FETCH NEXT FROM spl_cur INTO @NAME;
WHILE @@FETCH_STATUS=0
	BEGIN
		PRINT @NAME;
		FETCH NEXT FROM spl_cur INTO @NAME;
	END
	CLOSE spl_cur;
	DEALLOCATE spl_cur;

