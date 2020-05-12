	-- *******************
	-- * Pulizia TABELLE *
	-- *******************

	DELETE FROM [dbo].[Scarichi];
	DELETE FROM [dbo].[Aziende];
	DELETE FROM [dbo].[Inquinanti];
	DELETE FROM [dbo].[Prodotti];

	GO

	-- **********************************
	-- * Inserisce Dati Tabella AZIENDE *
	-- ********************************** 

	INSERT INTO [dbo].[Aziende] ([CodAzienda], [NomeAzienda], [GradoAzienda], [CittaAzienda], [ValAzienda]) VALUES('A1', 'Colle & Vernici', 20, 'Torino', '');
	INSERT INTO [dbo].[Aziende] ([CodAzienda], [NomeAzienda], [GradoAzienda], [CittaAzienda], [ValAzienda]) VALUES('A2', 'Factotum SpA', 10, 'Milano', '');
	INSERT INTO [dbo].[Aziende] ([CodAzienda], [NomeAzienda], [GradoAzienda], [CittaAzienda], [ValAzienda]) VALUES('A3', 'SuperClean Inc.', 30, 'Milano', '');
	INSERT INTO [dbo].[Aziende] ([CodAzienda], [NomeAzienda], [GradoAzienda], [CittaAzienda], [ValAzienda]) VALUES('A4', 'Elektron Srl.', 20, 'Torino', '');
	INSERT INTO [dbo].[Aziende] ([CodAzienda], [NomeAzienda], [GradoAzienda], [CittaAzienda], [ValAzienda]) VALUES('A5', 'Acme Ltd.', 30, 'Bologna', '');

	GO

	-- *************************************
	-- * Inserisce Dati Tabella INQUINANTI *
	-- ************************************* 

	INSERT INTO [dbo].[Inquinanti] ([CodInquinante], [NomeInquinante], [StatoInquinante], [PesSpecInquinante], [CittaInquinante], [ValInquinante]) VALUES('I1', 'Anidride solforosa', 'G', 12, 'Torino', ''); 
	INSERT INTO [dbo].[Inquinanti] ([CodInquinante], [NomeInquinante], [StatoInquinante], [PesSpecInquinante], [CittaInquinante], [ValInquinante]) VALUES('I2', 'Diossina', 'G', 17, 'Milano', ''); 
	INSERT INTO [dbo].[Inquinanti] ([CodInquinante], [NomeInquinante], [StatoInquinante], [PesSpecInquinante], [CittaInquinante], [ValInquinante]) VALUES('I3', 'Ammoniaca', 'L', 17, 'Venezia', ''); 
	INSERT INTO [dbo].[Inquinanti] ([CodInquinante], [NomeInquinante], [StatoInquinante], [PesSpecInquinante], [CittaInquinante], [ValInquinante]) VALUES('I4', 'Biossido di azoto', 'S', 14, 'Torino', ''); 
	INSERT INTO [dbo].[Inquinanti] ([CodInquinante], [NomeInquinante], [StatoInquinante], [PesSpecInquinante], [CittaInquinante], [ValInquinante]) VALUES('I5', 'Mercurio', 'S', 12, 'Milano', ''); 
	INSERT INTO [dbo].[Inquinanti] ([CodInquinante], [NomeInquinante], [StatoInquinante], [PesSpecInquinante], [CittaInquinante], [ValInquinante]) VALUES('I6', 'Acido cloridrico', 'G', 19, 'Torino', ''); 

	GO

	-- ***********************************
	-- * Inserisce Dati Tabella PRODOTTI *
	-- *********************************** 

	INSERT INTO [dbo].[Prodotti] ([CodProdotto], [NomeProdotto], [CittaProdotto], [ValProdotto]) VALUES('P1', 'Detersivo', 'Milano', '');
	INSERT INTO [dbo].[Prodotti] ([CodProdotto], [NomeProdotto], [CittaProdotto], [ValProdotto]) VALUES('P2', 'Vernice', 'Venezia', '');
	INSERT INTO [dbo].[Prodotti] ([CodProdotto], [NomeProdotto], [CittaProdotto], [ValProdotto]) VALUES('P3', 'Batteria', 'Bologna', '');
	INSERT INTO [dbo].[Prodotti] ([CodProdotto], [NomeProdotto], [CittaProdotto], [ValProdotto]) VALUES('P4', 'Detergente', 'Bologna', '');
	INSERT INTO [dbo].[Prodotti] ([CodProdotto], [NomeProdotto], [CittaProdotto], [ValProdotto]) VALUES('P5', 'Collante	', 'Torino', '');
	INSERT INTO [dbo].[Prodotti] ([CodProdotto], [NomeProdotto], [CittaProdotto], [ValProdotto]) VALUES('P6', 'Nastro magnetico', 'Firenze', '');
	INSERT INTO [dbo].[Prodotti] ([CodProdotto], [NomeProdotto], [CittaProdotto], [ValProdotto]) VALUES('P7', 'Trasformatore', 'Torino', '');

	GO

	-- ***********************************
	-- * Inserisce Dati Tabella SCARICHI *
	-- *********************************** 

	-- Caricamento CORRETTO ma con Progressivo incrementato ognivolta 
	-- INSERT INTO [dbo].[Scarichi] ([CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES('A1', 'I1', 'P1', 200, '');
	-- INSERT INTO [dbo].[Scarichi] ([CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES('A1', 'I1', 'P4', 700, '');
	-- INSERT INTO [dbo].[Scarichi] ([CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES('A2', 'I3', 'P1', 400, '');
	-- INSERT INTO [dbo].[Scarichi] ([CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES('A2', 'I3', 'P2', 200, '');
	-- INSERT INTO [dbo].[Scarichi] ([CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES('A2', 'I3', 'P3', 200, '');
	-- INSERT INTO [dbo].[Scarichi] ([CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES('A2', 'I3', 'P4', 500, '');
	-- INSERT INTO [dbo].[Scarichi] ([CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES('A2', 'I3', 'P5', 600, '');
	-- INSERT INTO [dbo].[Scarichi] ([CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES('A2', 'I3', 'P6', 400, '');
	-- INSERT INTO [dbo].[Scarichi] ([CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES('A2', 'I3', 'P7', 800, '');
	-- INSERT INTO [dbo].[Scarichi] ([CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES('A2', 'I5', 'P2', 100, '');
	-- INSERT INTO [dbo].[Scarichi] ([CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES('A3', 'I3', 'P1', 200, '');
	-- INSERT INTO [dbo].[Scarichi] ([CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES('A3', 'I4', 'P2', 500, '');
	-- INSERT INTO [dbo].[Scarichi] ([CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES('A4', 'I6', 'P3', 300, '');
	-- INSERT INTO [dbo].[Scarichi] ([CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES('A4', 'I6', 'P7', 300, '');
	-- INSERT INTO [dbo].[Scarichi] ([CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES('A5', 'I2', 'P2', 200, '');
	-- INSERT INTO [dbo].[Scarichi] ([CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES('A5', 'I2', 'P4', 100, '');
	-- INSERT INTO [dbo].[Scarichi] ([CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES('A5', 'I5', 'P5', 500, '');
	-- INSERT INTO [dbo].[Scarichi] ([CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES('A5', 'I5', 'P7', 100, '');
	-- INSERT INTO [dbo].[Scarichi] ([CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES('A5', 'I6', 'P2', 200, '');
	-- INSERT INTO [dbo].[Scarichi] ([CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES('A5', 'I1', 'P4', 100, '');
	-- INSERT INTO [dbo].[Scarichi] ([CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES('A5', 'I3', 'P4', 200, '');
	-- INSERT INTO [dbo].[Scarichi] ([CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES('A5', 'I4', 'P4', 800, '');
	-- INSERT INTO [dbo].[Scarichi] ([CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES('A5', 'I5', 'P4', 400, '');
	-- INSERT INTO [dbo].[Scarichi] ([CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES('A5', 'I6', 'P4', 500, '');

	-- Pre-Caricamento con Progressivo SEMPRE a partire da 1

	SET IDENTITY_INSERT [dbo].[Scarichi] ON;
	GO

	INSERT INTO [dbo].[Scarichi] ([CodScarico], [CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES(1, 'A1', 'I1', 'P1', 200, '');
	INSERT INTO [dbo].[Scarichi] ([CodScarico], [CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES(2, 'A1', 'I1', 'P4', 700, '');
	INSERT INTO [dbo].[Scarichi] ([CodScarico], [CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES(3, 'A2', 'I3', 'P1', 400, '');
	INSERT INTO [dbo].[Scarichi] ([CodScarico], [CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES(4, 'A2', 'I3', 'P2', 200, '');
	INSERT INTO [dbo].[Scarichi] ([CodScarico], [CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES(5, 'A2', 'I3', 'P3', 200, '');
	INSERT INTO [dbo].[Scarichi] ([CodScarico], [CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES(6, 'A2', 'I3', 'P4', 500, '');
	INSERT INTO [dbo].[Scarichi] ([CodScarico], [CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES(7, 'A2', 'I3', 'P5', 600, '');
	INSERT INTO [dbo].[Scarichi] ([CodScarico], [CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES(8, 'A2', 'I3', 'P6', 400, '');
	INSERT INTO [dbo].[Scarichi] ([CodScarico], [CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES(9, 'A2', 'I3', 'P7', 800, '');
	INSERT INTO [dbo].[Scarichi] ([CodScarico], [CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES(10, 'A2', 'I5', 'P2', 100, '');
	INSERT INTO [dbo].[Scarichi] ([CodScarico], [CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES(11, 'A3', 'I3', 'P1', 200, '');
	INSERT INTO [dbo].[Scarichi] ([CodScarico], [CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES(12, 'A3', 'I4', 'P2', 500, '');
	INSERT INTO [dbo].[Scarichi] ([CodScarico], [CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES(13, 'A4', 'I6', 'P3', 300, '');
	INSERT INTO [dbo].[Scarichi] ([CodScarico], [CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES(14, 'A4', 'I6', 'P7', 300, '');
	INSERT INTO [dbo].[Scarichi] ([CodScarico], [CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES(15, 'A5', 'I2', 'P2', 200, '');
	INSERT INTO [dbo].[Scarichi] ([CodScarico], [CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES(16, 'A5', 'I2', 'P4', 100, '');
	INSERT INTO [dbo].[Scarichi] ([CodScarico], [CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES(17, 'A5', 'I5', 'P5', 500, '');
	INSERT INTO [dbo].[Scarichi] ([CodScarico], [CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES(18, 'A5', 'I5', 'P7', 100, '');
	INSERT INTO [dbo].[Scarichi] ([CodScarico], [CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES(19, 'A5', 'I6', 'P2', 200, '');
	INSERT INTO [dbo].[Scarichi] ([CodScarico], [CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES(20, 'A5', 'I1', 'P4', 100, '');
	INSERT INTO [dbo].[Scarichi] ([CodScarico], [CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES(21, 'A5', 'I3', 'P4', 200, '');
	INSERT INTO [dbo].[Scarichi] ([CodScarico], [CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES(22, 'A5', 'I4', 'P4', 800, '');
	INSERT INTO [dbo].[Scarichi] ([CodScarico], [CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES(23, 'A5', 'I5', 'P4', 400, '');
	INSERT INTO [dbo].[Scarichi] ([CodScarico], [CodAziScarico], [CodInqScarico], [CodProScarico], [QtaScarico], [ValScarico]) VALUES(24, 'A5', 'I6', 'P4', 500, '');

	GO

	SET IDENTITY_INSERT [dbo].[Scarichi] OFF;
	GO