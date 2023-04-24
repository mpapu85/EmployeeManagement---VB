Imports System.Configuration
Imports System.Data.SqlClient

Public Class Details
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Milan\OneDrive\Documents\EmployeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub FetchData()
        If txtEmployeeId.Text = "" Then
            MsgBox("Enter the Employee Id")
        Else
            Con.Open()
            Dim sql = "select * from EmployeeTbl where EmployeeId = '" & txtEmployeeId.Text & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(sql, Con)
            Dim dt As DataTable
            dt = New DataTable
            Dim adapter As SqlDataAdapter
            adapter = New SqlDataAdapter(cmd)
            adapter.Fill(dt)
            For Each dr As DataRow In dt.Rows
                lblFirstNameInput.Text = dr(1).ToString()
                lblSecondNameInput.Text = dr(2).ToString()
                lblAddressInput.Text = dr(3).ToString()
                lblPhoneInput.Text = dr(4).ToString()
                lblGenderInput.Text = dr(5).ToString()
                lblPositionInput.Text = dr(6).ToString()
                lblEducationInput.Text = dr(7).ToString()
                lblFirstNameInput.Visible = True
                lblSecondNameInput.Visible = True
                lblAddressInput.Visible = True
                lblPhoneInput.Visible = True
                lblGenderInput.Visible = True
                lblPositionInput.Visible = True
                lblEducationInput.Visible = True
            Next
            Con.Close()
        End If
    End Sub
    Private Sub pbBack_Click(sender As Object, e As EventArgs) Handles pbBack.Click
        Me.Hide()
        Dim Home = New MainForm
        Home.Show()
    End Sub

    Private Sub lblX_Click(sender As Object, e As EventArgs) Handles lblX.Click
        Application.Exit()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        FetchData()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Employee Management System", New Font("Century Gothic", 25), Brushes.DarkBlue, 180, 40)
        e.Graphics.DrawString("***EMPLOYEE SUMMARY***", New Font("Arial", 20), Brushes.Crimson, 250, 100)
        e.Graphics.DrawString("First Name:     " + lblFirstNameInput.Text + vbTab + "Second Name:     " + lblSecondNameInput.Text, New Font("Century Gothic", 12), Brushes.Black, 140, 205)
        e.Graphics.DrawString("Address:     " + lblAddressInput.Text + vbTab + "Phone:     " + lblPhoneInput.Text, New Font("Century Gothic", 12), Brushes.Black, 140, 265)
        e.Graphics.DrawString("Gender:     " + lblGenderInput.Text + vbTab + "Education:     " + lblEducationInput.Text, New Font("Century Gothic", 12), Brushes.Black, 140, 325)
        e.Graphics.DrawString("Position:     " + lblPositionInput.Text, New Font("Century Gothic", 12), Brushes.Black, 140, 385)

        e.Graphics.DrawString("**********Thanks For Your Services**********", New Font("Century Gothic", 15), Brushes.DarkBlue, 150, 500)


    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Show()

    End Sub
End Class