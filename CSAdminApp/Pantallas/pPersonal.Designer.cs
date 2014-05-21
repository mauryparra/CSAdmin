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
            this.mSplitContainer = new System.Windows.Forms.SplitContainer();
            this.mButtonCancelar = new System.Windows.Forms.Button();
            this.mButtonModificar = new System.Windows.Forms.Button();
            this.mButtonTelefonos = new System.Windows.Forms.Button();
            this.mTextBoxCorreo = new System.Windows.Forms.TextBox();
            this.mTextBoxDireccion = new System.Windows.Forms.TextBox();
            this.mTextBoxApellido = new System.Windows.Forms.TextBox();
            this.mTextBoxNombre = new System.Windows.Forms.TextBox();
            this.mMaskedTextBoxCuit = new System.Windows.Forms.MaskedTextBox();
            this.mMaskedTextBoxDni = new System.Windows.Forms.MaskedTextBox();
            this.mLabelCorreo = new System.Windows.Forms.Label();
            this.mLabelDireccion = new System.Windows.Forms.Label();
            this.mLabelApellido = new System.Windows.Forms.Label();
            this.mLabelNombre = new System.Windows.Forms.Label();
            this.mLabelCuit = new System.Windows.Forms.Label();
            this.mLabelDni = new System.Windows.Forms.Label();
            this.mDataGridViewPer = new System.Windows.Forms.DataGridView();
            this.tabPageBaja = new System.Windows.Forms.TabPage();
            this.bSplitContainer = new System.Windows.Forms.SplitContainer();
            this.bButtonContratos = new System.Windows.Forms.Button();
            this.bButtonBaja = new System.Windows.Forms.Button();
            this.bButtonCancelar = new System.Windows.Forms.Button();
            this.bTextBoxDireccion = new System.Windows.Forms.TextBox();
            this.bTextBoxApellido = new System.Windows.Forms.TextBox();
            this.bTextBoxNombre = new System.Windows.Forms.TextBox();
            this.bMaskedTextBoxDni = new System.Windows.Forms.MaskedTextBox();
            this.bLabelDireccion = new System.Windows.Forms.Label();
            this.bLabelApellido = new System.Windows.Forms.Label();
            this.bLabelNombre = new System.Windows.Forms.Label();
            this.bLabelDni = new System.Windows.Forms.Label();
            this.bDataGridViewPer = new System.Windows.Forms.DataGridView();
            this.tabControlPersonal.SuspendLayout();
            this.tabPageAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer)).BeginInit();
            this.aSplitContainer.Panel1.SuspendLayout();
            this.aSplitContainer.Panel2.SuspendLayout();
            this.aSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridViewPer)).BeginInit();
            this.tabPageModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mSplitContainer)).BeginInit();
            this.mSplitContainer.Panel1.SuspendLayout();
            this.mSplitContainer.Panel2.SuspendLayout();
            this.mSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGridViewPer)).BeginInit();
            this.tabPageBaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSplitContainer)).BeginInit();
            this.bSplitContainer.Panel1.SuspendLayout();
            this.bSplitContainer.Panel2.SuspendLayout();
            this.bSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDataGridViewPer)).BeginInit();
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
            this.tabPageModificar.Controls.Add(this.mSplitContainer);
            this.tabPageModificar.Location = new System.Drawing.Point(4, 24);
            this.tabPageModificar.Name = "tabPageModificar";
            this.tabPageModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageModificar.Size = new System.Drawing.Size(681, 418);
            this.tabPageModificar.TabIndex = 1;
            this.tabPageModificar.Text = "Ver/Modificar";
            this.tabPageModificar.UseVisualStyleBackColor = true;
            // 
            // mSplitContainer
            // 
            this.mSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mSplitContainer.IsSplitterFixed = true;
            this.mSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.mSplitContainer.Name = "mSplitContainer";
            this.mSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mSplitContainer.Panel1
            // 
            this.mSplitContainer.Panel1.Controls.Add(this.mButtonCancelar);
            this.mSplitContainer.Panel1.Controls.Add(this.mButtonModificar);
            this.mSplitContainer.Panel1.Controls.Add(this.mButtonTelefonos);
            this.mSplitContainer.Panel1.Controls.Add(this.mTextBoxCorreo);
            this.mSplitContainer.Panel1.Controls.Add(this.mTextBoxDireccion);
            this.mSplitContainer.Panel1.Controls.Add(this.mTextBoxApellido);
            this.mSplitContainer.Panel1.Controls.Add(this.mTextBoxNombre);
            this.mSplitContainer.Panel1.Controls.Add(this.mMaskedTextBoxCuit);
            this.mSplitContainer.Panel1.Controls.Add(this.mMaskedTextBoxDni);
            this.mSplitContainer.Panel1.Controls.Add(this.mLabelCorreo);
            this.mSplitContainer.Panel1.Controls.Add(this.mLabelDireccion);
            this.mSplitContainer.Panel1.Controls.Add(this.mLabelApellido);
            this.mSplitContainer.Panel1.Controls.Add(this.mLabelNombre);
            this.mSplitContainer.Panel1.Controls.Add(this.mLabelCuit);
            this.mSplitContainer.Panel1.Controls.Add(this.mLabelDni);
            // 
            // mSplitContainer.Panel2
            // 
            this.mSplitContainer.Panel2.Controls.Add(this.mDataGridViewPer);
            this.mSplitContainer.Size = new System.Drawing.Size(675, 412);
            this.mSplitContainer.SplitterDistance = 140;
            this.mSplitContainer.TabIndex = 1;
            // 
            // mButtonCancelar
            // 
            this.mButtonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mButtonCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.mButtonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.mButtonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.mButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mButtonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mButtonCancelar.Location = new System.Drawing.Point(569, 77);
            this.mButtonCancelar.Name = "mButtonCancelar";
            this.mButtonCancelar.Size = new System.Drawing.Size(88, 26);
            this.mButtonCancelar.TabIndex = 29;
            this.mButtonCancelar.Text = "Cancelar";
            this.mButtonCancelar.UseVisualStyleBackColor = true;
            this.mButtonCancelar.Click += new System.EventHandler(this.mButtonCancelar_Click);
            // 
            // mButtonModificar
            // 
            this.mButtonModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mButtonModificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.mButtonModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.mButtonModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.mButtonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mButtonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mButtonModificar.Location = new System.Drawing.Point(569, 38);
            this.mButtonModificar.Name = "mButtonModificar";
            this.mButtonModificar.Size = new System.Drawing.Size(88, 26);
            this.mButtonModificar.TabIndex = 28;
            this.mButtonModificar.Text = "Modificar";
            this.mButtonModificar.UseVisualStyleBackColor = true;
            this.mButtonModificar.Click += new System.EventHandler(this.mButtonModificar_Click);
            // 
            // mButtonTelefonos
            // 
            this.mButtonTelefonos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mButtonTelefonos.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.mButtonTelefonos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.mButtonTelefonos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.mButtonTelefonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mButtonTelefonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mButtonTelefonos.Location = new System.Drawing.Point(384, 70);
            this.mButtonTelefonos.Name = "mButtonTelefonos";
            this.mButtonTelefonos.Size = new System.Drawing.Size(99, 26);
            this.mButtonTelefonos.TabIndex = 27;
            this.mButtonTelefonos.Text = "&Telefonos";
            this.mButtonTelefonos.UseVisualStyleBackColor = true;
            this.mButtonTelefonos.Click += new System.EventHandler(this.mButtonTelefonos_Click);
            // 
            // mTextBoxCorreo
            // 
            this.mTextBoxCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mTextBoxCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTextBoxCorreo.Location = new System.Drawing.Point(348, 42);
            this.mTextBoxCorreo.MaxLength = 40;
            this.mTextBoxCorreo.Name = "mTextBoxCorreo";
            this.mTextBoxCorreo.Size = new System.Drawing.Size(200, 21);
            this.mTextBoxCorreo.TabIndex = 26;
            // 
            // mTextBoxDireccion
            // 
            this.mTextBoxDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mTextBoxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mTextBoxDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTextBoxDireccion.Location = new System.Drawing.Point(348, 16);
            this.mTextBoxDireccion.MaxLength = 100;
            this.mTextBoxDireccion.Name = "mTextBoxDireccion";
            this.mTextBoxDireccion.Size = new System.Drawing.Size(200, 21);
            this.mTextBoxDireccion.TabIndex = 25;
            // 
            // mTextBoxApellido
            // 
            this.mTextBoxApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mTextBoxApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTextBoxApellido.Location = new System.Drawing.Point(69, 97);
            this.mTextBoxApellido.MaxLength = 50;
            this.mTextBoxApellido.Name = "mTextBoxApellido";
            this.mTextBoxApellido.Size = new System.Drawing.Size(200, 21);
            this.mTextBoxApellido.TabIndex = 24;
            // 
            // mTextBoxNombre
            // 
            this.mTextBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mTextBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTextBoxNombre.Location = new System.Drawing.Point(69, 70);
            this.mTextBoxNombre.MaxLength = 50;
            this.mTextBoxNombre.Name = "mTextBoxNombre";
            this.mTextBoxNombre.Size = new System.Drawing.Size(200, 21);
            this.mTextBoxNombre.TabIndex = 23;
            // 
            // mMaskedTextBoxCuit
            // 
            this.mMaskedTextBoxCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mMaskedTextBoxCuit.Location = new System.Drawing.Point(69, 42);
            this.mMaskedTextBoxCuit.Mask = "00-00000000-0";
            this.mMaskedTextBoxCuit.Name = "mMaskedTextBoxCuit";
            this.mMaskedTextBoxCuit.PromptChar = ' ';
            this.mMaskedTextBoxCuit.Size = new System.Drawing.Size(130, 21);
            this.mMaskedTextBoxCuit.TabIndex = 22;
            this.mMaskedTextBoxCuit.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mMaskedTextBoxDni
            // 
            this.mMaskedTextBoxDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mMaskedTextBoxDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mMaskedTextBoxDni.Location = new System.Drawing.Point(69, 16);
            this.mMaskedTextBoxDni.Mask = "00,000,000";
            this.mMaskedTextBoxDni.Name = "mMaskedTextBoxDni";
            this.mMaskedTextBoxDni.PromptChar = ' ';
            this.mMaskedTextBoxDni.Size = new System.Drawing.Size(130, 21);
            this.mMaskedTextBoxDni.TabIndex = 21;
            this.mMaskedTextBoxDni.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mMaskedTextBoxDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mMaskedTextBoxDni_KeyPress);
            // 
            // mLabelCorreo
            // 
            this.mLabelCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelCorreo.AutoSize = true;
            this.mLabelCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabelCorreo.Location = new System.Drawing.Point(287, 45);
            this.mLabelCorreo.Name = "mLabelCorreo";
            this.mLabelCorreo.Size = new System.Drawing.Size(47, 15);
            this.mLabelCorreo.TabIndex = 20;
            this.mLabelCorreo.Text = "Correo:";
            // 
            // mLabelDireccion
            // 
            this.mLabelDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelDireccion.AutoSize = true;
            this.mLabelDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabelDireccion.Location = new System.Drawing.Point(287, 19);
            this.mLabelDireccion.Name = "mLabelDireccion";
            this.mLabelDireccion.Size = new System.Drawing.Size(62, 15);
            this.mLabelDireccion.TabIndex = 19;
            this.mLabelDireccion.Text = "Dirección:";
            // 
            // mLabelApellido
            // 
            this.mLabelApellido.AutoSize = true;
            this.mLabelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabelApellido.Location = new System.Drawing.Point(14, 100);
            this.mLabelApellido.Name = "mLabelApellido";
            this.mLabelApellido.Size = new System.Drawing.Size(54, 15);
            this.mLabelApellido.TabIndex = 18;
            this.mLabelApellido.Text = "Apellido:";
            // 
            // mLabelNombre
            // 
            this.mLabelNombre.AutoSize = true;
            this.mLabelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabelNombre.Location = new System.Drawing.Point(14, 73);
            this.mLabelNombre.Name = "mLabelNombre";
            this.mLabelNombre.Size = new System.Drawing.Size(55, 15);
            this.mLabelNombre.TabIndex = 17;
            this.mLabelNombre.Text = "Nombre:";
            // 
            // mLabelCuit
            // 
            this.mLabelCuit.AutoSize = true;
            this.mLabelCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabelCuit.Location = new System.Drawing.Point(14, 45);
            this.mLabelCuit.Name = "mLabelCuit";
            this.mLabelCuit.Size = new System.Drawing.Size(37, 15);
            this.mLabelCuit.TabIndex = 16;
            this.mLabelCuit.Text = "CUIT:";
            // 
            // mLabelDni
            // 
            this.mLabelDni.AutoSize = true;
            this.mLabelDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabelDni.Location = new System.Drawing.Point(14, 19);
            this.mLabelDni.Name = "mLabelDni";
            this.mLabelDni.Size = new System.Drawing.Size(31, 15);
            this.mLabelDni.TabIndex = 15;
            this.mLabelDni.Text = "DNI:";
            // 
            // mDataGridViewPer
            // 
            this.mDataGridViewPer.AllowUserToAddRows = false;
            this.mDataGridViewPer.AllowUserToDeleteRows = false;
            this.mDataGridViewPer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mDataGridViewPer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDataGridViewPer.Location = new System.Drawing.Point(0, 0);
            this.mDataGridViewPer.MultiSelect = false;
            this.mDataGridViewPer.Name = "mDataGridViewPer";
            this.mDataGridViewPer.ReadOnly = true;
            this.mDataGridViewPer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mDataGridViewPer.Size = new System.Drawing.Size(671, 264);
            this.mDataGridViewPer.TabIndex = 0;
            this.mDataGridViewPer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mDataGridViewPer_CellDoubleClick);
            // 
            // tabPageBaja
            // 
            this.tabPageBaja.Controls.Add(this.bSplitContainer);
            this.tabPageBaja.Location = new System.Drawing.Point(4, 24);
            this.tabPageBaja.Name = "tabPageBaja";
            this.tabPageBaja.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBaja.Size = new System.Drawing.Size(681, 418);
            this.tabPageBaja.TabIndex = 2;
            this.tabPageBaja.Text = "Baja";
            this.tabPageBaja.UseVisualStyleBackColor = true;
            // 
            // bSplitContainer
            // 
            this.bSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.bSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.bSplitContainer.Name = "bSplitContainer";
            this.bSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // bSplitContainer.Panel1
            // 
            this.bSplitContainer.Panel1.Controls.Add(this.bButtonContratos);
            this.bSplitContainer.Panel1.Controls.Add(this.bButtonBaja);
            this.bSplitContainer.Panel1.Controls.Add(this.bButtonCancelar);
            this.bSplitContainer.Panel1.Controls.Add(this.bTextBoxDireccion);
            this.bSplitContainer.Panel1.Controls.Add(this.bTextBoxApellido);
            this.bSplitContainer.Panel1.Controls.Add(this.bTextBoxNombre);
            this.bSplitContainer.Panel1.Controls.Add(this.bMaskedTextBoxDni);
            this.bSplitContainer.Panel1.Controls.Add(this.bLabelDireccion);
            this.bSplitContainer.Panel1.Controls.Add(this.bLabelApellido);
            this.bSplitContainer.Panel1.Controls.Add(this.bLabelNombre);
            this.bSplitContainer.Panel1.Controls.Add(this.bLabelDni);
            // 
            // bSplitContainer.Panel2
            // 
            this.bSplitContainer.Panel2.Controls.Add(this.bDataGridViewPer);
            this.bSplitContainer.Size = new System.Drawing.Size(675, 412);
            this.bSplitContainer.SplitterDistance = 140;
            this.bSplitContainer.TabIndex = 1;
            // 
            // bButtonContratos
            // 
            this.bButtonContratos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bButtonContratos.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.bButtonContratos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.bButtonContratos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.bButtonContratos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bButtonContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bButtonContratos.Location = new System.Drawing.Point(444, 16);
            this.bButtonContratos.Name = "bButtonContratos";
            this.bButtonContratos.Size = new System.Drawing.Size(99, 26);
            this.bButtonContratos.TabIndex = 25;
            this.bButtonContratos.Text = "Contratos";
            this.bButtonContratos.UseVisualStyleBackColor = true;
            this.bButtonContratos.Click += new System.EventHandler(this.bButtonContratos_Click);
            // 
            // bButtonBaja
            // 
            this.bButtonBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bButtonBaja.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.bButtonBaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.bButtonBaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.bButtonBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bButtonBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bButtonBaja.Location = new System.Drawing.Point(444, 55);
            this.bButtonBaja.Name = "bButtonBaja";
            this.bButtonBaja.Size = new System.Drawing.Size(99, 26);
            this.bButtonBaja.TabIndex = 26;
            this.bButtonBaja.Text = "Baja";
            this.bButtonBaja.UseVisualStyleBackColor = true;
            this.bButtonBaja.Click += new System.EventHandler(this.bButtonBaja_Click);
            // 
            // bButtonCancelar
            // 
            this.bButtonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bButtonCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.bButtonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.bButtonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.bButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bButtonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bButtonCancelar.Location = new System.Drawing.Point(444, 96);
            this.bButtonCancelar.Name = "bButtonCancelar";
            this.bButtonCancelar.Size = new System.Drawing.Size(99, 26);
            this.bButtonCancelar.TabIndex = 27;
            this.bButtonCancelar.Text = "Cancelar";
            this.bButtonCancelar.UseVisualStyleBackColor = true;
            this.bButtonCancelar.Click += new System.EventHandler(this.bButtonCancelar_Click);
            // 
            // bTextBoxDireccion
            // 
            this.bTextBoxDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTextBoxDireccion.Location = new System.Drawing.Point(82, 94);
            this.bTextBoxDireccion.MaxLength = 100;
            this.bTextBoxDireccion.Name = "bTextBoxDireccion";
            this.bTextBoxDireccion.ReadOnly = true;
            this.bTextBoxDireccion.Size = new System.Drawing.Size(200, 21);
            this.bTextBoxDireccion.TabIndex = 24;
            this.bTextBoxDireccion.TabStop = false;
            // 
            // bTextBoxApellido
            // 
            this.bTextBoxApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTextBoxApellido.Location = new System.Drawing.Point(82, 70);
            this.bTextBoxApellido.MaxLength = 50;
            this.bTextBoxApellido.Name = "bTextBoxApellido";
            this.bTextBoxApellido.ReadOnly = true;
            this.bTextBoxApellido.Size = new System.Drawing.Size(201, 21);
            this.bTextBoxApellido.TabIndex = 23;
            this.bTextBoxApellido.TabStop = false;
            // 
            // bTextBoxNombre
            // 
            this.bTextBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTextBoxNombre.Location = new System.Drawing.Point(83, 43);
            this.bTextBoxNombre.MaxLength = 50;
            this.bTextBoxNombre.Name = "bTextBoxNombre";
            this.bTextBoxNombre.ReadOnly = true;
            this.bTextBoxNombre.Size = new System.Drawing.Size(200, 21);
            this.bTextBoxNombre.TabIndex = 22;
            this.bTextBoxNombre.TabStop = false;
            // 
            // bMaskedTextBoxDni
            // 
            this.bMaskedTextBoxDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bMaskedTextBoxDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMaskedTextBoxDni.Location = new System.Drawing.Point(83, 13);
            this.bMaskedTextBoxDni.Mask = "00,000,000";
            this.bMaskedTextBoxDni.Name = "bMaskedTextBoxDni";
            this.bMaskedTextBoxDni.PromptChar = ' ';
            this.bMaskedTextBoxDni.Size = new System.Drawing.Size(130, 21);
            this.bMaskedTextBoxDni.TabIndex = 21;
            this.bMaskedTextBoxDni.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.bMaskedTextBoxDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bMaskedTextBoxDni_KeyPress);
            // 
            // bLabelDireccion
            // 
            this.bLabelDireccion.AutoSize = true;
            this.bLabelDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLabelDireccion.Location = new System.Drawing.Point(15, 97);
            this.bLabelDireccion.Name = "bLabelDireccion";
            this.bLabelDireccion.Size = new System.Drawing.Size(62, 15);
            this.bLabelDireccion.TabIndex = 20;
            this.bLabelDireccion.Text = "Dirección:";
            // 
            // bLabelApellido
            // 
            this.bLabelApellido.AutoSize = true;
            this.bLabelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLabelApellido.Location = new System.Drawing.Point(15, 73);
            this.bLabelApellido.Name = "bLabelApellido";
            this.bLabelApellido.Size = new System.Drawing.Size(54, 15);
            this.bLabelApellido.TabIndex = 19;
            this.bLabelApellido.Text = "Apellido:";
            // 
            // bLabelNombre
            // 
            this.bLabelNombre.AutoSize = true;
            this.bLabelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLabelNombre.Location = new System.Drawing.Point(15, 46);
            this.bLabelNombre.Name = "bLabelNombre";
            this.bLabelNombre.Size = new System.Drawing.Size(55, 15);
            this.bLabelNombre.TabIndex = 18;
            this.bLabelNombre.Text = "Nombre:";
            // 
            // bLabelDni
            // 
            this.bLabelDni.AutoSize = true;
            this.bLabelDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLabelDni.Location = new System.Drawing.Point(15, 16);
            this.bLabelDni.Name = "bLabelDni";
            this.bLabelDni.Size = new System.Drawing.Size(31, 15);
            this.bLabelDni.TabIndex = 17;
            this.bLabelDni.Text = "DNI:";
            // 
            // bDataGridViewPer
            // 
            this.bDataGridViewPer.AllowUserToAddRows = false;
            this.bDataGridViewPer.AllowUserToDeleteRows = false;
            this.bDataGridViewPer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bDataGridViewPer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bDataGridViewPer.Location = new System.Drawing.Point(0, 0);
            this.bDataGridViewPer.MultiSelect = false;
            this.bDataGridViewPer.Name = "bDataGridViewPer";
            this.bDataGridViewPer.ReadOnly = true;
            this.bDataGridViewPer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bDataGridViewPer.Size = new System.Drawing.Size(671, 264);
            this.bDataGridViewPer.TabIndex = 1;
            this.bDataGridViewPer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bDataGridViewPer_CellDoubleClick);
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
            this.tabPageModificar.ResumeLayout(false);
            this.mSplitContainer.Panel1.ResumeLayout(false);
            this.mSplitContainer.Panel1.PerformLayout();
            this.mSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mSplitContainer)).EndInit();
            this.mSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mDataGridViewPer)).EndInit();
            this.tabPageBaja.ResumeLayout(false);
            this.bSplitContainer.Panel1.ResumeLayout(false);
            this.bSplitContainer.Panel1.PerformLayout();
            this.bSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bSplitContainer)).EndInit();
            this.bSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bDataGridViewPer)).EndInit();
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
        internal System.Windows.Forms.SplitContainer mSplitContainer;
        internal System.Windows.Forms.Button mButtonCancelar;
        internal System.Windows.Forms.Button mButtonModificar;
        internal System.Windows.Forms.Button mButtonTelefonos;
        internal System.Windows.Forms.TextBox mTextBoxCorreo;
        internal System.Windows.Forms.TextBox mTextBoxDireccion;
        internal System.Windows.Forms.TextBox mTextBoxApellido;
        internal System.Windows.Forms.TextBox mTextBoxNombre;
        internal System.Windows.Forms.MaskedTextBox mMaskedTextBoxCuit;
        internal System.Windows.Forms.MaskedTextBox mMaskedTextBoxDni;
        internal System.Windows.Forms.Label mLabelCorreo;
        internal System.Windows.Forms.Label mLabelDireccion;
        internal System.Windows.Forms.Label mLabelApellido;
        internal System.Windows.Forms.Label mLabelNombre;
        internal System.Windows.Forms.Label mLabelCuit;
        internal System.Windows.Forms.Label mLabelDni;
        internal System.Windows.Forms.DataGridView mDataGridViewPer;
        internal System.Windows.Forms.SplitContainer bSplitContainer;
        internal System.Windows.Forms.Button bButtonContratos;
        internal System.Windows.Forms.Button bButtonBaja;
        internal System.Windows.Forms.Button bButtonCancelar;
        internal System.Windows.Forms.TextBox bTextBoxDireccion;
        internal System.Windows.Forms.TextBox bTextBoxApellido;
        internal System.Windows.Forms.TextBox bTextBoxNombre;
        internal System.Windows.Forms.MaskedTextBox bMaskedTextBoxDni;
        internal System.Windows.Forms.Label bLabelDireccion;
        internal System.Windows.Forms.Label bLabelApellido;
        internal System.Windows.Forms.Label bLabelNombre;
        internal System.Windows.Forms.Label bLabelDni;
        internal System.Windows.Forms.DataGridView bDataGridViewPer;
    }
}
