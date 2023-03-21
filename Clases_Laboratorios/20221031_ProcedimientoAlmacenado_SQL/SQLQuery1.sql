create procedure sp_Cliente_Select
@cedula as nchar(15) = null
as
   if @cedula is null 
      select * from cliente
   else
      select * from cliente where cedula = @cedula



 exec sp_Cliente_Select

 drop procedure sp_Cliente_Select
