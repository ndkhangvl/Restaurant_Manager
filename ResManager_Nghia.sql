create database ResManager;



use ResManager;
drop table staff;
create table StaffPos(
	id_pos int primary key,
	posName varchar(50)
	);
	

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


select * from staff;
select * from StaffPos;
insert into StaffPos values(1,'Chef');
insert into StaffPos values(2,'Waiter');

insert into staff(staff_id,staffName,staffPhone,idPosition,staffState) values(1000,'Nguyen Duy Khang','0568812099',1,1)
insert into staff(staff_id,staffName,staffPhone,idPosition,staffState) values(1001,'Nguyen Van A','0568812088',2,1)

create table tables (
	table_id int identity(1,1) primary key,
	tableName varchar(15) not null,
	num_of_seat int not null,
	tableState int not null
);
insert into tables values('Table 1','3','1');
insert into tables values('Table 2','3','1');
select * from tables;


create table invoice(
	invoice_id bigint identity(1,1) primary key,
	table_id int FOREIGN KEY REFERENCES tables(table_id) not null,
	staff_id int FOREIGN KEY REFERENCES staff(staff_id) not null,
	invoiceDate datetime not null,
	invoiceDateUpt datetime not null,
	invoiceTotal bigint not null,
	invoiceState int not null,
);
insert into invoice values('1','1001','2023-03-19 14:30:00','2023-03-19 16:30:00','5000000','1')
insert into invoice values('2','1001','2023-03-19 15:30:00','2023-03-19 17:30:00','5000002','1')
select * from invoice;
drop table invoice;
SELECT * FROM invoice WHERE invoice_id = 1;
SELECT dn.dishName,id.Quantity FROM  dish_menu dn join invoice_detail id on dn.dish_id = id.dish_id  WHERE invoice_id = 1;

SELECT invoice.invoice_id, tableName, staffName, invoiceDate, invoiceDateUpt, invoiceTotal, invoiceState  from 
dish_menu INNER JOIN  invoice_detail on dish_menu.dish_id = invoice_detail.dish_id 
INNER JOIN  invoice on invoice.invoice_id=invoice_detail.invoice_id
INNER JOIN  staff on staff.staff_id=invoice.staff_id
INNER JOIN  tables on tables.table_id=invoice.table_id
WHERE invoice.invoice_id = 1;

create table dish_category(
	cate_id int identity(1,1) primary key,
	CateName varchar(50) not null
);
insert into dish_category values('Com');

select * from dish_category;

create table dish_menu(
	dish_id int primary key,
	dishName varchar(50) not null,
	cate_id int FOREIGN KEY REFERENCES dish_category(cate_id) not null,
	price int not null,
	unit varchar(15),
	dishState int not null
);
insert into dish_menu values ('001','Com ga chien nuoc mam','1','25000','dia','1');
insert into dish_menu values ('002','Com chien ca man','1','110000','phan','1');
select * from dish_menu;

create table invoice_detail(
	invoice_id bigint FOREIGN KEY REFERENCES invoice(invoice_id) not null,
	dish_id int FOREIGN KEY REFERENCES dish_menu(dish_id) not null,
	Quantity int not null
);
insert into invoice_detail values ('1','001','2');
insert into invoice_detail values ('2','001','1');

select * from invoice_detail;

drop table invoice_detail;


create table accounts(
	accID int identity(1,1) primary key,
	uname varchar(32) not null,
	passwd varchar(32) not null,
	acctype int not null,
);

insert into accounts(uname,passwd,acctype) values ('hnghia','hnghia',1);
insert into accounts(uname,passwd,acctype) values ('hnghia1','hnghia1',2);


select * from accounts;
