<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pContratos
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
        Me.TabControlContratos = New System.Windows.Forms.TabControl()
        Me.TabPageNuevo = New System.Windows.Forms.TabPage()
        Me.TabPageModificar = New System.Windows.Forms.TabPage()
        Me.TabPageBaja = New System.Windows.Forms.TabPage()
        Me.TabControlContratos.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlContratos
        '
        Me.TabControlContratos.Controls.Add(Me.TabPageNuevo)
        Me.TabControlContratos.Controls.Add(Me.TabPageModificar)
        Me.TabControlContratos.Controls.Add(Me.TabPageBaja)
        Me.TabControlContratos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlContratos.Location = New System.Drawing.Point(0, 0)
        Me.TabControlContratos.Name = "TabControlContratos"
        Me.TabControlContratos.SelectedIndex = 0
        Me.TabControlContratos.Size = New System.Drawing.Size(689, 446)
        Me.TabControlContratos.TabIndex = 0
        '
        'TabPageNuevo
        '
        Me.TabPageNuevo.Location = New System.Drawing.Point(4, 22)
        Me.TabPageNuevo.Name = "TabPageNuevo"
        Me.TabPageNuevo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageNuevo.Size = New System.Drawing.Size(681, 420)
        Me.TabPageNuevo.TabIndex = 0
        Me.TabPageNuevo.Text = "Nuevo"
        Me.TabPageNuevo.UseVisualStyleBackColor = True
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
        'pContratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControlContratos)
        Me.Name = "pContratos"
        Me.Size = New System.Drawing.Size(689, 446)
        Me.TabControlContratos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControlContratos As System.Windows.Forms.TabControl
    Friend WithEvents TabPageNuevo As System.Windows.Forms.TabPage
    Friend WithEvents TabPageModificar As System.Windows.Forms.TabPage
    Friend WithEvents TabPageBaja As System.Windows.Forms.TabPage

End Class
