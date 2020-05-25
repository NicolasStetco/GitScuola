using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class frmLettori : Form
    {
        public frmLettori()
        {
            InitializeComponent();
        }

        bool selezionaLettore = true;
        DataTable tabellaLettori = new DataTable();

        private void frmLettori_Load(object sender, EventArgs e)
        {
            selezionaLettore = false;
            elencoLettori('L');
            selezionaLettore = true;
        }

        private void chkAggiungiAnnullati_CheckedChanged(object sender, EventArgs e)
        {
            selezionaLettore = false;
            elencoLettori('K');
            selezionaLettore = true;
        }


        private void elencoLettori(char from)
        {
            clsLettore lett = new clsLettore("Biblioteca.mdf");

            if (from == 'L')
                tabellaLettori = lett.lista(' ');
            else if (chkAggiungiAnnullati.Checked == false)
                tabellaLettori = lett.lista(' ');
            else
                tabellaLettori = lett.lista('A');

            dgvElenco.DataSource = tabellaLettori;
            cmbLettori.DataSource = tabellaLettori;
            cmbLettori.ValueMember = "CodLettore";
            cmbLettori.DisplayMember = "NomeLettore" + " CognomeLettore";
            annulla();



            lett.dispose();



        }


        private void annulla()
        {
            lblCodice.Text = string.Empty;
            txtCognome.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtTessera.Text = string.Empty;
            chkAnnullaValditita.Checked = false;
            chkAnnullaValditita.Enabled = false;
            btnConferma.Text = "Aggiungi";
            cmbLettori.SelectedIndex = -1;

            grpElenco.Enabled = true;
            grpGestione.Enabled = false;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            annulla();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            grpGestione.Enabled = true;
            grpElenco.Enabled = false;

            clsLettore l = new clsLettore("Biblioteca.mdf");

            lblCodice.Text = "Codice: " + l.getNuovoCodice().ToString();
            //lblNTessera.Text = l.nuovaTessera();

            l.dispose();


            cmbLettori.SelectedIndex = -1;

            txtCognome.Focus();

        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            if (txtCognome.Text == string.Empty)
            {
                MessageBox.Show("Inserisci il cognome");
                txtCognome.Focus();
            }
            else if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Inserisci il nome");
                txtNome.Focus();
            }
            else if (txtMail.Text == string.Empty)
            {
                MessageBox.Show("Inserisci la mail");
                txtMail.Focus();
            }
            else if (!(txtMail.Text.Contains('@')))
            {
                MessageBox.Show("Inserisci la mail nel formato corretto");
                txtMail.Focus();
            }
            else if (txtTessera.Text == string.Empty)
            {
                MessageBox.Show("Inserisci il numero tessera");
                txtTessera.Focus();
            }
            else
            {
                clsLettore l = acquisciLettore();

                if (btnConferma.Text == "Aggiungi")
                {
                    l.aggiungi();
                    elencoLettori(' ');
                }
                else
                {
                    l.modifica();
                    if (chkAggiungiAnnullati.Checked == true)
                        elencoLettori('K');
                    else
                        elencoLettori('L');

                }


                l.dispose();
            }
        }



        private clsLettore acquisciLettore()
        {
            clsLettore l = new clsLettore("Biblioteca.mdf");

            l.nTessera = lblNTessera.Text;
            l.codice = Convert.ToInt32(lblCodice.Text.Substring(7));
            l.nome = txtNome.Text;
            l.cognome = txtCognome.Text;
            l.mail = txtMail.Text;
            l.nTessera = "NT2020_" + txtTessera.Text;

            if (chkAnnullaValditita.Checked == true)
                l.validita = 'A';
            else
                l.validita = ' ';


            return l;
        }

        private void cmbLettori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLettori.SelectedIndex != -1 && cmbLettori.ValueMember != "" && selezionaLettore)
            {
                clsLettore l = new clsLettore("Biblioteca.mdf");

                l.codice = Convert.ToInt32(cmbLettori.SelectedValue);
                l.getDati();

                txtNome.Text = l.nome;
                txtTessera.Text = l.nTessera.Substring(7);
                txtCognome.Text = l.cognome;
                txtMail.Text = l.mail;
                if (l.validita == 'A')
                    chkAnnullaValditita.Checked = true;

                lblCodice.Text = "Codice: " + l.codice.ToString();

                l.dispose();

                grpElenco.Enabled = false;
                grpGestione.Enabled = true;
                btnConferma.Text = "Modifica";

                chkAnnullaValditita.Enabled = true;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
