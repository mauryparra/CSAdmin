namespace CSAdminApp.Pantallas
{
    partial class pPersonal
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
            this.tabControlPersonal = new System.Windows.Forms.TabControl();
            this.tabPageAlta = new System.Windows.Forms.TabPage();
            this.aSplitContainer = new System.Windows.Forms.SplitContainer();
            this.aButtonReactivar = new System.Windows.Forms.Button();
            this.aButtonCancelar = new System.Windows.Forms.Button();
            this.aButtonAceptar = new System.Windows.Forms.Button();
            this.aButtonTelefonos = new System.Windows.Forms.Button();
            this.aTextBoxCorreo = new System.Windows.Forms.TextBox();
            this.aTextBoxDireccion = new System.Windows.Forms.TextBox();
            this.aTextBoxApellido = new System.Windows.Forms.TextBox();
            this.aTextBoxNombre = new System.Windows.Forms.TextBox();
            this.aMaskedTextBoxCuit = new System.Windows.Forms.MaskedTextBox();
            this.aMaskedTextBoxDni = new System.Windows.Forms.MaskedTextBox();
            this.aLabelCorreo = new System.Windows.Forms.Label();
            this.aLabelDireccion = new System.Windows.Forms.Label();
            this.aLabelApellido = new System.Windows.Forms.Label();
            this.aLabelNombre = new System.Windows.Forms.Label();
            this.aLabelCuit = new System.Windows.Forms.Label();
            this.aLabelDni = new System.Windows.Forms.Label();
            this.aDataGridViewPer = new System.Windows.Forms.DataGridView();
            this.tabPageModificar = new System.Windows.Forms.TabPage();
            this.tabPageBaja = new System.Windows.Forms.TabPage();
            this.tabControlPersonal.SuspendLayout();
            this.tabPageAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer)).BeginInit();
            this.aSplitContainer.Panel1.SuspendLayout();
            this.aSplitContainer.Panel2.SuspendLayout();
            this.aSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridViewPer)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPersonal
            // 
            this.tabControlPersonal.Controls.Add(this.tabPageAlta);
            this.tabControlPersonal.Controls.Add(this.tabPageModificar);
            this.tabControlPersonal.Controls.Add(this.tabPageBaja);
            this.tabControlPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tabControlPersonal.Location = new System.Drawing.Point(0, 0);
            this.tabControlPersonal.Name = "tabControlPersonal";
            this.tabControlPersonal.SelectedIndex = 0;
            this.tabControlPersonal.Size = new System.Drawing.Size(689, 446);
            this.tabControlPersonal.TabIndex = 0;
            this.tabControlPersonal.SelectedIndexChanged += new System.EventHandler(this.tabControlPersonal_SelectedIndexChanged);
            // 
            // tabPageAlta
            // 
            this.tabPageAlta.Controls.Add(this.aSplitContainer);
            this.tabPageAlta.Location = new System.Drawing.Point(4, 24);
            this.tabPageAlta.Name = "tabPageAlta";
            this.tabPageAlta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlta.Size = new System.Drawing.Size(681, 418);
            this.tabPageAlta.TabIndex = 0;
            this.tabPageAlta.Text = "Alta";
            this.tabPageAlta.UseVisualStyleBackColor = true;
            // 
            // aSplitContainer
            // 
            this.aSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.aSplitContainer.IsSplitterFixed = true;
            this.aSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.aSplitContainer.Name = "aSplitContainer";
            this.aSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // aSplitContainer.Panel1
            // 
            this.aSplitContainer.Panel1.Controls.Add(this.aButtonReactivar);
            this.aSplitContainer.Panel1.Controls.Add(this.aButtonCancelar);
            this.aSplitContainer.Panel1.Controls.Add(this.aButtonAceptar);
            this.aSplitContainer.Panel1.Controls.Add(this.aButtonTelefonos);
            this.aSplitContainer.Panel1.Controls.Add(this.aTextBoxCorreo);
            this.aSplitContainer.Panel1.Controls.Add(this.aTextBoxDireccion);
            this.aSplitContainer.Panel1.Controls.Add(this.aTextBoxApellido);
            this.aSplitContainer.Panel1.Controls.Add(this.aTextBoxNombre);
            this.aSplitContainer.Panel1.Controls.Add(this.aMaskedTextBoxCuit);
            this.aSplitContainer.Panel1.Controls.Add(this.aMaskedTextBoxDni);
            this.aSplitContainer.Panel1.Controls.Add(this.aLabelCorreo);
            this.aSplitContainer.Panel1.Controls.Add(this.aLabelDireccion);
            this.aSplitContainer.Panel1.Controls.Add(this.aLabelApellido);
            this.aSplitContainer.Panel1.Controls.Add(this.aLabelNombre);
            this.aSplitContainer.Panel1.Controls.Add(this.aLabelCuit);
            this.aSplitContainer.Panel1.Controls.Add(this.aLabelDni);
            // 
            // aSplitContainer.Panel2
            // 
            this.aSplitContainer.Panel2.Controls.Add(this.aDataGridViewPer);
            this.aSplitContainer.Size = new System.Drawing.Size(675, 412);
            this.aSplitContainer.SplitterDistance = 140;
            this.aSplitContainer.TabIndex = 0;
            // 
            // aButtonReactivar
            // 
            this.aButtonReactivar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aButtonReactivar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.aButtonReactivar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.aButtonReactivar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.aButtonReactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButtonReactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aButtonReactivar.Location = new System.Drawing.Point(383, 102);
            this.aButtonReactivar.Name = "aButtonReactivar";
            this.aButtonReactivar.Size = new System.Drawing.Size(99, 26);
            this.aButtonReactivar.TabIndex = 31;
            this.aButtonReactivar.Text = "Reactivar";
            this.aButtonReactivar.UseVisualStyleBackColor = true;
            this.aButtonReactivar.Click += new System.EventHandler(this.aButtonReactivar_Click);
            // 
            // aButtonCancelar
            // 
            this.aButtonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aButtonCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.aButtonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.aButtonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.aButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButtonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aButtonCancelar.Location = new System.Drawing.Point(568, 73);
            this.aButtonCancelar.Name = "aButtonCancelar";
            this.aButtonCancelar.Size = new System.Drawing.Size(88, 26);
            this.aButtonCancelar.TabIndex = 30;
            this.aButtonCancelar.Text = "Cancelar";
            this.aButtonCancelar.UseVisualStyleBackColor = true;
            this.aButtonCancelar.Click += new System.EventHandler(this.aButtonCancelar_Click);
            // 
            // aButtonAceptar
            // 
            this.aButtonAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aButtonAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.aButtonAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.aButtonAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.aButtonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButtonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aButtonAceptar.Location = new System.Drawing.Point(568, 34);
            this.aButtonAceptar.Name = "aButtonAceptar";
            this.aButtonAceptar.Size = new System.Drawing.Size(88, 26);
            this.aButtonAceptar.TabIndex = 29;
            this.aButtonAceptar.Text = "Aceptar";
            this.aButtonAceptar.UseVisualStyleBackColor = true;
            this.aButtonAceptar.Click += new System.EventHandler(this.aButtonAceptar_Click);
            // 
            // aButtonTelefonos
            // 
            this.aButtonTelefonos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aButtonTelefonos.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.aButtonTelefonos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.aButtonTelefonos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.aButtonTelefonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButtonTelefonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aButtonTelefonos.Location = new System.Drawing.Point(383, 67);
            this.aButtonTelefonos.Name = "aButtonTelefonos";
            this.aButtonTelefonos.Size = new System.Drawing.Size(99, 26);
            this.aButtonTelefonos.TabIndex = 28;
            this.aButtonTelefonos.Text = "&Telefonos";
            this.aButtonTelefonos.UseVisualStyleBackColor = true;
            this.aButtonTelefonos.Click += new System.EventHandler(this.aButtonTelefonos_Click);
            // 
            // aTextBoxCorreo
            // 
            this.aTextBoxCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aTextBoxCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aTextBoxCorreo.Location = new System.Drawing.Point(347, 39);
            this.aTextBoxCorreo.MaxLength = 40;
            this.aTextBoxCorreo.Name = "aTextBoxCorreo";
            this.aTextBoxCorreo.Size = new System.Drawing.Size(200, 21);
            this.aTextBoxCorreo.TabIndex = 27;
            // 
            // aTextBoxDireccion
            // 
            this.aTextBoxDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aTextBoxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aTextBoxDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aTextBoxDireccion.Location = new System.Drawing.Point(347, 13);
            this.aTextBoxDireccion.MaxLength = 100;
            this.aTextBoxDireccion.Name = "aTextBoxDireccion";
            this.aTextBoxDireccion.Size = new System.Drawing.Size(200, 21);
            this.aTextBoxDireccion.TabIndex = 26;
            // 
            // aTextBoxApellido
            // 
            this.aTextBoxApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aTextBoxApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aTextBoxApellido.Location = new System.Drawing.Point(68, 94);
            this.aTextBoxApellido.MaxLength = 50;
            this.aTextBoxApellido.Name = "aTextBoxApellido";
            this.aTextBoxApellido.Size = new System.Drawing.Size(200, 21);
            this.aTextBoxApellido.TabIndex = 25;
            // 
            // aTextBoxNombre
            // 
            this.aTextBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aTextBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aTextBoxNombre.Location = new System.Drawing.Point(68, 67);
            this.aTextBoxNombre.MaxLength = 50;
            this.aTextBoxNombre.Name = "aTextBoxNombre";
            this.aTextBoxNombre.Size = new System.Drawing.Size(200, 21);
            this.aTextBoxNombre.TabIndex = 24;
            // 
            // aMaskedTextBoxCuit
            // 
            this.aMaskedTextBoxCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aMaskedTextBoxCuit.Location = new System.Drawing.Point(68, 39);
            this.aMaskedTextBoxCuit.Mask = "00-00000000-0";
            this.aMaskedTextBoxCuit.Name = "aMaskedTextBoxCuit";
            this.aMaskedTextBoxCuit.PromptChar = ' ';
            this.aMaskedTextBoxCuit.Size = new System.Drawing.Size(130, 21);
            this.aMaskedTextBoxCuit.TabIndex = 23;
            this.aMaskedTextBoxCuit.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // aMaskedTextBoxDni
            // 
            this.aMaskedTextBoxDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aMaskedTextBoxDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aMaskedTextBoxDni.Location = new System.Drawing.Point(68, 13);
            this.aMaskedTextBoxDni.Mask = "00,000,000";
            this.aMaskedTextBoxDni.Name = "aMaskedTextBoxDni";
            this.aMaskedTextBoxDni.PromptChar = ' ';
            this.aMaskedTextBoxDni.Size = new System.Drawing.Size(130, 21);
            this.aMaskedTextBoxDni.TabIndex = 22;
            this.aMaskedTextBoxDni.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.aMaskedTextBoxDni.Leave += new System.EventHandler(this.aMaskedTextBoxDni_Leave);
            // 
            // aLabelCorreo
            // 
            this.aLabelCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aLabelCorreo.AutoSize = true;
            this.aLabelCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelCorreo.Location = new System.Drawing.Point(286, 42);
            this.aLabelCorreo.Name = "aLabelCorreo";
            this.aLabelCorreo.Size = new System.Drawing.Size(47, 15);
            this.aLabelCorreo.TabIndex = 21;
            this.aLabelCorreo.Text = "Correo:";
            // 
            // aLabelDireccion
            // 
            this.aLabelDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aLabelDireccion.AutoSize = true;
            this.aLabelDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelDireccion.Location = new System.Drawing.Point(286, 16);
            this.aLabelDireccion.Name = "aLabelDireccion";
            this.aLabelDireccion.Size = new System.Drawing.Size(62, 15);
            this.aLabelDireccion.TabIndex = 20;
            this.aLabelDireccion.Text = "Dirección:";
            // 
            // aLabelApellido
            // 
            this.aLabelApellido.AutoSize = true;
            this.aLabelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelApellido.Location = new System.Drawing.Point(13, 97);
            this.aLabelApellido.Name = "aLabelApellido";
            this.aLabelApellido.Size = new System.Drawing.Size(54, 15);
            this.aLabelApellido.TabIndex = 19;
            this.aLabelApellido.Text = "Apellido:";
            // 
            // aLabelNombre
            // 
            this.aLabelNombre.AutoSize = true;
            this.aLabelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelNombre.Location = new System.Drawing.Point(13, 70);
            this.aLabelNombre.Name = "aLabelNombre";
            this.aLabelNombre.Size = new System.Drawing.Size(55, 15);
            this.aLabelNombre.TabIndex = 18;
            this.aLabelNombre.Text = "Nombre:";
            // 
            // aLabelCuit
            // 
            this.aLabelCuit.AutoSize = true;
            this.aLabelCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelCuit.Location = new System.Drawing.Point(13, 42);
            this.aLabelCuit.Name = "aLabelCuit";
            this.aLabelCuit.Size = new System.Drawing.Size(37, 15);
            this.aLabelCuit.TabIndex = 17;
            this.aLabelCuit.Text = "CUIT:";
            // 
            // aLabelDni
            // 
            this.aLabelDni.AutoSize = true;
            this.aLabelDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelDni.Location = new System.Drawing.Point(13, 16);
            this.aLabelDni.Name = "aLabelDni";
            this.aLabelDni.Size = new System.Drawing.Size(31, 15);
            this.aLabelDni.TabIndex = 16;
            this.aLabelDni.Text = "DNI:";
            // 
            // aDataGridViewPer
            // 
            this.aDataGridViewPer.AllowUserToAddRows = false;
            this.aDataGridViewPer.AllowUserToDeleteRows = false;
            this.aDataGridViewPer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridViewPer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aDataGridViewPer.Location = new System.Drawing.Point(0, 0);
            this.aDataGridViewPer.MultiSelect = false;
            this.aDataGridViewPer.Name = "aDataGridViewPer";
            this.aDataGridViewPer.ReadOnly = true;
            this.aDataGridViewPer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.aDataGridViewPer.Size = new System.Drawing.Size(671, 264);
            this.aDataGridViewPer.TabIndex = 0;
            this.aDataGridViewPer.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.aDataGridViewPer_CellMouseDoubleClick);
            // 
            // tabPageModificar
            // 
            this.tabPageModificar.Location = new System.Drawing.Point(4, 24);
            this.tabPageModificar.Name = "tabPageModificar";
            this.tabPageModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageModificar.Size = new System.Drawing.Size(681, 418);
            this.tabPageModificar.TabIndex = 1;
            this.tabPageModificar.Text = "Ver/Modificar";
            this.tabPageModificar.UseVisualStyleBackColor = true;
            // 
            // tabPageBaja
            // 
            this.tabPageBaja.Location = new System.Drawing.Point(4, 24);
            this.tabPageBaja.Name = "tabPageBaja";
            this.tabPageBaja.Size = new System.Drawing.Size(681, 418);
            this.tabPageBaja.TabIndex = 2;
            this.tabPageBaja.Text = "Baja";
            this.tabPageBaja.UseVisualStyleBackColor = true;
            // 
            // pPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlPersonal);
            this.Name = "pPersonal";
            this.Size = new System.Drawing.Size(689, 446);
            this.Load += new System.EventHandler(this.pPersonal_Load);
            this.tabControlPersonal.ResumeLayout(false);
            this.tabPageAlta.ResumeLayout(false);
            this.aSplitContainer.Panel1.ResumeLayout(false);
            this.aSplitContainer.Panel1.PerformLayout();
            this.aSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer)).EndInit();
            this.aSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridViewPer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPersonal;
        private System.Windows.Forms.TabPage tabPageAlta;
        private System.Windows.Forms.TabPage tabPageModificar;
        private System.Windows.Forms.TabPage tabPageBaja;
        private System.Windows.Forms.SplitContainer aSplitContainer;
        private System.Windows.Forms.DataGridView aDataGridViewPer;
        internal System.Windows.Forms.Button aButtonReactivar;
        internal System.Windows.Forms.Button aButtonCancelar;
        internal System.Windows.Forms.Button aButtonAceptar;
        internal System.Windows.Forms.Button aButtonTelefonos;
        internal System.Windows.Forms.TextBox aTextBoxCorreo;
        internal System.Windows.Forms.TextBox aTextBoxDireccion;
        internal System.Windows.Forms.TextBox aTextBoxApellido;
        internal System.Windows.Forms.TextBox aTextBoxNombre;
        internal System.Windows.Forms.MaskedTextBox aMaskedTextBoxCuit;
        internal System.Windows.Forms.MaskedTextBox aMaskedTextBoxDni;
        internal System.Windows.Forms.Label aLabelCorreo;
        internal System.Windows.Forms.Label aLabelDireccion;
        internal System.Windows.Forms.Label aLabelApellido;
        internal System.Windows.Forms.Label aLabelNombre;
        internal System.Windows.Forms.Label aLabelCuit;
        internal System.Windows.Forms.Label aLabelDni;
    }
}
