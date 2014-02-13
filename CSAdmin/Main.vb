Public Class Main

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
#End Region

#Region "Menu Lateral"
    Private Sub RadBtnPersonal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBtnPersonal.CheckedChanged
        If RadBtnPersonal.Checked Then
            Call limpiarPanel()
            Dim pantallaPersonal As New Personal
            pantallaPersonal.Dock = DockStyle.Fill
            SplitContainer.Panel2.Controls.Add(pantallaPersonal)
        End If
    End Sub

    Private Sub RadBtnContratos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBtnContratos.CheckedChanged
        If RadBtnContratos.Checked Then
            Call limpiarPanel()
            Dim pantallaContratos As New Contratos
            pantallaContratos.Dock = DockStyle.Fill
            SplitContainer.Panel2.Controls.Add(pantallaContratos)
        End If
    End Sub

    Private Sub RadBtnAsistencia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBtnAsistencia.CheckedChanged
        If RadBtnAsistencia.Checked Then
            Call limpiarPanel()
            Dim pantallaAsistencia As New Asistencia
            pantallaAsistencia.Dock = DockStyle.Fill
            SplitContainer.Panel2.Controls.Add(pantallaAsistencia)
        End If
    End Sub

    Private Sub RadBtnEquipos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBtnEquipos.CheckedChanged
        If RadBtnEquipos.Checked Then
            Call limpiarPanel()
            Dim pantallaEquipos As New Equipos
            pantallaEquipos.Dock = DockStyle.Fill
            SplitContainer.Panel2.Controls.Add(pantallaEquipos)
        End If
    End Sub

    Private Sub RadBtnConsultas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBtnConsultas.CheckedChanged
        If RadBtnConsultas.Checked Then
            Call limpiarPanel()
            Dim pantallaConsultas As New Consultas
            pantallaConsultas.Dock = DockStyle.Fill
            SplitContainer.Panel2.Controls.Add(pantallaConsultas)
        End If
    End Sub

    Private Sub RadBtnCertificados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBtnCertificados.CheckedChanged
        If RadBtnCertificados.Checked Then
            Call limpiarPanel()
            Dim pantallaCertificados As New Certificados
            pantallaCertificados.Dock = DockStyle.Fill
            SplitContainer.Panel2.Controls.Add(pantallaCertificados)
        End If
    End Sub
#End Region
#End Region
End Class
