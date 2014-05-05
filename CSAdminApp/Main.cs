using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CSAdminApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (Thread.CurrentPrincipal.Identity.IsAuthenticated)
            {
                if (Thread.CurrentPrincipal.IsInRole(WindowsBuiltInRole.Administrator.ToString()))
                {
                    this.Text += " [Admin]";
                }
                else
                {
                    this.Text += " [Usuaurio]";
                }
            }
            else
            {
                Application.Exit();
            }
            this.toolStripStatusLabel.Text = "Listo";
        }

        #region GUI

        #region Menu Principal

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeCSAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe acerca = new AcercaDe("Acerca de CSAdmin", "http://mauryparra.com.ar/");
            acerca.ShowDialog();
        }

        #endregion

        

        #region Menu Lateral

        private void radioButtonPersonal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonContratos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonAsistencia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonEquipos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonConsultas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonCertificados_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion
    }
}
