﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Core.EntityClient;
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
        protected string[] telefonos = {string.Empty, string.Empty};

        public pPersonal()
        {
            InitializeComponent();
        }

        private void pPersonal_Load(object sender, EventArgs e)
        {
            try
            {
                using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                {
                    var personas = db.Personas
                                     .Where(p => p.Baja == true).ToList();
                    aDataGridViewPer.DataSource = personas;
                    aButtonReactivar.Visible = false;
                    aDataGridViewPer.Columns[0].Visible = false;
                    aDataGridViewPer.Columns[3].Visible = false;
                    aDataGridViewPer.Columns[6].Visible = false;
                    aDataGridViewPer.Columns[7].Visible = false;
                    aDataGridViewPer.Columns[8].Visible = false;
                    aDataGridViewPer.Columns[9].Visible = false;
                    aDataGridViewPer.Columns[10].Visible = false;
                    aDataGridViewPer.Columns[11].Visible = false;
                    aDataGridViewPer.Columns[12].Visible = false;
                    aDataGridViewPer.Columns[13].Visible = false;
                }
                
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
                using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                {
                    switch (tabControlPersonal.SelectedIndex)
                    {
                        case 0:
                            var personasAlta = db.Personas
                                                 .Where(p => p.Baja == true).ToList();
                            aDataGridViewPer.DataSource = personasAlta;
                            
                            aDataGridViewPer.Columns[0].Visible = false;
                            aDataGridViewPer.Columns[3].Visible = false;
                            aDataGridViewPer.Columns[6].Visible = false;
                            aDataGridViewPer.Columns[7].Visible = false;
                            aDataGridViewPer.Columns[8].Visible = false;
                            aDataGridViewPer.Columns[9].Visible = false;
                            aDataGridViewPer.Columns[10].Visible = false;
                            aDataGridViewPer.Columns[11].Visible = false;
                            aDataGridViewPer.Columns[12].Visible = false;
                            aDataGridViewPer.Columns[13].Visible = false;
                            break;

                        case 1:
                            var personasMod = db.Personas.ToList();
                            mDataGridViewPer.DataSource = personasMod;

                            // .Select("it.Id, it.Dni, it.Cuit, it.Nombre, it.Apellido, it.Direccion, it.Correo, it.Baja");

                            mDataGridViewPer.Columns[0].Visible = false;
                            mDataGridViewPer.Columns[9].Visible = false;
                            mDataGridViewPer.Columns[10].Visible = false;
                            mDataGridViewPer.Columns[11].Visible = false;
                            mDataGridViewPer.Columns[12].Visible = false;
                            mDataGridViewPer.Columns[13].Visible = false;
                            break;

                        case 2:
                            var personasBaja = db.Personas
                                                .Where(p => p.Baja == false).ToList();
                            bDataGridViewPer.DataSource = personasBaja;
                            // .Select("it.Id, it.Dni, it.Nombre, it.Apellido");

                            bDataGridViewPer.Columns[0].Visible = false;
                            bDataGridViewPer.Columns[3].Visible = false;
                            bDataGridViewPer.Columns[6].Visible = false;
                            bDataGridViewPer.Columns[7].Visible = false;
                            bDataGridViewPer.Columns[8].Visible = false;
                            bDataGridViewPer.Columns[9].Visible = false;
                            bDataGridViewPer.Columns[10].Visible = false;
                            bDataGridViewPer.Columns[11].Visible = false;
                            bDataGridViewPer.Columns[12].Visible = false;
                            bDataGridViewPer.Columns[13].Visible = false;
                            break;

                        default:
                            MessageBox.Show("No se puede determinar el indice de la Pestaña," +
                                        " por favor contacte al administrador", "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                            break;
                    }
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
            telPopUp tel = new telPopUp(telefonos);
            tel.StartPosition = FormStartPosition.CenterParent;
            tel.ShowDialog();
        }

        private void aButtonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Personas nuevaPersona = new Personas();
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

                // Se agregan telefonos
                
                PersonasTel telFijo = new PersonasTel();
                if (telefonos[0] != string.Empty)
                {
                    telFijo.Numero = Decimal.Parse(telefonos[0]);
                }
                else
                {
                    telFijo.Numero = 0;
                }
                telFijo.Tipo = "FI";
                nuevaPersona.PersonasTel.Add(telFijo);
                
                PersonasTel telMovil = new PersonasTel();
                if (telefonos[1] != string.Empty)
                {
                    telMovil.Numero = Decimal.Parse(telefonos[1]);
                } 
                else
                {
                    telMovil.Numero = 0;
                }
                telMovil.Tipo = "MO";
                nuevaPersona.PersonasTel.Add(telMovil);

                using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                {
                    db.Personas.Add(nuevaPersona);
                    db.SaveChanges();
                }
                MessageBox.Show("Se agrego: " + nuevaPersona.Nombre + " " + nuevaPersona.Apellido,
                            "Alta Personas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FunmPC.limpiarForm(aSplitContainer.Panel1);
                aButtonReactivar.Visible = false;
                aMaskedTextBoxDni.Focus();
                telefonos[0] = string.Empty;
                telefonos[1] = string.Empty;
                aux[0] = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.InnerException.Message);
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
            telefonos[0] = string.Empty;
            telefonos[1] = string.Empty;
            aux[0] = 0;
        }


        private void aButtonReactivar_Click(object sender, EventArgs e)
        {
            try
            {
                using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                {
                    var tempVar = aux[0];
                    var personaQ = db.Personas
                                     .Where(p => p.Id == tempVar);

                    personaQ.First().Baja = false;
                    db.SaveChanges();
                    MessageBox.Show("Se activo nuevamente a: " + personaQ.First().Nombre + " " +
                                personaQ.First().Apellido, "Alta Personas",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                FunmPC.limpiarForm(aSplitContainer.Panel1);
                FunmPC.readOnlyForm(aSplitContainer.Panel1, false);
                aButtonAceptar.Enabled = true;
                aButtonReactivar.Visible = false;
                aMaskedTextBoxDni.Focus();
                telefonos[0] = string.Empty;
                telefonos[1] = string.Empty;
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
                using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                {
                    aux[0] = Convert.ToInt32(aDataGridViewPer.SelectedRows[0].Cells[1].Value);
                    var tempVar = aux[0];
                    var personaQ = db.Personas
                                      .Where(p => p.Id == tempVar);

                    aMaskedTextBoxDni.Text = personaQ.First().Dni.ToString();
                    aMaskedTextBoxCuit.Text = personaQ.First().Cuit.ToString();
                    aTextBoxNombre.Text = personaQ.First().Nombre;
                    aTextBoxApellido.Text = personaQ.First().Apellido;
                    aTextBoxDireccion.Text = personaQ.First().Direccion;
                    aTextBoxCorreo.Text = personaQ.First().Correo;

                    // Si tiene telefonos registrados se cargan

                    var telefonosQ = db.PersonasTel
                                       .Where(t => t.IdPersona == tempVar);

                    if (telefonosQ.Any())
                    {
                        foreach (PersonasTel tel in telefonosQ)
                        {
                            if (tel.Tipo == "FI")
                            { telefonos[0] = tel.Numero.ToString(); }
                                
                            if (tel.Tipo == "MO")
                            { telefonos[1] = tel.Numero.ToString(); }
                                
                        }
                    }

                    FunmPC.readOnlyForm(aSplitContainer.Panel1, true);
                    aButtonAceptar.Enabled = false;
                    aButtonReactivar.Visible = true;
                }
                
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
                    using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                    {
                        var tempDNI = Convert.ToInt32(aMaskedTextBoxDni.Text);
                        var personaQ = db.Personas
                                         .Where(p => p.Dni == tempDNI);

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

                                // Si tiene telefonos registrados se cargan
                                var tempVar = aux[0];
                                var telefonosQ = db.PersonasTel
                                                   .Where(pt => pt.IdPersona == tempVar);

                                if (telefonosQ.Any())
                                {
                                    foreach (PersonasTel tel in telefonosQ)
                                    {
                                        if (tel.Tipo == "FI")
                                        { telefonos[0] = tel.Numero.ToString(); }

                                        if (tel.Tipo == "MO")
                                        { telefonos[1] = tel.Numero.ToString(); }

                                    }
                                }

                                FunmPC.readOnlyForm(aSplitContainer.Panel1, true);
                                aButtonAceptar.Enabled = false;
                                aButtonReactivar.Visible = true;
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
                    using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                    {
                        var tempDNI = Convert.ToInt32(mMaskedTextBoxDni.Text);
                        var personaQ = db.Personas
                                         .Where(p => p.Dni == tempDNI);

                        if (personaQ.Any())
                        {
                            mMaskedTextBoxCuit.Text = Convert.ToString(personaQ.First().Cuit);
                            mTextBoxNombre.Text = personaQ.First().Nombre;
                            mTextBoxApellido.Text = personaQ.First().Apellido;
                            mTextBoxDireccion.Text = personaQ.First().Direccion;
                            mTextBoxCorreo.Text = personaQ.First().Correo;
                            aux[1] = personaQ.First().Id;

                            // Si tiene telefonos registrados se cargan
                            var tempVar = aux[1];
                            var telefonosQ = db.PersonasTel
                                               .Where(pt => pt.IdPersona == tempVar);

                            if (telefonosQ.Any())
                            {
                                foreach (PersonasTel tel in telefonosQ)
                                {
                                    if (tel.Tipo == "FI")
                                    { telefonos[0] = tel.Numero.ToString(); }

                                    if (tel.Tipo == "MO")
                                    { telefonos[1] = tel.Numero.ToString(); }
                                }
                            }
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
                    using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                    {
                        var tempVar = aux[1];
                        var personaQ = db.Personas
                                         .Where(p => p.Id == tempVar);
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

                        // Guarda cambios en telefonos

                        foreach (PersonasTel tel in personaQ.First().PersonasTel)
                        {
                            if (tel.Tipo == "FI")
                            {
                                if (telefonos[0] != string.Empty)
                                {
                                    tel.Numero = Decimal.Parse(telefonos[0]); 
                                }
                                else
                                {
                                    tel.Numero = 0;
                                }
                            }

                            if (tel.Tipo == "MO")
                            {
                                if (telefonos[1] != string.Empty)
                                {
                                    tel.Numero = Decimal.Parse(telefonos[1]);
                                }
                                else
                                {
                                    tel.Numero = 0;
                                }
                            }
                        }

                        db.SaveChanges();
                        MessageBox.Show("Se modifico: " + personaQ.First().Nombre + " " + personaQ.First().Apellido,
                                    "Modificación de Personas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FunmPC.limpiarForm(mSplitContainer.Panel1);
                        mMaskedTextBoxDni.Focus();
                        telefonos[0] = string.Empty;
                        telefonos[1] = string.Empty;
                        aux[1] = 0;
                    }
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
                MessageBox.Show(ex.Message + " "  + ex.InnerException.Message);
            }
        }

        private void mButtonCancelar_Click(object sender, EventArgs e)
        {
            // Limpia el formulario.
            FunmPC.limpiarForm(mSplitContainer.Panel1);
            FunmPC.readOnlyForm(mSplitContainer.Panel1, false);
            mMaskedTextBoxDni.Focus();
            telefonos[0] = string.Empty;
            telefonos[1] = string.Empty;
            aux[1] = 0;
        }

        private void mButtonTelefonos_Click(object sender, EventArgs e)
        {
            telPopUp tel = new telPopUp(telefonos);
            tel.StartPosition = FormStartPosition.CenterParent;
            tel.ShowDialog();
        }

        private void mDataGridViewPer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                {
                    aux[1] = Convert.ToInt32(mDataGridViewPer.SelectedRows[0].Cells[1].Value);

                    // se usa una variable temporal ya que no se puede usar un array en la 
                    // expresion LINQ "The LINQ expression node type 'ArrayIndex' is not supported in LINQ to Entities"
                    var tempVar = aux[1];
                    var personasQ = db.Personas
                                      .Where(p => p.Id == tempVar);

                    mMaskedTextBoxDni.Text = Convert.ToString(personasQ.First().Dni);
                    mMaskedTextBoxCuit.Text = Convert.ToString(personasQ.First().Cuit);
                    mTextBoxNombre.Text = personasQ.First().Nombre;
                    mTextBoxApellido.Text = personasQ.First().Apellido;
                    mTextBoxDireccion.Text = personasQ.First().Direccion;
                    mTextBoxCorreo.Text = personasQ.First().Correo;

                    // Si tiene telefonos registrados se cargan

                    var telefonosQ = db.PersonasTel
                                       .Where(pt => pt.IdPersona == tempVar);

                    if (telefonosQ.Any())
                    {
                        foreach (PersonasTel tel in telefonosQ)
                        {
                            if (tel.Tipo == "FI")
                            { telefonos[0] = tel.Numero.ToString(); }

                            if (tel.Tipo == "MO")
                            { telefonos[1] = tel.Numero.ToString(); }

                        }
                    }
                }
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
                    using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                    {
                        var tempVar = aux[2];
                        var personaQ = db.Personas
                                         .Where(p=> p.Id == tempVar);

                        personaQ.First().Baja = true;
                        db.SaveChanges();
                        MessageBox.Show("Se dio de baja a: " + personaQ.First().Nombre,
                                    "Baja Personas",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FunmPC.limpiarForm(bSplitContainer.Panel1);
                        FunmPC.readOnlyForm(bSplitContainer.Panel1, false);
                        bMaskedTextBoxDni.Focus();
                        aux[2] = 0;
                    }
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
                    using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                    {
                        var tempDNI = Convert.ToInt32(bMaskedTextBoxDni.Text);
                        var personaQ = db.Personas
                                         .Where(p => p.Dni == tempDNI);

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
                using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                {
                    aux[2] = Convert.ToInt32(bDataGridViewPer.SelectedRows[0].Cells[1].Value);
                    var tempVar = aux[2];
                    var personaQ = db.Personas
                                     .Where(p => p.Id == tempVar);

                    bMaskedTextBoxDni.Text = Convert.ToString(personaQ.First().Dni);
                    bTextBoxNombre.Text = personaQ.First().Nombre;
                    bTextBoxApellido.Text = personaQ.First().Apellido;
                    bTextBoxDireccion.Text = personaQ.First().Direccion;
                    FunmPC.readOnlyForm(bSplitContainer.Panel1, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
#endregion  
    }
}
