<!doctype html>
<html lang="it">
	<head>
		<title> Esercizio 5 - PHP - DB DISCHI </title>
		<meta charset="UTF-8">
	</head>
	<body>
       <?php
            //Recupero ID Disco - GET
            $id= $_GET["codice"];

            //Recupero i Campi del Disco - POST
            $interprete= $_POST["txtInterprete$id"];
            $titolo= $_POST["txtTitolo$id"];
            $prezzo= $_POST["txtPrezzo$id"];
            $anno= $_POST["txtAnno$id"];

            $con = new mysqli("localhost","root","","ese05_dischi");
            if($con->connect_errno)
                die("Errore Connessione DataBase [" . $con->connect_errno . "] : " . $con->connect_error);
            
            $sql= "update dischi set
                        InterpreteDisco='$interprete',
                        TitoloDisco='$titolo',
                        PrezzoDisco='$prezzo',
                        AnnoDisco='$anno
                        where IdDisco=$id";
            $rs=$con->query($sql);
            if(!$rs)
                die("Errore nella query [" . $con->errno . "] : " . $con->error);
            else{
                $con->close();
                //echo("Record aggiornato")
                header("location:C:4A\Maggiore\Esercizio05_DB_Dischi");
            }
            
       ?>
    </body>
</html>