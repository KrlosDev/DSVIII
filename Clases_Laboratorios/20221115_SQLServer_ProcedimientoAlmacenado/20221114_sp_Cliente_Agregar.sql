create procedure sp_Cliente_Agregar
@cedula as nchar(15),
@nombre as nchar(20),
@apellido as nchar(20),
@cod_provincia as nchar(2)
as
	insert into cliente(cedula,nombre,apellido,cod_provincia) values(@cedula,@nombre,@apellido,@cod_provincia)
