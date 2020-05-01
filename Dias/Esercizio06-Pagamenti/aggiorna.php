<?php

$db = new PDO('sqlite:Pagamenti.sqlite3');

$id=$_GET["id"];
$stato=$_GET["stato"];

//echo $id;
//echo $stato;


/*

 $sql= "update dischi set
                        InterpreteDisco='$interprete',
                        TitoloDisco='$titolo',
                        PrezzoDisco='$prezzo',
                        AnnoDisco='$anno
                        where IdDisco=$id";

*/

$sql= "UPDATE pagamenti set
                        stato='$stato'
                        WHERE id=$id";


$db->exec('BEGIN');
$db->query($sql);
$db->exec('COMMIT');

?>