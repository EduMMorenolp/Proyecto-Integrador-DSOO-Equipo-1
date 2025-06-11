CREATE DATABASE club_deportivo;

USE club_deportivo;

CREATE TABLE Persona (
    id_persona INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50),
    apellido VARCHAR(50),
    dni VARCHAR(20) UNIQUE,
    fecha_nacimiento DATE
);

CREATE TABLE Administrador (
    id_admin INT AUTO_INCREMENT PRIMARY KEY,
    id_persona INT NOT NULL,
    nombre_usuario VARCHAR(50) UNIQUE NOT NULL,
    contrasena VARCHAR(255) NOT NULL,
    fecha_registro DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (id_persona) REFERENCES Persona(id_persona)
);

CREATE TABLE Socio (
    id_socio INT AUTO_INCREMENT PRIMARY KEY,
    id_persona INT,
    fecha_alta DATE,
    cuota_hasta DATE,
    tiene_carnet BOOLEAN,
    ficha_medica BOOLEAN,
    FOREIGN KEY (id_persona) REFERENCES Persona(id_persona)
);

CREATE TABLE NoSocio (
    id_no_socio INT AUTO_INCREMENT PRIMARY KEY,
    id_persona INT NOT NULL,
    FOREIGN KEY (id_persona) REFERENCES Persona(id_persona)
);

CREATE TABLE Cuota (
    id_cuota INT AUTO_INCREMENT PRIMARY KEY,
    id_socio INT,
    monto FLOAT,
    fecha_pago DATE,
    fecha_vence DATE,
    medio_pago VARCHAR(20),
    promocion INT,
    FOREIGN KEY (id_socio) REFERENCES Socio(id_socio)
);

CREATE TABLE Actividad (
    id_actividad INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50),
    tipo VARCHAR(30),
    profesor VARCHAR(50),
    horario VARCHAR(20),
    capacidad INT,
    costo_actividad DECIMAL(10,2)
);

CREATE TABLE NoSocio_Actividad (
    id_no_socio INT,
    id_actividad INT,
    PRIMARY KEY (id_no_socio, id_actividad),
    FOREIGN KEY (id_no_socio) REFERENCES NoSocio(id_no_socio),
    FOREIGN KEY (id_actividad) REFERENCES Actividad(id_actividad)
);

-- Personas
INSERT INTO Persona (nombre, apellido, dni, fecha_nacimiento) VALUES
('María', 'González', '23456789', '1990-05-20'),
('Carlos', 'López', '34567890', '1985-08-12'),
('Ana', 'Martínez', '45678901', '1995-03-25'),
('Lucas', 'Díaz', '56789012', '2000-11-10'),
('Pedro', 'Ramírez', '56789123', '1992-07-14'),
('Lucía', 'Fernández', '67891234', '1998-10-03');

-- Administradores
INSERT INTO Administrador (id_persona, nombre_usuario, contrasena) 
VALUES (1, 'admin', '1234');
INSERT INTO Administrador (id_persona, nombre_usuario, contrasena) VALUES
(2, 'maria_admin', 'passMaria123');

-- Socios
INSERT INTO Socio (id_persona, fecha_alta, cuota_hasta, tiene_carnet, ficha_medica) VALUES
(3, '2023-01-01', '2024-01-01', TRUE, TRUE),
(4, '2023-03-15', NULL, FALSE, TRUE);

-- NoSocios
INSERT INTO NoSocio (id_persona) VALUES (4),(5),(6);

-- Cuotas
INSERT INTO Cuota (id_socio, monto, fecha_pago, fecha_vence, medio_pago, promocion) VALUES
(1, 250.00, '2024-01-01', '2024-01-31', 'Efectivo', 0),
(1, 250.00, '2024-02-01', '2024-02-29', 'Tarjeta', 0),
(2, 250.00, '2024-01-15', '2024-02-15', 'Transferencia', 1);

-- Actividades
INSERT INTO Actividad (nombre, tipo, profesor, horario, capacidad, costo_actividad) VALUES
('Yoga', 'Bienestar', 'Laura Torres', 'Lun 09:00 - 10:00', 15, 50.00),
('Fútbol', 'Deporte Colectivo', 'Diego Marín', 'Mie 18:00 - 20:00', 22, 30.00),
('Natación', 'Aquático', 'Carmen Ruiz', 'Jue 17:00 - 18:00', 10, 60.00),
('Zumba', 'Bienestar', 'Silvia Pérez', 'Vie 19:00 - 20:00', 20, 45.00),
('CrossFit', 'Entrenamiento', 'Hernán Salinas', 'Lun 18:00 - 19:30', 12, 55.00),
('Caminata Recreativa', 'Bienestar', 'Sofía Moreno', 'Dom 08:00 - 09:00', 30, 0.00);

-- Actividad No Socios
INSERT INTO NoSocio_Actividad (id_no_socio, id_actividad) VALUES
(2, 5),
(3, 6);nosocio_actividad
