namespace Biblioteca
{
    partial class frmSchedaLibro
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
            this.cmbPrestatiNONVISIBILE = new System.Windows.Forms.ComboBox();
            this.ptbCopertina = new System.Windows.Forms.PictureBox();
            this.dgvElenco = new System.Windows.Forms.DataGridView();
            this.cmbLibri = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAggiungiAnnullati = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAutore = new System.Windows.Forms.Label();
            this.lblGenere = new System.Windows.Forms.Label();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.cmbLettori = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCopertina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElenco)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPrestatiNONVISIBILE
            // 
            this.cmbPrestatiNONVISIBILE.FormattingEnabled = true;
            this.cmbPrestatiNONVISIBILE.Location = new System.Drawing.Point(332, -35);
            this.cmbPrestatiNONVISIBILE.Name = "cmbPrestatiNONVISIBILE";
            this.cmbPrestatiNONVISIBILE.Size = new System.Drawing.Size(121, 24);
            this.cmbPrestatiNONVISIBILE.TabIndex = 13;
            this.cmbPrestatiNONVISIBILE.Visible = false;
            // 
            // ptbCopertina
            // 
            this.ptbCopertina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptbCopertina.ImageLocation = "";
            this.ptbCopertina.Location = new System.Drawing.Point(949, 57);
            this.ptbCopertina.Name = "ptbCopertina";
            this.ptbCopertina.Size = new System.Drawing.Size(124, 181);
            this.ptbCopertina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCopertina.TabIndex = 12;
            this.ptbCopertina.TabStop = false;
            // 
            // dgvElenco
            // 
            this.dgvElenco.AllowUserToOrderColumns = true;
            this.dgvElenco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElenco.Location = new System.Drawing.Point(20, 69);
            this.dgvElenco.Name = "dgvElenco";
            this.dgvElenco.RowHeadersWidth = 51;
            this.dgvElenco.RowTemplate.Height = 24;
            this.dgvElenco.Size = new System.Drawing.Size(798, 446);
            this.dgvElenco.TabIndex = 11;
            this.dgvElenco.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestati_CellContentClick);
            // 
            // cmbLibri
            // 
            this.cmbLibri.FormattingEnabled = true;
            this.cmbLibri.Location = new System.Drawing.Point(198, 21);
            this.cmbLibri.Name = "cmbLibri";
            this.cmbLibri.Size = new System.Drawing.Size(121, 24);
            this.cmbLibri.TabIndex = 14;
            this.cmbLibri.Visible = false;
            this.cmbLibri.SelectedIndexChanged += new System.EventHandler(this.cmbLibri_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbLettori);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblAutore);
            this.groupBox1.Controls.Add(this.lblGenere);
            this.groupBox1.Controls.Add(this.lblTitolo);
            this.groupBox1.Controls.Add(this.chkAggiungiAnnullati);
            this.groupBox1.Controls.Add(this.dgvElenco);
            this.groupBox1.Controls.Add(this.cmbLibri);
            this.groupBox1.Controls.Add(this.ptbCopertina);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1230, 538);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elenco ";
            // 
            // chkAggiungiAnnullati
            // 
            this.chkAggiungiAnnullati.AutoSize = true;
            this.chkAggiungiAnnullati.Location = new System.Drawing.Point(560, 33);
            this.chkAggiungiAnnullati.Name = "chkAggiungiAnnullati";
            this.chkAggiungiAnnullati.Size = new System.Drawing.Size(142, 21);
            this.chkAggiungiAnnullati.TabIndex = 15;
            this.chkAggiungiAnnullati.Text = "Aggiungi annullati";
            this.chkAggiungiAnnullati.UseVisualStyleBackColor = true;
            this.chkAggiungiAnnullati.CheckedChanged += new System.EventHandler(this.chkAggiungiAnnullati_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(930, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Autore:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(930, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Genere:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(930, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Titolo: ";
            // 
            // lblAutore
            // 
            this.lblAutore.AutoSize = true;
            this.lblAutore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutore.Location = new System.Drawing.Point(1011, 293);
            this.lblAutore.Name = "lblAutore";
            this.lblAutore.Size = new System.Drawing.Size(0, 17);
            this.lblAutore.TabIndex = 19;
            // 
            // lblGenere
            // 
            this.lblGenere.AutoSize = true;
            this.lblGenere.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenere.Location = new System.Drawing.Point(1011, 327);
            this.lblGenere.Name = "lblGenere";
            this.lblGenere.Size = new System.Drawing.Size(0, 17);
            this.lblGenere.TabIndex = 18;
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.Location = new System.Drawing.Point(1011, 262);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(0, 17);
            this.lblTitolo.TabIndex = 16;
            // 
            // cmbLettori
            // 
            this.cmbLettori.FormattingEnabled = true;
            this.cmbLettori.Location = new System.Drawing.Point(1014, 369);
            this.cmbLettori.Name = "cmbLettori";
            this.cmbLettori.Size = new System.Drawing.Size(160, 24);
            this.cmbLettori.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(874, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Richiesta dal lettore:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(949, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 54);
            this.button1.TabIndex = 26;
            this.button1.Text = "Crea scheda libro";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSchedaLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1254, 559);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbPrestatiNONVISIBILE);
            this.Name = "frmSchedaLibro";
            this.Text = "Schede libro";
            this.Load += new System.EventHandler(this.frmSchedaLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCopertina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElenco)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPrestatiNONVISIBILE;
        private System.Windows.Forms.PictureBox ptbCopertina;
        private System.Windows.Forms.DataGridView dgvElenco;
        private System.Windows.Forms.ComboBox cmbLibri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAggiungiAnnullati;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAutore;
        private System.Windows.Forms.Label lblGenere;
        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLettori;
    }
}