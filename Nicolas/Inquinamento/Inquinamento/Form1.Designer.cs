namespace Inquinamento
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Aziende = new System.Windows.Forms.TabPage();
            this.grpElenco = new System.Windows.Forms.GroupBox();
            this.dgvAziende = new System.Windows.Forms.DataGridView();
            this.btnAggiungiAzienda = new System.Windows.Forms.Button();
            this.chkAziendeAnnullate = new System.Windows.Forms.CheckBox();
            this.cmbAziende = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpDatiAzienda = new System.Windows.Forms.GroupBox();
            this.lblCodice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAnnullaAziende = new System.Windows.Forms.Button();
            this.btnConfermaAziende = new System.Windows.Forms.Button();
            this.txtCitta = new System.Windows.Forms.TextBox();
            this.numUDGrado = new System.Windows.Forms.NumericUpDown();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.chkAnnulla = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Inquinanti = new System.Windows.Forms.TabPage();
            this.grpModificaInquinanti = new System.Windows.Forms.GroupBox();
            this.btnConfermaModifica = new System.Windows.Forms.Button();
            this.nmbPesoSpecifico = new System.Windows.Forms.NumericUpDown();
            this.cmbStato = new System.Windows.Forms.ComboBox();
            this.txtCittaInquinante = new System.Windows.Forms.TextBox();
            this.txtNomeInquinante = new System.Windows.Forms.TextBox();
            this.chkAnnullaValInquinante = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAnnullaInquinamenti = new System.Windows.Forms.Button();
            this.lblCodInquinante = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpElencoInquinanti = new System.Windows.Forms.GroupBox();
            this.chkAggiungiInquinantiAnnullati = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInquinanti = new System.Windows.Forms.DataGridView();
            this.btnAggiungiinquinante = new System.Windows.Forms.Button();
            this.cmbInquinanti = new System.Windows.Forms.ComboBox();
            this.Prodotti = new System.Windows.Forms.TabPage();
            this.grpGestioneProdotti = new System.Windows.Forms.GroupBox();
            this.btnConfermaProdotti = new System.Windows.Forms.Button();
            this.chkAnnullaValProdotto = new System.Windows.Forms.CheckBox();
            this.btnAnnullaProdotti = new System.Windows.Forms.Button();
            this.txtCittaProdotti = new System.Windows.Forms.TextBox();
            this.txtNomeProdotto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblCodiceProdotto = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.grpElencoProdotti = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.chkAggiungiAnnullateProdotti = new System.Windows.Forms.CheckBox();
            this.dgvProdotti = new System.Windows.Forms.DataGridView();
            this.btnAggiungiProdotto = new System.Windows.Forms.Button();
            this.cmbProdotti = new System.Windows.Forms.ComboBox();
            this.Scarichi = new System.Windows.Forms.TabPage();
            this.GrpModificaScarichi = new System.Windows.Forms.GroupBox();
            this.cmbCodProd = new System.Windows.Forms.ComboBox();
            this.cmbCodInq = new System.Windows.Forms.ComboBox();
            this.cmbCodAzienda = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.nmbQuantita = new System.Windows.Forms.NumericUpDown();
            this.btnConferma_Scarico = new System.Windows.Forms.Button();
            this.chkAnnullaValScarico = new System.Windows.Forms.CheckBox();
            this.btnAnnulla_Scarico = new System.Windows.Forms.Button();
            this.lblAzienda = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblCodiceScarico = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.grpElencoScarichi = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.chkAggiungiScarichiAnnullati = new System.Windows.Forms.CheckBox();
            this.dgvScarichi = new System.Windows.Forms.DataGridView();
            this.btnAggiungiScarico = new System.Windows.Forms.Button();
            this.cmbScarichi = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.Aziende.SuspendLayout();
            this.grpElenco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAziende)).BeginInit();
            this.grpDatiAzienda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDGrado)).BeginInit();
            this.Inquinanti.SuspendLayout();
            this.grpModificaInquinanti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbPesoSpecifico)).BeginInit();
            this.grpElencoInquinanti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInquinanti)).BeginInit();
            this.Prodotti.SuspendLayout();
            this.grpGestioneProdotti.SuspendLayout();
            this.grpElencoProdotti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdotti)).BeginInit();
            this.Scarichi.SuspendLayout();
            this.GrpModificaScarichi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbQuantita)).BeginInit();
            this.grpElencoScarichi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScarichi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Aziende);
            this.tabControl1.Controls.Add(this.Inquinanti);
            this.tabControl1.Controls.Add(this.Prodotti);
            this.tabControl1.Controls.Add(this.Scarichi);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1264, 508);
            this.tabControl1.TabIndex = 0;
            // 
            // Aziende
            // 
            this.Aziende.Controls.Add(this.grpElenco);
            this.Aziende.Controls.Add(this.grpDatiAzienda);
            this.Aziende.Location = new System.Drawing.Point(4, 25);
            this.Aziende.Margin = new System.Windows.Forms.Padding(4);
            this.Aziende.Name = "Aziende";
            this.Aziende.Padding = new System.Windows.Forms.Padding(4);
            this.Aziende.Size = new System.Drawing.Size(1256, 479);
            this.Aziende.TabIndex = 1;
            this.Aziende.Text = "Aziende";
            this.Aziende.UseVisualStyleBackColor = true;
            // 
            // grpElenco
            // 
            this.grpElenco.Controls.Add(this.dgvAziende);
            this.grpElenco.Controls.Add(this.btnAggiungiAzienda);
            this.grpElenco.Controls.Add(this.chkAziendeAnnullate);
            this.grpElenco.Controls.Add(this.cmbAziende);
            this.grpElenco.Controls.Add(this.label2);
            this.grpElenco.Location = new System.Drawing.Point(21, 20);
            this.grpElenco.Margin = new System.Windows.Forms.Padding(4);
            this.grpElenco.Name = "grpElenco";
            this.grpElenco.Padding = new System.Windows.Forms.Padding(4);
            this.grpElenco.Size = new System.Drawing.Size(768, 426);
            this.grpElenco.TabIndex = 7;
            this.grpElenco.TabStop = false;
            this.grpElenco.Text = "Elenco Aziende";
            // 
            // dgvAziende
            // 
            this.dgvAziende.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAziende.Location = new System.Drawing.Point(8, 42);
            this.dgvAziende.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAziende.Name = "dgvAziende";
            this.dgvAziende.RowHeadersWidth = 51;
            this.dgvAziende.Size = new System.Drawing.Size(752, 299);
            this.dgvAziende.TabIndex = 1;
            // 
            // btnAggiungiAzienda
            // 
            this.btnAggiungiAzienda.Location = new System.Drawing.Point(553, 348);
            this.btnAggiungiAzienda.Margin = new System.Windows.Forms.Padding(4);
            this.btnAggiungiAzienda.Name = "btnAggiungiAzienda";
            this.btnAggiungiAzienda.Size = new System.Drawing.Size(207, 57);
            this.btnAggiungiAzienda.TabIndex = 6;
            this.btnAggiungiAzienda.Text = "Aggiungi Azienda";
            this.btnAggiungiAzienda.UseVisualStyleBackColor = true;
            this.btnAggiungiAzienda.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // chkAziendeAnnullate
            // 
            this.chkAziendeAnnullate.AutoSize = true;
            this.chkAziendeAnnullate.Location = new System.Drawing.Point(608, 14);
            this.chkAziendeAnnullate.Margin = new System.Windows.Forms.Padding(4);
            this.chkAziendeAnnullate.Name = "chkAziendeAnnullate";
            this.chkAziendeAnnullate.Size = new System.Drawing.Size(148, 21);
            this.chkAziendeAnnullate.TabIndex = 4;
            this.chkAziendeAnnullate.Text = "Aggiungi Annullate";
            this.chkAziendeAnnullate.UseVisualStyleBackColor = true;
            this.chkAziendeAnnullate.CheckedChanged += new System.EventHandler(this.chkAnnullate_CheckedChanged);
            // 
            // cmbAziende
            // 
            this.cmbAziende.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAziende.FormattingEnabled = true;
            this.cmbAziende.Location = new System.Drawing.Point(80, 379);
            this.cmbAziende.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAziende.Name = "cmbAziende";
            this.cmbAziende.Size = new System.Drawing.Size(444, 24);
            this.cmbAziende.TabIndex = 3;
            this.cmbAziende.SelectedIndexChanged += new System.EventHandler(this.cmbAziende_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 389);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aziende:";
            // 
            // grpDatiAzienda
            // 
            this.grpDatiAzienda.Controls.Add(this.lblCodice);
            this.grpDatiAzienda.Controls.Add(this.label7);
            this.grpDatiAzienda.Controls.Add(this.btnAnnullaAziende);
            this.grpDatiAzienda.Controls.Add(this.btnConfermaAziende);
            this.grpDatiAzienda.Controls.Add(this.txtCitta);
            this.grpDatiAzienda.Controls.Add(this.numUDGrado);
            this.grpDatiAzienda.Controls.Add(this.txtNome);
            this.grpDatiAzienda.Controls.Add(this.chkAnnulla);
            this.grpDatiAzienda.Controls.Add(this.label6);
            this.grpDatiAzienda.Controls.Add(this.label5);
            this.grpDatiAzienda.Controls.Add(this.label4);
            this.grpDatiAzienda.Controls.Add(this.label3);
            this.grpDatiAzienda.Enabled = false;
            this.grpDatiAzienda.Location = new System.Drawing.Point(797, 20);
            this.grpDatiAzienda.Margin = new System.Windows.Forms.Padding(4);
            this.grpDatiAzienda.Name = "grpDatiAzienda";
            this.grpDatiAzienda.Padding = new System.Windows.Forms.Padding(4);
            this.grpDatiAzienda.Size = new System.Drawing.Size(428, 426);
            this.grpDatiAzienda.TabIndex = 5;
            this.grpDatiAzienda.TabStop = false;
            this.grpDatiAzienda.Text = "Gestisce Dati Azienda";
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodice.ForeColor = System.Drawing.Color.Blue;
            this.lblCodice.Location = new System.Drawing.Point(108, 48);
            this.lblCodice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(0, 17);
            this.lblCodice.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Codice";
            // 
            // btnAnnullaAziende
            // 
            this.btnAnnullaAziende.Location = new System.Drawing.Point(245, 346);
            this.btnAnnullaAziende.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnullaAziende.Name = "btnAnnullaAziende";
            this.btnAnnullaAziende.Size = new System.Drawing.Size(100, 28);
            this.btnAnnullaAziende.TabIndex = 9;
            this.btnAnnullaAziende.Text = "Annulla";
            this.btnAnnullaAziende.UseVisualStyleBackColor = true;
            this.btnAnnullaAziende.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnConfermaAziende
            // 
            this.btnConfermaAziende.Location = new System.Drawing.Point(112, 346);
            this.btnConfermaAziende.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfermaAziende.Name = "btnConfermaAziende";
            this.btnConfermaAziende.Size = new System.Drawing.Size(100, 28);
            this.btnConfermaAziende.TabIndex = 8;
            this.btnConfermaAziende.Text = "Conferma";
            this.btnConfermaAziende.UseVisualStyleBackColor = true;
            this.btnConfermaAziende.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // txtCitta
            // 
            this.txtCitta.Location = new System.Drawing.Point(112, 202);
            this.txtCitta.Margin = new System.Windows.Forms.Padding(4);
            this.txtCitta.Name = "txtCitta";
            this.txtCitta.Size = new System.Drawing.Size(281, 22);
            this.txtCitta.TabIndex = 7;
            // 
            // numUDGrado
            // 
            this.numUDGrado.Location = new System.Drawing.Point(112, 153);
            this.numUDGrado.Margin = new System.Windows.Forms.Padding(4);
            this.numUDGrado.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDGrado.Name = "numUDGrado";
            this.numUDGrado.Size = new System.Drawing.Size(83, 22);
            this.numUDGrado.TabIndex = 6;
            this.numUDGrado.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(112, 94);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(281, 22);
            this.txtNome.TabIndex = 5;
            // 
            // chkAnnulla
            // 
            this.chkAnnulla.AutoSize = true;
            this.chkAnnulla.Location = new System.Drawing.Point(112, 257);
            this.chkAnnulla.Margin = new System.Windows.Forms.Padding(4);
            this.chkAnnulla.Name = "chkAnnulla";
            this.chkAnnulla.Size = new System.Drawing.Size(18, 17);
            this.chkAnnulla.TabIndex = 4;
            this.chkAnnulla.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 258);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Annulla";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Città";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Grado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome";
            // 
            // Inquinanti
            // 
            this.Inquinanti.Controls.Add(this.grpModificaInquinanti);
            this.Inquinanti.Controls.Add(this.grpElencoInquinanti);
            this.Inquinanti.Location = new System.Drawing.Point(4, 25);
            this.Inquinanti.Margin = new System.Windows.Forms.Padding(4);
            this.Inquinanti.Name = "Inquinanti";
            this.Inquinanti.Padding = new System.Windows.Forms.Padding(4);
            this.Inquinanti.Size = new System.Drawing.Size(1256, 479);
            this.Inquinanti.TabIndex = 2;
            this.Inquinanti.Text = "Inquinanti";
            this.Inquinanti.UseVisualStyleBackColor = true;
            this.Inquinanti.ContextMenuStripChanged += new System.EventHandler(this.switchInquinanti);
            this.Inquinanti.Enter += new System.EventHandler(this.switchInquinanti);
            // 
            // grpModificaInquinanti
            // 
            this.grpModificaInquinanti.Controls.Add(this.btnConfermaModifica);
            this.grpModificaInquinanti.Controls.Add(this.nmbPesoSpecifico);
            this.grpModificaInquinanti.Controls.Add(this.cmbStato);
            this.grpModificaInquinanti.Controls.Add(this.txtCittaInquinante);
            this.grpModificaInquinanti.Controls.Add(this.txtNomeInquinante);
            this.grpModificaInquinanti.Controls.Add(this.chkAnnullaValInquinante);
            this.grpModificaInquinanti.Controls.Add(this.label13);
            this.grpModificaInquinanti.Controls.Add(this.label12);
            this.grpModificaInquinanti.Controls.Add(this.label11);
            this.grpModificaInquinanti.Controls.Add(this.label10);
            this.grpModificaInquinanti.Controls.Add(this.btnAnnullaInquinamenti);
            this.grpModificaInquinanti.Controls.Add(this.lblCodInquinante);
            this.grpModificaInquinanti.Controls.Add(this.label8);
            this.grpModificaInquinanti.Location = new System.Drawing.Point(886, 24);
            this.grpModificaInquinanti.Name = "grpModificaInquinanti";
            this.grpModificaInquinanti.Size = new System.Drawing.Size(363, 443);
            this.grpModificaInquinanti.TabIndex = 1;
            this.grpModificaInquinanti.TabStop = false;
            this.grpModificaInquinanti.Text = "Gestione inquinanti";
            // 
            // btnConfermaModifica
            // 
            this.btnConfermaModifica.Location = new System.Drawing.Point(63, 336);
            this.btnConfermaModifica.Name = "btnConfermaModifica";
            this.btnConfermaModifica.Size = new System.Drawing.Size(118, 75);
            this.btnConfermaModifica.TabIndex = 23;
            this.btnConfermaModifica.Text = "Aggiungi";
            this.btnConfermaModifica.UseVisualStyleBackColor = true;
            this.btnConfermaModifica.Click += new System.EventHandler(this.btnConfermaModifica_Click);
            // 
            // nmbPesoSpecifico
            // 
            this.nmbPesoSpecifico.Location = new System.Drawing.Point(148, 225);
            this.nmbPesoSpecifico.Name = "nmbPesoSpecifico";
            this.nmbPesoSpecifico.Size = new System.Drawing.Size(155, 22);
            this.nmbPesoSpecifico.TabIndex = 22;
            // 
            // cmbStato
            // 
            this.cmbStato.FormattingEnabled = true;
            this.cmbStato.Location = new System.Drawing.Point(85, 175);
            this.cmbStato.Name = "cmbStato";
            this.cmbStato.Size = new System.Drawing.Size(218, 24);
            this.cmbStato.TabIndex = 21;
            // 
            // txtCittaInquinante
            // 
            this.txtCittaInquinante.Location = new System.Drawing.Point(85, 133);
            this.txtCittaInquinante.Name = "txtCittaInquinante";
            this.txtCittaInquinante.Size = new System.Drawing.Size(218, 22);
            this.txtCittaInquinante.TabIndex = 20;
            // 
            // txtNomeInquinante
            // 
            this.txtNomeInquinante.Location = new System.Drawing.Point(85, 95);
            this.txtNomeInquinante.Name = "txtNomeInquinante";
            this.txtNomeInquinante.Size = new System.Drawing.Size(218, 22);
            this.txtNomeInquinante.TabIndex = 19;
            // 
            // chkAnnullaValInquinante
            // 
            this.chkAnnullaValInquinante.AutoSize = true;
            this.chkAnnullaValInquinante.Location = new System.Drawing.Point(148, 278);
            this.chkAnnullaValInquinante.Name = "chkAnnullaValInquinante";
            this.chkAnnullaValInquinante.Size = new System.Drawing.Size(77, 21);
            this.chkAnnullaValInquinante.TabIndex = 18;
            this.chkAnnullaValInquinante.Text = "Annulla";
            this.chkAnnullaValInquinante.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Nome";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Città";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Stato";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Peso specifico";
            // 
            // btnAnnullaInquinamenti
            // 
            this.btnAnnullaInquinamenti.Location = new System.Drawing.Point(206, 336);
            this.btnAnnullaInquinamenti.Name = "btnAnnullaInquinamenti";
            this.btnAnnullaInquinamenti.Size = new System.Drawing.Size(117, 75);
            this.btnAnnullaInquinamenti.TabIndex = 10;
            this.btnAnnullaInquinamenti.Text = "Annulla";
            this.btnAnnullaInquinamenti.UseVisualStyleBackColor = true;
            this.btnAnnullaInquinamenti.Click += new System.EventHandler(this.btnAnnullaInquinamenti_Click);
            // 
            // lblCodInquinante
            // 
            this.lblCodInquinante.AutoSize = true;
            this.lblCodInquinante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodInquinante.ForeColor = System.Drawing.Color.Blue;
            this.lblCodInquinante.Location = new System.Drawing.Point(203, 40);
            this.lblCodInquinante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodInquinante.Name = "lblCodInquinante";
            this.lblCodInquinante.Size = new System.Drawing.Size(0, 17);
            this.lblCodInquinante.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Codice inquinante:";
            // 
            // grpElencoInquinanti
            // 
            this.grpElencoInquinanti.Controls.Add(this.chkAggiungiInquinantiAnnullati);
            this.grpElencoInquinanti.Controls.Add(this.label1);
            this.grpElencoInquinanti.Controls.Add(this.dgvInquinanti);
            this.grpElencoInquinanti.Controls.Add(this.btnAggiungiinquinante);
            this.grpElencoInquinanti.Controls.Add(this.cmbInquinanti);
            this.grpElencoInquinanti.Location = new System.Drawing.Point(7, 24);
            this.grpElencoInquinanti.Name = "grpElencoInquinanti";
            this.grpElencoInquinanti.Size = new System.Drawing.Size(873, 439);
            this.grpElencoInquinanti.TabIndex = 0;
            this.grpElencoInquinanti.TabStop = false;
            this.grpElencoInquinanti.Text = "Elenco inquinanti";
            // 
            // chkAggiungiInquinantiAnnullati
            // 
            this.chkAggiungiInquinantiAnnullati.AutoSize = true;
            this.chkAggiungiInquinantiAnnullati.Location = new System.Drawing.Point(649, 21);
            this.chkAggiungiInquinantiAnnullati.Name = "chkAggiungiInquinantiAnnullati";
            this.chkAggiungiInquinantiAnnullati.Size = new System.Drawing.Size(145, 21);
            this.chkAggiungiInquinantiAnnullati.TabIndex = 19;
            this.chkAggiungiInquinantiAnnullati.Text = "Aggiungi Annulate";
            this.chkAggiungiInquinantiAnnullati.UseVisualStyleBackColor = true;
            this.chkAggiungiInquinantiAnnullati.CheckedChanged += new System.EventHandler(this.chkAggiungiInquinantiAnnullati_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inquinanti:";
            // 
            // dgvInquinanti
            // 
            this.dgvInquinanti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInquinanti.Location = new System.Drawing.Point(7, 53);
            this.dgvInquinanti.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInquinanti.Name = "dgvInquinanti";
            this.dgvInquinanti.RowHeadersWidth = 51;
            this.dgvInquinanti.Size = new System.Drawing.Size(859, 284);
            this.dgvInquinanti.TabIndex = 7;
            // 
            // btnAggiungiinquinante
            // 
            this.btnAggiungiinquinante.Location = new System.Drawing.Point(592, 361);
            this.btnAggiungiinquinante.Margin = new System.Windows.Forms.Padding(4);
            this.btnAggiungiinquinante.Name = "btnAggiungiinquinante";
            this.btnAggiungiinquinante.Size = new System.Drawing.Size(207, 57);
            this.btnAggiungiinquinante.TabIndex = 9;
            this.btnAggiungiinquinante.Text = "Aggiungi inquinante";
            this.btnAggiungiinquinante.UseVisualStyleBackColor = true;
            this.btnAggiungiinquinante.Click += new System.EventHandler(this.btnAggiungiinquinante_Click_1);
            // 
            // cmbInquinanti
            // 
            this.cmbInquinanti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInquinanti.FormattingEnabled = true;
            this.cmbInquinanti.Location = new System.Drawing.Point(123, 378);
            this.cmbInquinanti.Margin = new System.Windows.Forms.Padding(4);
            this.cmbInquinanti.Name = "cmbInquinanti";
            this.cmbInquinanti.Size = new System.Drawing.Size(444, 24);
            this.cmbInquinanti.TabIndex = 8;
            this.cmbInquinanti.SelectedIndexChanged += new System.EventHandler(this.cmbInquinanti_SelectedIndexChanged);
            // 
            // Prodotti
            // 
            this.Prodotti.Controls.Add(this.grpGestioneProdotti);
            this.Prodotti.Controls.Add(this.grpElencoProdotti);
            this.Prodotti.Location = new System.Drawing.Point(4, 25);
            this.Prodotti.Margin = new System.Windows.Forms.Padding(4);
            this.Prodotti.Name = "Prodotti";
            this.Prodotti.Size = new System.Drawing.Size(1256, 479);
            this.Prodotti.TabIndex = 3;
            this.Prodotti.Text = "Prodotti";
            this.Prodotti.UseVisualStyleBackColor = true;
            this.Prodotti.Enter += new System.EventHandler(this.loadProdotti);
            // 
            // grpGestioneProdotti
            // 
            this.grpGestioneProdotti.Controls.Add(this.btnConfermaProdotti);
            this.grpGestioneProdotti.Controls.Add(this.chkAnnullaValProdotto);
            this.grpGestioneProdotti.Controls.Add(this.btnAnnullaProdotti);
            this.grpGestioneProdotti.Controls.Add(this.txtCittaProdotti);
            this.grpGestioneProdotti.Controls.Add(this.txtNomeProdotto);
            this.grpGestioneProdotti.Controls.Add(this.label9);
            this.grpGestioneProdotti.Controls.Add(this.label14);
            this.grpGestioneProdotti.Controls.Add(this.lblCodiceProdotto);
            this.grpGestioneProdotti.Controls.Add(this.label16);
            this.grpGestioneProdotti.Location = new System.Drawing.Point(862, 24);
            this.grpGestioneProdotti.Name = "grpGestioneProdotti";
            this.grpGestioneProdotti.Size = new System.Drawing.Size(391, 459);
            this.grpGestioneProdotti.TabIndex = 0;
            this.grpGestioneProdotti.TabStop = false;
            this.grpGestioneProdotti.Text = "Gestione prodotti";
            // 
            // btnConfermaProdotti
            // 
            this.btnConfermaProdotti.Location = new System.Drawing.Point(70, 306);
            this.btnConfermaProdotti.Name = "btnConfermaProdotti";
            this.btnConfermaProdotti.Size = new System.Drawing.Size(118, 75);
            this.btnConfermaProdotti.TabIndex = 29;
            this.btnConfermaProdotti.Text = " ";
            this.btnConfermaProdotti.UseVisualStyleBackColor = true;
            this.btnConfermaProdotti.Click += new System.EventHandler(this.btnConfermaProdotti_Click);
            // 
            // chkAnnullaValProdotto
            // 
            this.chkAnnullaValProdotto.AutoSize = true;
            this.chkAnnullaValProdotto.Location = new System.Drawing.Point(155, 248);
            this.chkAnnullaValProdotto.Name = "chkAnnullaValProdotto";
            this.chkAnnullaValProdotto.Size = new System.Drawing.Size(77, 21);
            this.chkAnnullaValProdotto.TabIndex = 28;
            this.chkAnnullaValProdotto.Text = "Annulla";
            this.chkAnnullaValProdotto.UseVisualStyleBackColor = true;
            // 
            // btnAnnullaProdotti
            // 
            this.btnAnnullaProdotti.Location = new System.Drawing.Point(213, 306);
            this.btnAnnullaProdotti.Name = "btnAnnullaProdotti";
            this.btnAnnullaProdotti.Size = new System.Drawing.Size(117, 75);
            this.btnAnnullaProdotti.TabIndex = 27;
            this.btnAnnullaProdotti.Text = "Annulla";
            this.btnAnnullaProdotti.UseVisualStyleBackColor = true;
            this.btnAnnullaProdotti.Click += new System.EventHandler(this.btnAnnullaProdotti_Click);
            // 
            // txtCittaProdotti
            // 
            this.txtCittaProdotti.Location = new System.Drawing.Point(101, 191);
            this.txtCittaProdotti.Name = "txtCittaProdotti";
            this.txtCittaProdotti.Size = new System.Drawing.Size(218, 22);
            this.txtCittaProdotti.TabIndex = 26;
            // 
            // txtNomeProdotto
            // 
            this.txtNomeProdotto.Location = new System.Drawing.Point(101, 153);
            this.txtNomeProdotto.Name = "txtNomeProdotto";
            this.txtNomeProdotto.Size = new System.Drawing.Size(218, 22);
            this.txtNomeProdotto.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Nome";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 194);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = "Città";
            // 
            // lblCodiceProdotto
            // 
            this.lblCodiceProdotto.AutoSize = true;
            this.lblCodiceProdotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodiceProdotto.ForeColor = System.Drawing.Color.Blue;
            this.lblCodiceProdotto.Location = new System.Drawing.Point(219, 98);
            this.lblCodiceProdotto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodiceProdotto.Name = "lblCodiceProdotto";
            this.lblCodiceProdotto.Size = new System.Drawing.Size(0, 17);
            this.lblCodiceProdotto.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(76, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 17);
            this.label16.TabIndex = 21;
            this.label16.Text = "Codice inquinante:";
            // 
            // grpElencoProdotti
            // 
            this.grpElencoProdotti.Controls.Add(this.label15);
            this.grpElencoProdotti.Controls.Add(this.chkAggiungiAnnullateProdotti);
            this.grpElencoProdotti.Controls.Add(this.dgvProdotti);
            this.grpElencoProdotti.Controls.Add(this.btnAggiungiProdotto);
            this.grpElencoProdotti.Controls.Add(this.cmbProdotti);
            this.grpElencoProdotti.Location = new System.Drawing.Point(3, 24);
            this.grpElencoProdotti.Name = "grpElencoProdotti";
            this.grpElencoProdotti.Size = new System.Drawing.Size(853, 455);
            this.grpElencoProdotti.TabIndex = 0;
            this.grpElencoProdotti.TabStop = false;
            this.grpElencoProdotti.Text = "Elenco prodotti";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 386);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 17);
            this.label15.TabIndex = 24;
            this.label15.Text = "Prodotti:";
            // 
            // chkAggiungiAnnullateProdotti
            // 
            this.chkAggiungiAnnullateProdotti.AutoSize = true;
            this.chkAggiungiAnnullateProdotti.Location = new System.Drawing.Point(639, 29);
            this.chkAggiungiAnnullateProdotti.Name = "chkAggiungiAnnullateProdotti";
            this.chkAggiungiAnnullateProdotti.Size = new System.Drawing.Size(145, 21);
            this.chkAggiungiAnnullateProdotti.TabIndex = 23;
            this.chkAggiungiAnnullateProdotti.Text = "Aggiungi Annulate";
            this.chkAggiungiAnnullateProdotti.UseVisualStyleBackColor = true;
            this.chkAggiungiAnnullateProdotti.CheckedChanged += new System.EventHandler(this.chkAggiungiAnnullateProdotti_CheckedChanged);
            // 
            // dgvProdotti
            // 
            this.dgvProdotti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdotti.Location = new System.Drawing.Point(-3, 61);
            this.dgvProdotti.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProdotti.Name = "dgvProdotti";
            this.dgvProdotti.RowHeadersWidth = 51;
            this.dgvProdotti.Size = new System.Drawing.Size(859, 284);
            this.dgvProdotti.TabIndex = 20;
            // 
            // btnAggiungiProdotto
            // 
            this.btnAggiungiProdotto.Location = new System.Drawing.Point(582, 369);
            this.btnAggiungiProdotto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAggiungiProdotto.Name = "btnAggiungiProdotto";
            this.btnAggiungiProdotto.Size = new System.Drawing.Size(207, 57);
            this.btnAggiungiProdotto.TabIndex = 22;
            this.btnAggiungiProdotto.Text = "Aggiungi prodotto";
            this.btnAggiungiProdotto.UseVisualStyleBackColor = true;
            this.btnAggiungiProdotto.Click += new System.EventHandler(this.btnAggiungiProdotto_Click);
            // 
            // cmbProdotti
            // 
            this.cmbProdotti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdotti.FormattingEnabled = true;
            this.cmbProdotti.Location = new System.Drawing.Point(113, 386);
            this.cmbProdotti.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProdotti.Name = "cmbProdotti";
            this.cmbProdotti.Size = new System.Drawing.Size(444, 24);
            this.cmbProdotti.TabIndex = 21;
            this.cmbProdotti.SelectedIndexChanged += new System.EventHandler(this.cmbProdotti_SelectedIndexChanged);
            // 
            // Scarichi
            // 
            this.Scarichi.Controls.Add(this.GrpModificaScarichi);
            this.Scarichi.Controls.Add(this.grpElencoScarichi);
            this.Scarichi.Location = new System.Drawing.Point(4, 25);
            this.Scarichi.Margin = new System.Windows.Forms.Padding(4);
            this.Scarichi.Name = "Scarichi";
            this.Scarichi.Size = new System.Drawing.Size(1256, 479);
            this.Scarichi.TabIndex = 4;
            this.Scarichi.Text = "Scarichi";
            this.Scarichi.UseVisualStyleBackColor = true;
            this.Scarichi.Enter += new System.EventHandler(this.loadScarichi);
            // 
            // GrpModificaScarichi
            // 
            this.GrpModificaScarichi.Controls.Add(this.cmbCodProd);
            this.GrpModificaScarichi.Controls.Add(this.cmbCodInq);
            this.GrpModificaScarichi.Controls.Add(this.cmbCodAzienda);
            this.GrpModificaScarichi.Controls.Add(this.label20);
            this.GrpModificaScarichi.Controls.Add(this.label22);
            this.GrpModificaScarichi.Controls.Add(this.nmbQuantita);
            this.GrpModificaScarichi.Controls.Add(this.btnConferma_Scarico);
            this.GrpModificaScarichi.Controls.Add(this.chkAnnullaValScarico);
            this.GrpModificaScarichi.Controls.Add(this.btnAnnulla_Scarico);
            this.GrpModificaScarichi.Controls.Add(this.lblAzienda);
            this.GrpModificaScarichi.Controls.Add(this.label19);
            this.GrpModificaScarichi.Controls.Add(this.lblCodiceScarico);
            this.GrpModificaScarichi.Controls.Add(this.label21);
            this.GrpModificaScarichi.Location = new System.Drawing.Point(878, 23);
            this.GrpModificaScarichi.Name = "GrpModificaScarichi";
            this.GrpModificaScarichi.Size = new System.Drawing.Size(375, 453);
            this.GrpModificaScarichi.TabIndex = 1;
            this.GrpModificaScarichi.TabStop = false;
            this.GrpModificaScarichi.Text = "Gestione scarichi";
            // 
            // cmbCodProd
            // 
            this.cmbCodProd.FormattingEnabled = true;
            this.cmbCodProd.Location = new System.Drawing.Point(109, 166);
            this.cmbCodProd.Name = "cmbCodProd";
            this.cmbCodProd.Size = new System.Drawing.Size(218, 24);
            this.cmbCodProd.TabIndex = 46;
            // 
            // cmbCodInq
            // 
            this.cmbCodInq.FormattingEnabled = true;
            this.cmbCodInq.Location = new System.Drawing.Point(109, 136);
            this.cmbCodInq.Name = "cmbCodInq";
            this.cmbCodInq.Size = new System.Drawing.Size(218, 24);
            this.cmbCodInq.TabIndex = 45;
            // 
            // cmbCodAzienda
            // 
            this.cmbCodAzienda.FormattingEnabled = true;
            this.cmbCodAzienda.Location = new System.Drawing.Point(109, 98);
            this.cmbCodAzienda.Name = "cmbCodAzienda";
            this.cmbCodAzienda.Size = new System.Drawing.Size(218, 24);
            this.cmbCodAzienda.TabIndex = 43;
            this.cmbCodAzienda.SelectedIndexChanged += new System.EventHandler(this.cmbCodAzienda_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 167);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 17);
            this.label20.TabIndex = 42;
            this.label20.Text = "Prodotto:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(21, 201);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(66, 17);
            this.label22.TabIndex = 41;
            this.label22.Text = "Quantità:";
            // 
            // nmbQuantita
            // 
            this.nmbQuantita.Location = new System.Drawing.Point(109, 199);
            this.nmbQuantita.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nmbQuantita.Name = "nmbQuantita";
            this.nmbQuantita.Size = new System.Drawing.Size(218, 22);
            this.nmbQuantita.TabIndex = 40;
            // 
            // btnConferma_Scarico
            // 
            this.btnConferma_Scarico.Location = new System.Drawing.Point(67, 359);
            this.btnConferma_Scarico.Name = "btnConferma_Scarico";
            this.btnConferma_Scarico.Size = new System.Drawing.Size(118, 75);
            this.btnConferma_Scarico.TabIndex = 38;
            this.btnConferma_Scarico.Text = " ";
            this.btnConferma_Scarico.UseVisualStyleBackColor = true;
            this.btnConferma_Scarico.Click += new System.EventHandler(this.btnConferma_Scarico_Click);
            // 
            // chkAnnullaValScarico
            // 
            this.chkAnnullaValScarico.AutoSize = true;
            this.chkAnnullaValScarico.Location = new System.Drawing.Point(174, 271);
            this.chkAnnullaValScarico.Name = "chkAnnullaValScarico";
            this.chkAnnullaValScarico.Size = new System.Drawing.Size(77, 21);
            this.chkAnnullaValScarico.TabIndex = 37;
            this.chkAnnullaValScarico.Text = "Annulla";
            this.chkAnnullaValScarico.UseVisualStyleBackColor = true;
            // 
            // btnAnnulla_Scarico
            // 
            this.btnAnnulla_Scarico.Location = new System.Drawing.Point(210, 359);
            this.btnAnnulla_Scarico.Name = "btnAnnulla_Scarico";
            this.btnAnnulla_Scarico.Size = new System.Drawing.Size(117, 75);
            this.btnAnnulla_Scarico.TabIndex = 36;
            this.btnAnnulla_Scarico.Text = "Annulla";
            this.btnAnnulla_Scarico.UseVisualStyleBackColor = true;
            this.btnAnnulla_Scarico.Click += new System.EventHandler(this.btnAnnulla_Scarico_Click);
            // 
            // lblAzienda
            // 
            this.lblAzienda.AutoSize = true;
            this.lblAzienda.Location = new System.Drawing.Point(21, 101);
            this.lblAzienda.Name = "lblAzienda";
            this.lblAzienda.Size = new System.Drawing.Size(63, 17);
            this.lblAzienda.TabIndex = 33;
            this.lblAzienda.Text = "Azienda:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 139);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 17);
            this.label19.TabIndex = 32;
            this.label19.Text = "Inquinante:";
            // 
            // lblCodiceScarico
            // 
            this.lblCodiceScarico.AutoSize = true;
            this.lblCodiceScarico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodiceScarico.ForeColor = System.Drawing.Color.Blue;
            this.lblCodiceScarico.Location = new System.Drawing.Point(227, 43);
            this.lblCodiceScarico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodiceScarico.Name = "lblCodiceScarico";
            this.lblCodiceScarico.Size = new System.Drawing.Size(0, 17);
            this.lblCodiceScarico.TabIndex = 31;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(84, 43);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 17);
            this.label21.TabIndex = 30;
            this.label21.Text = "Codice scarico:";
            // 
            // grpElencoScarichi
            // 
            this.grpElencoScarichi.Controls.Add(this.label17);
            this.grpElencoScarichi.Controls.Add(this.chkAggiungiScarichiAnnullati);
            this.grpElencoScarichi.Controls.Add(this.dgvScarichi);
            this.grpElencoScarichi.Controls.Add(this.btnAggiungiScarico);
            this.grpElencoScarichi.Controls.Add(this.cmbScarichi);
            this.grpElencoScarichi.Location = new System.Drawing.Point(3, 23);
            this.grpElencoScarichi.Name = "grpElencoScarichi";
            this.grpElencoScarichi.Size = new System.Drawing.Size(869, 453);
            this.grpElencoScarichi.TabIndex = 0;
            this.grpElencoScarichi.TabStop = false;
            this.grpElencoScarichi.Text = "Elenco scarichi";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 388);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 17);
            this.label17.TabIndex = 0;
            this.label17.Text = "Scarichi:";
            // 
            // chkAggiungiScarichiAnnullati
            // 
            this.chkAggiungiScarichiAnnullati.AutoSize = true;
            this.chkAggiungiScarichiAnnullati.Location = new System.Drawing.Point(632, 28);
            this.chkAggiungiScarichiAnnullati.Name = "chkAggiungiScarichiAnnullati";
            this.chkAggiungiScarichiAnnullati.Size = new System.Drawing.Size(140, 21);
            this.chkAggiungiScarichiAnnullati.TabIndex = 23;
            this.chkAggiungiScarichiAnnullati.Text = "Aggiungi Annulati";
            this.chkAggiungiScarichiAnnullati.UseVisualStyleBackColor = true;
            this.chkAggiungiScarichiAnnullati.CheckedChanged += new System.EventHandler(this.chkAggiungiScarichiAnnullati_CheckedChanged);
            // 
            // dgvScarichi
            // 
            this.dgvScarichi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScarichi.Location = new System.Drawing.Point(9, 56);
            this.dgvScarichi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvScarichi.Name = "dgvScarichi";
            this.dgvScarichi.RowHeadersWidth = 51;
            this.dgvScarichi.Size = new System.Drawing.Size(859, 284);
            this.dgvScarichi.TabIndex = 20;
            // 
            // btnAggiungiScarico
            // 
            this.btnAggiungiScarico.Location = new System.Drawing.Point(575, 368);
            this.btnAggiungiScarico.Margin = new System.Windows.Forms.Padding(4);
            this.btnAggiungiScarico.Name = "btnAggiungiScarico";
            this.btnAggiungiScarico.Size = new System.Drawing.Size(207, 57);
            this.btnAggiungiScarico.TabIndex = 22;
            this.btnAggiungiScarico.Text = "Aggiungi scarico";
            this.btnAggiungiScarico.UseVisualStyleBackColor = true;
            this.btnAggiungiScarico.Click += new System.EventHandler(this.btnAggiungiScarico_Click);
            // 
            // cmbScarichi
            // 
            this.cmbScarichi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScarichi.FormattingEnabled = true;
            this.cmbScarichi.Location = new System.Drawing.Point(106, 385);
            this.cmbScarichi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbScarichi.Name = "cmbScarichi";
            this.cmbScarichi.Size = new System.Drawing.Size(444, 24);
            this.cmbScarichi.TabIndex = 21;
            this.cmbScarichi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Aziende.ResumeLayout(false);
            this.grpElenco.ResumeLayout(false);
            this.grpElenco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAziende)).EndInit();
            this.grpDatiAzienda.ResumeLayout(false);
            this.grpDatiAzienda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDGrado)).EndInit();
            this.Inquinanti.ResumeLayout(false);
            this.grpModificaInquinanti.ResumeLayout(false);
            this.grpModificaInquinanti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbPesoSpecifico)).EndInit();
            this.grpElencoInquinanti.ResumeLayout(false);
            this.grpElencoInquinanti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInquinanti)).EndInit();
            this.Prodotti.ResumeLayout(false);
            this.grpGestioneProdotti.ResumeLayout(false);
            this.grpGestioneProdotti.PerformLayout();
            this.grpElencoProdotti.ResumeLayout(false);
            this.grpElencoProdotti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdotti)).EndInit();
            this.Scarichi.ResumeLayout(false);
            this.GrpModificaScarichi.ResumeLayout(false);
            this.GrpModificaScarichi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbQuantita)).EndInit();
            this.grpElencoScarichi.ResumeLayout(false);
            this.grpElencoScarichi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScarichi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Aziende;
        private System.Windows.Forms.TabPage Inquinanti;
        private System.Windows.Forms.ComboBox cmbAziende;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAziende;
        private System.Windows.Forms.TabPage Prodotti;
        private System.Windows.Forms.TabPage Scarichi;
        private System.Windows.Forms.CheckBox chkAziendeAnnullate;
        private System.Windows.Forms.GroupBox grpDatiAzienda;
        private System.Windows.Forms.Label lblCodice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAnnullaAziende;
        private System.Windows.Forms.Button btnConfermaAziende;
        private System.Windows.Forms.TextBox txtCitta;
        private System.Windows.Forms.NumericUpDown numUDGrado;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.CheckBox chkAnnulla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAggiungiAzienda;
        private System.Windows.Forms.GroupBox grpElenco;
        private System.Windows.Forms.GroupBox grpModificaInquinanti;
        private System.Windows.Forms.GroupBox grpElencoInquinanti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInquinanti;
        private System.Windows.Forms.Button btnAggiungiinquinante;
        private System.Windows.Forms.ComboBox cmbInquinanti;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCodInquinante;
        private System.Windows.Forms.Button btnAnnullaInquinamenti;
        private System.Windows.Forms.NumericUpDown nmbPesoSpecifico;
        private System.Windows.Forms.ComboBox cmbStato;
        private System.Windows.Forms.TextBox txtCittaInquinante;
        private System.Windows.Forms.TextBox txtNomeInquinante;
        private System.Windows.Forms.CheckBox chkAnnullaValInquinante;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnConfermaModifica;
        private System.Windows.Forms.CheckBox chkAggiungiInquinantiAnnullati;
        private System.Windows.Forms.GroupBox grpGestioneProdotti;
        private System.Windows.Forms.Button btnConfermaProdotti;
        private System.Windows.Forms.CheckBox chkAnnullaValProdotto;
        private System.Windows.Forms.Button btnAnnullaProdotti;
        private System.Windows.Forms.TextBox txtCittaProdotti;
        private System.Windows.Forms.TextBox txtNomeProdotto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCodiceProdotto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox grpElencoProdotti;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chkAggiungiAnnullateProdotti;
        private System.Windows.Forms.DataGridView dgvProdotti;
        private System.Windows.Forms.Button btnAggiungiProdotto;
        private System.Windows.Forms.ComboBox cmbProdotti;
        private System.Windows.Forms.GroupBox GrpModificaScarichi;
        private System.Windows.Forms.GroupBox grpElencoScarichi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chkAggiungiScarichiAnnullati;
        private System.Windows.Forms.DataGridView dgvScarichi;
        private System.Windows.Forms.Button btnAggiungiScarico;
        private System.Windows.Forms.ComboBox cmbScarichi;
        private System.Windows.Forms.Button btnConferma_Scarico;
        private System.Windows.Forms.CheckBox chkAnnullaValScarico;
        private System.Windows.Forms.Button btnAnnulla_Scarico;
        private System.Windows.Forms.Label lblAzienda;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblCodiceScarico;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown nmbQuantita;
        private System.Windows.Forms.ComboBox cmbCodProd;
        private System.Windows.Forms.ComboBox cmbCodInq;
        private System.Windows.Forms.ComboBox cmbCodAzienda;
    }
}

