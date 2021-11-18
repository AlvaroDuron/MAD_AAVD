USE HydroLAN;
use Proyecto;


CREATE PROCEDURE sp_ModificarCategoria(@categoria char(1), @porcentaje decimal)
AS
BEGIN
UPDATE Categoria SET porcentaje = @porcentaje WHERE categoria = @categoria;
END
GO

CREATE PROCEDURE sp_ConsultarZonas
AS
BEGIN
SELECT * FROM Zona;
END
GO

CREATE PROCEDURE sp_ModificarZona(@municipio varchar(100), @numeroZona int)
AS
BEGIN
UPDATE Zona SET numeroZona = @numeroZona WHERE municipio = @municipio;
END
GO

CREATE PROCEDURE sp_AgregarZona(@municipio varchar(100), @numeroZona int)
AS
BEGIN
INSERT INTO Zona(municipio, numeroZona) VALUES(@municipio, @numeroZona);
END
GO

CREATE PROCEDURE sp_EliminarZona(@municipio varchar(100))
AS
BEGIN
DELETE Zona WHERE municipio = @municipio;
END
GO

select * from Categoria;
insert into Usuario(nombreUsuario, contraseña, empleadoCliente, intentos, estado) values('mohidan', 123, 1, 0, 0);
insert into Usuario(nombreUsuario, contraseña, empleadoCliente, intentos, estado) values('aldana', 123, 2, 0, 0);

insert into Categoria(categoria, porcentaje) values('A', 0.10);
insert into Categoria(categoria, porcentaje) values('B', 0.15);
insert into Categoria(categoria, porcentaje) values('C', 0.18);