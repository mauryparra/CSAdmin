namespace CSAdminApp.Pantallas
{
    partial class pAsistencia
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pAsistencia));
            this.tabControlAsistencia = new System.Windows.Forms.TabControl();
            this.tabPageRegistrar = new System.Windows.Forms.TabPage();
            this.splitContainerRegistro = new System.Windows.Forms.SplitContainer();
            this.rButtonCancelar = new System.Windows.Forms.Button();
            this.rButtonRegistrar = new System.Windows.Forms.Button();
            this.rGroupBoxInasistencia = new System.Windows.Forms.GroupBox();
            this.rLabelCaracteres = new System.Windows.Forms.Label();
            this.rTextBoxMotivo = new System.Windows.Forms.TextBox();
            this.rLabelMotivo = new System.Windows.Forms.Label();
            this.rDateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.rLabelHasta = new System.Windows.Forms.Label();
            this.rLabelDesde = new System.Windows.Forms.Label();
            this.rDateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.rGroupBoxPersona = new System.Windows.Forms.GroupBox();
            this.rTextBoxNombre = new System.Windows.Forms.TextBox();
            this.rLabelNombre = new System.Windows.Forms.Label();
            this.rMaskedTextBoxDNI = new System.Windows.Forms.MaskedTextBox();
            this.rLabelDNI = new System.Windows.Forms.Label();
            this.rDataGridViewPersonas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageModificar = new System.Windows.Forms.TabPage();
            this.splitContainerModificar = new System.Windows.Forms.SplitContainer();
            this.mDataGridViewAsistencia = new System.Windows.Forms.DataGridView();
            this.mButtonEliminar = new System.Windows.Forms.Button();
            this.mButtonCancelar = new System.Windows.Forms.Button();
            this.mGroupBoxPersona = new System.Windows.Forms.GroupBox();
            this.mTextBoxNombre = new System.Windows.Forms.TextBox();
            this.mLabelNombre = new System.Windows.Forms.Label();
            this.mMaskedTextBoxDNI = new System.Windows.Forms.MaskedTextBox();
            this.mLabelDNI = new System.Windows.Forms.Label();
            this.mButtonModificar = new System.Windows.Forms.Button();
            this.mGroupBoxInasistencia = new System.Windows.Forms.GroupBox();
            this.mLabelCaracteres = new System.Windows.Forms.Label();
            this.mTextBoxMotivo = new System.Windows.Forms.TextBox();
            this.mLabelMotivo = new System.Windows.Forms.Label();
            this.mDateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.mLabelHasta = new System.Windows.Forms.Label();
            this.mLabelDesde = new System.Windows.Forms.Label();
            this.mDateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.entityDataSource = new EFWinforms.EntityDataSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEntityBindingNavigator = new EFWinforms.EntityBindingNavigator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxCampos = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonFiltrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLimpiar = new System.Windows.Forms.ToolStripButton();
            this.tabControlAsistencia.SuspendLayout();
            this.tabPageRegistrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRegistro)).BeginInit();
            this.splitContainerRegistro.Panel1.SuspendLayout();
            this.splitContainerRegistro.Panel2.SuspendLayout();
            this.splitContainerRegistro.SuspendLayout();
            this.rGroupBoxInasistencia.SuspendLayout();
            this.rGroupBoxPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rDataGridViewPersonas)).BeginInit();
            this.tabPageModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerModificar)).BeginInit();
            this.splitContainerModificar.Panel1.SuspendLayout();
            this.splitContainerModificar.Panel2.SuspendLayout();
            this.splitContainerModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGridViewAsistencia)).BeginInit();
            this.mGroupBoxPersona.SuspendLayout();
            this.mGroupBoxInasistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.mEntityBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAsistencia
            // 
            this.tabControlAsistencia.Controls.Add(this.tabPageRegistrar);
            this.tabControlAsistencia.Controls.Add(this.tabPageModificar);
            this.tabControlAsistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tabControlAsistencia.Location = new System.Drawing.Point(0, 0);
            this.tabControlAsistencia.Name = "tabControlAsistencia";
            this.tabControlAsistencia.SelectedIndex = 0;
            this.tabControlAsistencia.Size = new System.Drawing.Size(689, 446);
            this.tabControlAsistencia.TabIndex = 0;
            // 
            // tabPageRegistrar
            // 
            this.tabPageRegistrar.Controls.Add(this.splitContainerRegistro);
            this.tabPageRegistrar.Location = new System.Drawing.Point(4, 24);
            this.tabPageRegistrar.Name = "tabPageRegistrar";
            this.tabPageRegistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegistrar.Size = new System.Drawing.Size(681, 418);
            this.tabPageRegistrar.TabIndex = 0;
            this.tabPageRegistrar.Text = "Registro";
            this.tabPageRegistrar.UseVisualStyleBackColor = true;
            // 
            // splitContainerRegistro
            // 
            this.splitContainerRegistro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRegistro.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerRegistro.IsSplitterFixed = true;
            this.splitContainerRegistro.Location = new System.Drawing.Point(3, 3);
            this.splitContainerRegistro.Name = "splitContainerRegistro";
            this.splitContainerRegistro.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRegistro.Panel1
            // 
            this.splitContainerRegistro.Panel1.Controls.Add(this.rButtonCancelar);
            this.splitContainerRegistro.Panel1.Controls.Add(this.rButtonRegistrar);
            this.splitContainerRegistro.Panel1.Controls.Add(this.rGroupBoxInasistencia);
            this.splitContainerRegistro.Panel1.Controls.Add(this.rGroupBoxPersona);
            // 
            // splitContainerRegistro.Panel2
            // 
            this.splitContainerRegistro.Panel2.Controls.Add(this.rDataGridViewPersonas);
            this.splitContainerRegistro.Size = new System.Drawing.Size(675, 412);
            this.splitContainerRegistro.SplitterDistance = 220;
            this.splitContainerRegistro.TabIndex = 5;
            // 
            // rButtonCancelar
            // 
            this.rButtonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rButtonCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.rButtonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.rButtonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.rButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rButtonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButtonCancelar.Location = new System.Drawing.Point(566, 182);
            this.rButtonCancelar.Name = "rButtonCancelar";
            this.rButtonCancelar.Size = new System.Drawing.Size(88, 26);
            this.rButtonCancelar.TabIndex = 39;
            this.rButtonCancelar.Text = "&Cancelar";
            this.rButtonCancelar.UseVisualStyleBackColor = true;
            this.rButtonCancelar.Click += new System.EventHandler(this.rButtonCancelar_Click);
            // 
            // rButtonRegistrar
            // 
            this.rButtonRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rButtonRegistrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.rButtonRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.rButtonRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.rButtonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rButtonRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButtonRegistrar.Location = new System.Drawing.Point(472, 182);
            this.rButtonRegistrar.Name = "rButtonRegistrar";
            this.rButtonRegistrar.Size = new System.Drawing.Size(88, 26);
            this.rButtonRegistrar.TabIndex = 38;
            this.rButtonRegistrar.Text = "&Registrar";
            this.rButtonRegistrar.UseVisualStyleBackColor = true;
            this.rButtonRegistrar.Click += new System.EventHandler(this.rButtonRegistrar_Click);
            // 
            // rGroupBoxInasistencia
            // 
            this.rGroupBoxInasistencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rGroupBoxInasistencia.Controls.Add(this.rLabelCaracteres);
            this.rGroupBoxInasistencia.Controls.Add(this.rTextBoxMotivo);
            this.rGroupBoxInasistencia.Controls.Add(this.rLabelMotivo);
            this.rGroupBoxInasistencia.Controls.Add(this.rDateTimePickerHasta);
            this.rGroupBoxInasistencia.Controls.Add(this.rLabelHasta);
            this.rGroupBoxInasistencia.Controls.Add(this.rLabelDesde);
            this.rGroupBoxInasistencia.Controls.Add(this.rDateTimePickerDesde);
            this.rGroupBoxInasistencia.Location = new System.Drawing.Point(3, 78);
            this.rGroupBoxInasistencia.Name = "rGroupBoxInasistencia";
            this.rGroupBoxInasistencia.Size = new System.Drawing.Size(665, 98);
            this.rGroupBoxInasistencia.TabIndex = 6;
            this.rGroupBoxInasistencia.TabStop = false;
            this.rGroupBoxInasistencia.Text = "Inasistencia";
            // 
            // rLabelCaracteres
            // 
            this.rLabelCaracteres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rLabelCaracteres.AutoSize = true;
            this.rLabelCaracteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabelCaracteres.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rLabelCaracteres.Location = new System.Drawing.Point(620, 15);
            this.rLabelCaracteres.Name = "rLabelCaracteres";
            this.rLabelCaracteres.Size = new System.Drawing.Size(31, 15);
            this.rLabelCaracteres.TabIndex = 10;
            this.rLabelCaracteres.Text = "140";
            // 
            // rTextBoxMotivo
            // 
            this.rTextBoxMotivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rTextBoxMotivo.BackColor = System.Drawing.Color.Honeydew;
            this.rTextBoxMotivo.Location = new System.Drawing.Point(358, 33);
            this.rTextBoxMotivo.MaxLength = 140;
            this.rTextBoxMotivo.Multiline = true;
            this.rTextBoxMotivo.Name = "rTextBoxMotivo";
            this.rTextBoxMotivo.Size = new System.Drawing.Size(290, 54);
            this.rTextBoxMotivo.TabIndex = 4;
            this.rTextBoxMotivo.TextChanged += new System.EventHandler(this.rTextBoxMotivo_TextChanged);
            // 
            // rLabelMotivo
            // 
            this.rLabelMotivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rLabelMotivo.AutoSize = true;
            this.rLabelMotivo.Location = new System.Drawing.Point(306, 30);
            this.rLabelMotivo.Name = "rLabelMotivo";
            this.rLabelMotivo.Size = new System.Drawing.Size(46, 15);
            this.rLabelMotivo.TabIndex = 8;
            this.rLabelMotivo.Text = "Motivo:";
            // 
            // rDateTimePickerHasta
            // 
            this.rDateTimePickerHasta.Checked = false;
            this.errorProvider.SetError(this.rDateTimePickerHasta, "La fecha debe ser igual o mayor a la fecha de inicio.");
            this.rDateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.errorProvider.SetIconPadding(this.rDateTimePickerHasta, 10);
            this.rDateTimePickerHasta.Location = new System.Drawing.Point(101, 61);
            this.rDateTimePickerHasta.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.rDateTimePickerHasta.Name = "rDateTimePickerHasta";
            this.rDateTimePickerHasta.ShowCheckBox = true;
            this.rDateTimePickerHasta.Size = new System.Drawing.Size(99, 21);
            this.rDateTimePickerHasta.TabIndex = 3;
            // 
            // rLabelHasta
            // 
            this.rLabelHasta.AutoSize = true;
            this.rLabelHasta.Location = new System.Drawing.Point(34, 66);
            this.rLabelHasta.Name = "rLabelHasta";
            this.rLabelHasta.Size = new System.Drawing.Size(42, 15);
            this.rLabelHasta.TabIndex = 2;
            this.rLabelHasta.Text = "Hasta:";
            // 
            // rLabelDesde
            // 
            this.rLabelDesde.AutoSize = true;
            this.rLabelDesde.Location = new System.Drawing.Point(34, 30);
            this.rLabelDesde.Name = "rLabelDesde";
            this.rLabelDesde.Size = new System.Drawing.Size(46, 15);
            this.rLabelDesde.TabIndex = 0;
            this.rLabelDesde.Text = "Desde:";
            // 
            // rDateTimePickerDesde
            // 
            this.errorProvider.SetError(this.rDateTimePickerDesde, "La fecha debe ser menor o igual a la fecha de finalización");
            this.rDateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.errorProvider.SetIconPadding(this.rDateTimePickerDesde, 10);
            this.rDateTimePickerDesde.Location = new System.Drawing.Point(101, 25);
            this.rDateTimePickerDesde.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.rDateTimePickerDesde.Name = "rDateTimePickerDesde";
            this.rDateTimePickerDesde.Size = new System.Drawing.Size(99, 21);
            this.rDateTimePickerDesde.TabIndex = 1;
            // 
            // rGroupBoxPersona
            // 
            this.rGroupBoxPersona.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rGroupBoxPersona.Controls.Add(this.rTextBoxNombre);
            this.rGroupBoxPersona.Controls.Add(this.rLabelNombre);
            this.rGroupBoxPersona.Controls.Add(this.rMaskedTextBoxDNI);
            this.rGroupBoxPersona.Controls.Add(this.rLabelDNI);
            this.rGroupBoxPersona.Location = new System.Drawing.Point(3, 3);
            this.rGroupBoxPersona.Name = "rGroupBoxPersona";
            this.rGroupBoxPersona.Size = new System.Drawing.Size(665, 69);
            this.rGroupBoxPersona.TabIndex = 5;
            this.rGroupBoxPersona.TabStop = false;
            this.rGroupBoxPersona.Text = "Persona";
            // 
            // rTextBoxNombre
            // 
            this.rTextBoxNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.rTextBoxNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.rTextBoxNombre.BackColor = System.Drawing.Color.MistyRose;
            this.rTextBoxNombre.Location = new System.Drawing.Point(156, 27);
            this.rTextBoxNombre.Name = "rTextBoxNombre";
            this.rTextBoxNombre.Size = new System.Drawing.Size(220, 21);
            this.rTextBoxNombre.TabIndex = 1;
            this.rTextBoxNombre.Validated += new System.EventHandler(this.rTextBoxNombre_Validated);
            // 
            // rLabelNombre
            // 
            this.rLabelNombre.AutoSize = true;
            this.rLabelNombre.Location = new System.Drawing.Point(34, 30);
            this.rLabelNombre.Name = "rLabelNombre";
            this.rLabelNombre.Size = new System.Drawing.Size(116, 15);
            this.rLabelNombre.TabIndex = 0;
            this.rLabelNombre.Text = "Nombres y Apellido:";
            // 
            // rMaskedTextBoxDNI
            // 
            this.rMaskedTextBoxDNI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rMaskedTextBoxDNI.BackColor = System.Drawing.Color.MistyRose;
            this.rMaskedTextBoxDNI.Location = new System.Drawing.Point(474, 27);
            this.rMaskedTextBoxDNI.Mask = "99.999.999";
            this.rMaskedTextBoxDNI.Name = "rMaskedTextBoxDNI";
            this.rMaskedTextBoxDNI.PromptChar = ' ';
            this.rMaskedTextBoxDNI.Size = new System.Drawing.Size(124, 21);
            this.rMaskedTextBoxDNI.TabIndex = 3;
            this.rMaskedTextBoxDNI.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.rMaskedTextBoxDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rMaskedTextBoxDNI_KeyPress);
            // 
            // rLabelDNI
            // 
            this.rLabelDNI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rLabelDNI.AutoSize = true;
            this.rLabelDNI.Location = new System.Drawing.Point(437, 30);
            this.rLabelDNI.Name = "rLabelDNI";
            this.rLabelDNI.Size = new System.Drawing.Size(31, 15);
            this.rLabelDNI.TabIndex = 2;
            this.rLabelDNI.Text = "DNI:";
            // 
            // rDataGridViewPersonas
            // 
            this.rDataGridViewPersonas.AllowUserToAddRows = false;
            this.rDataGridViewPersonas.AllowUserToDeleteRows = false;
            this.rDataGridViewPersonas.AutoGenerateColumns = false;
            this.rDataGridViewPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rDataGridViewPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido});
            this.rDataGridViewPersonas.DataSource = this.entityDataSource;
            this.rDataGridViewPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rDataGridViewPersonas.Location = new System.Drawing.Point(0, 0);
            this.rDataGridViewPersonas.Name = "rDataGridViewPersonas";
            this.rDataGridViewPersonas.ReadOnly = true;
            this.rDataGridViewPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rDataGridViewPersonas.Size = new System.Drawing.Size(671, 184);
            this.rDataGridViewPersonas.TabIndex = 0;
            this.rDataGridViewPersonas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.rDataGridViewPersonas_CellMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // tabPageModificar
            // 
            this.tabPageModificar.Controls.Add(this.splitContainerModificar);
            this.tabPageModificar.Location = new System.Drawing.Point(4, 24);
            this.tabPageModificar.Name = "tabPageModificar";
            this.tabPageModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageModificar.Size = new System.Drawing.Size(681, 418);
            this.tabPageModificar.TabIndex = 1;
            this.tabPageModificar.Text = "Modificación";
            this.tabPageModificar.UseVisualStyleBackColor = true;
            // 
            // splitContainerModificar
            // 
            this.splitContainerModificar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerModificar.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerModificar.IsSplitterFixed = true;
            this.splitContainerModificar.Location = new System.Drawing.Point(3, 3);
            this.splitContainerModificar.Name = "splitContainerModificar";
            this.splitContainerModificar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerModificar.Panel1
            // 
            this.splitContainerModificar.Panel1.Controls.Add(this.mDataGridViewAsistencia);
            this.splitContainerModificar.Panel1.Controls.Add(this.mEntityBindingNavigator);
            // 
            // splitContainerModificar.Panel2
            // 
            this.splitContainerModificar.Panel2.Controls.Add(this.mButtonEliminar);
            this.splitContainerModificar.Panel2.Controls.Add(this.mButtonCancelar);
            this.splitContainerModificar.Panel2.Controls.Add(this.mGroupBoxPersona);
            this.splitContainerModificar.Panel2.Controls.Add(this.mButtonModificar);
            this.splitContainerModificar.Panel2.Controls.Add(this.mGroupBoxInasistencia);
            this.splitContainerModificar.Size = new System.Drawing.Size(675, 412);
            this.splitContainerModificar.SplitterDistance = 195;
            this.splitContainerModificar.TabIndex = 6;
            // 
            // mDataGridViewAsistencia
            // 
            this.mDataGridViewAsistencia.AllowUserToAddRows = false;
            this.mDataGridViewAsistencia.AllowUserToDeleteRows = false;
            this.mDataGridViewAsistencia.AllowUserToOrderColumns = true;
            this.mDataGridViewAsistencia.AutoGenerateColumns = false;
            this.mDataGridViewAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mDataGridViewAsistencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.personasDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.mDataGridViewAsistencia.DataMember = "Inasistencias";
            this.mDataGridViewAsistencia.DataSource = this.entityDataSource;
            this.mDataGridViewAsistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDataGridViewAsistencia.Location = new System.Drawing.Point(0, 25);
            this.mDataGridViewAsistencia.Name = "mDataGridViewAsistencia";
            this.mDataGridViewAsistencia.ReadOnly = true;
            this.mDataGridViewAsistencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mDataGridViewAsistencia.Size = new System.Drawing.Size(671, 166);
            this.mDataGridViewAsistencia.TabIndex = 4;
            this.mDataGridViewAsistencia.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mDataGridViewAsistencia_CellMouseDoubleClick);
            // 
            // mButtonEliminar
            // 
            this.mButtonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mButtonEliminar.Enabled = false;
            this.mButtonEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.mButtonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.mButtonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.mButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mButtonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mButtonEliminar.Location = new System.Drawing.Point(40, 180);
            this.mButtonEliminar.Name = "mButtonEliminar";
            this.mButtonEliminar.Size = new System.Drawing.Size(88, 26);
            this.mButtonEliminar.TabIndex = 40;
            this.mButtonEliminar.Text = "&Eliminar";
            this.mButtonEliminar.UseVisualStyleBackColor = true;
            this.mButtonEliminar.Click += new System.EventHandler(this.mButtonEliminar_Click);
            // 
            // mButtonCancelar
            // 
            this.mButtonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mButtonCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.mButtonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.mButtonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.mButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mButtonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mButtonCancelar.Location = new System.Drawing.Point(563, 180);
            this.mButtonCancelar.Name = "mButtonCancelar";
            this.mButtonCancelar.Size = new System.Drawing.Size(88, 26);
            this.mButtonCancelar.TabIndex = 39;
            this.mButtonCancelar.Text = "&Cancelar";
            this.mButtonCancelar.UseVisualStyleBackColor = true;
            this.mButtonCancelar.Click += new System.EventHandler(this.mButtonCancelar_Click);
            // 
            // mGroupBoxPersona
            // 
            this.mGroupBoxPersona.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mGroupBoxPersona.Controls.Add(this.mTextBoxNombre);
            this.mGroupBoxPersona.Controls.Add(this.mLabelNombre);
            this.mGroupBoxPersona.Controls.Add(this.mMaskedTextBoxDNI);
            this.mGroupBoxPersona.Controls.Add(this.mLabelDNI);
            this.mGroupBoxPersona.Location = new System.Drawing.Point(3, 3);
            this.mGroupBoxPersona.Name = "mGroupBoxPersona";
            this.mGroupBoxPersona.Size = new System.Drawing.Size(665, 69);
            this.mGroupBoxPersona.TabIndex = 5;
            this.mGroupBoxPersona.TabStop = false;
            this.mGroupBoxPersona.Text = "Persona";
            // 
            // mTextBoxNombre
            // 
            this.mTextBoxNombre.BackColor = System.Drawing.SystemColors.Control;
            this.mTextBoxNombre.Location = new System.Drawing.Point(156, 27);
            this.mTextBoxNombre.Name = "mTextBoxNombre";
            this.mTextBoxNombre.ReadOnly = true;
            this.mTextBoxNombre.Size = new System.Drawing.Size(220, 21);
            this.mTextBoxNombre.TabIndex = 1;
            // 
            // mLabelNombre
            // 
            this.mLabelNombre.AutoSize = true;
            this.mLabelNombre.Location = new System.Drawing.Point(34, 30);
            this.mLabelNombre.Name = "mLabelNombre";
            this.mLabelNombre.Size = new System.Drawing.Size(116, 15);
            this.mLabelNombre.TabIndex = 0;
            this.mLabelNombre.Text = "Nombres y Apellido:";
            // 
            // mMaskedTextBoxDNI
            // 
            this.mMaskedTextBoxDNI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mMaskedTextBoxDNI.BackColor = System.Drawing.SystemColors.Control;
            this.mMaskedTextBoxDNI.Location = new System.Drawing.Point(474, 27);
            this.mMaskedTextBoxDNI.Mask = "99.999.999";
            this.mMaskedTextBoxDNI.Name = "mMaskedTextBoxDNI";
            this.mMaskedTextBoxDNI.PromptChar = ' ';
            this.mMaskedTextBoxDNI.ReadOnly = true;
            this.mMaskedTextBoxDNI.Size = new System.Drawing.Size(124, 21);
            this.mMaskedTextBoxDNI.TabIndex = 3;
            this.mMaskedTextBoxDNI.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mLabelDNI
            // 
            this.mLabelDNI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelDNI.AutoSize = true;
            this.mLabelDNI.Location = new System.Drawing.Point(437, 30);
            this.mLabelDNI.Name = "mLabelDNI";
            this.mLabelDNI.Size = new System.Drawing.Size(31, 15);
            this.mLabelDNI.TabIndex = 2;
            this.mLabelDNI.Text = "DNI:";
            // 
            // mButtonModificar
            // 
            this.mButtonModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mButtonModificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.mButtonModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.mButtonModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.mButtonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mButtonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mButtonModificar.Location = new System.Drawing.Point(469, 180);
            this.mButtonModificar.Name = "mButtonModificar";
            this.mButtonModificar.Size = new System.Drawing.Size(88, 26);
            this.mButtonModificar.TabIndex = 38;
            this.mButtonModificar.Text = "&Modificar";
            this.mButtonModificar.UseVisualStyleBackColor = true;
            this.mButtonModificar.Click += new System.EventHandler(this.mButtonModificar_Click);
            // 
            // mGroupBoxInasistencia
            // 
            this.mGroupBoxInasistencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mGroupBoxInasistencia.Controls.Add(this.mLabelCaracteres);
            this.mGroupBoxInasistencia.Controls.Add(this.mTextBoxMotivo);
            this.mGroupBoxInasistencia.Controls.Add(this.mLabelMotivo);
            this.mGroupBoxInasistencia.Controls.Add(this.mDateTimePickerHasta);
            this.mGroupBoxInasistencia.Controls.Add(this.mLabelHasta);
            this.mGroupBoxInasistencia.Controls.Add(this.mLabelDesde);
            this.mGroupBoxInasistencia.Controls.Add(this.mDateTimePickerDesde);
            this.mGroupBoxInasistencia.Location = new System.Drawing.Point(3, 78);
            this.mGroupBoxInasistencia.Name = "mGroupBoxInasistencia";
            this.mGroupBoxInasistencia.Size = new System.Drawing.Size(665, 98);
            this.mGroupBoxInasistencia.TabIndex = 6;
            this.mGroupBoxInasistencia.TabStop = false;
            this.mGroupBoxInasistencia.Text = "Inasistencia";
            // 
            // mLabelCaracteres
            // 
            this.mLabelCaracteres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelCaracteres.AutoSize = true;
            this.mLabelCaracteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabelCaracteres.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mLabelCaracteres.Location = new System.Drawing.Point(620, 15);
            this.mLabelCaracteres.Name = "mLabelCaracteres";
            this.mLabelCaracteres.Size = new System.Drawing.Size(31, 15);
            this.mLabelCaracteres.TabIndex = 10;
            this.mLabelCaracteres.Text = "140";
            // 
            // mTextBoxMotivo
            // 
            this.mTextBoxMotivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mTextBoxMotivo.BackColor = System.Drawing.Color.Honeydew;
            this.mTextBoxMotivo.Location = new System.Drawing.Point(358, 33);
            this.mTextBoxMotivo.MaxLength = 140;
            this.mTextBoxMotivo.Multiline = true;
            this.mTextBoxMotivo.Name = "mTextBoxMotivo";
            this.mTextBoxMotivo.Size = new System.Drawing.Size(290, 54);
            this.mTextBoxMotivo.TabIndex = 4;
            this.mTextBoxMotivo.TextChanged += new System.EventHandler(this.mTextBoxMotivo_TextChanged);
            // 
            // mLabelMotivo
            // 
            this.mLabelMotivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelMotivo.AutoSize = true;
            this.mLabelMotivo.Location = new System.Drawing.Point(306, 30);
            this.mLabelMotivo.Name = "mLabelMotivo";
            this.mLabelMotivo.Size = new System.Drawing.Size(46, 15);
            this.mLabelMotivo.TabIndex = 8;
            this.mLabelMotivo.Text = "Motivo:";
            // 
            // mDateTimePickerHasta
            // 
            this.mDateTimePickerHasta.Checked = false;
            this.errorProvider.SetError(this.mDateTimePickerHasta, "La fecha debe ser igual o mayor a la fecha de inicio.");
            this.mDateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.errorProvider.SetIconPadding(this.mDateTimePickerHasta, 10);
            this.mDateTimePickerHasta.Location = new System.Drawing.Point(101, 61);
            this.mDateTimePickerHasta.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.mDateTimePickerHasta.Name = "mDateTimePickerHasta";
            this.mDateTimePickerHasta.ShowCheckBox = true;
            this.mDateTimePickerHasta.Size = new System.Drawing.Size(99, 21);
            this.mDateTimePickerHasta.TabIndex = 3;
            this.mDateTimePickerHasta.Validating += new System.ComponentModel.CancelEventHandler(this.mDateTimePickerHasta_Validating);
            // 
            // mLabelHasta
            // 
            this.mLabelHasta.AutoSize = true;
            this.mLabelHasta.Location = new System.Drawing.Point(34, 66);
            this.mLabelHasta.Name = "mLabelHasta";
            this.mLabelHasta.Size = new System.Drawing.Size(42, 15);
            this.mLabelHasta.TabIndex = 2;
            this.mLabelHasta.Text = "Hasta:";
            // 
            // mLabelDesde
            // 
            this.mLabelDesde.AutoSize = true;
            this.mLabelDesde.Location = new System.Drawing.Point(34, 30);
            this.mLabelDesde.Name = "mLabelDesde";
            this.mLabelDesde.Size = new System.Drawing.Size(46, 15);
            this.mLabelDesde.TabIndex = 0;
            this.mLabelDesde.Text = "Desde:";
            // 
            // mDateTimePickerDesde
            // 
            this.errorProvider.SetError(this.mDateTimePickerDesde, "La fecha debe ser menor o igual a la fecha de finalización");
            this.mDateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.errorProvider.SetIconPadding(this.mDateTimePickerDesde, 10);
            this.mDateTimePickerDesde.Location = new System.Drawing.Point(101, 25);
            this.mDateTimePickerDesde.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.mDateTimePickerDesde.Name = "mDateTimePickerDesde";
            this.mDateTimePickerDesde.Size = new System.Drawing.Size(99, 21);
            this.mDateTimePickerDesde.TabIndex = 1;
            this.mDateTimePickerDesde.Validating += new System.ComponentModel.CancelEventHandler(this.mDateTimePickerDesde_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // entityDataSource
            // 
            this.entityDataSource.DbContextType = typeof(CSAdminApp.Clases.CSAdminBDEntities);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdPersona";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdPersona";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // personasDataGridViewTextBoxColumn
            // 
            this.personasDataGridViewTextBoxColumn.DataPropertyName = "Personas";
            this.personasDataGridViewTextBoxColumn.HeaderText = "Personas";
            this.personasDataGridViewTextBoxColumn.Name = "personasDataGridViewTextBoxColumn";
            this.personasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Desde";
            this.dataGridViewTextBoxColumn3.HeaderText = "Desde";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Hasta";
            this.dataGridViewTextBoxColumn4.HeaderText = "Hasta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Motivo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Motivo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // mEntityBindingNavigator
            // 
            this.mEntityBindingNavigator.DataMember = "Inasistencias";
            this.mEntityBindingNavigator.DataSource = this.entityDataSource;
            this.mEntityBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mEntityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBoxFiltro,
            this.toolStripLabel2,
            this.toolStripComboBoxCampos,
            this.toolStripButtonFiltrar,
            this.toolStripButtonLimpiar});
            this.mEntityBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mEntityBindingNavigator.Name = "mEntityBindingNavigator";
            this.mEntityBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mEntityBindingNavigator.ShowAddRemoveButtons = false;
            this.mEntityBindingNavigator.ShowNavigationButtons = false;
            this.mEntityBindingNavigator.ShowSaveUndoRefreshButtons = false;
            this.mEntityBindingNavigator.Size = new System.Drawing.Size(671, 25);
            this.mEntityBindingNavigator.TabIndex = 3;
            this.mEntityBindingNavigator.Text = "entityBindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel1.Text = "Filtrar:";
            // 
            // toolStripTextBoxFiltro
            // 
            this.toolStripTextBoxFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.toolStripTextBoxFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.toolStripTextBoxFiltro.BackColor = System.Drawing.Color.MistyRose;
            this.toolStripTextBoxFiltro.Name = "toolStripTextBoxFiltro";
            this.toolStripTextBoxFiltro.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel2.Text = "en";
            // 
            // toolStripComboBoxCampos
            // 
            this.toolStripComboBoxCampos.BackColor = System.Drawing.Color.MistyRose;
            this.toolStripComboBoxCampos.Items.AddRange(new object[] {
            "Nombre",
            "DNI"});
            this.toolStripComboBoxCampos.Name = "toolStripComboBoxCampos";
            this.toolStripComboBoxCampos.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBoxCampos.Text = "Nombre";
            // 
            // toolStripButtonFiltrar
            // 
            this.toolStripButtonFiltrar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.toolStripButtonFiltrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFiltrar.Image")));
            this.toolStripButtonFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFiltrar.Margin = new System.Windows.Forms.Padding(0, 1, 2, 2);
            this.toolStripButtonFiltrar.Name = "toolStripButtonFiltrar";
            this.toolStripButtonFiltrar.Size = new System.Drawing.Size(41, 22);
            this.toolStripButtonFiltrar.Text = "Filtrar";
            this.toolStripButtonFiltrar.Click += new System.EventHandler(this.toolStripButtonFiltrar_Click);
            // 
            // toolStripButtonLimpiar
            // 
            this.toolStripButtonLimpiar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.toolStripButtonLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLimpiar.Image")));
            this.toolStripButtonLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLimpiar.Margin = new System.Windows.Forms.Padding(2, 1, 0, 2);
            this.toolStripButtonLimpiar.Name = "toolStripButtonLimpiar";
            this.toolStripButtonLimpiar.Size = new System.Drawing.Size(51, 22);
            this.toolStripButtonLimpiar.Text = "Limpiar";
            this.toolStripButtonLimpiar.Click += new System.EventHandler(this.toolStripButtonLimpiar_Click);
            // 
            // pAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlAsistencia);
            this.Name = "pAsistencia";
            this.Size = new System.Drawing.Size(689, 446);
            this.Load += new System.EventHandler(this.pAsistencia_Load);
            this.tabControlAsistencia.ResumeLayout(false);
            this.tabPageRegistrar.ResumeLayout(false);
            this.splitContainerRegistro.Panel1.ResumeLayout(false);
            this.splitContainerRegistro.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRegistro)).EndInit();
            this.splitContainerRegistro.ResumeLayout(false);
            this.rGroupBoxInasistencia.ResumeLayout(false);
            this.rGroupBoxInasistencia.PerformLayout();
            this.rGroupBoxPersona.ResumeLayout(false);
            this.rGroupBoxPersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rDataGridViewPersonas)).EndInit();
            this.tabPageModificar.ResumeLayout(false);
            this.splitContainerModificar.Panel1.ResumeLayout(false);
            this.splitContainerModificar.Panel1.PerformLayout();
            this.splitContainerModificar.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerModificar)).EndInit();
            this.splitContainerModificar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mDataGridViewAsistencia)).EndInit();
            this.mGroupBoxPersona.ResumeLayout(false);
            this.mGroupBoxPersona.PerformLayout();
            this.mGroupBoxInasistencia.ResumeLayout(false);
            this.mGroupBoxInasistencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.mEntityBindingNavigator.ResumeLayout(false);
            this.mEntityBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAsistencia;
        private System.Windows.Forms.TabPage tabPageRegistrar;
        private System.Windows.Forms.TabPage tabPageModificar;
        private System.Windows.Forms.SplitContainer splitContainerRegistro;
        private System.Windows.Forms.GroupBox rGroupBoxInasistencia;
        private System.Windows.Forms.Label rLabelCaracteres;
        private System.Windows.Forms.TextBox rTextBoxMotivo;
        private System.Windows.Forms.Label rLabelMotivo;
        private System.Windows.Forms.DateTimePicker rDateTimePickerHasta;
        private System.Windows.Forms.Label rLabelHasta;
        private System.Windows.Forms.Label rLabelDesde;
        private System.Windows.Forms.DateTimePicker rDateTimePickerDesde;
        private System.Windows.Forms.GroupBox rGroupBoxPersona;
        private System.Windows.Forms.TextBox rTextBoxNombre;
        private System.Windows.Forms.Label rLabelNombre;
        private System.Windows.Forms.MaskedTextBox rMaskedTextBoxDNI;
        private System.Windows.Forms.Label rLabelDNI;
        internal System.Windows.Forms.Button rButtonCancelar;
        internal System.Windows.Forms.Button rButtonRegistrar;
        private System.Windows.Forms.DataGridView rDataGridViewPersonas;
        private EFWinforms.EntityDataSource entityDataSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.SplitContainer splitContainerModificar;
        internal System.Windows.Forms.Button mButtonCancelar;
        internal System.Windows.Forms.Button mButtonModificar;
        private System.Windows.Forms.GroupBox mGroupBoxInasistencia;
        private System.Windows.Forms.Label mLabelCaracteres;
        private System.Windows.Forms.TextBox mTextBoxMotivo;
        private System.Windows.Forms.Label mLabelMotivo;
        private System.Windows.Forms.DateTimePicker mDateTimePickerHasta;
        private System.Windows.Forms.Label mLabelHasta;
        private System.Windows.Forms.Label mLabelDesde;
        private System.Windows.Forms.DateTimePicker mDateTimePickerDesde;
        private System.Windows.Forms.GroupBox mGroupBoxPersona;
        private System.Windows.Forms.TextBox mTextBoxNombre;
        private System.Windows.Forms.Label mLabelNombre;
        private System.Windows.Forms.MaskedTextBox mMaskedTextBoxDNI;
        private System.Windows.Forms.Label mLabelDNI;
        private EFWinforms.EntityBindingNavigator mEntityBindingNavigator;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFiltro;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxCampos;
        private System.Windows.Forms.ToolStripButton toolStripButtonFiltrar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolStripButton toolStripButtonLimpiar;
        internal System.Windows.Forms.Button mButtonEliminar;
        private System.Windows.Forms.DataGridView mDataGridViewAsistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn personasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
