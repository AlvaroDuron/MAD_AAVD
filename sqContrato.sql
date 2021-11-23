USE HydroLAN;
USE Proyecto;

CREATE TABLE Contrato
( numeroServicio INT IDENTITY(1,1) PRIMARY KEY,
numeroMedidor INT NOT NULL,
estatus VARCHAR(10) NOT NULL,
numeroCalle INT,
creacion DATE NOT NULL,
fechaAltaMod DATETIME,
calle VARCHAR(100),
colonia VARCHAR(100),
municipio VARCHAR(100),
FOREIGN KEY (municipio) REFERENCES Zona(municipio),
tipoServicio VARCHAR(10) NOT NULL,
FOREIGN KEY (tipoServicio) REFERENCES Tipo_Servicio(tipoServicio),
categoria CHAR(1) NOT NULL,
FOREIGN KEY (categoria) REFERENCES Categoria(categoria),
curp CHAR(18),
FOREIGN KEY (curp) REFERENCES Cliente_Fisico(curp),
rfc CHAR(12),
FOREIGN KEY (rfc) REFERENCES Cliente_Moral(rfc),
);