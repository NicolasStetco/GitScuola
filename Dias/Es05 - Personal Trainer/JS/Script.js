$(document).ready(function(){
    //console.log("gino");
    visualizzaEsercizi();

    $("#eserciziDaTitolo").hide();
    $("#btnAnnulla").hide();
  
    $("#sceltatitoli").change(function(){

      if(this.value!=" "){  

        $("#btnInizia").val("Inizia allenamento "+this.value );

        var xhttp = new XMLHttpRequest();
        xhttp.onreadystatechange = function() {
          if (this.readyState == 4 && this.status == 200) {
              document.getElementById("tabella").innerHTML = this.responseText;
          }
      };

      var dati="?titolo='"+this.value+"'";
      xhttp.open("GET", "visualizzaEserciziDaTitolo.php"+dati, true);
      $("#eserciziDaTitolo").show();
      xhttp.send();

      }else
        $("#eserciziDaTitolo").hide();   
    });


    $("#btnInizia").click(function(){
      //alert("gino");
      $("#maschera1").hide();
      $("#btnInizia").prop('disabled', true);
      
      $("label").hide();
      $("#btnAnnulla").show();

      iniziaAllenamento($("#sceltatitoli").val());
      $("#sceltatitoli").hide();
    });


    $("#btnAnnulla").click(function(){
      alert();
      $(this).hide();
      $("#maschera1").show();
      $("#sceltatitoli").show();
      $("label").show();
      $("#btnInizia").prop('disabled', false);
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