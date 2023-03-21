create procedure sp_Cliente_Agregar
@cedula as nchar(15),
@nombre as nchar(20),
@apellido as nchar(20)
as
	insert into cliente(cedula,nombre,apellido) values(@cedula,@nombre,@apellido)



	exec sp_Cliente_Agregar
	exec sp_Cliente_Select
	drop procedure sp_cliente_Agregar
	exec sp_Cliente_Agregar '6-2-1','Anasp','Lopezsp'