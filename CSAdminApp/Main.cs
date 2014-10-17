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
        public static Clases.CSAdminBDEntities BDContext = new Clases.CSAdminBDEntities();
        
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
            toolStripStatusLabel.Text = "Listo";

            // Carga pantalla por defecto
            if (radioButtonPersonal.Checked)
            {
                // Barra de estado
                toolStripProgressBar.Style = ProgressBarStyle.Marquee;
                toolStripProgressBar.MarqueeAnimationSpeed = 30;
                toolStripProgressBar.Visible = true;

                this.adminPantalla("pPersonal");

                toolStripProgressBar.Visible = false;
            }
        }

        #region GUI

        // Si la pantalla solicitada existe la muestra,
        // oculta el resto de ventanas y si no existe la crea.
        private void adminPantalla(String ctrlName)
        {
            bool flag = false;
            foreach (Control ctrl in splitContainer.Panel2.Controls)
            {
                if (ctrlName == ctrl.Name)
                {
                    ctrl.Show();
                    flag = true;
                }
                else
                {
                    ctrl.Hide();
                }
            }

            if (flag == false)
            {
                switch (ctrlName)
                {
                    case "pPersonal":
                        Pantallas.pPersonal pantallaPersonal = new Pantallas.pPersonal();
                        pantallaPersonal.Dock = DockStyle.Fill;
                        splitContainer.Panel2.Controls.Add(pantallaPersonal);
                        break;

                    case "pContratos":
                        Pantallas.pContratos pantallaContratos = new Pantallas.pContratos();
                        pantallaContratos.Dock = DockStyle.Fill;
                        splitContainer.Panel2.Controls.Add(pantallaContratos);
                        break;

                    case "pAsistencia":
                        Pantallas.pAsistencia pantallaAsistencia = new Pantallas.pAsistencia();
                        pantallaAsistencia.Dock = DockStyle.Fill;
                        splitContainer.Panel2.Controls.Add(pantallaAsistencia);
                        break;

                    case "pEquipos":
                        Pantallas.pEquipos pantallaEquipos = new Pantallas.pEquipos();
                        pantallaEquipos.Dock = DockStyle.Fill;
                        splitContainer.Panel2.Controls.Add(pantallaEquipos);
                        break;

                    case "pConsultas":
                        Pantallas.pConsultas pantallaConsultas = new Pantallas.pConsultas();
                        pantallaConsultas.Dock = DockStyle.Fill;
                        splitContainer.Panel2.Controls.Add(pantallaConsultas);
                        break;

                    case "pCertificados":

                        break;

                    case "pAdmin":
                        Pantallas.pAdmin pantallaAdmin = new Pantallas.pAdmin();
                        pantallaAdmin.Dock = DockStyle.Fill;
                        splitContainer.Panel2.Controls.Add(pantallaAdmin);
                        break;

                    default:
                        MessageBox.Show("Error al administrar pantalla");
                        break;
                }
            }
        }

        #region Menu Principal

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeCSAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe acerca = new AcercaDe();
            acerca.ShowDialog();
        }

        #endregion

        

        #region Menu Lateral

        private void radioButtonPersonal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPersonal.Checked)
            {
                // Barra de estado
                toolStripProgressBar.Style = ProgressBarStyle.Marquee;
                toolStripProgressBar.MarqueeAnimationSpeed = 30;
                toolStripProgressBar.Visible = true;

                this.adminPantalla("pPersonal");

                toolStripProgressBar.Visible = false;
            }
        }

        private void radioButtonContratos_CheckedChanged(object sender, EventArgs e)
        {
            // Barra de estado
            toolStripProgressBar.Style = ProgressBarStyle.Marquee;
            toolStripProgressBar.MarqueeAnimationSpeed = 30;
            toolStripProgressBar.Visible = true;

            this.adminPantalla("pContratos");

            toolStripProgressBar.Visible = false;
        }

        private void radioButtonAsistencia_CheckedChanged(object sender, EventArgs e)
        {
            // Barra de estado
            toolStripProgressBar.Style = ProgressBarStyle.Marquee;
            toolStripProgressBar.MarqueeAnimationSpeed = 30;
            toolStripProgressBar.Visible = true;

            this.adminPantalla("pAsistencia");

            toolStripProgressBar.Visible = false;
        }

        private void radioButtonEquipos_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEquipos.Checked)
            {
                // Barra de estado
                toolStripProgressBar.Style = ProgressBarStyle.Marquee;
                toolStripProgressBar.MarqueeAnimationSpeed = 30;
                toolStripProgressBar.Visible = true;

                this.adminPantalla("pEquipos");

                toolStripProgressBar.Visible = false;
            }
        }

        private void radioButtonConsultas_CheckedChanged(object sender, EventArgs e)
        {
            // Barra de estado
            toolStripProgressBar.Style = ProgressBarStyle.Marquee;
            toolStripProgressBar.MarqueeAnimationSpeed = 30;
            toolStripProgressBar.Visible = true;

            this.adminPantalla("pConsultas");

            toolStripProgressBar.Visible = false;
        }

        private void radioButtonCertificados_CheckedChanged(object sender, EventArgs e)
        {
            // Barra de estado
            toolStripProgressBar.Style = ProgressBarStyle.Marquee;
            toolStripProgressBar.MarqueeAnimationSpeed = 30;
            toolStripProgressBar.Visible = true;

            this.adminPantalla("");

            toolStripProgressBar.Visible = false;
        }

        private void radioButtonAdmin_CheckedChanged(object sender, EventArgs e)
        {
            // Barra de estado
            toolStripProgressBar.Style = ProgressBarStyle.Marquee;
            toolStripProgressBar.MarqueeAnimationSpeed = 30;
            toolStripProgressBar.Visible = true;

            this.adminPantalla("pAdmin");

            toolStripProgressBar.Visible = false;
        }

        #endregion

        #endregion
    }
}
