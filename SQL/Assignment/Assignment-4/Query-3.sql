create Database Assignment4DB
use Assignment4DB

--Creating table
create Table Holiday(
holiday_date Date,
holiday_name NVARCHAR(100)
);

--Insert holiday details
Insert into Holiday(holiday_date, holiday_name)
values
('2023-12-25', 'Christmas'),
('2023-11-12', 'Diwali'),
('2023-08-15', 'Independence Day'),
('2023-09-11', 'Thanksgiving')


select * from Holiday

--Trigger
create or alter trigger prevent_holiday_manipulation
on holiday
after insert, update, delete
as
begin
    declare @holiday_message nvarchar(100);
    declare @error_message nvarchar(200); 
    
    if exists (select 1 from holiday where holiday_date in (select holiday_date from inserted)) begin
        select @holiday_message = holiday_name from holiday where holiday_date in (select holiday_date from inserted);
        select @error_message = 'Due to ' + @holiday_message + ' you cannot manipulate data';
        rollback;
        raiserror(@error_message, 16, 1);
    end;
end;

update Holiday set holiday_name = 'holiiiii' where holiday_date='2023-12-25';

