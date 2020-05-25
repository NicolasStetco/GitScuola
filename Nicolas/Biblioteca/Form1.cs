using System;
using System.Windows.Forms;

namespace Biblioteca
{


    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtLoginUser.Focus();
        }

        private void btnAccedi_Click(object sender, EventArgs e)
        {
            if (txtLoginUser.Text == string.Empty)
                MessageBox.Show("Inserisci il nome utente");
            else if (txtLoginPwd.Text == string.Empty)
                MessageBox.Show("Inserisci la password");
            else if (controllo())
            {
                //globals.tipoUtente = "gino";

                frmHome f = new frmHome();
                f.Show();
                this.Hide();
            }
            else
                txtLoginUser.Focus();


        }



        private bool controllo()
        {

            clsUtente utente = new clsUtente("Biblioteca.mdf");

            utente.userID = txtLoginUser.Text;
            utente.pwd = txtLoginPwd.Text;

            utente.getDatiFromUserAndPWD();

            globals.tipoUtente = utente.tipo;
            globals.nomeUtente = utente.nominativo;

            return utente.controlloLogin();


        }

    }
}
