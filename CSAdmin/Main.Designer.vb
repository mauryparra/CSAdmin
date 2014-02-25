<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.ToolStripContainer = New System.Windows.Forms.ToolStripContainer()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.FlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.RadBtnPersonal = New System.Windows.Forms.RadioButton()
        Me.RadBtnContratos = New System.Windows.Forms.RadioButton()
        Me.RadBtnAsistencia = New System.Windows.Forms.RadioButton()
        Me.RadBtnEquipos = New System.Windows.Forms.RadioButton()
        Me.RadBtnConsultas = New System.Windows.Forms.RadioButton()
        Me.RadBtnCertificados = New System.Windows.Forms.RadioButton()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeCSAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer.ContentPanel.SuspendLayout()
        Me.ToolStripContainer.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        Me.FlowLayoutPanel.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer
        '
        '
        'ToolStripContainer.BottomToolStripPanel
        '
        Me.ToolStripContainer.BottomToolStripPanel.Controls.Add(Me.StatusStrip)
        '
        'ToolStripContainer.ContentPanel
        '
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.SplitContainer)
        Me.ToolStripContainer.ContentPanel.Size = New System.Drawing.Size(584, 296)
        Me.ToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer.Name = "ToolStripContainer"
        Me.ToolStripContainer.Size = New System.Drawing.Size(584, 342)
        Me.ToolStripContainer.TabIndex = 0
        Me.ToolStripContainer.Text = "ToolStripContainer"
        '
        'ToolStripContainer.TopToolStripPanel
        '
        Me.ToolStripContainer.TopToolStripPanel.Controls.Add(Me.MenuStrip)
        '
        'StatusStrip
        '
        Me.StatusStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.ToolStripProgressBar})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(584, 22)
        Me.StatusStrip.TabIndex = 0
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'ToolStripProgressBar
        '
        Me.ToolStripProgressBar.Name = "ToolStripProgressBar"
        Me.ToolStripProgressBar.Size = New System.Drawing.Size(100, 16)
        Me.ToolStripProgressBar.Visible = False
        '
        'SplitContainer
        '
        Me.SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer.IsSplitterFixed = True
        Me.SplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer.Name = "SplitContainer"
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.FlowLayoutPanel)
        Me.SplitContainer.Panel1MinSize = 144
        Me.SplitContainer.Size = New System.Drawing.Size(584, 296)
        Me.SplitContainer.SplitterDistance = 144
        Me.SplitContainer.SplitterWidth = 1
        Me.SplitContainer.TabIndex = 0
        '
        'FlowLayoutPanel
        '
        Me.FlowLayoutPanel.Controls.Add(Me.RadBtnPersonal)
        Me.FlowLayoutPanel.Controls.Add(Me.RadBtnContratos)
        Me.FlowLayoutPanel.Controls.Add(Me.RadBtnAsistencia)
        Me.FlowLayoutPanel.Controls.Add(Me.RadBtnEquipos)
        Me.FlowLayoutPanel.Controls.Add(Me.RadBtnConsultas)
        Me.FlowLayoutPanel.Controls.Add(Me.RadBtnCertificados)
        Me.FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel.Name = "FlowLayoutPanel"
        Me.FlowLayoutPanel.Size = New System.Drawing.Size(140, 292)
        Me.FlowLayoutPanel.TabIndex = 0
        '
        'RadBtnPersonal
        '
        Me.RadBtnPersonal.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadBtnPersonal.AutoSize = True
        Me.RadBtnPersonal.Checked = True
        Me.RadBtnPersonal.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.RadBtnPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.RadBtnPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.RadBtnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadBtnPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadBtnPersonal.Location = New System.Drawing.Point(3, 3)
        Me.RadBtnPersonal.MinimumSize = New System.Drawing.Size(134, 30)
        Me.RadBtnPersonal.Name = "RadBtnPersonal"
        Me.RadBtnPersonal.Padding = New System.Windows.Forms.Padding(2, 2, 2, 1)
        Me.RadBtnPersonal.Size = New System.Drawing.Size(134, 31)
        Me.RadBtnPersonal.TabIndex = 0
        Me.RadBtnPersonal.TabStop = True
        Me.RadBtnPersonal.Text = "&Personal"
        Me.RadBtnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadBtnPersonal.UseVisualStyleBackColor = True
        '
        'RadBtnContratos
        '
        Me.RadBtnContratos.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadBtnContratos.AutoSize = True
        Me.RadBtnContratos.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.RadBtnContratos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.RadBtnContratos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.RadBtnContratos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadBtnContratos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadBtnContratos.Location = New System.Drawing.Point(3, 40)
        Me.RadBtnContratos.MinimumSize = New System.Drawing.Size(134, 30)
        Me.RadBtnContratos.Name = "RadBtnContratos"
        Me.RadBtnContratos.Padding = New System.Windows.Forms.Padding(2, 2, 2, 1)
        Me.RadBtnContratos.Size = New System.Drawing.Size(134, 31)
        Me.RadBtnContratos.TabIndex = 1
        Me.RadBtnContratos.Text = "&Contratos"
        Me.RadBtnContratos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadBtnContratos.UseVisualStyleBackColor = True
        '
        'RadBtnAsistencia
        '
        Me.RadBtnAsistencia.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadBtnAsistencia.AutoSize = True
        Me.RadBtnAsistencia.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.RadBtnAsistencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.RadBtnAsistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.RadBtnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadBtnAsistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadBtnAsistencia.Location = New System.Drawing.Point(3, 77)
        Me.RadBtnAsistencia.MinimumSize = New System.Drawing.Size(134, 30)
        Me.RadBtnAsistencia.Name = "RadBtnAsistencia"
        Me.RadBtnAsistencia.Padding = New System.Windows.Forms.Padding(2, 2, 2, 1)
        Me.RadBtnAsistencia.Size = New System.Drawing.Size(134, 31)
        Me.RadBtnAsistencia.TabIndex = 2
        Me.RadBtnAsistencia.Text = "A&sistencia"
        Me.RadBtnAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadBtnAsistencia.UseVisualStyleBackColor = True
        '
        'RadBtnEquipos
        '
        Me.RadBtnEquipos.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadBtnEquipos.AutoSize = True
        Me.RadBtnEquipos.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.RadBtnEquipos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.RadBtnEquipos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.RadBtnEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadBtnEquipos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadBtnEquipos.Location = New System.Drawing.Point(3, 114)
        Me.RadBtnEquipos.MinimumSize = New System.Drawing.Size(134, 30)
        Me.RadBtnEquipos.Name = "RadBtnEquipos"
        Me.RadBtnEquipos.Padding = New System.Windows.Forms.Padding(2, 2, 2, 1)
        Me.RadBtnEquipos.Size = New System.Drawing.Size(134, 31)
        Me.RadBtnEquipos.TabIndex = 3
        Me.RadBtnEquipos.Text = "&Equipos"
        Me.RadBtnEquipos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadBtnEquipos.UseVisualStyleBackColor = True
        '
        'RadBtnConsultas
        '
        Me.RadBtnConsultas.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadBtnConsultas.AutoSize = True
        Me.RadBtnConsultas.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.RadBtnConsultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.RadBtnConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.RadBtnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadBtnConsultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadBtnConsultas.Location = New System.Drawing.Point(3, 151)
        Me.RadBtnConsultas.MinimumSize = New System.Drawing.Size(134, 30)
        Me.RadBtnConsultas.Name = "RadBtnConsultas"
        Me.RadBtnConsultas.Padding = New System.Windows.Forms.Padding(2, 2, 2, 1)
        Me.RadBtnConsultas.Size = New System.Drawing.Size(134, 31)
        Me.RadBtnConsultas.TabIndex = 4
        Me.RadBtnConsultas.Text = "C&onsultas"
        Me.RadBtnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadBtnConsultas.UseVisualStyleBackColor = True
        '
        'RadBtnCertificados
        '
        Me.RadBtnCertificados.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadBtnCertificados.AutoSize = True
        Me.RadBtnCertificados.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.RadBtnCertificados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.RadBtnCertificados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.RadBtnCertificados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadBtnCertificados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadBtnCertificados.Location = New System.Drawing.Point(3, 188)
        Me.RadBtnCertificados.MinimumSize = New System.Drawing.Size(134, 30)
        Me.RadBtnCertificados.Name = "RadBtnCertificados"
        Me.RadBtnCertificados.Padding = New System.Windows.Forms.Padding(2, 2, 2, 1)
        Me.RadBtnCertificados.Size = New System.Drawing.Size(134, 31)
        Me.RadBtnCertificados.TabIndex = 5
        Me.RadBtnCertificados.Text = "Ce&rtificados"
        Me.RadBtnCertificados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadBtnCertificados.UseVisualStyleBackColor = True
        '
        'MenuStrip
        '
        Me.MenuStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(584, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeCSAdminToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ay&uda"
        '
        'AcercaDeCSAdminToolStripMenuItem
        '
        Me.AcercaDeCSAdminToolStripMenuItem.Name = "AcercaDeCSAdminToolStripMenuItem"
        Me.AcercaDeCSAdminToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.AcercaDeCSAdminToolStripMenuItem.Text = "&Acerca de CSAdmin"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 342)
        Me.Controls.Add(Me.ToolStripContainer)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Main"
        Me.Text = "CSAdmin"
        Me.ToolStripContainer.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer.ResumeLayout(False)
        Me.ToolStripContainer.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.SplitContainer.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        Me.FlowLayoutPanel.ResumeLayout(False)
        Me.FlowLayoutPanel.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer As System.Windows.Forms.ToolStripContainer
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents FlowLayoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents RadBtnPersonal As System.Windows.Forms.RadioButton
    Friend WithEvents RadBtnContratos As System.Windows.Forms.RadioButton
    Friend WithEvents RadBtnAsistencia As System.Windows.Forms.RadioButton
    Friend WithEvents RadBtnEquipos As System.Windows.Forms.RadioButton
    Friend WithEvents RadBtnConsultas As System.Windows.Forms.RadioButton
    Friend WithEvents RadBtnCertificados As System.Windows.Forms.RadioButton
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeCSAdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
