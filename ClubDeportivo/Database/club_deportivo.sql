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
    cuota_hasta DATE DEFAULT NULL,
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

CREATE TABLE PagoActividad (
    id_persona INT,
    id_actividad INT,
    monto FLOAT,
    medio_pago VARCHAR(20),
    fecha_pago_actividad DATE,
    FOREIGN KEY (id_persona) REFERENCES Persona(id_persona),
    FOREIGN KEY (id_actividad) REFERENCES Actividad(id_actividad)
);


INSERT INTO Persona (id_persona, nombre, apellido, dni, fecha_nacimiento)
VALUES (1, 'Juan', 'Pérez', '12345678', '1980-01-15');
INSERT INTO Administrador (id_persona, nombre_usuario, contrasena) 
VALUES (1, 'admin', '1234');


