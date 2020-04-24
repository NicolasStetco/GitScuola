$(document).ready(function(){
    //console.log("gino");

  });

  function visualizzaPagamenti() {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
      if (this.readyState == 4 && this.status == 200) {
       document.getElementById("elenco").innerHTML = this.responseText;
      }
    };
    xhttp.open("GET", "visualizzaPagamenti.php", true);
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

  function aggiungiPagamenti(){
    //alert(document.getElementById("titolo").value);
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
    if (this.readyState == 4 && this.status == 200) {
        document.getElementById("elenco").innerHTML += "Esercizio aggiunto con successo";
      }
    };
    var dati =  "?cliente='"+document.getElementById("cliente").value+"'&indirizzo='"+document.getElementById("indirizzo").value+"'&data='"
    +document.getElementById("data").value+"'&intervento='"+document.getElementById("intervento").value+"'&descrizione='"+document.getElementById("descrizione").value+"'&importo='"
    +document.getElementById("importo").value+"'";
    xhttp.open("GET", "aggiungi.php"+dati, true);
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