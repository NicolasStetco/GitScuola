using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inquinamento
{
    public partial class Form1 : Form
    {

        //==============================================================================================================================================================================
        //*************************************************                      GESTIONE AZIENDE                    *******************************************************************
        //==============================================================================================================================================================================


        DataTable tabellaAziende = new DataTable();
        bool selezionaAziende = true;

        public Form1()
        {
            InitializeComponent();
        }

        /********************/
        /* Routine Iniziale */
        /********************/
        private void Form1_Load(object sender, EventArgs e)
        {
            // Recupero Aziende
            selezionaAziende = false;
            elencoAziende('L');
            selezionaAziende = true;
        }

        /******************/
        /* Elenco Aziende */
        /******************/
        private void elencoAziende(char tipo)
        {
            // Gestione dei Dati delle AZIENDE
            clsAzienda azienda = new clsAzienda("Inquinamento.mdf");

            // Recupero le Azienda dal DB
            if (tipo == 'L')
                // Da Form Load
                tabellaAziende = azienda.lista(' ');
            else
                // Da CHK Annullate
                if (chkAziendeAnnullate.Checked)
                    tabellaAziende = azienda.lista('A');
                else
                    tabellaAziende = azienda.lista(' ');

            // carico le Aziende sulla comboBox
            cmbAziende.DataSource = tabellaAziende;
            cmbAziende.DisplayMember = "NomeAzienda";
            cmbAziende.ValueMember = "CodAzienda";
            cmbAziende.SelectedIndex = -1;

            // Carico le Aziende sulla DGV
            dgvAziende.DataSource = tabellaAziende;
            dgvAziende.ClearSelection();

            azienda.Dispose();
        }

        /*****************************/
        /* Abilita Aziende Annullate */
        /*****************************/
        private void chkAnnullate_CheckedChanged(object sender, EventArgs e)
        {
            // Recupero Aziende
            selezionaAziende = false;
            elencoAziende('K');
            selezionaAziende = true;
        }

        /********************************************/
        /* Abilita l' Aggiunta di una Nuova Azienda */
        /********************************************/
        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            // Abilito/Disabilito i GRP
            grpElenco.Enabled = false;
            grpDatiAzienda.Enabled = true;

            // Imposto il Nuovo Codice Azienda
            clsAzienda azienda = new clsAzienda("Inquinamento.mdf");
            lblCodice.Text = azienda.getNuovoCodice();
            azienda.Dispose();

            txtNome.Focus();
            chkAnnulla.Enabled = false;
            chkAziendeAnnullate.Enabled = false;

        }

        /*****************************/
        /* Annullo Ultima Operazione */
        /*****************************/
        private void btnAnnulla_Click(object sender, EventArgs e)
        {

            // Pulizia Dati Azienda
            pulisciAzienda();

            // Abilito/Disabilito i GRP
            grpElenco.Enabled = true;
            grpDatiAzienda.Enabled = false;

            btnConferma.Text = "Conferma";

            cmbAziende.SelectedIndex = -1;
            dgvAziende.ClearSelection();

        }

        /************************/
        /* Pulizia Dati Azienda */
        /************************/
        private void pulisciAzienda()
        {
            lblCodice.Text = string.Empty;
            txtNome.Text = string.Empty;
            numUDGrado.Value = 1;
            txtCitta.Text = string.Empty;
            chkAnnulla.Checked = false;
        }

        /***********************/
        /* Confermo Operazione */
        /***********************/
        private void btnConferma_Click(object sender, EventArgs e)
        {
            bool esito = false;

            // Controllo Input Dati
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Non è stato inserito il Nome Azienda.");
                txtNome.Focus();
            }
                
            else if (txtCitta.Text == string.Empty)
            {
                MessageBox.Show("Non è stata inserita la Città.");
                txtCitta.Focus();
            }
            else
            {
                // Inserimento Dati sul DB
                clsAzienda azienda = new clsAzienda("Inquinamento.mdf");

                // Nonè necessario inserire il Campo Codice (SOLO x INSERT !!!)
                azienda.NomeAzienda = txtNome.Text;
                azienda.GradoAzienda = Convert.ToUInt16(numUDGrado.Value);
                azienda.CittaAzienda = txtCitta.Text;
                azienda.ValAzienda = ' ';

                // Eseguo l'Operazione in base alla scelta dell' Utente
                if (btnConferma.Text == "Conferma")
                    // Eseguo INSERT dell' Azienda
                    esito = azienda.aggiungi();
                else
                {
                    azienda.CodAzienda = lblCodice.Text;
                    if (chkAnnulla.Checked)
                        // Eseguo la CANCELLAZIONE dell' Azienda
                        esito = azienda.cancella();
                    else
                        // Eseguo la VARIAZIONE dell' Azienda
                        esito = azienda.modifica();
                }

                // Contro esito Operazione
                if (esito)
                {
                    // Pulizia Dati Azienda
                    pulisciAzienda();

                    // Abilito/Disabilito i GRP
                    grpElenco.Enabled = true;
                    grpDatiAzienda.Enabled = false;

                    btnConferma.Text = "Conferma";

                    // Recupero Aziende
                    selezionaAziende = false;
                    elencoAziende('L');
                    selezionaAziende = true;

                }

                azienda.Dispose();
            }
                

        }
        
        private void dgvAziende_SelectionChanged(object sender, EventArgs e)
        {
            // --
        }

        private void cmbAziende_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codAzienda = string.Empty;
            // Controllo selezione effettiva dell'Azienda
            if (cmbAziende.SelectedIndex != -1 && 
                cmbAziende.ValueMember != "" && selezionaAziende)
            {
                codAzienda = cmbAziende.SelectedValue.ToString(); 
                // Richiamo Seleziona singola Azienda
                selezionaAzienda(codAzienda);
            }

        }

        /*****************************/
        /* Seleziona singola Azienda */
        /*****************************/
        private void selezionaAzienda(string cAzi)
        {

            clsAzienda azienda = new clsAzienda("Inquinamento.mdf");

            // Recupero di dati dell' Azienda
            azienda.CodAzienda = cAzi;
            azienda.getDati();

            // Carico i Dati solo se non ho Errori
            if (azienda.CodAzienda != null)
            {
                // Carico i Dati a Video con quelle recuperati dall'Azienda
                lblCodice.Text = azienda.CodAzienda;
                txtNome.Text = azienda.NomeAzienda;
                numUDGrado.Value = azienda.GradoAzienda;
                txtCitta.Text = azienda.CittaAzienda;
                if (azienda.ValAzienda == 'A')
                    chkAnnulla.Checked = true;

                // Abilito/Disabilito i GRP
                grpElenco.Enabled = false;
                grpDatiAzienda.Enabled = true;

                btnConferma.Text = "Modifica";
            }

            azienda.Dispose();

        }

        //==============================================================================================================================================================================
        //*************************************************                 FINE GESTIONE AZIENDE               ************************************************************************
        //==============================================================================================================================================================================








        DataTable tabellaInquinanti = new DataTable();
        bool selezionaInquinanti;




        private void caricaInquinanti( char from)
        {
            clsInquinante inq = new clsInquinante("Inquinamento.mdf");

            //recupero Inquinanti dal DB
            if(from == 'L')
                //dal from.Load() recupero solo gli inquinanti validi
                tabellaInquinanti = inq.lista(' ');
            else
                //dal checkBoxInquinantiAnnullati recupero TUTTI gli inquinanti se è spuntato
                if (chkInquinantiAnnullati.Checked)
            {
                tabellaInquinanti = inq.lista('A');
                //MessageBox.Show("Feeeeega");
            }
                
            else
                tabellaInquinanti = inq.lista(' ');

            //carico la comboBox
            cmbInquinanti.DataSource = tabellaInquinanti;
            cmbInquinanti.DisplayMember = "NomeInquinante";
            cmbInquinanti.ValueMember = "CodInquinante";
            cmbInquinanti.SelectedIndex = -1;

            // Carico gli inquinamenti sulla DGV
            dgvInquinanti.DataSource = tabellaInquinanti;
            dgvInquinanti.ClearSelection();

            inq.Dispose();
        }

        private void switchInquinanti(object sender, EventArgs e)
        {
            //MessageBox.Show("ABBATEEEE");

            selezionaInquinanti = false;
            caricaInquinanti('L');
            selezionaInquinanti = true;
        }

        private void chkInquinantiAnnullati_CheckedChanged(object sender, EventArgs e)
        {
            selezionaInquinanti = false;
            caricaInquinanti('K');
            selezionaInquinanti = true;
        }

    }
}
