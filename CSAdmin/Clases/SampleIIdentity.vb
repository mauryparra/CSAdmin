Imports System.Data.Objects
Imports System.Data.Objects.DataClasses

Public Class SampleIIdentity
    Implements System.Security.Principal.IIdentity

    Private BDContext As CSAdminBDEntities
    Private nameValue As String
    Private authenticatedValue As Boolean
    Private roleValue As ApplicationServices.BuiltInRole

    Public ReadOnly Property AuthenticationType() As String Implements System.Security.Principal.IIdentity.AuthenticationType
        Get
            Return "Custom Authentication"
        End Get
    End Property

    Public ReadOnly Property IsAuthenticated() As Boolean Implements System.Security.Principal.IIdentity.IsAuthenticated
        Get
            Return authenticatedValue
        End Get
    End Property

    Public ReadOnly Property Name() As String Implements System.Security.Principal.IIdentity.Name
        Get
            Return nameValue
        End Get
    End Property

    Public ReadOnly Property Role() As ApplicationServices.BuiltInRole
        Get
            Return roleValue
        End Get
    End Property

    Public Sub New(ByVal name As String, ByVal pass As String)
        If IsValidNameAndPassword(name, pass) Then
            nameValue = name
            authenticatedValue = True
        Else
            nameValue = ""
            authenticatedValue = False
            roleValue = ApplicationServices.BuiltInRole.Guest
        End If
    End Sub

    Private Function IsValidNameAndPassword( _
        ByVal username As String, _
        ByVal pass As String) As Boolean

        BDContext = New CSAdminBDEntities()
        Dim usuariosQ As ObjectQuery(Of Usuarios) = _
            BDContext.Usuarios.Where("it.Usuario = @usuario AND it.Contra = @pass ")

        usuariosQ.Parameters.Add(New ObjectParameter("usuario", username))
        usuariosQ.Parameters.Add(New ObjectParameter("pass", pass))

        If Not usuariosQ.First.Usuario = "" Then
            Select Case usuariosQ.First.Rol
                Case "ADM"
                    roleValue = ApplicationServices.BuiltInRole.Administrator
                Case "USR"
                    roleValue = ApplicationServices.BuiltInRole.User
                Case Else
                    roleValue = ApplicationServices.BuiltInRole.Guest
            End Select
            Return True
        Else
            Return False
        End If
    End Function
End Class
