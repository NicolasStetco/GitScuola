using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Biblioteca
{
    class clsLettore
    {
        private int _codice;
        private string _cognome;
        private string _nome;
        private string _mail;
        private char _val;
        private string _nTessera;

        private string sql;
        private adoNetSQL sqlLettore;
        private DataTable tabellaLettori = new DataTable();



        public int codice
        {
            get { return _codice; }
            set { _codice = value; }
        }

        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        public string nTessera
        {
            get { return _nTessera; }
            set { _nTessera = value; }
        }

        public string cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }

        public char validita
        {
            get { return _val; }
            set { _val = value; }
        }

        public clsLettore(string nomeDB)
        {
            string pathDB = Application.StartupPath + "\\" + nomeDB;
            sqlLettore = new adoNetSQL(pathDB);
        }

        public void dispose()
        {
            sqlLettore.Dispose();
        }

        
        public string nuovaTessera()
        {
            string nuovoCodice = string.Empty;
            string risultato = string.Empty;
            string valoreNumerico = string.Empty;


            sql = "SELECT MAX(CodLettore) AS MAXCODICE " +
                "FROM Lettori";

            try
            {
                risultato = sqlLettore.eseguiScalar(sql, CommandType.Text);
                valoreNumerico = risultato.Substring(1);
                nuovoCodice = "NT2020_" + (Convert.ToInt32(valoreNumerico) + 1);

            }
            catch (Exception e)
            {
                MessageBox.Show("ATTENZIONE: " + e.Message);
            }

            return nuovoCodice;
        }

        private void clearDati()
        {
            _nome = string.Empty;
            _mail = string.Empty;
            _cognome = string.Empty;
            _nTessera = string.Empty;
            _val = ' ';
        }

        
       public int getNuovoCodice()
       {
           int nuovoCodice = -1;
           string risultato = string.Empty;


           sql = "SELECT MAX(CodLettore) AS MAXCODICE " +
               "FROM Lettori";

           try
           {
               risultato = sqlLettore.eseguiScalar(sql, CommandType.Text);
               nuovoCodice = Convert.ToInt32(risultato) + 1;

           }
           catch (Exception e)
           {
               MessageBox.Show("ATTENZIONE: " + e.Message);
           }

           return nuovoCodice;
       }

        private bool verifica()
        {
            bool esito = false;

            string risultato = String.Empty;

            /* seleziona dalla tabella inquinanti tutti gli elementi con il nome passato e li conta */
            sql = "SELECT COUNT(*) AS TOTALE " +
                "FROM Lettori " +
                "WHERE UPPER(NTesseraLettore) = '" + _nTessera.ToUpper() + "' ";

            try
            {
                //risultato contiene il numero di record che soddisfano la condizione indicata
                //in questo caso, il numero di aziende con lo stesso nome
                risultato = sqlLettore.eseguiScalar(sql, CommandType.Text);

                //se risultato vale 0, non ci altre aziende con quel nome
                if (Convert.ToInt32(risultato) == 0)
                {
                    esito = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ATTENZIONE: " + e.Message);
            }

            //se la funziona restituisce falso, esiste già un inquinante con quel nome
            return esito;
        }

        
        /***************************/
        /* Recupera singola Entità */
        /***************************/
        public void getDati()
        {
            int I;

            clearDati();
            tabellaLettori.Clear();

            sql = "SELECT " +
                  "NomeLettore, CognomeLettore,MailLettore, NTesseraLettore, ValLettore " +
                  "FROM Lettori " +
                  "WHERE CodLettore = '" + _codice + "' ";
            try
            {
                tabellaLettori = sqlLettore.eseguiQuery(sql, CommandType.Text);
                _nome = tabellaLettori.Rows[0].ItemArray[0].ToString();
                _cognome = tabellaLettori.Rows[0].ItemArray[1].ToString();
                _mail = tabellaLettori.Rows[0].ItemArray[2].ToString();
                _nTessera = tabellaLettori.Rows[0].ItemArray[3].ToString();
                _val = Convert.ToChar(tabellaLettori.Rows[0].ItemArray[4]);
            }
            catch (Exception e)
            {
                _codice = -1;
                MessageBox.Show("Attenzione !!" + e.Message);
            }
        }

        /**************************/
        /* Genera Lista Inquinanti*/
        /*************************/
        public DataTable lista(char validita)
        {
            string strValidita = "('')";

            tabellaLettori.Clear();

            if (validita == 'A')
                strValidita = "('', 'A')";

            sql = "SELECT * " +
                "FROM Lettori " +
                "WHERE ValLettore IN " + strValidita;
            try
            {
                tabellaLettori = sqlLettore.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione !!" + e.Message);
            }


            return tabellaLettori;
        }


        /***********************************************/
        /* Modifica i dati dell'inquinante selezionato */
        /***********************************************/
        public bool modifica()
        {
            bool esito = false;

            // Imposto SQL per modificare l'inquinante
            sql = "UPDATE Lettori " +
                  "SET " +
                  "NomeLettore = '" + _nome + "', " +
                  "CognomeLettore = '" + _cognome + "', " +
                  "NTesseraLettore = '" + _nTessera + "', " +
                  "MailLettore = '" + _mail + "', " +
                  "ValLettore = '" + _val + "' " +
                  "WHERE CodLettore = '" + _codice + "' ";
            try
            {
                sqlLettore.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                MessageBox.Show("Lettore modificato con successo.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione !!" + e.Message);
            }

            return esito;
        }

        /********************************/
        /* Inserimento NUOVO inquinante */
        /********************************/
        public bool aggiungi()
        {
            bool esito = false;

            // Verifico che l'Azienda da inserire non sia già presente
            if (verifica())
            {
                // Recupero il nuovo codice Azienda
                //_codice = nuovaTessera();

                /* Inserisci nella tabella con questi campi questi valori */
                sql = "INSERT INTO Lettori " +
                        "( NomeLettore, CognomeLettore,NTesseraLettore, MailLettore ,ValLettore) " +
                        "VALUES(" + "'" + _nome + "'," +
                                     "'" + _cognome + "'," +
                                      "'" + _nTessera + "'," +
                                     "'" + _mail + "'," +
                                    "'" + _val + "')";
                try
                {
                    sqlLettore.eseguiNonQuery(sql, CommandType.Text);
                    esito = true;
                    MessageBox.Show("Lettore inserito con successo.");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Attenzione tqhisa ropt!!" + e.Message);
                }
            }
            else
            {
                MessageBox.Show("Lettore  già presente.");
            }

            return esito;
        }

    }
}
