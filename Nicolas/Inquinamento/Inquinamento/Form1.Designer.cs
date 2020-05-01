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
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.chkAziendeAnnullate = new System.Windows.Forms.CheckBox();
            this.cmbAziende = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpDatiAzienda = new System.Windows.Forms.GroupBox();
            this.lblCodice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnConferma = new System.Windows.Forms.Button();
            this.txtCitta = new System.Windows.Forms.TextBox();
            this.numUDGrado = new System.Windows.Forms.NumericUpDown();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.chkAnnulla = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Inquinanti = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkInquinantiAnnullati = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInquinanti = new System.Windows.Forms.DataGridView();
            this.btnAggiungiinquinante = new System.Windows.Forms.Button();
            this.cmbInquinanti = new System.Windows.Forms.ComboBox();
            this.Prodotti = new System.Windows.Forms.TabPage();
            this.Scarichi = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Aziende.SuspendLayout();
            this.grpElenco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAziende)).BeginInit();
            this.grpDatiAzienda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDGrado)).BeginInit();
            this.Inquinanti.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInquinanti)).BeginInit();
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
            this.grpElenco.Controls.Add(this.btnAggiungi);
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
            this.dgvAziende.SelectionChanged += new System.EventHandler(this.dgvAziende_SelectionChanged);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(553, 348);
            this.btnAggiungi.Margin = new System.Windows.Forms.Padding(4);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(207, 57);
            this.btnAggiungi.TabIndex = 6;
            this.btnAggiungi.Text = "Aggiungi Azienda";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
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
            this.grpDatiAzienda.Controls.Add(this.btnAnnulla);
            this.grpDatiAzienda.Controls.Add(this.btnConferma);
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
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(245, 346);
            this.btnAnnulla.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(100, 28);
            this.btnAnnulla.TabIndex = 9;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(112, 346);
            this.btnConferma.Margin = new System.Windows.Forms.Padding(4);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(100, 28);
            this.btnConferma.TabIndex = 8;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
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
            this.Inquinanti.Controls.Add(this.groupBox2);
            this.Inquinanti.Controls.Add(this.groupBox1);
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
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(886, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 443);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elenco inquinanti";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkInquinantiAnnullati);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvInquinanti);
            this.groupBox1.Controls.Add(this.btnAggiungiinquinante);
            this.groupBox1.Controls.Add(this.cmbInquinanti);
            this.groupBox1.Location = new System.Drawing.Point(7, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 439);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elenco inquinanti";
            // 
            // chkInquinantiAnnullati
            // 
            this.chkInquinantiAnnullati.AutoSize = true;
            this.chkInquinantiAnnullati.Location = new System.Drawing.Point(664, 21);
            this.chkInquinantiAnnullati.Name = "chkInquinantiAnnullati";
            this.chkInquinantiAnnullati.Size = new System.Drawing.Size(142, 21);
            this.chkInquinantiAnnullati.TabIndex = 2;
            this.chkInquinantiAnnullati.Text = "Aggiungi annullati";
            this.chkInquinantiAnnullati.UseVisualStyleBackColor = true;
            this.chkInquinantiAnnullati.CheckedChanged += new System.EventHandler(this.chkInquinantiAnnullati_CheckedChanged);
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
            // 
            // Prodotti
            // 
            this.Prodotti.Location = new System.Drawing.Point(4, 25);
            this.Prodotti.Margin = new System.Windows.Forms.Padding(4);
            this.Prodotti.Name = "Prodotti";
            this.Prodotti.Size = new System.Drawing.Size(1256, 479);
            this.Prodotti.TabIndex = 3;
            this.Prodotti.Text = "Prodotti";
            this.Prodotti.UseVisualStyleBackColor = true;
            // 
            // Scarichi
            // 
            this.Scarichi.Location = new System.Drawing.Point(4, 25);
            this.Scarichi.Margin = new System.Windows.Forms.Padding(4);
            this.Scarichi.Name = "Scarichi";
            this.Scarichi.Size = new System.Drawing.Size(1256, 479);
            this.Scarichi.TabIndex = 4;
            this.Scarichi.Text = "Scarichi";
            this.Scarichi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInquinanti)).EndInit();
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
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.TextBox txtCitta;
        private System.Windows.Forms.NumericUpDown numUDGrado;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.CheckBox chkAnnulla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.GroupBox grpElenco;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInquinanti;
        private System.Windows.Forms.Button btnAggiungiinquinante;
        private System.Windows.Forms.ComboBox cmbInquinanti;
        private System.Windows.Forms.CheckBox chkInquinantiAnnullati;
    }
}

