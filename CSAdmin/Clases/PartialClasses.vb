Partial Public Class Personas
    ReadOnly Property NombreCompleto As String
        Get
            Return Me.Nombre + " " + Me.Apellido
        End Get
    End Property
End Class