CREATE TABLE IF NOT EXISTS Dischi (
	IdDisco INT NOT NULL AUTO_INCREMENT,
	InterpreteDisco VARCHAR(50) NOT NULL,
	TitoloDisco VARCHAR(100) NOT NULL,
	PrezzoDisco DOUBLE NOT NULL,
	AnnoDisco INT NOT NULL,
	ValDisco CHAR NOT NULL,
	PRIMARY KEY (IdDisco)
);

ALTER TABLE Dischi AUTO_INCREMENT = 0;

INSERT INTO Dischi (
	InterpreteDisco, 
	TitoloDisco, 
	PrezzoDisco, 
	AnnoDisco, 
	ValDisco)
VALUES
	( 'Vasco Rossi', 
	  'Albachiara', 
	  '11.3', 
	  '1985', 
	  ' '
	),
	( 'Zucchero', 
	  'Blues', 
	  '12.3', 
	  '1988', ' '
	);