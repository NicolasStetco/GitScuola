using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Biblioteca
{
    class clsGenere
    {
        private int _codice;
        private string _nome;
        private char _val;
       

        private string sql;
        private adoNetSQL sqlGenere;
        private DataTable tabellaGeneri = new DataTable();



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

        public char validita
        {
            get { return _val; }
            set { _val = value; }
        }

        public clsGenere(string nomeDB)
        {
            string pathDB = Application.StartupPath + "\\" + nomeDB;
            sqlGenere = new adoNetSQL(pathDB);
        }

        public void dispose()
        {
            sqlGenere.Dispose();
        }

        /*
        public int getNuovoCodice()
        {
            int nuovoCodice = -1;
            string risultato = string.Empty;


            sql = "SELECT MAX(CodUtente) AS MAXCODICE " +
                "FROM Utenti";

            try
            {
                risultato = sqlGenere.eseguiScalar(sql, CommandType.Text);
                nuovoCodice = Convert.ToInt32(risultato) + 1;

            }
            catch (Exception e)
            {
                MessageBox.Show("ATTENZIONE: " + e.Message);
            }

            return nuovoCodice;
        }*/

        private void clearDati()
        {
            _nome = string.Empty;
            _val = ' ';
        }

        private bool verifica()
        {
            bool esito = false;

            string risultato = String.Empty;

            /* seleziona dalla tabella inquinanti tutti gli elementi con il nome passato e li conta */
            sql = "SELECT COUNT(*) AS TOTALE " +
                "FROM Generi " +
                "WHERE UPPER(NomeGenere) = '" + _nome.ToUpper() + "' ";

            try
            {
                //risultato contiene il numero di record che soddisfano la condizione indicata
                //in questo caso, il numero di aziende con lo stesso nome
                risultato = sqlGenere.eseguiScalar(sql, CommandType.Text);

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
            tabellaGeneri.Clear();

            sql = "SELECT " +
                  "NomeGenere, ValGenere " +
                  "FROM Generi " +
                  "WHERE CodGenere = '" + _codice + "' ";
            try
            {
                tabellaGeneri = sqlGenere.eseguiQuery(sql, CommandType.Text);
                _nome = tabellaGeneri.Rows[0].ItemArray[0].ToString();
                _val = Convert.ToChar(tabellaGeneri.Rows[0].ItemArray[1]);
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

            tabellaGeneri.Clear();

            if (validita == 'A')
                strValidita = "('', 'A')";

            sql = "SELECT * " +
                "FROM Generi " +
                "WHERE ValGenere IN " + strValidita;
            try
            {
                tabellaGeneri = sqlGenere.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione !!" + e.Message);
            }


            return tabellaGeneri;
        }


        /***********************************************/
        /* Modifica i dati dell'inquinante selezionato */
        /***********************************************/
        public bool modifica()
        {
            bool esito = false;

            // Imposto SQL per modificare l'inquinante
            sql = "UPDATE Inquinanti " +
                  "SET " +
                  "NomeGenere = " + _nome + ", " +
                  "ValGenere = '" + _val + "' " +
                  "WHERE CodGenere = '" + _codice + "' ";
            try
            {
                sqlGenere.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                MessageBox.Show("Genere modificato con successo.");
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
               // _codice = getNuovoCodice();

                /* Inserisci nella tabella con questi campi questi valori */
                sql = "INSERT INTO Generi " +
                        "(CodGenere, NomeGenere, ValGenere) " +
                        "VALUES(" + "'" + _codice + "'," +
                                    " " + _nome + "," +
                                    "'" + _val + "')";
                try
                {
                    sqlGenere.eseguiNonQuery(sql, CommandType.Text);
                    esito = true;
                    MessageBox.Show("Genere inserito con successo.");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Attenzione !!" + e.Message);
                }
            }
            else
            {
                MessageBox.Show("Genere  già presente.");
            }

            return esito;
        }

    }
}
