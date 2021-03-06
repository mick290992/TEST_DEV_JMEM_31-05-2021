USE [Toka]
GO
/****** Object:  StoredProcedure [dbo].[sp_ByIDPersonaFisica]    Script Date: 30/05/2021 01:30:15 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Juan Miguel Espino>
-- Create date: <30/05/2021>
-- Description:	<Pricedimiento almacenado para la consulta de los registros>
-- =============================================
ALTER PROCEDURE [dbo].[sp_ByIDPersonaFisica] 
	-- Add the parameters for the stored procedure here
	(@ID INT) 
AS
BEGIN
    DECLARE @ERROR VARCHAR(500);	   
    BEGIN TRY
	    
			SELECT *
            FROM dbo.Tb_PersonasFisicas
            WHERE IdPersonaFisica = @ID
			AND Activo = 1

    END TRY
    BEGIN CATCH
        PRINT ERROR_MESSAGE();
        SELECT ERROR_NUMBER() * -1 AS ERROR,
               ISNULL(@ERROR, 'Error en la consulta.') AS MENSAJEERROR;
    END CATCH;
END
