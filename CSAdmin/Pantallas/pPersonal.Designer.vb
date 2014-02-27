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
        Me.TabPageModificar = New System.Windows.Forms.TabPage()
        Me.TabPageBaja = New System.Windows.Forms.TabPage()
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.LabelDni = New System.Windows.Forms.Label()
        Me.LabelCuit = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelApellido = New System.Windows.Forms.Label()
        Me.LabelDireccion = New System.Windows.Forms.Label()
        Me.LabelCorreo = New System.Windows.Forms.Label()
        Me.MaskedTextBoxDni = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxCuit = New System.Windows.Forms.MaskedTextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxApellido = New System.Windows.Forms.TextBox()
        Me.TextBoxDireccion = New System.Windows.Forms.TextBox()
        Me.TextBoxCorreo = New System.Windows.Forms.TextBox()
        Me.ButtonTelefonos = New System.Windows.Forms.Button()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonReactivar = New System.Windows.Forms.Button()
        Me.TabControlPersonal.SuspendLayout()
        Me.TabPageAlta.SuspendLayout()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabPageAlta.Controls.Add(Me.SplitContainer)
        Me.TabPageAlta.Location = New System.Drawing.Point(4, 24)
        Me.TabPageAlta.Name = "TabPageAlta"
        Me.TabPageAlta.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAlta.Size = New System.Drawing.Size(681, 418)
        Me.TabPageAlta.TabIndex = 0
        Me.TabPageAlta.Text = "Alta"
        Me.TabPageAlta.UseVisualStyleBackColor = True
        '
        'TabPageModificar
        '
        Me.TabPageModificar.Location = New System.Drawing.Point(4, 22)
        Me.TabPageModificar.Name = "TabPageModificar"
        Me.TabPageModificar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageModificar.Size = New System.Drawing.Size(427, 266)
        Me.TabPageModificar.TabIndex = 1
        Me.TabPageModificar.Text = "Ver/Modificar"
        Me.TabPageModificar.UseVisualStyleBackColor = True
        '
        'TabPageBaja
        '
        Me.TabPageBaja.Location = New System.Drawing.Point(4, 22)
        Me.TabPageBaja.Name = "TabPageBaja"
        Me.TabPageBaja.Size = New System.Drawing.Size(427, 266)
        Me.TabPageBaja.TabIndex = 2
        Me.TabPageBaja.Text = "Baja"
        Me.TabPageBaja.UseVisualStyleBackColor = True
        '
        'SplitContainer
        '
        Me.SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer.IsSplitterFixed = True
        Me.SplitContainer.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer.Name = "SplitContainer"
        Me.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.ButtonReactivar)
        Me.SplitContainer.Panel1.Controls.Add(Me.ButtonCancelar)
        Me.SplitContainer.Panel1.Controls.Add(Me.ButtonAceptar)
        Me.SplitContainer.Panel1.Controls.Add(Me.ButtonTelefonos)
        Me.SplitContainer.Panel1.Controls.Add(Me.TextBoxCorreo)
        Me.SplitContainer.Panel1.Controls.Add(Me.TextBoxDireccion)
        Me.SplitContainer.Panel1.Controls.Add(Me.TextBoxApellido)
        Me.SplitContainer.Panel1.Controls.Add(Me.TextBoxNombre)
        Me.SplitContainer.Panel1.Controls.Add(Me.MaskedTextBoxCuit)
        Me.SplitContainer.Panel1.Controls.Add(Me.MaskedTextBoxDni)
        Me.SplitContainer.Panel1.Controls.Add(Me.LabelCorreo)
        Me.SplitContainer.Panel1.Controls.Add(Me.LabelDireccion)
        Me.SplitContainer.Panel1.Controls.Add(Me.LabelApellido)
        Me.SplitContainer.Panel1.Controls.Add(Me.LabelNombre)
        Me.SplitContainer.Panel1.Controls.Add(Me.LabelCuit)
        Me.SplitContainer.Panel1.Controls.Add(Me.LabelDni)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer.Size = New System.Drawing.Size(675, 412)
        Me.SplitContainer.SplitterDistance = 140
        Me.SplitContainer.TabIndex = 0
        '
        'LabelDni
        '
        Me.LabelDni.AutoSize = True
        Me.LabelDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDni.Location = New System.Drawing.Point(3, 9)
        Me.LabelDni.Name = "LabelDni"
        Me.LabelDni.Size = New System.Drawing.Size(31, 15)
        Me.LabelDni.TabIndex = 0
        Me.LabelDni.Text = "DNI:"
        '
        'LabelCuit
        '
        Me.LabelCuit.AutoSize = True
        Me.LabelCuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCuit.Location = New System.Drawing.Point(3, 39)
        Me.LabelCuit.Name = "LabelCuit"
        Me.LabelCuit.Size = New System.Drawing.Size(37, 15)
        Me.LabelCuit.TabIndex = 1
        Me.LabelCuit.Text = "CUIT:"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.Location = New System.Drawing.Point(3, 63)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(55, 15)
        Me.LabelNombre.TabIndex = 2
        Me.LabelNombre.Text = "Nombre:"
        '
        'LabelApellido
        '
        Me.LabelApellido.AutoSize = True
        Me.LabelApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelApellido.Location = New System.Drawing.Point(3, 90)
        Me.LabelApellido.Name = "LabelApellido"
        Me.LabelApellido.Size = New System.Drawing.Size(54, 15)
        Me.LabelApellido.TabIndex = 3
        Me.LabelApellido.Text = "Apellido:"
        '
        'LabelDireccion
        '
        Me.LabelDireccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelDireccion.AutoSize = True
        Me.LabelDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDireccion.Location = New System.Drawing.Point(284, 9)
        Me.LabelDireccion.Name = "LabelDireccion"
        Me.LabelDireccion.Size = New System.Drawing.Size(62, 15)
        Me.LabelDireccion.TabIndex = 4
        Me.LabelDireccion.Text = "Dirección:"
        '
        'LabelCorreo
        '
        Me.LabelCorreo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCorreo.AutoSize = True
        Me.LabelCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCorreo.Location = New System.Drawing.Point(284, 35)
        Me.LabelCorreo.Name = "LabelCorreo"
        Me.LabelCorreo.Size = New System.Drawing.Size(47, 15)
        Me.LabelCorreo.TabIndex = 5
        Me.LabelCorreo.Text = "Correo:"
        '
        'MaskedTextBoxDni
        '
        Me.MaskedTextBoxDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBoxDni.Location = New System.Drawing.Point(58, 6)
        Me.MaskedTextBoxDni.Mask = "00,000,000"
        Me.MaskedTextBoxDni.Name = "MaskedTextBoxDni"
        Me.MaskedTextBoxDni.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MaskedTextBoxDni.Size = New System.Drawing.Size(130, 21)
        Me.MaskedTextBoxDni.TabIndex = 6
        '
        'MaskedTextBoxCuit
        '
        Me.MaskedTextBoxCuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBoxCuit.Location = New System.Drawing.Point(58, 32)
        Me.MaskedTextBoxCuit.Mask = "00-00000000-0"
        Me.MaskedTextBoxCuit.Name = "MaskedTextBoxCuit"
        Me.MaskedTextBoxCuit.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MaskedTextBoxCuit.Size = New System.Drawing.Size(130, 21)
        Me.MaskedTextBoxCuit.TabIndex = 7
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombre.Location = New System.Drawing.Point(58, 60)
        Me.TextBoxNombre.MaxLength = 50
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(200, 21)
        Me.TextBoxNombre.TabIndex = 8
        '
        'TextBoxApellido
        '
        Me.TextBoxApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxApellido.Location = New System.Drawing.Point(58, 87)
        Me.TextBoxApellido.MaxLength = 50
        Me.TextBoxApellido.Name = "TextBoxApellido"
        Me.TextBoxApellido.Size = New System.Drawing.Size(200, 21)
        Me.TextBoxApellido.TabIndex = 9
        '
        'TextBoxDireccion
        '
        Me.TextBoxDireccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDireccion.Location = New System.Drawing.Point(345, 6)
        Me.TextBoxDireccion.MaxLength = 100
        Me.TextBoxDireccion.Name = "TextBoxDireccion"
        Me.TextBoxDireccion.Size = New System.Drawing.Size(200, 21)
        Me.TextBoxDireccion.TabIndex = 10
        '
        'TextBoxCorreo
        '
        Me.TextBoxCorreo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCorreo.Location = New System.Drawing.Point(345, 32)
        Me.TextBoxCorreo.MaxLength = 40
        Me.TextBoxCorreo.Name = "TextBoxCorreo"
        Me.TextBoxCorreo.Size = New System.Drawing.Size(200, 21)
        Me.TextBoxCorreo.TabIndex = 11
        '
        'ButtonTelefonos
        '
        Me.ButtonTelefonos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonTelefonos.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.ButtonTelefonos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.ButtonTelefonos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.ButtonTelefonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTelefonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTelefonos.Location = New System.Drawing.Point(383, 61)
        Me.ButtonTelefonos.Name = "ButtonTelefonos"
        Me.ButtonTelefonos.Size = New System.Drawing.Size(99, 26)
        Me.ButtonTelefonos.TabIndex = 12
        Me.ButtonTelefonos.Text = "&Telefonos"
        Me.ButtonTelefonos.UseVisualStyleBackColor = True
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.ButtonAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.ButtonAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.ButtonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAceptar.Location = New System.Drawing.Point(568, 34)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(88, 26)
        Me.ButtonAceptar.TabIndex = 13
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.ButtonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink
        Me.ButtonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink
        Me.ButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelar.Location = New System.Drawing.Point(568, 73)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(88, 26)
        Me.ButtonCancelar.TabIndex = 14
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(671, 264)
        Me.DataGridView1.TabIndex = 0
        '
        'ButtonReactivar
        '
        Me.ButtonReactivar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonReactivar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.ButtonReactivar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.ButtonReactivar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.ButtonReactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonReactivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReactivar.Location = New System.Drawing.Point(383, 96)
        Me.ButtonReactivar.Name = "ButtonReactivar"
        Me.ButtonReactivar.Size = New System.Drawing.Size(99, 26)
        Me.ButtonReactivar.TabIndex = 15
        Me.ButtonReactivar.Text = "Reactivar"
        Me.ButtonReactivar.UseVisualStyleBackColor = True
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
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel1.PerformLayout()
        Me.SplitContainer.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControlPersonal As System.Windows.Forms.TabControl
    Friend WithEvents TabPageAlta As System.Windows.Forms.TabPage
    Friend WithEvents TabPageModificar As System.Windows.Forms.TabPage
    Friend WithEvents TabPageBaja As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents TextBoxDireccion As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxApellido As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBoxCuit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBoxDni As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LabelCorreo As System.Windows.Forms.Label
    Friend WithEvents LabelDireccion As System.Windows.Forms.Label
    Friend WithEvents LabelApellido As System.Windows.Forms.Label
    Friend WithEvents LabelNombre As System.Windows.Forms.Label
    Friend WithEvents LabelCuit As System.Windows.Forms.Label
    Friend WithEvents LabelDni As System.Windows.Forms.Label
    Friend WithEvents TextBoxCorreo As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCancelar As System.Windows.Forms.Button
    Friend WithEvents ButtonAceptar As System.Windows.Forms.Button
    Friend WithEvents ButtonTelefonos As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonReactivar As System.Windows.Forms.Button

End Class
