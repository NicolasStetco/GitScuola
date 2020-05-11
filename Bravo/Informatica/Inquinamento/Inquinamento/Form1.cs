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

        DataTable tabella = new DataTable();
        bool seleziona;
        public Form1()
        {
            InitializeComponent();
        }

        /********************/
        /* Routine Iniziale */
        /********************/
        private void Form1_Load(object sender, EventArgs e)
        {
            seleziona = false;
            elencoAziende('L');
            elencoInquinanti('L');
            elencoProdotti('L');
            elencoScarichi('L');
            seleziona = true;
        }

        /******************/
        /* Elenco Aziende */
        /******************/
        private void elencoAziende(char tipo)
        {
            // Gestione dei Dati delle AZIENDE
            clsAzienda azienda = new clsAzienda("Inquinamento.mdf");

            // Recupero le Azienda dal DB
            if (tipo=='L')
            {
                tabella = azienda.lista(' ');
            }
            else
            {
                if (chkAnnullate.Checked)
                {
                    tabella = azienda.lista('A');
                }
                else
                {
                    tabella = azienda.lista(' ');
                }
            }
            // carico le Aziende sulla comboBox
            cmbAziende.DataSource = tabella;
            cmbAziende.DisplayMember = "NomeAzienda";
            cmbAziende.ValueMember = "CodAzienda";
            cmbAziende.SelectedIndex = -1;

            // Carico le Aziende sulla DGV
            dgvAziende.DataSource = tabella;
            dgvAziende.ClearSelection();
            
            azienda.Dispose();
        }
        private void elencoInquinanti(char tipo)
        {
            // Gestione dei Dati delle AZIENDE
            clsInquinante inquinante = new clsInquinante("Inquinamento.mdf");

            // Recupero le Azienda dal DB
            if (tipo == 'L')
            {
                tabella = inquinante.lista(' ');
            }
            else
            {
                if (chkAnnullatiInquinanti.Checked)
                {
                    tabella = inquinante.lista('A');
                }
                else
                {
                    tabella = inquinante.lista(' ');
                }
            }

            // carico le Aziende sulla comboBox
            cmbInquinante.DataSource = tabella;
            cmbInquinante.DisplayMember = "NomeInquinante";
            cmbInquinante.ValueMember = "CodInquinante";
            cmbInquinante.SelectedIndex = -1;

            // Carico le Aziende sulla DGV
            dgvInquinanti.DataSource = tabella;
            dgvInquinanti.ClearSelection();

            inquinante.Dispose();
        }
        private void elencoProdotti(char tipo)
        {
            // Gestione dei Dati delle AZIENDE
            clsProdotto prodotto = new clsProdotto("Inquinamento.mdf");

            // Recupero le Azienda dal DB
            if (tipo == 'L')
            {
                tabella = prodotto.lista(' ');
            }
            else
            {
                if (chkProdottiAnnullati.Checked)
                {
                    tabella = prodotto.lista('A');
                }
                else
                {
                    tabella = prodotto.lista(' ');
                }
            }

            // carico le Aziende sulla comboBox
            cmbProdotti.DataSource = tabella;
            cmbProdotti.DisplayMember = "NomeProdotto";
            cmbProdotti.ValueMember = "CodProdotto";
            cmbProdotti.SelectedIndex = -1;

            // Carico le Aziende sulla DGV
            dgvProdotti.DataSource = tabella;
            dgvProdotti.ClearSelection();

            prodotto.Dispose();
        }
        private void elencoScarichi(char tipo)
        {
            // Gestione dei Dati delle AZIENDE
            clsScarico scarico = new clsScarico("Inquinamento.mdf");

            // Recupero le Azienda dal DB
            if (tipo == 'L')
            {
                tabella = scarico.lista(' ');
            }
            else
            {
                if (chkScarichiAnnullati.Checked)
                {
                    tabella = scarico.lista('A');
                }
                else
                {
                    tabella = scarico.lista(' ');
                }
            }
            // carico le Aziende sulla comboBox
            cmbScarichi.DataSource = tabella;
            cmbScarichi.DisplayMember = "CodAziScarico";
            cmbScarichi.ValueMember = "CodScarico";
            cmbScarichi.SelectedIndex = -1;

            // Carico le Aziende sulla DGV
            dgvScarichi.DataSource = tabella;
            dgvScarichi.ClearSelection();

            scarico.Dispose();
        }
        /*****************************/
        /* Abilita Aziende Annullate */
        /*****************************/
        private void chkAnnullate_CheckedChanged(object sender, EventArgs e)
        {
            //Recupero aziende
            seleziona = false;
            elencoAziende('K');
            seleziona = true;
        }
        /********************************/ 
        /* Abilita Inquinanti Annullati */
        /********************************/
        private void chkAnnullatiInquinanti_CheckedChanged(object sender, EventArgs e)
        {
            //Recupero inquinanti
            seleziona = false;
            elencoInquinanti('K');
            seleziona = true;
        }
        private void chkProdottiAnnullati_CheckedChanged(object sender, EventArgs e)
        {
            //Recupero Prodotti
            seleziona = false;
            elencoProdotti('K');
            seleziona = true;
        }
        private void chkScarichiAnnullati_CheckedChanged(object sender, EventArgs e)
        {
            //Recupero Prodotti
            seleziona = false;
            elencoScarichi('K');
            seleziona = true;
        }
        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            //Abilito/Disabilito i GRP
            grpElencoAziende.Enabled = false;
            grpDatiAzienda.Enabled = true;

            // Imposto il Nuovo Codice Azienda
            clsAzienda azienda = new clsAzienda("Inquinamento.mdf");
            lblCodice.Text = azienda.getNuovoCodice();
            azienda.Dispose();
            txtNome.Focus();
            chkAnnulla.Enabled = false;
            chkAnnullate.Checked = false;
        }
        private void btnAggiungiInquinante_Click(object sender, EventArgs e)
        {
            //Abilito/Disabilito i GRP
            grpElencoInquinanti.Enabled = false;
            grpGestioneInquinante.Enabled = true;

            // Imposto il Nuovo Codice Azienda
            clsInquinante inquinante = new clsInquinante("Inquinamento.mdf");
            lblCodInquinante.Text = inquinante.getNuovoCodice();
            inquinante.Dispose();
            txtNomeInquinante.Focus();
            chkAnnullaInquinante.Enabled = false;
            chkAnnullatiInquinanti.Checked = false;
        }
        private void btnAggiungiProdotti_Click(object sender, EventArgs e)
        {
            //Abilito/Disabilito i GRP
            grpElencoProdotti.Enabled = false;
            grpDatiProdotti.Enabled = true;

            // Imposto il Nuovo Codice Azienda
            clsProdotto prodotto = new clsProdotto("Inquinamento.mdf");
            lblCodProdotto.Text = prodotto.getNuovoCodice();
            prodotto.Dispose();
            txtNomeProdotto.Focus();
            chkAnnullaProdotto.Enabled = false;
            chkProdottiAnnullati.Checked = false;
        }
        private void btnAggiungiScarico_Click(object sender, EventArgs e)
        {
            grpScarichi.Enabled = false;
            grpDatiScarico.Enabled = true;

            clsScarico scarico = new clsScarico("Inquinamento.mdf");
            lblCodScarico.Text = scarico.getNuovoCodice().ToString();
            scarico.Dispose();
            chkAnnullaScarico.Enabled = false;
            chkScarichiAnnullati.Checked = false;
            cmbAziendaScarico.DataSource = caricaAziendaScarico();
            cmbAziendaScarico.SelectedIndex = -1;
            cmbInquinanteScarico.DataSource = caricaInquinanteScarico();
            cmbInquinanteScarico.SelectedIndex = -1;
            cmbProdottoScarico.DataSource = caricaProdottoScarico();
            cmbProdottoScarico.SelectedIndex = -1;
        }
        private string [] caricaAziendaScarico()
        {
            clsAzienda azienda = new clsAzienda("Inquinamento.mdf");
            // Recupero le Azienda dal DB
            tabella = azienda.lista(' ');
            string[] s = new string[tabella.Rows.Count];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = tabella.Rows[i].ItemArray[1].ToString();
            }
            return s;
        }
        private string[] caricaInquinanteScarico()
        {
            clsInquinante inquinante = new clsInquinante("Inquinamento.mdf");
            // Recupero le Azienda dal DB
            tabella = inquinante.lista(' ');
            string[] s = new string[tabella.Rows.Count];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = tabella.Rows[i].ItemArray[1].ToString();
            }
            return s;
        }
        private string[] caricaProdottoScarico()
        {
            clsProdotto prodotto = new clsProdotto("Inquinamento.mdf");
            // Recupero le Azienda dal DB
            tabella = prodotto.lista(' ');
            string[] s = new string[tabella.Rows.Count];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = tabella.Rows[i].ItemArray[1].ToString();
            }
            return s;
        }
        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            //Pulizia Dati Azienda
            pulisciAzienda();
            //Abilito/Disabilito i GRP
            grpElencoAziende.Enabled = true;
            grpDatiAzienda.Enabled = false;
            chkAnnullate.Checked = false;
            cmbAziende.SelectedIndex = -1;
            dgvAziende.ClearSelection();
            btnConferma.Text = "Conferma";
        }
        private void btnAnnullaInquinante_Click(object sender, EventArgs e)
        {
            //Pulizia Dati Azienda
            pulisciInquinante();
            //Abilito/Disabilito i GRP
            grpElencoInquinanti.Enabled = true;
            grpGestioneInquinante.Enabled = false;
            chkAnnullatiInquinanti.Checked = false;
            cmbInquinante.SelectedIndex = -1;
            dgvInquinanti.ClearSelection();
            btnConfermaInquinante.Text = "Conferma";
        }
        private void btnAnnullaProdotto_Click(object sender, EventArgs e)
        {
            //Pulizia Dati Azienda
            pulisciProdotto();
            //Abilito/Disabilito i GRP
            grpElencoProdotti.Enabled = true;
            grpDatiProdotti.Enabled = false;
            chkProdottiAnnullati.Checked = false;
            chkProdottiAnnullati.Enabled = true;
            cmbProdotti.SelectedIndex = -1;
            dgvProdotti.ClearSelection();
            btnConfermaProdotto.Text = "Conferma";
        }
        private void btnAnnullaScarico_Click(object sender, EventArgs e)
        {
            pulisciScarico();
            grpScarichi.Enabled = true;
            grpDatiScarico.Enabled = false;
            chkScarichiAnnullati.Checked = false;
            cmbScarichi.SelectedIndex = -1;
            dgvScarichi.ClearSelection();
            btnConfermaScarico.Text = "Conferma";
        }
        private void pulisciAzienda()
        {
            lblCodice.Text = string.Empty;
            txtNome.Text = string.Empty;
            numUDGrado.Value = numUDGrado.Minimum;
            txtCitta.Text = string.Empty;
            chkAnnulla.Checked = false;
            chkAnnulla.Enabled = true;
        }
        private void pulisciInquinante()
        {
            lblCodInquinante.Text = string.Empty;
            txtNomeInquinante.Text = string.Empty;
            chkGassoso.Checked = false;
            chkSolido.Checked = false;
            chkLiquido.Checked = false;
            numUPPesSpecIn.Value = numUPPesSpecIn.Minimum;
            txtCittaInquinante.Text = string.Empty;
            chkAnnullaInquinante.Checked = false;
            chkAnnullaInquinante.Enabled = true;
        }
        private void pulisciProdotto()
        {
            lblCodProdotto.Text = string.Empty;
            txtNomeProdotto.Text = string.Empty;
            txtCittaProdotto.Text = string.Empty;
            chkAnnullaProdotto.Checked = false;
            chkAnnullaProdotto.Enabled = true;
        }
        private void pulisciScarico()
        {
            lblCodScarico.Text = string.Empty;
            cmbAziendaScarico.SelectedIndex = -1;
            cmbInquinanteScarico.SelectedIndex = -1;
            cmbProdottoScarico.SelectedIndex = -1;
            qtaScarico.Value = qtaScarico.Minimum;
            chkAnnullaScarico.Checked = false;
            chkAnnullaScarico.Enabled = true;
        }
        /***********************/
        /* Confermo Operazione */
        /***********************/
        private void btnConferma_Click(object sender, EventArgs e)
        {
            bool esito = false;
            //Controllo Input Dati
            if (txtNome.Text==string.Empty)
            {
                MessageBox.Show("Non è stato inserito il nome Azienda");
                txtNome.Focus();
            }else if (txtCitta.Text == string.Empty)
            {
                MessageBox.Show("Non è stata inserita la Città");
                txtCitta.Focus();
            }
            else
            {
                //Inserimento Dati sul DB
                clsAzienda azienda = new clsAzienda("Inquinamento.mdf");

                //Non è necessario inserire il Campo Codice (Solo per Insert)
                azienda.NomeAzienda = txtNome.Text;
                azienda.GradoAzienda = Convert.ToUInt16(numUDGrado.Value);
                azienda.CittaAzienda = txtCitta.Text;
                if (chkAnnulla.Checked)
                    azienda.ValAzienda = 'A';
                else
                    azienda.ValAzienda = ' ';

                //Eseguo l'Operzaione in base alla scelta dell'Utente
                if (btnConferma.Text=="Conferma")
                {
                    //Eseguo la insert
                    esito = azienda.aggiungi();
                }
                else 
                {
                    
                    azienda.CodAzienda = lblCodice.Text;
                    if (chkAnnulla.Checked)
                        //Eseguo la cancellazione dell'Azienda
                        esito = azienda.cancella();
                    
                    else
                        //Eseguo la Variazione dell'Azienda
                        esito = azienda.modifica();
                }

                //Eseguo INSERT dell'Azienda
                if (esito)
                {
                    //Pulizia Dati Azienda
                    pulisciAzienda();
                    //Abilito/Disabilito i GRP
                    grpElencoAziende.Enabled = true;
                    grpDatiAzienda.Enabled = false;
                    chkAnnullate.Checked = false;

                    btnConferma.Text = "Conferma";

                    //Recupero Aziende
                    seleziona = false;
                    elencoAziende('L');
                    seleziona = true;
                }

                azienda.Dispose();
            }
        }
        private void btnConfermaInquinante_Click(object sender, EventArgs e)
        {
            bool esito = false;
            //Controllo Input Dati
            if (txtNomeInquinante.Text == string.Empty)
            {
                MessageBox.Show("Non è stato inserito il nome Inquinante");
                txtNomeInquinante.Focus();
            }
            else if (!chkGassoso.Checked && !chkLiquido.Checked && !chkSolido.Checked)
            {
                MessageBox.Show("Non è stato inserito lo Stato");
            }
            else if (chkSolido.Checked && chkLiquido.Checked && chkGassoso.Checked)
                MessageBox.Show("Bisogna scegliere solamente uno Stato");
            else if(chkGassoso.Checked&&chkLiquido.Checked&&!chkSolido.Checked)
                MessageBox.Show("Bisogna scegliere solamente uno Stato");
            else if(chkGassoso.Checked && !chkLiquido.Checked && chkSolido.Checked)
                MessageBox.Show("Bisogna scegliere solamente uno Stato");
            else if(!chkGassoso.Checked && chkLiquido.Checked && chkSolido.Checked)
                MessageBox.Show("Bisogna scegliere solamente uno Stato");
            else if (txtCittaInquinante.Text == string.Empty)
            {
                MessageBox.Show("Non è stata inserita la Città");
                txtCittaInquinante.Focus();
            }
            else
            {
                //Inserimento Dati sul DB
                clsInquinante inquinante = new clsInquinante("Inquinamento.mdf");

                //Non è necessario inserire il Campo Codice (Solo per Insert)
                inquinante.NomeInquinante = txtNomeInquinante.Text;
                if (chkSolido.Checked)
                    inquinante.StatoInquinante = 'S';
                if (chkLiquido.Checked)
                    inquinante.StatoInquinante = 'L';
                if (chkGassoso.Checked)
                    inquinante.StatoInquinante = 'G';
                inquinante.PesoSpecificoInquinante = Convert.ToUInt16(numUPPesSpecIn.Value);
                inquinante.CittaInquinante = txtCittaInquinante.Text;
                if (chkAnnullaInquinante.Checked)
                    inquinante.ValInquinante = 'A';
                else
                    inquinante.ValInquinante = ' ';

                //Eseguo l'Operzaione in base alla scelta dell'Utente
                if (btnConfermaInquinante.Text == "Conferma")
                {
                    //Eseguo la insert
                    esito = inquinante.aggiungi();
                }
                else
                {
                    inquinante.CodInquinante = lblCodInquinante.Text;
                    if (chkAnnullaInquinante.Checked)
                        //Eseguo la cancellazione dell'Azienda
                        esito = inquinante.cancella();

                    else
                        //Eseguo la Variazione dell'Azienda
                        esito = inquinante.modifica();
                }

                //Eseguo INSERT dell'Azienda
                if (esito)
                {
                    //Pulizia Dati Azienda
                    pulisciInquinante();
                    //Abilito/Disabilito i GRP
                    grpElencoInquinanti.Enabled = true;
                    grpGestioneInquinante.Enabled = false;
                    chkAnnullatiInquinanti.Checked = false;
                    btnConfermaInquinante.Text = "Conferma";

                    //Recupero Aziende
                    seleziona = false;
                    elencoInquinanti('L');
                    seleziona = true;
                }

                inquinante.Dispose();
            }
        }
        private void btnConfermaProdotto_Click(object sender, EventArgs e)
        {
            bool esito = false;
            //Controllo Input Dati
            if (txtNomeProdotto.Text == string.Empty)
            {
                MessageBox.Show("Non è stato inserito il Nome Prodotto");
                txtNomeProdotto.Focus();
            }
            else if (txtCittaProdotto.Text == string.Empty)
            {
                MessageBox.Show("Non è stata inserita la Città Prodotto");
                txtCittaProdotto.Focus();
            }
            else
            {
                //Inserimento Dati sul DB
                clsProdotto prodotto = new clsProdotto("Inquinamento.mdf");

                //Non è necessario inserire il Campo Codice (Solo per Insert)
                prodotto.NomeProdotto = txtNomeProdotto.Text;
                prodotto.CittaProdotto = txtCittaProdotto.Text;
                if (chkAnnullaProdotto.Checked)
                    prodotto.ValProdotto = 'A';
                else
                    prodotto.ValProdotto = ' ';

                //Eseguo l'Operzaione in base alla scelta dell'Utente
                if (btnConfermaProdotto.Text == "Conferma")
                {
                    //Eseguo la insert
                    esito = prodotto.aggiungi();
                }
                else
                {

                    prodotto.CodProdotto = lblCodProdotto.Text;
                    if (chkAnnullaProdotto.Checked)
                        //Eseguo la cancellazione dell'Azienda
                        esito = prodotto.cancella();

                    else
                        //Eseguo la Variazione dell'Azienda
                        esito = prodotto.modifica();
                }

                //Eseguo INSERT dell'Azienda
                if (esito)
                {
                    //Pulizia Dati Azienda
                    pulisciProdotto();
                    //Abilito/Disabilito i GRP
                    grpElencoProdotti.Enabled = true;
                    grpDatiProdotti.Enabled = false;
                    chkProdottiAnnullati.Checked = false;

                    btnConfermaProdotto.Text = "Conferma";

                    //Recupero Aziende
                    seleziona = false;
                    elencoProdotti('L');
                    seleziona = true;
                }

                prodotto.Dispose();
            }
        }
        private void btnConfermaScarico_Click(object sender, EventArgs e)
        {
            bool esito = false;
            //Controllo Input Dati
            if (cmbAziendaScarico.Text == string.Empty)
            {
                MessageBox.Show("Non è stato inserita l'azienda dello scarico.");
            }
            else if (cmbInquinanteScarico.Text == string.Empty)
            {
                MessageBox.Show("Non è stata inserito l'inquinante dello scarico.");
            }
            else if (cmbProdottoScarico.Text == string.Empty)
            {
                MessageBox.Show("Non è stata inserito il prodotto dello scarico.");
            }
            else
            {
                //Inserimento Dati sul DB
                clsScarico scarico = new clsScarico("Inquinamento.mdf");

                //Non è necessario inserire il Campo Codice (Solo per Insert)
                scarico.CodAziScarico = getCodAzi(cmbAziendaScarico.Text);
                scarico.CodInqScarico = getCodInq(cmbInquinanteScarico.Text);
                scarico.CodProScarico = getCodProd(cmbProdottoScarico.Text);
                scarico.QtaScarico = Convert.ToUInt16(qtaScarico.Value);
                if (chkAnnullaScarico.Checked)
                    scarico.ValScarico = 'A';
                else
                    scarico.ValScarico = ' ';

                //Eseguo l'Operzaione in base alla scelta dell'Utente
                if (btnConfermaScarico.Text == "Conferma")
                {
                    //Eseguo la insert
                    esito = scarico.aggiungi();
                }
                else
                {
                    scarico.CodScarico =Convert.ToInt32(lblCodScarico.Text);
                    if (chkAnnullaScarico.Checked)
                        //Eseguo la cancellazione dell'Azienda
                        esito = scarico.cancella();

                    else
                        //Eseguo la Variazione dell'Azienda
                        esito = scarico.modifica();
                }

                //Eseguo INSERT dell'Azienda
                if (esito)
                {
                    //Pulizia Dati Azienda
                    pulisciScarico();
                    //Abilito/Disabilito i GRP
                    grpScarichi.Enabled = true;
                    grpDatiScarico.Enabled = false;
                    chkScarichiAnnullati.Checked = false;

                    btnConfermaScarico.Text = "Conferma";

                    //Recupero Aziende
                    seleziona = false;
                    elencoScarichi('L');
                    seleziona = true;
                }

                scarico.Dispose();
            }
        }
        private string getCodAzi(string Azi)
        {
            clsAzienda azienda = new clsAzienda("Inquinamento.mdf");
            tabella = azienda.lista(' ');
            for (int i = 0; i < tabella.Rows.Count; i++)
            {
                if (tabella.Rows[i].ItemArray[1].ToString()==Azi)
                {
                    return tabella.Rows[i].ItemArray[0].ToString();
                }
            }
            return string.Empty;
        }
        private string getCodInq(string Inq)
        {
            clsInquinante inquinante = new clsInquinante("Inquinamento.mdf");
            tabella = inquinante.lista(' ');
            for (int i = 0; i < tabella.Rows.Count; i++)
            {
                if (tabella.Rows[i].ItemArray[1].ToString() == Inq)
                {
                    return tabella.Rows[i].ItemArray[0].ToString();
                }
            }
            return string.Empty;
        }
        private string getCodProd(string Prod)
        {
            clsProdotto prodotto = new clsProdotto("Inquinamento.mdf");
            tabella = prodotto.lista(' ');
            for (int i = 0; i < tabella.Rows.Count; i++)
            {
                if (tabella.Rows[i].ItemArray[1].ToString() == Prod)
                {
                    return tabella.Rows[i].ItemArray[0].ToString();
                }
            }
            return string.Empty;
        }
        private void cmbAziende_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codAzienda = string.Empty;
            //Controllo selezione effettiva dell'azienda
            if (cmbAziende.SelectedIndex!=-1 && cmbAziende.ValueMember!=""&&seleziona)
            {
                codAzienda = cmbAziende.SelectedValue.ToString();
                //Richiamo Seleziona singola Azienda
                selezionaAzienda(codAzienda);
            }
        }
        private void cmbInquinante_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codInquinante = string.Empty;
            //Controllo selezione effettiva dell'azienda
            if (cmbInquinante.SelectedIndex != -1 && cmbInquinante.ValueMember != "" && seleziona)
            {
                codInquinante = cmbInquinante.SelectedValue.ToString();
                //Richiamo Seleziona singola Azienda
                selezionaInquinante(codInquinante);
            }
        }
        private void cmbProdotti_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codProdotto = string.Empty;
            //Controllo selezione effettiva dell'azienda
            if (cmbProdotti.SelectedIndex != -1 && cmbProdotti.ValueMember != "" && seleziona)
            {
                codProdotto = cmbProdotti.SelectedValue.ToString();
                //Richiamo Seleziona singola Azienda
                selezionaProdotto(codProdotto);
            }
        }
        private void cmbScarichi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codScarico = 0;
            //Controllo selezione effettiva dell'azienda
            if (cmbScarichi.SelectedIndex != -1 && cmbScarichi.ValueMember != "" && seleziona)
            {
                codScarico = Convert.ToInt32(cmbScarichi.SelectedValue);
                //Richiamo Seleziona singola Azienda
                selezionaScarico(codScarico);
            }
        }
        /*****************************/
        /* Seleziona singola Azienda */
        /*****************************/
        private void selezionaAzienda(string cAzi)
        {
            clsAzienda azienda = new clsAzienda("Inquinamento.mdf");

            //Recupero di dati dell'Azienda
            azienda.CodAzienda = cAzi;
            azienda.getDati();

            //Carico i Dati solo se non ho errori
            if (azienda.CodAzienda != null)
            {
                lblCodice.Text = azienda.CodAzienda;
                txtNome.Text = azienda.NomeAzienda;
                numUDGrado.Value = azienda.GradoAzienda;
                txtCitta.Text = azienda.CittaAzienda;
                if (azienda.ValAzienda=='A')
                {
                    chkAnnulla.Checked=true;
                }
                grpElencoAziende.Enabled = false;
                grpDatiAzienda.Enabled = true;

                btnConferma.Text = "Modifica";
            }

            azienda.Dispose();
        }
        private void selezionaInquinante(string cInq)
        {
            
            clsInquinante inquinante = new clsInquinante("Inquinamento.mdf");

            //Recupero di dati dell'Azienda
            inquinante.CodInquinante = cInq;
            inquinante.getDati();

            //Carico i Dati solo se non ho errori
            if (inquinante.CodInquinante != null)
            {
                
                lblCodInquinante.Text = inquinante.CodInquinante;
               
                txtNomeInquinante.Text = inquinante.NomeInquinante;
                if (inquinante.StatoInquinante == 'S')
                    chkSolido.Checked = true;
                if (inquinante.StatoInquinante == 'L')
                    chkLiquido.Checked = true;
                if (inquinante.StatoInquinante == 'G')
                    chkGassoso.Checked = true;
                numUPPesSpecIn.Value = inquinante.PesoSpecificoInquinante;
                txtCittaInquinante.Text = inquinante.CittaInquinante;
                if (inquinante.ValInquinante == 'A')
                {
                    chkAnnullaInquinante.Checked = true;
                }
                grpElencoInquinanti.Enabled = false;
                grpGestioneInquinante.Enabled = true;

                btnConfermaInquinante.Text = "Modifica";
            }

            inquinante.Dispose();
        }
        private void selezionaProdotto(string cProd)
        {
            clsProdotto prodotto = new clsProdotto("Inquinamento.mdf");

            //Recupero di dati dell'Azienda
            prodotto.CodProdotto = cProd;
            prodotto.getDati();

            //Carico i Dati solo se non ho errori
            if (prodotto.CodProdotto != null)
            {
                lblCodProdotto.Text = prodotto.CodProdotto;
                txtNomeProdotto.Text = prodotto.NomeProdotto;
                txtCittaProdotto.Text = prodotto.CittaProdotto;
                if (prodotto.ValProdotto == 'A')
                {
                    chkAnnullaProdotto.Checked = true;
                }
                grpElencoProdotti.Enabled = false;
                grpDatiProdotti.Enabled = true;

                btnConfermaProdotto.Text = "Modifica";
            }
            prodotto.Dispose();
        }
        private void selezionaScarico(int cScar)
        {
            clsScarico scarico = new clsScarico("Inquinamento.mdf");

            //Recupero di dati dell'Azienda
            scarico.CodScarico = cScar;
            scarico.getDati();

            //Carico i Dati solo se non ho errori
            if (scarico.CodScarico != 0)
            {
                lblCodScarico.Text = scarico.CodScarico.ToString();
                cmbAziendaScarico.DataSource=caricaAziendaScarico();
                cmbAziendaScarico.Text = getDesAzi(scarico.CodAziScarico);
                cmbInquinanteScarico.DataSource = caricaInquinanteScarico();
                cmbInquinanteScarico.Text = getDesInq(scarico.CodInqScarico);
                cmbProdottoScarico.DataSource = caricaProdottoScarico();
                cmbProdottoScarico.Text = getDesProd(scarico.CodProScarico);
                qtaScarico.Value = scarico.QtaScarico;
                if (scarico.ValScarico == 'A')
                {
                    chkAnnullaScarico.Checked = true;
                }
                grpScarichi.Enabled = false;
                grpDatiScarico.Enabled = true;

                btnConfermaScarico.Text = "Modifica";
            }
            scarico.Dispose();
        }
        private string getDesAzi(string cAzi)
        {
            clsAzienda azienda = new clsAzienda("Inquinamento.mdf");
            tabella = azienda.lista(' ');
            for (int i = 0; i < tabella.Rows.Count; i++)
            {
                if (tabella.Rows[i].ItemArray[0].ToString()==cAzi)
                {
                    return tabella.Rows[i].ItemArray[1].ToString();
                }
            }
            return string.Empty;
        }
        private string getDesInq(string cInq)
        {
            clsInquinante inquinante = new clsInquinante("Inquinamento.mdf");
            tabella = inquinante.lista(' ');
            for (int i = 0; i < tabella.Rows.Count; i++)
            {
                if (tabella.Rows[i].ItemArray[0].ToString() == cInq)
                {
                    return tabella.Rows[i].ItemArray[1].ToString();
                }
            }
            return string.Empty;
        }
        private string getDesProd(string cProd)
        {
            clsProdotto prodotto = new clsProdotto("Inquinamento.mdf");
            tabella = prodotto.lista(' ');
            for (int i = 0; i < tabella.Rows.Count; i++)
            {
                if (tabella.Rows[i].ItemArray[0].ToString() == cProd)
                {
                    return tabella.Rows[i].ItemArray[1].ToString();
                }
            }
            return string.Empty;
        }
        private void chkSolido_CheckedChanged(object sender, EventArgs e)
        {
            if((chkLiquido.Checked||chkGassoso.Checked)&&chkSolido.Checked)
            {
                chkGassoso.Checked = false;
                chkLiquido.Checked = false;
            }
        }

        private void chkLiquido_CheckedChanged(object sender, EventArgs e)
        {
            if ((chkSolido.Checked || chkGassoso.Checked) && chkLiquido.Checked)
            {
                chkGassoso.Checked = false;
                chkSolido.Checked = false;
            }
        }

        private void chkGassoso_CheckedChanged(object sender, EventArgs e)
        {
            if ((chkSolido.Checked || chkLiquido.Checked) && chkGassoso.Checked)
            {
                chkSolido.Checked = false;
                chkLiquido.Checked = false;
            }
        }

        
    }
}
