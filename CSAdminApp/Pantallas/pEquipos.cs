using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CSAdminApp.Clases;

namespace CSAdminApp.Pantallas
{
    public partial class pEquipos : UserControl
    {
        // aux[] es utilizado para guardar temporalmente el Id del equipo en c/ pestaña
        // aux[0] para pesataña Modificar, aux[1] para pestaña Baja
        private string[] aux = { "", "" };
        public AutoCompleteStringCollection autocompleteEquipos = new AutoCompleteStringCollection();
        public pEquipos()
        {
            InitializeComponent();
        }

        private void pEquipos_Load(object sender, EventArgs e)
        {
            try
            {
                using (CSAdminBDEntities db = new CSAdminBDEntities())
                {
                    var equiposQuery =
                    from eq in db.Equipos
                    select new
                    {
                        Id = eq.Id,
                        Ubicacion = eq.Ubicacion,
                        Localidad = eq.Localidades.Localidad,
                        Coordinador = eq.Personas.Nombre + " " + eq.Personas.Apellido,
                        Telefono = eq.Telefono,
                        Correo = eq.Correo,
                        Contraseña = eq.Contra
                    };

                    // Muestra todos los equipos en el Datagrid
                    aDataGridViewEquipos.DataSource = equiposQuery;

                    // Carga los campos para autocompletar el nombre de equipo
                    foreach (Equipos eq in db.Equipos)
                    {
                        if (!autocompleteEquipos.Contains(eq.Id))
                        autocompleteEquipos.Add(eq.Id);
                    }
                    aTextBoxNombre.AutoCompleteCustomSource = autocompleteEquipos;

                    // Carga combobox de Localidades
                    aComboBoxLocalidad.DataSource = db.Localidades.ToList();
                    aComboBoxLocalidad.DisplayMember = "Localidad";
                    aComboBoxLocalidad.ValueMember = "Id";

                    // Carga combobox de Coordinadores
                    aComboBoxCoordinador.DataSource = db.Personas.ToList();
                    aComboBoxCoordinador.DisplayMember = "NombreCompleto";
                    aComboBoxCoordinador.ValueMember = "Id";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException.Message);
            }
        }

        private void tabControlEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (CSAdminBDEntities db = new CSAdminBDEntities())
                {
                    switch (tabControlEquipos.SelectedIndex)
                    {
                        case 0:
                            var equiposQ0 =
                            from eq in db.Equipos
                            select new
                            {
                                Id = eq.Id,
                                Ubicacion = eq.Ubicacion,
                                Localidad = eq.Localidades.Localidad,
                                Coordinador = eq.Personas.Nombre + " " + eq.Personas.Apellido,
                                Telefono = eq.Telefono,
                                Correo = eq.Correo,
                                Contraseña = eq.Contra
                            };

                            // Muestra todos los equipos en el Datagrid
                            aDataGridViewEquipos.DataSource = equiposQ0;

                            // Carga los campos para autocompletar el nombre de equipo
                            foreach (Equipos eq in db.Equipos)
                            {
                                if (!autocompleteEquipos.Contains(eq.Id))
                                    autocompleteEquipos.Add(eq.Id);
                            }
                            aTextBoxNombre.AutoCompleteCustomSource = autocompleteEquipos;

                            // Carga combobox de Localidades
                            aComboBoxLocalidad.DataSource = db.Localidades.ToList();
                            aComboBoxLocalidad.DisplayMember = "Localidad";
                            aComboBoxLocalidad.ValueMember = "Id";

                            // Carga combobox de Coordinadores
                            aComboBoxCoordinador.DataSource = db.Personas.ToList();
                            aComboBoxCoordinador.DisplayMember = "NombreCompleto";
                            aComboBoxCoordinador.ValueMember = "Id";
                            break;

                        case 1:
                            var equiposQ1 =
                            from eq in db.Equipos
                            select new
                            {
                                Id = eq.Id,
                                Ubicacion = eq.Ubicacion,
                                Localidad = eq.Localidades.Localidad,
                                Coordinador = eq.Personas.Nombre + " " + eq.Personas.Apellido,
                                Telefono = eq.Telefono,
                                Correo = eq.Correo,
                                Contraseña = eq.Contra
                            };

                            // Muestra todos los equipos en el Datagrid
                            mDataGridViewEquipos.DataSource = equiposQ1;

                            // Carga los campos para autocompletar el nombre de equipo
                            foreach (Equipos eq in db.Equipos)
                            {
                                if (!autocompleteEquipos.Contains(eq.Id))
                                    autocompleteEquipos.Add(eq.Id);
                            }
                            mTextBoxNombre.AutoCompleteCustomSource = autocompleteEquipos;

                            // Carga combobox de Localidades
                            mComboBoxLocalidad.DataSource = db.Localidades.ToList();
                            mComboBoxLocalidad.DisplayMember = "Localidad";
                            mComboBoxLocalidad.ValueMember = "Id";

                            // Carga combobox de Coordinadores
                            mComboBoxCoordinador.DataSource = db.Personas.ToList();
                            mComboBoxCoordinador.DisplayMember = "NombreCompleto";
                            mComboBoxCoordinador.ValueMember = "Id";
                            break;

                        case 2:
                            var equiposQ2 =
                            from eq in db.Equipos
                            select new
                            {
                                Id = eq.Id,
                                Ubicacion = eq.Ubicacion,
                                Localidad = eq.Localidades.Localidad,
                                Coordinador = eq.Personas.Nombre + " " + eq.Personas.Apellido,
                                Telefono = eq.Telefono,
                                Correo = eq.Correo,
                                Contraseña = eq.Contra
                            };

                            // Muestra todos los equipos en el Datagrid
                            bDataGridViewEquipos.DataSource = equiposQ2;

                            // Carga los campos para autocompletar el nombre de equipo
                            foreach (Equipos eq in db.Equipos)
                            {
                                if (!autocompleteEquipos.Contains(eq.Id))
                                    autocompleteEquipos.Add(eq.Id);
                            }
                            bTextBoxNombre.AutoCompleteCustomSource = autocompleteEquipos;
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
                MessageBox.Show(ex.Message + " " + ex.InnerException.Message);
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

                    using (CSAdminBDEntities db = new CSAdminBDEntities())
                    {
                        db.AddToEquipos(nuevoEquipo);
                        db.SaveChanges();
                    }

                    MessageBox.Show("Se agrego: " + nuevoEquipo.Id + " a Equipos.",
                                "Alta Equipos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FunmPC.limpiarForm(aSplitContainer.Panel1);
                    aTextBoxNombre.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " " + ex.InnerException.Message);
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
        // Se usa aux[0]

        private void mButtonModificar_Click(object sender, EventArgs e)
        {
            // Modificar datos de un Equipo en particular
            if (aux[0] != "")
            {
                try
                {
                    using (CSAdminBDEntities db = new CSAdminBDEntities())
                    {
                        ObjectQuery<Equipos> equipoQ =
                            db.Equipos.Where("it.Id = @Id");
                        equipoQ.Parameters.Add(new ObjectParameter("Id", aux[0]));

                        equipoQ.First().Ubicacion = mTextBoxUbicacion.Text;
                        equipoQ.First().LocalidadId = (Int32)mComboBoxLocalidad.SelectedValue;
                        equipoQ.First().Correo = mTextBoxCorreo.Text;
                        equipoQ.First().Contra = mTextBoxContra.Text;
                        if (mMaskedTextBoxTelefono.Text != "")
                        {
                            equipoQ.First().Telefono = Convert.ToDecimal(mMaskedTextBoxTelefono.Text);
                        }
                        equipoQ.First().CoordinadoId = (Int32)mComboBoxCoordinador.SelectedValue;

                        db.SaveChanges();
                        MessageBox.Show("Se modificaron datos de: " + equipoQ.First().Id,
                                        "Modificación de  Equipos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    FunmPC.limpiarForm(mSplitContainer.Panel1);
                    aux[0] = "";
                    mTextBoxNombre.ReadOnly = false;
                    mTextBoxNombre.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " " + ex.InnerException.Message);
                }
            }
        }

        private void mButtonCancelar_Click(object sender, EventArgs e)
        {
            FunmPC.limpiarForm(mSplitContainer.Panel1);
            aux[0] = "";
            mTextBoxNombre.ReadOnly = false;
            mTextBoxNombre.Focus();
        }

        private void mDataGridViewEquipos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                using (CSAdminBDEntities db = new CSAdminBDEntities())
                {
                    aux[0] = (string)mDataGridViewEquipos.SelectedRows[0].Cells[0].Value;
                    ObjectQuery<Equipos> equipoQ =
                        db.Equipos.Where("it.Id = @Id");
                    equipoQ.Parameters.Add(new ObjectParameter("Id", aux[0]));

                    mTextBoxNombre.Text = equipoQ.First().Id;
                    mTextBoxUbicacion.Text = equipoQ.First().Ubicacion;
                    mComboBoxLocalidad.SelectedValue = equipoQ.First().Localidades.Id;
                    mTextBoxCorreo.Text = equipoQ.First().Correo;
                    mTextBoxContra.Text = equipoQ.First().Contra;
                    mMaskedTextBoxTelefono.Text = equipoQ.First().Telefono.ToString();
                    mComboBoxCoordinador.SelectedValue = equipoQ.First().Personas.Id;

                    mTextBoxNombre.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException.Message);
            }
        }

        private void mTextBoxNombre_KeyDown(object sender, KeyEventArgs e)
        {
            // Al presionar enter en el textbox se busca el equipo y se intenta cargar en el form
            // Se usa el evento KeyDown en lugar de KeyPress ya que no funciona con autocompletar
            // en el textboxt activado. Ver http://stackoverflow.com/q/11720796
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    using (CSAdminBDEntities db = new CSAdminBDEntities())
                    {
                        ObjectQuery<Equipos> equiposQ =
                            db.Equipos.Where("it.Id = @Id");
                        equiposQ.Parameters.Add(new ObjectParameter("Id", mTextBoxNombre.Text));

                        if (equiposQ.Any())
                        {
                            aux[0] = equiposQ.First().Id;
                            mTextBoxUbicacion.Text = equiposQ.First().Ubicacion;
                            mComboBoxLocalidad.SelectedValue = equiposQ.First().Localidades.Id;
                            mTextBoxCorreo.Text = equiposQ.First().Correo;
                            mTextBoxContra.Text = equiposQ.First().Contra;
                            mMaskedTextBoxTelefono.Text = equiposQ.First().Telefono.ToString();
                            mComboBoxCoordinador.SelectedValue = equiposQ.First().Personas.Id;

                            mTextBoxNombre.ReadOnly = true;
                        }
                        else
                        {
                            aux[0] = "";
                            MessageBox.Show("No se encontro ningun equipo llamado: " + mTextBoxNombre.Text,
                                        "Modificacion Equipos",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FunmPC.limpiarForm(mSplitContainer.Panel1);
                            mTextBoxNombre.ReadOnly = false;
                            mTextBoxNombre.Focus();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " " + ex.InnerException.Message);
                }
            }
        }

        private void mTextBoxNombre_Validating(object sender, CancelEventArgs e)
        {
            // Al perder el foco el textbox se busca el equipo y se intenta cargar en el form
            if (mTextBoxNombre.Text != "")
            {
                try
                {
                    using (CSAdminBDEntities db = new CSAdminBDEntities())
                    {
                        ObjectQuery<Equipos> equiposQ =
                            db.Equipos.Where("it.Id = @Id");
                        equiposQ.Parameters.Add(new ObjectParameter("Id", mTextBoxNombre.Text));

                        if (equiposQ.Any())
                        {
                            aux[0] = equiposQ.First().Id;
                            mTextBoxUbicacion.Text = equiposQ.First().Ubicacion;
                            mComboBoxLocalidad.SelectedValue = equiposQ.First().Localidades.Id;
                            mTextBoxCorreo.Text = equiposQ.First().Correo;
                            mTextBoxContra.Text = equiposQ.First().Contra;
                            mMaskedTextBoxTelefono.Text = equiposQ.First().Telefono.ToString();
                            mComboBoxCoordinador.SelectedValue = equiposQ.First().Personas.Id;

                            mTextBoxNombre.ReadOnly = true;
                        }
                        else
                        {
                            aux[0] = "";
                            MessageBox.Show("No se encontro ningun equipo llamado: " + mTextBoxNombre.Text,
                                        "Modificacion Equipos",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FunmPC.limpiarForm(mSplitContainer.Panel1);
                            mTextBoxNombre.ReadOnly = false;
                            mTextBoxNombre.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " " + ex.InnerException.Message);
                }
            }
        }

#endregion

#region BAJA
        // Se usa aux[1]

        private void bButtonBaja_Click(object sender, EventArgs e)
        {
            // Intenta dar baja a Equipo
            if (aux[1] != "")
            {
                try
                {
                    using (CSAdminBDEntities db = new CSAdminBDEntities())
                    {
                        ObjectQuery<Equipos> equiposQ =
                            db.Equipos.Where("it.Id = @Id");
                        equiposQ.Parameters.Add(new ObjectParameter("Id", aux[1]));

                        if (equiposQ.Any())
                        {
                            db.Equipos.DeleteObject(equiposQ.First());
                            db.SaveChanges();
                            MessageBox.Show("Se dio de baja al equipo: " + bTextBoxNombre.Text,
                                        "Baja de Equipos",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                            aux[1] = "";
                            FunmPC.limpiarForm(bSplitContainer.Panel1);
                            bTextBoxNombre.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " " + ex.InnerException.Message);
                }
            }
            else
            {
                MessageBox.Show("No se selecciono ningún equipo.",
                                    "Baja de Equipos",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bButtonCancelar_Click(object sender, EventArgs e)
        {
            FunmPC.limpiarForm(bSplitContainer.Panel1);
            aux[1] = "";
            bTextBoxNombre.Focus();
        }

        private void bTextBoxNombre_KeyDown(object sender, KeyEventArgs e)
        {
            // Al presionar enter en el textbox se busca el equipo y se intenta cargar en el form
            // Se usa el evento KeyDown en lugar de KeyPress ya que no funciona con autocompletar
            // en el textboxt activado. Ver http://stackoverflow.com/q/11720796
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    using (CSAdminBDEntities db = new CSAdminBDEntities())
                    {
                        ObjectQuery<Equipos> equiposQ =
                            db.Equipos.Where("it.Id = @Id");
                        equiposQ.Parameters.Add(new ObjectParameter("Id", bTextBoxNombre.Text));

                        if (equiposQ.Any())
                        {
                            aux[1] = equiposQ.First().Id;
                            bTextBoxUbicacion.Text = equiposQ.First().Ubicacion;
                            bTextBoxLocalidad.Text = equiposQ.First().Localidades.Localidad;
                            bTextBoxCorreo.Text = equiposQ.First().Correo;
                            bTextBoxContra.Text = equiposQ.First().Contra;
                            bMaskedTextBoxTelefono.Text = equiposQ.First().Telefono.ToString();
                            bTextBoxCoordinador.Text = equiposQ.First().Personas.NombreCompleto;
                        }
                        else
                        {
                            aux[1] = "";
                            MessageBox.Show("No se encontro ningun equipo llamado: " + bTextBoxNombre.Text,
                                        "Modificacion Equipos",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FunmPC.limpiarForm(bSplitContainer.Panel1);
                            bTextBoxNombre.Focus();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " " + ex.InnerException.Message);
                }
            }
        }

        private void bTextBoxNombre_Validating(object sender, CancelEventArgs e)
        {
            // Al perder el foco el textbox se busca el equipo y se intenta cargar en el form
            if (bTextBoxNombre.Text != "")
            {
                try
                {
                    using (CSAdminBDEntities db = new CSAdminBDEntities())
                    {
                        ObjectQuery<Equipos> equiposQ =
                            db.Equipos.Where("it.Id = @Id");
                        equiposQ.Parameters.Add(new ObjectParameter("Id", bTextBoxNombre.Text));

                        if (equiposQ.Any())
                        {
                            aux[1] = equiposQ.First().Id;
                            bTextBoxUbicacion.Text = equiposQ.First().Ubicacion;
                            bTextBoxLocalidad.Text = equiposQ.First().Localidades.Localidad;
                            bTextBoxCorreo.Text = equiposQ.First().Correo;
                            bTextBoxContra.Text = equiposQ.First().Contra;
                            bMaskedTextBoxTelefono.Text = equiposQ.First().Telefono.ToString();
                            bTextBoxCoordinador.Text = equiposQ.First().Personas.NombreCompleto;
                        }
                        else
                        {
                            aux[1] = "";
                            MessageBox.Show("No se encontro ningun equipo llamado: " + bTextBoxNombre.Text,
                                        "Baja de Equipos",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FunmPC.limpiarForm(bSplitContainer.Panel1);
                            bTextBoxNombre.Focus();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " " + ex.InnerException.Message);
                }
            }
        }

        private void bDataGridViewEquipos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                using (CSAdminBDEntities db = new CSAdminBDEntities())
                {
                    aux[1] = (string)bDataGridViewEquipos.SelectedRows[0].Cells[0].Value;
                    ObjectQuery<Equipos> equipoQ =
                        db.Equipos.Where("it.Id = @Id");
                    equipoQ.Parameters.Add(new ObjectParameter("Id", aux[1]));

                    bTextBoxNombre.Text = equipoQ.First().Id;
                    bTextBoxUbicacion.Text = equipoQ.First().Ubicacion;
                    bTextBoxLocalidad.Text = equipoQ.First().Localidades.Localidad;
                    bTextBoxCorreo.Text = equipoQ.First().Correo;
                    bTextBoxContra.Text = equipoQ.First().Contra;
                    bMaskedTextBoxTelefono.Text = equipoQ.First().Telefono.ToString();
                    bTextBoxCoordinador.Text = equipoQ.First().Personas.NombreCompleto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException.Message);
            }
        }

#endregion
    }
}
