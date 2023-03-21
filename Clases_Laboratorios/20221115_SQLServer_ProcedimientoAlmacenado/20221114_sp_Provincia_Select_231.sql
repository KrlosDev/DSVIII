create procedure sp_Provincia_Select
as
	select * from provincia order by provincia

	exec sp_Provincia_Select