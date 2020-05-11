﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Inquinamento
{
    class clsProdotto
    {

        // Imposto Proprietà PRIVATE
        private string pCodProdotto;
        private string pNomeProdotto;
        private string pCittaProdotto;
        private char pValProdotto;

        private adoNetSQL sqlProdotti;
        private DataTable tabellaProdotti = new DataTable();
        private string sql;

        // Imposto Proprietà PUBBLICHE


        // Imposto Metodi PUBBLICI

        /***************/
        /* Costruttore */
        /***************/
        public clsProdotto(string nomeDB)
        {
            string pathDB = Application.StartupPath + "\\" + nomeDB;
            sqlProdotti = new adoNetSQL(pathDB);
        }

        /***************/
        /* Distruttore */
        /***************/
        public void Dispose()
        {
            sqlProdotti.Dispose();
        }

        /********************************************/
        /* Imposta/Recupera il Codice dell' Azienda */
        /********************************************/
        public string CodProdotto
        {
            get { return pCodProdotto; }
            set { pCodProdotto = value; }
        }

        /******************************************/
        /* Imposta/Recupera il Nome dell' Azienda */
        /******************************************/
        public string NomeProdotto
        {
            get { return pNomeProdotto; }
            set { pNomeProdotto = value; }
        }

        
        /*******************************************/
        /* Imposta/Recupera la Città dell' Azienda */
        /*******************************************/
        public string CittaProdotto
        {
            get { return pCittaProdotto; }
            set { pCittaProdotto = value; }
        }

        /**********************************************/
        /* Imposta/Recupera la Validità dell' Azienda */
        /**********************************************/
        public char ValProdotto
        {
            get { return pValProdotto; }
            set { pValProdotto = value; }
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
                pCodProdotto = getNuovoCodice();

                /* Inserisci nella tabella con questi campi questi valori */
                sql = "INSERT INTO Prodotti " +
                        "(codProdotto, nomeProdotto, cittaProdotto, valProdotto) " +
                        "VALUES(" + "'" + pCodProdotto + "'," +
                                    "'" + pNomeProdotto + "'," +
                                    "'" + pCittaProdotto + "'," +
                                    "'" + pValProdotto + "')";
                try
                {
                    sqlProdotti.eseguiNonQuery(sql, CommandType.Text);
                    esito = true;
                    MessageBox.Show("Prodotto inserita con successo.");
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

        /*****************/
        /* Modifica Dati */
        /*****************/
        public bool modifica()
        {
            bool esito = false;

            // Imposto SQL per modificare l'Azienda
            sql = "UPDATE Prodotti " +
                  "SET " +
                  "NomeProdotto = '" + pNomeProdotto + "', " +
                  "CittaProdotto = '" + pCittaProdotto + "', " +
                  "ValProdotto = '" + pValProdotto + "' " +
                  "WHERE CodProdotto = '" + pCodProdotto + "' ";
            try
            {
                sqlProdotti.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                MessageBox.Show("Prodotto modificato con successo.");
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
            sql = "UPDATE Prodotti " +
                  "SET " +
                  "ValProdotto = '" + pValProdotto + "' " +
                  "WHERE CodProdotto = '" + pCodProdotto + "' ";
            try
            {
                sqlProdotti.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                if (pValProdotto == 'A')
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

        /****************/
        /* Genera Lista */
        /****************/
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
                tabellaProdotti = sqlProdotti.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione !!" + e.Message);
            }
            return tabellaProdotti;
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
                  "WHERE CodProdotto = '" + pCodProdotto + "' ";
            try
            {
                tabellaProdotti = sqlProdotti.eseguiQuery(sql, CommandType.Text);
                pNomeProdotto = tabellaProdotti.Rows[0].ItemArray[0].ToString();
                pCittaProdotto = tabellaProdotti.Rows[0].ItemArray[1].ToString();
                pValProdotto = Convert.ToChar(tabellaProdotti.Rows[0].ItemArray[2]);
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
                pCodProdotto = null;
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
                "FROM Prodotti " +
                "WHERE UPPER(NomeProdotto) = '" + pNomeProdotto.ToUpper() + "' ";

            try
            {
                risultato = sqlProdotti.eseguiScalar(sql, CommandType.Text);
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

            sql = "SELECT MAX(codProdotto) AS MAXCODICE " +
                "FROM Prodotti ";

            try
            {
                risultato = sqlProdotti.eseguiScalar(sql, CommandType.Text);
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
            pNomeProdotto = string.Empty;
            pCittaProdotto = string.Empty;
            pValProdotto = ' ';
        }

        // ..

    }
}