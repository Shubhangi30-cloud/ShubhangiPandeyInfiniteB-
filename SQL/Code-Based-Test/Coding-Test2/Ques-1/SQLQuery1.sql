Create database  CodeBasedTest
use CodeBasedTest

create table Code_Employees (
    empno int primary key,
    empname varchar(35) NOT NULL,
    empsal numeric(10,2) check (empsal >= 25000),
    emptype char(1) check (emptype IN ('F', 'P'))
);


create procedure AddEmployee
    @empname varchar(35),
    @empsal numeric(10,2),
    @emptype char(1)
AS
BEGIN
    DECLARE @new_empno int;

 

    -- Generate a new employee number
    SELECT @new_empno = COALESCE(MAX(empno), 0) + 1 FROM Code_Employees;

 

    -- Insert the new employee record
    INSERT INTO Code_Employees(empno, empname, empsal, emptype)
    VALUES (@new_empno, @empname, @empsal, @emptype);
END;

select *from Code_Employees
