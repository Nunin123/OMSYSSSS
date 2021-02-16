Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim mainScreen As New frmMain

        If txtUsername.Text <> "1" Then
            MessageBox.Show("Incorrect username.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtPassword.Text <> "1" Then
            MessageBox.Show("Incorrect password.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            mainScreen.Show()
            Close()
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("MALAY KO SAU", "Hint", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
