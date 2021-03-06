USE [Toka]
GO
/****** Object:  StoredProcedure [dbo].[sp_LeerPersonaFisica]    Script Date: 30/05/2021 01:30:54 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Juan Miguel Espino>
-- Create date: <30/05/2021>
-- Description:	<Pricedimiento almacenado para la consulta de los registros>
-- =============================================
ALTER PROCEDURE [dbo].[sp_LeerPersonaFisica] 
AS
BEGIN
    DECLARE @ERROR VARCHAR(500);	   
    BEGIN TRY
       
        BEGIN
            SELECT * FROM dbo.Tb_PersonasFisicas WHERE Activo = 1;
        END;
        
    END TRY
    BEGIN CATCH
        PRINT ERROR_MESSAGE();
        SELECT ERROR_NUMBER() * -1 AS ERROR,
               ISNULL(@ERROR, 'Error.') AS MENSAJEERROR;
    END CATCH;
END
