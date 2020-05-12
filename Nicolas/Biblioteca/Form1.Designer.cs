namespace Biblioteca
{
    partial class frmLogin
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAccedi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoginPwd = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtLoginUser = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnAccedi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLoginPwd);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.txtLoginUser);
            this.groupBox1.Location = new System.Drawing.Point(35, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accedi";
            // 
            // btnAccedi
            // 
            this.btnAccedi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAccedi.Location = new System.Drawing.Point(62, 154);
            this.btnAccedi.Name = "btnAccedi";
            this.btnAccedi.Size = new System.Drawing.Size(202, 52);
            this.btnAccedi.TabIndex = 1;
            this.btnAccedi.Text = "Accedi";
            this.btnAccedi.UseVisualStyleBackColor = true;
            this.btnAccedi.Click += new System.EventHandler(this.btnAccedi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Utente:";
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.Location = new System.Drawing.Point(119, 103);
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.Size = new System.Drawing.Size(145, 22);
            this.txtLoginPwd.TabIndex = 2;
            this.txtLoginPwd.UseSystemPasswordChar = true;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(59, 45);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(54, 17);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Utente:";
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.Location = new System.Drawing.Point(119, 42);
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.Size = new System.Drawing.Size(145, 22);
            this.txtLoginUser.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(419, 304);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtLoginUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoginPwd;
        private System.Windows.Forms.Button btnAccedi;
    }
}

