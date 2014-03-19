<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelPopUp
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.MaskedTextBoxTel = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.ComboBoxTipo = New System.Windows.Forms.ComboBox()
        Me.LabelTelefono = New System.Windows.Forms.Label()
        Me.DataGridViewTel = New System.Windows.Forms.DataGridView()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        CType(Me.DataGridViewTel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer
        '
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.IsSplitterFixed = True
        Me.SplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer.Name = "SplitContainer"
        Me.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.MaskedTextBoxTel)
        Me.SplitContainer.Panel1.Controls.Add(Me.ButtonAgregar)
        Me.SplitContainer.Panel1.Controls.Add(Me.ComboBoxTipo)
        Me.SplitContainer.Panel1.Controls.Add(Me.LabelTelefono)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.Controls.Add(Me.DataGridViewTel)
        Me.SplitContainer.Size = New System.Drawing.Size(284, 122)
        Me.SplitContainer.SplitterDistance = 42
        Me.SplitContainer.TabIndex = 1
        '
        'MaskedTextBoxTel
        '
        Me.MaskedTextBoxTel.Location = New System.Drawing.Point(70, 10)
        Me.MaskedTextBoxTel.Mask = "(999) 000-0000"
        Me.MaskedTextBoxTel.Name = "MaskedTextBoxTel"
        Me.MaskedTextBoxTel.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MaskedTextBoxTel.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBoxTel.TabIndex = 2
        Me.MaskedTextBoxTel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.ButtonAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.ButtonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAgregar.Location = New System.Drawing.Point(242, 8)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(30, 23)
        Me.ButtonAgregar.TabIndex = 4
        Me.ButtonAgregar.Text = "+"
        Me.ButtonAgregar.UseVisualStyleBackColor = True
        '
        'ComboBoxTipo
        '
        Me.ComboBoxTipo.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ComboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxTipo.FormattingEnabled = True
        Me.ComboBoxTipo.Items.AddRange(New Object() {"MO", "FI"})
        Me.ComboBoxTipo.Location = New System.Drawing.Point(176, 10)
        Me.ComboBoxTipo.Name = "ComboBoxTipo"
        Me.ComboBoxTipo.Size = New System.Drawing.Size(60, 21)
        Me.ComboBoxTipo.TabIndex = 3
        '
        'LabelTelefono
        '
        Me.LabelTelefono.AutoSize = True
        Me.LabelTelefono.Location = New System.Drawing.Point(12, 13)
        Me.LabelTelefono.Name = "LabelTelefono"
        Me.LabelTelefono.Size = New System.Drawing.Size(52, 13)
        Me.LabelTelefono.TabIndex = 1
        Me.LabelTelefono.Text = "Teléfono:"
        '
        'DataGridViewTel
        '
        Me.DataGridViewTel.AllowUserToAddRows = False
        Me.DataGridViewTel.AllowUserToDeleteRows = False
        Me.DataGridViewTel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewTel.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewTel.Name = "DataGridViewTel"
        Me.DataGridViewTel.ReadOnly = True
        Me.DataGridViewTel.Size = New System.Drawing.Size(284, 76)
        Me.DataGridViewTel.TabIndex = 0
        '
        'TelPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 122)
        Me.Controls.Add(Me.SplitContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TelPopUp"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "TelPopUp"
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel1.PerformLayout()
        Me.SplitContainer.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        CType(Me.DataGridViewTel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents ButtonAgregar As System.Windows.Forms.Button
    Friend WithEvents ComboBoxTipo As System.Windows.Forms.ComboBox
    Friend WithEvents LabelTelefono As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTel As System.Windows.Forms.DataGridView
    Friend WithEvents MaskedTextBoxTel As System.Windows.Forms.MaskedTextBox
End Class
