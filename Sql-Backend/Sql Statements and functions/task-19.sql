1.subqueries
2.functions
3.group sets ,rollup,cube ,colasce
4. procedures


-- subqueries --
-- a query within a query we called it as sub query

 -- ex:- 
 select * from students

--1. a normal query:-
-- diplaying maximum salary 
select max(salary) from students

--2. now we want to print maximum salary student name then we are using sub-query
-- sub query
select name from students where salary=(  -- oterquery  through 50k it will retrive student name aman
select max(salary) from students)      -- inner query  will retrive 50000

-- ex:-2
select name from students where salary=(  -- david
 select min(salary) from students) 

 ex:-3

  select * from students where id in
  (select id from students where salary>30000)

  ex:-4 -- updating
  update students set salary=salary*0.1 where id in(select id from students where id>2)
 
 select * from students

 ex:--- deleting 
   delete from students  where id in(select id from students where id=6)
   
   ex:--- insert

     insert into students  select * from students where id in(select id from students )

	----------------------------------
2. FUNCTION :- a function perform set of operations or action
 its having two types 
  1.system defined function
  2. user defined function

  2. user defined function we have 3 types
   i)scalar
   ii)inline table valued
   iii)multi statement table valued

   i) scalar function :-
    create function newfun(@a int,@b int)
	returns int 
	as 
	begin 
	 return (@a*@a*@a)
	 end
	 
	 -- now we are calling the function
	 select dbo.newfun(2,2) as result
 
 (ii) inline function:- it returns a table it has no begin and end section
 select * from students
 create function funin(@san int)
 returns table 
 as 
 return (select * from students where id=@san)
  
  select * from funin(1)

  (iii) multi level function:- 
  a multi-statement table- valued function that returns the result of multiple statements
 -- ex:- 
  create function udfcontact() 
  returns @table table(
  id varchar(50),
  name varchar(50),
  designation varchar(255),
  salary varchar(25))
  as begin 
  insert into @table
  select id,name,designation,salary from students where designation='hr';
  return 
  end

  select * from udfcontact() -- retriving the data
  select * from students


 -- 3. grouing sets:-
 -- are extension to the group by clause
 select designation,sum(salary) from students group by GROUPING SETS
 ((designation,salary))

 rollup:-it is extension to the group by clause
 -- the roll up option extension to you to include extra
 --roes that represents the subtotal

  select designation,sum(salary) from students group by designation

  select designation,sum(salary)totalsalary from students group by rollup( designation)

  ------------------


  coalesce-- replaces the null value with actual value
  select coalesce(designation,'overall_totalsalary') as student_designation ,sum(salary) as totalsalary from 
  students group by rollup(designation)

    -------------------------
    cube:-
  select coalesce(designation,'overall_totalsalary') as student_designation ,sum(salary) as totalsalary from 
  students group by cube(designation)

  select * from students
  --------------------
  stored procedure-- 

  -- pre compiled sql statement
  -- saves time (avoids query writing again and again)
  -- two types 1) system defined 2)user defined

  select * from students
  -- procedure with no parameter
  create procedure pro_stud
  as 
  begin
  select * from students where salary>10000;
  end
  execute pro_stud
  
  -- procedure with parameter
  -- input parameter
  create procedure sp_stud(@dept varchar(30)) 
  as 
  begin
  select * from students where designation=@dept
  end
  execute sp_stud'hr'

  --output parameter
  alter procedure sp_ostud(@minsalary int output)
  as
  begin
  select @minsalary=min(salary) from students 
  end

  Declare @result int
  exec sp_ostud @result OUTPUT
  print @result

  ---------------------------
  sql joins:-
  create table person (pid int,pname varchar(40),pemailid varchar(30),courdeid int)
  insert into person values (1,'john','john@gmail.com',10)
   insert into person values (2,'scott','scott@gmail.com',20)
   insert into person values (3,'adam','adam@gmail.com',30)

   create table course(courdeid int,cname varchar(20),cfee decimal(6,2))
      insert into course values (50,'gcp',1700)
   
   select * from person 
   select * from course

   -- inner join retrive the data from multiple data based on equality condition it is called inner join
   -- a common column is required in inner query and must be same matching data/ row

   -- syntax:-
   select */ <list of column names> from <tn1>
   <join key> <tn2> on (joining condition);

   select * from person inner join course on person.courdeid=course.courdeid

