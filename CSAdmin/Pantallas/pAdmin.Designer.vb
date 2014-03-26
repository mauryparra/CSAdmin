<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pAdmin
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
        Me.TabControlAdmin = New System.Windows.Forms.TabControl()
        Me.TabPageFunciones = New System.Windows.Forms.TabPage()
        Me.TabPageSituacProfesionales = New System.Windows.Forms.TabPage()
        Me.TabPageUsuarios = New System.Windows.Forms.TabPage()
        Me.TabPageLocalidades = New System.Windows.Forms.TabPage()
        Me.TabControlAdmin.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlAdmin
        '
        Me.TabControlAdmin.Controls.Add(Me.TabPageFunciones)
        Me.TabControlAdmin.Controls.Add(Me.TabPageSituacProfesionales)
        Me.TabControlAdmin.Controls.Add(Me.TabPageUsuarios)
        Me.TabControlAdmin.Controls.Add(Me.TabPageLocalidades)
        Me.TabControlAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlAdmin.Location = New System.Drawing.Point(0, 0)
        Me.TabControlAdmin.Name = "TabControlAdmin"
        Me.TabControlAdmin.SelectedIndex = 0
        Me.TabControlAdmin.Size = New System.Drawing.Size(689, 446)
        Me.TabControlAdmin.TabIndex = 0
        '
        'TabPageFunciones
        '
        Me.TabPageFunciones.Location = New System.Drawing.Point(4, 24)
        Me.TabPageFunciones.Name = "TabPageFunciones"
        Me.TabPageFunciones.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageFunciones.Size = New System.Drawing.Size(681, 418)
        Me.TabPageFunciones.TabIndex = 0
        Me.TabPageFunciones.Text = "Funciones"
        Me.TabPageFunciones.UseVisualStyleBackColor = True
        '
        'TabPageSituacProfesionales
        '
        Me.TabPageSituacProfesionales.Location = New System.Drawing.Point(4, 24)
        Me.TabPageSituacProfesionales.Name = "TabPageSituacProfesionales"
        Me.TabPageSituacProfesionales.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSituacProfesionales.Size = New System.Drawing.Size(681, 418)
        Me.TabPageSituacProfesionales.TabIndex = 1
        Me.TabPageSituacProfesionales.Text = "Situaciones Profesionales"
        Me.TabPageSituacProfesionales.UseVisualStyleBackColor = True
        '
        'TabPageUsuarios
        '
        Me.TabPageUsuarios.Location = New System.Drawing.Point(4, 24)
        Me.TabPageUsuarios.Name = "TabPageUsuarios"
        Me.TabPageUsuarios.Size = New System.Drawing.Size(681, 418)
        Me.TabPageUsuarios.TabIndex = 3
        Me.TabPageUsuarios.Text = "Usuarios"
        Me.TabPageUsuarios.UseVisualStyleBackColor = True
        '
        'TabPageLocalidades
        '
        Me.TabPageLocalidades.Location = New System.Drawing.Point(4, 24)
        Me.TabPageLocalidades.Name = "TabPageLocalidades"
        Me.TabPageLocalidades.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageLocalidades.Size = New System.Drawing.Size(681, 418)
        Me.TabPageLocalidades.TabIndex = 2
        Me.TabPageLocalidades.Text = "Localidades"
        Me.TabPageLocalidades.UseVisualStyleBackColor = True
        '
        'pAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControlAdmin)
        Me.Name = "pAdmin"
        Me.Size = New System.Drawing.Size(689, 446)
        Me.TabControlAdmin.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControlAdmin As System.Windows.Forms.TabControl
    Friend WithEvents TabPageFunciones As System.Windows.Forms.TabPage
    Friend WithEvents TabPageSituacProfesionales As System.Windows.Forms.TabPage
    Friend WithEvents TabPageLocalidades As System.Windows.Forms.TabPage
    Friend WithEvents TabPageUsuarios As System.Windows.Forms.TabPage

End Class
