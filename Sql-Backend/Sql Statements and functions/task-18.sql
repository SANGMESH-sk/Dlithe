--1.primary and foreignkey constraints
--2.referntial integrity
--3.index
--4.sequences
--5.Views
--6.Synonyms

----- ========================== -----------
--1.working with pk and fk

--1.conditions
  --1) one table should contain pk and another table contains fk.
 ---2) a common column both in tables
 ---3) the common column datatype must be same in both tables
 -- ================================= -------------

---1) PARENT TABLE
create table DEPARTMENT(DEPTNO INT PRIMARY KEY, DNAME VARCHAR(40),
LOCATION VARCHAR(40))

--2)INSERTING VALUES IN TABLE STEP2
INSERT DEPARTMENT VALUES(10,'SAP','HYD'),(20,'HR','PUNE'),(30,'IT','CHENNAI')

SELECT * FROM DEPARTMENT

--3) CHILD TABLE
CREATE TABLE EMP(EMPID INT,ENAME VARCHAR(40),SALARY MONEY,
DEPTNO INT FOREIGN KEY REFERENCES DEPARTMENT(DEPTNO))

-- CHECKING RELATION ESTABLISHED OR NOT 
SELECT * FROM DEPARTMENT
SELECT * FROM EMP

--TEST 
INSERT EMP VALUES (103,'ADAM1',50000,20)
INSERT EMP VALUES (104,'SCOTT',40000,30)

----------------------------------------

2.REFERNCIAL INTEGRITY:- 
INTEGRITY:- SAME VALUE for the database of the products
it means the reference from A row in one table to another table

--- ============== -----

delete from EMP where DEPTNO=10 -- error -- we are not able to delete data from parent table 

 --- to overcome this we are using 
 --On delete Cascade- and On update Cascasde

 alter table emp drop constraint FK__EMP__DEPTNO__5DCAEF64
 alter table emp drop constraint FK__EMP__DEPTNO__5DCAEF64 foreign key(emp)
 references department(deptno) on delete cascade;

 delete from EMP where DEPTNO=10 

 select * from emp


 alter table emp drop constraint FK__EMP__DEPTNO__5DCAEF64
 update emp set empid=105 where empid=103
 
 --- index es-----
 3.INDEX :- indexes are used by queries to find data from tables quickly indexes are created on tables and view

 select * from Employees
 
 -- a clustered index is an index which defines the physical order in which table recorrds are stored in a database
 -- threre can be only one clutered index per table by default a clutered index created in primary column
 
  1. clustered index:- if we have primary key column in a table
  automatically it will become clustered index

 --2.  non clustered index
 select * from students where salary=30000
 create index in_stu on students (salary asc)

 4.SEQUENCES:- --SEquences object is defined by the user and can be shared by multiple users 
 --and can be shared by multiple tables since it is not tied to ant table 

 create sequence dbo.sqstunts as int 
 start with 1 
 increment by 1
 
 select * from sys.sequences where name='sqstunts'

 create table sq_student(
 id int primary key,
 name varchar(25),
 lastname varchar(40)
 )

 select next value for dbo.sqstunts

 insert into sq_student values(next value for dbo.sqstunts,'pooja','biradar')
 
 insert into sq_student values(next value for dbo.sqstunts,'geeta','swamy')
 
 insert into sq_student values(next value for dbo.sqstunts,'shravani','biradar')
 
 insert into sq_student values(next value for dbo.sqstunts,'supriya','biradar')

 select * from sq_student

 5.Views:- a view is a virtual table based on the result-set of an sql statement
 -- virtual table
 --view is the result set of a stored query
 --read-only vs updatable views
 -- materialized view

 select * from students

 -- creating a simple view
 CREATE VIEW detailsview as select id, 
 designation from students 

select * from detailsview


6. synonym :-is an alias or alternative name for a
database object such as table view , stored procedure etc

 create synonym std for dbo.students 

 -- here we created the alias name for students as std

 select * from std

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

 --select salary,count(*) from employees group by salary having salary >40000

 --select designation,sum(salary)  totalsalary from employees 
-- group by designation


   select * from Employees

   syntax:- count()

   select count(*) from employees
   sum() 
   ex:- select sum(salary) from employees

   select avg(salary) from employees

   order by clause:-
   syntaxx:- select expression from table where condition order by expression asc/desc

   ex:-
    select * from employees where salary>40000 order by salary asc

	group by clause:-

	select designation,count(*) totalemp from employees group by designation

	select salary,count(*) from employees group by salary having (salary)> 40000
