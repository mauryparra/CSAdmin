﻿using System;
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
        }

        #region GUI

        // Elimina las pantallas que se agregan al Panel2 del SplitContainer
        private void limpiarPanel()
        {
            foreach (Control ctrl in splitContainer.Panel2.Controls)
            {
                splitContainer.Panel2.Controls.Remove(ctrl);
            }
        }

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
            if (radioButtonPersonal.Checked)
            {
                // Barra de estado
                toolStripProgressBar.Style = ProgressBarStyle.Marquee;
                toolStripProgressBar.MarqueeAnimationSpeed = 30;
                toolStripProgressBar.Visible = true;

                this.limpiarPanel();

                // codigo pantalla
                Pantallas.pPersonal pantallaPersonal = new Pantallas.pPersonal();
                pantallaPersonal.Dock = DockStyle.Fill;
                splitContainer.Panel2.Controls.Add(pantallaPersonal);

                toolStripProgressBar.Visible = false;
            }
        }

        private void radioButtonContratos_CheckedChanged(object sender, EventArgs e)
        {
            // Barra de estado
            toolStripProgressBar.Style = ProgressBarStyle.Marquee;
            toolStripProgressBar.MarqueeAnimationSpeed = 30;
            toolStripProgressBar.Visible = true;

            this.limpiarPanel();

            // codigo pantalla


            toolStripProgressBar.Visible = false;
        }

        private void radioButtonAsistencia_CheckedChanged(object sender, EventArgs e)
        {
            // Barra de estado
            toolStripProgressBar.Style = ProgressBarStyle.Marquee;
            toolStripProgressBar.MarqueeAnimationSpeed = 30;
            toolStripProgressBar.Visible = true;

            this.limpiarPanel();

            // codigo pantalla


            toolStripProgressBar.Visible = false;
        }

        private void radioButtonEquipos_CheckedChanged(object sender, EventArgs e)
        {
            // Barra de estado
            toolStripProgressBar.Style = ProgressBarStyle.Marquee;
            toolStripProgressBar.MarqueeAnimationSpeed = 30;
            toolStripProgressBar.Visible = true;

            this.limpiarPanel();

            // codigo pantalla


            toolStripProgressBar.Visible = false;
        }

        private void radioButtonConsultas_CheckedChanged(object sender, EventArgs e)
        {
            // Barra de estado
            toolStripProgressBar.Style = ProgressBarStyle.Marquee;
            toolStripProgressBar.MarqueeAnimationSpeed = 30;
            toolStripProgressBar.Visible = true;

            this.limpiarPanel();

            // codigo pantalla


            toolStripProgressBar.Visible = false;
        }

        private void radioButtonCertificados_CheckedChanged(object sender, EventArgs e)
        {
            // Barra de estado
            toolStripProgressBar.Style = ProgressBarStyle.Marquee;
            toolStripProgressBar.MarqueeAnimationSpeed = 30;
            toolStripProgressBar.Visible = true;

            this.limpiarPanel();

            // codigo pantalla


            toolStripProgressBar.Visible = false;
        }

        private void radioButtonAdmin_CheckedChanged(object sender, EventArgs e)
        {
            // Barra de estado
            toolStripProgressBar.Style = ProgressBarStyle.Marquee;
            toolStripProgressBar.MarqueeAnimationSpeed = 30;
            toolStripProgressBar.Visible = true;

            this.limpiarPanel();

            // codigo pantalla


            toolStripProgressBar.Visible = false;
        }

        #endregion

        #endregion
    }
}