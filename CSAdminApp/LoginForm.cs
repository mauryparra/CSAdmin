using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CSAdminApp.Clases;

namespace CSAdminApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            progressBar.Visible = false;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            try
            {
                SampleIPrincipal samplePrincipal = new SampleIPrincipal(this.UsernameTextBox.Text, this.PasswordTextBox.Text);
                this.PasswordTextBox.Clear();
                if (!samplePrincipal.Identity.IsAuthenticated)
                {
                    // Usuario No Validado
                    MessageBox.Show("Usuario o contraseña incorrecta, intente nuevamente.",
                            "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    this.PasswordTextBox.Focus();
                }
                else
                {
                    // Usuario Validado, se actualiza CurrentPrincipal
                    System.Threading.Thread.CurrentPrincipal = samplePrincipal;
                    this.Close();
                }
                progressBar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.InnerException.Message);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
