﻿using CSAdminApp.Clases;
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
        internal Int32 aux = 0;
        internal BindingSource bs = new BindingSource();
        internal Clases.Personas persona;
        private bool soloLectura;
        

        public telPopUp(Personas per, bool modo)
        {
            InitializeComponent();

            persona = per;
            soloLectura = modo;
        }

        private void telPopUp_Load(object sender, EventArgs e)
        {
            try
            {
                if (soloLectura)
                {
                    maskedTextBoxTel.Enabled = false;
                    comboBoxTipo.Enabled = false;
                    buttonAgregar.Enabled = false;
                }
                else
                {
                    maskedTextBoxTel.Enabled = true;
                    comboBoxTipo.Enabled = true;
                    buttonAgregar.Enabled = true;
                    comboBoxTipo.SelectedIndex = 0;
                }

                ObjectQuery<PersonasTel> personasTelQ =
                    Main.BDContext.PersonasTel.Where("it.IdPersona = @Id");
                personasTelQ.Parameters.Add(new ObjectParameter("Id", aux));
                bs.DataSource = personasTelQ.Select("it.Tipo, it.Numero");
                dataGridViewTel.DataSource = bs;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO Revisar restricciones telefonos
                PersonasTel nuevoTel = new PersonasTel();
                nuevoTel.Numero = Decimal.Parse(maskedTextBoxTel.Text);
                nuevoTel.Tipo = comboBoxTipo.SelectedItem.ToString();

                persona.PersonasTel.Add(nuevoTel);
                MessageBox.Show("Se agregó el numero de Tel: " + nuevoTel.Numero.ToString());
                FunmPC.limpiarForm(splitContainer.Panel1);
                maskedTextBoxTel.Focus();

                // TODO Refresco dinamico de datagrid
                bs.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void telPopUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Close();
            }
        }
    }
}