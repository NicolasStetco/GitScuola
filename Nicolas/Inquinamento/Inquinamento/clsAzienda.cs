using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Inquinamento
{
    class clsAzienda
    {

        // Imposto Proprietà PRIVATE
        private string pCodAzienda;
        private string pNomeAzienda;
        private UInt16 pGradoAzienda;
        private string pCittaAzienda;
        private char pValAzienda;

        private adoNetSQL sqlAziende;
        private DataTable tabellaAziende = new DataTable();
        private string sql;

        // Imposto Proprietà PUBBLICHE


        // Imposto Metodi PUBBLICI

        /***************/
        /* Costruttore */
        /***************/
        public clsAzienda(string nomeDB)
        {
            string pathDB = Application.StartupPath + "\\" + nomeDB;
            sqlAziende = new adoNetSQL(pathDB);
        }

        /***************/
        /* Distruttore */
        /***************/
        public void Dispose()
        {
            sqlAziende.Dispose();
        }

        /********************************************/
        /* Imposta/Recupera il Codice dell' Azienda */
        /********************************************/
        public string CodAzienda
        {
            get { return pCodAzienda; }
            set { pCodAzienda = value; }
        }

        /******************************************/
        /* Imposta/Recupera il Nome dell' Azienda */
        /******************************************/
        public string NomeAzienda
        {
            get { return pNomeAzienda; }
            set { pNomeAzienda = value; }
        }

        /*******************************************/
        /* Imposta/Recupera il Grado dell' Azienda */
        /*******************************************/
        public UInt16 GradoAzienda
        {
            get { return pGradoAzienda; }
            set { pGradoAzienda = value; }
        }

        /*******************************************/
        /* Imposta/Recupera la Città dell' Azienda */
        /*******************************************/
        public string CittaAzienda
        {
            get { return pCittaAzienda; }
            set { pCittaAzienda = value; }
        }

        /**********************************************/
        /* Imposta/Recupera la Validità dell' Azienda */
        /**********************************************/
        public char ValAzienda
        {
            get { return pValAzienda; }
            set { pValAzienda = value; }
        }

        /********************/
        /* Inserimento Dati */
        /********************/
        public bool aggiungi()
        {
            bool esito = false;

            // Verifico che l'Azienda da inserire non sia già presente
            if (verifica())
            {
                // Recupero il nuovo codice Azienda
                pCodAzienda = getNuovoCodice();

                /* Inserisci nella tabella con questi campi questi valori */
                sql = "INSERT INTO Aziende " +
                        "(codAzienda, nomeAzienda, gradoAzienda, cittaAzienda, valAzienda) " +
                        "VALUES(" + "'" + pCodAzienda + "'," +
                                    "'" + pNomeAzienda + "'," +
                                    " " + pGradoAzienda + "," +
                                    "'" + pCittaAzienda + "'," +
                                    "'" + pValAzienda + "')";
                try
                {
                    sqlAziende.eseguiNonQuery(sql, CommandType.Text);
                    esito = true;
                    MessageBox.Show("Azienda inserita con successo.");
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

        /*****************/
        /* Modifica Dati */
        /*****************/
        public bool modifica()
        {
            bool esito = false;

            // Imposto SQL per modificare l'Azienda
            sql = "UPDATE Aziende " +
                  "SET " +
                  "NomeAzienda = '" + pNomeAzienda + "', " +
                  "GradoAzienda = " + pGradoAzienda + ", " +
                  "CittaAzienda = '" + pCittaAzienda + "', " +
                  "ValAzienda = '" + pValAzienda + "' " +
                  "WHERE CodAzienda = '" + pCodAzienda + "' ";
            try
            {
                sqlAziende.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                MessageBox.Show("Azienda modificata con successo.");
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
            sql = "UPDATE Aziende " +
                  "SET " +
                  "ValAzienda = '" + pValAzienda + "' " +
                  "WHERE CodAzienda = '" + pCodAzienda + "' ";
            try
            {
                sqlAziende.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                if (pValAzienda == 'A')
                    MessageBox.Show("Azienda cancellata con successo.");
                else
                    MessageBox.Show("Azienda ripristinata con successo.");
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

            tabellaAziende.Clear();

            if (validita == 'A')
                strValidita = "('', 'A')";

            sql = "SELECT * " +
                "FROM Aziende " +
                "WHERE ValAzienda IN " + strValidita;
            try
            {
                tabellaAziende = sqlAziende.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione !!" + e.Message);
            }


            return tabellaAziende;
        }

        /***************************/
        /* Recupera singola Entità */
        /***************************/
        public void getDati()
        {
            int I;

            clearDati();
            tabellaAziende.Clear();

            sql = "SELECT " +
                  "NomeAzienda, GradoAzienda, CittaAzienda,ValAzienda " +
                  "FROM Aziende " +
                  "WHERE CodAzienda = '" + pCodAzienda + "' ";
            try
            {
                tabellaAziende = sqlAziende.eseguiQuery(sql, CommandType.Text);
                pNomeAzienda = tabellaAziende.Rows[0].ItemArray[0].ToString();
                pGradoAzienda = Convert.ToUInt16(tabellaAziende.Rows[0].ItemArray[1]);
                pCittaAzienda = tabellaAziende.Rows[0].ItemArray[2].ToString();
                pValAzienda = Convert.ToChar(tabellaAziende.Rows[0].ItemArray[3]);
                // gestisco l' unica riga in modo da recuperare i Dati
                /*
                for (I = 0; I < tabellaAziende.Rows[0].ItemArray.Length; I++)
                    {
                    switch (I)
                    {
                        case 0:
                            pNomeAzienda = tabellaAziende.Rows[0].ItemArray[I].ToString();
                            break;
                        case 1:
                            pGradoAzienda = Convert.ToUInt16(tabellaAziende.Rows[0].ItemArray[I]);
                            break;
                        case 2:
                            pCittaAzienda = tabellaAziende.Rows[0].ItemArray[I].ToString();
                            break;
                        case 3:
                            pValAzienda = Convert.ToChar(tabellaAziende.Rows[0].ItemArray[I]);
                            break;
                    }
                 }*/
            }
            catch (Exception e)
            {
                pCodAzienda = null;
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

            /* seleziona dalla tabella Aziende tutti gli elementi con il nome passato e li conta */
            sql = "SELECT COUNT(*) AS TOTALE " +
                "FROM Aziende " +
                "WHERE UPPER(NomeAzienda) = '" + pNomeAzienda.ToUpper() + "' ";

            try
            {
                risultato = sqlAziende.eseguiScalar(sql, CommandType.Text);
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

            sql = "SELECT MAX(codAzienda) AS MAXCODICE " +
                "FROM Aziende ";

            try
            {
                risultato = sqlAziende.eseguiScalar(sql, CommandType.Text);
                valoreNumerico = risultato.Substring(1);
                nuovoCodice = "A" + (Convert.ToInt32(valoreNumerico) + 1);
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
            pNomeAzienda = string.Empty;
            pGradoAzienda = 0;
            pCittaAzienda = string.Empty;
            pValAzienda = ' ';
        }

        // ..

    }
}