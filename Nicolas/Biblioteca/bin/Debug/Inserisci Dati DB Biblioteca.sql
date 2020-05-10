	-- *******************
	-- * Pulizia TABELLE *
	-- *******************

	DELETE FROM [dbo].[Utenti];
	DELETE FROM [dbo].[Prestiti];
	DELETE FROM [dbo].[Lettori];
	DELETE FROM [dbo].[Libri];
	DELETE FROM [dbo].[Generi];

	GO

	-- *********************************
	-- * Inserisce Dati Tabella UTENTI *
	-- ********************************* 
	
	SET IDENTITY_INSERT [dbo].[Utenti] ON;
	GO

	INSERT INTO [dbo].[Utenti] ([CodUtente], [NominativoUtente], [TipoUtente], [UserIDUtente], [PwdUtente], [ValUtente]) VALUES(1, 'Admin Sistema', 'ADM', 'admin', 'sistema', '');
	INSERT INTO [dbo].[Utenti] ([CodUtente], [NominativoUtente], [TipoUtente], [UserIDUtente], [PwdUtente], [ValUtente]) VALUES(2, 'Operatore Biblioteca', 'OPE', 'operatore', 'biblioteca', '');

	GO
	
	SET IDENTITY_INSERT [dbo].[Utenti] OFF;
	GO
	
	-- **********************************
	-- * Inserisce Dati Tabella LETTORI *
	-- ********************************** 
	
	SET IDENTITY_INSERT [dbo].[Lettori] ON;
	GO
	
	INSERT INTO [dbo].[Lettori] ([CodLettore], [CognomeLettore], [NomeLettore], [MailLettore], [NTesseraLettore], [ValLettore]) VALUES(1, 'Esempio', 'Utente', 'esempio.utente@mail.it', 'NT2020_0005', '');
	INSERT INTO [dbo].[Lettori] ([CodLettore], [CognomeLettore], [NomeLettore], [MailLettore], [NTesseraLettore], [ValLettore]) VALUES(2, 'Prova', 'Utente', 'prova.utente@mail.it', 'NT2020_0015', '');
	INSERT INTO [dbo].[Lettori] ([CodLettore], [CognomeLettore], [NomeLettore], [MailLettore], [NTesseraLettore], [ValLettore]) VALUES(3, 'Rossi', 'Mario', 'rossi.mario@mail.it', 'NT2020_0078', '');

	GO
	
	SET IDENTITY_INSERT [dbo].[Lettori] OFF;
	GO
	
	-- *********************************
	-- * Inserisce Dati Tabella GENERI *
	-- ********************************* 
	
	SET IDENTITY_INSERT [dbo].[Generi] ON;
	GO
	
	INSERT INTO [dbo].[Generi] ([CodGenere], [NomeGenere], [ValGenere]) VALUES(1, 'AVVENTURA E AZIONE', ''); 
	INSERT INTO [dbo].[Generi] ([CodGenere], [NomeGenere], [ValGenere]) VALUES(2, 'FANTASY', ''); 
	INSERT INTO [dbo].[Generi] ([CodGenere], [NomeGenere], [ValGenere]) VALUES(3, 'HORROR', ''); 
	INSERT INTO [dbo].[Generi] ([CodGenere], [NomeGenere], [ValGenere]) VALUES(4, 'ROMANZO ROSA', ''); 
	INSERT INTO [dbo].[Generi] ([CodGenere], [NomeGenere], [ValGenere]) VALUES(5, 'ROMANZO STORICO', ''); 
	INSERT INTO [dbo].[Generi] ([CodGenere], [NomeGenere], [ValGenere]) VALUES(6, 'THRILLER', ''); 

	GO
	
	SET IDENTITY_INSERT [dbo].[Generi] OFF;
	GO
	
	-- ********************************
	-- * Inserisce Dati Tabella LIBRI *
	-- ******************************** 
	
	SET IDENTITY_INSERT [dbo].[Libri] ON;
	GO
	
	INSERT INTO [dbo].[Libri] ([CodLibro], [TitoloLibro], [AutoreLibro], [CodGenereLibro], [CodISBNLibro], [ImgLibro], [AnnoPubLibro], [InPrestitoLibro], [ValLibro]) VALUES(1, 'Il destino del faraone', 'Clive Cussler', 1,  '9788830454354', '9788830454354.jpg', 2020, '', '');
	INSERT INTO [dbo].[Libri] ([CodLibro], [TitoloLibro], [AutoreLibro], [CodGenereLibro], [CodISBNLibro], [ImgLibro], [AnnoPubLibro], [InPrestitoLibro], [ValLibro]) VALUES(2, 'Il fuoco della vendetta', 'Wilbur Smith', 1,  '9788869055454', '9788869055454.jpg', 2020, '', '');
	INSERT INTO [dbo].[Libri] ([CodLibro], [TitoloLibro], [AutoreLibro], [CodGenereLibro], [CodISBNLibro], [ImgLibro], [AnnoPubLibro], [InPrestitoLibro], [ValLibro]) VALUES(3, 'La nona casa', 'Leigh Bardugo', 2,  '9788804721871', '9788804721871.jpg', 2020, '', '');
	INSERT INTO [dbo].[Libri] ([CodLibro], [TitoloLibro], [AutoreLibro], [CodGenereLibro], [CodISBNLibro], [ImgLibro], [AnnoPubLibro], [InPrestitoLibro], [ValLibro]) VALUES(4, 'Loki. Il giovane dio dell''inganno', 'Mackenzi Lee', 2,  '9788804720225', '9788804720225.jpg', 2020, '', '');
	INSERT INTO [dbo].[Libri] ([CodLibro], [TitoloLibro], [AutoreLibro], [CodGenereLibro], [CodISBNLibro], [ImgLibro], [AnnoPubLibro], [InPrestitoLibro], [ValLibro]) VALUES(5, 'Se scorre il sangue', 'Stephen King', 6,  '9788820069131', '9788820069131.jpg', 2020, '', '');

	GO
	
	SET IDENTITY_INSERT [dbo].[Libri] OFF;
	GO

	-- ***********************************
	-- * Inserisce Dati Tabella SCARICHI *
	-- *********************************** 

	SET IDENTITY_INSERT [dbo].[Prestiti] ON;
	GO

	INSERT INTO [dbo].[Prestiti] ([CodPrestito], [CodLettorePrestito], [CodLibroPrestito], [DataPrestito], [DataResPrestito], [ValPrestito]) VALUES(1, 1, 2, CONVERT(date, '26-01-2020', 105), CONVERT(date, '21-02-2020', 105), '');
	INSERT INTO [dbo].[Prestiti] ([CodPrestito], [CodLettorePrestito], [CodLibroPrestito], [DataPrestito], [DataResPrestito], [ValPrestito]) VALUES(2, 2, 4, CONVERT(date, '12-02-2020', 105), CONVERT(date, '04-03-2020', 105), '');
	INSERT INTO [dbo].[Prestiti] ([CodPrestito], [CodLettorePrestito], [CodLibroPrestito], [DataPrestito], [DataResPrestito], [ValPrestito]) VALUES(3, 3, 3, CONVERT(date, '02-03-2020', 105), CONVERT(date, '27-03-2020', 105), '');
	INSERT INTO [dbo].[Prestiti] ([CodPrestito], [CodLettorePrestito], [CodLibroPrestito], [DataPrestito], [DataResPrestito], [ValPrestito]) VALUES(4, 1, 1, CONVERT(date, '09-04-2020', 105), NULL, '');
	INSERT INTO [dbo].[Prestiti] ([CodPrestito], [CodLettorePrestito], [CodLibroPrestito], [DataPrestito], [DataResPrestito], [ValPrestito]) VALUES(5, 2, 2, CONVERT(date, '22-04-2020', 105), NULL, '');
	INSERT INTO [dbo].[Prestiti] ([CodPrestito], [CodLettorePrestito], [CodLibroPrestito], [DataPrestito], [DataResPrestito], [ValPrestito]) VALUES(6, 1, 3, CONVERT(date, '26-04-2020', 105), NULL, '');
	INSERT INTO [dbo].[Prestiti] ([CodPrestito], [CodLettorePrestito], [CodLibroPrestito], [DataPrestito], [DataResPrestito], [ValPrestito]) VALUES(7, 3, 4, CONVERT(date, '11-04-2020', 105), NULL, '');
	INSERT INTO [dbo].[Prestiti] ([CodPrestito], [CodLettorePrestito], [CodLibroPrestito], [DataPrestito], [DataResPrestito], [ValPrestito]) VALUES(8, 3, 5, CONVERT(date, '06-04-2020', 105), NULL, '');

	GO

	SET IDENTITY_INSERT [dbo].[Prestiti] OFF;
	GO
	
	--- Per il CONVERT vedi https://docs.microsoft.com/en-us/sql/t-sql/functions/cast-and-convert-transact-sql?redirectedfrom=MSDN&view=sql-server-ver15