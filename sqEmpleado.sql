USE HydroLAN;
use Proyecto;

CREATE PROCEDURE sp_ConsultarEmpleados
AS
BEGIN
SELECT * FROM Empleado;
END
GO

CREATE PROCEDURE sp_AgregarEmpleado(@nombreUsuario varchar(100), @id int, @nombre varchar(100), @nacimiento date, @domicilio varchar(100), genero bit, modificacion date)
AS
BEGIN
INSERT INTO Empleado() VALUES();
END
GO