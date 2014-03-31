Public Class pAdmin

    Private Sub pAdmin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            DataGridViewFunciones.DataSource = Me.EntityDataSource
            DataGridViewFunciones.DataMember = "Funciones"
            DataGridViewContratos.DataSource = Me.EntityDataSource
            DataGridViewContratos.DataMember = "Funciones.Contratos"
            DataGridViewFunciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TabControlAdmin_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TabControlAdmin.SelectedIndexChanged
        Select Case TabControlAdmin.SelectedIndex
            Case 0
                Try
                    DataGridViewFunciones.DataSource = Me.EntityDataSource
                    DataGridViewFunciones.DataMember = "Funciones"
                    DataGridViewContratos.DataSource = Me.EntityDataSource
                    DataGridViewContratos.DataMember = "Funciones.Contratos"
                    DataGridViewFunciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Case 1
                Try
                    DataGridViewSitProf.DataSource = Me.EntityDataSource
                    DataGridViewSitProf.DataMember = "SituacionesProfesionales"
                    DataGridViewSitProf.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Case 2
                Try
                    DataGridViewUsuarios.DataSource = Me.EntityDataSource
                    DataGridViewUsuarios.DataMember = "Usuarios"
                    DataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Case 3
                Try
                    DataGridViewLocalidades.DataSource = Me.EntityDataSource
                    DataGridViewLocalidades.DataMember = "Localidades"
                    DataGridViewLocalidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Case Else
                MessageBox.Show("Error")
        End Select
    End Sub
End Class
