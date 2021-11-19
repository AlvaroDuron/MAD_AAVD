USE HydroLAN;
use Proyecto;


CREATE PROCEDURE sp_ModificarCategoria(@categoria char(1), @porcentaje decimal)
AS
BEGIN
UPDATE Categoria SET porcentaje = @porcentaje WHERE categoria = @categoria;
END
GO

CREATE PROCEDURE sp_ConsultarCategorias
AS
BEGIN
SELECT * FROM Categoria;
END
GO