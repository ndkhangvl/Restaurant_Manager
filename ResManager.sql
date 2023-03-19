create database ResManager;
use ResManager;
drop table staff;
create table staff (
	staff_id int primary key,
	staffName varchar(50) not null,
	DoB date,
	staffPhone varchar(10) not null,
	idPosition int FOREIGN KEY REFERENCES StaffPos(id_pos),
	staffState int not null,
	bonus int ,
	totalSal bigint 
);

create table StaffPos(
	id_pos int primary key,
	posName varchar(50)
	);
	
select * from staff;
insert into StaffPos values(1,'Chef');
insert into staff(staff_id,staffName,staffPhone,idPosition,staffState) values(1000,'Nguyen Duy Khang','0568812099',1,1)

create table tables (
	table_id int identity(1,1) primary key,
	tableName varchar(15) not null,
	num_of_seat int not null,
	tableState int not null
);

create table invoice(
	invoice_id bigint identity(1,1) primary key,
	table_id int FOREIGN KEY REFERENCES tables(table_id) not null,
	staff_id int FOREIGN KEY REFERENCES staff(staff_id) not null,
	invoiceDate datetime not null,
	invoiceDateUpt datetime not null,
	invoiceTotal bigint not null,
	invoiceState int not null,
	
);
create table invoice_detail(
	invoice_id bigint FOREIGN KEY REFERENCES invoice(invoice_id) not null,
	dish_id int FOREIGN KEY REFERENCES dish_menu(dish_id) not null,
	Quantity int not null
);
drop table invoice_detail;



create table dish_menu(
	dish_id int primary key,
	dishName varchar(50) not null,
	cate_id int FOREIGN KEY REFERENCES dish_category(cate_id) not null,
	price int not null,
	unit varchar(15),
	dishState int not null
);
create table dish_category(
	cate_id int identity(1,1) primary key,
	CateName varchar(50) not null
);


create table accounts(
	accID int identity(1,1) primary key,
	uname varchar(32) not null,
	passwd varchar(32) not null,
	acctype int not null,
);

insert into accounts(uname,passwd,acctype) values ('ndkhang','ndkhang',1);
select * from accounts;

