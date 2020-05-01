using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Inquinamento
{
    class clsInquinante
    {
        private string _codInquinante;
        private string _cittaInquinante;
        private string _nomeInquinante;
        private char _validita;
        private char _statoInquinante;
        private int _pesoSpecificoInquinante;

        private string sql;
        private adoNetSQL sqlInquinanti;
        private DataTable tabellaInquinanti = new DataTable();



        /***********************************************/
        /* Imposta/Recupera le proprità dell'inquinante*/
        /***********************************************/
        public string codAzienda
        {
            get { return _codInquinante; }
            set { _codInquinante = value; }
        }

        public string citta
        {
            get { return _cittaInquinante; }
            set { _cittaInquinante = value; }
        }

        public string nomeInquinante
        {
            get { return _nomeInquinante; }
            set { _nomeInquinante = value; }
        }

        public char validita
        {
            get { return _validita; }
            set { _validita = value; }
        }

        public char stato
        {
            get { return _statoInquinante; }
            set { _statoInquinante = value; }
        }

        public int pesoSpecifico
        {
            get { return _pesoSpecificoInquinante; }
            set { _pesoSpecificoInquinante = value; }
        }
        //==============================================================================
        //******************************************************************************
        //==============================================================================


        /***************/
        /* Costruttore */
        /***************/
        public clsInquinante(string nomeDB)
        {
            string pathDB = Application.StartupPath + "\\" + nomeDB;
            sqlInquinanti = new adoNetSQL(pathDB);
        }

        /***************/
        /* Distruttore */
        /***************/
        public void Dispose()
        {
            sqlInquinanti.Dispose();
        }


        /*******************************************/
        /* Recupera il prossimo codice da inserire */
        /*******************************************/
        public string getNuovoCodice()
        {
            string nuovoCodice = string.Empty;
            string risultato = string.Empty;
            string valoreNumerico = string.Empty;

            sql = "SELECT MAX(CodInquinante) AS MAXCODICE " +
                "FROM Inquinanti";

            try
            {
                risultato = sqlInquinanti.eseguiScalar(sql, CommandType.Text);
                valoreNumerico = risultato.Substring(1);
                nuovoCodice = "I" + (Convert.ToInt32(valoreNumerico) + 1);
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
            _nomeInquinante = string.Empty;
            _pesoSpecificoInquinante = 0;
            _cittaInquinante = string.Empty;
            _validita = ' ';
            _statoInquinante = ' ';
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
                "FROM Inquinanti " +
                "WHERE UPPER(NomeInquinante) = '" + _nomeInquinante.ToUpper() + "' ";

            try
            {
                //risultato contiene il numero di record che soddisfano la condizione indicata
                //in questo caso, il numero di aziende con lo stesso nome
                risultato = sqlInquinanti.eseguiScalar(sql, CommandType.Text);
                
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
            tabellaInquinanti.Clear();

            sql = "SELECT " +
                  "NomeInquinante, StatoInquinante,PesSpecInquinante, CittaInquinante, ValInquinante " +
                  "FROM Inquinanti " +
                  "WHERE CodInquinante = '" + _codInquinante + "' ";
            try
            {
                tabellaInquinanti = sqlInquinanti.eseguiQuery(sql, CommandType.Text);
                _nomeInquinante = Convert.ToString(tabellaInquinanti.Rows[0].ItemArray[0].ToString());
                _statoInquinante = Convert.ToChar(tabellaInquinanti.Rows[0].ItemArray[1]);
                _pesoSpecificoInquinante = Convert.ToInt32(tabellaInquinanti.Rows[0].ItemArray[2].ToString());
                _cittaInquinante = Convert.ToString(tabellaInquinanti.Rows[0].ItemArray[3]);
                _validita = Convert.ToChar(tabellaInquinanti.Rows[0].ItemArray[4]);
            }
            catch (Exception e)
            {
                _codInquinante = null;
                MessageBox.Show("Attenzione !!" + e.Message);
            }
        }

        /**************************/
        /* Genera Lista Inquinanti*/
        /*************************/
        public DataTable lista(char validita)
        {
            string strValidita = "('')";

            tabellaInquinanti.Clear();

            if (validita == 'A')
                strValidita = "('', 'A')";

            sql = "SELECT * " +
                "FROM Inquinanti " +
                "WHERE ValInquinante IN " + strValidita;
            try
            {
                tabellaInquinanti = sqlInquinanti.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione !!" + e.Message);
            }


            return tabellaInquinanti;
        }


        /***************************************/
        /* Cancellazione (LOGICA) di un entità */
        /***************************************/
        public bool cancella()
        {
            bool esito = false;

            // Imposta SQL di Cancellazione / 
            sql = "UPDATE Inquinanti " +
                  "SET " +
                  "ValInquinante = '" + _validita + "' " +
                  "WHERE CodInquinante = '" + _codInquinante + "' ";
            try
            {
                sqlInquinanti.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                if (_validita == 'A')
                    MessageBox.Show("Inquinante cancellato con successo.");
                else
                    MessageBox.Show("Inquinante ripristinato con successo.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione !!" + e.Message);
            }

            return esito;
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
                  "NomeInquinante = '" + _nomeInquinante + "', " +
                  "PesSpecInquinante = " + _pesoSpecificoInquinante + ", " +
                  "CittaInquinante = '" + _cittaInquinante + "', " +
                  "StatoInquinante = '" + _statoInquinante + "', " +
                  "Valinquinante = '" + _validita + "' " +
                  "WHERE CodInquinante = '" + _codInquinante + "' ";
            try
            {
                sqlInquinanti.eseguiNonQuery(sql, CommandType.Text);
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
        /* Inserimento NUOVO inquinante */
        /********************************/
        public bool aggiungi()
        {
            bool esito = false;

            // Verifico che l'Azienda da inserire non sia già presente
            if (verifica())
            {
                // Recupero il nuovo codice Azienda
                _codInquinante = getNuovoCodice();

                /* Inserisci nella tabella con questi campi questi valori */
                sql = "INSERT INTO Aziende " +
                        "(CodInquinante, NomeInquinante, PesSpecinquinante , c ittaAzienda, StatoInquinante, ValInquinante ) " +
                        "VALUES(" + "'" + _codInquinante + "'," +
                                    "'" + _nomeInquinante + "'," +
                                    " " + _pesoSpecificoInquinante + "," +
                                    "'" + _cittaInquinante + "'," +
                                    "'" + _statoInquinante + "'," +
                                    "'" + _validita + "')";
                try
                {
                    sqlInquinanti.eseguiNonQuery(sql, CommandType.Text);
                    esito = true;
                    MessageBox.Show("Inquinante inserito con successo.");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Attenzione !!" + e.Message);
                }
            }
            else
            {
                MessageBox.Show("Azienda già presente.");
            }

            return esito;
        }


    }
}
