
CREATE TABLE Usuario_Islas
(
    IdUsuario INT PRIMARY KEY IDENTITY(1,1),
    NickName VARCHAR(50),
    FechaRegistro DATETIME,
    CorreoElectronico VARCHAR(100),
    Contrasenia VARCHAR(MAX),
    Estatus BIT DEFAULT(1)
);