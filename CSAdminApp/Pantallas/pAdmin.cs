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

        private void aButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                entityDataSource.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }

        private void aButtonActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                entityDataSource.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }

        private void aButtonCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                entityDataSource.CancelChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }
    }
}
