DROP DATABASE HydroLAN;

CREATE DATABASE HydroLAN;

USE HydroLAN;
use Proyecto;

CREATE TABLE Zona
( numeroZona INT PRIMARY KEY,
nombre VARCHAR(100) 
);

CREATE TABLE Municipio
( municipio VARCHAR(100) PRIMARY KEY,
numeroZona INT 
);

CREATE TABLE Parametro
( idParametro INT IDENTITY(1,1) PRIMARY KEY,
cuotaFija INT,
rango1 INT,
rango2 INT,
rango3 INT
);

CREATE TABLE Categoria
( categoria CHAR(1) PRIMARY KEY NOT NULL,
porcentaje DECIMAL
);

CREATE TABLE Tipo_Servicio
( tipoServicio VARCHAR(10) PRIMARY KEY NOT NULL,
cuotaDrenaje MONEY
);

CREATE TABLE Usuario
( nombreUsuario VARCHAR(100) PRIMARY KEY, 
contraseña VARCHAR(100) NOT NULL,
empleadoCliente TINYINT NOT NULL,
intentos TINYINT,
estado TINYINT NOT NULL
);

CREATE TABLE Empleado
( idEmpleado INT IDENTITY(1,1) PRIMARY KEY,
nombre VARCHAR(100) NOT NULL,
nacimiento DATE NOT NULL,
genero CHAR(1) NOT NULL,
fechaAltaMod DATE,
numeroCalle INT,
usuario VARCHAR(100) UNIQUE NOT NULL,
FOREIGN KEY (usuario) REFERENCES Usuario(nombreUsuario),
calle INT,
FOREIGN KEY (calle) REFERENCES Calle(claveCalle),
colonia INT,
FOREIGN KEY (colonia) REFERENCES Colonia(claveColonia),
municipio VARCHAR(100),
FOREIGN KEY (municipio) REFERENCES Zona(municipio)
);

CREATE TABLE Cliente_Fisico
( curp CHAR(18) PRIMARY KEY NOT NULL,
nombre VARCHAR(100) NOT NULL,
nacimiento DATE NOT NULL,
genero CHAR(1) NOT NULL,
email VARCHAR(100) NOT NULL,
numeroCalle INT,
usuario VARCHAR(100) UNIQUE NOT NULL,
FOREIGN KEY (usuario) REFERENCES Usuario(nombreUsuario),
calle INT,
FOREIGN KEY (calle) REFERENCES Calle(claveCalle),
colonia INT,
FOREIGN KEY (colonia) REFERENCES Colonia(claveColonia),
municipio VARCHAR(100),
FOREIGN KEY (municipio) REFERENCES Zona(municipio)
);

CREATE TABLE Cliente_Moral
( rfc CHAR(12) PRIMARY KEY NOT NULL,
nombreInstitucion VARCHAR(100) NOT NULL,
fechaConstitucion DATE NOT NULL,
email VARCHAR(100) NOT NULL,
numeroCalle INT,
usuario VARCHAR(100) UNIQUE NOT NULL,
FOREIGN KEY (usuario) REFERENCES Usuario(nombreUsuario),
calle INT,
FOREIGN KEY (calle) REFERENCES Calle(claveCalle),
colonia INT,
FOREIGN KEY (colonia) REFERENCES Colonia(claveColonia),
municipio VARCHAR(100),
FOREIGN KEY (municipio) REFERENCES Zona(municipio)
);

CREATE TABLE Contrato
( numeroServicio INT IDENTITY(1,1) PRIMARY KEY,
estatus VARCHAR(10) NOT NULL,
numeroMedidor INT NOT NULL,
numeroCalle INT,
calle INT,
FOREIGN KEY (calle) REFERENCES Calle(claveCalle),
colonia INT,
FOREIGN KEY (colonia) REFERENCES Colonia(claveColonia),
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

CREATE TABLE Tarifa
( numeroZona INT NOT NULL,
año CHAR(4) NOT NULL,
mes CHAR(2) NOT NULL,
cuotaFija MONEY,
basico MONEY,
intermedio MONEY,
excedente MONEY,
municipio VARCHAR(100),
FOREIGN KEY (municipio) REFERENCES Zona(municipio),
idParametro INT,
FOREIGN KEY (idParametro) REFERENCES Parametro(idParametro),
PRIMARY KEY(numeroZona, año, mes)
);

CREATE TABLE Consumo
( numeroMedidor INT NOT NULL,
año CHAR(4) NOT NULL,
mes CHAR(2) NOT NULL,
lecturaAnterior DECIMAL NOT NULL,
lecturaActual DECIMAL NOT NULL,
numeroZona INT,
añoTarifa CHAR(4),
mesTarifa CHAR(2),
FOREIGN KEY (numeroZona, añoTarifa, mesTarifa) REFERENCES Tarifa(numeroZona, año, mes),
numeroServicio INT,
FOREIGN KEY (numeroServicio) REFERENCES Contrato(numeroServicio),
PRIMARY KEY(numeroMedidor, año, mes)
);

CREATE TABLE Recibo
(folio INT IDENTITY(1,1) PRIMARY KEY,
consumoAgua MONEY,
cuotaDrenaje MONEY,
iva DECIMAL,
totalPagar MONEY, 
añoVencimiento CHAR(4),
mesVencimiento CHAR(2),
diaVencimiento CHAR(2),
adeudoPendiente MONEY,
subtotal1 MONEY,
subtotal2 MONEY,
curp CHAR(18),
FOREIGN KEY (curp) REFERENCES Cliente_Fisico(curp),
rfc CHAR(12),
FOREIGN KEY (rfc) REFERENCES Cliente_Moral(rfc),
idEmpleado INT,
FOREIGN KEY (idEmpleado) REFERENCES Empleado(idEmpleado),
numeroMedidor INT,
año CHAR(4),
mes CHAR(2),
FOREIGN KEY (numeroMedidor, año, mes) REFERENCES Consumo(numeroMedidor, año, mes)
);

CREATE TABLE Gestion_Cliente_Fisico
( claveGestion INT IDENTITY(1,1) PRIMARY KEY,
fechaAccion DATE,
idEmpleado INT,
FOREIGN KEY (idEmpleado) REFERENCES Empleado(idEmpleado),
curp CHAR(18),
FOREIGN KEY (curp) REFERENCES Cliente_Fisico(curp)
);
CREATE TABLE Gestion_Cliente_Moral
( claveGestion INT IDENTITY(1,1) PRIMARY KEY,
fechaAccion DATE,
idEmpleado INT,
FOREIGN KEY (idEmpleado) REFERENCES Empleado(idEmpleado),
rfc CHAR(12),
FOREIGN KEY (rfc) REFERENCES Cliente_Moral(rfc)
);
CREATE TABLE Gestion_Categoria
( claveGestion INT IDENTITY(1,1) PRIMARY KEY,
fechaAccion DATE,
idEmpleado INT,
FOREIGN KEY (idEmpleado) REFERENCES Empleado(idEmpleado),
categoria CHAR(1),
FOREIGN KEY (categoria) REFERENCES Categoria(categoria)
);
CREATE TABLE Gestion_Zona
( claveGestion INT IDENTITY(1,1) PRIMARY KEY,
fechaAccion DATE,
idEmpleado INT,
FOREIGN KEY (idEmpleado) REFERENCES Empleado(idEmpleado),
municipio VARCHAR(100),
FOREIGN KEY (municipio) REFERENCES Zona(municipio)
);
CREATE TABLE Gestion_Tipo_Servicio
( claveGestion INT IDENTITY(1,1) PRIMARY KEY,
fechaAccion DATE,
idEmpleado INT,
FOREIGN KEY (idEmpleado) REFERENCES Empleado(idEmpleado),
tipoServicio VARCHAR(10),
FOREIGN KEY (tipoServicio) REFERENCES Tipo_Servicio(tipoServicio)
);
CREATE TABLE Gestion_Contrato
( claveGestion INT IDENTITY(1,1) PRIMARY KEY,
fechaAccion DATE,
idEmpleado INT,
FOREIGN KEY (idEmpleado) REFERENCES Empleado(idEmpleado),
numeroServicio INT,
FOREIGN KEY (numeroServicio) REFERENCES Contrato(numeroServicio)
);
CREATE TABLE Gestion_Parametro
( claveGestion INT IDENTITY(1,1) PRIMARY KEY,
fechaAccion DATE,
idEmpleado INT,
FOREIGN KEY (idEmpleado) REFERENCES Empleado(idEmpleado),
idParametro INT,
FOREIGN KEY (idParametro) REFERENCES Parametro(idParametro)
);
CREATE TABLE Gestion_Tarifa
( claveGestion INT IDENTITY(1,1) PRIMARY KEY,
fechaAccion DATE,
idEmpleado INT,
FOREIGN KEY (idEmpleado) REFERENCES Empleado(idEmpleado),
numeroZona INT,
año CHAR(4),
mes CHAR(2),
FOREIGN KEY (numeroZona, año, mes) REFERENCES Tarifa(numeroZona, año, mes)
);
CREATE TABLE Gestion_Consumo
( claveGestion INT IDENTITY(1,1) PRIMARY KEY,
fechaAccion DATE,
idEmpleado INT,
FOREIGN KEY (idEmpleado) REFERENCES Empleado(idEmpleado),
numeroMedidor INT,
año CHAR(4),
mes CHAR(2),
FOREIGN KEY (numeroMedidor, año, mes) REFERENCES Consumo(numeroMedidor, año, mes)
);
