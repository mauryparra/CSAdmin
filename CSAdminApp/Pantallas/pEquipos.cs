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
        public AutoCompleteStringCollection autocompleteEquipos;
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
    }
}
