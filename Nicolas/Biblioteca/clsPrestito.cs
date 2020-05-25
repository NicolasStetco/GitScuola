using System;
using System.Data;
using System.Windows.Forms;

namespace Biblioteca
{
    class clsPrestito
    {
        private int _codice;
        private int _codLibro;
        private int _codLettore;
        private char _val;
        private DateTime _dataPrestito;
        private DateTime _dataRest;

        private string sql;
        private adoNetSQL sqlPrestito;
        private DataTable tabellaPrestiti = new DataTable();



        public int codice
        {
            get { return _codice; }
            set { _codice = value; }
        }

        public int codLettore
        {
            get { return _codLettore; }
            set { _codLettore = value; }
        }

        public int codLibro
        {
            get { return _codLibro; }
            set { _codLibro = value; }
        }

        public DateTime dataPrestito
        {
            get { return _dataPrestito; }
            set { _dataPrestito = value; }
        }

        public DateTime dataRest
        {
            get { return _dataRest; }
            set { _dataRest = value; }
        }

        public char validita
        {
            get { return _val; }
            set { _val = value; }
        }

        public clsPrestito(string nomeDB)
        {
            string pathDB = Application.StartupPath + "\\" + nomeDB;
            sqlPrestito = new adoNetSQL(pathDB);
        }

        public void dispose()
        {
            sqlPrestito.Dispose();
        }




        private void clearDati()
        {
            _dataRest = DateTime.MinValue;
            _dataPrestito = DateTime.MinValue;
            _codLibro = 0;
            _codLettore = 0;
            _val = ' ';
        }


        public int getNuovoCodice()
        {
            int nuovoCodice = -1;
            string risultato = string.Empty;


            sql = "SELECT MAX(CodPrestito) AS MAXCODICE " +
                "FROM Prestiti";

            try
            {
                risultato = sqlPrestito.eseguiScalar(sql, CommandType.Text);
                nuovoCodice = Convert.ToInt32(risultato) + 1;

            }
            catch (Exception e)
            {
                MessageBox.Show("ATTENZIONE: " + e.Message);
            }

            return nuovoCodice;
        }

        public void getPrestitoFromLibro()
        {

            string risultato = String.Empty;

            /* seleziona dalla tabella inquinanti tutti gli elementi con il nome passato e li conta */
            sql = "SELECT *" +
                "FROM Prestiti " +
                "WHERE CodLibroPrestito = " + _codLibro + " AND DataResPrestito is NULL";

            try
            {
                tabellaPrestiti = sqlPrestito.eseguiQuery(sql, CommandType.Text);
                _codLettore = Convert.ToInt32(tabellaPrestiti.Rows[0].ItemArray[1]);
                _codLibro = Convert.ToInt32(tabellaPrestiti.Rows[0].ItemArray[2]);
                _dataPrestito = Convert.ToDateTime(tabellaPrestiti.Rows[0].ItemArray[3]);
                //_dataRest = Convert.ToDateTime(tabellaPrestiti.Rows[0].ItemArray[4]);
                _val = Convert.ToChar(tabellaPrestiti.Rows[0].ItemArray[5]);
            }
            catch (Exception e)
            {
                MessageBox.Show("ATTENZIONE: " + e.Message);
            }

        }


        /***************************/
        /* Recupera singola Entità */
        /***************************/
        public void getDati()
        {
            int I;

            clearDati();
            tabellaPrestiti.Clear();

            sql = "SELECT " +
                  "CodLettorePrestito,CodLibroPrestito,DataPrestito, DataResPrestito , ValPrestito " +
                  "FROM Prestiti " +
                  "WHERE CodPrestito = '" + _codice + "' ";
            try
            {
                tabellaPrestiti = sqlPrestito.eseguiQuery(sql, CommandType.Text);
                _codLettore = Convert.ToInt32(tabellaPrestiti.Rows[0].ItemArray[0]);
                _codLibro = Convert.ToInt32(tabellaPrestiti.Rows[0].ItemArray[1]);
                _dataPrestito = Convert.ToDateTime(tabellaPrestiti.Rows[0].ItemArray[2]);
                if (tabellaPrestiti.Rows[0].ItemArray[3] != DBNull.Value)
                    _dataRest = Convert.ToDateTime(tabellaPrestiti.Rows[0].ItemArray[3]);
                else
                    _dataRest = DateTime.MinValue;

                /*else
                    _dataRest = DateTime.MinValue;*/
                _val = Convert.ToChar(tabellaPrestiti.Rows[0].ItemArray[4]);
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
        public DataTable lista(char validita, bool soloNonRestituiti, int codGenere)
        {
            string strValidita = "('')";
            //string sqlParziale = string.Empty;


            tabellaPrestiti.Clear();

            if (validita == 'A')
                strValidita = "('', 'A')";

            if (soloNonRestituiti)
                sql = "SELECT * " +
                    "FROM Prestiti " +
                    "WHERE ValPrestito IN " + strValidita + " AND DataResPrestito IS NULL";
            else
                sql = "SELECT * " +
                    "FROM Prestiti " +
                    "WHERE ValPrestito IN " + strValidita;

            if (codGenere != 0)
            {
                sql += " AND CodLibroPrestito in(Select CodLibro from Libri WHERE CodGenereLibro= " + codGenere + ")";
            }

            try
            {
                tabellaPrestiti = sqlPrestito.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione !!" + e.Message);
            }

            return tabellaPrestiti;
        }

        public DataTable filtraPerGenere(int codGenere)
        {

            tabellaPrestiti.Clear();

            sql = "SELECT * " +
                "FROM Prestiti " +
                "WHERE DataResPrestito= NULL";
            try
            {
                tabellaPrestiti = sqlPrestito.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione !!" + e.Message);
            }

            return tabellaPrestiti;
        }

        public bool modifica()
        {
            bool esito = false;

            sql = "UPDATE Prestiti " +
                  "SET " +
                  "CodLettorePrestito = '" + _codLettore + "', " +
                  "CodLibroPrestito = '" + _codLibro + "', " +
                  "DataPrestito = '" + _dataPrestito.ToString("MM/dd/yyyy") + "', " +
                   "DataResPrestito = '" + _dataRest.ToString("MM/dd/yyyy") + "', " +
                  "ValPrestito = '" + _val + "' " +
                  "WHERE CodPrestito = '" + _codice + "' ";
            try
            {
                sqlPrestito.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                MessageBox.Show("Prestito modificato con successo.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione [MODIFICA]!!" + e.Message);
            }

            return esito;
        }


        public bool aggiungi()
        {
            bool esito = false;

            /* Inserisci nella tabella con questi campi questi valori */
            sql = "INSERT INTO Prestiti " +
                    "( CodLibroPrestito, CodLettorePrestito,DataPrestito,ValPrestito) " +
                    "VALUES(" + "'" + _codLibro + "'," +
                                 "'" + _codLettore + "'," +
                                  "'" + _dataPrestito.ToString("MM/dd/yyyy") + "'," +
                                "'" + _val + "')";
            try
            {
                sqlPrestito.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                MessageBox.Show("Prestito inserito con successo.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione [AGGIUNGI]!!" + e.Message);
            }



            return esito;
        }



    }
}
