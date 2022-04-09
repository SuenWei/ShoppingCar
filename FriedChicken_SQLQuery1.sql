use myDB;
go

select * from persons

--**品項表格**--
select * from FriedChicken
select top 50 * from  FriedChicken

--**新增產品表格**--
Create table FriedChicken
(ProductID int identity primary key, ProductName varchar(50), ProductPrice int, ProductPhoto varchar(50))

--新增產品品項--
insert into FriedChicken
values ('香香雞', 60,'1.香香雞.png'), ('魷魚腳', 60,'2.魷魚腳.png'), ('杏鮑菇', 50,'3.杏鮑菇.png'), ('香雞排', 80,'4.香雞排.png'), 
('脆皮薯條', 50,'5.脆皮薯條.png'), ('墨魚甜不辣', 40,'6.墨魚甜不辣.png'), ('雞皮仙貝', 50,'7.雞皮仙貝.png'), ('三節翅', 50,'8.三節翅.png'),
('花枝丸', 40,'9.花枝丸.png'), ('地瓜薯薯', 50,'10.地瓜薯薯.png'), ('百頁豆腐', 40,'11.百頁豆腐.png'), ('蘿蔔糕', 50,'12.蘿蔔糕.png'),('芝麻球', 50,'13.芝麻球.png')


-- 更新內容
update DrinkProduct
set ProductName='紅茶茶'
where ProductID=1

--刪除品項
delete from DrinkProduct
where  ProductID= 1

--刪除表格
drop table Customer
drop table Employee
drop table FriedChicken
drop table Orderr
drop table OrderDetails
drop table Spicy
drop table Topping

------------------------------
--**配料表格**--
select * from Topping;

--新增配料表格
Create table Topping
(ToppingID int identity primary key, ToppingName varchar(50))

--新增配料
insert into Topping
values ('不添加'), ('九層塔'), ('蒜頭'), ('洋蔥'), ('香菜')

------------------------------

--**新增辣度表格**--
CREATE TABLE Spicy
(SpicyID int identity primary key, SpicyDegree varchar(50))

--新增辣度--
insert into Spicy
values ('不辣'), ('微辣'), ('小辣'), ('中辣'), ('大辣')

---------------------------------

--**訂單表格**--
Create table　Orderr
(OrderID int identity primary key, CustID int, CustName varchar(100), CustPhone int, CustAdress varchar(100),
OrderDate smalldatetime, TotalPrice int, Delivery varchar(100))

--**訂單細節表格**--
Create table OrderDetails
(ID int identity primary key, OrderID int, Product varchar(100), Spicy varchar(100), Topping varchar(100),
Price int, Quantity int, Subtotal int)


---------------------
--**會員表格**--
Create table Customer
(CustID int identity (1001,1) primary key, CustName varchar(100), CustPhone varchar(100) , CustAdress varchar(100), CustBirth date, 
CustAccount varchar(100), CustPassword varchar(100), CustEmail varchar(100),CustPoint int)

insert into  Customer
values ('孫維政', '0912345678','台南市東區大學路1號','1990-01-01','qwe','qwe','qwe@qwe.mail',0),
 ('孫維政', '0912345678','台南市東區大學路1號','1990-01-01','qwe','qwe','qwe@qwe.mail',0),


-------------------------
--**員工表格**--
Create table Employee
(EmpID int identity (101,1) primary key, EmpName varchar(100), EmpPhone int, EmpAdress varchar(100), EmpBirth date, 
EmpAccount varchar(100), EmpPassword varchar(100), EmpEmail varchar(100), EmpPoint int)

-------------------------



--觸發器 trg_EncryptPwd
--sql觸發器，自動加密前臺傳入的密碼欄位
set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

Create TRIGGER Tri_CustPassword
ON  Customer
AFTER INSERT,UPDATE
AS 
BEGIN
    IF(UPDATE(CustPassword))
    BEGIN
        DECLARE @CustAccount varchar(100)
        DECLARE @CustPassword varchar(100)
        -- 獲取使用者ID和密碼
        SELECT @CustAccount=CustAccount, @CustPassword=CustPassword FROM inserted
        -- 更新密碼
        --UPDATE Customer SET CustPassword = dbo.MD5(@CustAccount,100) WHERE CustAccount= @CustAccount
    END
END
-- 註冊使用者時，自動將使用者密碼加密。













