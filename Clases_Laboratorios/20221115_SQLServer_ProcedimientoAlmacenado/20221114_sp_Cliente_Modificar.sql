create procedure sp_Cliente_Modificar
@cedula as nchar(15),
@nombre as nchar(20),
@apellido as nchar(20),
@cod_provincia as nchar(2)
as
	update cliente set nombre = @nombre, apellido = @apellido, cod_provincia = @cod_provincia where cedula = @cedula
