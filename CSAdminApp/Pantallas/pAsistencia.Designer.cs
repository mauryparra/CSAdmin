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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlAsistencia = new System.Windows.Forms.TabControl();
            this.tabPageRegistrar = new System.Windows.Forms.TabPage();
            this.splitContainerRegistro = new System.Windows.Forms.SplitContainer();
            this.rGroupBoxInasistencia = new System.Windows.Forms.GroupBox();
            this.rLabelCaracteres = new System.Windows.Forms.Label();
            this.rTextBoxMotivo = new System.Windows.Forms.TextBox();
            this.rLabelMotivo = new System.Windows.Forms.Label();
            this.rDateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.rLabelHasta = new System.Windows.Forms.Label();
            this.rLabelDesde = new System.Windows.Forms.Label();
            this.rDateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rGroupBoxPersona = new System.Windows.Forms.GroupBox();
            this.rTextBoxNombre = new System.Windows.Forms.TextBox();
            this.rLabelNombre = new System.Windows.Forms.Label();
            this.rMaskedTextBoxDNI = new System.Windows.Forms.MaskedTextBox();
            this.rLabelDNI = new System.Windows.Forms.Label();
            this.tabPageModificar = new System.Windows.Forms.TabPage();
            this.rButtonCancelar = new System.Windows.Forms.Button();
            this.rButtonRegistrar = new System.Windows.Forms.Button();
            this.rDataGridViewPersonas = new System.Windows.Forms.DataGridView();
            this.entityDataSource = new EFWinforms.EntityDataSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bajaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControlAsistencia.SuspendLayout();
            this.tabPageRegistrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRegistro)).BeginInit();
            this.splitContainerRegistro.Panel1.SuspendLayout();
            this.splitContainerRegistro.Panel2.SuspendLayout();
            this.splitContainerRegistro.SuspendLayout();
            this.rGroupBoxInasistencia.SuspendLayout();
            this.rGroupBoxPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rDataGridViewPersonas)).BeginInit();
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
            this.rGroupBoxInasistencia.Controls.Add(this.shapeContainer1);
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
            this.rDateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
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
            this.rDateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rDateTimePickerDesde.Location = new System.Drawing.Point(101, 25);
            this.rDateTimePickerDesde.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.rDateTimePickerDesde.Name = "rDateTimePickerDesde";
            this.rDateTimePickerDesde.Size = new System.Drawing.Size(99, 21);
            this.rDateTimePickerDesde.TabIndex = 1;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 17);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(659, 78);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.Color.Transparent;
            this.rectangleShape2.BorderColor = System.Drawing.Color.Aquamarine;
            this.rectangleShape2.BorderWidth = 3;
            this.rectangleShape2.Location = new System.Drawing.Point(96, 42);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(102, 24);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.BorderColor = System.Drawing.Color.MistyRose;
            this.rectangleShape1.BorderWidth = 3;
            this.rectangleShape1.Location = new System.Drawing.Point(96, 6);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(102, 24);
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
            this.rTextBoxNombre.BackColor = System.Drawing.Color.MistyRose;
            this.rTextBoxNombre.Location = new System.Drawing.Point(156, 27);
            this.rTextBoxNombre.Name = "rTextBoxNombre";
            this.rTextBoxNombre.Size = new System.Drawing.Size(220, 21);
            this.rTextBoxNombre.TabIndex = 1;
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
            // tabPageModificar
            // 
            this.tabPageModificar.Location = new System.Drawing.Point(4, 24);
            this.tabPageModificar.Name = "tabPageModificar";
            this.tabPageModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageModificar.Size = new System.Drawing.Size(681, 418);
            this.tabPageModificar.TabIndex = 1;
            this.tabPageModificar.Text = "Modificación";
            this.tabPageModificar.UseVisualStyleBackColor = true;
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
            // rDataGridViewPersonas
            // 
            this.rDataGridViewPersonas.AllowUserToAddRows = false;
            this.rDataGridViewPersonas.AllowUserToDeleteRows = false;
            this.rDataGridViewPersonas.AutoGenerateColumns = false;
            this.rDataGridViewPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rDataGridViewPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.dniDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.bajaDataGridViewCheckBoxColumn});
            this.rDataGridViewPersonas.DataMember = "Personas";
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
            // entityDataSource
            // 
            this.entityDataSource.ObjectContextType = typeof(CSAdminApp.Clases.CSAdminBDEntities);
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
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            dataGridViewCellStyle1.NullValue = null;
            this.dniDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            this.dniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bajaDataGridViewCheckBoxColumn
            // 
            this.bajaDataGridViewCheckBoxColumn.DataPropertyName = "Baja";
            this.bajaDataGridViewCheckBoxColumn.HeaderText = "Baja";
            this.bajaDataGridViewCheckBoxColumn.Name = "bajaDataGridViewCheckBoxColumn";
            this.bajaDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // pAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlAsistencia);
            this.Name = "pAsistencia";
            this.Size = new System.Drawing.Size(689, 446);
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
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bajaDataGridViewCheckBoxColumn;
    }
}
