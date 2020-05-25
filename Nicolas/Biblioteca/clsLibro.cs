using System;
using System.Data;
using System.Windows.Forms;

namespace Biblioteca
{
    class clsLibro
    {
        private int _codice;
        private string _titolo;
        private string _autore;
        private int _codGenere;
        private string _codISBN;
        private string _imgLibro;
        private int _anno;
        private char _val;
        private char _prestito;


        private string sql;
        private adoNetSQL sqlLibro;
        private DataTable tabellaLibri = new DataTable();



        public int codice
        {
            get { return _codice; }
            set { _codice = value; }
        }

        public int anno
        {
            get { return _anno; }
            set { _anno = value; }
        }
        public int codGenere
        {
            get { return _codGenere; }
            set { _codGenere = value; }
        }

        public string autore
        {
            get { return _autore; }
            set { _autore = value; }
        }

        public string immagine
        {
            get { return _imgLibro; }
            set { _imgLibro = value; }
        }



        public string codISBNL
        {
            get { return _codISBN; }
            set { _codISBN = value; }
        }

        public string titolo
        {
            get { return _titolo; }
            set { _titolo = value; }
        }

        public char validita
        {
            get { return _val; }
            set { _val = value; }
        }

        public char prestato
        {
            get { return _prestito; }
            set { _prestito = value; }
        }

        public clsLibro(string nomeDB)
        {
            string pathDB = Application.StartupPath + "\\" + nomeDB;
            sqlLibro = new adoNetSQL(pathDB);
        }

        public void dispose()
        {
            sqlLibro.Dispose();
        }


        public int getNuovoCodice()
        {
            int nuovoCodice = -1;
            string risultato = string.Empty;


            sql = "SELECT MAX(CodLibro) AS MAXCODICE " +
                "FROM Libri";

            try
            {
                risultato = sqlLibro.eseguiScalar(sql, CommandType.Text);
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
            _autore = string.Empty;
            _codISBN = string.Empty;
            _titolo = string.Empty;
            _imgLibro = string.Empty;
            _prestito = ' ';
            _val = ' ';
            _anno = 0;
            _codGenere = 0;
        }



        private bool verifica()
        {
            bool esito = false;

            string risultato = String.Empty;

            /* seleziona dalla tabella inquinanti tutti gli elementi con il nome passato e li conta */
            sql = "SELECT COUNT(*) AS TOTALE " +
                "FROM Libri " +
                "WHERE UPPER(TitoloLibro) = '" + _titolo.ToUpper() + "' ";

            try
            {
                //risultato contiene il numero di record che soddisfano la condizione indicata
                //in questo caso, il numero di aziende con lo stesso nome
                risultato = sqlLibro.eseguiScalar(sql, CommandType.Text);

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
            clearDati();
            tabellaLibri.Clear();

            sql = "SELECT " +
                  "AutoreLibro, TitoloLibro,CodGenereLibro, imgLibro, CodISBNLibro,AnnoPubLibro,InPrestitoLibro,ValLibro " +
                  "FROM Libri " +
                  "WHERE CodLibro = '" + _codice + "' ";
            try
            {
                tabellaLibri = sqlLibro.eseguiQuery(sql, CommandType.Text);
                _autore = tabellaLibri.Rows[0].ItemArray[0].ToString();
                _titolo = tabellaLibri.Rows[0].ItemArray[1].ToString();
                _codGenere = Convert.ToInt32(tabellaLibri.Rows[0].ItemArray[2]);
                _imgLibro = tabellaLibri.Rows[0].ItemArray[3].ToString();
                _codISBN = tabellaLibri.Rows[0].ItemArray[4].ToString();
                _anno = Convert.ToInt32(tabellaLibri.Rows[0].ItemArray[5]);
                _prestito = Convert.ToChar(tabellaLibri.Rows[0].ItemArray[6]);
                _val = Convert.ToChar(tabellaLibri.Rows[0].ItemArray[7]);
            }
            catch (Exception e)
            {
                _codice = -1;
                MessageBox.Show("Attenzione!!" + e.Message);
            }
        }

        /**************************/
        /* Genera Lista Inquinanti*/
        /*************************/
        public DataTable lista(char validita)
        {
            string strValidita = "('')";

            tabellaLibri.Clear();

            if (validita == 'A')
                strValidita = "('', 'A')";

            sql = "SELECT * " +
                "FROM Libri " +
                "WHERE ValLibro IN " + strValidita;

            try
            {
                tabellaLibri = sqlLibro.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione !!" + e.Message);
            }

            return tabellaLibri;
        }

        public DataTable disponibili()
        {

            tabellaLibri.Clear();

            sql = "SELECT * " +
                "FROM Libri " +
                "WHERE ValLibro =' '  AND NOT InPrestitoLibro = 'P'";

            try
            {
                tabellaLibri = sqlLibro.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione !!" + e.Message);
            }

            return tabellaLibri;
        }




        public DataTable prestati()
        {


            tabellaLibri.Clear();

            sql = "SELECT DISTINCT Libri.CodLibro, Libri.TitoloLibro, Libri.AutoreLibro, Libri.CodGenereLibro, Libri.CodISBNLibro, Libri.AnnoPubLibro, Prestiti.CodPrestito, Prestiti.DataPrestito " +
               "FROM Libri INNER JOIN Prestiti " +
                "ON (Prestiti.CodLibroPrestito = Libri.CodLibro AND Prestiti.DataResPrestito IS NULL)" +
                "ORDER BY Prestiti.DataPrestito ASC";
            try
            {
                tabellaLibri = sqlLibro.eseguiQuery(sql, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione !! " + e.Message);
            }


            return tabellaLibri;
        }

        public void aggiornaPrestito(char prestato)
        {
            sql = "UPDATE Libri " +
                  "SET " +
                  " InPrestitoLibro = '" + prestato + "' " +
                  "WHERE CodLibro = '" + _codice + "' ";
            try
            {
                sqlLibro.eseguiNonQuery(sql, CommandType.Text);
                //MessageBox.Show("Libro modificato con successo.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Attenzione !!" + e.Message);
            }
        }

        /***********************************************/
        /* Modifica i dati dell'inquinante selezionato */
        /***********************************************/
        public bool modifica()
        {
            bool esito = false;

            sql = "UPDATE Libri " +
                  "SET " +
                  "AutoreLibro = '" + _autore + "', " +
                  "TitoloLibro = '" + _titolo + "', " +
                  "CodGenereLibro = '" + _codGenere + "', " +
                  "ImgLibro = '" + _imgLibro + "', " +
                  "CodISBNLibro = '" + _codISBN + "', " +
                  "AnnoPubLibro = '" + _anno + "', " +
                  "ValLibro = '" + _val + "' " +
                  "WHERE CodLibro = '" + _codice + "' ";
            try
            {
                sqlLibro.eseguiNonQuery(sql, CommandType.Text);
                esito = true;
                MessageBox.Show("Libro modificato con successo.");
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
                //_codice = getNuovoCodice();

                /* Inserisci nella tabella con questi campi questi valori */
                sql = "INSERT INTO Libri " +
                        "(AutoreLibro, TitoloLibro,CodGenereLibro, imgLibro, CodISBNLibro,AnnoPubLibro,InPrestitoLibro,ValLibro) " +
                        "VALUES(" + "'" + _autore + "'," +
                                    "'" + _titolo + "'," +
                                    " " + _codGenere + "," +
                                    "'" + _imgLibro + "'," +
                                    "'" + _codISBN + "'," +
                                    "'" + _anno + "'," +
                                    "'" + _prestito + "'," +
                                    "'" + _val + "')";
                try
                {
                    sqlLibro.eseguiNonQuery(sql, CommandType.Text);
                    esito = true;
                    MessageBox.Show("Libro inserito con successo.");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Attenzione eeeeeeeee!!" + e.Message);
                }
            }
            else
            {
                MessageBox.Show("Libro  già presente.");
            }

            return esito;
        }




    }
}
