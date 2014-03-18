Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Data.EntityClient

Public Class TelPopUp
    Friend aux As Integer = 0
    Friend persona As New CSAdmin.Personas
    Private soloLectura As Boolean

    Private Sub TelPopUp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            If soloLectura Then
                MaskedTextBoxTel.Enabled = False
                ComboBoxTipo.Enabled = False
                ButtonAgregar.Enabled = False
            Else
                MaskedTextBoxTel.Enabled = True
                ComboBoxTipo.Enabled = True
                ButtonAgregar.Enabled = True
                ComboBoxTipo.SelectedIndex = 0
            End If
            Dim personasTelQuery As ObjectQuery(Of PersonasTel) = _
                   Main.BDContext.PersonasTel.Where("it.IdPersona = @Id")
            personasTelQuery.Parameters.Add(New ObjectParameter("Id", aux))
            DataGridViewTel.DataSource = personasTelQuery.Select("it.Tipo, it.Numero")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TelPopUp_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub ButtonAgregar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAgregar.Click
        Try
            Dim nuevoTel As New CSAdmin.PersonasTel
            With nuevoTel
                .Numero = MaskedTextBoxTel.Text
                .Tipo = ComboBoxTipo.SelectedItem
            End With
            persona.PersonasTel.Add(nuevoTel)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub New(ByRef per As CSAdmin.Personas, ByVal modo As Boolean)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


        ' Se pasa por referencia el objeto para poder agregar los telefonos a la clase
        persona = per
        soloLectura = modo
    End Sub
End Class