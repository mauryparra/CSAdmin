Module FunSubs

    Friend Sub limpiarForm(ByVal control As Control)
        ' Restablece todos los campos del formulario
        For Each obj In control.Controls
            If obj.GetType.ToString = "System.Windows.Forms.TextBox" _
                Or obj.GetType.ToString = "System.Windows.Forms.MaskedTextBox" Then
                obj.Text = ""
            End If
        Next
    End Sub

    Friend Sub readOnlyForm(ByVal control As Control, ByVal estado As Boolean)
        For Each obj In control.Controls
            If obj.GetType.ToString = "System.Windows.Forms.TextBox" _
                Or obj.GetType.ToString = "System.Windows.Forms.MaskedTextBox" Then
                obj.ReadOnly = estado
            End If
        Next
    End Sub
End Module
