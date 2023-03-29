----Create Database----
create database ResManager;
use ResManager;

---------------------DROP_TABLE----------------------------
drop table invoice_detail;
drop table dish_menu;
drop table dish_category;
drop table invoice;
drop table tables;
drop table accounts;
drop table staff;
drop table StaffPos;

--------------STAFF_FORM----------------------------
create table StaffPos(
	id_pos int primary key,
	posName nvarchar(50),
	salary int
	);
	
create table accounts(
	accID int identity(10000,1) primary key,
	uname nvarchar(32) not null,
	passwd nvarchar(32) not null,
	acctype int not null,
);
drop table staff;
create table staff(
	staff_id int identity(1000,1) primary key,
	staffName nvarchar(50) not null,
	DoB date,
	staffPhone varchar(10) not null,
	idAccount int FOREIGN KEY REFERENCES accounts(accID),
	idPosition int FOREIGN KEY REFERENCES StaffPos(id_pos),
	staffState int not null,
	bonus int
);
insert into StaffPos values(1,'Head-Chef',15000000);
insert into StaffPos values(2,'Sous-Chef',12000000);
insert into StaffPos values(3,'Waitstaff',5000000);
insert into StaffPos values(4,'Bartender',6000000);
insert into StaffPos values(5,'Cashier',8000000);
insert into StaffPos values(6,'Prep-Cook',7000000);
insert into StaffPos values(7,'Dishwasher',5000000);


/* Thêm 1 tài khoản mới */
create procedure staff_new(@staffName varchar(50),@DoB date, @staffPhone varchar(10),@idPosition int,@staffState int,@uname varchar(32)
							,@passwd varchar(32),@acctype int)
as
begin
    if not exists(select uname from accounts where upper(accounts.uname)=upper(@uname))
    begin
		insert into accounts(uname,passwd,acctype) values(@uname,@passwd,@acctype);
		declare @accountID int;
		set @accountID = SCOPE_IDENTITY();
        insert into staff(staffName,DoB,staffPhone,idAccount,idPosition,staffState,bonus) values(@staffName,@DoB,@staffPhone,@accountID,@idPosition,@staffState, 0);
	end
end

drop procedure staff_new;
EXEC staff_new @staffName = 'Nguyen Duy Khang',@DoB = '1990-01-01',@staffPhone = '0568812099',@idPosition = 1,
    @staffState = 1,@uname = 'ndkhang',@passwd = 'ndkhang',@acctype = 1;

select * from accounts;
select * from staff;
/* Thêm bonus */
update staff set bonus=10 where staff_id = 1000;

/* Update thông tin Staff (Undone) */
CREATE PROCEDURE update_staff (@staff_id int,@staffName varchar(50),@DoB date, @staffPhone varchar(10),@idPosition int,@staffState int,@uname varchar(32)
							,@passwd varchar(32),@acctype int)
AS
BEGIN
    UPDATE staff st
    SET
        staffName = @staffName,
        DoB = @DoB,
        staffPhone = @staffPhone,
        staffState = @staffState,
        bonus = @bonus
    WHERE staff_id = @staff_id;
    UPDATE accounts acc
    SET
		uname = @uname,
		passwd = @passwd,
		acctype = @acctype
	WHERE st.idAccount = acc.accID;
END

/* Tính tổng lương của 1 nhân viên */ 
CREATE PROCEDURE sum_salary(@staff_id int)
AS
BEGIN
	DECLARE @sum bigint;
	SELECT @sum = ((sp.salary*st.bonus)/100) + sp.salary
	FROM staff st join StaffPos sp ON st.idPosition = sp.id_pos 
	WHERE st.staff_id= @staff_id
	SELECT @sum AS sum_salary;
END

select * from staffpos;
drop procedure sum_salary;
EXEC sum_salary @staff_id = 1000;

----------------------INVOICE----------------------------------------
create table tables(
	table_id int identity(1,1) primary key,
	tableName nvarchar(15) not null,
	num_of_seat int not null,
	tableState int not null
);
drop table tables;

-- --TABLES
/*
	Danh sách bàn
	tableState 1: đang có người ngồi, 0: đang trống
*/
insert into tables values(N'Mang về', 0, 0);
insert into tables values(N'Bàn 01', 4, 0);
insert into tables values(N'Bàn 02', 4, 0);
insert into tables values(N'Bàn 03', 4, 0);
insert into tables values(N'Bàn 04', 4, 0);
insert into tables values(N'Bàn 05', 10, 0);
insert into tables values(N'Bàn 06', 10, 0);
insert into tables values(N'Bàn 07', 10, 0);
insert into tables values(N'Bàn 08', 10, 0);
insert into tables values(N'Bàn 09', 10, 0);
insert into tables values(N'Bàn 10', 4, 0);
insert into tables values(N'Bàn 11', 4, 0);
insert into tables values(N'Bàn 12', 4, 0);
insert into tables values(N'Bàn 13', 4, 0);
insert into tables values(N'Bàn 14', 4, 0);
insert into tables values(N'Bàn 15', 10, 0);
insert into tables values(N'Bàn 16', 10, 0);
insert into tables values(N'Bàn 17', 10, 0);
insert into tables values(N'Bàn 18', 10, 0);
insert into tables values(N'Bàn 19', 10, 0);
insert into tables values(N'Bàn 20', 10, 0);

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

insert into invoice values('1','1000','2023-03-19 14:30:00','2023-03-19 16:30:00','5000000','1')
insert into invoice values('2','1000','2023-03-19 15:30:00','2023-03-19 17:30:00','5000002','1')


drop table invoice_detail;
create table invoice_detail(
	invoice_id bigint FOREIGN KEY REFERENCES invoice(invoice_id) not null,
	dish_id int FOREIGN KEY REFERENCES dish_menu(dish_id) not null,
	Quantity int not null
);
insert into invoice_detail values ('5','001','2');
insert into invoice_detail values ('6','001','1');


create table dish_category(
	cate_id int identity(1,1) primary key,
	CateName nvarchar(50) not null
);
insert into dish_category values(N'Cơm');
insert into dish_category values(N'Gà/Vịt');
insert into dish_category values(N'Bò/Heo');
insert into dish_category values(N'Thủy/Hải sản');
insert into dish_category values(N'Lẩu');
insert into dish_category values(N'Cơm/Mì');
insert into dish_category values(N'Soup');
insert into dish_category values(N'Tráng miệng/Nước');
insert into dish_category values(N'Khác');


create table dish_menu(
	dish_id int primary key,
	dishName nvarchar(50) not null,
	cate_id int FOREIGN KEY REFERENCES dish_category(cate_id) not null,
	price int not null,
	unit nvarchar(15),
	dishState int not null
);
insert into dish_menu values ('1',N'Cánh gà chiên nước mắm','2','25000',N'dĩa','1');
insert into dish_menu values ('2',N'Cơm chiên cá mặn','1','110000',N'phần','1');
insert into dish_menu values ('3',N'Cơm cá chẽm hấp','1','150000',N'phần','1');
insert into dish_menu values ('4',N'Cơm chiên hến','1','100000',N'phần','1');
insert into dish_menu values('5','Cá Chẽm Chiên Giòn', 4, 260000, N'con',1);
insert into dish_menu values('6',N'Cá Chẽm Hấp',4, 260000, N'con',1);
insert into dish_menu values('7',N'Cá Dứa Chiên', 4, 100000, N'con',1);
insert into dish_menu values('8',N'Cá Bớp Chiên', 4, 100000, N'con',1);
insert into dish_menu values('10',N'Cá Đuối Hấp', 4, 200000, N'con',1);
insert into dish_menu values('9',N'Lẩu Cá Chẽm', 5, 260000, N'phần',1);
insert into dish_menu values(11,N'Lẩu Thái Hải Sản', 5, 150000, N'phần',1);
insert into dish_menu values(12,N'Lẩu Nấm', 5, 100000, N'phần',1);
insert into dish_menu values(13,N'Gà Luộc', 1, 160000, N'con',0);
insert into dish_menu values(14,N'Gà Quay', 1, 160000, N'con',1);
insert into dish_menu values(15,N'Gà Nướng Muối Ớt', 1, 170000, N'con',1);
insert into dish_menu values(16,N'Bò Quanh Lửa Hồng', 2, 120000, N'phần',0);
insert into dish_menu values(17,N'Bò Tái Chanh', 2, 100000, N'phần',1);
insert into dish_menu values(18,N'Soup Thập Cẩm', 6, 50000, N'phần',1);
insert into dish_menu values(19,N'Soup Cua', 6, 70000, N'phần',0);
insert into dish_menu values(20,N'Nước Ngọt Các Loại', 7, 15000, N'chai/lon',1);
insert into dish_menu values(21,N'Trái Cây Dĩa', 7, 40000, N'dĩa',1);


/*thêm 1 danh mục món ăn*/
create procedure dish_cate_new(@CateName nvarchar(50))
as
begin
    if not exists(select CateName from dish_category where upper(dish_category.CateName)=upper(@CateName))
    begin
        insert into dish_category(CateName) values(@CateName);
	end
end
--execute dish_cate_new 'Bánh ngọt';

/*Danh sách danh mục thức ăn*/
create function list_category()
returns @temptable table (
	cate_id int,
	CateName nvarchar(50)
)
as
begin
	insert into @temptable
	select * from dish_category order by cate_id;
	return;
end
/*trả về danh sách món ăn theo danh mục*/
create function dish_list_by_cate(@cateid int)
	returns @temptable table (
		dish_id int,
		dishName nvarchar(50),
		price int,
		unit nvarchar(50),
		state nvarchar(50),
		cateid int
	)
as
begin
	if exists (select dish_id from dish_menu where dishState=1)
	begin
		insert into @temptable
		select dish_id, dishName, price, unit,
        case when dm.dishState=1
			then'Available'
		else 'Deleted' end as state, @cateid
        from dish_menu dm join dish_category dc on dm.cate_id=dc.cate_id where dm.cate_id=@cateid
        and dm.dishState=1
		order by dish_id asc;
    end
    return
end
--select * from dish_list_by_cate(3);

/*trả về danh sách các món không còn bán nữa*/
create function dish_list_deleted()
	returns @temptable table (
		dish_id int,
		dishName nvarchar(50),
		cateName nvarchar(50),
		price int,
		unit nvarchar(50),
		state nvarchar(10)
	)
as
begin
	if exists (select dish_id from dish_menu where dishState=0)
	begin
		insert into @temptable
		select dish_id, dishName, cateName, price, unit, 'Deleted' as state
        from dish_menu dm join dish_category dc on dm.cate_id=dc.cate_id
        where dishState=0
		order by dish_id asc;
    end
    return
end

--select * from dish_list_deleted();

/*xóa 1 món ăn (thực chất là set state thành 0)*/
create procedure dish_delete(@dish_id int)
as
begin
	if exists (select dish_id from dish_menu where dish_menu.dish_id=@dish_id and dish_menu.dishState=1)
	begin
		update dish_menu set dishState=0 where dish_menu.dish_id=@dish_id;
	end
end

/*Thêm 1 bàn mới*/
create procedure table_new(@tableName nvarchar(15), @num_of_seat int)
as
begin
    if not exists (select table_id from tables where tables.tableName=@tableName)
	begin
		insert into tables(tableName, num_of_seat) values(@tableName,@num_of_seat);
    end;
end
--execute table_new N'Bàn 22', 4;

/*Danh sách tất cả các bàn*/
create function table_list()
returns table
as
	return
	select table_id, tableName, num_of_seat as seats, case when tableState=0
		then 'Available' else 'Not Available' end as state
	from tables;
--select * from table_list();

/*Thêm 1 món ăn*/
create procedure dish_new(@dishName nvarchar(50), @cateid int,
							@price int, @unit nvarchar(15))
as
begin
	insert into dish_menu(dishName, cate_id, price, unit) values(@dishName,@cateid,@price,@unit);
end

select * from dish_menu;

/*Cập nhật thông tin món ăn*/
create procedure dish_update(@dish_id int, @dishName nvarchar(50), @vcate_id int,
									@price int, @unit nvarchar(15))
as
begin
	if exists (select dish_id from dish_menu dm where dm.dish_id=@dish_id and dm.dishState=1)
	begin
		update dish_menu set dishName=@dishName, cate_id=@vcate_id, price=@price, unit=@unit
        where dish_id=@dish_id;
	end
end

/*Đem món ăn từ danh sách xóa trở về*/
create procedure dish_restore(@dishid int)
as
begin
	if exists (select dish_id from dish_menu where dish_menu.dish_id=@dishid and dish_menu.dishState=0)
	begin
		update dish_menu set dishState=1 where dish_menu.dish_id=@dishid;
	end
end

-----------------------procedure đổi bàn---------------------------
create procedure changeTables (@invoiceid int, @NewTableID int)
as
begin
	declare @oldtabe int;
	select @oldtabe=table_id from invoice where invoice_id=@invoiceid;
	update invoice set table_id=@NewTableID where invoice_id=@invoiceid;
	
	update tables set tableState=0 where table_id=@oldtabe;
	update tables set tableState=1 where table_id=@NewTableID;
	
end

-------------------------procedure paid----------------------------
create procedure btnPaid (@invoiceid int)
as
begin
	update invoice set invoiceState=1 where invoice_id = @invoiceid;
	declare @tableid int 
	select @tableid = table_id from invoice where invoice_id = @invoiceid;
	update tables set tableState=0 where table_id = @tableid;
end

execute btnPaid 10;


-----------------------proceduce Update Món Ăn---------------------------

create procedure btnUpt_invoiceDetail (@invoiceid int, @dishid int, @quant int)
as
begin
	if (@quant = 0)
	begin
		delete from invoice_detail where invoice_id=@invoiceid and dish_id=@dishid;
	end
	else if exists (select * from invoice_detail where invoice_id=@invoiceid and dish_id=@dishid)
	begin
		update invoice_detail set Quantity=@quant where invoice_id=@invoiceid and dish_id=@dishid;
	end
	else
	begin
		insert invoice_detail values (@invoiceid, @dishid, @quant);
	end
	
	declare @temptotal bigint = 0;
	if (@quant != 0)
	begin
		select @temptotal= sum(Quantity * price)
		from invoice join invoice_detail on invoice.invoice_id=invoice_detail.invoice_id 
		join dish_menu on invoice_detail.dish_id = dish_menu.dish_id 
		where invoice.invoice_id=@invoiceid;
	end
	update invoice set invoiceTotal=@temptotal, invoiceDateUpt=GETDATE() where invoice_id=@invoiceid;
	
end

execute btnUpt_invoiceDetail();








