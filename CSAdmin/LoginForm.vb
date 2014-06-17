Public Class LoginForm

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Login usando autentificación personalizada contra la BD
        Dim samplePrincipal As New SampleIPrincipal( _
            UsernameTextBox.Text, PasswordTextBox.Text)
        Me.PasswordTextBox.Text = ""
        If Not (samplePrincipal.Identity.IsAuthenticated) Then
            ' El usuario no esta validado.
            MessageBox.Show("Usuario o contraseña incorrecta, intente nuevamente.", _
                            "Error", MessageBoxButtons.OK, _
                            MessageBoxIcon.Information)
            PasswordTextBox.SelectAll()
            PasswordTextBox.Focus()
        Else
            ' Usuario Validado
            My.User.CurrentPrincipal = samplePrincipal
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        Application.Exit()
    End Sub

End Class
