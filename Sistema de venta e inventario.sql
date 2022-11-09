--Definicion de procedimientos almacenados   by Bill Gates!!

CREATE DATABASE Venta_Inventario;
USE Venta_Inventario;

CREATE TABLE Categoria(
	id_categoria INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	nombre VARCHAR(50) NOT NULL,
	descripcion VARCHAR(256) NOT NULL
);

CREATE TABLE Producto(
	id_producto INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	id_categoria INT NOT NULL,
	CONSTRAINT fk_id_categoria FOREIGN KEY (id_categoria)
	REFERENCES Categoria (id_categoria),
	codigo INT NOT NULL,
	nombre VARCHAR(50) NOT NULL,
	descripcion VARCHAR(1025) NULL,
	imagen VARCHAR(256) NULL
);

CREATE TABLE Proveedor(
	id_proveedor INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	nombre VARCHAR(50) NOT NULL,
	sector_comercial VARCHAR(256) NOT NULL,
	num_documento VARCHAR(12) NOT NULL,
	direccion VARCHAR(256) NULL,
	telefono VARCHAR(9) NULL,
	email VARCHAR(256) NULL,
	dirc_url VARCHAR(256) NULL
);

CREATE TABLE Ingreso(
	id_ingreso INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	id_producto INT NOT NULL,
	CONSTRAINT fk_id_producto FOREIGN KEY (id_producto)
	REFERENCES Producto (id_producto),
	id_proveedor INT NOT NULL,
	CONSTRAINT fk_id_proveedor FOREIGN KEY (id_proveedor)
	REFERENCES Proveedor (id_proveedor),
	fecha DATE NOT NULL,
	precio_compra DECIMAL(11,2) NOT NULL,
	precio_venta DECIMAL(11,2) NOT NULL,
	stock_inicial INT NOT NULL,
	stock_actual INT NOT NULL,
	fecha_produccion DATE NOT NULL,
	fecha_vencimiento DATE NOT NULL
);

CREATE TABLE Cliente(
	id_cliente INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	nombre VARCHAR(50) NOT NULL,
	apellido VARCHAR(50) NULL,
	sexo VARCHAR(1) NULL,
	fecha_nacimiento varchar(50) NOT NULL,
	cedula VARCHAR(12) NOT NULL,
	direccion VARCHAR(256) NULL,
	telefono VARCHAR(9) NULL,
	email VARCHAR(256) NULL
);

CREATE TABLE Trabajador(
	id_trabajador INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	nombre VARCHAR(50) NOT NULL,
	apellido VARCHAR(50) NOT NULL,
	sexo VARCHAR(1) NOT NULL,
	fecha_nacimiento DATE NOT NULL,
	cedula VARCHAR(12) NOT NULL,
	direccion VARCHAR(256) NULL,
	telefono VARCHAR(9) NULL,
	email VARCHAR(256) NULL
);

CREATE TABLE Venta(
	id_venta INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	id_cliente INT NOT NULL,
	CONSTRAINT fk_id_cliente FOREIGN KEY (id_cliente)
	REFERENCES Cliente (id_cliente),
	id_trabajador INT NOT NULL,
	CONSTRAINT fk_id_trabajador FOREIGN KEY (id_trabajador)
	REFERENCES Trabajador (id_trabajador),
	id_ingreso INT NOT NULL,
	CONSTRAINT fk_id_ingreso FOREIGN KEY (id_ingreso)
	REFERENCES Ingreso (id_ingreso),
);


insert into [dbo].[Categoria] ([nombre], [descripcion]) values ('Bebidas', 'Refrescos, cafés, tés, cervezas y cervezas' );
insert into [dbo].[Categoria] ([nombre], [descripcion]) values ('condimentos', 'Salsas dulces y saladas, condimentos, pastas para untar y condimentos' );
insert into [dbo].[Categoria] ([nombre], [descripcion]) values ('dulces', 'Postres, dulces y panes dulces' );
insert into [dbo].[Categoria] ([nombre], [descripcion]) values ('Productos lácteos', 'Quesos' );
insert into [dbo].[Categoria] ([nombre], [descripcion]) values ('Granos/Cereales', 'Panes, galletas saladas, pasta y cereales' );
insert into [dbo].[Categoria] ([nombre], [descripcion]) values ('Carne de ave', 'carnes preparadas' );
insert into [dbo].[Categoria] ([nombre], [descripcion]) values ('Producir', 'Frutos secos y tofu' );
insert into [dbo].[Categoria] ([nombre], [descripcion]) values ('Mariscos', 'algas y pescado' );

select*from [dbo].[Categoria]



create procedure AgregarClientes

	@nombre varchar(50),
	@apellido varchar(50),
	@sexo char, 
	@fecha_nacimiento varchar(50), 
	@cedula varchar(12),
	@direccion varchar(256),
	@telefono varchar(9),
	@email varchar(256)



as 

insert into Cliente ([nombre],[apellido],[sexo],[fecha_nacimiento],[cedula],[direccion],[telefono],[email])
values (@nombre,@apellido,@sexo,@fecha_nacimiento,@cedula,@direccion,@telefono,@email)

go


create procedure MostrarClientes
as
select*from Cliente
go
