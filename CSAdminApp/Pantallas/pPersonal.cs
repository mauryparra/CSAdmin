using System;
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
                switch (tabControlPersonal.SelectedIndex)
                {
                    case 0:
                        Personas nuevaPersona = new Personas();
                        ObjectQuery<Personas> personaQuery =
                            Main.BDContext.Personas.Where("it.Baja = True");
                        aDataGridViewPer.DataSource = personaQuery.Select("it.Id, it.Dni, it.Nombre, it.Apellido");
                        break;

                    case 1:
                        // TODO
                        break;

                    case 2:

                        //TODO
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
        bool soloLectura = false;

        private void aButtonTelefonos_Click(object sender, EventArgs e)
        {
            // TODO
            /*Dim tel As TelPopUp = New TelPopUp(nuevaPersona, soloLectura)
            With tel
                .StartPosition = FormStartPosition.CenterParent
                .aux = aux(0)
            End With
            tel.ShowDialog()*/
        }

        private void aButtonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                nuevaPersona.Dni = Decimal.Parse(aMaskedTextBoxDni.Text);
                nuevaPersona.Cuit = Decimal.Parse(aMaskedTextBoxCuit.Text);
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
    }
}
