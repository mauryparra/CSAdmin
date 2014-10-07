using CSAdminApp.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSAdminApp.Pantallas
{
    public partial class telPopUp : Form
    {
        private string[] tel;
        

        public telPopUp(string[] telefonos)
        {
            InitializeComponent();
            tel = telefonos;
        }

        private void telPopUp_Load(object sender, EventArgs e)
        {
            try
            {
                maskedTextBoxTel.Text = tel[0];
                maskedTextBoxCel.Text = tel[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void buttonAgregar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // TODO Revisar restricciones telefonos
        //        PersonasTel nuevoTel = new PersonasTel();
        //        nuevoTel.Numero = Decimal.Parse(maskedTextBoxTel.Text);
        //        nuevoTel.Tipo = comboBoxTipo.SelectedItem.ToString();

        //        persona.PersonasTel.Add(nuevoTel);
        //        MessageBox.Show("Se agregó el numero de Tel: " + nuevoTel.Numero.ToString());
        //        FunmPC.limpiarForm(splitContainer.Panel1);
        //        maskedTextBoxTel.Focus();

        //        // TODO Refresco dinamico de datagrid
        //        bs.ResetBindings(false);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void telPopUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Close();
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                tel[0] = maskedTextBoxTel.Text;
                tel[1] = maskedTextBoxCel.Text;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
