<!DOCTYPE html>
<html>
    <head> 
        <meta charset="UTF-8">
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"
        integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"
        integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous">
    </script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"
        integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous">
    </script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"
        integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous">
    </script>
    <script src="JS/Script.js"></script>

    <link rel="stylesheet" type="text/css" href="CSS/style.css">
    </head>

     <body>
        <h1 style="margin: 10px">Personal trainer online</h1>

        <div id="wrapper"> </div>
            <div class="contenitore">
                <form action="aggiungi.php" method="GET" ></form>

                    <label for="titolo">Titolo:</label>
                    <input type="text" name="titolo " id="titolo">  <br>
                    <label for="indice">Indice:</label>
                    <input type="number" name="indice" id="indice"><br>
                    <label for="attività">Attività:</label>
                    <input type="text" name="attività " id="attività"><br>
                    <label for="descrizione">Descrizione:</label>
                    <input type="text" name="descrizione" id="descrizione"><br>
                    <label for="ripetizioni">Ripetizioni:</label>
                    <input type="number" name="ripetizioni" id="ripetizioni"><br>
                    <label for="durata">Durata:</label>
                    <input type="number" name="durata" id="durata"><br>
                    <label for="tempoRiposo">Tempo di recupero:</label>
                    <input type="number" name="tempoRiposo" id="tempoRiposo"><br>
                    <label for="media">Tipo di media:</label>
                    <input type="text" name="media" id="media"><br>
                    <label for="file">File:</label>
                    <input type="file" name="file" id="file"><br>
            
                    <input type="button" style="margin: 10px" onclick="visualizzaEsercizi()" value="visualizza esercizi">
                    <input type="button" style="margin: 10px" onclick="aggiungiEsercizio()" value="Aggiungi nuovo esercizio">
                </form>
           
        </div>
        <div id="punto2">
            <select id="sceltatitoli">
                <option value="Principiante">Principiante</option>
                <option value="Intermedio">Intermedio</option>
                <option value="Avanzato">Avanzato</option>
            </select>
            <div id="eserciziDaTitolo"></div>
        </div>
        
    
    </body>
</html>