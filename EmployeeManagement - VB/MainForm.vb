Public Class MainForm
    Private Sub pbEmployee_Click(sender As Object, e As EventArgs) Handles pbEmployee.Click

        Me.Hide()
        Dim Emp = New Employee
        Emp.Show()

    End Sub

    Private Sub lblEmployee_Click(sender As Object, e As EventArgs) Handles lblEmployee.Click
        Me.Hide()
        Dim Emp = New Employee
        Emp.Show()
    End Sub

    Private Sub pbDetails_Click(sender As Object, e As EventArgs) Handles pbDetails.Click
        Me.Hide()
        Dim Det = New Details
        Det.Show()
    End Sub

    Private Sub lblDetails_Click(sender As Object, e As EventArgs) Handles lblDetails.Click
        Me.Hide()
        Dim Det = New Details
        Det.Show()
    End Sub

    Private Sub pbSalary_Click(sender As Object, e As EventArgs) Handles pbSalary.Click
        Me.Hide()
        Dim Sal = New Salary
        Sal.Show()
    End Sub

    Private Sub lblSalary_Click(sender As Object, e As EventArgs) Handles lblSalary.Click
        Me.Hide()
        Dim Sal = New Salary
        Sal.Show()
    End Sub

    Private Sub lblX_Click(sender As Object, e As EventArgs) Handles lblX.Click
        Application.Exit()
    End Sub

    Private Sub lblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click
        Dim log = New Login
        log.Show()
        Me.Hide()

    End Sub
End Class