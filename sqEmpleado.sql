USE HydroLAN;
use Proyecto;

CREATE PROCEDURE sp_ConsultarEmpleados
AS
BEGIN
SELECT * FROM Empleado;
END
GO