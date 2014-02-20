<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pContratos
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPageNuevo = New System.Windows.Forms.TabPage
        Me.TabPageModificar = New System.Windows.Forms.TabPage
        Me.TabPageBaja = New System.Windows.Forms.TabPage
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageNuevo)
        Me.TabControl1.Controls.Add(Me.TabPageModificar)
        Me.TabControl1.Controls.Add(Me.TabPageBaja)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(435, 292)
        Me.TabControl1.TabIndex = 0
        '
        'TabPageNuevo
        '
        Me.TabPageNuevo.Location = New System.Drawing.Point(4, 22)
        Me.TabPageNuevo.Name = "TabPageNuevo"
        Me.TabPageNuevo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageNuevo.Size = New System.Drawing.Size(427, 266)
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
        'Contratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Contratos"
        Me.Size = New System.Drawing.Size(435, 292)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageNuevo As System.Windows.Forms.TabPage
    Friend WithEvents TabPageModificar As System.Windows.Forms.TabPage
    Friend WithEvents TabPageBaja As System.Windows.Forms.TabPage

End Class
