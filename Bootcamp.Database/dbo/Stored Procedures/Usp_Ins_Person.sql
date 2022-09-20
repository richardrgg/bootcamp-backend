CREATE PROCEDURE [dbo].[Usp_Ins_Person]
@Name VARCHAR(50),
@Lastname VARCHAR(50),
@DocumentTypeId INT,
@DocumentNumber VARCHAR(50)
AS
BEGIN

	INSERT INTO [dbo].[Person]
	(Name, Lastname, DocumentTypeId, DocumentNumber)
	VALUES
	(@Name, @Lastname, @DocumentTypeId, @DocumentNumber)

END