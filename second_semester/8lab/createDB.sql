use master
create database _8lab
go
use _8lab
create table _STUDENT
(
	ID       int primary key,
	AGE      int,
	PHOTO    image,
	F_NAME   nvarchar(20)
)

create table _ADRESS
(
	ID int  foreign key references _STUDENT(ID),
	STREET  nvarchar(20),
	CITY	nvarchar(20),
	COUNTRY nvarchar(20)
)

insert into _STUDENT(ID, AGE, F_NAME)	values 

(5, 18, 'Daria');

insert into _ADRESS (ID, STREET, CITY, COUNTRY) values 
(1, 'Kolasa', 'Novopolotsk', 'Belarus'), 
(2, 'Logoiskiy', 'Minsk', 'Belarus'),
(3, 'Belarusskaya', 'Minsk', 'Belarus');

use _8lab
select top 1 PHOTO from _STUDENT  

select * from (_STUDENT join _ADRESS on _STUDENT.ID=_ADRESS.ID);

select * from (_STUDENT join _ADRESS on _STUDENT.ID=_ADRESS.ID) order by AGE desc;

select top 1 ID from _STUDENT order by ID desc

use _8lab
delete from _ADRESS where ID >3
delete from _STUDENT where ID >3

update _STUDENT
set AGE = 19 where F_NAME = 'Daria'