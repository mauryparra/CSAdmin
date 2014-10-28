using System;
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
            using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
            {
                foreach (Clases.Personas persona in db.Personas)
                {
                    if (persona.Baja == false)
                    {
                        autocomNombres.Add(persona.NombreCompleto);
                        nombresDict.Add(persona.NombreCompleto, persona.Id);
                    }
                }
            } 

            mButtonEliminar.Enabled = false;
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

                    using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                    {
                        db.AddToInasistencias(nuevaInasistencia);
                        db.SaveChanges();
                    }
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
                using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                {
                    aux[0] = Convert.ToInt32(rDataGridViewPersonas.SelectedRows[0].Cells[0].Value);
                    ObjectQuery<Personas> personaQ =
                        db.Personas.Where("it.Id = @Id");
                    personaQ.Parameters.Add(new ObjectParameter("Id", aux[0]));

                    rTextBoxNombre.Text = personaQ.First().NombreCompleto;
                    rMaskedTextBoxDNI.Text = personaQ.First().Dni.ToString();
                }
                
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
                    using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                    {
                        ObjectQuery<Personas> personas =
                        db.Personas.Where("it.Dni = @Dni");
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
                        using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                        {
                            ObjectQuery<Personas> personas =
                                db.Personas.Where("it.Id = @Id");
                            personas.Parameters.Add(new ObjectParameter("Id", nombresDict[rTextBoxNombre.Text]));

                            rMaskedTextBoxDNI.Text = personas.First().Dni.ToString();
                            aux[0] = nombresDict[rTextBoxNombre.Text];
                        }
                        
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
            mButtonEliminar.Enabled = false;
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
                    using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                    {
                        ObjectQuery<Inasistencias> inasistenciaQ =
                             db.Inasistencias.Where("it.Id = @Id");
                        inasistenciaQ.Parameters.Add(new ObjectParameter("Id", auxInasistencia));

                        inasistenciaQ.First().Desde = mDateTimePickerDesde.Value.Date;
                        if (mDateTimePickerHasta.Checked == true)
                        {
                            inasistenciaQ.First().Hasta = mDateTimePickerHasta.Value.Date;
                        }
                        else
                        {
                            inasistenciaQ.First().Hasta = null;
                        }
                        inasistenciaQ.First().Motivo = mTextBoxMotivo.Text;

                        db.SaveChanges();
                        MessageBox.Show("Se han modificado los datos de la insasistencia.", "Asistencias",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        entityDataSource.Refresh();
                    }


                    // Limpiar Form
                    FunmPC.limpiarForm(mGroupBoxPersona);
                    FunmPC.limpiarForm(mGroupBoxInasistencia);
                    mDateTimePickerDesde.Value = DateTime.Now.Date;
                    mDateTimePickerHasta.Value = DateTime.Now.Date;
                    mDateTimePickerHasta.Checked = false;
                    toolStripTextBoxFiltro.Focus();
                    mGroupBoxInasistencia.Text = "Inasistencia";
                    mButtonEliminar.Enabled = false;
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

        private void mButtonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (aux[1] != 0)
                {
                    using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                    {

                        passwordPrompt passprompt = new passwordPrompt();
                        DialogResult dr = passprompt.ShowDialog();
                        if (dr == DialogResult.OK)
                        {
                            ObjectQuery<Inasistencias> borrarInasistencia =
                                db.Inasistencias.Where("it.Id = @Id");
                            borrarInasistencia.Parameters.Add(new ObjectParameter("Id", auxInasistencia));
                            db.Inasistencias.DeleteObject(borrarInasistencia.First());
                            db.SaveChanges();
                            MessageBox.Show("Inasistencia eliminada");
                            entityDataSource.Refresh();

                            // Limpiar Form
                            FunmPC.limpiarForm(mGroupBoxPersona);
                            FunmPC.limpiarForm(mGroupBoxInasistencia);
                            mDateTimePickerDesde.Value = DateTime.Now.Date;
                            mDateTimePickerHasta.Value = DateTime.Now.Date;
                            mDateTimePickerHasta.Checked = false;
                            toolStripTextBoxFiltro.Focus();
                            mGroupBoxInasistencia.Text = "Inasistencia";
                            mButtonEliminar.Enabled = false;
                            aux[1] = 0;
                            auxInasistencia = 0;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }

        private void mDataGridViewAsistencia_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                {
                    // Datos Persona
                    aux[1] = Convert.ToInt32(mDataGridViewAsistencia.SelectedRows[0].Cells[1].Value);
                    ObjectQuery<Personas> personaQ =
                        db.Personas.Where("it.Id = @Id");
                    personaQ.Parameters.Add(new ObjectParameter("Id", aux[1]));

                    mTextBoxNombre.Text = personaQ.First().NombreCompleto;
                    mMaskedTextBoxDNI.Text = personaQ.First().Dni.ToString();

                    // Datos Inasistencia
                    auxInasistencia = Convert.ToInt32(mDataGridViewAsistencia.SelectedRows[0].Cells[0].Value);
                    ObjectQuery<Inasistencias> inasistenciaQ =
                        db.Inasistencias.Where("it.Id = @Id");
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
                    mButtonEliminar.Enabled = true;
                }
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
            try
            {
                if (toolStripTextBoxFiltro.Text.Length > 0)
                {
                    using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                    {
                        switch (toolStripComboBoxCampos.SelectedIndex)
                        {
                            case 0:
                                if (nombresDict.Keys.Contains(toolStripTextBoxFiltro.Text))
                                {
                                    aux[1] = nombresDict[toolStripTextBoxFiltro.Text];
                                    ObjectQuery<Inasistencias> inasistenciasQF =
                                        db.Inasistencias.Where("it.IdPersona = @IdP");
                                    inasistenciasQF.Parameters.Add(new ObjectParameter("IdP", aux[1]));
                                    var bindinglist = entityDataSource.CreateView(inasistenciasQF);
                                    mDataGridViewAsistencia.DataSource = bindinglist;
                                }
                                else
                                {
                                    MessageBox.Show("No se encontraron registros con ese nombre");
                                    toolStripTextBoxFiltro.Focus();
                                }
                                break;

                            case 1:
                                ObjectQuery<Personas> personaQF =
                                    db.Personas.Where("it.DNI = @Dni");
                                personaQF.Parameters.Add(new ObjectParameter("Dni", Decimal.Parse(toolStripTextBoxFiltro.Text)));
                                if (personaQF.Any())
                                {
                                    aux[1] = personaQF.First().Id;
                                    ObjectQuery<Inasistencias> inasistenciaQF =
                                        db.Inasistencias.Where("it.IdPersona = @IdP");
                                    inasistenciaQF.Parameters.Add(new ObjectParameter("IdP", aux[1]));
                                    var bindinglist = entityDataSource.CreateView(inasistenciaQF);
                                    mDataGridViewAsistencia.DataSource = bindinglist;
                                }
                                else
                                {
                                    MessageBox.Show("No se encontraron registros con ese DNI");
                                    toolStripTextBoxFiltro.Focus();
                                }
                                break;

                            default:
                                break;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButtonLimpiar_Click(object sender, EventArgs e)
        {
            toolStripTextBoxFiltro.Clear();
            mDataGridViewAsistencia.DataSource = entityDataSource;
            mDataGridViewAsistencia.DataMember = "Inasistencias";
        }
#endregion
    }
}
