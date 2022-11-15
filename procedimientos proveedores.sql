use [Venta_Inventario]
select*from [dbo].[Proveedor]

select*from [dbo].[Venta]

select*from [dbo].[Ingreso]
select*from Proveedor
create procedure ListarProveedores
as
	select Proveedor.id_proveedor[ID],Proveedor.nombre[Nombre], Proveedor.email[E-Mail], Proveedor.sector_comercial[Sector Comercial],
	Proveedor.num_documento[Numero Documento], Proveedor.direccion[Direccion], Proveedor.telefono[Telefono],
	Proveedor.dirc_url[Pagina Web]	from Proveedor
go
create procedure InsertarProvedor

@nombre varchar(50),
@sector varchar(256),
@num_documento varchar(12),
@direccion varchar(256),
@telefono varchar(9),
@email varchar(256),
@dirc_url varchar(256)
as
	if @email = (select Proveedor.email from Proveedor where Proveedor.email = @email)
	begin 
		select 'error'
	end
	else 
	begin 
		insert into Proveedor ([nombre],[sector_comercial],[num_documento],[direccion],[telefono],[email],[dirc_url])
		values (@nombre,@sector,@num_documento,@direccion,@telefono,@email,@dirc_url)	
	end
	
go



alter procedure EliminarProducto
@id int
as
 delete from Producto where Producto.id_producto = @id
go

alter procedure ActualizarProducto
@id_producto int,
@id_categoria int, 
@codigo int,
@nombre varchar(50),
@descripcion varchar(1025),
@imagen varbinary(max),
@Precio_venta money,
@Precio_compra money
as
	update Producto set Producto.codigo = @codigo, Producto.descripcion = @descripcion, Producto.id_categoria = @id_categoria, Producto.imagen = @imagen, Producto.nombre = @nombre,
	Producto.Precio_Venta = @Precio_venta, Producto.Precio_Compra = @Precio_compra
	where Producto.id_producto = @id_producto
go

select*from Producto

select*from Ingreso


alter table Ingreso
	alter column fecha varchar(40)


alter table Ingreso
 alter column precio_compra money

alter table Ingreso
 alter column precio_venta money

 alter table Ingreso
 alter column fecha_produccion varchar(40)

  alter table Ingreso
 alter column fecha_vencimiento varchar(40)



alter procedure RegistrarInventario
 @id_producto int, 
 @fecha varchar(40),
 @stock int
 as
 if @id_producto = (select Ingreso.id_producto from Ingreso where Ingreso.id_producto = @id_producto)
 begin
  select 'Error'
 end 
 else
 begin
 	insert into Ingreso ([id_producto],[fecha],[stock_actual]) 
	Values (@id_producto,@fecha,@stock)

 end
 go

 create procedure ListarProveedores_Inventario
 as
 select id_proveedor, nombre From Proveedor
 go


 alter PROCEDURE [dbo].[LISTAR_INVENTARIO]
AS 
SELECT Ingreso.id_ingreso[ID],Ingreso.id_producto, Producto.nombre, 
Ingreso.stock_actual[Stock Actual],Ingreso.fecha[Fecha] FROM [dbo].[Ingreso]
inner join Producto on Producto.id_producto = Ingreso.id_producto
GO


create procedure EliminarInventario
@id_Ingreso int
as
 delete Ingreso where Ingreso.id_ingreso = @id_Ingreso
go

alter procedure ActualizarInventario
 @id_ingreso int,
 @id_producto int, 
 @fecha varchar(40),
 @stock_actual int

 as
	update Ingreso set  Ingreso.id_producto = @id_producto, Ingreso.fecha = @fecha,
	 Ingreso.stock_actual = @stock_actual where Ingreso.id_ingreso = @id_ingreso
 go



 create table LineaPedido
(
id_LineaPedido int IDENTITY(1,1) NOT NULL,
id_producto int not null,
id_venta int not null,
precio_unitario money,
descripcion varchar(256),
cantidad int,
impuesto decimal,
subtotal money


foreign key (id_producto) references Producto(id_producto),
foreign key (id_venta) references Venta(id_venta),
Primary key (id_LineaPedido)
)


alter table Venta
add Total_Venta Money

alter table Venta
add Fecha Date

alter table producto
add Precio_Venta money
alter table producto
add Precio_Compra money

alter procedure

Alter PROCEDURE [dbo].[LISTAR_PRODUCTOS]
AS

SELECT Producto.id_producto[ID DEL PRODUCTO], Producto.codigo[CODIGO DEL PRODUCTO], Producto.nombre[NOMBRE DEL PRODUCTO], Producto.descripcion[DESCRIPCION DEL PRODUCTO],
Categoria.nombre[CATEGORIA], Producto.Precio_Venta[Precio Venta], Producto.Precio_Compra[Precio Compra], Producto.imagen
FROM [dbo].[Producto] INNER JOIN [dbo].[Categoria] ON Producto.id_categoria = Categoria.id_categoria

GO

select*from Venta


create view Lista_Ventas
 

select*from Producto

alter procedure [dbo].[InsertarProducto] 
@id_categoria int, 
@codigo int,
@nombre varchar(50),
@descripcion varchar(1025),
@imagen varbinary(max),
@Precio_venta money,
@Precio_compra money
as 
	INSERT INTO Producto ([id_categoria],[codigo],[nombre],[descripcion],[imagen],[Precio_Venta],[Precio_Compra]) 
	values (@id_categoria,@codigo,@nombre,@descripcion,@imagen,@Precio_venta,@Precio_compra)
GO

SELECT*FROM [dbo].[LineaPedido]
SELECT*FROM [dbo].[Venta]
exec MostrarLineaPedido 6

select*from Categoria

alter procedure MostrarLineaPedido

@id_Producto int
as
	SELECT Ingreso.id_ingreso[ID Ingreso], Producto.id_producto[ID Produto], Producto.nombre[Nombre Producto], 
	Producto.id_categoria[ID Categoria], Categoria.nombre[Categoria], Producto.Precio_Venta, Ingreso.stock_actual[Stock Disponible] from
	Producto Inner Join Categoria on Categoria.id_categoria = Producto.id_categoria Inner join 
	Ingreso on Ingreso.id_producto = Producto.id_producto where Producto.id_producto = @id_Producto
			
go
insert into [dbo].[Categoria] ([nombre], [descripcion]) values ('condimentos', 'Salsas dulces y saladas, condimentos, pastas para untar y condimentos' );
insert into [dbo].[Categoria] ([nombre], [descripcion]) values ('dulces', 'Postres, dulces y panes dulces' );
insert into [dbo].[Categoria] ([nombre], [descripcion]) values ('Productos lácteos', 'Quesos' );
insert into [dbo].[Categoria] ([nombre], [descripcion]) values ('Granos/Cereales', 'Panes, galletas saladas, pasta y cereales' );
insert into [dbo].[Categoria] ([nombre], [descripcion]) values ('Carne de ave', 'carnes preparadas' );
insert into [dbo].[Categoria] ([nombre], [descripcion]) values ('Producir', 'Frutos secos y tofu' );
insert into [dbo].[Categoria] ([nombre], [descripcion]) values ('Mariscos', 'algas y pescado' );

insert into Categoria ([nombre],[descripcion]) values ('Bebidas alcohólicas','Carvezas, Licores, Champagne..')

select*from Categoria

exec MostrarLineaPedido 6

select*from Venta
select*from LineaPedido


USE [Venta_Inventario]



select*from Venta
select*from LineaPedido


alter table LineaPedido
alter column subtotal decimal
alter table LineaPedido
alter column impuesto decimal
alter table LineaPedido
alter column precio_unitario decimal

alter Procedure CrearVenta
@id_ingreso int,
@id_trabajador int, 
@id_cliente int,
@id_producto int, 
@descripcion varchar(256),
@precio_unitario Decimal,
@cantidad int,
@fecha date,
@itbms Decimal, 
@sub_total Decimal,
@venta_total Decimal

as
if @cantidad > (Select Ingreso.stock_actual from Ingreso where Ingreso.id_producto = @id_producto)
begin 
	SELECT 'ERROR'
end 
else
BEGIN
	update Ingreso set Ingreso.stock_actual = Ingreso.stock_actual-@cantidad
	insert into Venta ([id_cliente],[id_trabajador],[id_ingreso],[Total_Venta],[Fecha]) 
values (@id_cliente, @id_trabajador, @id_ingreso, @venta_total, @fecha)

declare @id_venta int	
set @id_venta= (select max(Venta.id_venta) from Venta)

insert into LineaPedido ([id_producto],[id_venta],[precio_unitario],[descripcion],[cantidad],[impuesto],[subtotal]) 
values(@id_producto, @id_venta, @precio_unitario, @descripcion, @cantidad, @itbms, @sub_total)
end 


go

select*from Producto
select max(Producto.id_producto) from Producto