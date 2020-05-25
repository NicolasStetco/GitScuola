using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;

namespace Biblioteca
{
    public partial class frmSchedaLibro : Form
    {
        public frmSchedaLibro()
        {
            InitializeComponent();
        }

        bool selezionaLibro = true;
        System.Data.DataTable tabellaLibri = new System.Data.DataTable();
        System.Data.DataTable tabellaLettori = new System.Data.DataTable();

        // Oggetto che contiene i Riferimenti all'Application WORD
        _Application myWord;

        // Oggetto che contiene i Riferimenti al Documento
        _Document myDoc;

        // Oggetto che definisce il range di gestione dei mie Paragrafi
        Range myRange;
        object start;
        object end;

        // Percorsi Generici File
        string Percorso;
        string FileDOC, FilePDF, FileRIS, FileIMG;

        private void dgvPrestati_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmSchedaLibro_Load(object sender, EventArgs e)
        {
            selezionaLibro = false;
            elencoLibri('L');
            selezionaLibro = true;

            clsLettore l = new clsLettore("Biblioteca.mdf");

            tabellaLettori = l.lista(' ');

            l.dispose();

            cmbLettori.DataSource = tabellaLettori;
            cmbLettori.DisplayMember = "CognomeLettore";
            cmbLettori.ValueMember = "CodLettore";
            cmbLettori.SelectedIndex = -1;

        }

        private void chkAggiungiAnnullati_CheckedChanged(object sender, EventArgs e)
        {
            selezionaLibro = false;
            elencoLibri('K');
            selezionaLibro = true;

        }

        private void elencoLibri(char from)
        {
            clsLibro l = new clsLibro("Biblioteca.mdf");
            if (from == 'L')
                tabellaLibri = l.lista(' ');
            else if (chkAggiungiAnnullati.Checked == true)
                tabellaLibri = l.lista('A');
            else
                tabellaLibri = l.lista(' ');


            dgvElenco.DataSource = tabellaLibri;

            cmbLibri.DataSource = tabellaLibri;
            cmbLibri.DisplayMember = "TitoloLibro";
            cmbLibri.ValueMember = "CodLibro";
            cmbLibri.SelectedIndex = -1;

            l.dispose();
            //annulla();
        }

        private void cmbLibri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLibri.SelectedIndex != -1 && selezionaLibro)
            {
                clsLibro libro = new clsLibro("Biblioteca.mdf");

                libro.codice = Convert.ToInt32(cmbLibri.SelectedValue);

                libro.getDati();

                lblAutore.Text = libro.autore;
                lblGenere.Text = libro.codGenere.ToString();
                lblTitolo.Text = libro.titolo;

                clsGenere g = new clsGenere("Biblioteca.mdf");

                g.codice = libro.codGenere;
                g.getDati();
                lblGenere.Text = g.nome;

                g.dispose();

                ptbCopertina.ImageLocation = @"IMG\\" + libro.immagine;

                libro.dispose();

                cmbLettori.SelectedIndex = -1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbLettori.SelectedIndex != -1)
            {
                string dati = creaStringa();

                clsLettore l = new clsLettore("Biblioteca.mdf");

                l.codice = Convert.ToInt32(cmbLettori.SelectedValue);
                l.getDati();

                Percorso = System.Windows.Forms.Application.StartupPath;
                //MessageBox.Show(Percorso);
                FileDOC = Percorso + "/" + "PDF\\" + lblTitolo.Text +"_"+l.cognome + l.nome+ ".docx";
                FilePDF = Percorso + "/" + "PDF\\" + lblTitolo.Text + "_"+l.cognome+l.nome+".pdf";

                l.dispose();
                // Creo una NUOVA istanza di WORD Application
                myWord = new Microsoft.Office.Interop.Word.Application();

                // Rendo visibile la nuova Word Application
                //myWord.Visible = false;
                myWord.Visible = false;

                //Aggiungo un NUOVO Documento
                myDoc = new Document();
                myDoc = myWord.Documents.Add();

                start = myDoc.Sentences[myDoc.Sentences.Count].End - 1;
                end = myDoc.Sentences[myDoc.Sentences.Count].End;
                myRange = myDoc.Range(ref start, ref end);

                // Aggiungo il Testo
                myRange.Text = dati + "\n";

                myDoc.SaveAs2(FileDOC);

                // Chiudo il Documento
                myDoc.Close();

                // Chiudo il Word Application
                myWord.Quit();

                this.Cursor = Cursors.WaitCursor;

                myWord = new Microsoft.Office.Interop.Word.Application();

                myWord.Visible = false;

                myDoc = new Document();

                myDoc = myWord.Documents.Open(@FileDOC);

                myDoc.ExportAsFixedFormat(@FilePDF, WdExportFormat.wdExportFormatPDF);

                myDoc.Close();

                myWord.Quit();

                this.Cursor = Cursors.Default;

                MessageBox.Show("PDF creato con successo");

                File.Delete(@FileDOC);

                cmbLettori.SelectedIndex = -1;
                cmbLettori.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Seleziona il lettore");
            }
        }


        private string creaStringa()
        {
            string s = string.Empty;

            clsLettore lettore = new clsLettore("Biblioteca.mdf");

            lettore.codice = Convert.ToInt32(cmbLettori.SelectedValue);
            lettore.getDati();

            s = "Scheda richiesta da: " + lettore.cognome + " " + lettore.nome + "\n";


            lettore.dispose();

            s += "Titolo: " + lblTitolo.Text +
                "\nAutore: " + lblAutore.Text +
                "\nGenere: " + lblGenere.Text;

            return s;
        }
    }
}
