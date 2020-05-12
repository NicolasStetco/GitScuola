using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void frmHome_Load(object sender, EventArgs e)
        {
            //if (utente.tipo=="OPE")
                areaRiservataToolStripMenuItem.Enabled = false;

            prestitiRecenti();
        }


        private void prestitiRecenti()
        {
            clsLibro l = new clsLibro("Biblioteca.mdf");
            tabellaPrestati = l.prestati();
            
            dgvPrestati.DataSource = tabellaPrestati;

            cmbPrestatiNONVISIBILE.DataSource = tabellaPrestati;
            cmbPrestatiNONVISIBILE.ValueMember = "CodLibro";
            cmbPrestatiNONVISIBILE.DisplayMember = "TitoloLibro";
            cmbPrestatiNONVISIBILE.SelectedIndex = 1;
            

            l.dispose();
        }

        private void dgvPrestati_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dgvPrestati.SelectedRows.ToString());
        }

        private void cmbPrestatiNONVISIBILE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPrestatiNONVISIBILE.SelectedIndex != -1)
            {
                clsLibro libro = new clsLibro("Biblioteca.mdf");

                libro.codice = Convert.ToInt32(cmbPrestatiNONVISIBILE.SelectedValue);

                libro.getDati();

                lblAutore.Text = libro.autore;
                lblGenere.Text = libro.codGenere.ToString();
                lblTitolo.Text = libro.titolo;

                clsGenere g= new clsGenere("Biblioteca.mdf");

                g.codice = libro.codGenere;
                g.getDati();
                lblGenere.Text = g.nome;

                g.dispose();


                ptbCopertina.ImageLocation =@"IMG\\"+libro.immagine;

                libro.dispose();
            }
        }

        private void ingrandisci(object sender, EventArgs e)
        {
            ptbCopertina.Width=ptbCopertina.Width*2;
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
    }
}
