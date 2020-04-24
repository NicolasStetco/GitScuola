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

    <style>
    </style>
    </head>

     <body>
     <h1 style="margin: 10px">Pagamenti</h1>
        <div id="maschera1">
                <div class="contenitore">
                    <form action="aggiungi.php" method="GET" ></form>
                        <!--<input type="text" name="titolo " id="titolo">  --><br>
                        <label for="cliente">Cliente:</label>
                        <input type="text" name="cliente" id="cliente"><br>
                        <label for="indirizzo">Indirizzo:</label>
                        <input type="text" name="indirizzo " id="indirizzo"><br>
                        <label for="data">Data:</label>
                        <input type="text" name="data" id="data"><br>
                        <label for="intervento">Intervento:</label>
                        <select id="intervento">
                        <option value="riparazione">Riparazione</option>
                        <option value="installazione">Installazione</option>
                        <option value="rimozione">Rimozione</option>
                        </select><br>
                        <label for="id">Id:</label>
                        <input type="text" name="id" id="id" readonly><br>                       
                        <label for="descrizione">Descrizione:</label>
                        <input type="text" name="descrizione" id="descrizione"><br>
                        <label for="importo">Importo:</label>
                        <input type="text" name="importo" id="importo"><br>
                        
                
                        <!--<input type="button" style="margin: 10px" onclick="visualizzaPagamenti()" value="Visualizza Pagamenti">-->
                        <input type="button" style="margin: 10px" onclick="aggiungiPagamenti()" value="Aggiungi nuovo Pagamento">
                    </form>  
            </div>
            <div id="elenco"> </div>
            <div id="sospesi"> </div>
            <div id="pagati"> </div>
            <div id="prova"></div>
        </div>
    </body>
</html>