1.Triggers
2.Transaction
3.Temporary Tables

1.Triggers:- a trigger is a special type of stored procedure that automatically runs 
--when an event occur in the database server dml triggers run when a user to modify data through 
--a data manupulation language(dml) dml are insert,update,delete on a table or view
--CREATE DATABASE NEWDB

CREATE TRIGGER TG_STRICT
ON DATABASE
FOR CREATE_TABLE
AS
BEGIN
PRINT'YOU CANT CREATE'
ROLLBACK TRANSACTION 
END
USE NEWDB
CREATE TABLE DEMO1(ID INT)


-- CREATING ON NEW TABLE FOR DML OPERATION
create table developer
(
d_id int primary key,
d_name varchar(25),
salary money,
address varchar(30))

insert into developer values(100,'roja',23000,'mandya')
insert into developer values(101,'nischita',25000,'banglore')
insert into developer values(102,'deepak',28000,'banglore')
select * from developer

1. insert trigger
-- creating an insert trigger on developer table
CREATE TRIGGER INSER_TRI
ON DEVELOPER
FOR INSERT 
AS
BEGIN
PRINT'CANNOT INSERT IN THE TABLE'
ROLLBACK TRANSACTION
END

INSERT INTO DEVELOPER VALUES(104,'ROHAN',29000,'HUBBALLI')
-- WE GOT THE ERROR CANNOT INSERT IN THE TABLE

CREATE TRIGGER UPDATE_TRI
ON DEVELOPER
FOR UPDATE 
AS
BEGIN
PRINT'CANNOT UPDATE IN THE TABLE'
ROLLBACK TRANSACTION
END

UPDATE DEVELOPER SET d_name='SHRIDHAR' WHERE d_id=102
-- CANNOT UPDATE IN THE TABLE

CREATE TRIGGER DELETE_TRI
ON DEVELOPER
FOR DELETE 
AS
BEGIN
PRINT'CANNOT DELETE IN THE TABLE'
ROLLBACK TRANSACTION
END

DROP TRIGGER DELETE_TRI
DELETE FROM DEVELOPER WHERE D_ID=102 
-- CANNOT DELETE IN THE TABLE

WE CAN ACHIEVE IN ONE TABLE ALSO INSTED OF WRITING 3 TRIGGERS

CREATE TRIGGER ALLOPERATION
ON DEVELOPER
FOR DELETE,INSERT,UPDATE
AS
BEGIN
PRINT'CANNOT DELETE UPDATE AND INSERT IN THE TABLE'
ROLLBACK TRANSACTION
END
DELETE FROM DEVELOPER WHERE D_ID=101 
-- CANNOT DELETE UPDATE AND INSERT IN THE TABLE


--------------------
Transaction:- is a unit of work that is performed against a database  
 properties of transactions are:- acid
 atomicity
 consistency
 isolation
 durability
------------
1.commit:- used to save changes
--------------
select * from students
delete from students where id=5
begin transaction 
insert into students values(5,'titan','dev',50000)
update students set name='mike' where id=4;
commit transaction

2.rollback:-the rollback it is use for undo any transaction 

begin transaction 
insert into students values(6,'kgf2','actor',40000)
update students set name='maks' where id=5;
rollback transaction

3.-- savepoint:---the savepoint allows us to rollback allthe points

begin transaction
insert into students values(7,'rrr','actor',50000)
save transaction insertstatement
delete from students where id=7

rollback transaction insertstatement
commit

select * from students


 -- temporary tables--
 -- temporary table help us to store and process intermediate results

 create table #empdetails(id int,name varchar(25))
 insert into #empdetails values(1,'yash')
 select * from #empdetails

 create procedure proctemp
 as
 begin
 insert into #empdetails values(1,'yash'),(2,'aish')
 select * from #empdetails 
 end
 execute proctemp
 drop proctemp


