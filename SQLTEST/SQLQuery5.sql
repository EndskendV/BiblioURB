create database next
use next

create  table Departamento(
ID_Dep int identity(1,1) primary key,
NameDep nvarchar (100) not null
)
create table Plaza(
ID_Plaza int identity(1,1) primary key,
NamePlaza varchar(100)not null,
TipoPlaza varchar(100)
)

create table Instructor(
ID_Instructor int identity(1,1) primary key,
NameInstrcn varchar (100) not null,
ID_Dep int,
foreign key(ID_Dep) references Departamento(ID_Dep)
)
create table Asistencia(
ID_Asistencia int primary key)

create table Curso(
ID_Curso varchar(10)  primary key,
ID_Instructor int,
NameCurso varchar(100) not null,
Horario datetime,
LugarCurso varchar(100)not null,
TipoCurso varchar(100) not null,
foreign key(ID_Instructor) references Instructor(ID_Instructor)
)

create table Docente(
ID_Docente varchar(10) primary key,
ID_Plaza int not null,
ID_Dep int not null,
NameDocente varchar(100)not null,
ID_Curso varchar(10)not null,
foreign key (ID_Plaza) references Plaza(ID_Plaza),
foreign key (ID_Dep) references Departamento(ID_Dep),
foreign key (ID_Curso) references Curso(ID_Curso)
)

create table Grupo(
ID_Grupo varchar(10) primary key,
HorarioGroup datetime,
ID_Docente varchar(10) not null,
ID_Curso varchar(10)not null,
ID_Plaza int,
ID_Asistencia int,
foreign key(ID_Docente) references Docente(ID_Docente),
foreign key (ID_Curso) references Curso(ID_Curso),
foreign key (ID_Plaza) references Plaza(ID_Plaza),
foreign key (ID_Asistencia) references Asistencia(ID_Asistencia)
)