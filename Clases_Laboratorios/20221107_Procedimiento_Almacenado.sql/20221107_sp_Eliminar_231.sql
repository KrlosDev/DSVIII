create procedure sp_Cliente_Eliminar
@cedula as nchar(15)
as
	delete from cliente where cedula = @cedula


	exec sp_cliente_select
	exec sp_cliente_eliminar
	drop procedure sp_cliente_eliminar