drop database ResManager;
----Create Database----
create database ResManager;
use ResManager;

---------------------DROP_TABLE----------------------------
/*
drop table invoice_detail;
drop table dish_menu;
drop table dish_category;
drop table invoice;
drop table tables;
drop table staff;
drop table accounts;
drop table StaffPos;
*/
--------------STAFF_FORM----------------------------
------TABLE STAFFPOS-------------
create table StaffPos(
	id_pos int identity primary key,
	posName nvarchar(50),
	salary int
);

------TABLE ACCOUNTS-------------
create table accounts(
	accID int identity(1000,1) primary key,
	uname nvarchar(32) not null unique,
	passwd nvarchar(32) not null,
	acctype int not null,
);
ALTER TABLE invoice ADD CONSTRAINT id_fk_Staff FOREIGN KEY (staff_id) REFERENCES staff (staff_id)
ON DELETE SET DEFAULT;

------TABLE STAFF---------------
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


insert into StaffPos values('Head-Chef',15000000);
insert into StaffPos values('Sous-Chef',12000000);
insert into StaffPos values('Waitstaff',5000000);
insert into StaffPos values('Bartender',6000000);
insert into StaffPos values('Cashier',8000000);
insert into StaffPos values('Prep-Cook',7000000);
insert into StaffPos values('Dishwasher',5000000);

---------------------------------------------------PROCEDURE STAFF-------------------------------------------------------------------
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

/*
if not exists(select uname from accounts where upper(accounts.uname)=upper('ndkhanvg'))
    begin
		select 1;
	end
else select 2;

drop procedure staff_new;
*/
EXEC staff_new @staffName = 'Admin',@DoB = '1990-01-01',@staffPhone = '0111111111',@idPosition = 5,
    @staffState = 1,@uname = 'admin',@passwd = 'admin',@acctype = 1;

EXEC staff_new @staffName = 'Ho Xuan Phuong Dong',@DoB = '2001-10-20',@staffPhone = '0774839113',@idPosition = 5,
    @staffState = 1,@uname = 'hxpdong',@passwd = 'hxpdong',@acctype = 2;
    
EXEC staff_new @staffName = 'Nguyen Duy Khang',@DoB = '2001-10-04',@staffPhone = '0568812099',@idPosition = 5,
    @staffState = 1,@uname = 'ndkhang',@passwd = 'ndkhang',@acctype = 2;

EXEC staff_new @staffName = 'Nguyen Thi My Khanh',@DoB = '2001-05-04',@staffPhone = '0976038762',@idPosition = 5,
    @staffState = 1,@uname = 'ntmkhanh',@passwd = 'ntmkhanh',@acctype = 2;
    
EXEC staff_new @staffName = 'Dang Quoc Cuong',@DoB = '2001-09-29',@staffPhone = '0819942106',@idPosition = 1,
    @staffState = 1,@uname = 'dqcuong',@passwd = 'dqcuong',@acctype = 2;
   
EXEC staff_new @staffName = 'Danh Be Hai',@DoB = '2001-11-20',@staffPhone = '0977511560',@idPosition = 3,
    @staffState = 1,@uname = 'dbhai',@passwd = 'dbhai',@acctype = 2;

EXEC staff_new @staffName = 'Nguyen Hieu Nghia',@DoB = '2001-01-08',@staffPhone = '0773856988',@idPosition = 5,
    @staffState = 1,@uname = 'hnghia',@passwd = 'hnghia',@acctype = 1;
/*
select * from accounts;
select * from staff;

update accounts set acctype =1 where accID=1001;
*/
--select * from staff join StaffPos on staff.idPosition = StaffPos.id_pos join accounts on accounts.accID = staff.idAccount where staff.staff_id = 1001;

/* Thêm bonus */
--SELECT COUNT(*) FROM accounts WHERE uname = 'ndkhanvg';

/* Update thông tin Staff */
CREATE PROCEDURE update_staff (@staff_id int,@staffName varchar(50),@DoB date, @staffPhone varchar(10),@idPosition int,@staffState int
							,@acctype int, @bonus int)
AS
BEGIN
	DECLARE @num_staff int
	SET @num_staff = @staff_id
    
    UPDATE staff 
    SET
        staffName =@staffName,
        DoB = @DoB,
        staffPhone = @staffPhone,
        idPosition = @idPosition,
        staffState = @staffState,
        bonus = @bonus
    WHERE staff_id = @num_staff;
    
    UPDATE accounts 
    SET
		acctype = @acctype
	WHERE accID = @num_staff;
END

exec update_staff @staff_id = 1002,@staffName = 'Nguyen Duy Khang', @DoB = '1990-01-01', @staffPhone = '0568812098',@idPosition = 1,@staffState = 1, @acctype = 1, @bonus = 10;

/* Thay đổi mật khẩu cho Staff */
CREATE PROCEDURE change_passwd_staff(@uname nvarchar(32),@oldpasswd nvarchar(32),@newpasswd nvarchar(32))
AS
BEGIN
	IF EXISTS(SELECT * FROM Accounts WHERE uname = @uname AND passwd = @oldpasswd)
	BEGIN
		UPDATE accounts 
		SET
			passwd = @newpasswd
		WHERE accounts.uname = @uname;
	END
	ELSE 
		SELECT 'Account name is incorrect' AS Result
END

--select COUNT(*) from accounts where uname ='ndkhang' AND passwd = 'ndkhang';
--drop procedure change_passwd_staff;
--exec change_passwd_staff 'ndkhang','ndkhangvl','12345';
--select * from accounts;

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

--select * from staffpos;
--drop procedure sum_salary;
--EXEC sum_salary 1000;

/*
select staff.staff_id,staff.staffName,staff.DoB,staff.staffPhone,staff.staffState,StaffPos.posName from staff
                                        join StaffPos on staff.idPosition = StaffPos.id_pos;
*/

/* Delete staff by ID */
CREATE PROCEDURE del_staff(@staff_id int)
AS
BEGIN
	UPDATE staff set staffState = 0 where staff_id=@staff_id
END

/*
exec del_staff @staff_id = 1005;
select * from accounts;
select * from staff;
*/
----------------------INVOICE----------------------------------------
----------TABLE TABLE------------------ 
create table tables(
	table_id int identity(1,1) primary key,
	tableName nvarchar(15) not null,
	num_of_seat int not null,
	tableState int not null
);
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

----------TABLE INVOICE-----------------------
create table invoice(
	invoice_id bigint identity(1,1) primary key,
	table_id int FOREIGN KEY REFERENCES tables(table_id) not null,
	staff_id int FOREIGN KEY REFERENCES staff(staff_id) not null,
	invoiceDate datetime not null,
	invoiceDateUpt datetime not null,
	invoiceTotal bigint not null,
	invoiceState int not null,
);
ALTER TABLE invoice ADD CONSTRAINT df_invoicedate DEFAULT GETDATE() for invoiceDate;
ALTER TABLE invoice ADD CONSTRAINT df_invoicedateUpt DEFAULT GETDATE() for invoiceDateUpt;

insert into invoice values('1','1001','2023-04-13 14:30:00','2023-04-13 16:30:00','220000','1');
insert into invoice values('2','1001','2023-04-13 15:30:00','2023-04-13 17:30:00','250000','1');
insert into invoice values('3','1001','2023-04-14 12:30:00','2023-04-14 16:30:00','2533500','1');
insert into invoice values('4','1001','2023-04-14 13:30:00','2023-04-14 17:30:00','1080000','1');
insert into invoice values('5','1001','2023-04-14 14:30:00','2023-04-14 16:30:00','375000','1');
insert into invoice values('6','1001','2023-04-14 15:30:00','2023-04-14 17:30:00','270000','1');
insert into invoice values('7','1001','2023-04-14 15:30:00','2023-04-14 16:30:00','750000','1');
insert into invoice values('8','1006','2023-04-14 16:30:00','2023-04-14 17:30:00','399000','1');

----------TABLE CATEROGY----------------
create table dish_category(
	cate_id int identity(1,1) primary key,
	CateName nvarchar(50) not null
);

insert into dish_category values(N'Cơm');					--1
insert into dish_category values(N'Gà/Vịt');				--2
insert into dish_category values(N'Bò/Heo');				--3
insert into dish_category values(N'Thủy/Hải sản');			--4	
insert into dish_category values(N'Lẩu');					--5
insert into dish_category values(N'Cơm/Mì');				--6
insert into dish_category values(N'Soup');					--7
insert into dish_category values(N'Tráng miệng/Nước');		--8
insert into dish_category values(N'Khác');					--9

--------------TABLE MENU-----------------
create table dish_menu(
	dish_id int identity(1,1) primary key,
	dishName nvarchar(50) not null,
	cate_id int FOREIGN KEY REFERENCES dish_category(cate_id) not null,
	price int not null,
	unit nvarchar(15),
	dishState int not null									--1 là còn bán, 0 là hết bán
);
insert into dish_menu values (N'Cánh gà chiên nước mắm','2','25000',N'dĩa',1);
insert into dish_menu values (N'Cơm chiên cá mặn','1','110000',N'phần',1);
insert into dish_menu values (N'Cơm cá chẽm hấp','1','150000',N'phần',1);
insert into dish_menu values (N'Cơm chiên hến','1','100000',N'phần',1);
insert into dish_menu values(N'Cá Chẽm Chiên Giòn', '4', '260000', N'con',1);
insert into dish_menu values(N'Cá Chẽm Hấp','4', '260000', N'con',1);
insert into dish_menu values(N'Cá Dứa Chiên', '4', '100000', N'con',1);
insert into dish_menu values(N'Cá Bớp Chiên', '4', '100000', N'con',1);
insert into dish_menu values(N'Cá Đuối Hấp', '4', '200000', N'con',1);
insert into dish_menu values(N'Lẩu Cá Chẽm', '5', '260000', N'phần',1);
insert into dish_menu values(N'Lẩu Thái Hải Sản', '5', '150000', N'phần',1);
insert into dish_menu values(N'Lẩu Nấm', '5', '100000', N'phần',1);
insert into dish_menu values(N'Gà Luộc', '2', '160000', N'con',0);
insert into dish_menu values(N'Gà Quay', '2', '160000', N'con',1);
insert into dish_menu values(N'Gà Nướng Muối Ớt', '2', '170000', N'con',1);
insert into dish_menu values(N'Bò Quanh Lửa Hồng', '3', '120000', N'phần',0);
insert into dish_menu values(N'Bò Tái Chanh', '3', '100000', N'phần',1);
insert into dish_menu values(N'Soup Thập Cẩm', '7', '50000', N'phần',1);
insert into dish_menu values(N'Soup Cua', '7', '70000', N'phần',0);
insert into dish_menu values(N'Nước Ngọt Các Loại', '8', '15000', N'chai/lon',1);
insert into dish_menu values(N'Trái Cây Dĩa', '8', '40000', N'dĩa',1);

-----------TABLE INVOICE_DETAIL-----------------
create table invoice_detail(
	invoice_id bigint FOREIGN KEY REFERENCES invoice(invoice_id) not null,
	dish_id int FOREIGN KEY REFERENCES dish_menu(dish_id) not null,
	Quantity int not null
);
insert into invoice_detail values ('1','2','2');
insert into invoice_detail values ('2','3','1');
insert into invoice_detail values ('2','4','1');
insert into invoice_detail values ('3','6','9');
insert into invoice_detail values ('3','1','5');
insert into invoice_detail values ('3','18','7');
insert into invoice_detail values ('4','2','8');
insert into invoice_detail values ('4','17','2');
insert into invoice_detail values ('5','20','5');
insert into invoice_detail values ('5','3','2');
insert into invoice_detail values ('7','4','5');
insert into invoice_detail values ('7','18','5');
insert into invoice_detail values ('6','11','2');
insert into invoice_detail values ('8','14','2');
insert into invoice_detail values ('8','17','1');


---------------------------------------PROCEDURE MENU/TABLE------------------------------------------------------------
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


--select * from table_list();


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


------------------------------------PROCEDURE OTHER-------------------------------------------------------------
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
	
	select @temptotal= sum(Quantity * price)
	from invoice join invoice_detail on invoice.invoice_id=invoice_detail.invoice_id 
	join dish_menu on invoice_detail.dish_id = dish_menu.dish_id 
	where invoice.invoice_id=@invoiceid;

	update invoice set invoiceTotal=@temptotal, invoiceDateUpt=GETDATE() where invoice_id=@invoiceid;
	
end

--execute btnUpt_invoiceDetail();
--------------Procedure btn Paid---------------
create procedure btnPaid (@invoiceid int, @invTotal int)
as
begin
	update invoice set invoiceState=1, invoiceTotal=invoiceTotal - invoiceTotal*@invTotal/100 where invoice_id = @invoiceid;
	declare @tableid int 
	select @tableid = table_id from invoice where invoice_id = @invoiceid;
	update tables set tableState=0 where table_id = @tableid;
end

------------Add Table-----------------
/*Thêm 1 bàn mới*/
create procedure table_new(@tableName nvarchar(15), @num_of_seat int)
as
begin
    if not exists (select table_id from tables where tables.tableName=@tableName)
	begin
		insert into tables(tableName, num_of_seat, tableState) values(@tableName,@num_of_seat, 0);
    end;
end


---------------------
/*Thêm 1 món ăn*/
create procedure dish_new(@dishName nvarchar(50), @cateid int,
							@price int, @unit nvarchar(15))
as
begin
	insert into dish_menu(dishName, cate_id, price, unit, dishState) values(@dishName,@cateid,@price,@unit, 1);
end

/*Danh sách tất cả các bàn*/
create function table_list()
returns table
as
	return
	select table_id, tableName, num_of_seat as seats, case when tableState=0
		then 'Available' else 'Not Available' end as state
	from tables;
	
