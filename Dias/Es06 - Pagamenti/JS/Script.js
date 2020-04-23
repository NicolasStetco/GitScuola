$(document).ready(function(){
    //console.log("gino");

  });

  function visualizzaEsercizi() {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
      if (this.readyState == 4 && this.status == 200) {
       document.getElementById("wrapper").innerHTML = this.responseText;
      }
    };
    xhttp.open("GET", "visualizzaElenco.php", true);
    /*
      QUESTA GESTIONE DELLA COMUNICAZIONE CON IL SERVER RISPETTA UN MODELLO
      TRADIZIONALE CHE COME EFFETTO CI RICARICA COMPLETAMENTE 
      LA PAGINA.
      UTILIZZANDO AJAX INVECE POSSIAMO TRASFERIRE LA RISPOSTA DEL SERVER PHP
      IN UN DIV PRESENTE SULLA PAGINA IMPOSTA SEMPLICEMENTE IL SUO HTML SENZA
      RICARICARE LA PAGINA

    */
    xhttp.send();
  } 

  function aggiungiEsercizio(){
    //alert(document.getElementById("titolo").value);
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
    if (this.readyState == 4 && this.status == 200) {
        document.getElementById("wrapper").innerHTML += "Esercizio aggiunto con successo";
      }
    };
    var dati =  "?titolo='"+document.getElementById("titolo").value+"'&indice='"+document.getElementById("indice").value+"'&attività='"
    +document.getElementById("attività").value+"'&descrizione='"+document.getElementById("descrizione").value+"'&ripetizioni='"
    +document.getElementById("ripetizioni").value+"'&durata='"+document.getElementById("durata").value+"'&tempoRiposo='"
    +document.getElementById("tempoRiposo").value+"'&media='"+document.getElementById("media").value+"'&file='"+document.getElementById("file").value+"'";
    xhttp.open("GET", "aggiungi.php"+dati, true);
    //visualizzaEsercizi();
    xhttp.send();

    
  }

  function iniziaAllenamento(titolo){
    //alert(titolo);
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
    if (this.readyState == 4 && this.status == 200) {
        document.getElementById("maschera2").innerHTML += this.responseText;
      }
    };
    var dati =  "?titolo='"+titolo+"'";
    xhttp.open("GET", "iniziaAllenamento.php"+dati, true);
    //visualizzaEsercizi();
    xhttp.send();
  }