<!doctype html>
<html lang="it">
	<head>
		<title> Esercizio 5 - PHP - DB DISCHI </title>
		<!-- per HTML4 -->
		<!-- <meta http-equiv="Content-Type" content="text/html;charset=ISO-8859-1"> -->
		<!-- per HTML5 -->
		<meta charset="UTF-8">

		<!-- Fogli stile utilizzati -->
		<link rel="stylesheet" type="text/css" href="CSS/stile.css" />
		<link rel="stylesheet" type="text/css" href="jQuery/jquery-ui.structure-1.12.1.css" />
		<link rel="stylesheet" type="text/css" href="jQuery/jquery-ui.theme-1.12.1.css" />
		<link rel="stylesheet" type="text/css" href="jQuery/jquery-ui-1.12.1.css" />
	

		<!-- JavaScript esterni al Progetto -->
		<script type="text/javascript" src="jQuery/jQuery3.4.1.js" ></script>
		<script type="text/javascript" src="jQuery/jquery-ui-1.12.1.js" ></script>

		<!-- JavaScript interni al Progetto -->
		<script type="text/javascript" src="JS/script.js"></script>
	</head>
	<body>
		<h1 align="center">Elenco DISCHI</h1>
		<?php
			/* l'oggetto myspl restituisce una connessione al DB indicato*/
			$con=new mysqli("localhost","root","","ese05_dischi");
			/* controlla se il codice di errore è diverso da 0*/
			if($con->connect_errno)
				die("Errore Connessione DataBase [". $con->connect_errno . "] : " . $con->connect_error);
			
			/*Imposto SQL di Selezione Dati*/
			$sql="select * from Dischi where ValDIsco = '' ";

			/* Il metodo query esegue la query sql e restituisce il Recordset corrispondente*/
			$rs=$con->query($sql);

			//Controllo Errore
			if(!$rs)
				die("Errore nella query [". $con->errno . "] " . $con->error);

			echo("<form>");
			echo("<table>");

			/* Ciclo di scansione del Recordset */
			while($record=$rs->fetch_assoc())
			{
				echo("<tr>");

				// ID Disco
				$id=$record["IdDisco"];
				echo("<td>$id</td>");

				//Interprete Disco
				$interprete=$record["InterpreteDisco"];
				echo("<td><input type='text' name='txtInterprete$id' value='$interprete'></td>");

				// Titolo Disco
				$titolo=$record["TitoloDisco"];
				echo("<td><input type='text' name='txtTitolo$id' value='$titolo'></td>");

				// Prezzo Disco
				$prezzo=$record["PrezzoDisco"];
				echo("<td><input type='text' name='txtPrezzo$id' value='$prezzo'></td>");

				// Anno Disco
				$anno=$record["AnnoDisco"];
				echo("<td><input type='text' name='txtAnno" . $id . "' value='$anno'></td>");

				/* Salva e Cancella */
				echo("<td><input type='submit' formmethod='post' formaction='PHP/aggiorna.php?codice=$id' value='Salva'></td>");
				echo("<td><input type='submit' formmethod='post' formaction='PHP/cancella.php?codice=$id' value='Cancella'></td>");

				echo("</tr>");
			}

			echo("</table>");

			echo("<br><br>");
			echo("<input type='button' value='Inserisci' onclick='window.location.href=\"PHP/inserisci.php\"'>");

			echo("</form>");
			
			//Chiudo la connessione al DB
			$con->close();
		?>
	</body>
</html>
