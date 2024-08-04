create database pharmacy

create table users(
id int identity(1,1)primary key,
userRole varchar(50)not null,
name varchar(250)not null,
dob varchar(250)not null,
mobile int not null,
email varchar(250)not null,
username varchar(250)unique not null,
pass varchar(250)not null
);
userRole,name,dob,mobile,email,username,pass
select * from users;
----------------------------
create table medicine(
id int identity(1,1)primary key,
mid varchar(250) not null,
mname varchar(250) not null,
mnumber varchar(250) not null,
mDate varchar(250) not null,
eDate varchar(250) not null,
quantity bigint not null,
perUnit bigint not null
);
drop table medicine;
truncate table medicine
mid,mname,mnumber,mDate,eDate,quantity,perUnit;
select * from medicine;
select cast( eDate as datetime) from medicine 
select * from medicine where eDate >= getdate();
select * from medicine where eDate <= getdate();



