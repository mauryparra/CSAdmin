Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Data.EntityClient

Public Class pPersonal
    Private BDContext As New CSAdminBDEntities()
    ' aux() es utilizado para guardar temporalmente el Id de la persona en c/ pestaña
    Private aux() As Integer = {0, 0, 0}

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
                    Dim personasQuery As ObjectQuery(Of Personas) = _
                        BDContext.Personas
                    MDataGridViewPer.DataSource = personasQuery.Select( _
                        "it.Id, it.Dni, it.Cuit, it.Nombre, it.Apellido, it.Direccion, it.Correo, it.Baja")
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
    ' Se utiliza aux(0)
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
            MessageBox.Show("Se agrego: " + nuevaPersona.Nombre + " " + nuevaPersona.Apellido, _
                            "Alta Personas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call limpiarForm(ASplitContainer.Panel1)
            AButtonReactivar.Visible = False
            AMaskedTextBoxDni.Focus()
            aux(0) = 0
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
        aux(0) = 0
    End Sub

    Private Sub AButtonReactivar_Click(sender As System.Object, e As System.EventArgs) Handles AButtonReactivar.Click
        Try
            Dim personaQ As ObjectQuery(Of Personas) = _
                BDContext.Personas.Where("it.Id = @Id")
            personaQ.Parameters.Add(New ObjectParameter("Id", aux))

            personaQ.First.Baja = False
            BDContext.SaveChanges()
            MessageBox.Show("Se activo nuevamente a: " + personaQ.First.Nombre + " " + _
                            personaQ.First.Apellido, "Alta Personas", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call limpiarForm(ASplitContainer.Panel1)
            Call readOnlyForm(ASplitContainer.Panel1, False)
            AButtonAceptar.Enabled = True
            AButtonReactivar.Visible = False
            AMaskedTextBoxDni.Focus()
            aux(0) = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ADataGridViewPer_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles ADataGridViewPer.CellMouseDoubleClick
        Try
            aux(0) = ADataGridViewPer.SelectedRows.Item(0).Cells(0).Value
            Dim personasQuery As ObjectQuery(Of Personas) = _
                    BDContext.Personas.Where("it.Id = @Id")
            personasQuery.Parameters.Add(New ObjectParameter("Id", aux(0)))

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

#Region "MODIFICAR"
    Private Sub MMaskedTextBoxDni_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MMaskedTextBoxDni.KeyPress

    End Sub
#End Region

#Region "BAJA"
    ' Se utiliza aux(2)
    Private Sub BButtonCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BButtonCancelar.Click
        ' Limpia el fomrulario.
        Call limpiarForm(BSplitContainer.Panel1)
        Call readOnlyForm(BSplitContainer.Panel1, False)
        BMaskedTextBoxDni.Focus()
        aux(2) = 0
    End Sub

    Private Sub BButtonBaja_Click(sender As System.Object, e As System.EventArgs) Handles BButtonBaja.Click
        Try
            If Not aux(2) = 0 Then
                Dim personaQ As ObjectQuery(Of Personas) = _
                BDContext.Personas.Where("it.Id = @Id")
                personaQ.Parameters.Add(New ObjectParameter("Id", aux))

                personaQ.First.Baja = True
                BDContext.SaveChanges()
                MessageBox.Show("Se dio de baja a: " + personaQ.First.Nombre, _
                                "Baja Personas", _
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call limpiarForm(BSplitContainer.Panel1)
                Call readOnlyForm(BSplitContainer.Panel1, False)
                BMaskedTextBoxDni.Focus()
                aux(2) = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BButtonContratos_Click(sender As System.Object, e As System.EventArgs) Handles BButtonContratos.Click

    End Sub

    Private Sub BDataGridViewPer_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles BDataGridViewPer.CellMouseDoubleClick
        Try
            aux(2) = BDataGridViewPer.SelectedRows.Item(0).Cells(0).Value
            Dim personaQuery As ObjectQuery(Of Personas) = _
                    BDContext.Personas.Where("it.Id = @Id")
            personaQuery.Parameters.Add(New ObjectParameter("Id", aux(2)))

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

            BMaskedTextBoxDni.Text = personaActivada.Dni
            BTextBoxNombre.Text = personaActivada.Nombre
            BTextBoxApellido.Text = personaActivada.Apellido
            BTextBoxDireccion.Text = personaActivada.Direccion
            Call readOnlyForm(BSplitContainer.Panel1, True)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BMaskedTextBoxDni_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles BMaskedTextBoxDni.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Try
                Dim personaQuery As ObjectQuery(Of Personas) = _
                    BDContext.Personas.Where("it.Dni = @Dni")
                personaQuery.Parameters.Add(New ObjectParameter("Dni", CInt(BMaskedTextBoxDni.Text)))

                If personaQuery.Any Then
                    BTextBoxNombre.Text = personaQuery.First.Nombre
                    BTextBoxApellido.Text = personaQuery.First.Apellido
                    BTextBoxDireccion.Text = personaQuery.First.Direccion
                    aux(2) = personaQuery.First.Id
                Else
                    MessageBox.Show("No se encontro ninguna persona con DNI: " + BMaskedTextBoxDni.Text, _
                                "Baja Personas", _
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call limpiarForm(BSplitContainer.Panel1)
                    BMaskedTextBoxDni.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

#End Region

End Class
