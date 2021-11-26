USE HydroLAN;
use Proyecto;

CREATE TABLE Categoria
( categoria CHAR(1) PRIMARY KEY NOT NULL,
porcentaje FLOAT
);

CREATE PROCEDURE sp_ConsultarCategoriasPorCategoria
AS
BEGIN
SELECT categoria FROM Categoria;
END
GO

CREATE PROCEDURE sp_ConsultarCategorias
AS
BEGIN
SELECT categoria, porcentaje FROM Categoria;
END
GO

CREATE PROCEDURE sp_BuscarCategoria(@categoria char(1))
AS
BEGIN
SELECT categoria, porcentaje FROM Categoria WHERE categoria = @categoria;
END
GO

CREATE PROCEDURE sp_ModificarCategoria(@categoria char(1), @porcentaje float)
AS
BEGIN
UPDATE Categoria SET porcentaje = @porcentaje WHERE categoria = @categoria;
END
GO


INSERT INTO Categoria(categoria, porcentaje) VALUES('A', 0.5);
INSERT INTO Categoria(categoria, porcentaje) VALUES('B', 0.8);
INSERT INTO Categoria(categoria, porcentaje) VALUES('C', 0.9);
SELECT * FROM Categoria;