CREATE DATABASE club_deportivo;

USE club_deportivo;

CREATE TABLE Persona (
    id_persona INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50),
    apellido VARCHAR(50),
    dni VARCHAR(20) UNIQUE,
    fecha_nacimiento DATE
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