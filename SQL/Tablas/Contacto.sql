
CREATE TABLE Contacto_Islas
(
    IdContacto INT PRIMARY KEY IDENTITY(1,1),
    FechaRegistro DATETIME,
    NumTelefono VARCHAR(10),
    IdUsuario INT FOREIGN KEY (IdUsuario) REFERENCES Usuario_Islas (IdUsuario)
);