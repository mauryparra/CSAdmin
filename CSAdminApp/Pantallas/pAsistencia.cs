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
    public partial class pAsistencia : UserControl
    {
        // aux[] es utilizado para guardar temporalmente el Id de la persona en c/ pestaña
        private int[] aux = { 0, 0};

        public pAsistencia()
        {
            InitializeComponent();
        }

        private void rTextBoxMotivo_TextChanged(object sender, EventArgs e)
        {
            rLabelCaracteres.Text = Convert.ToString(140 - rTextBoxMotivo.Text.Length);
        }

        private void rButtonRegistrar_Click(object sender, EventArgs e)
        {
            if (aux[0] != 0)
            {
                try
                {
                    Inasistencias nuevaInasistencia = new Inasistencias();
                    nuevaInasistencia.IdPersona = aux[0];
                    nuevaInasistencia.Desde = rDateTimePickerDesde.Value;
                    if (rDateTimePickerHasta.Checked)
                    {
                        nuevaInasistencia.Hasta = rDateTimePickerHasta.Value;
                    }
                    else
                    {
                        nuevaInasistencia.Hasta = null;
                    }
                    nuevaInasistencia.Motivo = rTextBoxMotivo.Text;

                    Main.BDContext.AddToInasistencias(nuevaInasistencia);
                    Main.BDContext.SaveChanges();
                    MessageBox.Show("Se registro la inasistencia de: " + rTextBoxNombre.Text,
                                    "Registro Inasistencias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FunmPC.limpiarForm(rGroupBoxPersona);
                    FunmPC.limpiarForm(rGroupBoxInasistencia);
                    rDateTimePickerHasta.Checked = false;
                    rTextBoxNombre.Focus();
                    aux[0] = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna persona",
                            "Registrar Inasistencias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rButtonCancelar_Click(object sender, EventArgs e)
        {
            FunmPC.limpiarForm(rGroupBoxPersona);
            FunmPC.limpiarForm(rGroupBoxInasistencia);
            rDateTimePickerHasta.Checked = false;
            rTextBoxNombre.Focus();
            aux[0] = 0;
        }

        private void rDataGridViewPersonas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                aux[0] = Convert.ToInt32(rDataGridViewPersonas.SelectedRows[0].Cells[0].Value);
                ObjectQuery<Personas> personaQ =
                    Main.BDContext.Personas.Where("it.Id = @Id");
                personaQ.Parameters.Add(new ObjectParameter("Id", aux[0]));

                rTextBoxNombre.Text = personaQ.First().NombreCompleto;
                rMaskedTextBoxDNI.Text = personaQ.First().Dni.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }
    }
}
