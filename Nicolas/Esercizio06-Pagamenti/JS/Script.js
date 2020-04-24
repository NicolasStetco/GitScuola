$(document).ready(function(){
    //console.log("gino");

  });

  function visualizzaPagamenti() {
    var httpE = new XMLHttpRequest();
    httpE.onreadystatechange = function() {
      if (this.readyState == 4 && this.status == 200) {
       document.getElementById("elenco").innerHTML = this.responseText;
      }
    };

    var dati="?stato=e";
    httpE.open("GET", "visualizzaPagamenti.php"+dati, true);
   
    httpE.send();

    var httpS = new XMLHttpRequest();

    httpS.onreadystatechange = function() {
      if (this.readyState == 4 && this.status == 200) {
       document.getElementById("sospesi").innerHTML = this.responseText;
      }
    };

    dati="?stato=s";
    httpS.open("GET", "visualizzaPagamenti.php"+dati, true);
   
    httpS.send();


    var httpP = new XMLHttpRequest();

    httpP.onreadystatechange = function() {
      if (this.readyState == 4 && this.status == 200) {
       document.getElementById("pagati").innerHTML = this.responseText;
      }
    };

    dati="?stato=p";
    httpP.open("GET", "visualizzaPagamenti.php"+dati, true);
   
    httpP.send();
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

  function elimina(id){
    var httpE = new XMLHttpRequest();
    httpE.onreadystatechange = function() {
      if (this.readyState == 4 && this.status == 200) {
        console.log("eliminato");
        document.getElementById("prova").innerHTML = this.responseText;

      }
    };

    var dati="?stato=a&id="+id;
    httpE.open("GET", "aggiorna.php"+dati, true);
   
    httpE.send();

    visualizzaPagamenti();
  }

  function sospendi(id){
    //alert(id);
    
    var httpE = new XMLHttpRequest();
    httpE.onreadystatechange = function() {
      if (this.readyState == 4 && this.status == 200) {
        console.log("sospeso");
        document.getElementById("prova").innerHTML = this.responseText;

      }
    };

    var dati="?stato=s&id="+id;
    httpE.open("GET", "aggiorna.php"+dati, true);
   
    httpE.send();

    visualizzaPagamenti();
  }

  function pagato(id){
    //alert(id);
    
    var httpE = new XMLHttpRequest();
    httpE.onreadystatechange = function() {
      if (this.readyState == 4 && this.status == 200) {
       console.log("Pagato");
       document.getElementById("prova").innerHTML = this.responseText;
      }
    };

    var dati="?stato=p&id="+id;
    httpE.open("GET", "aggiorna.php"+dati, true);
   
    httpE.send();

    visualizzaPagamenti();
  }