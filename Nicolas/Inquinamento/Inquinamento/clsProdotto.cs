using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Inquinamento
{
    class clsProdotto
    {
        private string _codiceProdotto;
        private string _cittaProdotto;
        private string _nomeProdotto;
        private char _validita;


        private string sql;
        private adoNetSQL sqlProdotto;
        private DataTable tabellaProdotti = new DataTable();


        /***********************************************/
        /* Imposta/Recupera le proprità dell'inquinante*/
        /***********************************************/
        public string codice
        {
            get { return _codiceProdotto; }
            set { _codiceProdotto = value; }
        }

        public string citta
        {
            get { return _cittaProdotto; }
            set { _cittaProdotto = value; }
        }

        public string nome
        {
            get { return _nomeProdotto; }
            set { _nomeProdotto = value; }
        }

        public char validita
        {
            get { return _validita; }
            set { _validita = value; }
        }


        //==============================================================================
        //******************************************************************************
        //==============================================================================


        /***************/
        /* Costruttore */
        /***************/

        public clsProdotto(string nomeDB)
        {
            string pathDB = Application.StartupPath + "\\" + nomeDB;
            sqlProdotto = new adoNetSQL(pathDB);
        }

        /***************/
        /* Distruttore */
        /***************/
        public void Dispose()
        {
            sqlProdotto.Dispose();
        }


        /*******************************************/
        /* Recupera il prossimo codice da inserire */
        /*******************************************/
        public string getNuovoCodice()
        {
            string nuovoCodice = string.Empty;
            string risultato = string.Empty;
            string valoreNumerico = string.Empty;

            sql = "SELECT MAX(codProdotto) AS MAXCODICE " +
                "FROM Prodotti";

            try
            {
                risultato = sqlProdotto.eseguiScalar(sql, CommandType.Text);
                valoreNumerico = risultato.Substring(1);
                nuovoCodice = "P" + (Convert.ToInt32(valoreNumerico) + 1);
            }
            catch (Exception e)
            {
                MessageBox.Show("ATTENZIONE: " + e.Message);
            }

            return nuovoCodice;
        }

        /***************************************/
        /* Pulisce i Dati della Singola Entità */
        /***************************************/
        private void clearDati()
        {
            _nomeProdotto = string.Empty;
            _cittaProdotto = string.Empty;
            _validita = ' ';

        }

        /*******************************/
        /* Controllo Duplicazione Dati */
        /*******************************/
        private bool verifica()
        {
            bool esito = false;

            string risultato = String.Empty;

            /* seleziona dalla tabella inquinanti tutti gli elementi con il nome passato e li conta */
            sql = "SELECT COUNT(*) AS TOTALE " +
                "FROM Prodotti " +
                "WHERE UPPER(NomeProdotto) = '" + _nomeProdotto.ToUpper() + "' ";

            try
            {
                //risultato contiene il numero di record che soddisfano la condizione indicata
                //in questo caso, il numero di aziende con lo stesso nome
                risultato = sqlProdotto.eseguiScalar(sql, CommandType.Text);

                //se risultato vale 0, non ci altri prodotti con quel nome
                if (Convert.ToInt32(risultato) == 0)
                {
                    esito = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ATTENZIONE: " + e.Message);
            }

            //se la funziona restituisce falso, esiste già un prodotto con quel nome
            return esito;
        }

        /***************************/
        /* Recupera singola Entità */
        /***************************/
        public void getDati()
        {
            int I;

            clearDati();
            tabellaProdotti.Clear();

            sql = "SELECT " +
                  "NomeProdotto, CittaProdotto, ValProdotto " +
                  "FROM Prodotti " +
                  "WHERE CodProdotto = '" + _codiceProdotto + "' ";
            try
            {
                tabellaProdotti = sqlProdotto.eseguiQuery(sql, CommandType.Text);
                _nomeProdotto = Convert.ToString(tabellaProdotti.Rows[0].ItemArray[0].ToString());
                _cittaProdotto = Convert.ToString(tabellaProdotti.Rows[0].ItemArray[1]);
                _validita = Convert.ToChar(tabellaProdotti.Rows[0].ItemArray[2]);
            }
            catch (Exception e)
            {
                _codiceProdotto = null;
                MessageBox.Show("Attenzione !!" + e.Message);
            }
        }

        /**************************/
        /* Genera Lista prdotti*/
        /*************************/
        public DataTable lista(char validita)
        {
            string strValidita = "('')";

            tabellaProdotti.Clear();

            if (validita == 'A')
                strValidita = "('', 'A')";

            sql = "SELECT * " +
                "FROM Prodotti " +
                "WHERE ValProdotto IN " + strValidita;
            try
            {
                tabellaProdotti = sqlProdotto.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione !!" + e.Message);
            }


            return tabellaProdotti;
        }


        /***************************************/
        /* Cancellazione (LOGICA) di un entità */
        /***************************************/
        public bool cancella()
        {
            bool esito = false;

            // Imposta SQL di Cancellazione / 
            sql = "UPDATE Prodotti " +
                  "SET " +
                  "ValProdotto = '" + _validita + "' " +
                  "WHERE CodProdotto = '" + _codiceProdotto + "' ";
            try
            {
                sqlProdotto.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                if (_validita == 'A')
                    MessageBox.Show("Prodotto cancellato con successo.");
                else
                    MessageBox.Show("Prodotto ripristinato con successo.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione !!" + e.Message);
            }

            return esito;
        }

        /***********************************************/
        /* Modifica i dati del prodotto selezionato */
        /***********************************************/
        public bool modifica()
        {
            bool esito = false;

            // Imposto SQL per modificare il prodotto
            sql = "UPDATE Prodotti " +
                  "SET " +
                  "NomeProdotto = '" + _nomeProdotto + "', " +
                  "CittaProdotto = '" + _cittaProdotto + "', " +
                  "ValProdotto = '" + _validita + "' " +
                  "WHERE CodProdotto = '" + _codiceProdotto + "' ";
            try
            {
                sqlProdotto.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                MessageBox.Show("Azienda modificata con successo.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione !!" + e.Message);
            }

            return esito;
        }

        /********************************/
        /* Inserimento NUOVO prodotto */
        /********************************/
        public bool aggiungi()
        {
            bool esito = false;

            // Verifico che il prodotto da inserire non sia già presente
            if (verifica())
            {
                // Recupero il nuovo codice prodotto
                _codiceProdotto = getNuovoCodice();

                /* Inserisci nella tabella con questi campi questi valori */
                sql = "INSERT INTO Prodotti " +
                        "(CodProdotto, NomeProdotto, CittaProdotto, ValProdotto ) " +
                        "VALUES(" + "'" + _codiceProdotto + "'," +
                                    "'" + _nomeProdotto + "'," +
                                     "'" + _cittaProdotto + "'," +
                                    "'" + _validita + "')";
                try
                {
                    sqlProdotto.eseguiNonQuery(sql, CommandType.Text);
                    esito = true;
                    MessageBox.Show("Prodotto inserito con successo.");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Attenzione !!" + e.Message);
                }
            }
            else
            {
                MessageBox.Show("Prodotto già presente.");
            }

            return esito;
        }

    }
}

