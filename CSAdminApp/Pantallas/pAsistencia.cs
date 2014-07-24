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
        private int auxInasistencia = 0;

        private AutoCompleteStringCollection autocomNombres = new AutoCompleteStringCollection();

        // key = NombreCompleto, value = Id
        private Dictionary<string, int> nombresDict = new Dictionary<string, int>();

        public pAsistencia()
        {
            InitializeComponent();
        }

        private void pAsistencia_Load(object sender, EventArgs e)
        {
            foreach (Clases.Personas persona in Main.BDContext.Personas)
            {
                if (persona.Baja == false)
                {
                    autocomNombres.Add(persona.NombreCompleto);

                    nombresDict.Add(persona.NombreCompleto, persona.Id);
                }
            }

            rTextBoxNombre.AutoCompleteCustomSource = autocomNombres;
            toolStripTextBoxFiltro.AutoCompleteCustomSource = autocomNombres;
            errorProvider.Clear();
        }

#region Registro

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

        private void rMaskedTextBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    ObjectQuery<Personas> personas =
                        Main.BDContext.Personas.Where("it.Dni = @Dni");
                    personas.Parameters.Add(new ObjectParameter("Dni", Convert.ToDecimal(rMaskedTextBoxDNI.Text)));

                    if (personas.Any())
                    {
                        rTextBoxNombre.Text = personas.First().NombreCompleto;
                        aux[0] = personas.First().Id;
                    }
                    else
                    {
                        MessageBox.Show("No hay ninguna persona con ese DNI", "Asistencias",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        FunmPC.limpiarForm(rGroupBoxPersona);
                        FunmPC.limpiarForm(rGroupBoxInasistencia);
                        rDateTimePickerHasta.Checked = false;
                        rTextBoxNombre.Focus();
                        aux[0] = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
                }
            }
        }

        private void rTextBoxNombre_Validated(object sender, EventArgs e)
        {
            if (rTextBoxNombre.Text.Length > 0)
            {
                try
                {
                    if (nombresDict.ContainsKey(rTextBoxNombre.Text))
                    {
                        ObjectQuery<Personas> personas =
                            Main.BDContext.Personas.Where("it.Id = @Id");
                        personas.Parameters.Add(new ObjectParameter("Id", nombresDict[rTextBoxNombre.Text]));

                        rMaskedTextBoxDNI.Text = personas.First().Dni.ToString();
                        aux[0] = nombresDict[rTextBoxNombre.Text];
                    }
                    else
                    {
                        MessageBox.Show("No hay ninguna persona con ese nombre", "Asistencias",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        FunmPC.limpiarForm(rGroupBoxPersona);
                        FunmPC.limpiarForm(rGroupBoxInasistencia);
                        rDateTimePickerHasta.Checked = false;
                        rTextBoxNombre.Focus();
                        aux[0] = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
                }
            }
        }
#endregion

#region Modificacion

        private void mTextBoxMotivo_TextChanged(object sender, EventArgs e)
        {
            mLabelCaracteres.Text = Convert.ToString(140 - mTextBoxMotivo.Text.Length);
        }

        private void mButtonCancelar_Click(object sender, EventArgs e)
        {
            FunmPC.limpiarForm(mGroupBoxPersona);
            FunmPC.limpiarForm(mGroupBoxInasistencia);
            mDateTimePickerDesde.Value = DateTime.Now;
            mDateTimePickerHasta.Value = DateTime.Now;
            mDateTimePickerHasta.Checked = false;
            toolStripTextBoxFiltro.Focus();
            mGroupBoxInasistencia.Text = "Inasistencia";
            errorProvider.Clear();
            aux[1] = 0;
            auxInasistencia = 0;
        }

        private void mButtonModificar_Click(object sender, EventArgs e)
        {
            if (aux[1] != 0)
            {
                try
                {
                    ObjectQuery<Inasistencias> inasistenciaQ =
                            Main.BDContext.Inasistencias.Where("it.Id = @Id");
                    inasistenciaQ.Parameters.Add(new ObjectParameter("Id", auxInasistencia));

                    inasistenciaQ.First().Desde = mDateTimePickerDesde.Value;
                    if (mDateTimePickerHasta.Checked == true)
                    {
                        inasistenciaQ.First().Hasta = mDateTimePickerHasta.Value;
                    }
                    else
                    {
                        inasistenciaQ.First().Hasta = null;
                    }
                    inasistenciaQ.First().Motivo = mTextBoxMotivo.Text;

                    Main.BDContext.SaveChanges();
                    MessageBox.Show("Se han modificado los datos de la insasistencia.", "Asistencias",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    entityDataSource.Refresh();

                    // Limpiar Form
                    FunmPC.limpiarForm(mGroupBoxPersona);
                    FunmPC.limpiarForm(mGroupBoxInasistencia);
                    mDateTimePickerDesde.Value = DateTime.Now;
                    mDateTimePickerHasta.Value = DateTime.Now;
                    mDateTimePickerHasta.Checked = false;
                    toolStripTextBoxFiltro.Focus();
                    mGroupBoxInasistencia.Text = "Inasistencia";
                    aux[1] = 0;
                    auxInasistencia = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna inasistencia seleccionada", "Asistencias",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mDataGridViewAsistencia_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                // Datos Persona
                aux[1] = Convert.ToInt32(mDataGridViewAsistencia.SelectedRows[0].Cells[1].Value);
                ObjectQuery<Personas> personaQ =
                    Main.BDContext.Personas.Where("it.Id = @Id");
                personaQ.Parameters.Add(new ObjectParameter("Id", aux[1]));

                mTextBoxNombre.Text = personaQ.First().NombreCompleto;
                mMaskedTextBoxDNI.Text = personaQ.First().Dni.ToString();

                // Datos Inasistencia
                auxInasistencia = Convert.ToInt32(mDataGridViewAsistencia.SelectedRows[0].Cells[0].Value);
                ObjectQuery<Inasistencias> inasistenciaQ =
                    Main.BDContext.Inasistencias.Where("it.Id = @Id");
                inasistenciaQ.Parameters.Add(new ObjectParameter("Id", auxInasistencia));

                mDateTimePickerDesde.Value = inasistenciaQ.First().Desde;
                if (inasistenciaQ.First().Hasta != null)
                {
                    mDateTimePickerHasta.Value = (DateTime)inasistenciaQ.First().Hasta;
                    mDateTimePickerHasta.Checked = true;
                }
                else
                {
                    mDateTimePickerHasta.Value = DateTime.Now;
                    mDateTimePickerHasta.Checked = false;
                }
                mTextBoxMotivo.Text = inasistenciaQ.First().Motivo;
                mGroupBoxInasistencia.Text = "Inasistencia - ID: " + inasistenciaQ.First().Id.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }

        private void mDateTimePickerDesde_Validating(object sender, CancelEventArgs e)
        {
            if (mDateTimePickerHasta.Checked == true)
            {
                if (FunmPC.compareDates(mDateTimePickerDesde.Value, mDateTimePickerHasta.Value))
                {
                    errorProvider.Clear();
                }
                else
                {
                    errorProvider.SetError(mDateTimePickerDesde, "La fecha debe ser menor o igual a la fecha de finalización");
                }
            }
            
        }

        private void mDateTimePickerHasta_Validating(object sender, CancelEventArgs e)
        {
            if (mDateTimePickerHasta.Checked == true)
            {
                if (FunmPC.compareDates(mDateTimePickerDesde.Value, mDateTimePickerHasta.Value))
                {
                    errorProvider.Clear();
                }
                else
                {
                    errorProvider.SetError(mDateTimePickerHasta, "La fecha debe ser igual o mayor a la fecha de inicio");
                }
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void toolStripButtonFiltrar_Click(object sender, EventArgs e)
        {
            if (toolStripComboBoxCampos.SelectedText == "Nombre")
            {
                // TODO Filtrar por nombre
            }
            else if (toolStripComboBoxCampos.SelectedText == "DNI")
            {
                // TODO Filtrar por DNI
            }
        }
#endregion
    }
}
