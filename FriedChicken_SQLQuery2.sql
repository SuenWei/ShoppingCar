--**一鍵新增全表格**--
use myDB;
go

update Customer set CustName=555
where CustID=1001;
---------------------------------

--**新增產品表格**--
Create table FriedChicken
(ProductID int identity primary key, ProductName varchar(50), ProductPrice int, ProductPhoto varchar(50))

--新增產品品項--
insert into FriedChicken
values ('香香雞', 60,'1.香香雞.png'), ('魷魚腳', 60,'2.魷魚腳.png'), ('杏鮑菇', 50,'3.杏鮑菇.png'), ('香雞排', 80,'4.香雞排.png'), 
('脆皮薯條', 50,'5.脆皮薯條.png'), ('墨魚甜不辣', 40,'6.墨魚甜不辣.png'), ('雞皮仙貝', 50,'7.雞皮仙貝.png'), ('三節翅', 50,'8.三節翅.png'),
('花枝丸', 40,'9.花枝丸.png'), ('地瓜薯薯', 50,'10.地瓜薯薯.png'), ('百頁豆腐', 40,'11.百頁豆腐.png'), ('蘿蔔糕', 50,'12.蘿蔔糕.png'),('芝麻球', 50,'13.芝麻球.png')
---------------------------------

--**新增配料表格**--
Create table Topping
(ToppingID int identity primary key, ToppingName varchar(50))
--新增配料--
insert into Topping
values ('不添加'), ('九層塔'), ('蒜頭'), ('洋蔥'), ('香菜')

---------------------------------

--**新增辣度表格**--
Create table Spicy
(SpicyID int identity primary key, SpicyDegree varchar(50))
--新增辣度--
insert into Spicy
values ('不辣'), ('微辣'), ('小辣'), ('中辣'), ('大辣')

---------------------------------

--**新增會員表格**--
Create table Customer
(CustID int identity (1001,1) primary key, CustName varchar(100), CustPhone int , CustAdress varchar(100), CustBirth date, 
CustAccount varchar(100), CustPassword varchar(100), CustEmail varchar(100),CustPoint int)

-------------------------
--**新增員工表格**--
Create table Employee
(EmpID int identity (101,1) primary key, EmpName varchar(100), EmpPhone int, EmpAdress varchar(100), EmpBirth date, 
EmpAccount varchar(100), EmpPassword varchar(100), EmpEmail varchar(100), EmpPoint int)

-------------------------