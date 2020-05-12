using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Inquinamento
{
    class clsScarico
    {
        private string _codInquinante;
        private string _codAzienda;
        private string _codProdotto;
        private char _validita;
        private string _codiceScarico;
        private int _quantita;

        private string sql;
        private adoNetSQL sqlScarico;
        private DataTable tabellaScarichi = new DataTable();



        /***********************************************/
        /* Imposta/Recupera le proprità dell'inquinante*/
        /***********************************************/
        public string codInquinante
        {
            get { return _codInquinante; }
            set { _codInquinante = value; }
        }

        public string codAzienda
        {
            get { return _codAzienda; }
            set { _codAzienda = value; }
        }

        public string codProdotto
        {
            get { return _codProdotto; }
            set { _codProdotto = value; }
        }

        public char validita
        {
            get { return _validita; }
            set { _validita = value; }
        }

        public string codiceScarico
        {
            get { return _codiceScarico; }
            set { _codiceScarico = value; }
        }

        public int quantita
        {
            get { return _quantita; }
            set { _quantita = value; }
        }
        //==============================================================================
        //******************************************************************************
        //==============================================================================


        /***************/
        /* Costruttore */
        /***************/
        public clsScarico(string nomeDB)
        {
            string pathDB = Application.StartupPath + "\\" + nomeDB;
            sqlScarico = new adoNetSQL(pathDB);
        }

        /***************/
        /* Distruttore */
        /***************/
        public void Dispose()
        {
            sqlScarico.Dispose();
        }


        /*******************************************/
        /* Recupera il prossimo codice da inserire */
        /*******************************************/
        public string getNuovoCodice()
        {
            string nuovoCodice = string.Empty;
            string risultato = string.Empty;
            string valoreNumerico = string.Empty;

            sql = "SELECT MAX(CodScarico) AS MAXCODICE " +
                "FROM Scarichi";

            try
            {
                risultato = sqlScarico.eseguiScalar(sql, CommandType.Text);
                nuovoCodice = Convert.ToString(Convert.ToInt32(risultato) + 1);
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
            _codProdotto = string.Empty;
            _quantita = 0;
            _codAzienda = string.Empty;
            _validita = ' ';
           // _codiceScarico =string.Empty;
            _codInquinante = string.Empty;
        }

        

        /***************************/
        /* Recupera singola Entità */
        /***************************/
        public void getDati()
        {

            clearDati();
            tabellaScarichi.Clear();

           

            sql = "SELECT " +
                 "CodScarico, CodAziScarico,CodInqScarico, CodProScarico, QtaScarico,ValScarico " +
                 "FROM Scarichi " +
                 "WHERE CodScarico = '" + _codiceScarico + "' ";
            

            try
            {
                tabellaScarichi = sqlScarico.eseguiQuery(sql, CommandType.Text);
                _codiceScarico = tabellaScarichi.Rows[0].ItemArray[0].ToString();
                _codAzienda = tabellaScarichi.Rows[0].ItemArray[1].ToString();
                _codInquinante = tabellaScarichi.Rows[0].ItemArray[2].ToString();
                _codProdotto = tabellaScarichi.Rows[0].ItemArray[3].ToString();
                _quantita = Convert.ToInt32(tabellaScarichi.Rows[0].ItemArray[4]);
                _validita = Convert.ToChar(tabellaScarichi.Rows[0].ItemArray[5]);
            }
            catch (Exception e)
            {
                _codiceScarico = null;
                MessageBox.Show("Attenzione !! " + e.Message);
            }
        }

        /**************************/
        /* Genera Lista Inquinanti*/
        /*************************/
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
                tabellaScarichi = sqlScarico.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione !!" + e.Message);
            }


            return tabellaScarichi;
        }


  

        /***********************************************/
        /* Modifica i dati dell'inquinante selezionato */
        /***********************************************/
        public bool modifica()
        {
            bool esito = false;

            // Imposto SQL per modificare l'inquinante
            sql = "UPDATE Scarichi " +
                  "SET " +
                  "CodProScarico = '" + _codProdotto + "', " +
                  "QtaScarico = " + _quantita + ", " +
                  "CodAziScarico = '" + _codAzienda + "', " +
                  "CodInqScarico = '" + _codInquinante + "', " +
                  "ValScarico = '" + _validita + "' " +
                  "WHERE CodScarico = '" + _codiceScarico + "' ";
            try
            {
                sqlScarico.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                MessageBox.Show("Scarico modificato con successo.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione tqsiha ropt!!" + e.Message);
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
            
                // Recupero il nuovo codice Azienda
                _codiceScarico = getNuovoCodice();

                /* Inserisci nella tabella con questi campi questi valori */
                sql = "INSERT INTO Scarichi " +
                        "(CodInqScarico, CodProScarico, QtaScarico , CodAziScarico,  ValScarico ) " +
                        "VALUES(" + "'" + _codInquinante + "'," +
                                    "'" + _codProdotto + "'," +
                                    " " + _quantita + "," +
                                    "'" + _codAzienda + "'," +
                                  
                                    "'" + _validita + "')";
                try
                {
                    sqlScarico.eseguiNonQuery(sql, CommandType.Text);
                    esito = true;
                    MessageBox.Show("Scarico inserito con successo.");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Attenzione !!" + e.Message);
                }
          

            return esito;
        }
    }
}
