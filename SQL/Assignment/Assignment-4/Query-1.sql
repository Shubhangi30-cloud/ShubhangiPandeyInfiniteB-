------Ouestion1-------
declare @z int
declare @result int
set @z = 5 
set @result = 1
while @z > 1
begin
    set @result = @result * @z
    set @z = @z - 1
end
select @result as factorial

 