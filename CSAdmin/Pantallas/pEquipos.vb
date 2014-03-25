Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Data.EntityClient

Public Class pEquipos
    Dim autocompleteEquipos As New AutoCompleteStringCollection

    Private Sub pEquipos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Dim EquiposQuery = _
                From eq In Main.BDContext.Equipos _
                Select New With _
                { _
                    .Id = eq.Id, _
                    .Ubicacion = eq.Ubicacion, _
                    .Localidad = eq.Localidades.Localidad, _
                    .Coordinador = eq.Personas.Nombre + " " + eq.Personas.Apellido, _
                    .Telefono = eq.Telefono, _
                    .Correo = eq.Correo _
                }

            ' Muestra todos los equipos en el Datagrid
            ADataGridViewEquipos.DataSource = EquiposQuery

            ' Carga los campos para autocompletar el nombre de equipo
            For Each eq In Main.BDContext.Equipos
                autocompleteEquipos.Add(eq.Id)
            Next
            ATextBoxNombre.AutoCompleteCustomSource = autocompleteEquipos

            ' Carga combobox de Localidades
            AComboBoxLocalidad.DataSource = Main.BDContext.Localidades.ToList()
            AComboBoxLocalidad.DisplayMember = "Localidad"
            AComboBoxLocalidad.ValueMember = "Id"

            ' Carga combobox de Coordinadores
            AComboBoxCoordinador.DataSource = Main.BDContext.Personas.ToList()
            AComboBoxCoordinador.DisplayMember = "NombreCompleto"
            AComboBoxCoordinador.ValueMember = "Id"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#Region "ALTA"
    Private Sub AButtonAceptar_Click(sender As System.Object, e As System.EventArgs) Handles AButtonAceptar.Click
        Try
            Dim nuevoEquipo As New Equipos
            With nuevoEquipo
                .Id = ATextBoxNombre.Text
                .Ubicacion = ATextBoxUbicacion.Text
                .LocalidadId = AComboBoxLocalidad.SelectedValue
                .Correo = ATextBoxCorreo.Text
                .Contra = ATextBoxContra.Text
                If Not AMaskedTextBoxTelefono.Text = "" Then
                    .Telefono = AMaskedTextBoxTelefono.Text
                End If
                .CoordinadoId = AComboBoxCoordinador.SelectedValue
            End With

            Main.BDContext.AddToEquipos(nuevoEquipo)
            Main.BDContext.SaveChanges()
            MessageBox.Show("Se agrego: " + nuevoEquipo.Id + " a Equipos.", _
                            "Alta Equipos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call limpiarForm(ASplitContainer.Panel1)
            ATextBoxNombre.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AButtonCancelar_Click(sender As System.Object, e As System.EventArgs) Handles AButtonCancelar.Click
        Call limpiarForm(ASplitContainer.Panel1)
        ATextBoxNombre.Focus()
    End Sub
#End Region

#Region "MODIFICAR"

#End Region

#Region "BAJA"

#End Region
End Class
