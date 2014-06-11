using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSAdminApp.Pantallas
{
    public partial class pAdmin : UserControl
    {
        public pAdmin()
        {
            InitializeComponent();
        }

        private void entityDataSource_DataError(object sender, EFWinforms.DataErrorEventArgs e)
        {
            MessageBox.Show("Error Detectado:\r\n" + e.Exception.Message);
            entityDataSource.CancelChanges();
            e.Handled = true;
        }

        private void fButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                entityDataSource.SaveChanges();
                MessageBox.Show("Se guardaron los datos", "Admin Funciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }

        private void fButtonRecargar_Click(object sender, EventArgs e)
        {
            try
            {
                entityDataSource.Refresh();
                MessageBox.Show("Se recargaron los datos", "Admin Funciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }

        private void fButtonCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                entityDataSource.CancelChanges();
                MessageBox.Show("Se revirtieron los datos", "Admin Funciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }

        private void sButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                entityDataSource.SaveChanges();
                MessageBox.Show("Se guardaron los datos", "Admin Situaciones Profesionales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }

        private void sButtonRecargar_Click(object sender, EventArgs e)
        {
            try
            {
                entityDataSource.Refresh();
                MessageBox.Show("Se recargaron los datos", "Admin Situaciones Profesionales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }

        private void sButtonCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                entityDataSource.CancelChanges();
                MessageBox.Show("Se revirtieron los datos", "Admin Situaciones Profesionales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }

        // TODO mejorar seleccion de persona para usuario

        private void uButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                entityDataSource.SaveChanges();
                MessageBox.Show("Se guardaron los datos", "Admin Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }

        private void uButtonRecargar_Click(object sender, EventArgs e)
        {
            try
            {
                entityDataSource.Refresh();
                MessageBox.Show("Se recargaron los datos", "Admin Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }

        private void uButtonCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                entityDataSource.CancelChanges();
                MessageBox.Show("Se revirtieron los datos", "Admin Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }

        private void lButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                entityDataSource.SaveChanges();
                MessageBox.Show("Se guardaron los datos", "Admin Localidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }

        private void lButtonRecargar_Click(object sender, EventArgs e)
        {
            try
            {
                entityDataSource.Refresh();
                MessageBox.Show("Se recargaron los datos", "Admin Localidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }

        private void lButtonCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                entityDataSource.CancelChanges();
                MessageBox.Show("Se revirtieron los datos", "Admin Localidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }

        private void dataGridViewUsuarios_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error Detectado:\r\n" + e.Exception.Message);
        }
    }
}
