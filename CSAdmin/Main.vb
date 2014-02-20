Public Class Main

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Forms.LoginForm.ShowDialog()
        ToolStripStatusLabel.Text = "Listo"
    End Sub



#Region "GUI" 'Interfaz grafica

    ' Elimina las pantallas que se encuentren en 
    ' el Panel2 del SplitContainer
    Private Sub limpiarPanel()
        For Each control In SplitContainer.Panel2.Controls
            SplitContainer.Panel2.Controls.Remove(control)
        Next
    End Sub

#Region "Menu Principal"
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        My.Forms.AcercaDe.ShowDialog()
    End Sub
#End Region

#Region "Menu Lateral"
    Private Sub RadBtnPersonal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBtnPersonal.CheckedChanged
        If RadBtnPersonal.Checked Then
            ToolStripProgressBar.Style = ProgressBarStyle.Continuous
            ToolStripProgressBar.Visible = True
            Call limpiarPanel()
            Dim pantallaPersonal As New pPersonal
            pantallaPersonal.Dock = DockStyle.Fill
            SplitContainer.Panel2.Controls.Add(pantallaPersonal)
            ToolStripProgressBar.Visible = False
        End If
    End Sub

    Private Sub RadBtnContratos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBtnContratos.CheckedChanged
        If RadBtnContratos.Checked Then
            Call limpiarPanel()
            Dim pantallaContratos As New pContratos
            pantallaContratos.Dock = DockStyle.Fill
            SplitContainer.Panel2.Controls.Add(pantallaContratos)
        End If
    End Sub

    Private Sub RadBtnAsistencia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBtnAsistencia.CheckedChanged
        If RadBtnAsistencia.Checked Then
            Call limpiarPanel()
            Dim pantallaAsistencia As New pAsistencia
            pantallaAsistencia.Dock = DockStyle.Fill
            SplitContainer.Panel2.Controls.Add(pantallaAsistencia)
        End If
    End Sub

    Private Sub RadBtnEquipos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBtnEquipos.CheckedChanged
        If RadBtnEquipos.Checked Then
            Call limpiarPanel()
            Dim pantallaEquipos As New pEquipos
            pantallaEquipos.Dock = DockStyle.Fill
            SplitContainer.Panel2.Controls.Add(pantallaEquipos)
        End If
    End Sub

    Private Sub RadBtnConsultas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBtnConsultas.CheckedChanged
        If RadBtnConsultas.Checked Then
            Call limpiarPanel()
            Dim pantallaConsultas As New pConsultas
            pantallaConsultas.Dock = DockStyle.Fill
            SplitContainer.Panel2.Controls.Add(pantallaConsultas)
        End If
    End Sub

    Private Sub RadBtnCertificados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBtnCertificados.CheckedChanged
        If RadBtnCertificados.Checked Then
            Call limpiarPanel()
            Dim pantallaCertificados As New pCertificados
            pantallaCertificados.Dock = DockStyle.Fill
            SplitContainer.Panel2.Controls.Add(pantallaCertificados)
        End If
    End Sub
#End Region
#End Region
End Class
