Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Data.EntityClient

Public Class pPersonal
    Private BDContext As New CSAdminBDEntities()
    Private aux As Integer = 0

    Private Sub pPersonal_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            Dim personasQuery As ObjectQuery(Of Personas) = _
                    BDContext.Personas.Where("it.Baja = True")
            ADataGridViewPer.DataSource = personasQuery.Select("it.Id, it.Dni, it.Nombre, it.Apellido")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        AButtonReactivar.Visible = False
    End Sub

    Private Sub TabControlPersonal_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TabControlPersonal.SelectedIndexChanged
        Try
            Select Case TabControlPersonal.SelectedIndex
                Case 0
                    Dim personasQuery As ObjectQuery(Of Personas) = _
                        BDContext.Personas.Where("it.Baja = True")
                    ADataGridViewPer.DataSource = personasQuery.Select("it.Id, it.Dni, it.Nombre, it.Apellido")
                Case 1

                Case 2
                    Dim personasQuery As ObjectQuery(Of Personas) = _
                        BDContext.Personas.Where("it.Baja = False")
                    BDataGridViewPer.DataSource = personasQuery.Select("it.Id, it.Dni, it.Nombre, it.Apellido")
                Case Else
                    MessageBox.Show("No se puede determinar el indice de la Pestaña," & _
                                    " por favor contacte al administrador", "Error", _
                                    MessageBoxButtons.OK, _
                                    MessageBoxIcon.Error)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#Region "TAB ALTA"
    Private Sub AButtonTelefonos_Click(sender As System.Object, e As System.EventArgs) Handles AButtonTelefonos.Click

    End Sub

    Private Sub AButtonAceptar_Click(sender As System.Object, e As System.EventArgs) Handles AButtonAceptar.Click
        Try
            Dim nuevaPersona As New CSAdmin.Personas
            With nuevaPersona
                .Dni = AMaskedTextBoxDni.Text
                .Cuit = AMaskedTextBoxCuit.Text
                .Nombre = ATextBoxNombre.Text
                .Apellido = ATextBoxApellido.Text
                .Direccion = ATextBoxDireccion.Text
                .Correo = ATextBoxCorreo.Text
                .Baja = False
            End With
            BDContext.AddToPersonas(nuevaPersona)
            BDContext.SaveChanges()
            MessageBox.Show("Se agrego")
            Call limpiarForm(ASplitContainer.Panel1)
            AButtonReactivar.Visible = False
            AMaskedTextBoxDni.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AButtonCancelar_Click(sender As System.Object, e As System.EventArgs) Handles AButtonCancelar.Click
        ' Limpia el fomrulario.
        Call limpiarForm(ASplitContainer.Panel1)
        Call readOnlyForm(ASplitContainer.Panel1, False)
        AButtonAceptar.Enabled = True
        AButtonReactivar.Visible = False
        AMaskedTextBoxDni.Focus()
    End Sub

    Private Sub AButtonReactivar_Click(sender As System.Object, e As System.EventArgs) Handles AButtonReactivar.Click
        Try
            Dim personaQ As ObjectQuery(Of Personas) = _
                BDContext.Personas.Where("it.Id = @Id")
            personaQ.Parameters.Add(New ObjectParameter("Id", aux))

            personaQ.First.Baja = False
            BDContext.SaveChanges()
            MessageBox.Show("Se activo nuevamente la persona")
            Call limpiarForm(ASplitContainer.Panel1)
            Call readOnlyForm(ASplitContainer.Panel1, False)
            AButtonAceptar.Enabled = True
            AButtonReactivar.Visible = False
            AMaskedTextBoxDni.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ADataGridViewPer_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles ADataGridViewPer.CellMouseDoubleClick
        Try
            Dim index As Integer = 0
            index = ADataGridViewPer.SelectedRows.Item(0).Cells(0).Value
            Dim personasQuery As ObjectQuery(Of Personas) = _
                    BDContext.Personas.Where("it.Id = @Id")
            personasQuery.Parameters.Add(New ObjectParameter("Id", index))

            Dim personaDesactivada As New CSAdmin.Personas
            With personaDesactivada
                .Id = personasQuery.First.Id
                .Dni = personasQuery.First.Dni
                .Cuit = personasQuery.First.Cuit
                .Nombre = personasQuery.First.Nombre
                .Apellido = personasQuery.First.Apellido
                .Direccion = personasQuery.First.Direccion
                .Correo = personasQuery.First.Correo
                .Baja = personasQuery.First.Baja
            End With

            aux = index

            AMaskedTextBoxDni.Text = personaDesactivada.Dni
            AMaskedTextBoxCuit.Text = personaDesactivada.Cuit
            ATextBoxNombre.Text = personaDesactivada.Nombre
            ATextBoxApellido.Text = personaDesactivada.Apellido
            ATextBoxDireccion.Text = personaDesactivada.Direccion
            ATextBoxCorreo.Text = personaDesactivada.Correo
            Call readOnlyForm(ASplitContainer.Panel1, True)
            AButtonAceptar.Enabled = False
            AButtonReactivar.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

#End Region

#Region "BAJA"

    Private Sub BButtonCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BButtonCancelar.Click
        ' Limpia el fomrulario.
        Call limpiarForm(BSplitContainer.Panel1)
        Call readOnlyForm(BSplitContainer.Panel1, False)
        BMaskedTextBoxDni.Focus()
    End Sub

    Private Sub BButtonBaja_Click(sender As System.Object, e As System.EventArgs) Handles BButtonBaja.Click
        Try
            Dim personaQ As ObjectQuery(Of Personas) = _
                BDContext.Personas.Where("it.Id = @Id")
            personaQ.Parameters.Add(New ObjectParameter("Id", aux))

            personaQ.First.Baja = True
            BDContext.SaveChanges()
            MessageBox.Show("Se dio de baja a: " + personaQ.First.Nombre)
            Call limpiarForm(BSplitContainer.Panel1)
            Call readOnlyForm(BSplitContainer.Panel1, False)
            BMaskedTextBoxDni.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BButtonContratos_Click(sender As System.Object, e As System.EventArgs) Handles BButtonContratos.Click

    End Sub

    Private Sub BDataGridViewPer_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles BDataGridViewPer.CellMouseDoubleClick
        Try
            Dim index As Integer = 0
            index = BDataGridViewPer.SelectedRows.Item(0).Cells(0).Value
            Dim personaQuery As ObjectQuery(Of Personas) = _
                    BDContext.Personas.Where("it.Id = @Id")
            personaQuery.Parameters.Add(New ObjectParameter("Id", index))

            Dim personaActivada As New CSAdmin.Personas
            With personaActivada
                .Id = personaQuery.First.Id
                .Dni = personaQuery.First.Dni
                .Cuit = personaQuery.First.Cuit
                .Nombre = personaQuery.First.Nombre
                .Apellido = personaQuery.First.Apellido
                .Direccion = personaQuery.First.Direccion
                .Correo = personaQuery.First.Correo
                .Baja = personaQuery.First.Baja
            End With

            aux = index

            BMaskedTextBoxDni.Text = personaActivada.Dni
            BTextBoxNombre.Text = personaActivada.Nombre
            BTextBoxApellido.Text = personaActivada.Apellido
            BTextBoxDireccion.Text = personaActivada.Direccion
            Call readOnlyForm(BSplitContainer.Panel1, True)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

End Class
