CREATE TABLE [dbo].[TalleresMotivosMoviles]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[TallerMovilId] UNIQUEIDENTIFIER NOT NULL , 
    [MotivoTallerId] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [FK_TallerMovilMotivo_TallerId] FOREIGN KEY (TallerMovilId) REFERENCES TalleresMoviles(Id), 
    CONSTRAINT [FK_TallerMovilMotivo_MotivoTaller] FOREIGN KEY (MotivoTallerId) REFERENCES MotivosTalleres(Id)
)


	

