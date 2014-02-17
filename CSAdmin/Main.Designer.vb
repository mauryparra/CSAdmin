<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.ToolStripContainer = New System.Windows.Forms.ToolStripContainer
        Me.MainStatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripProgressBar = New System.Windows.Forms.ToolStripProgressBar
        Me.SplitContainer = New System.Windows.Forms.SplitContainer
        Me.FlowLayoutPanelMenu = New System.Windows.Forms.FlowLayoutPanel
        Me.RadBtnPersonal = New System.Windows.Forms.RadioButton
        Me.RadBtnContratos = New System.Windows.Forms.RadioButton
        Me.RadBtnAsistencia = New System.Windows.Forms.RadioButton
        Me.RadBtnEquipos = New System.Windows.Forms.RadioButton
        Me.RadBtnConsultas = New System.Windows.Forms.RadioButton
        Me.RadBtnCertificados = New System.Windows.Forms.RadioButton
        Me.MainMenuStrip = New System.Windows.Forms.MenuStrip
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripContainer.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer.ContentPanel.SuspendLayout()
        Me.ToolStripContainer.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer.SuspendLayout()
        Me.MainStatusStrip.SuspendLayout()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        Me.FlowLayoutPanelMenu.SuspendLayout()
        Me.MainMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer
        '
        '
        'ToolStripContainer.BottomToolStripPanel
        '
        Me.ToolStripContainer.BottomToolStripPanel.Controls.Add(Me.MainStatusStrip)
        '
        'ToolStripContainer.ContentPanel
        '
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.SplitContainer)
        resources.ApplyResources(Me.ToolStripContainer.ContentPanel, "ToolStripContainer.ContentPanel")
        resources.ApplyResources(Me.ToolStripContainer, "ToolStripContainer")
        Me.ToolStripContainer.Name = "ToolStripContainer"
        '
        'ToolStripContainer.TopToolStripPanel
        '
        Me.ToolStripContainer.TopToolStripPanel.Controls.Add(Me.MainMenuStrip)
        '
        'MainStatusStrip
        '
        resources.ApplyResources(Me.MainStatusStrip, "MainStatusStrip")
        Me.MainStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.ToolStripProgressBar})
        Me.MainStatusStrip.Name = "MainStatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        resources.ApplyResources(Me.ToolStripStatusLabel, "ToolStripStatusLabel")
        '
        'ToolStripProgressBar
        '
        Me.ToolStripProgressBar.Name = "ToolStripProgressBar"
        resources.ApplyResources(Me.ToolStripProgressBar, "ToolStripProgressBar")
        '
        'SplitContainer
        '
        Me.SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.SplitContainer, "SplitContainer")
        Me.SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer.Name = "SplitContainer"
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.FlowLayoutPanelMenu)
        '
        'FlowLayoutPanelMenu
        '
        Me.FlowLayoutPanelMenu.Controls.Add(Me.RadBtnPersonal)
        Me.FlowLayoutPanelMenu.Controls.Add(Me.RadBtnContratos)
        Me.FlowLayoutPanelMenu.Controls.Add(Me.RadBtnAsistencia)
        Me.FlowLayoutPanelMenu.Controls.Add(Me.RadBtnEquipos)
        Me.FlowLayoutPanelMenu.Controls.Add(Me.RadBtnConsultas)
        Me.FlowLayoutPanelMenu.Controls.Add(Me.RadBtnCertificados)
        resources.ApplyResources(Me.FlowLayoutPanelMenu, "FlowLayoutPanelMenu")
        Me.FlowLayoutPanelMenu.Name = "FlowLayoutPanelMenu"
        '
        'RadBtnPersonal
        '
        resources.ApplyResources(Me.RadBtnPersonal, "RadBtnPersonal")
        Me.RadBtnPersonal.Checked = True
        Me.RadBtnPersonal.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.RadBtnPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.RadBtnPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.RadBtnPersonal.MinimumSize = New System.Drawing.Size(134, 30)
        Me.RadBtnPersonal.Name = "RadBtnPersonal"
        Me.RadBtnPersonal.TabStop = True
        Me.RadBtnPersonal.UseVisualStyleBackColor = True
        '
        'RadBtnContratos
        '
        resources.ApplyResources(Me.RadBtnContratos, "RadBtnContratos")
        Me.RadBtnContratos.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.RadBtnContratos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.RadBtnContratos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.RadBtnContratos.MinimumSize = New System.Drawing.Size(134, 30)
        Me.RadBtnContratos.Name = "RadBtnContratos"
        Me.RadBtnContratos.UseVisualStyleBackColor = True
        '
        'RadBtnAsistencia
        '
        resources.ApplyResources(Me.RadBtnAsistencia, "RadBtnAsistencia")
        Me.RadBtnAsistencia.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.RadBtnAsistencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.RadBtnAsistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.RadBtnAsistencia.MinimumSize = New System.Drawing.Size(134, 30)
        Me.RadBtnAsistencia.Name = "RadBtnAsistencia"
        Me.RadBtnAsistencia.UseVisualStyleBackColor = True
        '
        'RadBtnEquipos
        '
        resources.ApplyResources(Me.RadBtnEquipos, "RadBtnEquipos")
        Me.RadBtnEquipos.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.RadBtnEquipos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.RadBtnEquipos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.RadBtnEquipos.MinimumSize = New System.Drawing.Size(134, 30)
        Me.RadBtnEquipos.Name = "RadBtnEquipos"
        Me.RadBtnEquipos.UseVisualStyleBackColor = True
        '
        'RadBtnConsultas
        '
        resources.ApplyResources(Me.RadBtnConsultas, "RadBtnConsultas")
        Me.RadBtnConsultas.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.RadBtnConsultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.RadBtnConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.RadBtnConsultas.MinimumSize = New System.Drawing.Size(134, 30)
        Me.RadBtnConsultas.Name = "RadBtnConsultas"
        Me.RadBtnConsultas.UseVisualStyleBackColor = True
        '
        'RadBtnCertificados
        '
        resources.ApplyResources(Me.RadBtnCertificados, "RadBtnCertificados")
        Me.RadBtnCertificados.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen
        Me.RadBtnCertificados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.RadBtnCertificados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.RadBtnCertificados.MinimumSize = New System.Drawing.Size(134, 30)
        Me.RadBtnCertificados.Name = "RadBtnCertificados"
        Me.RadBtnCertificados.UseVisualStyleBackColor = True
        '
        'MainMenuStrip
        '
        resources.ApplyResources(Me.MainMenuStrip, "MainMenuStrip")
        Me.MainMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MainMenuStrip.Name = "MainMenuStrip"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        resources.ApplyResources(Me.ArchivoToolStripMenuItem, "ArchivoToolStripMenuItem")
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        resources.ApplyResources(Me.SalirToolStripMenuItem, "SalirToolStripMenuItem")
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        resources.ApplyResources(Me.AyudaToolStripMenuItem, "AyudaToolStripMenuItem")
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        resources.ApplyResources(Me.AcercaDeToolStripMenuItem, "AcercaDeToolStripMenuItem")
        '
        'Main
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer)
        Me.Name = "Main"
        Me.ToolStripContainer.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer.ResumeLayout(False)
        Me.ToolStripContainer.PerformLayout()
        Me.MainStatusStrip.ResumeLayout(False)
        Me.MainStatusStrip.PerformLayout()
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.ResumeLayout(False)
        Me.FlowLayoutPanelMenu.ResumeLayout(False)
        Me.FlowLayoutPanelMenu.PerformLayout()
        Me.MainMenuStrip.ResumeLayout(False)
        Me.MainMenuStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer As System.Windows.Forms.ToolStripContainer
    Friend WithEvents MainStatusStrip As System.Windows.Forms.StatusStrip
    Shadows WithEvents MainMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents FlowLayoutPanelMenu As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents RadBtnPersonal As System.Windows.Forms.RadioButton
    Friend WithEvents RadBtnContratos As System.Windows.Forms.RadioButton
    Friend WithEvents RadBtnAsistencia As System.Windows.Forms.RadioButton
    Friend WithEvents RadBtnEquipos As System.Windows.Forms.RadioButton
    Friend WithEvents RadBtnConsultas As System.Windows.Forms.RadioButton
    Friend WithEvents RadBtnCertificados As System.Windows.Forms.RadioButton
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
