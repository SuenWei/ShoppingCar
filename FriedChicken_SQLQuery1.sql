use myDB;
go

select * from persons

--**�~�����**--
select * from FriedChicken
select top 50 * from  FriedChicken

--**�s�W���~���**--
Create table FriedChicken
(ProductID int identity primary key, ProductName varchar(50), ProductPrice int, ProductPhoto varchar(50))

--�s�W���~�~��--
insert into FriedChicken
values ('������', 60,'1.������.png'), ('�{���}', 60,'2.�{���}.png'), ('���jۣ', 50,'3.���jۣ.png'), ('������', 80,'4.������.png'), 
('�ܥ�����', 50,'5.�ܥ�����.png'), ('����������', 40,'6.����������.png'), ('���֥P��', 50,'7.���֥P��.png'), ('�T�`��', 50,'8.�T�`��.png'),
('��K�Y', 40,'9.��K�Y.png'), ('�a������', 50,'10.�a������.png'), ('�ʭ����G', 40,'11.�ʭ����G.png'), ('�ڽ��|', 50,'12.�ڽ��|.png'),('�۳²y', 50,'13.�۳²y.png')


-- ��s���e
update DrinkProduct
set ProductName='������'
where ProductID=1

--�R���~��
delete from DrinkProduct
where  ProductID= 1

--�R�����
drop table Customer
drop table Employee
drop table FriedChicken
drop table Orderr
drop table OrderDetails
drop table Spicy
drop table Topping

------------------------------
--**�t�ƪ��**--
select * from Topping;

--�s�W�t�ƪ��
Create table Topping
(ToppingID int identity primary key, ToppingName varchar(50))

--�s�W�t��
insert into Topping
values ('���K�['), ('�E�h��'), ('�[�Y'), ('�v��'), ('����')

------------------------------

--**�s�W���ת��**--
CREATE TABLE Spicy
(SpicyID int identity primary key, SpicyDegree varchar(50))

--�s�W����--
insert into Spicy
values ('����'), ('�L��'), ('�p��'), ('����'), ('�j��')

---------------------------------

--**�q����**--
Create table�@Orderr
(OrderID int identity primary key, CustID int, CustName varchar(100), CustPhone int, CustAdress varchar(100),
OrderDate smalldatetime, TotalPrice int, Delivery varchar(100))

--**�q��Ӹ`���**--
Create table OrderDetails
(ID int identity primary key, OrderID int, Product varchar(100), Spicy varchar(100), Topping varchar(100),
Price int, Quantity int, Subtotal int)


---------------------
--**�|�����**--
Create table Customer
(CustID int identity (1001,1) primary key, CustName varchar(100), CustPhone varchar(100) , CustAdress varchar(100), CustBirth date, 
CustAccount varchar(100), CustPassword varchar(100), CustEmail varchar(100),CustPoint int)

insert into  Customer
values ('�]���F', '0912345678','�x�n���F�Ϥj�Ǹ�1��','1990-01-01','qwe','qwe','qwe@qwe.mail',0),
 ('�]���F', '0912345678','�x�n���F�Ϥj�Ǹ�1��','1990-01-01','qwe','qwe','qwe@qwe.mail',0),


-------------------------
--**���u���**--
Create table Employee
(EmpID int identity (101,1) primary key, EmpName varchar(100), EmpPhone int, EmpAdress varchar(100), EmpBirth date, 
EmpAccount varchar(100), EmpPassword varchar(100), EmpEmail varchar(100), EmpPoint int)

-------------------------



--Ĳ�o�� trg_EncryptPwd
--sqlĲ�o���A�۰ʥ[�K�e�O�ǤJ���K�X���
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
        -- ����ϥΪ�ID�M�K�X
        SELECT @CustAccount=CustAccount, @CustPassword=CustPassword FROM inserted
        -- ��s�K�X
        --UPDATE Customer SET CustPassword = dbo.MD5(@CustAccount,100) WHERE CustAccount= @CustAccount
    END
END
-- ���U�ϥΪ̮ɡA�۰ʱN�ϥΪ̱K�X�[�K�C













