<?php 
$db = new PDO('sqlite:Ginnastica.sqlite3');
// SE NON ESISTE LA TABELLA DI DESTINAZIONE DEI DATI LA CREA

// QUERY DI INSET NUOVO RECORD
/*$titolo = $_GET['genere'];
$desTmp = "'" . $_GET['descrizione'] . "'";
$pezziTmp = $_GET['pezzi'];
$prezzoTmp = $_GET['prezzo'];
$db->exec('BEGIN');
$db->query('INSERT INTO "condivisioni" ("negozio", "utente","descrizione","genere","pezzi","prezzo", "time")
    VALUES ("Neg", "Ut",  $desTmp  ,  $titolo  ,$pezziTmp,$prezzoTmp, "2017-01-14 10:11:23")');
$db->exec('COMMIT');	
echo $titolo . " aggiunto nuovo elemento<br>";*/

/*
<label for="titolo">Titolo:</label>
            <input type="text" name="titolo " id="titolo">  <br>
            <input type="text" name="indice" id="indice"><br>
            <input type="text" name="attività " id="attività"><br>
            <input type="text" name="descrizione" id="descrizione"><br>
            <input type="text" name="ripetizioni" id="ripetizioni"><br>
            <input type="text" name="durata" id="durata"><br>
            <input type="text" name="tempoRiposo" id="tempoRiposo"><br>
            <input type="text" name="media" id="media"><br>
            <input type="text" name="file" id="file"><br>
*/

echo "ABBATEEE";

//QUERY DI INSET NUOVO RECORD
$titolo = $_GET['titolo'];
$descrizione =  $_GET['descrizione'] ;
$indice = $_GET['indice'];
$attività = $_GET['attività'];
$ripetizioni = $_GET['ripetizioni'];
$durata =  $_GET['durata'] ;
$tempoRiposo = $_GET['tempoRiposo'];
$media = $_GET['media'];
$file = $_GET['file'];



$QueryTmp = "INSERT INTO Esercizi
('titolo','indice','attività','descrizione','ripetizioni','durata','tempoRiposo','media','file')";
$QueryTmp = $QueryTmp  .  " VALUES (" .  $titolo . " , " .  $indice . "  , " . $attività . " , " . $descrizione . " ,
" .  $ripetizioni . " , " .  $durata . "  , " . $tempoRiposo . " , " . $media . " , " . $file . ")";
$db->exec('BEGIN');
$db->query($QueryTmp);
$db->exec('COMMIT');
//echo $QueryTmp . " aggiunto nuovo elemento<br>"

?>