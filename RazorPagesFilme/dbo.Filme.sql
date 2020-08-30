CREATE TABLE [dbo].[Filme]
(
	[ID]          INT     IDENTITY(1,1) NOT NULL,
	[Genero]      NVARCHAR(MAX) NULL,
	[Preco]		  DECIMAL(18, 2) NOT NULL,
	[DataLancamento] DATETIME2(7) NOT NULL,
	[Titulo] NVARCHAR(MAX) NULL,
	[Avaliacao] NVARCHAR(MAX) NULL,

)
