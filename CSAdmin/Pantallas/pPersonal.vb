Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Data.EntityClient

Public Class pPersonal
    ' aux() es utilizado para guardar temporalmente el Id de la persona en c/ pestaña
    Private aux() As Integer = {0, 0, 0}
    Friend nuevaPersona As CSAdmin.Personas

    Private Sub pPersonal_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            nuevaPersona = New CSAdmin.Personas
            Dim personasQuery As ObjectQuery(Of Personas) = _
                    Main.BDContext.Personas.Where("it.Baja = True")
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
                    nuevaPersona = New CSAdmin.Personas
                    Dim personasQuery As ObjectQuery(Of Personas) = _
                        Main.BDContext.Personas.Where("it.Baja = True")
                    ADataGridViewPer.DataSource = personasQuery.Select("it.Id, it.Dni, it.Nombre, it.Apellido")
                Case 1
                    Dim personasQuery As ObjectQuery(Of Personas) = _
                        Main.BDContext.Personas
                    MDataGridViewPer.DataSource = personasQuery.Select( _
                        "it.Id, it.Dni, it.Cuit, it.Nombre, it.Apellido, it.Direccion, it.Correo, it.Baja")
                Case 2
                    Dim personasQuery As ObjectQuery(Of Personas) = _
                        Main.BDContext.Personas.Where("it.Baja = False")
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

#Region "ALTA"
    ' Se utiliza aux(0)

    ' En caso de que se este reactivando
    ' un usuario no se puede añadir informacion
    Private soloLectura As Boolean = False

    Private Sub AButtonTelefonos_Click(sender As System.Object, e As System.EventArgs) Handles AButtonTelefonos.Click
        Dim tel As TelPopUp = New TelPopUp(nuevaPersona, soloLectura)
        With tel
            .StartPosition = FormStartPosition.CenterParent
            .aux = aux(0)
        End With
        tel.ShowDialog()
    End Sub

    Private Sub AButtonAceptar_Click(sender As System.Object, e As System.EventArgs) Handles AButtonAceptar.Click
        Try
            With nuevaPersona
                .Dni = AMaskedTextBoxDni.Text
                .Cuit = AMaskedTextBoxCuit.Text
                .Nombre = ATextBoxNombre.Text
                .Apellido = ATextBoxApellido.Text
                .Direccion = ATextBoxDireccion.Text
                .Correo = ATextBoxCorreo.Text
                .Baja = False
            End With
            Main.BDContext.AddToPersonas(nuevaPersona)
            Main.BDContext.SaveChanges()
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
        soloLectura = False
        aux(0) = 0
    End Sub

    Private Sub AButtonReactivar_Click(sender As System.Object, e As System.EventArgs) Handles AButtonReactivar.Click
        Try
            Dim personaQ As ObjectQuery(Of Personas) = _
                Main.BDContext.Personas.Where("it.Id = @Id")
            personaQ.Parameters.Add(New ObjectParameter("Id", aux(0)))

            personaQ.First.Baja = False
            Main.BDContext.SaveChanges()
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
                    Main.BDContext.Personas.Where("it.Id = @Id")
            personasQuery.Parameters.Add(New ObjectParameter("Id", aux(0)))

            AMaskedTextBoxDni.Text = personasQuery.First.Dni
            AMaskedTextBoxCuit.Text = personasQuery.First.Cuit
            ATextBoxNombre.Text = personasQuery.First.Nombre
            ATextBoxApellido.Text = personasQuery.First.Apellido
            ATextBoxDireccion.Text = personasQuery.First.Direccion
            ATextBoxCorreo.Text = personasQuery.First.Correo
            Call readOnlyForm(ASplitContainer.Panel1, True)
            AButtonAceptar.Enabled = False
            AButtonReactivar.Visible = True
            soloLectura = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AMaskedTextBoxDni_Leave(sender As System.Object, e As System.EventArgs) Handles AMaskedTextBoxDni.Leave
        Try
            Dim personaQuery As ObjectQuery(Of Personas) = _
                Main.BDContext.Personas.Where("it.Dni = @Dni")
            personaQuery.Parameters.Add(New ObjectParameter("Dni", CInt(AMaskedTextBoxDni.Text)))

            If personaQuery.Any Then
                If personaQuery.First.Baja Then
                    AMaskedTextBoxCuit.Text = personaQuery.First.Cuit
                    ATextBoxNombre.Text = personaQuery.First.Nombre
                    ATextBoxApellido.Text = personaQuery.First.Apellido
                    ATextBoxDireccion.Text = personaQuery.First.Direccion
                    ATextBoxCorreo.Text = personaQuery.First.Correo
                    aux(0) = personaQuery.First.Id
                    Call readOnlyForm(ASplitContainer.Panel1, True)
                    AButtonAceptar.Enabled = False
                    AButtonReactivar.Visible = True
                    soloLectura = True
                Else
                    MessageBox.Show(personaQuery.First.Nombre + " " + personaQuery.First.Apellido + " ya se encuentra dado de alta.", _
                            "Agregar Personas", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
                    AMaskedTextBoxDni.Clear()
                    AMaskedTextBoxDni.Focus()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "MODIFICAR"
    ' Se utiliza aux(1)
    Private Sub MMaskedTextBoxDni_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MMaskedTextBoxDni.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Try
                Dim personaQuery As ObjectQuery(Of Personas) = _
                    Main.BDContext.Personas.Where("it.Dni = @Dni")
                personaQuery.Parameters.Add(New ObjectParameter("Dni", CInt(MMaskedTextBoxDni.Text)))

                If personaQuery.Any Then
                    MMaskedTextBoxCuit.Text = personaQuery.First.Cuit
                    MTextBoxNombre.Text = personaQuery.First.Nombre
                    MTextBoxApellido.Text = personaQuery.First.Apellido
                    MTextBoxDireccion.Text = personaQuery.First.Direccion
                    MTextBoxCorreo.Text = personaQuery.First.Correo
                    aux(1) = personaQuery.First.Id
                Else
                    MessageBox.Show("No se encontro ninguna persona con DNI: " + MMaskedTextBoxDni.Text, _
                                "Modificar Personas", _
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call limpiarForm(MSplitContainer.Panel1)
                    MMaskedTextBoxDni.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub MButtonModificar_Click(sender As System.Object, e As System.EventArgs) Handles MButtonModificar.Click
        Try
            If aux(1) <> 0 Then
                Dim personaQuery As ObjectQuery(Of CSAdmin.Personas) = _
                                Main.BDContext.Personas.Where("it.Id = @Id")
                personaQuery.Parameters.Add(New ObjectParameter("Id", aux(1)))
                personaQuery.First.Dni = MMaskedTextBoxDni.Text
                personaQuery.First.Cuit = MMaskedTextBoxCuit.Text
                personaQuery.First.Nombre = MTextBoxNombre.Text
                personaQuery.First.Apellido = MTextBoxApellido.Text
                personaQuery.First.Direccion = MTextBoxDireccion.Text
                personaQuery.First.Correo = MTextBoxCorreo.Text
                Main.BDContext.SaveChanges()
                MessageBox.Show("Se modifico: " + personaQuery.First.Nombre + " " + personaQuery.First.Apellido, _
                                "Modificación de Personas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call limpiarForm(MSplitContainer.Panel1)
                MMaskedTextBoxDni.Focus()
                aux(1) = 0
            Else
                MessageBox.Show("Actualmente no se esta editando ninguna Persona", "Modificación de Personas", _
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                MMaskedTextBoxDni.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MButtonCancelar_Click(sender As System.Object, e As System.EventArgs) Handles MButtonCancelar.Click
        ' Limpia el fomrulario.
        Call limpiarForm(MSplitContainer.Panel1)
        Call readOnlyForm(MSplitContainer.Panel1, False)
        MMaskedTextBoxDni.Focus()
        aux(1) = 0
    End Sub

    Private Sub MButtonTelefonos_Click(sender As System.Object, e As System.EventArgs) Handles MButtonTelefonos.Click
        Dim tel As TelPopUp = New TelPopUp(nuevaPersona, soloLectura)
        With tel
            .StartPosition = FormStartPosition.CenterParent
            .aux = aux(0)
        End With
        tel.ShowDialog()
    End Sub

    Private Sub MDataGridViewPer_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MDataGridViewPer.CellDoubleClick
        Try
            aux(1) = MDataGridViewPer.SelectedRows.Item(0).Cells(0).Value
            Dim personasQuery As ObjectQuery(Of Personas) = _
                    Main.BDContext.Personas.Where("it.Id = @Id")
            personasQuery.Parameters.Add(New ObjectParameter("Id", aux(1)))

            MMaskedTextBoxDni.Text = personasQuery.First.Dni
            MMaskedTextBoxCuit.Text = personasQuery.First.Cuit
            MTextBoxNombre.Text = personasQuery.First.Nombre
            MTextBoxApellido.Text = personasQuery.First.Apellido
            MTextBoxDireccion.Text = personasQuery.First.Direccion
            MTextBoxCorreo.Text = personasQuery.First.Correo
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
            If aux(2) <> 0 Then
                Dim personaQ As ObjectQuery(Of Personas) = _
                Main.BDContext.Personas.Where("it.Id = @Id")
                personaQ.Parameters.Add(New ObjectParameter("Id", aux(2)))

                personaQ.First.Baja = True
                Main.BDContext.SaveChanges()
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
                    Main.BDContext.Personas.Where("it.Id = @Id")
            personaQuery.Parameters.Add(New ObjectParameter("Id", aux(2)))

            BMaskedTextBoxDni.Text = personaQuery.First.Dni
            BTextBoxNombre.Text = personaQuery.First.Nombre
            BTextBoxApellido.Text = personaQuery.First.Apellido
            BTextBoxDireccion.Text = personaQuery.First.Direccion
            Call readOnlyForm(BSplitContainer.Panel1, True)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BMaskedTextBoxDni_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles BMaskedTextBoxDni.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Try
                Dim personaQuery As ObjectQuery(Of Personas) = _
                    Main.BDContext.Personas.Where("it.Dni = @Dni")
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