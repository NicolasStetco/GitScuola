using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Inquinamento
{
    class clsInquinante
    {

        // Imposto Proprietà PRIVATE
        private string pCodInquinante;
        private string pNomeInquinante;
        private char pStatoInquinante;
        private UInt16 PesSpecInquinante;
        private string pCittaInquinante;
        private char pValInquinante;

        private adoNetSQL sqlInquinanti;
        private DataTable tabellaInquinanti = new DataTable();
        private string sql;

        // Imposto Proprietà PUBBLICHE


        // Imposto Metodi PUBBLICI

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

        /********************************************/
        /* Imposta/Recupera il Codice dell' Inquinante */
        /********************************************/
        public string CodInquinante
        {
            get { return pCodInquinante; }
            set { pCodInquinante = value; }
        }

        /******************************************/
        /* Imposta/Recupera il Nome dell' Inquinante */
        /******************************************/
        public string NomeInquinante
        {
            get { return pNomeInquinante; }
            set { pNomeInquinante = value; }
        }

        /*******************************************/
        /* Imposta/Recupera il Grado dell' Inquinante */
        /*******************************************/
        public char StatoInquinante
        {
            get { return pStatoInquinante; }
            set { pStatoInquinante = value; }
        }

        /*******************************************/
        /* Imposta/Recupera la Città dell' Inquinante */
        /*******************************************/
        public UInt16 PesoSpecificoInquinante
        {
            get { return PesSpecInquinante; }
            set { PesSpecInquinante = value; }
        }

        /**********************************************/
        /* Imposta/Recupera la Validità dell' Inquinante */
        /**********************************************/
        public string CittaInquinante
        {
            get { return pCittaInquinante; }
            set { pCittaInquinante = value; }
        }
        /*************************************************/
        /* Imposta/Recupera la Validità dell' Inquinante */
        /*************************************************/
        public char ValInquinante
        {
            get { return pValInquinante; }
            set { pValInquinante = value; }
        }

        /********************/
        /* Inserimento Dati */
        /********************/
        public bool aggiungi()
        {
            bool esito = false;

            // Verifico che l'Inquinante da inserire non sia già presente
            if (verifica())
            {
                // Recupero il nuovo codice Inquinante
                pCodInquinante = getNuovoCodice();

                /* Inserisci nella tabella con questi campi questi valori */
                sql = "INSERT INTO Inquinanti " +
                        "(codInquinante, nomeInquinante, statoInquinante, pesSpecInquinante, cittaInquinante, valInquinante) " +
                        "VALUES(" + "'" + pCodInquinante + "'," +
                                    "'" + pNomeInquinante + "'," +
                                    "'" + pStatoInquinante + "'," +
                                    " " + PesSpecInquinante + "," +
                                    "'" + pCittaInquinante + "'," +
                                    "'" + pValInquinante + "')";
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
                MessageBox.Show("Inquinante già presente.");
            }

            return esito;
        }

        /*****************/
        /* Modifica Dati */
        /*****************/
        public bool modifica()
        {
            bool esito = false;

            // Imposto SQL per modificare l'Inquinante
            sql = "UPDATE Inquinanti " +
                  "SET " +
                  "NomeInquinante = '" + pNomeInquinante + "', " +
                  "StatoInquinante = '" + pStatoInquinante + "', " +
                  "PesSpecInquinante = '" + PesSpecInquinante + "', " +
                  "CittaInquinante = '" + pCittaInquinante + "', " +
                  "ValInquinante = '" + pValInquinante + "' " +
                  "WHERE CodInquinante = '" + pCodInquinante + "' ";
            try
            {
                sqlInquinanti.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                MessageBox.Show("Inquinante modificato con successo.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione !!" + e.Message);
            }

            return esito;
        }

        /*******************************/
        /* Cancellazione Dati (Logica) */
        /*******************************/
        public bool cancella()
        {
            bool esito = false;

            // Imposta SQL di Cancellazione / 
            sql = "UPDATE Inquinanti " +
                  "SET " +
                  "ValInquinante = '" + pValInquinante + "' " +
                  "WHERE CodInquinante = '" + pCodInquinante + "' ";
            try
            {
                sqlInquinanti.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                if (pValInquinante == 'A')
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

        /****************/
        /* Genera Lista */
        /****************/
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

        /***************************/
        /* Recupera singola Entità */
        /***************************/
        public void getDati()
        {
            int I;

            clearDati();
            tabellaInquinanti.Clear();

            sql = "SELECT " +
                  "NomeInquinante, StatoInquinante, PesSpecInquinante,CittaInquinante,ValInquinante " +
                  "FROM Inquinanti " +
                  "WHERE CodInquinante = '" + pCodInquinante + "' ";
            try
            {
                tabellaInquinanti = sqlInquinanti.eseguiQuery(sql, CommandType.Text);
                pNomeInquinante = tabellaInquinanti.Rows[0].ItemArray[0].ToString();
                pStatoInquinante = Convert.ToChar(tabellaInquinanti.Rows[0].ItemArray[1]);
                PesSpecInquinante = Convert.ToUInt16(tabellaInquinanti.Rows[0].ItemArray[2]);
                pCittaInquinante = tabellaInquinanti.Rows[0].ItemArray[3].ToString();
                pValInquinante = Convert.ToChar(tabellaInquinanti.Rows[0].ItemArray[4]);
            }
            catch (Exception e)
            {
                pCodInquinante = null;
                MessageBox.Show("Attenzione !!" + e.Message);
            }
        }

        // ..

        // Imposto Metodi PRIVATI

        /*******************************/
        /* Controllo Duplicazione Dati */
        /*******************************/
        private bool verifica()
        {
            bool esito = false;

            string risultato = String.Empty;

            /* seleziona dalla tabella Inquinante tutti gli elementi con il nome passato e li conta */
            sql = "SELECT COUNT(*) AS TOTALE " +
                "FROM Inquinanti " +
                "WHERE UPPER(NomeInquinante) = '" + pNomeInquinante.ToUpper() + "' ";

            try
            {
                risultato = sqlInquinanti.eseguiScalar(sql, CommandType.Text);
                if (Convert.ToInt32(risultato) == 0)
                {
                    esito = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ATTENZIONE: " + e.Message);
            }

            return esito;
        }

        /*************************/
        /* Recupero Nuovo Codice */
        /*************************/
        public string getNuovoCodice()
        {
            string nuovoCodice = string.Empty;
            string risultato = string.Empty;
            string valoreNumerico = string.Empty;

            sql = "SELECT MAX(codInquinante) AS MAXCODICE " +
                "FROM Inquinanti ";

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
            pNomeInquinante = string.Empty;
            pStatoInquinante = ' ';
            PesSpecInquinante = 0;
            pCittaInquinante = string.Empty;
            pValInquinante = ' ';
        }
    }
}