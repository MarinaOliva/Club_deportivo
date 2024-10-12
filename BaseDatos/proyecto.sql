-- Crear la base de datos y usarla
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

-- Insertar clientes (sólo si no están ya insertados)
INSERT INTO Cliente (nombre, apellido, tipoDoc, numDoc, telefono, email, presentaAptoFisico)
VALUES 
    ('Martín', 'Aliaga', 'DNI', 12345678, 11223344, 'martin.gonzalez@yahoo.com', TRUE),
    ('Lucía', 'López', 'DNI', 87654321, 22334455, 'lucia.lopez@gmail.com', TRUE),
    ('Pedro', 'Fernández', 'DNI', 13579246, 45566778, 'pedro.fernandez@hotmail.com', FALSE),
    ('Sofía', 'Martínez', 'DNI', 24681357, 56677899, 'sofia.martinez@live.com', TRUE),
    ('Javier', 'Andino', 'DNI', 98765432, 67788900, 'javier.perez@outlook.com', FALSE),
    ('Carlos', 'Ramírez', 'DNI', 15975384, 78899001, 'carlos.ramirez@gmail.com', TRUE),  
    ('Ana', 'García', 'DNI', 75315986, 99001122, 'ana.garcia@yahoo.com', TRUE),           
    ('Miguel', 'Torres', 'DNI', 85236914, 90011222, 'miguel.torres@hotmail.com', TRUE);    

-- Tabla para los socios (hereda de Cliente)
CREATE TABLE Socio (
    socioID INT AUTO_INCREMENT PRIMARY KEY,
    clienteID INT,
    FOREIGN KEY (clienteID) REFERENCES Cliente(clienteID)
);

-- Insertar socios (asegúrate de que estos clienteID existan en la tabla Cliente)
INSERT INTO Socio (clienteID)
VALUES 
    (1),  -- Martín Aliaga
    (2),  -- Lucía López
    (4),  -- Sofía Martínez
    (6),  -- Carlos Ramírez
    (7),  -- Ana García
    (8);  -- Miguel Torres

-- Tabla para los no socios (hereda de Cliente)
CREATE TABLE NoSocio (
    noSocioID INT AUTO_INCREMENT PRIMARY KEY,
    clienteID INT,
    FOREIGN KEY (clienteID) REFERENCES Cliente(clienteID)
);

-- Insertar no socios
INSERT INTO NoSocio (clienteID)
VALUES 
    (3),  -- Pedro Fernández
    (5);  -- Javier Andino

-- Tabla para las actividades
CREATE TABLE Actividad (
    idActividad INT AUTO_INCREMENT PRIMARY KEY,
    nombreActividad VARCHAR(255),
    costo DECIMAL(10, 2),
    cuposDisponibles INT
);

INSERT INTO Actividad (nombreActividad, costo, cuposDisponibles)
VALUES 
    ('Musculación y Aparatos', 2000.00, NULL),
    ('Natación', 3000.00, NULL),
    ('Pilates', 2500.00, 25),
    ('Yoga', 2300.00, 25),
    ('Zumba', 2200.00, 25);

-- Tabla para las cuotas
CREATE TABLE Cuota (
    idCuota INT AUTO_INCREMENT PRIMARY KEY,
    socioID INT,
    fechaVencimiento DATE,
    fechaPago DATE,
    importe DECIMAL(10, 2),
    FOREIGN KEY (socioID) REFERENCES Socio(socioID)
);

-- Insertar cuotas para socios que adeudan cuotas
INSERT INTO Cuota (socioID, fechaVencimiento, fechaPago, importe)
VALUES 
    (1, '2024-10-31', '2024-10-31', 23000.00),  -- Martín Aliaga 
    (2, '2024-10-15', '2024-10-14', 23000.00),   -- Lucía López 
    (4, '2024-10-28', NULL, 23000.00),  -- Carlos Ramírez 
    (5, '2024-10-20', NULL, 23000.00),   -- Ana García 
    (6, '2024-10-25', '2024-10-25', 23000.00);  -- Miguel Torres

-- Tabla para los administradores
CREATE TABLE administrador (
    idAdministrador INT AUTO_INCREMENT PRIMARY KEY,
    NombreUsu VARCHAR(20),
    PassUsu VARCHAR(15),
    Activo BOOLEAN 
);

INSERT INTO administrador (NombreUsu, PassUsu, Activo)
VALUES 
    ('Juan_Gomez', 'Juan2024!', TRUE),
    ('Maria_Perez', 'Maria@123', TRUE);

-- Procedimiento para ingreso de login
DELIMITER //

CREATE PROCEDURE IngresoLogin(
    IN usuarioNombre VARCHAR(20),
    IN usuarioContrasena VARCHAR(15)
)
BEGIN
    /* Se selecciona si el usuario está activo */
    SELECT *
    FROM administrador
    WHERE NombreUsu = usuarioNombre
        AND PassUsu = usuarioContrasena
        AND Activo = 1; /* El usuario debe estar activo */
END //

DELIMITER ;
