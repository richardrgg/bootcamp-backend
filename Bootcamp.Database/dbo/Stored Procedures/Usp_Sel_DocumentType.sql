CREATE PROCEDURE [dbo].[Usp_Sel_DocumentType]
AS
BEGIN

	SELECT
		Id,
		Name,
		Shortname
	FROM [dbo].[DocumentType]

END