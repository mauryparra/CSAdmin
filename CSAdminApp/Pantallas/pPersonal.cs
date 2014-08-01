﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CSAdminApp.Clases;

namespace CSAdminApp.Pantallas
{
    public partial class pPersonal : UserControl
    {
        // aux[] es utilizado para guardar temporalmente el Id de la persona en c/ pestaña
        private int[] aux = {0, 0, 0};
        protected Personas nuevaPersona;
        bool soloLectura = false;

        public pPersonal()
        {
            InitializeComponent();
        }

        private void pPersonal_Load(object sender, EventArgs e)
        {
            try
            {
                nuevaPersona = new Personas();
                ObjectQuery<Personas> personaQuery =
                        Main.BDContext.Personas.Where("it.Baja = True");
                aDataGridViewPer.DataSource = personaQuery.Select("it.Id, it.Dni, it.Nombre, it.Apellido");
                aButtonReactivar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabControlPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ObjectQuery<Personas> personaQ;
                switch (tabControlPersonal.SelectedIndex)
                {
                    case 0:
                        nuevaPersona = new Personas();
                        personaQ =
                            Main.BDContext.Personas.Where("it.Baja = True");
                        aDataGridViewPer.DataSource = personaQ.Select("it.Id, it.Dni, it.Nombre, it.Apellido");
                        break;

                    case 1:
                        personaQ =
                            Main.BDContext.Personas;
                        mDataGridViewPer.DataSource = personaQ.Select(
                            "it.Id, it.Dni, it.Cuit, it.Nombre, it.Apellido, it.Direccion, it.Correo, it.Baja");
                        break;

                    case 2:
                        personaQ =
                            Main.BDContext.Personas.Where("it.Baja = False");
                        bDataGridViewPer.DataSource = personaQ.Select("it.Id, it.Dni, it.Nombre, it.Apellido");
                        break;

                    default:
                        MessageBox.Show("No se puede determinar el indice de la Pestaña," +
                                    " por favor contacte al administrador", "Error", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Error);
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

#region ALTA
        // Se utiliza aux[0]

        // En caso de que se este reactivando
        // un usuario no se puede añadir informacion
        

        private void aButtonTelefonos_Click(object sender, EventArgs e)
        {
            telPopUp tel = new telPopUp(nuevaPersona, soloLectura);
            tel.StartPosition = FormStartPosition.CenterParent;
            tel.aux = aux[0];
            tel.ShowDialog();
        }

        private void aButtonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                nuevaPersona.Dni = Decimal.Parse(aMaskedTextBoxDni.Text);
                if (aMaskedTextBoxCuit.Text.Length > 0)
                {
                    nuevaPersona.Cuit = Decimal.Parse(aMaskedTextBoxCuit.Text);
                }
                else
                {
                    nuevaPersona.Cuit = null;
                }
                nuevaPersona.Nombre = aTextBoxNombre.Text;
                nuevaPersona.Apellido = aTextBoxApellido.Text;
                nuevaPersona.Direccion = aTextBoxDireccion.Text;
                nuevaPersona.Correo = aTextBoxCorreo.Text;
                nuevaPersona.Baja = false;

                Main.BDContext.AddToPersonas(nuevaPersona);
                Main.BDContext.SaveChanges();
                MessageBox.Show("Se agrego: " + nuevaPersona.Nombre + " " + nuevaPersona.Apellido,
                            "Alta Personas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FunmPC.limpiarForm(aSplitContainer.Panel1);
                aButtonReactivar.Visible = false;
                aMaskedTextBoxDni.Focus();
                aux[0] = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void aButtonCancelar_Click(object sender, EventArgs e)
        {
            // Limpia el formulario

            FunmPC.limpiarForm(aSplitContainer.Panel1);
            FunmPC.readOnlyForm(aSplitContainer.Panel1, false);
            aButtonAceptar.Enabled = true;
            aButtonReactivar.Visible = false;
            aMaskedTextBoxDni.Focus();
            soloLectura = false;
            aux[0] = 0;
        }


        private void aButtonReactivar_Click(object sender, EventArgs e)
        {
            try
            {
                ObjectQuery<Personas> personaQ =
                    Main.BDContext.Personas.Where("it.Id = @Id");
                personaQ.Parameters.Add(new ObjectParameter("Id", aux[0]));

                personaQ.First().Baja = false;
                Main.BDContext.SaveChanges();
                MessageBox.Show("Se activo nuevamente a: " + personaQ.First().Nombre + " " +
                                personaQ.First().Apellido, "Alta Personas",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                FunmPC.limpiarForm(aSplitContainer.Panel1);
                FunmPC.readOnlyForm(aSplitContainer.Panel1, false);
                aButtonAceptar.Enabled = true;
                aButtonReactivar.Visible = false;
                aMaskedTextBoxDni.Focus();
                aux[0] = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void aDataGridViewPer_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                aux[0] = Convert.ToInt32(aDataGridViewPer.SelectedRows[0].Cells[0].Value);
                ObjectQuery<Personas> personaQ =
                    Main.BDContext.Personas.Where("it.Id = @Id");
                personaQ.Parameters.Add(new ObjectParameter("Id", aux[0]));

                aMaskedTextBoxDni.Text = personaQ.First().Dni.ToString();
                aMaskedTextBoxCuit.Text = personaQ.First().Cuit.ToString();
                aTextBoxNombre.Text = personaQ.First().Nombre;
                aTextBoxApellido.Text = personaQ.First().Apellido;
                aTextBoxDireccion.Text = personaQ.First().Direccion;
                aTextBoxCorreo.Text = personaQ.First().Correo;
                FunmPC.readOnlyForm(aSplitContainer.Panel1, true);
                aButtonAceptar.Enabled = false;
                aButtonReactivar.Visible = true;
                soloLectura = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void aMaskedTextBoxDni_Leave(object sender, EventArgs e)
        {
            if (aMaskedTextBoxDni.Text.Length > 0)
            {

                try
                {
                    ObjectQuery<Personas> personaQ =
                        Main.BDContext.Personas.Where("it.Dni = @Dni");
                    personaQ.Parameters.Add(new ObjectParameter("Dni", Convert.ToInt32(aMaskedTextBoxDni.Text)));

                    if (personaQ.Any())
                    {
                        if (personaQ.First().Baja)
                        {
                            aMaskedTextBoxCuit.Text = personaQ.First().Cuit.ToString();
                            aTextBoxNombre.Text = personaQ.First().Nombre;
                            aTextBoxApellido.Text = personaQ.First().Apellido;
                            aTextBoxDireccion.Text = personaQ.First().Direccion;
                            aTextBoxCorreo.Text = personaQ.First().Correo;
                            aux[0] = personaQ.First().Id;
                            FunmPC.readOnlyForm(aSplitContainer.Panel1, true);
                            aButtonAceptar.Enabled = false;
                            aButtonReactivar.Visible = true;
                            soloLectura = true;
                        }
                        else
                        {
                            MessageBox.Show(personaQ.First().Nombre + " " + personaQ.First().Apellido + " ya se encuentra dado de alta.",
                                "Agregar Personas",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            aMaskedTextBoxDni.Clear();
                            aMaskedTextBoxDni.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

#endregion    

#region MODIFICAR
        // Se utiliza aux[1]
        private void mMaskedTextBoxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    ObjectQuery<Personas> personaQ =
                        Main.BDContext.Personas.Where("it.Dni = @Dni");
                    personaQ.Parameters.Add(new ObjectParameter("Dni", Convert.ToInt32(mMaskedTextBoxDni.Text)));

                    if (personaQ.Any())
                    {
                        mMaskedTextBoxCuit.Text = Convert.ToString(personaQ.First().Cuit);
                        mTextBoxNombre.Text = personaQ.First().Nombre;
                        mTextBoxApellido.Text = personaQ.First().Apellido;
                        mTextBoxDireccion.Text = personaQ.First().Direccion;
                        mTextBoxCorreo.Text = personaQ.First().Correo;
                        aux[1] = personaQ.First().Id;
                    }
                    else
                    {
                        MessageBox.Show("No se encontro ninguna persona con DNI: " + mMaskedTextBoxDni.Text,
                                "Modificar Personas",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FunmPC.limpiarForm(mSplitContainer.Panel1);
                        mMaskedTextBoxDni.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void mButtonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (aux[1] != 0)
                {
                   ObjectQuery<Personas> personaQ =
                        Main.BDContext.Personas.Where("it.Id = @Id");
                    personaQ.Parameters.Add(new ObjectParameter("Id", aux[1]));
                    personaQ.First().Dni = Convert.ToInt32(mMaskedTextBoxDni.Text);
                    if (mMaskedTextBoxCuit.Text.Length > 0)
                    {
                        personaQ.First().Cuit = Convert.ToInt64(mMaskedTextBoxCuit.Text);
                    }
                    else
                    {
                        personaQ.First().Cuit = null;
                    }
                    personaQ.First().Nombre = mTextBoxNombre.Text;
                    personaQ.First().Apellido = mTextBoxApellido.Text;
                    personaQ.First().Direccion = mTextBoxDireccion.Text;
                    personaQ.First().Correo = mTextBoxCorreo.Text;
                    Main.BDContext.SaveChanges();
                    MessageBox.Show("Se modifico: " + personaQ.First().Nombre + " " + personaQ.First().Apellido,
                                "Modificación de Personas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FunmPC.limpiarForm(mSplitContainer.Panel1);
                    mMaskedTextBoxDni.Focus();
                    aux[1] = 0;
                }
                else
                {
                    MessageBox.Show("Actualmente no se esta editando ninguna Persona", "Modificación de Personas", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mMaskedTextBoxDni.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mButtonCancelar_Click(object sender, EventArgs e)
        {
            // Limpia el formulario.
            FunmPC.limpiarForm(mSplitContainer.Panel1);
            FunmPC.readOnlyForm(mSplitContainer.Panel1, false);
            mMaskedTextBoxDni.Focus();
            aux[1] = 0;
        }

        private void mButtonTelefonos_Click(object sender, EventArgs e)
        {
            telPopUp tel = new telPopUp(nuevaPersona, soloLectura);
            tel.StartPosition = FormStartPosition.CenterParent;
            tel.aux = aux[1];
            tel.ShowDialog();
        }

        private void mDataGridViewPer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                aux[1] =Convert.ToInt32(mDataGridViewPer.SelectedRows[0].Cells[0].Value);
                ObjectQuery<Personas> personasQ =
                    Main.BDContext.Personas.Where("it.Id = @Id");
                personasQ.Parameters.Add(new ObjectParameter("Id", aux[1]));

                mMaskedTextBoxDni.Text = Convert.ToString(personasQ.First().Dni);
                mMaskedTextBoxCuit.Text = Convert.ToString(personasQ.First().Cuit);
                mTextBoxNombre.Text = personasQ.First().Nombre;
                mTextBoxApellido.Text = personasQ.First().Apellido;
                mTextBoxDireccion.Text = personasQ.First().Direccion;
                mTextBoxCorreo.Text = personasQ.First().Correo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
#endregion 

#region BAJA
        // Se utiliza aux[2]
        private void bButtonBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (aux[2] != 0)
                {
                    ObjectQuery<Personas> personaQ =
                        Main.BDContext.Personas.Where("it.Id = @Id");
                    personaQ.Parameters.Add(new ObjectParameter("Id", aux[2]));

                    personaQ.First().Baja = true;
                    Main.BDContext.SaveChanges();
                    MessageBox.Show("Se dio de baja a: " + personaQ.First().Nombre,
                                "Baja Personas",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FunmPC.limpiarForm(bSplitContainer.Panel1);
                    FunmPC.readOnlyForm(bSplitContainer.Panel1, false);
                    bMaskedTextBoxDni.Focus();
                    aux[2] = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bButtonCancelar_Click(object sender, EventArgs e)
        {
            // Limpia el formulario
            FunmPC.limpiarForm(bSplitContainer.Panel1);
            FunmPC.readOnlyForm(bSplitContainer.Panel1, false);
            bMaskedTextBoxDni.Focus();
            aux[2] = 0;
        }

        private void bButtonContratos_Click(object sender, EventArgs e)
        {
            // TODO Contratos Personal
        }

        private void bMaskedTextBoxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    ObjectQuery<Personas> personaQ =
                    Main.BDContext.Personas.Where("it.Dni = @Dni");
                    personaQ.Parameters.Add(new ObjectParameter("Dni", Convert.ToInt32(bMaskedTextBoxDni.Text)));

                    if (personaQ.Any())
                    {
                        bTextBoxNombre.Text = personaQ.First().Nombre;
                        bTextBoxApellido.Text = personaQ.First().Apellido;
                        bTextBoxDireccion.Text = personaQ.First().Direccion;
                        aux[2] = personaQ.First().Id;
                    }
                    else
                    {
                        MessageBox.Show("No se encontro ninguna persona con DNI: " + bMaskedTextBoxDni.Text,
                                    "Baja Personas",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FunmPC.limpiarForm(bSplitContainer.Panel1);
                        bMaskedTextBoxDni.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bDataGridViewPer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                aux[2] = Convert.ToInt32(bDataGridViewPer.SelectedRows[0].Cells[0].Value);
                ObjectQuery<Personas> personaQ =
                    Main.BDContext.Personas.Where("it.Id = @Id");
                personaQ.Parameters.Add(new ObjectParameter("Id", aux[2]));

                bMaskedTextBoxDni.Text = Convert.ToString(personaQ.First().Dni);
                bTextBoxNombre.Text = personaQ.First().Nombre;
                bTextBoxApellido.Text = personaQ.First().Apellido;
                bTextBoxDireccion.Text = personaQ.First().Direccion;
                FunmPC.readOnlyForm(bSplitContainer.Panel1, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
#endregion  
    }
}
