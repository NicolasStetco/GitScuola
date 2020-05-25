namespace Biblioteca
{
    partial class frmLettori
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
            this.components = new System.ComponentModel.Container();
            this.grpElenco = new System.Windows.Forms.GroupBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.cmbLettori = new System.Windows.Forms.ComboBox();
            this.chkAggiungiAnnullati = new System.Windows.Forms.CheckBox();
            this.dgvElenco = new System.Windows.Forms.DataGridView();
            this.grpGestione = new System.Windows.Forms.GroupBox();
            this.txtTessera = new System.Windows.Forms.TextBox();
            this.btnConferma = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.lblCodice = new System.Windows.Forms.Label();
            this.chkAnnullaValditita = new System.Windows.Forms.CheckBox();
            this.lblNTessera = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpElenco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElenco)).BeginInit();
            this.grpGestione.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpElenco
            // 
            this.grpElenco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpElenco.Controls.Add(this.btnAggiungi);
            this.grpElenco.Controls.Add(this.cmbLettori);
            this.grpElenco.Controls.Add(this.chkAggiungiAnnullati);
            this.grpElenco.Controls.Add(this.dgvElenco);
            this.grpElenco.Location = new System.Drawing.Point(12, 12);
            this.grpElenco.Name = "grpElenco";
            this.grpElenco.Size = new System.Drawing.Size(811, 475);
            this.grpElenco.TabIndex = 0;
            this.grpElenco.TabStop = false;
            this.grpElenco.Text = "Elenco ";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAggiungi.Location = new System.Drawing.Point(292, 405);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(132, 50);
            this.btnAggiungi.TabIndex = 3;
            this.btnAggiungi.Text = "Aggiungi lettore";
            this.btnAggiungi.UseVisualStyleBackColor = false;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // cmbLettori
            // 
            this.cmbLettori.FormattingEnabled = true;
            this.cmbLettori.Location = new System.Drawing.Point(248, -13);
            this.cmbLettori.Name = "cmbLettori";
            this.cmbLettori.Size = new System.Drawing.Size(121, 24);
            this.cmbLettori.TabIndex = 2;
            this.cmbLettori.Visible = false;
            this.cmbLettori.SelectedIndexChanged += new System.EventHandler(this.cmbLettori_SelectedIndexChanged);
            // 
            // chkAggiungiAnnullati
            // 
            this.chkAggiungiAnnullati.AutoSize = true;
            this.chkAggiungiAnnullati.Location = new System.Drawing.Point(559, 421);
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
            // grpGestione
            // 
            this.grpGestione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpGestione.Controls.Add(this.txtTessera);
            this.grpGestione.Controls.Add(this.btnConferma);
            this.grpGestione.Controls.Add(this.btnAnnulla);
            this.grpGestione.Controls.Add(this.lblCodice);
            this.grpGestione.Controls.Add(this.chkAnnullaValditita);
            this.grpGestione.Controls.Add(this.lblNTessera);
            this.grpGestione.Controls.Add(this.label4);
            this.grpGestione.Controls.Add(this.label3);
            this.grpGestione.Controls.Add(this.label2);
            this.grpGestione.Controls.Add(this.label1);
            this.grpGestione.Controls.Add(this.txtNome);
            this.grpGestione.Controls.Add(this.txtMail);
            this.grpGestione.Controls.Add(this.txtCognome);
            this.grpGestione.Location = new System.Drawing.Point(829, 12);
            this.grpGestione.Name = "grpGestione";
            this.grpGestione.Size = new System.Drawing.Size(327, 475);
            this.grpGestione.TabIndex = 1;
            this.grpGestione.TabStop = false;
            this.grpGestione.Text = "Gestione";
            // 
            // txtTessera
            // 
            this.txtTessera.Location = new System.Drawing.Point(197, 274);
            this.txtTessera.Name = "txtTessera";
            this.txtTessera.Size = new System.Drawing.Size(90, 22);
            this.txtTessera.TabIndex = 12;
            // 
            // btnConferma
            // 
            this.btnConferma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConferma.Location = new System.Drawing.Point(34, 405);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(132, 50);
            this.btnConferma.TabIndex = 11;
            this.btnConferma.Text = "button1";
            this.btnConferma.UseVisualStyleBackColor = false;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAnnulla.Location = new System.Drawing.Point(172, 405);
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
            this.lblCodice.Location = new System.Drawing.Point(119, 30);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(62, 17);
            this.lblCodice.TabIndex = 9;
            this.lblCodice.Text = "Codice:";
            // 
            // chkAnnullaValditita
            // 
            this.chkAnnullaValditita.AutoSize = true;
            this.chkAnnullaValditita.Location = new System.Drawing.Point(107, 364);
            this.chkAnnullaValditita.Name = "chkAnnullaValditita";
            this.chkAnnullaValditita.Size = new System.Drawing.Size(125, 21);
            this.chkAnnullaValditita.TabIndex = 8;
            this.chkAnnullaValditita.Text = "Annulla validità";
            this.chkAnnullaValditita.UseVisualStyleBackColor = true;
            // 
            // lblNTessera
            // 
            this.lblNTessera.AutoSize = true;
            this.lblNTessera.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNTessera.Location = new System.Drawing.Point(119, 277);
            this.lblNTessera.Name = "lblNTessera";
            this.lblNTessera.Size = new System.Drawing.Size(74, 17);
            this.lblNTessera.TabIndex = 7;
            this.lblNTessera.Text = "NT2020_";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tessera:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cognome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(122, 164);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(165, 22);
            this.txtNome.TabIndex = 2;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(122, 224);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(165, 22);
            this.txtMail.TabIndex = 1;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(122, 107);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(165, 22);
            this.txtCognome.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmLettori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1168, 499);
            this.Controls.Add(this.grpGestione);
            this.Controls.Add(this.grpElenco);
            this.Name = "frmLettori";
            this.Text = "Lettori";
            this.Load += new System.EventHandler(this.frmLettori_Load);
            this.grpElenco.ResumeLayout(false);
            this.grpElenco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElenco)).EndInit();
            this.grpGestione.ResumeLayout(false);
            this.grpGestione.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpElenco;
        private System.Windows.Forms.GroupBox grpGestione;
        private System.Windows.Forms.DataGridView dgvElenco;
        private System.Windows.Forms.CheckBox chkAggiungiAnnullati;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label lblCodice;
        private System.Windows.Forms.CheckBox chkAnnullaValditita;
        private System.Windows.Forms.Label lblNTessera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbLettori;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.TextBox txtTessera;
    }
}