Public Class SampleIPrincipal
    Implements System.Security.Principal.IPrincipal

    Private identityValue As SampleIIdentity

    Public ReadOnly Property Identity() As System.Security.Principal.IIdentity Implements System.Security.Principal.IPrincipal.Identity
        Get
            Return identityValue
        End Get
    End Property

    Public Function IsInRole(ByVal role As String) As Boolean Implements System.Security.Principal.IPrincipal.IsInRole
        Return role = identityValue.Role.ToString
    End Function

    Public Sub New(ByVal name As String, ByVal pass As String)
        identityValue = New SampleIIdentity(name, pass)
    End Sub
End Class
