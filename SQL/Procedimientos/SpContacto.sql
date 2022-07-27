

CREATE PROCEDURE AccionesContacto
    @Opcion VARCHAR(15),
    @IdContacto INT = NULL,
    @NumTelefono VARCHAR(10),
    @IdUsuario INT
AS
BEGIN
    IF @Opcion = 'Consultar'
    BEGIN
        SELECT * FROM Contacto_Islas WITH(NOLOCK) 
    END
    IF @Opcion = 'Insertar'
    BEGIN
        INSERT INTO Contacto_Islas
            (FechaRegistro, NumTelefono, IdUsuario)
        VALUES
            (GETDATE(), @NumTelefono, @IdUsuario)
    END
    IF @Opcion = 'Actualizar'
    BEGIN
        UPDATE Contacto_Islas
        SET NumTelefono = @NumTelefono,
        IdUsuario = @IdUsuario
    END
    IF @Opcion = 'Eliminar'
    BEGIN
        DELETE FROM Contacto_Islas
        WHERE IdContacto = @IdContacto
    END
END