/* Creazione Tabella UTENTI */
CREATE TABLE [dbo].[Utenti]
(
	[CodUtente] INT IDENTITY (1, 1) NOT NULL,
	[NominativoUtente] NVARCHAR(80) NOT NULL,
	[TipoUtente] NVARCHAR(3) NOT NULL,
	[UserIDUtente] NVARCHAR(30) NOT NULL,
	[PwdUtente] NVARCHAR(20) NOT NULL,
	[ValUtente] CHAR NOT NULL,
	PRIMARY KEY CLUSTERED ([CodUtente] ASC)
);

/* Creazione Tabella LETTORI */
CREATE TABLE [dbo].[Lettori]
(
	[CodLettore] INT IDENTITY (1, 1) NOT NULL,
	[CognomeLettore] NVARCHAR(50) NOT NULL,
	[NomeLettore] NVARCHAR(50) NOT NULL,
	[MailLettore] NVARCHAR(80) NOT NULL,
	[NTesseraLettore] NVARCHAR(20) NOT NULL,
	[ValLettore] CHAR NOT NULL,
	PRIMARY KEY CLUSTERED ([CodLettore] ASC)
);

/* Creazione Indici LETTORI */
CREATE NONCLUSTERED INDEX [Indice_Lettori_NTessera] 
    ON [dbo].[Lettori]([NTesseraLettore] ASC);
CREATE NONCLUSTERED INDEX [Indice_Lettori_CognNome] 
    ON [dbo].[Lettori]([CognomeLettore], [NomeLettore] ASC);


/* Creazione Tabella GENERI */
CREATE TABLE [dbo].[Generi]
(
	[CodGenere] INT IDENTITY (1, 1) NOT NULL,
	[NomeGenere] NVARCHAR(50) NOT NULL,
	[ValGenere] CHAR NOT NULL,
	PRIMARY KEY CLUSTERED ([CodGenere] ASC)
);

/* Creazione Indici GENERI */
CREATE NONCLUSTERED INDEX [Indice_Generi_Nome] 
    ON [dbo].[Generi]([NomeGenere] ASC);


/* Creazione Tabella LIBRI */
CREATE TABLE [dbo].[Libri]
(
	[CodLibro] INT IDENTITY (1, 1) NOT NULL,
	[TitoloLibro] NVARCHAR(50) NOT NULL,
	[AutoreLibro] NVARCHAR(50) NOT NULL,
	[CodGenereLibro] INT NOT NULL,
	[CodISBNLibro] NVARCHAR(20) NOT NULL,
	[ImgLibro] NVARCHAR(50) NOT NULL,
	[AnnoPubLibro] INT NOT NULL,
	[InPrestitoLibro] CHAR NOT NULL,
	[ValLibro] CHAR NOT NULL,
	PRIMARY KEY CLUSTERED ([CodLibro] ASC),
	CONSTRAINT [FK_Libri_Generi] FOREIGN KEY ([CodGenereLibro]) REFERENCES [dbo].[Generi]([CodGenere]) 
);

/* Creazione Indici LIBRI */
CREATE NONCLUSTERED INDEX [Indice_Libri_Autore] 
    ON [dbo].[Libri]([AutoreLibro] ASC);
CREATE NONCLUSTERED INDEX [Indice_Libri_CodISBN] 
    ON [dbo].[Libri]([CodISBNLibro] ASC);
CREATE NONCLUSTERED INDEX [Indice_Libri_Anno] 
    ON [dbo].[Libri]([AnnoPubLibro] ASC);

/* Creazione Tabella PRESTITI */
CREATE TABLE [dbo].[Prestiti]
(
	[CodPrestito] INT IDENTITY (1, 1) NOT NULL,
	[CodLettorePrestito] INT NOT NULL,
	[CodLibroPrestito] INT NOT NULL,
	[DataPrestito] DATE NOT NULL,
	[DataResPrestito] DATE NULL,
	[ValPrestito] CHAR NOT NULL,
	PRIMARY KEY CLUSTERED ([CodPrestito] ASC),
	CONSTRAINT [FK_Prestiti_Lettori] FOREIGN KEY ([CodLettorePrestito]) REFERENCES [dbo].[Lettori]([CodLettore]),
	CONSTRAINT [FK_Prestiti_Libri] FOREIGN KEY ([CodLibroPrestito]) REFERENCES [dbo].[Libri]([CodLibro])
);

/* Creazione Indici PRESTITI */
CREATE NONCLUSTERED INDEX [Indice_Prestiti_DataPrestitoASC]
	ON [dbo].[Prestiti]([DataPrestito] ASC);
CREATE NONCLUSTERED INDEX [Indice_Prestiti_DataPrestitoDESC]
	ON [dbo].[Prestiti]([DataPrestito] DESC);



