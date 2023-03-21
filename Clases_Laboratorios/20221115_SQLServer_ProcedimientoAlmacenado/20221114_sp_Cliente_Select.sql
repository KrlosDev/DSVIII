create procedure sp_Cliente_Select
@cedula as nchar(15) = null
as
   if @cedula is null 
      select * from cliente
   else
      select * from cliente, provincia where cedula = @cedula and cod_provincia=codigo

