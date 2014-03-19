<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pEquipos
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
        Me.AComboBoxCoordinador = New System.Windows.Forms.ComboBox()
        Me.ALabelCoordinador = New System.Windows.Forms.Label()
        Me.AMaskedTextBoxTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.ALabelTelefono = New System.Windows.Forms.Label()
        Me.AComboBoxLocalidad = New System.Windows.Forms.ComboBox()
        Me.ALabelLocalidad = New System.Windows.Forms.Label()
        Me.AButtonCancelar = New System.Windows.Forms.Button()
        Me.AButtonAceptar = New System.Windows.Forms.Button()
        Me.ATextBoxCorreo = New System.Windows.Forms.TextBox()
        Me.ATextBoxContra = New System.Windows.Forms.TextBox()
        Me.ATextBoxUbicacion = New System.Windows.Forms.TextBox()
        Me.ATextBoxNombre = New System.Windows.Forms.TextBox()
        Me.ALabelCorreo = New System.Windows.Forms.Label()
        Me.ALabelContra = New System.Windows.Forms.Label()
        Me.ALabelUbicacion = New System.Windows.Forms.Label()
        Me.ALabelNombre = New System.Windows.Forms.Label()
        Me.ADataGridViewEquipos = New System.Windows.Forms.DataGridView()
        Me.TabPageModificar = New System.Windows.Forms.TabPage()
        Me.MSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.MButtonCancelar = New System.Windows.Forms.Button()
        Me.MButtonModificar = New System.Windows.Forms.Button()
        Me.MDataGridViewEquipos = New System.Windows.Forms.DataGridView()
        Me.TabPageBaja = New System.Windows.Forms.TabPage()
        Me.BSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.BButtonBaja = New System.Windows.Forms.Button()
        Me.BButtonCancelar = New System.Windows.Forms.Button()
        Me.BDataGridViewEquipos = New System.Windows.Forms.DataGridView()
        Me.TabControlPersonal.SuspendLayout()
        Me.TabPageAlta.SuspendLayout()
        CType(Me.ASplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ASplitContainer.Panel1.SuspendLayout()
        Me.ASplitContainer.Panel2.SuspendLayout()
        Me.ASplitContainer.SuspendLayout()
        CType(Me.ADataGridViewEquipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageModificar.SuspendLayout()
        CType(Me.MSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MSplitContainer.Panel1.SuspendLayout()
        Me.MSplitContainer.Panel2.SuspendLayout()
        Me.MSplitContainer.SuspendLayout()
        CType(Me.MDataGridViewEquipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageBaja.SuspendLayout()
        CType(Me.BSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BSplitContainer.Panel1.SuspendLayout()
        Me.BSplitContainer.Panel2.SuspendLayout()
        Me.BSplitContainer.SuspendLayout()
        CType(Me.BDataGridViewEquipos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControlPersonal.TabIndex = 1
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
        Me.ASplitContainer.Panel1.Controls.Add(Me.AComboBoxCoordinador)
        Me.ASplitContainer.Panel1.Controls.Add(Me.ALabelCoordinador)
        Me.ASplitContainer.Panel1.Controls.Add(Me.AMaskedTextBoxTelefono)
        Me.ASplitContainer.Panel1.Controls.Add(Me.ALabelTelefono)
        Me.ASplitContainer.Panel1.Controls.Add(Me.AComboBoxLocalidad)
        Me.ASplitContainer.Panel1.Controls.Add(Me.ALabelLocalidad)
        Me.ASplitContainer.Panel1.Controls.Add(Me.AButtonCancelar)
        Me.ASplitContainer.Panel1.Controls.Add(Me.AButtonAceptar)
        Me.ASplitContainer.Panel1.Controls.Add(Me.ATextBoxCorreo)
        Me.ASplitContainer.Panel1.Controls.Add(Me.ATextBoxContra)
        Me.ASplitContainer.Panel1.Controls.Add(Me.ATextBoxUbicacion)
        Me.ASplitContainer.Panel1.Controls.Add(Me.ATextBoxNombre)
        Me.ASplitContainer.Panel1.Controls.Add(Me.ALabelCorreo)
        Me.ASplitContainer.Panel1.Controls.Add(Me.ALabelContra)
        Me.ASplitContainer.Panel1.Controls.Add(Me.ALabelUbicacion)
        Me.ASplitContainer.Panel1.Controls.Add(Me.ALabelNombre)
        '
        'ASplitContainer.Panel2
        '
        Me.ASplitContainer.Panel2.Controls.Add(Me.ADataGridViewEquipos)
        Me.ASplitContainer.Size = New System.Drawing.Size(675, 412)
        Me.ASplitContainer.SplitterDistance = 140
        Me.ASplitContainer.TabIndex = 0
        '
        'AComboBoxCoordinador
        '
        Me.AComboBoxCoordinador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AComboBoxCoordinador.FormattingEnabled = True
        Me.AComboBoxCoordinador.Location = New System.Drawing.Point(357, 97)
        Me.AComboBoxCoordinador.Name = "AComboBoxCoordinador"
        Me.AComboBoxCoordinador.Size = New System.Drawing.Size(200, 23)
        Me.AComboBoxCoordinador.TabIndex = 14
        '
        'ALabelCoordinador
        '
        Me.ALabelCoordinador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ALabelCoordinador.AutoSize = True
        Me.ALabelCoordinador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALabelCoordinador.Location = New System.Drawing.Point(273, 101)
        Me.ALabelCoordinador.Name = "ALabelCoordinador"
        Me.ALabelCoordinador.Size = New System.Drawing.Size(78, 15)
        Me.ALabelCoordinador.TabIndex = 13
        Me.ALabelCoordinador.Text = "Coordinador:"
        '
        'AMaskedTextBoxTelefono
        '
        Me.AMaskedTextBoxTelefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AMaskedTextBoxTelefono.Location = New System.Drawing.Point(357, 70)
        Me.AMaskedTextBoxTelefono.Mask = "(999) 000-0000"
        Me.AMaskedTextBoxTelefono.Name = "AMaskedTextBoxTelefono"
        Me.AMaskedTextBoxTelefono.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.AMaskedTextBoxTelefono.Size = New System.Drawing.Size(200, 21)
        Me.AMaskedTextBoxTelefono.TabIndex = 12
        Me.AMaskedTextBoxTelefono.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'ALabelTelefono
        '
        Me.ALabelTelefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ALabelTelefono.AutoSize = True
        Me.ALabelTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALabelTelefono.Location = New System.Drawing.Point(286, 73)
        Me.ALabelTelefono.Name = "ALabelTelefono"
        Me.ALabelTelefono.Size = New System.Drawing.Size(58, 15)
        Me.ALabelTelefono.TabIndex = 11
        Me.ALabelTelefono.Text = "Teléfono:"
        '
        'AComboBoxLocalidad
        '
        Me.AComboBoxLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.AComboBoxLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.AComboBoxLocalidad.FormattingEnabled = True
        Me.AComboBoxLocalidad.Location = New System.Drawing.Point(77, 70)
        Me.AComboBoxLocalidad.Name = "AComboBoxLocalidad"
        Me.AComboBoxLocalidad.Size = New System.Drawing.Size(200, 23)
        Me.AComboBoxLocalidad.TabIndex = 6
        '
        'ALabelLocalidad
        '
        Me.ALabelLocalidad.AutoSize = True
        Me.ALabelLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALabelLocalidad.Location = New System.Drawing.Point(9, 73)
        Me.ALabelLocalidad.Name = "ALabelLocalidad"
        Me.ALabelLocalidad.Size = New System.Drawing.Size(64, 15)
        Me.ALabelLocalidad.TabIndex = 5
        Me.ALabelLocalidad.Text = "Localidad:"
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
        Me.AButtonCancelar.TabIndex = 16
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
        Me.AButtonAceptar.TabIndex = 15
        Me.AButtonAceptar.Text = "Aceptar"
        Me.AButtonAceptar.UseVisualStyleBackColor = True
        '
        'ATextBoxCorreo
        '
        Me.ATextBoxCorreo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ATextBoxCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ATextBoxCorreo.Location = New System.Drawing.Point(357, 14)
        Me.ATextBoxCorreo.MaxLength = 30
        Me.ATextBoxCorreo.Name = "ATextBoxCorreo"
        Me.ATextBoxCorreo.Size = New System.Drawing.Size(200, 21)
        Me.ATextBoxCorreo.TabIndex = 8
        '
        'ATextBoxContra
        '
        Me.ATextBoxContra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ATextBoxContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ATextBoxContra.Location = New System.Drawing.Point(357, 44)
        Me.ATextBoxContra.MaxLength = 30
        Me.ATextBoxContra.Name = "ATextBoxContra"
        Me.ATextBoxContra.Size = New System.Drawing.Size(200, 21)
        Me.ATextBoxContra.TabIndex = 10
        '
        'ATextBoxUbicacion
        '
        Me.ATextBoxUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ATextBoxUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ATextBoxUbicacion.Location = New System.Drawing.Point(77, 42)
        Me.ATextBoxUbicacion.MaxLength = 60
        Me.ATextBoxUbicacion.Name = "ATextBoxUbicacion"
        Me.ATextBoxUbicacion.Size = New System.Drawing.Size(200, 21)
        Me.ATextBoxUbicacion.TabIndex = 4
        '
        'ATextBoxNombre
        '
        Me.ATextBoxNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ATextBoxNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ATextBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ATextBoxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ATextBoxNombre.Location = New System.Drawing.Point(77, 15)
        Me.ATextBoxNombre.MaxLength = 20
        Me.ATextBoxNombre.Name = "ATextBoxNombre"
        Me.ATextBoxNombre.Size = New System.Drawing.Size(200, 21)
        Me.ATextBoxNombre.TabIndex = 2
        '
        'ALabelCorreo
        '
        Me.ALabelCorreo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ALabelCorreo.AutoSize = True
        Me.ALabelCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALabelCorreo.Location = New System.Drawing.Point(286, 17)
        Me.ALabelCorreo.Name = "ALabelCorreo"
        Me.ALabelCorreo.Size = New System.Drawing.Size(47, 15)
        Me.ALabelCorreo.TabIndex = 7
        Me.ALabelCorreo.Text = "Correo:"
        '
        'ALabelContra
        '
        Me.ALabelContra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ALabelContra.AutoSize = True
        Me.ALabelContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALabelContra.Location = New System.Drawing.Point(286, 46)
        Me.ALabelContra.Name = "ALabelContra"
        Me.ALabelContra.Size = New System.Drawing.Size(73, 15)
        Me.ALabelContra.TabIndex = 9
        Me.ALabelContra.Text = "Contraseña:"
        '
        'ALabelUbicacion
        '
        Me.ALabelUbicacion.AutoSize = True
        Me.ALabelUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALabelUbicacion.Location = New System.Drawing.Point(9, 44)
        Me.ALabelUbicacion.Name = "ALabelUbicacion"
        Me.ALabelUbicacion.Size = New System.Drawing.Size(65, 15)
        Me.ALabelUbicacion.TabIndex = 3
        Me.ALabelUbicacion.Text = "Ubicación:"
        '
        'ALabelNombre
        '
        Me.ALabelNombre.AutoSize = True
        Me.ALabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALabelNombre.Location = New System.Drawing.Point(9, 17)
        Me.ALabelNombre.Name = "ALabelNombre"
        Me.ALabelNombre.Size = New System.Drawing.Size(55, 15)
        Me.ALabelNombre.TabIndex = 1
        Me.ALabelNombre.Text = "Nombre:"
        '
        'ADataGridViewEquipos
        '
        Me.ADataGridViewEquipos.AllowUserToAddRows = False
        Me.ADataGridViewEquipos.AllowUserToDeleteRows = False
        Me.ADataGridViewEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ADataGridViewEquipos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ADataGridViewEquipos.Location = New System.Drawing.Point(0, 0)
        Me.ADataGridViewEquipos.MultiSelect = False
        Me.ADataGridViewEquipos.Name = "ADataGridViewEquipos"
        Me.ADataGridViewEquipos.ReadOnly = True
        Me.ADataGridViewEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ADataGridViewEquipos.Size = New System.Drawing.Size(671, 264)
        Me.ADataGridViewEquipos.TabIndex = 0
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
        '
        'MSplitContainer.Panel2
        '
        Me.MSplitContainer.Panel2.Controls.Add(Me.MDataGridViewEquipos)
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
        'MDataGridViewEquipos
        '
        Me.MDataGridViewEquipos.AllowUserToAddRows = False
        Me.MDataGridViewEquipos.AllowUserToDeleteRows = False
        Me.MDataGridViewEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MDataGridViewEquipos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MDataGridViewEquipos.Location = New System.Drawing.Point(0, 0)
        Me.MDataGridViewEquipos.MultiSelect = False
        Me.MDataGridViewEquipos.Name = "MDataGridViewEquipos"
        Me.MDataGridViewEquipos.ReadOnly = True
        Me.MDataGridViewEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MDataGridViewEquipos.Size = New System.Drawing.Size(671, 264)
        Me.MDataGridViewEquipos.TabIndex = 0
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
        Me.BSplitContainer.Panel1.Controls.Add(Me.BButtonBaja)
        Me.BSplitContainer.Panel1.Controls.Add(Me.BButtonCancelar)
        '
        'BSplitContainer.Panel2
        '
        Me.BSplitContainer.Panel2.Controls.Add(Me.BDataGridViewEquipos)
        Me.BSplitContainer.Size = New System.Drawing.Size(675, 412)
        Me.BSplitContainer.SplitterDistance = 140
        Me.BSplitContainer.TabIndex = 1
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
        'BDataGridViewEquipos
        '
        Me.BDataGridViewEquipos.AllowUserToAddRows = False
        Me.BDataGridViewEquipos.AllowUserToDeleteRows = False
        Me.BDataGridViewEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BDataGridViewEquipos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BDataGridViewEquipos.Location = New System.Drawing.Point(0, 0)
        Me.BDataGridViewEquipos.MultiSelect = False
        Me.BDataGridViewEquipos.Name = "BDataGridViewEquipos"
        Me.BDataGridViewEquipos.ReadOnly = True
        Me.BDataGridViewEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BDataGridViewEquipos.Size = New System.Drawing.Size(671, 264)
        Me.BDataGridViewEquipos.TabIndex = 0
        '
        'pEquipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControlPersonal)
        Me.Name = "pEquipos"
        Me.Size = New System.Drawing.Size(689, 446)
        Me.TabControlPersonal.ResumeLayout(False)
        Me.TabPageAlta.ResumeLayout(False)
        Me.ASplitContainer.Panel1.ResumeLayout(False)
        Me.ASplitContainer.Panel1.PerformLayout()
        Me.ASplitContainer.Panel2.ResumeLayout(False)
        CType(Me.ASplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ASplitContainer.ResumeLayout(False)
        CType(Me.ADataGridViewEquipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageModificar.ResumeLayout(False)
        Me.MSplitContainer.Panel1.ResumeLayout(False)
        Me.MSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.MSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MSplitContainer.ResumeLayout(False)
        CType(Me.MDataGridViewEquipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageBaja.ResumeLayout(False)
        Me.BSplitContainer.Panel1.ResumeLayout(False)
        Me.BSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.BSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BSplitContainer.ResumeLayout(False)
        CType(Me.BDataGridViewEquipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControlPersonal As System.Windows.Forms.TabControl
    Friend WithEvents TabPageAlta As System.Windows.Forms.TabPage
    Friend WithEvents ASplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents AComboBoxLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents ALabelLocalidad As System.Windows.Forms.Label
    Friend WithEvents AButtonCancelar As System.Windows.Forms.Button
    Friend WithEvents AButtonAceptar As System.Windows.Forms.Button
    Friend WithEvents ATextBoxCorreo As System.Windows.Forms.TextBox
    Friend WithEvents ATextBoxContra As System.Windows.Forms.TextBox
    Friend WithEvents ATextBoxUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents ATextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents ALabelCorreo As System.Windows.Forms.Label
    Friend WithEvents ALabelContra As System.Windows.Forms.Label
    Friend WithEvents ALabelUbicacion As System.Windows.Forms.Label
    Friend WithEvents ALabelNombre As System.Windows.Forms.Label
    Friend WithEvents ADataGridViewEquipos As System.Windows.Forms.DataGridView
    Friend WithEvents TabPageModificar As System.Windows.Forms.TabPage
    Friend WithEvents MSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents MButtonCancelar As System.Windows.Forms.Button
    Friend WithEvents MButtonModificar As System.Windows.Forms.Button
    Friend WithEvents MDataGridViewEquipos As System.Windows.Forms.DataGridView
    Friend WithEvents TabPageBaja As System.Windows.Forms.TabPage
    Friend WithEvents BSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents BButtonBaja As System.Windows.Forms.Button
    Friend WithEvents BButtonCancelar As System.Windows.Forms.Button
    Friend WithEvents BDataGridViewEquipos As System.Windows.Forms.DataGridView
    Friend WithEvents AMaskedTextBoxTelefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ALabelTelefono As System.Windows.Forms.Label
    Friend WithEvents AComboBoxCoordinador As System.Windows.Forms.ComboBox
    Friend WithEvents ALabelCoordinador As System.Windows.Forms.Label

End Class
