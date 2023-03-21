create procedure sp_Cliente_Modificar
@cedula as nchar(15),
@nombre as nchar(20),
@apellido as nchar(20)
as
	update cliente set nombre = @nombre, apellido = @apellido where cedula = @cedula


exec sp_cliente_modificar
exec sp_Cliente_Select
drop procedure sp_Cliente_Modificar

exec sp_cliente_modificar '6-3-1','Luis_xx','Perez_xx'