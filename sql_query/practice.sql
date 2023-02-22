/*gives distinct value of lecture in both tables
select lecture from Professor union select lecture from student;*/

/* exists operetor on subquery returns all if true 
select firstname from student where exists (select lecture from Professor where lecture='DBMS');*/

/* ANY

select * from student where address= any (select address from Professor where Address='Varanasi');*/
/*alter table Professor add gender varchar(1);
select * from Professor;*/
