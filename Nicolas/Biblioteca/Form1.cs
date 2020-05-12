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
                //this.Close();
                frmHome f = new frmHome();
                f.Show(); 
            }
            else
            {
                MessageBox.Show("Nome utente o password errati");
                txtLoginUser.Focus();
            }
                
        }


        private bool controllo()
        {
         
            clsUtente utente = new clsUtente("Biblioteca.mdf");

            utente.userID = txtLoginUser.Text;
            utente.pwd = txtLoginPwd.Text; 

            return utente.controlloLogin();

        }

        private void btnRegistrazione_Click(object sender, EventArgs e)
        {
            frmRegistrazione r = new frmRegistrazione();
            r.Show();
        }
    }
}
