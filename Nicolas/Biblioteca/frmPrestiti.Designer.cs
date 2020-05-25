namespace Biblioteca
{
    partial class frmPrestiti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpGestione = new System.Windows.Forms.GroupBox();
            this.chkRestituito = new System.Windows.Forms.CheckBox();
            this.dtpRestituzione = new System.Windows.Forms.DateTimePicker();
            this.dtpPrestito = new System.Windows.Forms.DateTimePicker();
            this.cmbLibro = new System.Windows.Forms.ComboBox();
            this.pctCopertina = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLettore = new System.Windows.Forms.ComboBox();
            this.btnConferma = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.lblCodice = new System.Windows.Forms.Label();
            this.chkAnnullaValditita = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpElenco = new System.Windows.Forms.GroupBox();
            this.chkFiltraGenere = new System.Windows.Forms.CheckBox();
            this.cmbGenere = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSoloNonRestituiti = new System.Windows.Forms.CheckBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.cmbPrestiti = new System.Windows.Forms.ComboBox();
            this.chkAggiungiAnnullati = new System.Windows.Forms.CheckBox();
            this.dgvElenco = new System.Windows.Forms.DataGridView();
            this.grpGestione.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCopertina)).BeginInit();
            this.grpElenco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElenco)).BeginInit();
            this.SuspendLayout();
            // 
            // grpGestione
            // 
            this.grpGestione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpGestione.Controls.Add(this.chkRestituito);
            this.grpGestione.Controls.Add(this.dtpRestituzione);
            this.grpGestione.Controls.Add(this.dtpPrestito);
            this.grpGestione.Controls.Add(this.cmbLibro);
            this.grpGestione.Controls.Add(this.pctCopertina);
            this.grpGestione.Controls.Add(this.label5);
            this.grpGestione.Controls.Add(this.cmbLettore);
            this.grpGestione.Controls.Add(this.btnConferma);
            this.grpGestione.Controls.Add(this.btnAnnulla);
            this.grpGestione.Controls.Add(this.lblCodice);
            this.grpGestione.Controls.Add(this.chkAnnullaValditita);
            this.grpGestione.Controls.Add(this.label3);
            this.grpGestione.Controls.Add(this.label2);
            this.grpGestione.Controls.Add(this.label1);
            this.grpGestione.Location = new System.Drawing.Point(820, 12);
            this.grpGestione.Name = "grpGestione";
            this.grpGestione.Size = new System.Drawing.Size(369, 475);
            this.grpGestione.TabIndex = 5;
            this.grpGestione.TabStop = false;
            this.grpGestione.Text = "Gestione";
            // 
            // chkRestituito
            // 
            this.chkRestituito.AutoSize = true;
            this.chkRestituito.Enabled = false;
            this.chkRestituito.Location = new System.Drawing.Point(21, 260);
            this.chkRestituito.Name = "chkRestituito";
            this.chkRestituito.Size = new System.Drawing.Size(89, 21);
            this.chkRestituito.TabIndex = 23;
            this.chkRestituito.Text = "Restituito";
            this.chkRestituito.UseVisualStyleBackColor = true;
            this.chkRestituito.CheckedChanged += new System.EventHandler(this.chkRestituito_CheckedChanged_1);
            // 
            // dtpRestituzione
            // 
            this.dtpRestituzione.Location = new System.Drawing.Point(136, 175);
            this.dtpRestituzione.Name = "dtpRestituzione";
            this.dtpRestituzione.Size = new System.Drawing.Size(218, 22);
            this.dtpRestituzione.TabIndex = 22;
            // 
            // dtpPrestito
            // 
            this.dtpPrestito.Location = new System.Drawing.Point(136, 147);
            this.dtpPrestito.Name = "dtpPrestito";
            this.dtpPrestito.Size = new System.Drawing.Size(218, 22);
            this.dtpPrestito.TabIndex = 21;
            // 
            // cmbLibro
            // 
            this.cmbLibro.FormattingEnabled = true;
            this.cmbLibro.Location = new System.Drawing.Point(136, 83);
            this.cmbLibro.Name = "cmbLibro";
            this.cmbLibro.Size = new System.Drawing.Size(218, 24);
            this.cmbLibro.TabIndex = 20;
            // 
            // pctCopertina
            // 
            this.pctCopertina.Location = new System.Drawing.Point(186, 203);
            this.pctCopertina.Name = "pctCopertina";
            this.pctCopertina.Size = new System.Drawing.Size(168, 172);
            this.pctCopertina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctCopertina.TabIndex = 19;
            this.pctCopertina.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Data prestito:";
            // 
            // cmbLettore
            // 
            this.cmbLettore.FormattingEnabled = true;
            this.cmbLettore.Location = new System.Drawing.Point(136, 114);
            this.cmbLettore.Name = "cmbLettore";
            this.cmbLettore.Size = new System.Drawing.Size(218, 24);
            this.cmbLettore.TabIndex = 13;
            // 
            // btnConferma
            // 
            this.btnConferma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConferma.Location = new System.Drawing.Point(53, 405);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(132, 50);
            this.btnConferma.TabIndex = 11;
            this.btnConferma.Text = "button1";
            this.btnConferma.UseVisualStyleBackColor = false;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click_1);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAnnulla.Location = new System.Drawing.Point(191, 405);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(132, 50);
            this.btnAnnulla.TabIndex = 10;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = false;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodice.Location = new System.Drawing.Point(79, 34);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(67, 17);
            this.lblCodice.TabIndex = 9;
            this.lblCodice.Text = "Codice: ";
            // 
            // chkAnnullaValditita
            // 
            this.chkAnnullaValditita.AutoSize = true;
            this.chkAnnullaValditita.Location = new System.Drawing.Point(21, 309);
            this.chkAnnullaValditita.Name = "chkAnnullaValditita";
            this.chkAnnullaValditita.Size = new System.Drawing.Size(125, 21);
            this.chkAnnullaValditita.TabIndex = 8;
            this.chkAnnullaValditita.Text = "Annulla validità";
            this.chkAnnullaValditita.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lettore:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data restituzione:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Libro:";
            // 
            // grpElenco
            // 
            this.grpElenco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpElenco.Controls.Add(this.chkFiltraGenere);
            this.grpElenco.Controls.Add(this.cmbGenere);
            this.grpElenco.Controls.Add(this.label4);
            this.grpElenco.Controls.Add(this.chkSoloNonRestituiti);
            this.grpElenco.Controls.Add(this.btnAggiungi);
            this.grpElenco.Controls.Add(this.cmbPrestiti);
            this.grpElenco.Controls.Add(this.chkAggiungiAnnullati);
            this.grpElenco.Controls.Add(this.dgvElenco);
            this.grpElenco.Location = new System.Drawing.Point(3, 12);
            this.grpElenco.Name = "grpElenco";
            this.grpElenco.Size = new System.Drawing.Size(811, 475);
            this.grpElenco.TabIndex = 4;
            this.grpElenco.TabStop = false;
            this.grpElenco.Text = "Elenco ";
            // 
            // chkFiltraGenere
            // 
            this.chkFiltraGenere.AutoSize = true;
            this.chkFiltraGenere.Location = new System.Drawing.Point(397, 405);
            this.chkFiltraGenere.Name = "chkFiltraGenere";
            this.chkFiltraGenere.Size = new System.Drawing.Size(135, 21);
            this.chkFiltraGenere.TabIndex = 7;
            this.chkFiltraGenere.Text = "Filtra per genere";
            this.chkFiltraGenere.UseVisualStyleBackColor = true;
            this.chkFiltraGenere.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cmbGenere
            // 
            this.cmbGenere.FormattingEnabled = true;
            this.cmbGenere.Location = new System.Drawing.Point(397, 445);
            this.cmbGenere.Name = "cmbGenere";
            this.cmbGenere.Size = new System.Drawing.Size(212, 24);
            this.cmbGenere.TabIndex = 6;
            this.cmbGenere.SelectedIndexChanged += new System.EventHandler(this.cmbGenere_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seleziona genere:";
            // 
            // chkSoloNonRestituiti
            // 
            this.chkSoloNonRestituiti.AutoSize = true;
            this.chkSoloNonRestituiti.Location = new System.Drawing.Point(24, 405);
            this.chkSoloNonRestituiti.Name = "chkSoloNonRestituiti";
            this.chkSoloNonRestituiti.Size = new System.Drawing.Size(211, 21);
            this.chkSoloNonRestituiti.TabIndex = 4;
            this.chkSoloNonRestituiti.Text = "Visualizza solo i non restituiti";
            this.chkSoloNonRestituiti.UseVisualStyleBackColor = true;
            this.chkSoloNonRestituiti.CheckedChanged += new System.EventHandler(this.chkSoloNonRestituiti_CheckedChanged);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAggiungi.Location = new System.Drawing.Point(657, 405);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(132, 50);
            this.btnAggiungi.TabIndex = 3;
            this.btnAggiungi.Text = "Aggiungi prestito";
            this.btnAggiungi.UseVisualStyleBackColor = false;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // cmbPrestiti
            // 
            this.cmbPrestiti.FormattingEnabled = true;
            this.cmbPrestiti.Location = new System.Drawing.Point(255, 4);
            this.cmbPrestiti.Name = "cmbPrestiti";
            this.cmbPrestiti.Size = new System.Drawing.Size(121, 24);
            this.cmbPrestiti.TabIndex = 2;
            this.cmbPrestiti.Visible = false;
            this.cmbPrestiti.SelectedIndexChanged += new System.EventHandler(this.cmbPrestiti_SelectedIndexChanged_1);
            // 
            // chkAggiungiAnnullati
            // 
            this.chkAggiungiAnnullati.AutoSize = true;
            this.chkAggiungiAnnullati.Location = new System.Drawing.Point(24, 448);
            this.chkAggiungiAnnullati.Name = "chkAggiungiAnnullati";
            this.chkAggiungiAnnullati.Size = new System.Drawing.Size(142, 21);
            this.chkAggiungiAnnullati.TabIndex = 1;
            this.chkAggiungiAnnullati.Text = "Aggiungi annullati";
            this.chkAggiungiAnnullati.UseVisualStyleBackColor = true;
            this.chkAggiungiAnnullati.CheckedChanged += new System.EventHandler(this.chkAggiungiAnnullati_CheckedChanged);
            // 
            // dgvElenco
            // 
            this.dgvElenco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElenco.Location = new System.Drawing.Point(6, 34);
            this.dgvElenco.Name = "dgvElenco";
            this.dgvElenco.RowHeadersWidth = 51;
            this.dgvElenco.RowTemplate.Height = 24;
            this.dgvElenco.Size = new System.Drawing.Size(799, 351);
            this.dgvElenco.TabIndex = 0;
            // 
            // frmPrestiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1198, 493);
            this.Controls.Add(this.grpGestione);
            this.Controls.Add(this.grpElenco);
            this.Name = "frmPrestiti";
            this.Text = "frmPrestiti";
            this.Load += new System.EventHandler(this.frmPrestiti_Load);
            this.grpGestione.ResumeLayout(false);
            this.grpGestione.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCopertina)).EndInit();
            this.grpElenco.ResumeLayout(false);
            this.grpElenco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElenco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGestione;
        private System.Windows.Forms.PictureBox pctCopertina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLettore;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Label lblCodice;
        private System.Windows.Forms.CheckBox chkAnnullaValditita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpElenco;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.ComboBox cmbPrestiti;
        private System.Windows.Forms.CheckBox chkAggiungiAnnullati;
        private System.Windows.Forms.DataGridView dgvElenco;
        private System.Windows.Forms.DateTimePicker dtpRestituzione;
        private System.Windows.Forms.DateTimePicker dtpPrestito;
        private System.Windows.Forms.ComboBox cmbLibro;
        private System.Windows.Forms.CheckBox chkRestituito;
        private System.Windows.Forms.CheckBox chkSoloNonRestituiti;
        private System.Windows.Forms.ComboBox cmbGenere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkFiltraGenere;
    }
}