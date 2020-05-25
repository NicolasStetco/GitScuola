using System;
using System.Data;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class frmLibri : Form
    {
        public frmLibri()
        {
            InitializeComponent();
        }

        bool selezionaLibro = true;
        DataTable tabellaLibri = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            //Specifico  la directory iniziale
            openFile.InitialDirectory = @"IMG";
            openFile.Filter = "Tutti i File (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = false;
            openFile.ShowDialog();
            //MessageBox.Show(openFile.FileName);

            //vado a prendere sottocartella e nome del file splittando il percorso globale e prendendone gli ultimi due elementi
            string[] path = openFile.FileName.Split('\\');
            string nomeFile = path[path.Length - 1];
            //MessageBox.Show(nomeFile);
            pctCopertina.ImageLocation = @"IMG\" + nomeFile;
            //MessageBox.Show(pctFoto.ImageLocation);
        }



        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            annulla();
        }

        private void annulla()
        {
            txtAutore.Text = string.Empty;
            txtISBN.Text = string.Empty;
            txtTitolo.Text = string.Empty;
            lblCodice.Text = string.Empty;
            cmbGenere.SelectedIndex = -1;
            chkAnnullaValditita.Checked = false;
            chkAnnullaValditita.Enabled = false;
            pctCopertina.ImageLocation = string.Empty;
            nmbAnno.Value = nmbAnno.Minimum;
            grpElenco.Enabled = true;
            grpGestione.Enabled = false;
            lblPrestito.Text = string.Empty;
            btnConferma.Text = "Aggiungi";
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            grpElenco.Enabled = false;
            grpGestione.Enabled = true;
            clsLibro l = new clsLibro("Biblioteca.mdf");
            lblCodice.Text = "Codice: " + l.getNuovoCodice();
            l.dispose();
        }

        private void frmLibri_Load(object sender, EventArgs e)
        {
            selezionaLibro = false;
            elencoLibri('L');
            selezionaLibro = true;

            clsGenere g = new clsGenere("Biblioteca.mdf");

            cmbGenere.DataSource = g.lista(' ');
            cmbGenere.ValueMember = "CodGenere";
            cmbGenere.DisplayMember = "NomeGenere";
            cmbGenere.SelectedIndex = -1;


            g.dispose();


        }

        private void elencoLibri(char from)
        {
            clsLibro l = new clsLibro("Biblioteca.mdf");
            if (from == 'L')
                tabellaLibri = l.lista(' ');
            else if (chkAggiungiAnnullati.Checked == true)
                tabellaLibri = l.lista('A');
            else
                tabellaLibri = l.lista(' ');


            dgvElenco.DataSource = tabellaLibri;

            cmbLibri.DataSource = tabellaLibri;
            cmbLibri.DisplayMember = "TitoloLibro";
            cmbLibri.ValueMember = "CodLibro";
            cmbLibri.SelectedIndex = -1;

            l.dispose();
            annulla();
        }

        private void cmbLibri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLibri.SelectedIndex != -1 && selezionaLibro)
            {
                clsLibro l = new clsLibro("Biblioteca.mdf");

                l.codice = Convert.ToInt32(cmbLibri.SelectedValue);
                l.getDati();
                lblCodice.Text = "Codice: " + l.codice;
                txtAutore.Text = l.autore;
                txtTitolo.Text = l.titolo;
                txtISBN.Text = l.codISBNL;
                nmbAnno.Value = Convert.ToDecimal(l.anno);
                if (l.validita == 'A')
                    chkAnnullaValditita.Checked = true;
                cmbGenere.SelectedValue = l.codGenere;
                pctCopertina.ImageLocation = @"IMG\" + l.immagine;
                if (l.prestato == 'P')
                    lblPrestito.Text = "Libro dato in prestito";

                chkAnnullaValditita.Enabled = true;

                /*
                clsGenere g = new clsGenere("Biblioteca.mdf");

                g.codice = l.codGenere;
                g.getDati();
                cmbGenere.SelectedValue = g.codice;

                g.dispose();
                */

                grpElenco.Enabled = false;
                grpGestione.Enabled = true;
                btnConferma.Text = "Modifica";

                l.dispose();
            }
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            if (controlloInput())
            {
                clsLibro l = acquisiciLibro();

                if (btnConferma.Text == "Modifica")
                {
                    l.modifica();
                    selezionaLibro = false;
                    if (chkAggiungiAnnullati.Checked == true)
                        elencoLibri('K');
                    else
                        elencoLibri('L');
                    selezionaLibro = true;
                }
                else
                {
                    l.aggiungi();
                    selezionaLibro = false;
                    elencoLibri('L');
                    selezionaLibro = true;
                }

                l.dispose();
            }
        }


        private bool controlloInput()
        {
            bool esito = true;

            if (txtTitolo.Text == string.Empty)
            {
                MessageBox.Show("Inserisci il titolo del libro");
                txtTitolo.Focus();
                esito = false;
            }
            else if (txtAutore.Text == string.Empty)
            {
                MessageBox.Show("Inserisci l'autore del libro");
                txtAutore.Focus();
                esito = false;
            }
            else if (txtISBN.Text == string.Empty)
            {
                MessageBox.Show("Inserisci il codice ISBN del libro");
                txtISBN.Focus();
                esito = false;
            }
            if (cmbGenere.SelectedIndex == -1)
            {
                MessageBox.Show("Scegli il genere del libro");
                cmbGenere.Focus();
                esito = false;
            }
            if (nmbAnno.Value == 0)
            {
                MessageBox.Show("Inserisci l'anno di pubblicazione del libro");
                nmbAnno.Focus();
                esito = false;
            }
            else if (pctCopertina.ImageLocation == string.Empty)
            {
                MessageBox.Show("Scegli la copertina del libro");
                esito = false;
            }

            return esito;
        }



        private clsLibro acquisiciLibro()
        {
            clsLibro l = new clsLibro("Biblioteca.mdf");

            l.anno = Convert.ToInt32(nmbAnno.Value);
            l.autore = txtAutore.Text;
            l.titolo = txtTitolo.Text;
            l.codISBNL = txtISBN.Text;
            l.codGenere = Convert.ToInt32(cmbGenere.SelectedValue);
            //MessageBox.Show((pctCopertina.ImageLocation).Split('\\')[1]);
            l.immagine = (pctCopertina.ImageLocation).Split('\\')[1];
            l.codice = Convert.ToInt32(lblCodice.Text.Substring(7));
            if (chkAnnullaValditita.Checked == true)
                l.validita = 'A';
            else
                l.validita = ' ';

            return l;
        }

        private void chkAggiungiAnnullati_CheckedChanged(object sender, EventArgs e)
        {
            selezionaLibro = false;
            elencoLibri('K');
            selezionaLibro = true;
        }
    }
}
