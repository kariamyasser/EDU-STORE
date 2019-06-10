
-------------Database creation-------------
--create database EduStore
Create database Edustore
GO
use Edustore

------------Table Creation----------------
create table Admin
(
Username varchar(50) unique not null,
Password varchar(150) NOT NULL
)
	

------Employee--------

create table Employee
(
SSN int  Identity(1,1),
Name varchar(50) NOT NULL,
Username varchar(50) unique not null,

password varchar(150) NOT NULL,

Hours int NULL,

Primary key (SSN)
)

----------Store-----------------
create table Store
(

Name varchar(50) NOT NULL,

Address varchar(50) NULL,

Username varchar(50) unique not null,

Password varchar(150) NOT NULL,

ESSN int NULL,

Primary key (Name),

foreign key (ESSN) references Employee
On update No action
On delete No action
)
-----------refernence to store for employee-------------
alter table Employee add Store_Name varchar(50)
alter table Employee add foreign key (Store_Name) references Store


-------------Customer----------------------
create table customer 
(
CU_ID int Identity(1,1),

Username varchar(50) unique not null,

password varchar(150) NOT NULL,

CU_Name varchar(50) NOT NULL,

Email varchar(50) NULL,

Phone int NOT NULL,

Age int NULL,

Wallet_points int Default 0,

Address Varchar(50) NOT NULL,

Credit_Card int NULL,

primary key (CU_ID)
)

--------------Department---------------
CREATE TABLE DEPARTMENT (
NAME VARCHAR(50) NOT NULL,
on_sale int default 0,

PRIMARY KEY(NAME)
)

---------------Product----------------
create table Product
(
P_ID int Identity(1,1),

Description Varchar(50) NOT NULL,

Quantity int NOT NULL,

Price_dollars float NOT NULL,

Price_points float NOT NULL,

Store_Name varchar(50) NOT NULL,

DName varchar(50) NOT NULL,

Primary key (P_ID),

foreign key (Store_Name) references Store
On update No action
On delete No action,

foreign key (DName) references Department
On Update No action
On delete No action
)
--------------Book----------------------
CREATE TABLE Book (
B_ID INTEGER Identity(1,1),

Name VARCHAR(50) NOT NULL,

Author VARCHAR(50) NOT NULL,

Quantity int NOT NULL,

Price_dollars float NOT NULL,

Price_points float NOT NULL,

Store_Name varchar(50) NOT NULL,

PRIMARY KEY(B_ID),

foreign key (Store_Name) references Store
On update No action
On delete No action
)

-------------Shopping Carts-----------------
create table Shopping_Cart
(
SC_ID int Identity(1,1),

Cu_ID int NOT NULL UNIQUE,

Total_Cost float default 0,

primary key (SC_ID,Cu_ID),

Foreign key (Cu_ID) references Customer
On update No action
On delete No action,
)
-------------Shopping Cart Content-----------
create table SC_contents
(
ID int Identity(1,1),

SC_ID int NOT NULL,

CU_ID int NOT NULL,

Item varchar(50) NOT NULL,

Dname varchar(50) null, 

store_name varchar(50) NOT NULL,

Price_dollars int NOT NULL,

Price_points int NOT NULL,

primary key (ID),
Foreign key (SC_ID,CU_ID) references Shopping_Cart
On update No action
On delete No action,
Foreign key (Dname) references Department
On update No action
On delete No action,
)
------------Order--------------------
create table Orders
(
O_ID int Identity(1,1),


SC_ID int NOT NULL,

CU_ID int NOT NULL,

Item varchar(50),

Price_dollars int NOT NULL,

Price_points int NOT NULL,

Store_Name varchar(50),

PayMethod varchar(50) NULL,

ESSN int  NULL,
ostate varchar(50) NULL,

Primary key (O_ID,Cu_ID,SC_ID),

foreign key (Cu_ID) references Customer
On update No action
On delete no action,

foreign key (Store_name) references store
On update No action
On delete no action,

foreign key (ESSN) references Employee
On update no action
On delete no action

)

-----------------Payment------------------
CREATE TABLE PAYMENT 
(

pay_ID int identity(1,1),

O_ID int ,

SC_ID int NOt NULL,
CU_ID int NOT NULL,

Item varchar(50),

Price_dollars int NOT NULL,

Price_points int NOT NULL,

Store_Name varchar(50),

PayMethod varchar(50) NULL,

ESSN int  NULL,


PRIMARY KEY(pay_ID),

)
---------------Sale-----------------
create table Sales
(

Percentage int NOT NULL,

Dname varchar(50) Not NUll,

Store_Name varchar(50),

Primary Key(Dname,Store_Name),
FOREIGN KEY(Dname) REFERENCES Department
ON UPDATE No action
ON DELETE No action,
FOREIGN KEY(Store_Name) REFERENCES Store
ON UPDATE No action
ON DELETE No action
)




----------Printing Order(filled & added to SC)-------------------
CREATE TABLE Printing_Order (

ID INTEGER Identity(1,1), 

No_copies INTEGER NOT NULL,

sources varchar(50) NOT NULL,

Size VARCHAR(10) NOT NULL,
color varchar(50),
Price_dollars int ,

Price_points int ,

SC_ID int NOT NULL,

CU_ID INTEGER NOT NULL,

PRIMARY KEY(ID),
FOREIGN KEY(SC_ID,Cu_ID) REFERENCES Shopping_Cart
ON UPDATE No action 
ON DELETE No action,
)
----------------------------------------------------------------------------------

---------------Inserting values into tables----------------
insert into Admin 
values
('Admin1' ,'QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY='),
('Admin2' ,'QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=')




insert into customer 
values
('CU1','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=','John Smith','J_S@gmail.com',22332,20,0,'731 Fondren, Houston, TX',2343),

('CU2','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=','Franklin Wong','F_W@gmail.com',2332,22,0,'731 maadi, Houston, TX',23411),

('CU3','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=','Joyce Goku','J_G@gmail.com',232,24,0,'731 hello, Houston, TX',2356423),

('CU4','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=','Rameesh Narayan','R_N@gmail.com',30595,21,0,'731 shewa, Houston, TX',9994),

('CU5','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=','Kefla Goku','K_G@gmail.com',09595,29,0,'731 mals, Houston, TX',24844),

('CU6','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=','Joyce James','Jamesjoycee@gmail.com',04380,24,0,'731 kiwi, Houston, TX',23458),

('CU7','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=','Lami Orthodox','J_orthodocxx@gmail.com',09493,24,0,'731 zinga, Houston, TX',23426),

('CU8','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=','John Makram','J_makramgmail.com',222,20,0,'731 Fondren, Houston, TX',2343),

('CU9','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=','Franklin Smith','F_smith@gmail.com',2335,22,0,'731 maadi, Houston, TX',6411),

('CU10','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=','Joyce Mansour','mansour2020@gmail.com',2335122,24,0,'731 hello, Houston, TX',23223),

('CU11','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=','Rameesh Samy','samiiii@gmail.com',305346195,21,0,'731 shewa, Houston, TX',95094),

('CU12','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=','Kefla Mamaro','keflamamarooo@gmail.com',093146,29,0,'731 mals, Houston, TX',24494),

('CU13','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=','Joyce Wong','wongation@gmail.com',0380,24,0,'731 kiwi, Houston, TX',239938),

('CU14','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=','Lami Moaasser','lami98@gmail.com',090493,24,0,'731 zinga, Houston, TX',23826),

('CU15','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=','Will Smith','willsmith23@gmail.com',22302,20,0,'731 Fondren, Houston, TX',23743),

('CU16','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=','Samy Wong','sammu@gmail.com',23432,22,0,'731 maadi, Houston, TX',234611),

('CU17','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=','Mohamed Goku','mohammmedd@gmail.com',234572,24,0,'731 hello, Houston, TX',23523),

('CU18','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=','Salma Narayan','salmoooka@gmail.com',30255,21,0,'731 shewa, Houston, TX',95494),

('CU19','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=','Zeyad Goku','zizoooq23@gmail.com',0595,29,0,'731 mals, Houston, TX',24434),

('CU20','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=','Lebron James','L_james@gmail.com',04780,24,0,'731 kiwi, Houston, TX',23382),

('CU21','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=','Mayada Moustafa','mayadaa1@gmail.com',09493,24,0,'731 zinga, Houston, TX',23261)





insert into Store
values
('Alpha','Houston, TX','ST1','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=',null),
('Omega','Houston, TX','ST2','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=',null),
('Beta','Houston, TX','ST3','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=',null),
('samirali','Houston, TX','ST4','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=',null)


insert into Employee
values
('Mohamed','EMP1','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=',8,'Omega'),
('Salah','EMP2','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=',6,'Alpha'),
('Eddy','EMP3','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=',4,'Beta'),
('Wael','EMP4','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=',7,'samirali'),
('Ahmed','EMP5','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=',8,'Omega'),
('Saaed','EMP6','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=',6,'Alpha'),
('Saad','EMP7','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=',4,'Beta'),
('Sayed','EMP8','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=',7,'samirali'),
('Mahmoud','EMP9','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=',8,'Omega'),
('Samy','EMP10','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=',6,'Alpha'),
('Esmail','EMP11','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=',4,'Beta'),
('Montasser','EMP12','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=',7,'samirali'),
('Mohsen','EMP13','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=',8,'Omega'),
('Ali','EMP14','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=',6,'Alpha'),
('Ibrahimy','EMP15','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=',4,'Beta'),
('Mostafa','EMP16','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=',7,'samirali'),
('Kareem','EMP17','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=',8,'Omega'),
('Abdelrahman','EMP18','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=',6,'Alpha'),
('Abdelghafaar','EMP19','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=',4,'Beta'),
('Loay','EMP20','QONfyK684R4tQraU7PtS5hdX+qIE/1XPwMsh8uP4yLY=',7,'samirali')

update Store set ESSN = 1 where Name='Omega'
update Store set ESSN = 2 where Name='Alpha'
update Store set ESSN = 3 where Name='Beta'
update Store set ESSN = 4 where Name='samirali'

insert into Department
values
('Architecture',0),
('School equipments',0),
('Electronics',0),
('Data holders',0),
('Drawing',0),
('Accessories',0)


insert into Product
values
('Pencil rotring',5,2,20,'samirali','School equipments'),
('Ruler 80 cm',5,1,10,'samirali','School equipments'),
('Pencil fabrcastle',5,2,20,'samirali','School equipments'),
('compass rotring',5,5,30,'samirali','School equipments'),
('ruler 120 cm',5,3,30,'samirali','School equipments'),
('ruler 100 cm',5,2,20,'samirali','School equipments'),
('map',5,3,30,'samirali','Accessories'),
('board 20x60',5,10,100,'samirali','Accessories'),
('board 40,80',5,15,150,'samirali','Accessories'),
('Pencil rotring',5,2,20,'Beta','School equipments'),
('Ruler 80 cm',5,1,10,'Alpha','School equipments'),
('Pencil fabrcastle',5,2,20,'Alpha','School equipments'),
('compass rotring',5,5,30,'Alpha','School equipments'),
('ruler 120 cm',5,3,30,'Alpha','School equipments'),
('ruler 100 cm',5,2,20,'Alpha','School equipments'),
('map',5,3,30,'Alpha','Accessories'),
('board 20x60',5,10,100,'Alpha','Accessories'),
('Pencil rotring',5,2,20,'Alpha','School equipments'),
('Ruler 80 cm',5,1,10,'Beta','School equipments'),
('Pencil fabrcastle',5,2,20,'Beta','School equipments'),
('compass rotring',5,5,30,'Beta','School equipments'),
('ruler 120 cm',5,3,30,'Beta','School equipments'),
('ruler 100 cm',5,2,20,'Beta','School equipments'),
('map',5,3,30,'Beta','Accessories'),
('board 20x60',5,10,100,'Beta','Accessories'),
('Ruler 80 cm',5,1,10,'Beta','School equipments'),
('Pencil fabrcastle',5,2,20,'Beta','School equipments'),
('compass rotring',5,5,30,'Beta','School equipments'),
('ruler 120 cm',5,3,30,'Beta','School equipments'),
('ruler 100 cm',5,2,20,'Beta','School equipments'),
('map',5,3,30,'Beta','Accessories'),
('board 20x60',5,10,100,'Beta','Accessories'),
('ruler 120 cm',5,3,30,'Omega','School equipments'),
('ruler 100 cm',5,2,20,'Omega','School equipments'),
('map',5,3,30,'Omega','Accessories'),
('board 20x60',5,10,100,'Omega','Accessories'),
('Chasset',5,2,20,'samirali','Architecture'),
('Maquette',5,1,10,'samirali','Architecture'),
('Calculator',5,2,20,'samirali','Electronics'),
('Faber Castle 12 colors',5,5,30,'samirali','Drawing'),
('Faber Castle 24 colors',5,3,30,'samirali','Drawing'),
('Clear holder 100 paper',5,2,20,'samirali','Data holders'),
('File',5,3,30,'samirali','Data holders'),
('scientific caclulator',5,10,100,'samirali','Electronics'),
('masepian',5,15,150,'samirali','Architecture'),
('Maquette',5,1,10,'alpha','Architecture'),
('Calculator',5,2,20,'alpha','Electronics'),
('Faber Castle 12 colors',5,5,30,'alpha','Drawing'),
('Faber Castle 24 colors',5,3,30,'alpha','Drawing'),
('Clear holder 100 paper',5,2,20,'alpha','Data holders'),
('Maquette',5,1,10,'beta','Architecture'),
('Calculator',5,2,20,'beta','Electronics'),
('Faber Castle 12 colors',5,5,30,'beta','Drawing'),
('Faber Castle 24 colors',5,3,30,'beta','Drawing'),
('Clear holder 100 paper',5,2,20,'beta','Data holders'),
('Maquette',5,1,10,'omega','Architecture'),
('Calculator',5,2,20,'omega','Electronics'),
('Faber Castle 12 colors',5,5,30,'omega','Drawing'),
('Faber Castle 24 colors',5,3,30,'omega','Drawing'),
('Clear holder 100 paper',5,2,20,'omega','Data holders')



insert into BOOK
values
('Jane Eyre','charles bronte',5,20,1000,'samirali'),
('Tale of Two Cities','charles dickens',5,25,1200,'Beta'),
('Murder is Announced','agatha christie',5,23,1100,'Omega'),
('Hepta','Amr Hussein',5,20,1000,'alpha'),
('Feel alazrak','Ahmed Mourad',5,25,1200,'Beta'),
('Murder is Announced part 2','agatha christie',5,23,1100,'Omega'),
('Harry Potter and the philosphers stone','jk rowling',5,20,1000,'samirali'),
('Harry Potter and the chamber of secrets','jk rowling',5,25,1200,'Beta'),
('Harry Potter and the prisoner of zenda','jk rowling',5,23,1100,'Omega'),
('Harry Potter and the goblet of fire','jk rowling',5,20,1000,'samirali'),
('Harry Potter and the order of phoenix','jk rowling',5,25,1200,'Beta'),
('Harry Potter and the half blood prince','jk rowling',4,23,1100,'alpha'),
('Harry Potter and the deathly hallows','jk rowling',5,20,1000,'samirali'),
('oliver twist','charles dickens',5,25,1200,'Beta'),
('Murder is Announced part 3','agatha christie',5,23,1100,'Omega'),
('Jane Eyre part 2','charles bronte',5,20,1000,'alpha'),
('Around the world in 80 days','jules verne',5,25,1200,'Beta'),
('Twilight saga Lunar eclipse','stepanie meyer',5,23,1100,'Omega'),
('the host','stephanie meyer',5,20,1000,'samirali'),
('Twilight saga breaking dawn','stepanie meyer',5,25,1200,'Beta'),
('Twilight saga new moon','stepanie meyer',5,23,1100,'Omega'),
('The Secret','phonda byrne',5,20,1000,'samirali'),
('welad haretna','naguib mahfouz',5,25,1200,'Beta'),
('macbeth','shakespeare',5,23,1100,'alpha')


insert into Shopping_Cart
values
(1,0),
(2,0),
(3,0),
(4,0),
(5,0),
(6,0),
(7,0),
(8,0),
(9,0),
(10,0),
(11,0),
(12,0),
(13,0),
(14,0),
(15,0),
(16,0),
(17,0),
(18,0),
(19,0),
(20,0),
(21,0)




insert into SC_contents
values
(1,1,'suiter','School equipments','Omega',100,100)


insert into Sales
values
(20,'Architecture','samirali'),
(25,'Electronics','omega'),
(10,'School equipments','beta'),
(15,'Drawing','alpha')




insert into Orders
values
(1,1,'le3ba',10,10,'samirali','Cash',NULL,NULL)




insert into Printing_Order
values
(2,'jefs.com','A3','Black',NULL,NULL,1,1)


insert into PAYMENT
values
(1,1,1,'sajhsa',23,22,'samirali','Cash',4)


