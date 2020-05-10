﻿using System;
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

        }

        private void btnAccedi_Click(object sender, EventArgs e)
        {
            if (txtLoginUser.Text == string.Empty)
                MessageBox.Show("Inserisci il nome utente");
            else if (txtLoginPwd.Text == string.Empty)
                MessageBox.Show("Inserisci la password");
            else if (controllo())
            {
                frmHome f = new frmHome();
                f.Show();
                frmLogin fL = new frmLogin();
                fL.Close();
            }
            else
                MessageBox.Show("Nome utente o password errati");
        }


        private bool controllo()
        {
         
            clsUtente utente = new clsUtente("Biblioteca.mdf");

            utente.userID = txtLoginUser.Text;
            utente.pwd = txtLoginPwd.Text; 

            return utente.controlloLogin();

        }
    }
}
