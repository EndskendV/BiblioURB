create database urban
use urban

create table Personal(
ID_Personal int identity(1,1)primary key,
NameP nvarchar (50) not null,
FechNacimiento datetime not null,
DomicilioP nvarchar(100) not null,
MailP nvarchar (100) not null,
TelefonoP nvarchar(10) not null)

create table Libros(
ID_Book int identity(1,1) primary key,
NameBook varchar (100) not null,
AutorBook varchar (100) not null,
EditorialB varchar (100) not null,
FechaPublicacion varchar (100) not null,
Tematica varchar (100) not null,
Precio float not null)

create table Computadoras(
ID_PC int identity(0,1)primary key,
Disponible int not null)

create table Ventas(
ID_Book int primary key,
foreign key(ID_Book) references Libros(ID_Book),
EstadoLibro int not null,
ID_Personal int,
foreign key(ID_Personal) references Personal(ID_Personal),
Precio float)


