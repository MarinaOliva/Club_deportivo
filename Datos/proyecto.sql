CREATE DATABASE Proyecto;
USE Proyecto;

-- Tabla para los clientes
CREATE TABLE Cliente (
    clienteID INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    tipoDoc VARCHAR(20),
    numDoc INT,
    telefono INT,
    email VARCHAR(100),
    presentaAptoFisico BOOLEAN
);

-- Tabla para los socios (hereda de Cliente)
CREATE TABLE Socio (
    socioID INT AUTO_INCREMENT PRIMARY KEY,
    clienteID INT,
    adeudaCuota BOOLEAN,
    tieneCarnet BOOLEAN,
    FOREIGN KEY (clienteID) REFERENCES Cliente(clienteID)
);

-- Tabla para los no socios (hereda de Cliente)
CREATE TABLE NoSocio (
    noSocioID INT AUTO_INCREMENT PRIMARY KEY,
    clienteID INT,
    FOREIGN KEY (clienteID) REFERENCES Cliente(clienteID)
);

-- Tabla para las actividades
CREATE TABLE Actividad (
    idActividad INT AUTO_INCREMENT PRIMARY KEY,
    costo DECIMAL(10, 2),
    horario TIME,
    cuposDisponibles INT
);

-- Tabla para las cuotas
CREATE TABLE Cuota (
    idCuota INT AUTO_INCREMENT PRIMARY KEY,
    socioID INT,
    fechaVencimiento DATE,
    importe DECIMAL(10, 2),
    formaPago VARCHAR(50),
    FOREIGN KEY (socioID) REFERENCES Socio(socioID)
);

DELIMITER //

CREATE PROCEDURE IngresoLogin(
    IN usuarioNombre VARCHAR(20),
    IN usuarioContrasena VARCHAR(15)
)
BEGIN
    /* Se selecciona el rol del usuario */
    SELECT r.NomRol 
    FROM usuario u
    INNER JOIN roles r ON u.RolUsu = r.RolUsu
    WHERE u.NombreUsu = usuarioNombre
        AND u.PassUsu = usuarioContrasena
        AND u.Activo = 1; /* El usuario debe estar activo */
END //

DELIMITER ;

SHOW PROCEDURE STATUS WHERE Db = 'proyecto';
