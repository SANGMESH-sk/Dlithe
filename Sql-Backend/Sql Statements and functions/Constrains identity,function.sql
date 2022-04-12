Constraints:- constraints are used to specify rules for the data in a table. 
               are used to limit what type of data that can go into a table
			    it ensures accuracy and reliability of the data in the table

  the following constraints commonly used in sql
       1.NOT-NULL :- IT Ensures that column cannot have null vaues

	   2.UNIQUE :-   IT Ensures that all the values prsent must be diffrent

	   3.PRIMARY-KEY:-it is the combination of not-null and unique key

	   4.FOREIGN-KEY:- it is used for linking two table
	   5.CHECK:-      IT use for checking the condition 
	   6.Default:-    it sets a default value for a column if no value is sppecified

	   --Ex:- CREATING TABLE WITH CONSTRAINTS 
	   create table persons(
	   ID INT PRIMARY KEY,NAME VARCHAR(40) UNIQUE,
	   LASTNAME VARCHAR(50) NOT NULL, AGE INT,check(age>18), 
	   city varchar(50)  DEFAULT 'bidar');

	   select * from persons

	   insert into persons values(1,'chetan','biradar',24,'bidar')

	   insert into persons values(2,'chetanya','biradar',23)

	   insert into persons values(3,'chetu','dr',19)

	   drop table persons

	   --working with pk and fk

--1.conditions
  --1) one table should contain pk and another table contains fk.
 ---2) a common column both in tables
 ---3) the common column datatype must be same in both tables


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
    INSERT EMP VALUES (103,'ADAM1',50000,10)
    INSERT EMP VALUES (104,'SCOTT',40000,30)
 
 -- NOW WE ARE DONE THE RELATION SHIP OF PK AND FK


 -- working with identity---
 2. IDENTITY:-a identity column of a table whose value increases automatically
             the value in an identity column is created by the server
    
	EX:-
	CREATE TABLE OBJ(
	ID INT IDENTITY (1,1),
	NAME VARCHAR(50)
	)

	INSERT INTO OBJ VALUES('GEETA')

3. NOW WE ARE EXPLORING FUNCTIONS
 FUNCTIONS:- sql server has many built-in functions this reference contains string,numeric,date conversion and some other

 1.date and time function:-
  select sysdatetime() as 'dateandTime' --date and time

    select sysdatetimeoffset() as 'dateandTime' --date time offset

	select sysutcdatetime() as 'dateandTime' --date and time in utc

	select datename(year,getdate()) --2022

	select datename(month,getdate()) --april

	select datename(week,getdate()) --16

	select datename(hour,getdate()) -- 14 hour

	select datename(day,getdate())  --11 day

	select datename(weekday,getdate())  --monday

2. Math function:-
  1.sqrt():-
   select sqrt(100) --10
   select sqrt(10.20) --3.193
   

 2.pi():-
  select pi() --3.145

  3.square
  select square(5) --25

  4.round:- it is use for rounding the value nearest
  select round(125.315,2) --125.320

  5.ceiling and floor:-
  ceiling:- it is use for finding next highest value ex:-
  select ceiling(45.56) --46
  
  6.floor:-  it is use for lowest next highest value ex:-
   select floor(45.56) --45

 3.string functions:-
 1.select char(65) as numbercodetocharecter --asci value

 2.select concat ('school','.com') --school.com

 3.select charindex('t','customer') --4 position

 4.select datalength('customer')  --8 length

 5.select left('sql tutorial',5) --sql t

 6.select ltrim('     sql tutorial')-- it remove space

 7.select replace('sql tutorial','t','m'); // it will replace t to m

 8.select reverse('sql tutorial') --it will reverse the character

 9.select upper('sql tutorial') --it will COnvert to upper case 

 10.select lower('SQL TUTORIAL') --it will COnvert to lower case 

