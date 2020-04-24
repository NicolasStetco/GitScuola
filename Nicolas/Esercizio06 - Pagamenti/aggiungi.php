<?php 
$db = new PDO('sqlite:Pagamenti.sqlite3');
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
            <input type="text" name="data" id="data"><br>
            <input type="text" name="intervento " id="intervento"><br>
            <input type="text" name="descrizione" id="descrizione"><br>
            <input type="text" name="descrizione" id="descrizione"><br>
            <input type="text" name="importo" id="importo"><br>
            <input type="text" name="tempoRiposo" id="tempoRiposo"><br>
            <input type="text" name="media" id="media"><br>
            <input type="text" name="file" id="file"><br>
*/

echo "ABBATEEE";

//QUERY DI INSET NUOVO RECORD
$cliente = $_GET['cliente'];
$indirizzo =  $_GET['indirizzo'] ;
$data = $_GET['data'];
$intervento = $_GET['intervento'];
$descrizione = $_GET['descrizione'];
$importo =  $_GET['importo'] ;


$QueryTmp = "INSERT INTO pagamenti
('cliente','indirizzo','data','intervento','descrizione','importo','stato')";
$QueryTmp = $QueryTmp  .  " VALUES (" .  $cliente . " , " .  $indirizzo . "  , " . $data . " , " . $intervento . " ,
" .  $descrizione . " , " .  $importo .",'e')";
$db->exec('BEGIN');
$db->query($QueryTmp);
$db->exec('COMMIT');
//echo $QueryTmp . " aggiunto nuovo elemento<br>"

?>