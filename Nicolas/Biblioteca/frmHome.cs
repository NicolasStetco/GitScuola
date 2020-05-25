using System;
using System.Data;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        DataTable tabellaPrestati = new DataTable();
        bool firstRun = true;

        private void frmHome_Load(object sender, EventArgs e)
        {
            if (globals.tipoUtente == "OPE")
                areaRiservataToolStripMenuItem.Enabled = false;

            this.Text += globals.nomeUtente;


            prestitiRecenti();
            firstRun = false;

            //MessageBox.Show(globals.tipoUtente);
        }


        private void prestitiRecenti()
        {
            clsLibro l = new clsLibro("Biblioteca.mdf");
            tabellaPrestati = l.prestati();

            dgvPrestati.DataSource = tabellaPrestati;

            cmbPrestatiNONVISIBILE.DataSource = tabellaPrestati;
            cmbPrestatiNONVISIBILE.ValueMember = "CodLibro";
            cmbPrestatiNONVISIBILE.DisplayMember = "CodLibro";
            cmbPrestatiNONVISIBILE.SelectedIndex = -1;

            l.dispose();
        }

        private void dgvPrestati_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dgvPrestati.SelectedRows.ToString());
        }

        private void cmbPrestatiNONVISIBILE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPrestatiNONVISIBILE.SelectedIndex != -1 && !firstRun)
            {
                clsLibro libro = new clsLibro("Biblioteca.mdf");

                libro.codice = Convert.ToInt32(cmbPrestatiNONVISIBILE.SelectedValue);

                libro.getDati();

                lblAutore.Text = libro.autore;
                lblGenere.Text = libro.codGenere.ToString();
                lblTitolo.Text = libro.titolo;

                clsGenere g = new clsGenere("Biblioteca.mdf");

                g.codice = libro.codGenere;
                g.getDati();
                lblGenere.Text = g.nome;

                g.dispose();

                clsPrestito p = new clsPrestito("Biblioteca.mdf");

                p.codLibro = libro.codice;
                p.getPrestitoFromLibro();
                lblDataPrestito.Text = p.dataPrestito.ToShortDateString();

                p.dispose();


                ptbCopertina.ImageLocation = @"IMG\\" + libro.immagine;

                libro.dispose();
            }
        }

        private void ingrandisci(object sender, EventArgs e)
        {
            ptbCopertina.Width = ptbCopertina.Width * 2;
            ptbCopertina.Height = ptbCopertina.Height * 2;
        }

        private void rimpicciolisci(object sender, EventArgs e)
        {
            ptbCopertina.Width = ptbCopertina.Width / 2;
            ptbCopertina.Height = ptbCopertina.Height / 2;
        }

        private void nuovoLettoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLettori f = new frmLettori();
            f.Show();
        }

        private void chiudiTutto(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void gestioneLibriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLibri f = new frmLibri();
            f.Show();
        }

        private void prestitiToolStripMenuItem_Click(object sender, EventArgs e)
        {


            globals.DATAGRID = dgvPrestati;
            globals.COMBO = cmbPrestatiNONVISIBILE;
            frmPrestiti f = new frmPrestiti();
            f.Show();

            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void schedaLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSchedaLibro f = new frmSchedaLibro();
            f.Show();
        }
    }
}
