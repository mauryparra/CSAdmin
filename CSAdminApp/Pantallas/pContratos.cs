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
    public partial class pContratos : UserControl
    {
        List<string> cargos = new List<string>();
        List<string> condiciones = new List<string>();
        // aux[] es utilizado para guardar temporalmente el Id de la persona en c/ pestaña
        private int[] aux = { 0, 0, 0 };

        public pContratos()
        {
            InitializeComponent();
        }

        private void pContratos_Load(object sender, EventArgs e)
        {
            try
            {
                ObjectQuery<SituacionesProfesionales> sitProf =
                    Main.BDContext.SituacionesProfesionales;

                foreach (var sit in sitProf)
                {
                    if (!cargos.Contains(sit.CargoAbrev))
                    {
                        cargos.Add(sit.CargoAbrev);
                    }
                }

                aComboBoxCargo.DataSource = cargos;

                ObjectQuery<Equipos> equipos =
                    Main.BDContext.Equipos;
                aComboBoxEquipo.DataSource = equipos;
                aComboBoxEquipo.DisplayMember = "Id";
                aComboBoxEquipo.ValueMember = "Id";

                ObjectQuery<Funciones> funciones =
                    Main.BDContext.Funciones;
                aComboBoxFuncion.DataSource = funciones;
                aComboBoxFuncion.DisplayMember = "Funcion";
                aComboBoxFuncion.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }

        private void aCheckBoxAfectado_CheckedChanged(object sender, EventArgs e)
        {
            if (aCheckBoxAfectado.Checked)
            {
                aComboBoxOrigen.Enabled = true;
                aComboBoxOrigen.Focus();
            }
            else
            {
                aComboBoxOrigen.Enabled = false;
                aComboBoxOrigen.SelectedIndex = -1;
                aComboBoxCargo.Focus();
            }
        }

        private void aComboBoxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                condiciones.Clear();
                ObjectQuery<SituacionesProfesionales> sitCond =
                   Main.BDContext.SituacionesProfesionales.Where("it.CargoAbrev = @Cargo");
                sitCond.Parameters.Add(new ObjectParameter("Cargo", aComboBoxCargo.SelectedValue));

                foreach (var cond in sitCond)
                {
                    if (!condiciones.Contains(cond.CondicionAbrev))
                    {
                        condiciones.Add(cond.CondicionAbrev);
                    }
                }

                aComboBoxCondicion.DataSource = null;
                aComboBoxCondicion.DataSource = condiciones;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }

        private void aComboBoxEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ObjectQuery<Equipos> equipos =
                    Main.BDContext.Equipos.Where("it.Id = @Id");
                equipos.Parameters.Add(new ObjectParameter("Id", aComboBoxEquipo.SelectedValue));

                aTextBoxSede.Text = equipos.First().Ubicacion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }

        private void aMaskedTextBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    ObjectQuery<Personas> personas =
                    Main.BDContext.Personas.Where("it.Dni = @Dni");
                    personas.Parameters.Add(new ObjectParameter("Dni", Convert.ToDecimal(aMaskedTextBoxDNI.Text)));

                    if (personas.Any())
                    {
                        aMaskedTextBoxCuit.Text = personas.First().Cuit.ToString();
                        aTextBoxNombre.Text = personas.First().Nombre;
                        aTextBoxApellido.Text = personas.First().Apellido;
                        aux[0] = personas.First().Id;
                    }
                    else
                    {
                        MessageBox.Show("No hay ninguna persona con ese DNI", "Alta Contratos",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        FunmPC.limpiarForm(aGroupBoxPersona);
                        FunmPC.limpiarForm(aGroupBoxDestino);
                        aCheckBoxAfectado.Checked = false;
                        aNumericUpDownHoras.Value = 25;
                        aMaskedTextBoxDNI.Focus();
                        aux[0] = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
                }
            }
        }

        private void aMaskedTextBoxDNI_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (aMaskedTextBoxDNI.Text.Length > 0)
                {
                    ObjectQuery<Personas> personas =
                        Main.BDContext.Personas.Where("it.Dni = @Dni");
                    personas.Parameters.Add(new ObjectParameter("Dni", Convert.ToDecimal(aMaskedTextBoxDNI.Text)));

                    if (personas.Any())
                    {
                        aMaskedTextBoxCuit.Text = personas.First().Cuit.ToString();
                        aTextBoxNombre.Text = personas.First().Nombre;
                        aTextBoxApellido.Text = personas.First().Apellido;
                        aux[0] = personas.First().Id;
                    }
                    else
                    {
                        MessageBox.Show("No hay ninguna persona con ese DNI", "Alta Contratos",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        FunmPC.limpiarForm(aGroupBoxPersona);
                        FunmPC.limpiarForm(aGroupBoxDestino);
                        aCheckBoxAfectado.Checked = false;
                        aNumericUpDownHoras.Value = 25;
                        aMaskedTextBoxDNI.Focus();
                        aux[0] = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }

        private void aButtonCancelar_Click(object sender, EventArgs e)
        {
            FunmPC.limpiarForm(aGroupBoxPersona);
            FunmPC.limpiarForm(aGroupBoxDestino);
            aCheckBoxAfectado.Checked = false;
            aNumericUpDownHoras.Value = 25;
            aMaskedTextBoxDNI.Focus();
            aux[0] = 0;
        }

        private void aButtonGuardar_Click(object sender, EventArgs e)
        {
            if (aux[0] != 0)
            {
                try
                {
                    Contratos nuevoContrato = new Contratos();
                    nuevoContrato.PersonaId = aux[0];
                    nuevoContrato.FechaInicio = aDateTimePickerInicio.Value;
                    if (aDateTimePickerBaja.Checked == true)
                    {
                        nuevoContrato.FechaBaja = aDateTimePickerBaja.Value;
                    }
                    else
                    {
                        nuevoContrato.FechaBaja = null;
                    }
                    nuevoContrato.Afectado = aCheckBoxAfectado.Checked;
                    if (aCheckBoxAfectado.Checked)
                    {
                        nuevoContrato.Origen = aComboBoxOrigen.Text;
                    }
                    else
                    {
                        nuevoContrato.Origen = null;
                    }
                    nuevoContrato.CargoId = aComboBoxCargo.SelectedValue.ToString();
                    nuevoContrato.CondicionId = aComboBoxCondicion.SelectedItem.ToString();
                    nuevoContrato.FuncionId = aComboBoxFuncion.SelectedValue.ToString();
                    nuevoContrato.EquipoId = aComboBoxEquipo.SelectedValue.ToString();
                    nuevoContrato.Horas = Convert.ToByte(aNumericUpDownHoras.Value);
                    nuevoContrato.Observacion = aTextBoxObs.Text;

                    Main.BDContext.AddToContratos(nuevoContrato);
                    Main.BDContext.SaveChanges();
                    MessageBox.Show("Se agrego el contrato a: " + aTextBoxNombre.Text + " " + aTextBoxApellido.Text,
                                    "Alta Contratos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FunmPC.limpiarForm(aGroupBoxPersona);
                    FunmPC.limpiarForm(aGroupBoxDestino);
                    aCheckBoxAfectado.Checked = false;
                    aNumericUpDownHoras.Value = 25;
                    aMaskedTextBoxDNI.Focus();
                    aux[0] = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
                }
            }
            else MessageBox.Show("No se ha seleccionado ninguna persona",
                            "Alta Contratos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
