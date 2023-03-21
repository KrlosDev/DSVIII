create procedure sp_Cliente_Select
@cedula as nchar(15) = null,
@orden as char(20) = null
as
   if @cedula is null
      if @orden is null
         select * from cliente, provincia where cod_provincia = codigo
      else
	     select * from cliente, provincia where cod_provincia = codigo order by
		    case
			when @orden = 'cedula' then cedula
			when @orden = 'nombre' then nombre
			end
   else
      select * from cliente, provincia where cedula = @cedula and cod_provincia=codigo

drop procedure sp_Cliente_Select