using System;
using System.Data;
using System.Windows.Forms;

namespace Biblioteca
{
    class clsUtente
    {
        private int _codice;
        private string _tipo;
        private string _nominativo;
        private string _password;
        private char _val;
        private string _userID;

        private string sql;
        private adoNetSQL sqlUtente;
        private DataTable tabellaUtenti = new DataTable();



        public int codice
        {
            get { return _codice; }
            set { _codice = value; }
        }

        public string nominativo
        {
            get { return _nominativo; }
            set { _nominativo = value; }
        }

        public string pwd
        {
            get { return _password; }
            set { _password = value; }
        }

        public string userID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public char validita
        {
            get { return _val; }
            set { _val = value; }
        }

        public clsUtente(string nomeDB)
        {
            string pathDB = Application.StartupPath + "\\" + nomeDB;
            sqlUtente = new adoNetSQL(pathDB);
        }

        public void dispose()
        {
            sqlUtente.Dispose();
        }


        public int getNuovoCodice()
        {
            int nuovoCodice = -1;
            string risultato = string.Empty;


            sql = "SELECT MAX(CodUtente) AS MAXCODICE " +
                "FROM Utenti";

            try
            {
                risultato = sqlUtente.eseguiScalar(sql, CommandType.Text);
                nuovoCodice = Convert.ToInt32(risultato) + 1;

            }
            catch (Exception e)
            {
                MessageBox.Show("ATTENZIONE: " + e.Message);
            }

            return nuovoCodice;
        }

        private void clearDati()
        {
            _nominativo = string.Empty;
            _password = string.Empty;
            _tipo = string.Empty;
            _userID = string.Empty;
            _val = ' ';
        }

        private bool verifica()
        {
            bool esito = false;

            string risultato = String.Empty;

            /* seleziona dalla tabella inquinanti tutti gli elementi con il nome passato e li conta */
            sql = "SELECT COUNT(*) AS TOTALE " +
                "FROM Utenti " +
                "WHERE UPPER(UserIDUtente) = '" + _userID.ToUpper() + "' ";

            try
            {
                //risultato contiene il numero di record che soddisfano la condizione indicata
                //in questo caso, il numero di aziende con lo stesso nome
                risultato = sqlUtente.eseguiScalar(sql, CommandType.Text);

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

        public bool controlloLogin()
        {
            bool esito = true;

            string risultato = String.Empty;

            /* seleziona dalla tabella inquinanti tutti gli elementi con il nome passato e li conta */
            sql = "SELECT COUNT(*) AS TOTALE " +
                "FROM Utenti " +
                "WHERE UPPER(UserIDUtente) = '" + _userID.ToUpper() + "'  AND PwdUtente ='" + _password + "'";

            try
            {
                //risultato contiene il numero di record che soddisfano la condizione indicata
                //in questo caso, il numero di aziende con lo stesso nome
                risultato = sqlUtente.eseguiScalar(sql, CommandType.Text);

                //se risultato vale 0, non esiste quellq coppia ID - PWD
                if (Convert.ToInt32(risultato) == 0)
                {
                    esito = false;
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
            tabellaUtenti.Clear();

            sql = "SELECT " +
                  "NominativoUtente, TipoUtente,UserIDUtente, PwdUtente, ValUtente" +
                  "FROM Utenti " +
                  "WHERE CodUtente = '" + _codice + "' ";
            try
            {
                tabellaUtenti = sqlUtente.eseguiQuery(sql, CommandType.Text);
                _nominativo = tabellaUtenti.Rows[0].ItemArray[0].ToString();
                _tipo = tabellaUtenti.Rows[0].ItemArray[1].ToString();
                _userID = tabellaUtenti.Rows[0].ItemArray[2].ToString();
                _password = tabellaUtenti.Rows[0].ItemArray[3].ToString();
                _val = Convert.ToChar(tabellaUtenti.Rows[0].ItemArray[4]);
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

            tabellaUtenti.Clear();

            if (validita == 'A')
                strValidita = "('', 'A')";

            sql = "SELECT * " +
                "FROM Utenti " +
                "WHERE ValUtente IN " + strValidita;
            try
            {
                tabellaUtenti = sqlUtente.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione !!" + e.Message);
            }


            return tabellaUtenti;
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
                  "NominativoUtente = '" + _nominativo + "', " +
                  "TipoUtente = " + _tipo + ", " +
                  "UserIDUtente = '" + _userID + "', " +
                  "PwdUtente = '" + _password + "', " +
                  "ValUtente = '" + _val + "' " +
                  "WHERE CodUtente = '" + _codice + "' ";
            try
            {
                sqlUtente.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                MessageBox.Show("Utente modificato con successo.");
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
                _codice = getNuovoCodice();

                /* Inserisci nella tabella con questi campi questi valori */
                sql = "INSERT INTO Utenti " +
                        "(CodUtente, NominativoUtente, TipoUtente, UserIDUtente, PwdUtente, ValUtente ) " +
                        "VALUES(" + "'" + _codice + "'," +
                                    "'" + _nominativo + "'," +
                                    " " + _tipo + "," +
                                    "'" + _userID + "'," +
                                    "'" + _password + "'," +
                                    "'" + _val + "')";
                try
                {
                    sqlUtente.eseguiNonQuery(sql, CommandType.Text);
                    esito = true;
                    MessageBox.Show("Utente inserito con successo.");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Attenzione !!" + e.Message);
                }
            }
            else
            {
                MessageBox.Show("Utente  già presente.");
            }

            return esito;
        }

        public void getDatiFromUserAndPWD()
        {
            int I;

            //clearDati();
            tabellaUtenti.Clear();

            sql = "SELECT " +
                  "NominativoUtente, TipoUtente,UserIDUtente, PwdUtente, ValUtente " +
                  "FROM Utenti " +
                  "WHERE  PwdUtente= '" + _password + "' AND UserIDUtente= '" + _userID + "' ";
            try
            {
                tabellaUtenti = sqlUtente.eseguiQuery(sql, CommandType.Text);
                _nominativo = tabellaUtenti.Rows[0].ItemArray[0].ToString();
                _tipo = tabellaUtenti.Rows[0].ItemArray[1].ToString();
                _userID = tabellaUtenti.Rows[0].ItemArray[2].ToString();
                _password = tabellaUtenti.Rows[0].ItemArray[3].ToString();
                _val = Convert.ToChar(tabellaUtenti.Rows[0].ItemArray[4]);
            }
            catch (Exception e)
            {
                _codice = -1;
                MessageBox.Show("Nome utente o password errati");
                //MessageBox.Show("Attenzione tqisha ropt!!" + e.Message);
            }
        }
    }
}
