<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pPersonal
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControlPersonal = New System.Windows.Forms.TabControl()
        Me.TabPageAlta = New System.Windows.Forms.TabPage()
        Me.ASplitContainer = New System.Windows.Forms.SplitContainer()
        Me.AButtonReactivar = New System.Windows.Forms.Button()
        Me.AButtonCancelar = New System.Windows.Forms.Button()
        Me.AButtonAceptar = New System.Windows.Forms.Button()
        Me.AButtonTelefonos = New System.Windows.Forms.Button()
        Me.ATextBoxCorreo = New System.Windows.Forms.TextBox()
        Me.ATextBoxDireccion = New System.Windows.Forms.TextBox()
        Me.ATextBoxApellido = New System.Windows.Forms.TextBox()
        Me.ATextBoxNombre = New System.Windows.Forms.TextBox()
        Me.AMaskedTextBoxCuit = New System.Windows.Forms.MaskedTextBox()
        Me.AMaskedTextBoxDni = New System.Windows.Forms.MaskedTextBox()
        Me.ALabelCorreo = New System.Windows.Forms.Label()
        Me.ALabelDireccion = New System.Windows.Forms.Label()
        Me.ALabelApellido = New System.Windows.Forms.Label()
        Me.ALabelNombre = New System.Windows.Forms.Label()
        Me.ALabelCuit = New System.Windows.Forms.Label()
        Me.ALabelDni = New System.Windows.Forms.Label()
        Me.ADataGridViewPer = New System.Windows.Forms.DataGridView()
        Me.TabPageModificar = New System.Windows.Forms.TabPage()
        Me.MSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.MButtonCancelar = New System.Windows.Forms.Button()
        Me.MButtonModificar = New System.Windows.Forms.Button()
        Me.MButtonTelefonos = New System.Windows.Forms.Button()
        Me.MTextBoxCorreo = New System.Windows.Forms.TextBox()
        Me.MTextBoxDireccion = New System.Windows.Forms.TextBox()
        Me.MTextBoxApellido = New System.Windows.Forms.TextBox()
        Me.MTextBoxNombre = New System.Windows.Forms.TextBox()
        Me.MMaskedTextBoxCuit = New System.Windows.Forms.MaskedTextBox()
        Me.MMaskedTextBoxDni = New System.Windows.Forms.MaskedTextBox()
        Me.MLabelCorreo = New System.Windows.Forms.Label()
        Me.MLabelDireccion = New System.Windows.Forms.Label()
        Me.MLabelApellido = New System.Windows.Forms.Label()
        Me.MLabelNombre = New System.Windows.Forms.Label()
        Me.MLabelCuit = New System.Windows.Forms.Label()
        Me.MLabelDni = New System.Windows.Forms.Label()
        Me.MDataGridViewPer = New System.Windows.Forms.DataGridView()
        Me.TabPageBaja = New System.Windows.Forms.TabPage()
        Me.BSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.BButtonContratos = New System.Windows.Forms.Button()
        Me.BButtonBaja = New System.Windows.Forms.Button()
        Me.BButtonCancelar = New System.Windows.Forms.Button()
        Me.BTextBoxDireccion = New System.Windows.Forms.TextBox()
        Me.BTextBoxApellido = New System.Windows.Forms.TextBox()
        Me.BTextBoxNombre = New System.Windows.Forms.TextBox()
        Me.BMaskedTextBoxDni = New System.Windows.Forms.MaskedTextBox()
        Me.BLabelDireccion = New System.Windows.Forms.Label()
        Me.BLabelApellido = New System.Windows.Forms.Label()
        Me.BLabelNombre = New System.Windows.Forms.Label()
        Me.BLabelDni = New System.Windows.Forms.Label()
        Me.BDataGridViewPer = New System.Windows.Forms.DataGridView()
        Me.TabControlPersonal.SuspendLayout()
        Me.TabPageAlta.SuspendLayout()
        CType(Me.ASplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ASplitContainer.Panel1.SuspendLayout()
        Me.ASplitContainer.Panel2.SuspendLayout()
        Me.ASplitContainer.SuspendLayout()
        CType(Me.ADataGridViewPer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageModificar.SuspendLayout()
        CType(Me.MSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MSplitContainer.Panel1.SuspendLayout()
        Me.MSplitContainer.Panel2.SuspendLayout()
        Me.MSplitContainer.SuspendLayout()
        CType(Me.MDataGridViewPer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageBaja.SuspendLayout()
        CType(Me.BSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BSplitContainer.Panel1.SuspendLayout()
        Me.BSplitContainer.Panel2.SuspendLayout()
        Me.BSplitContainer.SuspendLayout()
        CType(Me.BDataGridViewPer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlPersonal
        '
        Me.TabControlPersonal.Controls.Add(Me.TabPageAlta)
        Me.TabControlPersonal.Controls.Add(Me.TabPageModificar)
        Me.TabControlPersonal.Controls.Add(Me.TabPageBaja)
        Me.TabControlPersonal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlPersonal.Location = New System.Drawing.Point(0, 0)
        Me.TabControlPersonal.Name = "TabControlPersonal"
        Me.TabControlPersonal.SelectedIndex = 0
        Me.TabControlPersonal.Size = New System.Drawing.Size(689, 446)
        Me.TabControlPersonal.TabIndex = 0
        '
        'TabPageAlta
        '
        Me.TabPageAlta.Controls.Add(Me.ASplitContainer)
        Me.TabPageAlta.Location = New System.Drawing.Point(4, 24)
        Me.TabPageAlta.Name = "TabPageAlta"
        Me.TabPageAlta.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAlta.Size = New System.Drawing.Size(681, 418)
        Me.TabPageAlta.TabIndex = 0
        Me.TabPageAlta.Text = "Alta"
        Me.TabPageAlta.UseVisualStyleBackColor = True
        '
        'ASplitContainer
        '
        Me.ASplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ASplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ASplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.ASplitContainer.IsSplitterFixed = True
        Me.ASplitContainer.Location = New System.Drawing.Point(3, 3)
        Me.ASplitContainer.Name = "ASplitContainer"
        Me.ASplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'ASplitContainer.Panel1
        '
        Me.ASplitContainer.Panel1.Controls.Add(Me.AButtonReactivar)
        Me.ASplitContainer.Panel1.Controls.Add(Me.AButtonCancelar)
        Me.ASplitContainer.Panel1.Controls.Add(Me.AButtonAceptar)
        Me.ASplitContainer.Panel1.Controls.Add(Me.AButtonTelefonos)
        Me.ASplitContainer.Panel1.Controls.Add(Me.ATextBoxCorreo)
        Me.ASplitContainer.Panel1.Controls.Add(Me.ATextBoxDireccion)
        Me.ASplitContainer.Panel1.Controls.Add(Me.ATextBoxApellido)
        Me.ASplitContainer.Panel1.Controls.Add(Me.ATextBoxNombre)
        Me.ASplitContainer.Panel1.Controls.Add(Me.AMaskedTextBoxCuit)
        Me.ASplitContainer.Panel1.Controls.Add(Me.AMaskedTextBoxDni)
        Me.ASplitContainer.Panel1.Controls.Add(Me.ALabelCorreo)
        Me.ASplitContainer.Panel1.Controls.Add(Me.ALabelDireccion)
        Me.ASplitContainer.Panel1.Controls.Add(Me.ALabelApellido)
        Me.ASplitContainer.Panel1.Controls.Add(Me.ALabelNombre)
        Me.ASplitContainer.Panel1.Controls.Add(Me.ALabelCuit)
        Me.ASplitContainer.Panel1.Controls.Add(Me.ALabelDni)
        '
        'ASplitContainer.Panel2
        '
        Me.ASplitContainer.Panel2.Controls.Add(Me.ADataGridViewPer)
        Me.ASplitContainer.Size = New System.Drawing.Size(675, 412)
        Me.ASplitContainer.SplitterDistance = 140
        Me.ASplitContainer.TabIndex = 0
        '
        'AButtonReactivar
        '
        Me.AButtonReactivar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AButtonReactivar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.AButtonReactivar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.AButtonReactivar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.AButtonReactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AButtonReactivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AButtonReactivar.Location = New System.Drawing.Point(383, 102)
        Me.AButtonReactivar.Name = "AButtonReactivar"
        Me.AButtonReactivar.Size = New System.Drawing.Size(99, 26)
        Me.AButtonReactivar.TabIndex = 15
        Me.AButtonReactivar.Text = "Reactivar"
        Me.AButtonReactivar.UseVisualStyleBackColor = True
        '
        'AButtonCancelar
        '
        Me.AButtonCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AButtonCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.AButtonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink
        Me.AButtonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink
        Me.AButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AButtonCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AButtonCancelar.Location = New System.Drawing.Point(568, 73)
        Me.AButtonCancelar.Name = "AButtonCancelar"
        Me.AButtonCancelar.Size = New System.Drawing.Size(88, 26)
        Me.AButtonCancelar.TabIndex = 14
        Me.AButtonCancelar.Text = "Cancelar"
        Me.AButtonCancelar.UseVisualStyleBackColor = True
        '
        'AButtonAceptar
        '
        Me.AButtonAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AButtonAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.AButtonAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.AButtonAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.AButtonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AButtonAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AButtonAceptar.Location = New System.Drawing.Point(568, 34)
        Me.AButtonAceptar.Name = "AButtonAceptar"
        Me.AButtonAceptar.Size = New System.Drawing.Size(88, 26)
        Me.AButtonAceptar.TabIndex = 13
        Me.AButtonAceptar.Text = "Aceptar"
        Me.AButtonAceptar.UseVisualStyleBackColor = True
        '
        'AButtonTelefonos
        '
        Me.AButtonTelefonos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AButtonTelefonos.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.AButtonTelefonos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.AButtonTelefonos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.AButtonTelefonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AButtonTelefonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AButtonTelefonos.Location = New System.Drawing.Point(383, 67)
        Me.AButtonTelefonos.Name = "AButtonTelefonos"
        Me.AButtonTelefonos.Size = New System.Drawing.Size(99, 26)
        Me.AButtonTelefonos.TabIndex = 12
        Me.AButtonTelefonos.Text = "&Telefonos"
        Me.AButtonTelefonos.UseVisualStyleBackColor = True
        '
        'ATextBoxCorreo
        '
        Me.ATextBoxCorreo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ATextBoxCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ATextBoxCorreo.Location = New System.Drawing.Point(347, 39)
        Me.ATextBoxCorreo.MaxLength = 40
        Me.ATextBoxCorreo.Name = "ATextBoxCorreo"
        Me.ATextBoxCorreo.Size = New System.Drawing.Size(200, 21)
        Me.ATextBoxCorreo.TabIndex = 11
        '
        'ATextBoxDireccion
        '
        Me.ATextBoxDireccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ATextBoxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ATextBoxDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ATextBoxDireccion.Location = New System.Drawing.Point(347, 13)
        Me.ATextBoxDireccion.MaxLength = 100
        Me.ATextBoxDireccion.Name = "ATextBoxDireccion"
        Me.ATextBoxDireccion.Size = New System.Drawing.Size(200, 21)
        Me.ATextBoxDireccion.TabIndex = 10
        '
        'ATextBoxApellido
        '
        Me.ATextBoxApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ATextBoxApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ATextBoxApellido.Location = New System.Drawing.Point(68, 94)
        Me.ATextBoxApellido.MaxLength = 50
        Me.ATextBoxApellido.Name = "ATextBoxApellido"
        Me.ATextBoxApellido.Size = New System.Drawing.Size(200, 21)
        Me.ATextBoxApellido.TabIndex = 9
        '
        'ATextBoxNombre
        '
        Me.ATextBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ATextBoxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ATextBoxNombre.Location = New System.Drawing.Point(68, 67)
        Me.ATextBoxNombre.MaxLength = 50
        Me.ATextBoxNombre.Name = "ATextBoxNombre"
        Me.ATextBoxNombre.Size = New System.Drawing.Size(200, 21)
        Me.ATextBoxNombre.TabIndex = 8
        '
        'AMaskedTextBoxCuit
        '
        Me.AMaskedTextBoxCuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AMaskedTextBoxCuit.Location = New System.Drawing.Point(68, 39)
        Me.AMaskedTextBoxCuit.Mask = "00-00000000-0"
        Me.AMaskedTextBoxCuit.Name = "AMaskedTextBoxCuit"
        Me.AMaskedTextBoxCuit.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.AMaskedTextBoxCuit.Size = New System.Drawing.Size(130, 21)
        Me.AMaskedTextBoxCuit.TabIndex = 7
        Me.AMaskedTextBoxCuit.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'AMaskedTextBoxDni
        '
        Me.AMaskedTextBoxDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AMaskedTextBoxDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AMaskedTextBoxDni.Location = New System.Drawing.Point(68, 13)
        Me.AMaskedTextBoxDni.Mask = "00,000,000"
        Me.AMaskedTextBoxDni.Name = "AMaskedTextBoxDni"
        Me.AMaskedTextBoxDni.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.AMaskedTextBoxDni.Size = New System.Drawing.Size(130, 21)
        Me.AMaskedTextBoxDni.TabIndex = 6
        Me.AMaskedTextBoxDni.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'ALabelCorreo
        '
        Me.ALabelCorreo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ALabelCorreo.AutoSize = True
        Me.ALabelCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALabelCorreo.Location = New System.Drawing.Point(286, 42)
        Me.ALabelCorreo.Name = "ALabelCorreo"
        Me.ALabelCorreo.Size = New System.Drawing.Size(47, 15)
        Me.ALabelCorreo.TabIndex = 5
        Me.ALabelCorreo.Text = "Correo:"
        '
        'ALabelDireccion
        '
        Me.ALabelDireccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ALabelDireccion.AutoSize = True
        Me.ALabelDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALabelDireccion.Location = New System.Drawing.Point(286, 16)
        Me.ALabelDireccion.Name = "ALabelDireccion"
        Me.ALabelDireccion.Size = New System.Drawing.Size(62, 15)
        Me.ALabelDireccion.TabIndex = 4
        Me.ALabelDireccion.Text = "Dirección:"
        '
        'ALabelApellido
        '
        Me.ALabelApellido.AutoSize = True
        Me.ALabelApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALabelApellido.Location = New System.Drawing.Point(13, 97)
        Me.ALabelApellido.Name = "ALabelApellido"
        Me.ALabelApellido.Size = New System.Drawing.Size(54, 15)
        Me.ALabelApellido.TabIndex = 3
        Me.ALabelApellido.Text = "Apellido:"
        '
        'ALabelNombre
        '
        Me.ALabelNombre.AutoSize = True
        Me.ALabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALabelNombre.Location = New System.Drawing.Point(13, 70)
        Me.ALabelNombre.Name = "ALabelNombre"
        Me.ALabelNombre.Size = New System.Drawing.Size(55, 15)
        Me.ALabelNombre.TabIndex = 2
        Me.ALabelNombre.Text = "Nombre:"
        '
        'ALabelCuit
        '
        Me.ALabelCuit.AutoSize = True
        Me.ALabelCuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALabelCuit.Location = New System.Drawing.Point(13, 42)
        Me.ALabelCuit.Name = "ALabelCuit"
        Me.ALabelCuit.Size = New System.Drawing.Size(37, 15)
        Me.ALabelCuit.TabIndex = 1
        Me.ALabelCuit.Text = "CUIT:"
        '
        'ALabelDni
        '
        Me.ALabelDni.AutoSize = True
        Me.ALabelDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALabelDni.Location = New System.Drawing.Point(13, 16)
        Me.ALabelDni.Name = "ALabelDni"
        Me.ALabelDni.Size = New System.Drawing.Size(31, 15)
        Me.ALabelDni.TabIndex = 0
        Me.ALabelDni.Text = "DNI:"
        '
        'ADataGridViewPer
        '
        Me.ADataGridViewPer.AllowUserToAddRows = False
        Me.ADataGridViewPer.AllowUserToDeleteRows = False
        Me.ADataGridViewPer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ADataGridViewPer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ADataGridViewPer.Location = New System.Drawing.Point(0, 0)
        Me.ADataGridViewPer.MultiSelect = False
        Me.ADataGridViewPer.Name = "ADataGridViewPer"
        Me.ADataGridViewPer.ReadOnly = True
        Me.ADataGridViewPer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ADataGridViewPer.Size = New System.Drawing.Size(671, 264)
        Me.ADataGridViewPer.TabIndex = 0
        '
        'TabPageModificar
        '
        Me.TabPageModificar.Controls.Add(Me.MSplitContainer)
        Me.TabPageModificar.Location = New System.Drawing.Point(4, 24)
        Me.TabPageModificar.Name = "TabPageModificar"
        Me.TabPageModificar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageModificar.Size = New System.Drawing.Size(681, 418)
        Me.TabPageModificar.TabIndex = 1
        Me.TabPageModificar.Text = "Ver/Modificar"
        Me.TabPageModificar.UseVisualStyleBackColor = True
        '
        'MSplitContainer
        '
        Me.MSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.MSplitContainer.IsSplitterFixed = True
        Me.MSplitContainer.Location = New System.Drawing.Point(3, 3)
        Me.MSplitContainer.Name = "MSplitContainer"
        Me.MSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'MSplitContainer.Panel1
        '
        Me.MSplitContainer.Panel1.Controls.Add(Me.MButtonCancelar)
        Me.MSplitContainer.Panel1.Controls.Add(Me.MButtonModificar)
        Me.MSplitContainer.Panel1.Controls.Add(Me.MButtonTelefonos)
        Me.MSplitContainer.Panel1.Controls.Add(Me.MTextBoxCorreo)
        Me.MSplitContainer.Panel1.Controls.Add(Me.MTextBoxDireccion)
        Me.MSplitContainer.Panel1.Controls.Add(Me.MTextBoxApellido)
        Me.MSplitContainer.Panel1.Controls.Add(Me.MTextBoxNombre)
        Me.MSplitContainer.Panel1.Controls.Add(Me.MMaskedTextBoxCuit)
        Me.MSplitContainer.Panel1.Controls.Add(Me.MMaskedTextBoxDni)
        Me.MSplitContainer.Panel1.Controls.Add(Me.MLabelCorreo)
        Me.MSplitContainer.Panel1.Controls.Add(Me.MLabelDireccion)
        Me.MSplitContainer.Panel1.Controls.Add(Me.MLabelApellido)
        Me.MSplitContainer.Panel1.Controls.Add(Me.MLabelNombre)
        Me.MSplitContainer.Panel1.Controls.Add(Me.MLabelCuit)
        Me.MSplitContainer.Panel1.Controls.Add(Me.MLabelDni)
        '
        'MSplitContainer.Panel2
        '
        Me.MSplitContainer.Panel2.Controls.Add(Me.MDataGridViewPer)
        Me.MSplitContainer.Size = New System.Drawing.Size(675, 412)
        Me.MSplitContainer.SplitterDistance = 140
        Me.MSplitContainer.TabIndex = 1
        '
        'MButtonCancelar
        '
        Me.MButtonCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MButtonCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.MButtonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink
        Me.MButtonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink
        Me.MButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MButtonCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MButtonCancelar.Location = New System.Drawing.Point(568, 73)
        Me.MButtonCancelar.Name = "MButtonCancelar"
        Me.MButtonCancelar.Size = New System.Drawing.Size(88, 26)
        Me.MButtonCancelar.TabIndex = 14
        Me.MButtonCancelar.Text = "Cancelar"
        Me.MButtonCancelar.UseVisualStyleBackColor = True
        '
        'MButtonModificar
        '
        Me.MButtonModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MButtonModificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.MButtonModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.MButtonModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.MButtonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MButtonModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MButtonModificar.Location = New System.Drawing.Point(568, 34)
        Me.MButtonModificar.Name = "MButtonModificar"
        Me.MButtonModificar.Size = New System.Drawing.Size(88, 26)
        Me.MButtonModificar.TabIndex = 13
        Me.MButtonModificar.Text = "Modificar"
        Me.MButtonModificar.UseVisualStyleBackColor = True
        '
        'MButtonTelefonos
        '
        Me.MButtonTelefonos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MButtonTelefonos.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.MButtonTelefonos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.MButtonTelefonos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.MButtonTelefonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MButtonTelefonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MButtonTelefonos.Location = New System.Drawing.Point(383, 67)
        Me.MButtonTelefonos.Name = "MButtonTelefonos"
        Me.MButtonTelefonos.Size = New System.Drawing.Size(99, 26)
        Me.MButtonTelefonos.TabIndex = 12
        Me.MButtonTelefonos.Text = "&Telefonos"
        Me.MButtonTelefonos.UseVisualStyleBackColor = True
        '
        'MTextBoxCorreo
        '
        Me.MTextBoxCorreo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MTextBoxCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTextBoxCorreo.Location = New System.Drawing.Point(347, 39)
        Me.MTextBoxCorreo.MaxLength = 40
        Me.MTextBoxCorreo.Name = "MTextBoxCorreo"
        Me.MTextBoxCorreo.Size = New System.Drawing.Size(200, 21)
        Me.MTextBoxCorreo.TabIndex = 11
        '
        'MTextBoxDireccion
        '
        Me.MTextBoxDireccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MTextBoxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MTextBoxDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTextBoxDireccion.Location = New System.Drawing.Point(347, 13)
        Me.MTextBoxDireccion.MaxLength = 100
        Me.MTextBoxDireccion.Name = "MTextBoxDireccion"
        Me.MTextBoxDireccion.Size = New System.Drawing.Size(200, 21)
        Me.MTextBoxDireccion.TabIndex = 10
        '
        'MTextBoxApellido
        '
        Me.MTextBoxApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MTextBoxApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTextBoxApellido.Location = New System.Drawing.Point(68, 94)
        Me.MTextBoxApellido.MaxLength = 50
        Me.MTextBoxApellido.Name = "MTextBoxApellido"
        Me.MTextBoxApellido.Size = New System.Drawing.Size(200, 21)
        Me.MTextBoxApellido.TabIndex = 9
        '
        'MTextBoxNombre
        '
        Me.MTextBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MTextBoxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTextBoxNombre.Location = New System.Drawing.Point(68, 67)
        Me.MTextBoxNombre.MaxLength = 50
        Me.MTextBoxNombre.Name = "MTextBoxNombre"
        Me.MTextBoxNombre.Size = New System.Drawing.Size(200, 21)
        Me.MTextBoxNombre.TabIndex = 8
        '
        'MMaskedTextBoxCuit
        '
        Me.MMaskedTextBoxCuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MMaskedTextBoxCuit.Location = New System.Drawing.Point(68, 39)
        Me.MMaskedTextBoxCuit.Mask = "00-00000000-0"
        Me.MMaskedTextBoxCuit.Name = "MMaskedTextBoxCuit"
        Me.MMaskedTextBoxCuit.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MMaskedTextBoxCuit.Size = New System.Drawing.Size(130, 21)
        Me.MMaskedTextBoxCuit.TabIndex = 7
        Me.MMaskedTextBoxCuit.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'MMaskedTextBoxDni
        '
        Me.MMaskedTextBoxDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MMaskedTextBoxDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MMaskedTextBoxDni.Location = New System.Drawing.Point(68, 13)
        Me.MMaskedTextBoxDni.Mask = "00,000,000"
        Me.MMaskedTextBoxDni.Name = "MMaskedTextBoxDni"
        Me.MMaskedTextBoxDni.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MMaskedTextBoxDni.Size = New System.Drawing.Size(130, 21)
        Me.MMaskedTextBoxDni.TabIndex = 6
        Me.MMaskedTextBoxDni.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'MLabelCorreo
        '
        Me.MLabelCorreo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MLabelCorreo.AutoSize = True
        Me.MLabelCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MLabelCorreo.Location = New System.Drawing.Point(286, 42)
        Me.MLabelCorreo.Name = "MLabelCorreo"
        Me.MLabelCorreo.Size = New System.Drawing.Size(47, 15)
        Me.MLabelCorreo.TabIndex = 5
        Me.MLabelCorreo.Text = "Correo:"
        '
        'MLabelDireccion
        '
        Me.MLabelDireccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MLabelDireccion.AutoSize = True
        Me.MLabelDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MLabelDireccion.Location = New System.Drawing.Point(286, 16)
        Me.MLabelDireccion.Name = "MLabelDireccion"
        Me.MLabelDireccion.Size = New System.Drawing.Size(62, 15)
        Me.MLabelDireccion.TabIndex = 4
        Me.MLabelDireccion.Text = "Dirección:"
        '
        'MLabelApellido
        '
        Me.MLabelApellido.AutoSize = True
        Me.MLabelApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MLabelApellido.Location = New System.Drawing.Point(13, 97)
        Me.MLabelApellido.Name = "MLabelApellido"
        Me.MLabelApellido.Size = New System.Drawing.Size(54, 15)
        Me.MLabelApellido.TabIndex = 3
        Me.MLabelApellido.Text = "Apellido:"
        '
        'MLabelNombre
        '
        Me.MLabelNombre.AutoSize = True
        Me.MLabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MLabelNombre.Location = New System.Drawing.Point(13, 70)
        Me.MLabelNombre.Name = "MLabelNombre"
        Me.MLabelNombre.Size = New System.Drawing.Size(55, 15)
        Me.MLabelNombre.TabIndex = 2
        Me.MLabelNombre.Text = "Nombre:"
        '
        'MLabelCuit
        '
        Me.MLabelCuit.AutoSize = True
        Me.MLabelCuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MLabelCuit.Location = New System.Drawing.Point(13, 42)
        Me.MLabelCuit.Name = "MLabelCuit"
        Me.MLabelCuit.Size = New System.Drawing.Size(37, 15)
        Me.MLabelCuit.TabIndex = 1
        Me.MLabelCuit.Text = "CUIT:"
        '
        'MLabelDni
        '
        Me.MLabelDni.AutoSize = True
        Me.MLabelDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MLabelDni.Location = New System.Drawing.Point(13, 16)
        Me.MLabelDni.Name = "MLabelDni"
        Me.MLabelDni.Size = New System.Drawing.Size(31, 15)
        Me.MLabelDni.TabIndex = 0
        Me.MLabelDni.Text = "DNI:"
        '
        'MDataGridViewPer
        '
        Me.MDataGridViewPer.AllowUserToAddRows = False
        Me.MDataGridViewPer.AllowUserToDeleteRows = False
        Me.MDataGridViewPer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MDataGridViewPer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MDataGridViewPer.Location = New System.Drawing.Point(0, 0)
        Me.MDataGridViewPer.MultiSelect = False
        Me.MDataGridViewPer.Name = "MDataGridViewPer"
        Me.MDataGridViewPer.ReadOnly = True
        Me.MDataGridViewPer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MDataGridViewPer.Size = New System.Drawing.Size(671, 264)
        Me.MDataGridViewPer.TabIndex = 0
        '
        'TabPageBaja
        '
        Me.TabPageBaja.Controls.Add(Me.BSplitContainer)
        Me.TabPageBaja.Location = New System.Drawing.Point(4, 24)
        Me.TabPageBaja.Name = "TabPageBaja"
        Me.TabPageBaja.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageBaja.Size = New System.Drawing.Size(681, 418)
        Me.TabPageBaja.TabIndex = 2
        Me.TabPageBaja.Text = "Baja"
        Me.TabPageBaja.UseVisualStyleBackColor = True
        '
        'BSplitContainer
        '
        Me.BSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.BSplitContainer.IsSplitterFixed = True
        Me.BSplitContainer.Location = New System.Drawing.Point(3, 3)
        Me.BSplitContainer.Name = "BSplitContainer"
        Me.BSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'BSplitContainer.Panel1
        '
        Me.BSplitContainer.Panel1.Controls.Add(Me.BButtonContratos)
        Me.BSplitContainer.Panel1.Controls.Add(Me.BButtonBaja)
        Me.BSplitContainer.Panel1.Controls.Add(Me.BButtonCancelar)
        Me.BSplitContainer.Panel1.Controls.Add(Me.BTextBoxDireccion)
        Me.BSplitContainer.Panel1.Controls.Add(Me.BTextBoxApellido)
        Me.BSplitContainer.Panel1.Controls.Add(Me.BTextBoxNombre)
        Me.BSplitContainer.Panel1.Controls.Add(Me.BMaskedTextBoxDni)
        Me.BSplitContainer.Panel1.Controls.Add(Me.BLabelDireccion)
        Me.BSplitContainer.Panel1.Controls.Add(Me.BLabelApellido)
        Me.BSplitContainer.Panel1.Controls.Add(Me.BLabelNombre)
        Me.BSplitContainer.Panel1.Controls.Add(Me.BLabelDni)
        '
        'BSplitContainer.Panel2
        '
        Me.BSplitContainer.Panel2.Controls.Add(Me.BDataGridViewPer)
        Me.BSplitContainer.Size = New System.Drawing.Size(675, 412)
        Me.BSplitContainer.SplitterDistance = 140
        Me.BSplitContainer.TabIndex = 1
        '
        'BButtonContratos
        '
        Me.BButtonContratos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BButtonContratos.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.BButtonContratos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.BButtonContratos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.BButtonContratos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BButtonContratos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BButtonContratos.Location = New System.Drawing.Point(443, 16)
        Me.BButtonContratos.Name = "BButtonContratos"
        Me.BButtonContratos.Size = New System.Drawing.Size(99, 26)
        Me.BButtonContratos.TabIndex = 14
        Me.BButtonContratos.Text = "Contratos"
        Me.BButtonContratos.UseVisualStyleBackColor = True
        '
        'BButtonBaja
        '
        Me.BButtonBaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BButtonBaja.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.BButtonBaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.BButtonBaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.BButtonBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BButtonBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BButtonBaja.Location = New System.Drawing.Point(443, 55)
        Me.BButtonBaja.Name = "BButtonBaja"
        Me.BButtonBaja.Size = New System.Drawing.Size(99, 26)
        Me.BButtonBaja.TabIndex = 15
        Me.BButtonBaja.Text = "Baja"
        Me.BButtonBaja.UseVisualStyleBackColor = True
        '
        'BButtonCancelar
        '
        Me.BButtonCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BButtonCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.BButtonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink
        Me.BButtonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink
        Me.BButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BButtonCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BButtonCancelar.Location = New System.Drawing.Point(443, 96)
        Me.BButtonCancelar.Name = "BButtonCancelar"
        Me.BButtonCancelar.Size = New System.Drawing.Size(99, 26)
        Me.BButtonCancelar.TabIndex = 16
        Me.BButtonCancelar.Text = "Cancelar"
        Me.BButtonCancelar.UseVisualStyleBackColor = True
        '
        'BTextBoxDireccion
        '
        Me.BTextBoxDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTextBoxDireccion.Location = New System.Drawing.Point(81, 94)
        Me.BTextBoxDireccion.MaxLength = 100
        Me.BTextBoxDireccion.Name = "BTextBoxDireccion"
        Me.BTextBoxDireccion.ReadOnly = True
        Me.BTextBoxDireccion.Size = New System.Drawing.Size(200, 21)
        Me.BTextBoxDireccion.TabIndex = 10
        Me.BTextBoxDireccion.TabStop = False
        '
        'BTextBoxApellido
        '
        Me.BTextBoxApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTextBoxApellido.Location = New System.Drawing.Point(81, 70)
        Me.BTextBoxApellido.MaxLength = 50
        Me.BTextBoxApellido.Name = "BTextBoxApellido"
        Me.BTextBoxApellido.ReadOnly = True
        Me.BTextBoxApellido.Size = New System.Drawing.Size(201, 21)
        Me.BTextBoxApellido.TabIndex = 9
        Me.BTextBoxApellido.TabStop = False
        '
        'BTextBoxNombre
        '
        Me.BTextBoxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTextBoxNombre.Location = New System.Drawing.Point(82, 43)
        Me.BTextBoxNombre.MaxLength = 50
        Me.BTextBoxNombre.Name = "BTextBoxNombre"
        Me.BTextBoxNombre.ReadOnly = True
        Me.BTextBoxNombre.Size = New System.Drawing.Size(200, 21)
        Me.BTextBoxNombre.TabIndex = 8
        Me.BTextBoxNombre.TabStop = False
        '
        'BMaskedTextBoxDni
        '
        Me.BMaskedTextBoxDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BMaskedTextBoxDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BMaskedTextBoxDni.Location = New System.Drawing.Point(82, 13)
        Me.BMaskedTextBoxDni.Mask = "00,000,000"
        Me.BMaskedTextBoxDni.Name = "BMaskedTextBoxDni"
        Me.BMaskedTextBoxDni.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BMaskedTextBoxDni.Size = New System.Drawing.Size(130, 21)
        Me.BMaskedTextBoxDni.TabIndex = 6
        Me.BMaskedTextBoxDni.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'BLabelDireccion
        '
        Me.BLabelDireccion.AutoSize = True
        Me.BLabelDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLabelDireccion.Location = New System.Drawing.Point(14, 97)
        Me.BLabelDireccion.Name = "BLabelDireccion"
        Me.BLabelDireccion.Size = New System.Drawing.Size(62, 15)
        Me.BLabelDireccion.TabIndex = 4
        Me.BLabelDireccion.Text = "Dirección:"
        '
        'BLabelApellido
        '
        Me.BLabelApellido.AutoSize = True
        Me.BLabelApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLabelApellido.Location = New System.Drawing.Point(14, 73)
        Me.BLabelApellido.Name = "BLabelApellido"
        Me.BLabelApellido.Size = New System.Drawing.Size(54, 15)
        Me.BLabelApellido.TabIndex = 3
        Me.BLabelApellido.Text = "Apellido:"
        '
        'BLabelNombre
        '
        Me.BLabelNombre.AutoSize = True
        Me.BLabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLabelNombre.Location = New System.Drawing.Point(14, 46)
        Me.BLabelNombre.Name = "BLabelNombre"
        Me.BLabelNombre.Size = New System.Drawing.Size(55, 15)
        Me.BLabelNombre.TabIndex = 2
        Me.BLabelNombre.Text = "Nombre:"
        '
        'BLabelDni
        '
        Me.BLabelDni.AutoSize = True
        Me.BLabelDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLabelDni.Location = New System.Drawing.Point(14, 16)
        Me.BLabelDni.Name = "BLabelDni"
        Me.BLabelDni.Size = New System.Drawing.Size(31, 15)
        Me.BLabelDni.TabIndex = 0
        Me.BLabelDni.Text = "DNI:"
        '
        'BDataGridViewPer
        '
        Me.BDataGridViewPer.AllowUserToAddRows = False
        Me.BDataGridViewPer.AllowUserToDeleteRows = False
        Me.BDataGridViewPer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BDataGridViewPer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BDataGridViewPer.Location = New System.Drawing.Point(0, 0)
        Me.BDataGridViewPer.MultiSelect = False
        Me.BDataGridViewPer.Name = "BDataGridViewPer"
        Me.BDataGridViewPer.ReadOnly = True
        Me.BDataGridViewPer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BDataGridViewPer.Size = New System.Drawing.Size(671, 264)
        Me.BDataGridViewPer.TabIndex = 0
        '
        'pPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControlPersonal)
        Me.Name = "pPersonal"
        Me.Size = New System.Drawing.Size(689, 446)
        Me.TabControlPersonal.ResumeLayout(False)
        Me.TabPageAlta.ResumeLayout(False)
        Me.ASplitContainer.Panel1.ResumeLayout(False)
        Me.ASplitContainer.Panel1.PerformLayout()
        Me.ASplitContainer.Panel2.ResumeLayout(False)
        CType(Me.ASplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ASplitContainer.ResumeLayout(False)
        CType(Me.ADataGridViewPer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageModificar.ResumeLayout(False)
        Me.MSplitContainer.Panel1.ResumeLayout(False)
        Me.MSplitContainer.Panel1.PerformLayout()
        Me.MSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.MSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MSplitContainer.ResumeLayout(False)
        CType(Me.MDataGridViewPer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageBaja.ResumeLayout(False)
        Me.BSplitContainer.Panel1.ResumeLayout(False)
        Me.BSplitContainer.Panel1.PerformLayout()
        Me.BSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.BSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BSplitContainer.ResumeLayout(False)
        CType(Me.BDataGridViewPer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControlPersonal As System.Windows.Forms.TabControl
    Friend WithEvents TabPageAlta As System.Windows.Forms.TabPage
    Friend WithEvents TabPageModificar As System.Windows.Forms.TabPage
    Friend WithEvents TabPageBaja As System.Windows.Forms.TabPage
    Friend WithEvents ASplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents ATextBoxDireccion As System.Windows.Forms.TextBox
    Friend WithEvents ATextBoxApellido As System.Windows.Forms.TextBox
    Friend WithEvents ATextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents AMaskedTextBoxCuit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents AMaskedTextBoxDni As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ALabelCorreo As System.Windows.Forms.Label
    Friend WithEvents ALabelDireccion As System.Windows.Forms.Label
    Friend WithEvents ALabelApellido As System.Windows.Forms.Label
    Friend WithEvents ALabelNombre As System.Windows.Forms.Label
    Friend WithEvents ALabelCuit As System.Windows.Forms.Label
    Friend WithEvents ALabelDni As System.Windows.Forms.Label
    Friend WithEvents ATextBoxCorreo As System.Windows.Forms.TextBox
    Friend WithEvents AButtonCancelar As System.Windows.Forms.Button
    Friend WithEvents AButtonAceptar As System.Windows.Forms.Button
    Friend WithEvents AButtonTelefonos As System.Windows.Forms.Button
    Friend WithEvents ADataGridViewPer As System.Windows.Forms.DataGridView
    Friend WithEvents AButtonReactivar As System.Windows.Forms.Button
    Friend WithEvents BSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents BButtonBaja As System.Windows.Forms.Button
    Friend WithEvents BButtonCancelar As System.Windows.Forms.Button
    Friend WithEvents BTextBoxDireccion As System.Windows.Forms.TextBox
    Friend WithEvents BTextBoxApellido As System.Windows.Forms.TextBox
    Friend WithEvents BTextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents BMaskedTextBoxDni As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BLabelDireccion As System.Windows.Forms.Label
    Friend WithEvents BLabelApellido As System.Windows.Forms.Label
    Friend WithEvents BLabelNombre As System.Windows.Forms.Label
    Friend WithEvents BLabelDni As System.Windows.Forms.Label
    Friend WithEvents BDataGridViewPer As System.Windows.Forms.DataGridView
    Friend WithEvents BButtonContratos As System.Windows.Forms.Button
    Friend WithEvents MSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents MButtonCancelar As System.Windows.Forms.Button
    Friend WithEvents MButtonModificar As System.Windows.Forms.Button
    Friend WithEvents MButtonTelefonos As System.Windows.Forms.Button
    Friend WithEvents MTextBoxCorreo As System.Windows.Forms.TextBox
    Friend WithEvents MTextBoxDireccion As System.Windows.Forms.TextBox
    Friend WithEvents MTextBoxApellido As System.Windows.Forms.TextBox
    Friend WithEvents MTextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents MMaskedTextBoxCuit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MMaskedTextBoxDni As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MLabelCorreo As System.Windows.Forms.Label
    Friend WithEvents MLabelDireccion As System.Windows.Forms.Label
    Friend WithEvents MLabelApellido As System.Windows.Forms.Label
    Friend WithEvents MLabelNombre As System.Windows.Forms.Label
    Friend WithEvents MLabelCuit As System.Windows.Forms.Label
    Friend WithEvents MLabelDni As System.Windows.Forms.Label
    Friend WithEvents MDataGridViewPer As System.Windows.Forms.DataGridView

End Class
