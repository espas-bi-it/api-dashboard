CREATE TABLE [dbo].[collaborator]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL,
    [TeamRole] NVARCHAR(50) NOT NULL
)