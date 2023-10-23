use Assignment3DB

--Cursor Program ---
DECLARE @empno NUMERIC(4);
DECLARE @sal INT;

--	Declare The Cursor 
DECLARE employee_cursor CURSOR FOR
SELECT empno, sal
FROM employees
WHERE deptno = '10';

---Open the cursor 
OPEN employee_cursor;

--Fetch the first row 
FETCH NEXT FROM employee_cursor INTO @empno, @sal;
--
WHILE @@FETCH_STATUS = 0
BEGIN  

--Update The salary with a 15% increase 
UPDATE employeess
SET sal = sal * 1.15; 
WHERE empno = @empno; 
    
	--- Fetch again 
   
    FETCH NEXT FROM employee_cursor INTO @empno, sal;
END

--close the cursor 
CLOSE employee_cursor;
DEALLOCATE employee_cursor;

 --Select the upated records to verify 
 Select * from employees where deptno=10;