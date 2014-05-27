using CSAdminApp.Clases;
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
    public partial class pEquipos : UserControl
    {
        public AutoCompleteStringCollection autocompleteEquipos = new AutoCompleteStringCollection();
        public pEquipos()
        {
            InitializeComponent();
        }

        private void pEquipos_Load(object sender, EventArgs e)
        {
            try
            {
                var equiposQuery =
                from eq in Main.BDContext.Equipos
                select new
                {
                    Id = eq.Id,
                    Ubicacion = eq.Ubicacion,
                    Localidad = eq.Localidades.Localidad,
                    Coordinador = eq.Personas.Nombre + " " + eq.Personas.Apellido,
                    Telefono = eq.Telefono,
                    Correo = eq.Correo
                };

                // Muestra todos los equipos en el Datagrid
                aDataGridViewEquipos.DataSource = equiposQuery;

                // Carga los campos para autocompletar el nombre de equipo
                foreach (Equipos eq in Main.BDContext.Equipos)
                {
                    autocompleteEquipos.Add(eq.Id);
                }
                aTextBoxNombre.AutoCompleteCustomSource = autocompleteEquipos;

                // Carga combobox de Localidades
                aComboBoxLocalidad.DataSource = Main.BDContext.Localidades.ToList();
                aComboBoxLocalidad.DisplayMember = "Localidad";
                aComboBoxLocalidad.ValueMember = "Id";

                // Carga combobox de Coordinadores
                aComboBoxCoordinador.DataSource = Main.BDContext.Personas.ToList();
                aComboBoxCoordinador.DisplayMember = "NombreCompleto";
                aComboBoxCoordinador.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException);
            }
        }

#region ALTA
        private void aButtonAceptar_Click(object sender, EventArgs e)
        {
            if (aTextBoxNombre.Text != "" && aTextBoxUbicacion.Text != "")
            {
                try
                {
                    Equipos nuevoEquipo = new Equipos();
                    nuevoEquipo.Id = aTextBoxNombre.Text;
                    nuevoEquipo.Ubicacion = aTextBoxUbicacion.Text;
                    nuevoEquipo.LocalidadId = (Int32)aComboBoxLocalidad.SelectedValue;
                    nuevoEquipo.Correo = aTextBoxCorreo.Text;
                    nuevoEquipo.Contra = aTextBoxContra.Text;
                    if (aMaskedTextBoxTelefono.Text != "")
                    {
                        nuevoEquipo.Telefono = Convert.ToDecimal(aMaskedTextBoxTelefono.Text);
                    }
                    nuevoEquipo.CoordinadoId = (Int32)aComboBoxCoordinador.SelectedValue;

                    Main.BDContext.AddToEquipos(nuevoEquipo);
                    Main.BDContext.SaveChanges();
                    MessageBox.Show("Se agrego: " + nuevoEquipo.Id + " a Equipos.",
                                "Alta Equipos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FunmPC.limpiarForm(aSplitContainer.Panel1);
                    aTextBoxNombre.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " " + ex.InnerException);
                }
            }
            else
            {
                MessageBox.Show("No se puede dar de alta el equipo sin los datos obligatorios",
                                "Alta Equipos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                aTextBoxNombre.Focus();
            }
        }

        private void aTextBoxNombre_Validating(object sender, CancelEventArgs e)
        {
            bool aux = false;
            foreach (string eq in autocompleteEquipos)
            {
                if (aTextBoxNombre.Text == eq)
                    aux = true;
            }
            if (aux == true)
            {
                MessageBox.Show("El nombre de Equipo no puede estar repetido",
                                "Alta Equipos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                aTextBoxNombre.Focus();
            }
        }

        private void aButtonCancelar_Click(object sender, EventArgs e)
        {
            FunmPC.limpiarForm(aSplitContainer.Panel1);
            aTextBoxNombre.Focus();
        }
#endregion

#region MODIFICAR

#endregion

#region BAJA

#endregion
    }
}
