Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Login de Prueba
        If UsernameTextBox.Text = "admin" Then
            If PasswordTextBox.Text = "admin" Then
                Me.Close()
            Else
                MessageBox.Show("Contraseña incorrecta, intente nuevamente.", _
                                "Error", _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Information)
                PasswordTextBox.SelectAll()
                PasswordTextBox.Focus()
            End If
        Else
            MessageBox.Show("Nombre de usurio incorrecto, intente nuevamente.", _
                                "Error", _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Information)
            UsernameTextBox.SelectAll()
            UsernameTextBox.Focus()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        Application.Exit()
    End Sub
End Class
