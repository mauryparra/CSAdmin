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
    public partial class pContratos : UserControl
    {
        List<string> cargos = new List<string>();
        List<string> condiciones = new List<string>();

        private AutoCompleteStringCollection autocomNombres = new AutoCompleteStringCollection();

        // key = NombreCompleto, value = Id
        private Dictionary<string, int> nombresDict = new Dictionary<string, int>();

        // aux[] es utilizado para guardar temporalmente el Id de la persona en c/ pestaña
        private int[] aux = { 0, 0 };
        private int auxContratoId = 0;

        public pContratos()
        {
            InitializeComponent();
        }

        private void pContratos_Load(object sender, EventArgs e)
        {
            try
            {
                using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                {
                    ObjectQuery<SituacionesProfesionales> sitProf =
                        db.SituacionesProfesionales;

                    foreach (var sit in sitProf)
                    {
                        if (!cargos.Contains(sit.CargoAbrev))
                        {
                            cargos.Add(sit.CargoAbrev);
                        }
                    }

                    aComboBoxCargo.DataSource = cargos;

                    ObjectQuery<Equipos> equipos =
                        db.Equipos;
                    aComboBoxEquipo.DataSource = equipos;
                    aComboBoxEquipo.DisplayMember = "Id";
                    aComboBoxEquipo.ValueMember = "Id";

                    mComboBoxEquipo.DataSource = equipos;
                    mComboBoxEquipo.DisplayMember = "Id";
                    mComboBoxEquipo.ValueMember = "Id";

                    ObjectQuery<Funciones> funciones =
                        db.Funciones;
                    aComboBoxFuncion.DataSource = funciones;
                    aComboBoxFuncion.DisplayMember = "Funcion";
                    aComboBoxFuncion.ValueMember = "Id";

                    mComboBoxFuncion.DataSource = funciones;
                    mComboBoxFuncion.DisplayMember = "Funcion";
                    mComboBoxFuncion.ValueMember = "Id";


                    foreach (Clases.Personas persona in db.Personas)
                    {
                        if (persona.Baja == false)
                        {
                            autocomNombres.Add(persona.NombreCompleto);

                            nombresDict.Add(persona.NombreCompleto, persona.Id);
                        }
                    }

                    toolStripTextBoxFiltro.AutoCompleteCustomSource = autocomNombres;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }

#region Alta

        private void aComboBoxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                {
                    condiciones.Clear();
                    ObjectQuery<SituacionesProfesionales> sitCond =
                       db.SituacionesProfesionales.Where("it.CargoAbrev = @Cargo");
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
                using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                {
                    ObjectQuery<Equipos> equipos =
                        db.Equipos.Where("it.Id = @Id");
                    equipos.Parameters.Add(new ObjectParameter("Id", aComboBoxEquipo.SelectedValue));

                    aTextBoxSede.Text = equipos.First().Ubicacion;
                }
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
                    using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                    {
                        ObjectQuery<Personas> personas =
                        db.Personas.Where("it.Dni = @Dni");
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
        }

        private void aMaskedTextBoxDNI_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                {
                    if (aMaskedTextBoxDNI.Text.Length > 0)
                    {
                        ObjectQuery<Personas> personas =
                            db.Personas.Where("it.Dni = @Dni");
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
                            aNumericUpDownHoras.Value = 25;
                            aMaskedTextBoxDNI.Focus();
                            aux[0] = 0;
                        }
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
            aNumericUpDownHoras.Value = 25;
            aMaskedTextBoxDNI.Focus();
            aComboBoxOrigen.SelectedIndex = -1;
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
                    nuevoContrato.Origen = aComboBoxOrigen.Text;
                    
                    nuevoContrato.CargoId = aComboBoxCargo.SelectedValue.ToString();
                    nuevoContrato.CondicionId = aComboBoxCondicion.SelectedItem.ToString();
                    nuevoContrato.FuncionId = aComboBoxFuncion.SelectedValue.ToString();
                    nuevoContrato.EquipoId = aComboBoxEquipo.SelectedValue.ToString();
                    nuevoContrato.Horas = Convert.ToByte(aNumericUpDownHoras.Value);
                    nuevoContrato.Observacion = aTextBoxObs.Text;

                    using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                    {
                        db.AddToContratos(nuevoContrato);
                        db.SaveChanges();
                        MessageBox.Show("Se agrego el contrato a: " + aTextBoxNombre.Text + " " + aTextBoxApellido.Text,
                                        "Alta Contratos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    FunmPC.limpiarForm(aGroupBoxPersona);
                    FunmPC.limpiarForm(aGroupBoxDestino);
                    aNumericUpDownHoras.Value = 25;
                    aMaskedTextBoxDNI.Focus();
                    aComboBoxOrigen.SelectedIndex = -1;
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

#endregion

#region Modificar
        private void mDataGridViewContratos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
            {
                // en aux se guarda el Id de persona
                aux[1] = Convert.ToInt32(mDataGridViewContratos.SelectedRows[0].Cells[1].Value);

                ObjectQuery<Personas> personaQ =
                        db.Personas.Where("it.Id = @Id");
                personaQ.Parameters.Add(new ObjectParameter("Id", aux[1]));

                mTextBoxNombre.Text = personaQ.First().NombreCompleto;
                mMaskedTextBoxDNI.Text = personaQ.First().Dni.ToString();

                // Datos Contrato
                auxContratoId = Convert.ToInt32(mDataGridViewContratos.SelectedRows[0].Cells[0].Value);

                ObjectQuery<Contratos> contratoQ =
                    db.Contratos.Where("it.Id = @Id");
                contratoQ.Parameters.Add(new ObjectParameter("Id", auxContratoId));

                mDateTimePickerInicio.Value = contratoQ.First().FechaInicio;
                if (contratoQ.First().FechaBaja.HasValue)
                {
                    mDateTimePickerBaja.Value = (DateTime)contratoQ.First().FechaBaja;
                    mDateTimePickerBaja.Checked = true;
                }
                else
                {
                    mDateTimePickerBaja.Value = DateTime.Now.Date;
                    mDateTimePickerBaja.Checked = false;
                }

                mComboBoxOrigen.Text = contratoQ.First().Origen;

                // Carga de combobox para Cargo y Condicion
                ObjectQuery<SituacionesProfesionales> sitProf =
                        db.SituacionesProfesionales;
                foreach (var sit in sitProf)
                {
                    if (!cargos.Contains(sit.CargoAbrev))
                    {
                        cargos.Add(sit.CargoAbrev);
                    }
                }
                mComboBoxCargo.DataSource = cargos;
                mComboBoxCargo.SelectedItem = contratoQ.First().CargoId;

                condiciones.Clear();
                ObjectQuery<SituacionesProfesionales> sitCond =
                   db.SituacionesProfesionales.Where("it.CargoAbrev = @Cargo");
                sitCond.Parameters.Add(new ObjectParameter("Cargo", mComboBoxCargo.SelectedValue));

                foreach (var cond in sitCond)
                {
                    if (!condiciones.Contains(cond.CondicionAbrev))
                    {
                        condiciones.Add(cond.CondicionAbrev);
                    }
                }

                mComboBoxCondicion.DataSource = null;
                mComboBoxCondicion.DataSource = condiciones;

                mComboBoxCondicion.SelectedItem = contratoQ.First().CondicionId;

                mComboBoxEquipo.SelectedValue = contratoQ.First().EquipoId;
                mComboBoxFuncion.SelectedValue = contratoQ.First().FuncionId;
                mNumericUpDownHoras.Value = contratoQ.First().Horas;
                mTextBoxObs.Text = contratoQ.First().Observacion;
                mButtonEliminar.Enabled = true;
            }
        }

        private void mButtonCancelar_Click(object sender, EventArgs e)
        {
            aux[1] = 0;
            auxContratoId = 0;
            FunmPC.limpiarForm(mGroupBoxPersona);
            FunmPC.limpiarForm(mGroupBoxContrato);
            mNumericUpDownHoras.Value = 25;
            mComboBoxOrigen.SelectedIndex = -1;
            mDateTimePickerInicio.Value = DateTime.Now.Date;
            mDateTimePickerBaja.Value = DateTime.Now.Date;
            mDateTimePickerBaja.Checked = false;
            mButtonEliminar.Enabled = false;
        }

        private void mButtonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (aux[1] != 0)
                {
                    using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                    {
                        ObjectQuery<Contratos> contratosQ =
                            db.Contratos.Where("it.Id = @Id");
                        contratosQ.Parameters.Add(new ObjectParameter("Id", auxContratoId));

                        contratosQ.First().FechaInicio = mDateTimePickerInicio.Value;
                        if (mDateTimePickerBaja.Checked)
                        {
                            contratosQ.First().FechaBaja = mDateTimePickerBaja.Value;
                        }
                        else
                        {
                            contratosQ.First().FechaBaja = null;
                        }

                        contratosQ.First().Origen = mComboBoxOrigen.Text;
                        contratosQ.First().EquipoId = (string)mComboBoxEquipo.SelectedValue;
                        contratosQ.First().FuncionId = (string)mComboBoxFuncion.SelectedValue;
                        contratosQ.First().Horas = Convert.ToByte(mNumericUpDownHoras.Value);
                        contratosQ.First().Observacion = mTextBoxObs.Text;

                        db.SaveChanges();
                        MessageBox.Show("Se han modificado los datos del contrato.", "Contratos",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        entityDataSource.Refresh();
                    }

                    // Limpiar Form
                    FunmPC.limpiarForm(mGroupBoxPersona);
                    FunmPC.limpiarForm(mGroupBoxContrato);
                    mDateTimePickerInicio.Value = DateTime.Now.Date;
                    mDateTimePickerBaja.Value = DateTime.Now.Date;
                    mDateTimePickerBaja.Checked = false;
                    mNumericUpDownHoras.Value = 25;
                    mComboBoxOrigen.SelectedIndex = -1;
                    toolStripTextBoxFiltro.Focus();
                    mButtonEliminar.Enabled = false;
                    aux[1] = 0;
                    auxContratoId = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }

        private void mButtonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (aux[1] != 0)
                {
                    passwordPrompt passprompt = new passwordPrompt();
                    DialogResult dr = passprompt.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                        {
                            ObjectQuery<Contratos> contratoQ =
                                db.Contratos.Where("it.Id = @Id");
                            contratoQ.Parameters.Add(new ObjectParameter("Id", auxContratoId));
                            db.Contratos.DeleteObject(contratoQ.First());
                            db.SaveChanges();
                            MessageBox.Show("Contrato eliminado");
                            entityDataSource.Refresh();
                        }


                        // Limpiar Form
                        FunmPC.limpiarForm(mGroupBoxPersona);
                        FunmPC.limpiarForm(mGroupBoxContrato);
                        mDateTimePickerInicio.Value = DateTime.Now.Date;
                        mDateTimePickerBaja.Value = DateTime.Now.Date;
                        mDateTimePickerBaja.Checked = false;
                        mNumericUpDownHoras.Value = 25;
                        mComboBoxOrigen.SelectedIndex = -1;
                        toolStripTextBoxFiltro.Focus();
                        mButtonEliminar.Enabled = false;
                        aux[1] = 0;
                        auxContratoId = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }

        private void mComboBoxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                {
                    condiciones.Clear();
                    ObjectQuery<SituacionesProfesionales> sitCond =
                       db.SituacionesProfesionales.Where("it.CargoAbrev = @Cargo");
                    sitCond.Parameters.Add(new ObjectParameter("Cargo", mComboBoxCargo.SelectedValue));

                    foreach (var cond in sitCond)
                    {
                        if (!condiciones.Contains(cond.CondicionAbrev))
                        {
                            condiciones.Add(cond.CondicionAbrev);
                        }
                    }

                    mComboBoxCondicion.DataSource = null;
                    mComboBoxCondicion.DataSource = condiciones;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.InnerException.Message);
            }
        }

        private void toolStripButtonFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (toolStripTextBoxFiltro.Text.Length > 0)
                {

                    // TODO agregar filtro de activos o inactivos
                    using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
                    {
                        switch (toolStripComboBoxCampos.SelectedIndex)
                        {
                            case 0:
                                if (nombresDict.Keys.Contains(toolStripTextBoxFiltro.Text))
                                {
                                    aux[1] = nombresDict[toolStripTextBoxFiltro.Text];
                                    if (toolStripButtonActivos.Checked) // Muestra solo contratos activos
                                    {
                                        ObjectQuery<Contratos> ContratosQF =
                                            db.Contratos.Where("it.PersonaId = @IdP AND it.FechaBaja IS NULL");
                                        ContratosQF.Parameters.Add(new ObjectParameter("IdP", aux[1]));
                                        var bindinglist = entityDataSource.CreateView(ContratosQF);
                                        mDataGridViewContratos.DataSource = bindinglist;
                                    }
                                    else
                                    {
                                        ObjectQuery<Contratos> ContratosQF =
                                            db.Contratos.Where("it.PersonaId = @IdP");
                                        ContratosQF.Parameters.Add(new ObjectParameter("IdP", aux[1]));
                                        var bindinglist = entityDataSource.CreateView(ContratosQF);
                                        mDataGridViewContratos.DataSource = bindinglist;
                                    }
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
                                    if (toolStripButtonActivos.Checked) // Muestra solo contratos activos
                                    {
                                        ObjectQuery<Contratos> contratosQF =
                                        db.Contratos.Where("it.PersonaId = @IdP AND it.FechaBaja IS NULL");
                                        contratosQF.Parameters.Add(new ObjectParameter("IdP", aux[1]));
                                        var bindinglist = entityDataSource.CreateView(contratosQF);
                                        mDataGridViewContratos.DataSource = bindinglist;
                                    }
                                    else
                                    {
                                        ObjectQuery<Contratos> contratosQF =
                                        db.Contratos.Where("it.PersonaId = @IdP");
                                        contratosQF.Parameters.Add(new ObjectParameter("IdP", aux[1]));
                                        var bindinglist = entityDataSource.CreateView(contratosQF);
                                        mDataGridViewContratos.DataSource = bindinglist;
                                    }

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
            mDataGridViewContratos.DataSource = entityDataSource;
            mDataGridViewContratos.DataMember = "Contratos";
        }

        private void toolStripButtonActivos_CheckedChanged(object sender, EventArgs e)
        {
            using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
            {
                if (toolStripButtonActivos.Checked)
                {
                    ObjectQuery<Contratos> contratosQ =
                                        db.Contratos.Where("it.FechaBaja IS NULL");
                    mDataGridViewContratos.DataSource = entityDataSource.CreateView(contratosQ);
                }
                else
                {
                    mDataGridViewContratos.DataSource = entityDataSource;
                    mDataGridViewContratos.DataMember = "Contratos";
                }
            }
        }
#endregion
    }
}
