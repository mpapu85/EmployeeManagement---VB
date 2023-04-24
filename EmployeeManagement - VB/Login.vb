Public Class Login
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUserId.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Application.Exit()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUserId.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Enter The Urer Id and Password")
        ElseIf txtUserId.Text = "admin" And txtPassword.Text = "admin" Then
            Me.Hide()
            Dim main = New MainForm
            main.Show()
        Else
            MsgBox("Wrong User Id or Password")
        End If
    End Sub
End Class