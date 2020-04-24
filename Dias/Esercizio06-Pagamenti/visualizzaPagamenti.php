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


$stato=$_GET["stato"];

//echo $stato;

if($stato=='e'){
echo "<h1 style='text-align:center'>Elenco</h1>";
echo "<hr>";
echo "<table>";
$result = $db->query('SELECT * FROM pagamenti');
    foreach($result as $row) {
      if($row["stato"]=='e'){
        echo "<tr><td><input type='button' style='margin: 10px'  onclick='sospendi(" . $row["id"] . ")'  value='S'></td>";
        echo "<td><input type='button' style='margin: 10px' onclick='pagato(" . $row["id"] . ")' value='P'></td>";
        echo "<td>" . $row["cliente"] . "</td>";
        echo "<td>" . $row["importo"] . " €</td>";
        echo "<td>" . $row["intervento"] . "</td>";
        echo "<td><input type='button' style='margin: 10px' onclick='elimina(" . $row["id"] . ")' value='X'></td>";
        echo "</tr>";
      } 
    }

echo "</table>";
echo "</br>";
echo "</br>";
$db = null;  
}else if($stato=='p'){
  echo "<h1 style='text-align:center'>Pagati</h1>";
echo "<hr>";
echo "<table>";
$result = $db->query('SELECT * FROM pagamenti  ');
    foreach($result as $row) {
      if($row["stato"]=='p'){

        echo "<td>" . $row["cliente"] . "</td>";
        echo "<td>" . $row["importo"] . " €</td>";
        echo "<td>" . $row["intervento"] . "</td>";
        
        echo "</tr>";
      } 
    }

echo "</table>";
echo "</br>";
echo "</br>";
$db = null;  
}else if($stato=='s'){
  echo "<h1 style='text-align:center'>Sospesi</h1>";
echo "<hr>";
echo "<table>";
$result = $db->query('SELECT * FROM pagamenti  ');
    foreach($result as $row) {
      if($row["stato"]=='s'){

        echo "<td>" . $row["cliente"] . "</td>";
        echo "<td>" . $row["importo"] . " €</td>";
        echo "<td>" . $row["intervento"] . "</td>";
        
        echo "</tr>";
      } 
    }

echo "</table>";
echo "</br>";
echo "</br>";
$db = null;  
}

?>