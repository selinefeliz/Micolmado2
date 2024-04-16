create dataBase MiColmado
Use MiColmado

CREATE TABLE users(
    userID   INT PRIMARY KEY IDENTITY,
    userName VARCHAR (50),
    upass    VARCHAR (10),
    uName    VARCHAR (50),
    uPhone   VARCHAR (20),
    uImage image
    );

Create table Category
(
catID int primary key identity,
catName varchar (150) not null
)

Create table Customer
(
cusID int primary key identity,
cusName varchar (50) not null,
CusPhone varchar (50),
CusEmail varchar (50),
)

Create table Supplier
(
supID int primary key identity,
supName varchar (50) not null,
supPhone varchar (50),
supEmail varchar (50),
)

Create table products
(
proID int primary key identity,
proName varchar (50) not null,
pCatID int,
proCode varchar (50),
proCost float,
proPrice float,
proImage image,
)



