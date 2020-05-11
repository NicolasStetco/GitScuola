using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Inquinamento
{
    class clsScarico
    {
        private int pCodScarico;
        private string pCodAziScarico;
        private string pCodInqScarico;
        private string pCodProScarico;
        private UInt16 pQtaScarico;
        private char pValScarico;

        private adoNetSQL sqlScarichi;
        private DataTable tabellaScarichi = new DataTable();
        private string sql;

        /***************/
        /* Costruttore */
        /***************/
        public clsScarico(string nomeDB)
        {
            string pathDB = Application.StartupPath + "\\" + nomeDB;
            sqlScarichi = new adoNetSQL(pathDB);
        }
        /***************/
        /* Distruttore */
        /***************/
        public void Dispose()
        {
            sqlScarichi.Dispose();
        }
        /********************************************/
        /* Imposta/Recupera il Codice dell' Azienda */
        /********************************************/
        public int CodScarico
        {
            get { return pCodScarico; }
            set { pCodScarico = value; }
        }
        /********************************************/
        /* Imposta/Recupera il Codice dell' Azienda */
        /********************************************/
        public string CodAziScarico
        {
            get { return pCodAziScarico; }
            set { pCodAziScarico = value; }
        }
        /********************************************/
        /* Imposta/Recupera il Codice dell' Azienda */
        /********************************************/
        public string CodInqScarico
        {
            get { return pCodInqScarico; }
            set { pCodInqScarico = value; }
        }
        /********************************************/
        /* Imposta/Recupera il Codice dell' Azienda */
        /********************************************/
        public string CodProScarico
        {
            get { return pCodProScarico; }
            set { pCodProScarico = value; }
        }
        /********************************************/
        /* Imposta/Recupera il Codice dell' Azienda */
        /********************************************/
        public UInt16 QtaScarico
        {
            get { return pQtaScarico; }
            set { pQtaScarico = value; }
        }
        /********************************************/
        /* Imposta/Recupera il Codice dell' Azienda */
        /********************************************/
        public char ValScarico
        {
            get { return pValScarico; }
            set { pValScarico = value; }
        }
        /********************/
        /* Inserimento Dati */
        /********************/
        public bool aggiungi()
        {
            bool esito = false;
            // Recupero il nuovo codice Azienda
            pCodScarico = getNuovoCodice();

            /* Inserisci nella tabella con questi campi questi valori */
            sql ="INSERT INTO Scarichi " +
                    "(codAziScarico, codInqScarico, codProScarico, qtaScarico, valScarico) " +
                    "VALUES(" + "'" + pCodAziScarico + "'," +
                                "'" + pCodInqScarico + "'," +
                                "'" + pCodProScarico + "',"+
                                " " + pQtaScarico + ","+
                                "'" + pValScarico + "')";
            try
            {
                sqlScarichi.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                MessageBox.Show("Scarico inserito con successo.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione !!" + e.Message);
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
            sql = "UPDATE Scarichi " +
                  "SET " +
                  "CodAziScarico = '" + pCodAziScarico + "', " +
                  "CodInqScarico = '" + pCodInqScarico + "', " +
                  "CodProScarico = '" + pCodProScarico + "', " +
                  "QtaScarico = '" + pQtaScarico + "', " +
                  "ValScarico = '" + pValScarico + "' " +
                  "WHERE CodScarico = '" + pCodScarico + "' ";
            try
            {
                sqlScarichi.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                MessageBox.Show("Scarico modificato con successo.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione beppe !!" + e.Message);
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
            sql = "UPDATE Scarichi " +
                  "SET " +
                  "ValScarico = '" + pValScarico + "' " +
                  "WHERE CodScarico = '" + pCodScarico + "' ";
            try
            {
                sqlScarichi.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                if (pValScarico == 'A')
                    MessageBox.Show("Scarico cancellato con successo.");
                else
                    MessageBox.Show("Scarico ripristinato con successo.");
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

            tabellaScarichi.Clear();

            if (validita == 'A')
                strValidita = "('', 'A')";

            sql = "SELECT * " +
                "FROM Scarichi " +
                "WHERE ValScarico IN " + strValidita;
            
            try
            {
                tabellaScarichi = sqlScarichi.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione !!" + e.Message);
            }
            return tabellaScarichi;
        }
        
        /***************************/
        /* Recupera singola Entità */
        /***************************/
        public void getDati()
        {
            int I;

            clearDati();
            tabellaScarichi.Clear();

            sql = "SELECT " +
                  "CodAziScarico, CodInqScarico, CodProScarico, QtaScarico, ValScarico " +
                  "FROM Scarichi " +
                  "WHERE CodScarico = '" + pCodScarico + "' ";
            try
            {
                tabellaScarichi = sqlScarichi.eseguiQuery(sql, CommandType.Text);
                pCodAziScarico = tabellaScarichi.Rows[0].ItemArray[0].ToString();
                pCodInqScarico = tabellaScarichi.Rows[0].ItemArray[1].ToString();
                pCodProScarico = tabellaScarichi.Rows[0].ItemArray[2].ToString();
                pQtaScarico = Convert.ToUInt16(tabellaScarichi.Rows[0].ItemArray[3]);
                pValScarico = Convert.ToChar(tabellaScarichi.Rows[0].ItemArray[4]);
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
                pCodScarico = 0;
                MessageBox.Show("Attenzione !!" + e.Message);
            }
        }
        /*************************/
        /* Recupero Nuovo Codice */
        /*************************/
        public int getNuovoCodice()
        {
            int nuovoCodice = 0;
            int risultato = 0;

            sql = "SELECT MAX(codScarico) AS MAXCODICE " +
                "FROM Scarichi ";

            try
            {
                risultato = Convert.ToInt32(sqlScarichi.eseguiScalar(sql, CommandType.Text));
                nuovoCodice =risultato+1;
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
            pCodAziScarico = string.Empty;
            pCodInqScarico = string.Empty;
            pCodProScarico = string.Empty;
            QtaScarico = 0;
            pValScarico = ' ';
        }
    }
}
