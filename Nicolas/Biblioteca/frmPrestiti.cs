using System;
using System.Data;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class frmPrestiti : Form
    {
        public frmPrestiti()
        {
            InitializeComponent();
        }

        DataTable tabellaPrestiti = new DataTable();
        DataTable lettori = new DataTable();
        DataTable libri = new DataTable();
        DataTable generi = new DataTable();
        bool selezionaPrestito = true;
        bool selezionaLibro = false;
        DataTable tabellaPrestati = new DataTable();

        private void frmPrestiti_Load(object sender, EventArgs e)
        {


            MessageBox.Show(globals.DATAGRID.Name.ToString());

            selezionaLibro = false;
            caricaComboBox('L');


            selezionaPrestito = false;
            elencoPrestiti('L');
            selezionaPrestito = true;


            //globals.DATAGRID.DataSource = tabellaPrestiti;
        }

        private void prestitiRecenti()
        {
            clsLibro l = new clsLibro("Biblioteca.mdf");
            tabellaPrestati = l.prestati();

            globals.DATAGRID.DataSource = tabellaPrestati;

            globals.COMBO.DataSource = tabellaPrestati;
            globals.COMBO.ValueMember = "CodLibro";
            globals.COMBO.DisplayMember = "CodLibro";
            globals.COMBO.SelectedIndex = -1;

            l.dispose();
        }


        private void annulla()
        {
            cmbLettore.SelectedIndex = -1;
            cmbLibro.SelectedIndex = -1;
            dtpPrestito.Value = DateTime.Now;
            dtpRestituzione.Value = DateTime.Now;
            chkRestituito.Checked = false;
            chkRestituito.Enabled = false;
            chkAnnullaValditita.Checked = false;
            chkAnnullaValditita.Enabled = false;
            pctCopertina.ImageLocation = string.Empty;
            grpElenco.Enabled = true;
            grpGestione.Enabled = false;
            dtpRestituzione.Enabled = false;
            btnConferma.Text = "Aggiungi";
            lblCodice.Text = "Codice: ";
            selezionaPrestito = true;
            selezionaLibro = false;
        }

        private clsPrestito acquisisciDati()
        {
            clsPrestito p = new clsPrestito("Biblioteca.mdf");

            p.dataPrestito = Convert.ToDateTime(dtpPrestito.Value);
            p.codLettore = Convert.ToInt32(cmbLettore.SelectedValue);
            p.codLibro = Convert.ToInt32(cmbLibro.SelectedValue);
            p.codice = Convert.ToInt32(lblCodice.Text.Substring(8));

            if (chkRestituito.Checked == true)
                p.dataRest = dtpRestituzione.Value;

            if (chkAnnullaValditita.Checked == true)
                p.validita = 'A';
            else
                p.validita = ' ';

            return p;
        }

        private void caricaComboBox(char from)
        {
            clsGenere g = new clsGenere("Biblioteca.mdf");
            generi = g.lista('A');

            cmbGenere.DataSource = generi;
            cmbGenere.ValueMember = "CodGenere";
            cmbGenere.DisplayMember = "NomeGenere";
            cmbGenere.SelectedIndex = -1;
            cmbGenere.Enabled = false;

            g.dispose();

            clsLibro libro = new clsLibro("Biblioteca.mdf");
            clsLettore lett = new clsLettore("Biblioteca.mdf");



            libri = libro.lista('A');
            lettori = lett.lista('A');

            cmbLibro.DataSource = libri;
            cmbLibro.ValueMember = "CodLibro";
            cmbLibro.DisplayMember = "TitoloLibro";
            cmbLibro.SelectedIndex = -1;

            cmbLettore.DataSource = lettori;
            cmbLettore.ValueMember = "CodLettore";
            cmbLettore.DisplayMember = "CognomeLettore";
            cmbLettore.SelectedIndex = -1;


            lett.dispose();
            libro.dispose();
        }

        private void elencoPrestiti(char from)
        {
            clsPrestito p = new clsPrestito("Biblioteca.mdf");



            if (from == 'L')
                if (chkSoloNonRestituiti.Checked == true)
                    tabellaPrestiti = p.lista(' ', true, Convert.ToInt32(cmbGenere.SelectedIndex + 1));
                else
                    tabellaPrestiti = p.lista(' ', false, Convert.ToInt32(cmbGenere.SelectedIndex + 1));
            else
            {
                if (chkAggiungiAnnullati.Checked == true)
                    if (chkSoloNonRestituiti.Checked == true)
                        tabellaPrestiti = p.lista('A', true, Convert.ToInt32(cmbGenere.SelectedIndex + 1));
                    else
                        tabellaPrestiti = p.lista('A', false, Convert.ToInt32(cmbGenere.SelectedIndex + 1));
                else if (chkSoloNonRestituiti.Checked == true)
                    tabellaPrestiti = p.lista(' ', true, Convert.ToInt32(cmbGenere.SelectedIndex + 1));
                else
                    tabellaPrestiti = p.lista(' ', false, Convert.ToInt32(cmbGenere.SelectedIndex + 1));
            }

            p.dispose();

            dgvElenco.DataSource = tabellaPrestiti;

            cmbPrestiti.DataSource = tabellaPrestiti;
            cmbPrestiti.ValueMember = "CodPrestito";
            cmbPrestiti.SelectedIndex = -1;

            annulla();
        }

        private void chkAggiungiAnnullati_CheckedChanged(object sender, EventArgs e)
        {
            selezionaPrestito = false;
            elencoPrestiti('K');
            selezionaPrestito = true;
        }

        private void chkSoloNonRestituiti_CheckedChanged(object sender, EventArgs e)
        {
            selezionaPrestito = false;
            elencoPrestiti('K');
            selezionaPrestito = true;
        }

        private void cmbGenere_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGenere.SelectedIndex != -1)
            {
                selezionaPrestito = false;
                elencoPrestiti('K');
                selezionaPrestito = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFiltraGenere.Checked == true)
                cmbGenere.Enabled = true;
            else
            {
                cmbGenere.Enabled = false;
                cmbGenere.SelectedIndex = -1;
                selezionaPrestito = false;
                elencoPrestiti('K');
                selezionaPrestito = true;
            }

        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            grpElenco.Enabled = false;
            grpGestione.Enabled = true;


            clsPrestito p = new clsPrestito("Biblioteca.mdf");

            lblCodice.Text = "Codice: " + (p.getNuovoCodice()).ToString();

            //caricaComboBox('L');

            clsLettore lett = new clsLettore("Biblioteca.mdf");
            clsLibro libro = new clsLibro("Biblioteca.mdf");

            libri = libro.disponibili();
            lettori = lett.lista(' ');

            cmbLettore.DataSource = lettori;
            cmbLettore.DisplayMember = "CognomeLettore";
            cmbLettore.ValueMember = "CodLettore";
            cmbLettore.SelectedIndex = -1;


            cmbLibro.DataSource = libri;
            cmbLibro.DisplayMember = "TitoloLibro";
            cmbLibro.ValueMember = "CodLibro";
            cmbLibro.SelectedIndex = -1;

            selezionaLibro = true;

            libro.dispose();
            lett.dispose();
            p.dispose();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            annulla();
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(lblCodice.Text.Substring(8));
            if (controllo())
            {
                clsPrestito p = acquisisciDati();
                clsLibro l = new clsLibro("Biblioteca.mdf");
                l.codice = Convert.ToInt32(cmbLibro.SelectedValue);
                if (btnConferma.Text == "Aggiungi")
                {
                    if (p.aggiungi())
                    {
                        l.aggiornaPrestito('P');
                        selezionaPrestito = false;
                        elencoPrestiti('L');
                        selezionaPrestito = false;
                    }
                }
                else
                {
                    if (p.modifica())
                    {
                        if (chkRestituito.Checked == true)
                            l.aggiornaPrestito(' ');
                        else
                            l.aggiornaPrestito('P');

                        selezionaPrestito = false;
                        elencoPrestiti('K');
                        selezionaPrestito = false;
                    }
                }

                p.dispose();
                l.dispose();
                annulla();
            }
        }

        private bool controllo()
        {
            bool esito = true;

            if (cmbLibro.SelectedIndex == -1)
            {
                MessageBox.Show("Seleziona il libro");
                cmbLibro.Focus();
                esito = false;
            }
            else if (cmbLettore.SelectedIndex == -1)
            {
                MessageBox.Show("Seleziona il lettore");
                cmbLettore.Focus();
                esito = false;
            }
            else if (dtpPrestito.Value > dtpRestituzione.Value)
            {
                MessageBox.Show("Date non valide");
                dtpRestituzione.Focus();
                esito = false;
            }

            return esito;
        }

        private void cmbPrestiti_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(tabellaPrestiti.Rows.ToString());
            if (selezionaPrestito && cmbPrestiti.SelectedIndex != -1 && cmbPrestiti.ValueMember != "")
            {
                grpElenco.Enabled = false;
                grpGestione.Enabled = true;

                selezionaLibro = true;

                btnConferma.Text = "Modifica";

                chkAnnullaValditita.Enabled = true;

                clsPrestito p = new clsPrestito("Biblioteca.mdf");


                p.codice = Convert.ToInt32(cmbPrestiti.SelectedValue);
                p.getDati();

                caricaComboBox('k');

                if (p.validita == 'A')
                    chkAnnullaValditita.Checked = true;

                dtpPrestito.Value = p.dataPrestito;
                cmbLettore.SelectedValue = p.codLettore;
                cmbLibro.SelectedValue = p.codLibro;
                lblCodice.Text = "Codice: " + p.codice;

                clsLibro l = new clsLibro("Biblioteca.mdf");

                l.codice = p.codLibro;
                l.getDati();
                pctCopertina.ImageLocation = @"IMG\\" + l.immagine;

                l.dispose();

                if (p.dataRest != DateTime.MinValue)
                {
                    dtpRestituzione.Value = p.dataRest;
                    chkRestituito.Checked = true;
                    dtpRestituzione.Enabled = true;
                }
                else
                {
                    chkRestituito.Checked = false;
                    chkRestituito.Enabled = true;
                }
                p.dispose();
            }
        }

        private void chkRestituito_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRestituito.Checked == true)
                dtpRestituzione.Enabled = true;
            else
                dtpRestituzione.Enabled = false;
        }

        private void cmbLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLibro.SelectedIndex != -1 && selezionaLibro)
            {
                clsLibro l = new clsLibro("Biblioteca.mdf");

                //MessageBox.Show(cmbLibro.SelectedValue.ToString());

                l.codice = Convert.ToInt32(cmbLibro.SelectedValue);
                l.getDati();
                pctCopertina.ImageLocation = @"IMG\\" + l.immagine;

                l.dispose();
            }
        }

        private void btnConferma_Click_1(object sender, EventArgs e)
        {
            if (controllo())
            {
                clsPrestito p = acquisisciDati();
                clsLibro l = new clsLibro("Biblioteca.mdf");
                l.codice = Convert.ToInt32(cmbLibro.SelectedValue);
                if (btnConferma.Text == "Aggiungi")
                {
                    if (p.aggiungi())
                    {
                        l.aggiornaPrestito('P');
                        selezionaPrestito = false;
                        elencoPrestiti('L');
                        selezionaPrestito = false;
                    }
                }
                else
                {
                    if (p.modifica())
                    {
                        if (chkRestituito.Checked == true)
                            l.aggiornaPrestito(' ');
                        else
                            l.aggiornaPrestito('P');

                        selezionaPrestito = false;
                        elencoPrestiti('K');
                        selezionaPrestito = false;
                    }
                }

                p.dispose();
                l.dispose();
                annulla();
                prestitiRecenti();
            }
        }

        private void chkRestituito_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkRestituito.Checked == true)
                dtpRestituzione.Enabled = true;
            else
                dtpRestituzione.Enabled = false;
        }

        private void cmbPrestiti_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (selezionaPrestito && cmbPrestiti.SelectedIndex != -1 && cmbPrestiti.ValueMember != "")
            {
                grpElenco.Enabled = false;
                grpGestione.Enabled = true;

                selezionaLibro = true;

                btnConferma.Text = "Modifica";

                chkAnnullaValditita.Enabled = true;

                clsPrestito p = new clsPrestito("Biblioteca.mdf");


                p.codice = Convert.ToInt32(cmbPrestiti.SelectedValue);
                p.getDati();

                caricaComboBox('k');

                if (p.validita == 'A')
                    chkAnnullaValditita.Checked = true;

                dtpPrestito.Value = p.dataPrestito;
                cmbLettore.SelectedValue = p.codLettore;
                cmbLibro.SelectedValue = p.codLibro;
                lblCodice.Text = "Codice: " + p.codice;

                clsLibro l = new clsLibro("Biblioteca.mdf");

                l.codice = p.codLibro;
                l.getDati();
                pctCopertina.ImageLocation = @"IMG\\" + l.immagine;

                l.dispose();

                if (p.dataRest != DateTime.MinValue)
                {
                    dtpRestituzione.Value = p.dataRest;
                    chkRestituito.Checked = true;
                    dtpRestituzione.Enabled = true;
                }
                else
                {
                    chkRestituito.Checked = false;
                    chkRestituito.Enabled = true;
                }
                p.dispose();
            }
        }
    }
}
