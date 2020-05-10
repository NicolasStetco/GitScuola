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

            btnConfermaAziende.Text = "Conferma";

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
                if (btnConfermaAziende.Text == "Conferma")
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

                    btnConfermaAziende.Text = "Conferma";

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

                btnConfermaAziende.Text = "Modifica";
            }

            azienda.Dispose();

        }

        //==============================================================================================================================================================================
        //*************************************************                 FINE GESTIONE AZIENDE               ************************************************************************
        //==============================================================================================================================================================================








        //==============================================================================================================================================================================
        //*************************************************                      GESTIONE INQUINANTI                    ****************************************************************
        //==============================================================================================================================================================================

        DataTable tabellaInquinanti = new DataTable();
        bool selezionaInquinante = true;

        /********************/
        /* Routine Iniziale */
        /********************/
        private void switchInquinanti(object sender, EventArgs e)
        {
            // Recupero Aziende
            selezionaInquinante = false;
            elencoInquinanti('L');
            selezionaInquinante = true;

            string[] stati = new string[3];
            stati[0] = "Solido";
            stati[1] = "Liquido";
            stati[2] = "Gassoso";
            cmbStato.DataSource = stati;
            cmbStato.SelectedIndex = -1;

        }

        /******************/
        /* Elenco inquinanti */
        /******************/
        private void elencoInquinanti(char from)
        {
            // Gestione dei Dati degli INQUINANTI
            clsInquinante inq = new clsInquinante("Inquinamento.mdf");

            if (from == 'L')
                tabellaInquinanti = inq.lista(' ');
            else if(chkAggiungiInquinantiAnnullati.Checked==true)
                tabellaInquinanti = inq.lista('A');
            else
                tabellaInquinanti = inq.lista(' ');

            cmbInquinanti.DataSource = tabellaInquinanti;
            cmbInquinanti.ValueMember = "CodInquinante";
            cmbInquinanti.DisplayMember = "NomeInquinante";
            cmbInquinanti.SelectedIndex = -1;

            dgvInquinanti.DataSource = tabellaInquinanti;

            annulla_Inquinanti();

            inq.Dispose();
        }

        /*****************************/
        /* Abilita Aziende Annullate */
        /*****************************/
        private void chkInquinantiAnnullati(object sender, EventArgs e)
        {
            // Recupero Aziende
            selezionaInquinante = false;
            elencoInquinanti('K');
            selezionaInquinante = true;

        }

        private void annulla_Inquinanti()
        {
            txtNomeInquinante.Text = string.Empty;
            txtCittaInquinante.Text = string.Empty;
            chkAnnullaValInquinante.Checked = false;
            grpElencoInquinanti.Enabled = true;
            grpModificaInquinanti.Enabled = false;
            btnConfermaModifica.Text = "Aggiungi";
            nmbPesoSpecifico.Value = 0;
            cmbStato.SelectedIndex = -1;
            lblCodInquinante.Text = string.Empty;
        }

        /********************************************/
        /* Abilita l' Aggiunta di una Nuova Azienda */
        /********************************************/

        /*****************************/
        /* Annullo Ultima Operazione */
        /*****************************/
        private void btnAnnullaInquinamenti_Click(object sender, EventArgs e)
        {
            annulla_Inquinanti();
        }

        /************************/
        /* Pulizia Dati Azienda */
        /************************/


        /***********************/
        /* Confermo Operazione */
        /***********************/
        private void btnConfermaModifica_Click(object sender, EventArgs e)
        {
            bool esito = false;

            // Controllo Input Dati
            if (txtNomeInquinante.Text == string.Empty)
            {
                MessageBox.Show("Non è stato inserito il Nome dell'inquinante.");
                txtNomeInquinante.Focus();
            }

            else if (txtCittaInquinante.Text == string.Empty)
            {
                MessageBox.Show("Non è stata inserita la Città.");
                txtCitta.Focus();
            }
            else if (cmbStato.SelectedIndex == -1)
            {
                MessageBox.Show("Seleziona lo stato dell'inquinante");
            }
            else
            {
                // Inserimento Dati sul DB
                clsInquinante inq = acquisisciInquinante();

               

                // Eseguo l'Operazione in base alla scelta dell' Utente
                if (btnConfermaModifica.Text == "Aggiungi")
                {
                    // Eseguo INSERT dell' Azienda
                    inq.aggiungi();
                    selezionaInquinante = false;
                    elencoInquinanti('k');
                    selezionaInquinante = true;
                }
                else
                {
                    inq.modifica();
                    selezionaInquinante = false;
                    elencoInquinanti('k');
                    selezionaInquinante = true;
                }

                


                inq.Dispose();
            }


        }

        private clsInquinante acquisisciInquinante()
        {
            // Nonè necessario inserire il Campo Codice (SOLO x INSERT !!!)

            clsInquinante inq = new clsInquinante("Inquinamento.mdf");

            inq.nomeInquinante = txtNomeInquinante.Text;
            inq.pesoSpecifico = Convert.ToUInt16(nmbPesoSpecifico.Value);
            inq.citta = txtCittaInquinante.Text;
            if (chkAnnullaValInquinante.Checked == true)
                inq.validita = 'A';
            else
                inq.validita = ' ';

            inq.codice = lblCodInquinante.Text;
            switch (cmbStato.SelectedItem)
            {
                case "Solido":
                    inq.stato = 'S';
                    break;

                case "Liquido":
                    inq.stato = 'L';
                    break;

                case "Gassoso":
                    inq.stato = 'G';
                    break;
            }
            return inq;
        }

        private void cmbInquinanti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInquinanti.SelectedIndex != -1 && cmbInquinanti.ValueMember!= ""&&selezionaInquinante)
            {

                grpElencoInquinanti.Enabled = false;
                grpModificaInquinanti.Enabled=true;
                chkAnnullaValInquinante.Enabled = true;
                btnConfermaModifica.Text = "Modifica";

                clsInquinante inquinante = new clsInquinante("Inquinamento.mdf");
                inquinante.codice = cmbInquinanti.SelectedValue.ToString();
                inquinante.getDati();
                lblCodInquinante.Text = inquinante.codice;
                txtNomeInquinante.Text = inquinante.nomeInquinante;
                nmbPesoSpecifico.Value = inquinante.pesoSpecifico;
                txtCittaInquinante.Text = inquinante.citta;
                if (inquinante.validita == 'A')
                    chkAnnullaValInquinante.Checked = true;
                else
                    chkAnnullaValInquinante.Checked = false;
                switch (inquinante.stato)
                {
                    case 'S':
                        cmbStato.SelectedIndex = 0;
                        break;

                    case 'L':
                        cmbStato.SelectedIndex = 1;
                        break;

                    case 'G':
                        cmbStato.SelectedIndex = 2;
                        break;
                }


                inquinante.Dispose();
            }
        }

       

        private void btnAggiungiinquinante_Click_1(object sender, EventArgs e)
        {
            // Abilito/Disabilito i GRP
            grpElencoInquinanti.Enabled = false;
            grpModificaInquinanti.Enabled = true;

            // Imposto il Nuovo Codice Azienda
            clsInquinante inquinante = new clsInquinante("Inquinamento.mdf");
            lblCodInquinante.Text = inquinante.getNuovoCodice();
            inquinante.Dispose();

            txtNomeInquinante.Focus();
            chkAnnullaValInquinante.Enabled = false;
            //chkInquinantiAnnullati.Enabled = false;
        }

        private void chkAggiungiInquinantiAnnullati_CheckedChanged(object sender, EventArgs e)
        {
            selezionaInquinante = false;
            elencoInquinanti('K');
            selezionaInquinante = true;
        }





        //==============================================================================================================================================================================
        //*************************************************                 FINE GESTIONE AZIENDE               ************************************************************************
        //==============================================================================================================================================================================





        //==============================================================================================================================================================================
        //*************************************************                      GESTIONE PRODOTTI                    ******************************************************************
        //==============================================================================================================================================================================

        DataTable tabellaProdotti = new DataTable();

        private void loadProdotti(object sender, EventArgs e)
        {
            //MessageBox.Show("gino");
            elencoProdotti('L');
        }


        private void elencoProdotti(char from)
        {
            clsProdotto prodotto = new clsProdotto("Inquinamento.mdf");

            if (from == 'L')
                tabellaProdotti = prodotto.lista(' ');
            else if (chkAggiungiAnnullateProdotti.Checked == true)
                tabellaProdotti = prodotto.lista('A');
            else
                tabellaProdotti = prodotto.lista(' ');

            cmbProdotti.DataSource = tabellaProdotti;
            cmbProdotti.DisplayMember = "NomeProdotto";
            cmbProdotti.ValueMember = "CodProdotto";
            cmbProdotti.SelectedIndex = -1;


            dgvProdotti.DataSource = tabellaProdotti;

            prodotto.Dispose();

            annulla_Prodotti();
        }

        private void btnAnnullaProdotti_Click(object sender, EventArgs e)
        {
            annulla_Prodotti();
        }

        private void annulla_Prodotti()
        {
            txtNomeProdotto.Text = string.Empty;
            txtCittaProdotti.Text = string.Empty;
            chkAnnullaValProdotto.Checked = false;
            grpElencoProdotti.Enabled = true;
            grpGestioneProdotti.Enabled = false;
            lblCodiceProdotto.Text = string.Empty;
            btnConfermaProdotti.Text = "Aggiungi";
        }

        private void btnAggiungiProdotto_Click(object sender, EventArgs e)
        {
            grpElencoProdotti.Enabled = false;
            grpGestioneProdotti.Enabled = true;
            cmbProdotti.SelectedIndex = -1;
            txtNomeProdotto.Focus();
            chkAnnullaValProdotto.Enabled = false;

            clsProdotto prodotto = new clsProdotto("Inquinamento.mdf");
            lblCodiceProdotto.Text = prodotto.getNuovoCodice();
            prodotto.Dispose();

        }

        private void btnConfermaProdotti_Click(object sender, EventArgs e)
        {
            if (txtNomeProdotto.Text == string.Empty)
                MessageBox.Show("Inserisci il nome del prodotto");
            else if (txtCittaProdotti.Text == string.Empty)
                MessageBox.Show("Inserisci la città del prodotto");
            else
            {
                clsProdotto prodotto = acquisisciProdotto();
                //MessageBox.Show(prodotto.citta);

                if (btnConfermaProdotti.Text == "Aggiungi")
                {
                    //MessageBox.Show("gino");
                    prodotto.aggiungi();
                    elencoProdotti('L');
                }
                else
                {
                    prodotto.modifica();
                    elencoProdotti('K');
                }

                prodotto.Dispose();
            }


        }


        private void chkAggiungiAnnullateProdotti_CheckedChanged(object sender, EventArgs e)
        {
            elencoProdotti('K');
        }

        private clsProdotto acquisisciProdotto()
        {
            clsProdotto prodotto = new clsProdotto("Inquinamento.mdf");

            prodotto.codice = lblCodiceProdotto.Text;
            prodotto.nome = txtNomeProdotto.Text;
            prodotto.citta = txtCittaProdotti.Text;
            if (chkAnnullaValProdotto.Checked == true)
                prodotto.validita = 'A';
            else
                prodotto.validita = ' ';

            return prodotto;
        }

        private void cmbProdotti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProdotti.SelectedIndex != -1&& cmbProdotti.ValueMember!="")
            {
                grpElencoProdotti.Enabled = false;
                grpGestioneProdotti.Enabled = true;
                chkAnnullaValProdotto.Enabled = true;
                btnConfermaProdotti.Text = "Modifica";


                clsProdotto prodotto = new clsProdotto("Inquinamento.mdf");
                prodotto.codice = cmbProdotti.SelectedValue.ToString();
                //MessageBox.Show(prodotto.codice);
                prodotto.getDati();
                lblCodiceProdotto.Text = prodotto.codice;
                txtNomeProdotto.Text = prodotto.nome;
                txtCittaProdotti.Text = prodotto.citta;
                if (prodotto.validita == 'A')
                    chkAnnullaValProdotto.Checked = true;
                prodotto.Dispose();
            }
        }



        //==============================================================================================================================================================================
        //*************************************************                 FINE GESTIONE PRODOTTI               ***********************************************************************
        //==============================================================================================================================================================================



        //==============================================================================================================================================================================
        //*************************************************                 INIZIO GESTIONE SCARICHI               *********************************************************************
        //==============================================================================================================================================================================
        DataTable tabellaScarichi = new DataTable();
        bool selezionaScarico = true;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbScarichi.SelectedIndex != -1 && cmbScarichi.ValueMember != ""&&selezionaScarico)
            {
                //...
                clsScarico s = new clsScarico("Inquinamento.mdf");

                s.codiceScarico = cmbScarichi.SelectedValue.ToString();
                //MessageBox.Show(s.codiceScarico);
                s.getDati();
                //MessageBox.Show(s.codAzienda);
                /*
                clsAzienda a= new clsAzienda("Inquinamento.mdf");
                a.CodAzienda = s.codAzienda;
                a.getDati();
                clsInquinante i= new clsInquinante("Inquinamento.mdf");
                i.codice = s.codInquinante;
                i.getDati();
                clsProdotto p= new clsProdotto("Inquinamento.mdf");
                p.codice = s.codProdotto;
                p.getDati();

                
                cmbCodAzienda.SelectedItem = a.NomeAzienda;
                cmbCodInq.SelectedItem = i.nomeInquinante;
                cmbCodProd.SelectedItem = p.nome;
                */
                lblCodiceScarico.Text = s.codiceScarico;
                cmbCodAzienda.SelectedValue = s.codAzienda;
                cmbCodInq.SelectedValue = s.codInquinante;
                cmbCodProd.SelectedValue = s.codProdotto;
                

                if (s.validita == 'A')
                    chkAnnullaValScarico.Checked = true;
                lblCodiceScarico.Text = s.codiceScarico;
                nmbQuantita.Value = s.quantita;

                s.Dispose();
                /*
                a.Dispose();
                i.Dispose();
                p.Dispose();*/


                grpElencoScarichi.Enabled = false;
                GrpModificaScarichi.Enabled = true;
                chkAnnullaValScarico.Enabled = true;

                btnConferma_Scarico.Text = "Modifica";

            }
        }

        private void loadScarichi(object sender, EventArgs e)
        {
            //MessageBox.Show("gino");
            selezionaScarico = false;
            elencoScarichi('L');
            selezionaScarico = true;
            caricaComboBox();

        }

        private void annulla_Scarichi()
        {
            grpElencoScarichi.Enabled = true;
            GrpModificaScarichi.Enabled = false;
            chkAnnullaValScarico.Checked = false;
            cmbCodAzienda.SelectedIndex = -1;
            cmbCodInq.SelectedIndex = -1;
            cmbCodProd.SelectedIndex = -1;
            nmbQuantita.Value = 0;
            btnConferma_Scarico.Text = "Aggiungi";
            lblCodiceScarico.Text = string.Empty;
        }

        private void btnAggiungiScarico_Click(object sender, EventArgs e)
        {
            grpElencoScarichi.Enabled = false;
            GrpModificaScarichi.Enabled = true;
            chkAnnullaValScarico.Enabled = false;

            clsScarico s = new clsScarico("Inquinamento.mdf");
            lblCodiceScarico.Text = s.getNuovoCodice();
            s.Dispose();
        }

        private void btnAnnulla_Scarico_Click(object sender, EventArgs e)
        {
            annulla_Scarichi();
        }


        private void elencoScarichi(char from)
        {
            clsScarico scarico = new clsScarico("Inquinamento.mdf");

            if (from == 'L')
                tabellaScarichi = scarico.lista(' ');
            else if (chkAggiungiScarichiAnnullati.Checked == true)
                tabellaScarichi = scarico.lista('A');
            else
                tabellaScarichi = scarico.lista(' ');

            

            cmbScarichi.DataSource = tabellaScarichi;
            cmbScarichi.DisplayMember = "CodScarico";
            cmbScarichi.ValueMember = "CodScarico";
            cmbScarichi.SelectedIndex = -1;

            dgvScarichi.DataSource = tabellaScarichi;

            scarico.Dispose();

            annulla_Scarichi();

        }

        private void chkAggiungiScarichiAnnullati_CheckedChanged(object sender, EventArgs e)
        {
            selezionaScarico = false;
            elencoScarichi('K');
            selezionaScarico = true;
        }

        private void caricaComboBox()
        {

            //recupero le aziende 
            clsAzienda azi = new clsAzienda("Inquinamento.mdf");

            DataTable tabAziende = azi.lista(' ');
           
            //inserisco nelle comboBox i nomi delle entità
            cmbCodAzienda.DataSource = tabAziende;
            cmbCodAzienda.ValueMember = "CodAzienda";
            cmbCodAzienda.DisplayMember = "NomeAzienda";
            cmbCodAzienda.SelectedIndex = -1;

            azi.Dispose();

            //recuperocgli inquinanti
            clsInquinante inq = new clsInquinante("Inquinamento.mdf");

            DataTable tabInq = inq.lista(' ');

            //inserisco nelle comboBox i nomi delle entità
            cmbCodInq.DataSource = tabInq;
            cmbCodInq.ValueMember = "CodInquinante";
            cmbCodInq.DisplayMember = "NomeInquinante";
            cmbCodInq.SelectedIndex = -1;

            inq.Dispose();

            //recupero i prodotti 
            clsProdotto prod = new clsProdotto("Inquinamento.mdf");

            DataTable tabProd = prod.lista(' ');

            //inserisco nelle comboBox i nomi delle entità
            cmbCodProd.DataSource = tabProd;
            cmbCodProd.ValueMember = "CodProdotto";
            cmbCodProd.DisplayMember = "NomeProdotto";
            cmbCodProd.SelectedIndex = -1;

            prod.Dispose();
        }

        private void cmbCodAzienda_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cmbCodAzienda.SelectedIndex!=-1) MessageBox.Show(cmbCodAzienda.SelectedValue.ToString());
        }

        private void btnConferma_Scarico_Click(object sender, EventArgs e)
        {
            //controllo campi di input
            if (cmbCodAzienda.SelectedIndex == -1)
                MessageBox.Show("Seleziona l'azienda");
            else if (cmbCodInq.SelectedIndex == -1)
                MessageBox.Show("Seleziona l'inquinante");
            else if (cmbCodProd.SelectedIndex == -1)
                MessageBox.Show("Seleziona il prodotto");
            else if (nmbQuantita.Value==0)
                MessageBox.Show("Inserisci la quantità");
            else
            {
                clsScarico s= acquisisciScarico();

                if(btnConferma_Scarico.Text=="Aggiungi")
                {
                    s.aggiungi();
                    selezionaScarico = false;
                    elencoScarichi('L');
                    selezionaScarico = true;
                }
                else if (chkAnnullaValScarico.Checked == true)
                {
                    s.modifica();
                    selezionaScarico = false;
                    elencoScarichi('K');
                    selezionaScarico = true;
                }
                else
                {
                    s.modifica();
                    selezionaScarico = false;
                    elencoScarichi('L');
                    selezionaScarico = true;
                }

                s.Dispose();
                
            }
        }


        private clsScarico acquisisciScarico()
        {
            clsScarico scarico = new clsScarico("Inquinamento.mdf");

            scarico.codiceScarico = lblCodiceScarico.Text;
            scarico.quantita = Convert.ToInt32(nmbQuantita.Value);
            if(chkAnnullaValScarico.Checked==false)
                scarico.validita = ' ';
            else
                scarico.validita = 'A';
            scarico.codAzienda = cmbCodAzienda.SelectedValue.ToString();
            scarico.codInquinante = cmbCodInq.SelectedValue.ToString();
            scarico.codProdotto = cmbCodProd.SelectedValue.ToString();


            return scarico;
        }

        //==============================================================================================================================================================================
        //*************************************************                 FINE GESTIONE SCARICHI               ***********************************************************************
        //==============================================================================================================================================================================
    }
}