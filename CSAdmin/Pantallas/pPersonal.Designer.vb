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
        Me.TabControlPersonal.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlPersonal
        '
        Me.TabControlPersonal.Controls.Add(Me.TabPageAlta)
        Me.TabControlPersonal.Controls.Add(Me.TabPageModificar)
        Me.TabControlPersonal.Controls.Add(Me.TabPageBaja)
        Me.TabControlPersonal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPersonal.Location = New System.Drawing.Point(0, 0)
        Me.TabControlPersonal.Name = "TabControlPersonal"
        Me.TabControlPersonal.SelectedIndex = 0
        Me.TabControlPersonal.Size = New System.Drawing.Size(435, 292)
        Me.TabControlPersonal.TabIndex = 0
        '
        'TabPageAlta
        '
        Me.TabPageAlta.Location = New System.Drawing.Point(4, 22)
        Me.TabPageAlta.Name = "TabPageAlta"
        Me.TabPageAlta.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAlta.Size = New System.Drawing.Size(427, 266)
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
        'pPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControlPersonal)
        Me.Name = "pPersonal"
        Me.Size = New System.Drawing.Size(435, 292)
        Me.TabControlPersonal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControlPersonal As System.Windows.Forms.TabControl
    Friend WithEvents TabPageAlta As System.Windows.Forms.TabPage
    Friend WithEvents TabPageModificar As System.Windows.Forms.TabPage
    Friend WithEvents TabPageBaja As System.Windows.Forms.TabPage

End Class
