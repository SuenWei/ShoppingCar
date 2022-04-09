--**�@��s�W�����**--
use myDB;
go

update Customer set CustName=555
where CustID=1001;
---------------------------------

--**�s�W���~���**--
Create table FriedChicken
(ProductID int identity primary key, ProductName varchar(50), ProductPrice int, ProductPhoto varchar(50))

--�s�W���~�~��--
insert into FriedChicken
values ('������', 60,'1.������.png'), ('�{���}', 60,'2.�{���}.png'), ('���jۣ', 50,'3.���jۣ.png'), ('������', 80,'4.������.png'), 
('�ܥ�����', 50,'5.�ܥ�����.png'), ('����������', 40,'6.����������.png'), ('���֥P��', 50,'7.���֥P��.png'), ('�T�`��', 50,'8.�T�`��.png'),
('��K�Y', 40,'9.��K�Y.png'), ('�a������', 50,'10.�a������.png'), ('�ʭ����G', 40,'11.�ʭ����G.png'), ('�ڽ��|', 50,'12.�ڽ��|.png'),('�۳²y', 50,'13.�۳²y.png')
---------------------------------

--**�s�W�t�ƪ��**--
Create table Topping
(ToppingID int identity primary key, ToppingName varchar(50))
--�s�W�t��--
insert into Topping
values ('���K�['), ('�E�h��'), ('�[�Y'), ('�v��'), ('����')

---------------------------------

--**�s�W���ת��**--
Create table Spicy
(SpicyID int identity primary key, SpicyDegree varchar(50))
--�s�W����--
insert into Spicy
values ('����'), ('�L��'), ('�p��'), ('����'), ('�j��')

---------------------------------

--**�s�W�|�����**--
Create table Customer
(CustID int identity (1001,1) primary key, CustName varchar(100), CustPhone int , CustAdress varchar(100), CustBirth date, 
CustAccount varchar(100), CustPassword varchar(100), CustEmail varchar(100),CustPoint int)

-------------------------
--**�s�W���u���**--
Create table Employee
(EmpID int identity (101,1) primary key, EmpName varchar(100), EmpPhone int, EmpAdress varchar(100), EmpBirth date, 
EmpAccount varchar(100), EmpPassword varchar(100), EmpEmail varchar(100), EmpPoint int)

-------------------------