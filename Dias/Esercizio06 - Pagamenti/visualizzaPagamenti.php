<?php 

$db = new PDO('sqlite:Pagamenti.sqlite3');
// SE NON ESISTE LA TABELLA DI DESTINAZIONE DEI DATI LA CREA
/*$db->query('CREATE TABLE IF NOT EXISTS "condivisioni" (
    "id" INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    "negozio" VARCHAR,
    "utente" VARCHAR,
    "descrizione" VARCHAR,
    "genere" VARCHAR,
    "pezzi" INT,
    "prezzo" INT,	
    "time" DATETIME
)');*/

echo "<h1>Elenco</h1>";
echo "<hr>";
echo "<table>";

$result = $db->query('SELECT * FROM pagamenti');
    foreach($result as $row) {
      echo "<tr><td><input type='button' style='margin: 10px' onclick='sospendi()' value='S'></td>";
      echo "<td><input type='button' style='margin: 10px' onclick='pagato()' value='P'></td>";
      echo "<td>" . $row["cliente"] . "</td>";
      echo "<td>" . $row["importo"] . " €</td>";
      echo "<td>" . $row["intervento"] . "</td>";
      echo "<td><input type='button' style='margin: 10px' onclick='elimina()' value='X'></td>";
      echo "</tr>";
    }

echo "</table>";
echo "</br>";
echo "</br>";
$db = null;  

?>