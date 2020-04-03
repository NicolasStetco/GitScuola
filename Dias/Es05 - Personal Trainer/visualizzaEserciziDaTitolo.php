<?php
$db = new PDO('sqlite:ginnastica.sqlite3');
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

$titolo = $_GET['titolo'];

echo "</br>";

//echo $titolo;
echo "<table>";
echo "<tr class='header'><td>ID esercizi</td>";
echo "<td>Titolo esercizio</td>";
echo "<td>Indice</td>";
echo "<td>Attività</td>";
echo "<td>Descrizione</td>";
echo "<td>Ripetizioni</td>";
echo "<td>Durata</td>";
echo "<td>Tempo di riposo</td>";
echo "<td>Tipo media</td>";
echo "<td>File</td>";
echo "</tr>";

for ($mul = 1; $mul <= 20; $mul++){
$result = $db->query('SELECT * FROM esercizi');
    foreach($result as $row) {
        if($titolo=="'".$row["titolo"]."'"){
            if($mul==$row["indice"]){
                echo "<tr><td>" . $row['ID'] . "</td>";
                echo "<td>" . $row["titolo"] . "</td>";
                echo "<td>" . $row["indice"] . "</td>";
                echo "<td>" . $row["attività"] . "</td>";
                echo "<td>" . $row["descrizione"] . "</td>";
                echo "<td>" . $row["ripetizioni"] . "</td>";
                echo "<td>" . $row["durata"] . "</td>";
                echo "<td>" . $row["tempoRiposo"] . "</td>";
                echo "<td>" . $row["media"] . "</td>";
                echo "<td>" . $row["file"] . "</td>";
                echo "</tr>";
            }
        }
    }
}

echo "</table>";
echo "</br>";
echo "</br>";

//echo '<input type="button" value="Inizia allenamento ' . $titolo . '" id="btnInizia">';
$db = null;  

?>