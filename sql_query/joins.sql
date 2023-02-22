/*alter table student add gender varchar(1);
update student set gender='M',lecture='DBMS' where roll_number=5;*/
/* Performing inner join on table student and professor on lecture

select * from student inner join Professor on student.lecture=Professor.lecture;*/

/* Performing full outer join on table student and professor on lecture 
select * from student full outer join Professor on student.lecture=Professor.lecture;*/

/* Performing left join on table student and professor on lecture
select * from student left join Professor on student.lecture=Professor.lecture;*/

/* Performing right join on table student and professor on lecture
select * from student right join Professor on student.lecture=Professor.lecture;*/

/* Performing self  join on table student
select * from student s1 , student s2 where s1.address=s2.address and s1.lecture=s2.lecture order by s1.firstname;*/

 /*Performing self  join on table student and professor 
select * from student cross join Professor;*/



