using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using CSAdminApp.Clases;

namespace CSAdminApp.Pantallas
{
    public partial class passwordPrompt : Form
    {
        public passwordPrompt()
        {
            InitializeComponent();
        }

        private void passwordPrompt_Load(object sender, EventArgs e)
        {
            usernameTextBox.Text = System.Threading.Thread.CurrentPrincipal.Identity.Name;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
            {
                ObjectQuery<Usuarios> userQ =
                    db.Usuarios.Where("it.Usuario = @Usuario");
                userQ.Parameters.Add(new ObjectParameter("Usuario", usernameTextBox.Text));

                if (userQ.Any())
                {
                    if (userQ.First().Contra == passwordTextBox.Text)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta");
                        passwordTextBox.Clear();
                        passwordTextBox.Focus();
                    }
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
