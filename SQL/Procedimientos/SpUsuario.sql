

CREATE PROCEDURE AccionesUsuario
    @Opcion VARCHAR(15),
    @IdUsuario INT = NULL,
    @NickName VARCHAR(50),
    @CorreoElectronico VARCHAR(100),
    @Contrasenia VARCHAR(MAX)
AS
BEGIN
    IF @Opcion = 'Consultar'
    BEGIN
        SELECT * FROM Usuaio_Islas WITH(NOLOCK) 
    END
    IF @Opcion = 'Insertar'
    BEGIN
        INSERT INTO Usuario_Islas
            (NickName, FechaRegistro, CorreoElectronico,Contrasenia,Estatus)
        VALUES
            (@NickName, GETDATE(), @CorreoElectronico, @Contrasenia, 1)
    END
    IF @Opcion = 'Actualizar'
    BEGIN
        UPDATE Usuaio_Islas
        SET NickName = @NickName,
        CorreoElectronico = @CorreoElectronico,
        Contrasenia = @Contrasenia,
        Estatus = @Estatus
    END
    IF @Opcion = 'Eliminar'
    BEGIN
        DELETE FROM Usuaio_Islas
        WHERe IdUsuario = @IdUsuario
    END
END