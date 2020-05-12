namespace Biblioteca
{
    partial class frmHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovoLettoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedaLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestitiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaRiservataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneLibriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneUtentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneGeneriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpElencoPrestiti = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPrestatiNONVISIBILE = new System.Windows.Forms.ComboBox();
            this.lblAutore = new System.Windows.Forms.Label();
            this.lblGenere = new System.Windows.Forms.Label();
            this.lblDataPrestito = new System.Windows.Forms.Label();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.ptbCopertina = new System.Windows.Forms.PictureBox();
            this.dgvPrestati = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.grpElencoPrestiti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCopertina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestati)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestioneToolStripMenuItem,
            this.areaRiservataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1277, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestioneToolStripMenuItem
            // 
            this.gestioneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovoLettoreToolStripMenuItem,
            this.schedaLibroToolStripMenuItem,
            this.prestitiToolStripMenuItem});
            this.gestioneToolStripMenuItem.Name = "gestioneToolStripMenuItem";
            this.gestioneToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.gestioneToolStripMenuItem.Text = "Gestione";
            // 
            // nuovoLettoreToolStripMenuItem
            // 
            this.nuovoLettoreToolStripMenuItem.Name = "nuovoLettoreToolStripMenuItem";
            this.nuovoLettoreToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nuovoLettoreToolStripMenuItem.Text = "Lettori";
            this.nuovoLettoreToolStripMenuItem.Click += new System.EventHandler(this.nuovoLettoreToolStripMenuItem_Click);
            // 
            // schedaLibroToolStripMenuItem
            // 
            this.schedaLibroToolStripMenuItem.Name = "schedaLibroToolStripMenuItem";
            this.schedaLibroToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.schedaLibroToolStripMenuItem.Text = "Scheda libro";
            // 
            // prestitiToolStripMenuItem
            // 
            this.prestitiToolStripMenuItem.Name = "prestitiToolStripMenuItem";
            this.prestitiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.prestitiToolStripMenuItem.Text = "Prestiti";
            // 
            // areaRiservataToolStripMenuItem
            // 
            this.areaRiservataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestioneLibriToolStripMenuItem,
            this.gestioneUtentiToolStripMenuItem,
            this.gestioneGeneriToolStripMenuItem});
            this.areaRiservataToolStripMenuItem.Name = "areaRiservataToolStripMenuItem";
            this.areaRiservataToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.areaRiservataToolStripMenuItem.Text = "Area riservata";
            // 
            // gestioneLibriToolStripMenuItem
            // 
            this.gestioneLibriToolStripMenuItem.Name = "gestioneLibriToolStripMenuItem";
            this.gestioneLibriToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.gestioneLibriToolStripMenuItem.Text = "Gestione libri";
            // 
            // gestioneUtentiToolStripMenuItem
            // 
            this.gestioneUtentiToolStripMenuItem.Name = "gestioneUtentiToolStripMenuItem";
            this.gestioneUtentiToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.gestioneUtentiToolStripMenuItem.Text = "Gestione utenti";
            // 
            // gestioneGeneriToolStripMenuItem
            // 
            this.gestioneGeneriToolStripMenuItem.Name = "gestioneGeneriToolStripMenuItem";
            this.gestioneGeneriToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.gestioneGeneriToolStripMenuItem.Text = "Gestione generi";
            // 
            // grpElencoPrestiti
            // 
            this.grpElencoPrestiti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpElencoPrestiti.Controls.Add(this.label1);
            this.grpElencoPrestiti.Controls.Add(this.label2);
            this.grpElencoPrestiti.Controls.Add(this.label3);
            this.grpElencoPrestiti.Controls.Add(this.label4);
            this.grpElencoPrestiti.Controls.Add(this.cmbPrestatiNONVISIBILE);
            this.grpElencoPrestiti.Controls.Add(this.lblAutore);
            this.grpElencoPrestiti.Controls.Add(this.lblGenere);
            this.grpElencoPrestiti.Controls.Add(this.lblDataPrestito);
            this.grpElencoPrestiti.Controls.Add(this.lblTitolo);
            this.grpElencoPrestiti.Controls.Add(this.ptbCopertina);
            this.grpElencoPrestiti.Controls.Add(this.dgvPrestati);
            this.grpElencoPrestiti.Location = new System.Drawing.Point(12, 40);
            this.grpElencoPrestiti.Name = "grpElencoPrestiti";
            this.grpElencoPrestiti.Size = new System.Drawing.Size(1253, 556);
            this.grpElencoPrestiti.TabIndex = 1;
            this.grpElencoPrestiti.TabStop = false;
            this.grpElencoPrestiti.Text = "Ultimi prestiti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(885, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Autore:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(885, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Genere:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(885, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Prestato il:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(885, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Titolo: ";
            // 
            // cmbPrestatiNONVISIBILE
            // 
            this.cmbPrestatiNONVISIBILE.FormattingEnabled = true;
            this.cmbPrestatiNONVISIBILE.Location = new System.Drawing.Point(354, 0);
            this.cmbPrestatiNONVISIBILE.Name = "cmbPrestatiNONVISIBILE";
            this.cmbPrestatiNONVISIBILE.Size = new System.Drawing.Size(121, 24);
            this.cmbPrestatiNONVISIBILE.TabIndex = 10;
            this.cmbPrestatiNONVISIBILE.Visible = false;
            this.cmbPrestatiNONVISIBILE.SelectedIndexChanged += new System.EventHandler(this.cmbPrestatiNONVISIBILE_SelectedIndexChanged);
            // 
            // lblAutore
            // 
            this.lblAutore.AutoSize = true;
            this.lblAutore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutore.Location = new System.Drawing.Point(966, 449);
            this.lblAutore.Name = "lblAutore";
            this.lblAutore.Size = new System.Drawing.Size(0, 17);
            this.lblAutore.TabIndex = 9;
            // 
            // lblGenere
            // 
            this.lblGenere.AutoSize = true;
            this.lblGenere.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenere.Location = new System.Drawing.Point(966, 483);
            this.lblGenere.Name = "lblGenere";
            this.lblGenere.Size = new System.Drawing.Size(0, 17);
            this.lblGenere.TabIndex = 8;
            // 
            // lblDataPrestito
            // 
            this.lblDataPrestito.AutoSize = true;
            this.lblDataPrestito.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPrestito.Location = new System.Drawing.Point(966, 521);
            this.lblDataPrestito.Name = "lblDataPrestito";
            this.lblDataPrestito.Size = new System.Drawing.Size(52, 17);
            this.lblDataPrestito.TabIndex = 7;
            this.lblDataPrestito.Text = "label2";
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.Location = new System.Drawing.Point(966, 418);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(0, 17);
            this.lblTitolo.TabIndex = 6;
            // 
            // ptbCopertina
            // 
            this.ptbCopertina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptbCopertina.ImageLocation = "";
            this.ptbCopertina.Location = new System.Drawing.Point(946, 21);
            this.ptbCopertina.Name = "ptbCopertina";
            this.ptbCopertina.Size = new System.Drawing.Size(124, 181);
            this.ptbCopertina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCopertina.TabIndex = 5;
            this.ptbCopertina.TabStop = false;
            this.ptbCopertina.MouseEnter += new System.EventHandler(this.ingrandisci);
            this.ptbCopertina.MouseLeave += new System.EventHandler(this.rimpicciolisci);
            // 
            // dgvPrestati
            // 
            this.dgvPrestati.AllowUserToOrderColumns = true;
            this.dgvPrestati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestati.Location = new System.Drawing.Point(6, 21);
            this.dgvPrestati.Name = "dgvPrestati";
            this.dgvPrestati.RowHeadersWidth = 51;
            this.dgvPrestati.RowTemplate.Height = 24;
            this.dgvPrestati.Size = new System.Drawing.Size(866, 529);
            this.dgvPrestati.TabIndex = 2;
            this.dgvPrestati.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestati_CellContentClick);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1277, 608);
            this.Controls.Add(this.grpElencoPrestiti);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpElencoPrestiti.ResumeLayout(false);
            this.grpElencoPrestiti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCopertina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovoLettoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedaLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaRiservataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioneLibriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioneUtentiToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpElencoPrestiti;
        private System.Windows.Forms.DataGridView dgvPrestati;
        private System.Windows.Forms.Label lblAutore;
        private System.Windows.Forms.Label lblGenere;
        private System.Windows.Forms.Label lblDataPrestito;
        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.PictureBox ptbCopertina;
        private System.Windows.Forms.ComboBox cmbPrestatiNONVISIBILE;
        private System.Windows.Forms.ToolStripMenuItem gestioneGeneriToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem prestitiToolStripMenuItem;
    }
}