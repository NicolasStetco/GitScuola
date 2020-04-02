$(document).ready(function(){
    //alert("gino");
    visualizzaEsercizi();

    $("#sceltatitoli").change(function(){
      alert(this.value);
      var xhttp = new XMLHttpRequest();
      xhttp.onreadystatechange = function() {
      if (this.readyState == 4 && this.status == 200) {
          document.getElementById("eserciziDaTitolo").innerHTML = this.responseText;
      }
      };
      var dati="?titolo='"+this.value+"'";
      xhttp.open("GET", "visualizzaEserciziDaTitolo.php"+dati, true);
      xhttp.send();

    });


  });

  function visualizzaEsercizi() {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
      if (this.readyState == 4 && this.status == 200) {
       document.getElementById("wrapper").innerHTML = this.responseText;
      }
    };
    xhttp.open("GET", "visualizzaElenco.php", true);
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