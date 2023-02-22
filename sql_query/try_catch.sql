/* try catch in sql */
begin try
select firstname + roll_number from student
end try
begin catch
print 'Error Occurred'
end catch
go
