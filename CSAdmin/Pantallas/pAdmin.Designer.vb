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
        Me.components = New System.ComponentModel.Container()
        Me.TabControlAdmin = New System.Windows.Forms.TabControl()
        Me.TabPageFunciones = New System.Windows.Forms.TabPage()
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.DataGridViewContratos = New System.Windows.Forms.DataGridView()
        Me.TabPageSituacProfesionales = New System.Windows.Forms.TabPage()
        Me.TabPageUsuarios = New System.Windows.Forms.TabPage()
        Me.TabPageLocalidades = New System.Windows.Forms.TabPage()
        Me.EntityDataSource = New EFWinForms.EntityDataSource(Me.components)
        Me.EntityBindingNavigatorSitPro = New EFWinForms.EntityBindingNavigator()
        Me.DataGridViewSitProf = New System.Windows.Forms.DataGridView()
        Me.EntityBindingNavigatorUsuarios = New EFWinForms.EntityBindingNavigator()
        Me.EntityBindingNavigatorLocalidades = New EFWinForms.EntityBindingNavigator()
        Me.DataGridViewLocalidades = New System.Windows.Forms.DataGridView()
        Me.DataGridViewUsuarios = New System.Windows.Forms.DataGridView()
        Me.EntityBindingNavigatorFunciones = New EFWinForms.EntityBindingNavigator()
        Me.DataGridViewFunciones = New System.Windows.Forms.DataGridView()
        Me.TabControlAdmin.SuspendLayout()
        Me.TabPageFunciones.SuspendLayout()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        CType(Me.DataGridViewContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageSituacProfesionales.SuspendLayout()
        Me.TabPageUsuarios.SuspendLayout()
        Me.TabPageLocalidades.SuspendLayout()
        CType(Me.DataGridViewSitProf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewLocalidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewFunciones, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabPageFunciones.Controls.Add(Me.SplitContainer)
        Me.TabPageFunciones.Location = New System.Drawing.Point(4, 24)
        Me.TabPageFunciones.Name = "TabPageFunciones"
        Me.TabPageFunciones.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageFunciones.Size = New System.Drawing.Size(681, 418)
        Me.TabPageFunciones.TabIndex = 0
        Me.TabPageFunciones.Text = "Funciones"
        Me.TabPageFunciones.UseVisualStyleBackColor = True
        '
        'SplitContainer
        '
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer.Name = "SplitContainer"
        Me.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.DataGridViewFunciones)
        Me.SplitContainer.Panel1.Controls.Add(Me.EntityBindingNavigatorFunciones)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.Controls.Add(Me.DataGridViewContratos)
        Me.SplitContainer.Size = New System.Drawing.Size(675, 412)
        Me.SplitContainer.SplitterDistance = 225
        Me.SplitContainer.TabIndex = 0
        '
        'DataGridViewContratos
        '
        Me.DataGridViewContratos.AllowUserToAddRows = False
        Me.DataGridViewContratos.AllowUserToDeleteRows = False
        Me.DataGridViewContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewContratos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewContratos.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewContratos.Name = "DataGridViewContratos"
        Me.DataGridViewContratos.ReadOnly = True
        Me.DataGridViewContratos.Size = New System.Drawing.Size(675, 183)
        Me.DataGridViewContratos.TabIndex = 0
        '
        'TabPageSituacProfesionales
        '
        Me.TabPageSituacProfesionales.Controls.Add(Me.DataGridViewSitProf)
        Me.TabPageSituacProfesionales.Controls.Add(Me.EntityBindingNavigatorSitPro)
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
        Me.TabPageUsuarios.Controls.Add(Me.DataGridViewUsuarios)
        Me.TabPageUsuarios.Controls.Add(Me.EntityBindingNavigatorUsuarios)
        Me.TabPageUsuarios.Location = New System.Drawing.Point(4, 24)
        Me.TabPageUsuarios.Name = "TabPageUsuarios"
        Me.TabPageUsuarios.Size = New System.Drawing.Size(681, 418)
        Me.TabPageUsuarios.TabIndex = 3
        Me.TabPageUsuarios.Text = "Usuarios"
        Me.TabPageUsuarios.UseVisualStyleBackColor = True
        '
        'TabPageLocalidades
        '
        Me.TabPageLocalidades.Controls.Add(Me.DataGridViewLocalidades)
        Me.TabPageLocalidades.Controls.Add(Me.EntityBindingNavigatorLocalidades)
        Me.TabPageLocalidades.Location = New System.Drawing.Point(4, 24)
        Me.TabPageLocalidades.Name = "TabPageLocalidades"
        Me.TabPageLocalidades.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageLocalidades.Size = New System.Drawing.Size(681, 418)
        Me.TabPageLocalidades.TabIndex = 2
        Me.TabPageLocalidades.Text = "Localidades"
        Me.TabPageLocalidades.UseVisualStyleBackColor = True
        '
        'EntityDataSource
        '
        Me.EntityDataSource.ObjectContextType = GetType(CSAdmin.CSAdminBDEntities)
        '
        'EntityBindingNavigatorSitPro
        '
        Me.EntityBindingNavigatorSitPro.DataMember = "SituacionesProfesionales"
        Me.EntityBindingNavigatorSitPro.DataSource = Me.EntityDataSource
        Me.EntityBindingNavigatorSitPro.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.EntityBindingNavigatorSitPro.Location = New System.Drawing.Point(3, 3)
        Me.EntityBindingNavigatorSitPro.Name = "EntityBindingNavigatorSitPro"
        Me.EntityBindingNavigatorSitPro.Size = New System.Drawing.Size(675, 25)
        Me.EntityBindingNavigatorSitPro.TabIndex = 0
        Me.EntityBindingNavigatorSitPro.Text = "EntityBindingNavigator1"
        '
        'DataGridViewSitProf
        '
        Me.DataGridViewSitProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSitProf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewSitProf.Location = New System.Drawing.Point(3, 28)
        Me.DataGridViewSitProf.Name = "DataGridViewSitProf"
        Me.DataGridViewSitProf.Size = New System.Drawing.Size(675, 387)
        Me.DataGridViewSitProf.TabIndex = 1
        '
        'EntityBindingNavigatorUsuarios
        '
        Me.EntityBindingNavigatorUsuarios.DataMember = "Usuarios"
        Me.EntityBindingNavigatorUsuarios.DataSource = Me.EntityDataSource
        Me.EntityBindingNavigatorUsuarios.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.EntityBindingNavigatorUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.EntityBindingNavigatorUsuarios.Name = "EntityBindingNavigatorUsuarios"
        Me.EntityBindingNavigatorUsuarios.Size = New System.Drawing.Size(681, 25)
        Me.EntityBindingNavigatorUsuarios.TabIndex = 0
        Me.EntityBindingNavigatorUsuarios.Text = "EntityBindingNavigator1"
        '
        'EntityBindingNavigatorLocalidades
        '
        Me.EntityBindingNavigatorLocalidades.DataMember = "Localidades"
        Me.EntityBindingNavigatorLocalidades.DataSource = Me.EntityDataSource
        Me.EntityBindingNavigatorLocalidades.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.EntityBindingNavigatorLocalidades.Location = New System.Drawing.Point(3, 3)
        Me.EntityBindingNavigatorLocalidades.Name = "EntityBindingNavigatorLocalidades"
        Me.EntityBindingNavigatorLocalidades.Size = New System.Drawing.Size(675, 25)
        Me.EntityBindingNavigatorLocalidades.TabIndex = 0
        Me.EntityBindingNavigatorLocalidades.Text = "EntityBindingNavigator1"
        '
        'DataGridViewLocalidades
        '
        Me.DataGridViewLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewLocalidades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewLocalidades.Location = New System.Drawing.Point(3, 28)
        Me.DataGridViewLocalidades.Name = "DataGridViewLocalidades"
        Me.DataGridViewLocalidades.Size = New System.Drawing.Size(675, 387)
        Me.DataGridViewLocalidades.TabIndex = 1
        '
        'DataGridViewUsuarios
        '
        Me.DataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewUsuarios.Location = New System.Drawing.Point(0, 25)
        Me.DataGridViewUsuarios.Name = "DataGridViewUsuarios"
        Me.DataGridViewUsuarios.Size = New System.Drawing.Size(681, 393)
        Me.DataGridViewUsuarios.TabIndex = 1
        '
        'EntityBindingNavigatorFunciones
        '
        Me.EntityBindingNavigatorFunciones.DataMember = "Funciones"
        Me.EntityBindingNavigatorFunciones.DataSource = Me.EntityDataSource
        Me.EntityBindingNavigatorFunciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.EntityBindingNavigatorFunciones.Location = New System.Drawing.Point(0, 0)
        Me.EntityBindingNavigatorFunciones.Name = "EntityBindingNavigatorFunciones"
        Me.EntityBindingNavigatorFunciones.Size = New System.Drawing.Size(675, 25)
        Me.EntityBindingNavigatorFunciones.TabIndex = 2
        '
        'DataGridViewFunciones
        '
        Me.DataGridViewFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFunciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewFunciones.Location = New System.Drawing.Point(0, 25)
        Me.DataGridViewFunciones.Name = "DataGridViewFunciones"
        Me.DataGridViewFunciones.Size = New System.Drawing.Size(675, 200)
        Me.DataGridViewFunciones.TabIndex = 3
        '
        'pAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControlAdmin)
        Me.Name = "pAdmin"
        Me.Size = New System.Drawing.Size(689, 446)
        Me.TabControlAdmin.ResumeLayout(False)
        Me.TabPageFunciones.ResumeLayout(False)
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel1.PerformLayout()
        Me.SplitContainer.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        CType(Me.DataGridViewContratos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageSituacProfesionales.ResumeLayout(False)
        Me.TabPageSituacProfesionales.PerformLayout()
        Me.TabPageUsuarios.ResumeLayout(False)
        Me.TabPageUsuarios.PerformLayout()
        Me.TabPageLocalidades.ResumeLayout(False)
        Me.TabPageLocalidades.PerformLayout()
        CType(Me.DataGridViewSitProf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewLocalidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewFunciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControlAdmin As System.Windows.Forms.TabControl
    Friend WithEvents TabPageFunciones As System.Windows.Forms.TabPage
    Friend WithEvents TabPageSituacProfesionales As System.Windows.Forms.TabPage
    Friend WithEvents TabPageLocalidades As System.Windows.Forms.TabPage
    Friend WithEvents TabPageUsuarios As System.Windows.Forms.TabPage
    Friend WithEvents EntityDataSource As EFWinForms.EntityDataSource
    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridViewContratos As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewSitProf As System.Windows.Forms.DataGridView
    Friend WithEvents EntityBindingNavigatorSitPro As EFWinForms.EntityBindingNavigator
    Friend WithEvents DataGridViewUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents EntityBindingNavigatorUsuarios As EFWinForms.EntityBindingNavigator
    Friend WithEvents DataGridViewLocalidades As System.Windows.Forms.DataGridView
    Friend WithEvents EntityBindingNavigatorLocalidades As EFWinForms.EntityBindingNavigator
    Friend WithEvents DataGridViewFunciones As System.Windows.Forms.DataGridView
    Friend WithEvents EntityBindingNavigatorFunciones As EFWinForms.EntityBindingNavigator

End Class
