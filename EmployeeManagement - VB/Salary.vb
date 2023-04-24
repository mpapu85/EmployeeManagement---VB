Imports System.Data.SqlClient

Public Class Salary
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
                lblPositionInput.Text = dr(6).ToString()
                lblFirstNameInput.Visible = True
                lblSecondNameInput.Visible = True
                lblPositionInput.Visible = True
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

    Private Sub btnFatchData_Click(sender As Object, e As EventArgs) Handles btnFatchData.Click
        FetchData()
    End Sub
    Dim DailyPay
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If lblPositionInput.Text = "" Then
            MsgBox("Select an Employee")
        ElseIf txtWorkDays.Text = "" Or Convert.ToInt32(txtWorkDays.Text) > 28 Then
            MsgBox("Enter a valid Number of days")

        Else
            If lblPositionInput.Text = "Manager" Then
                DailyPay = 1200
            ElseIf lblPositionInput.Text = "Security" Then
                DailyPay = 600
            ElseIf lblPositionInput.Text = "Cleaner" Then
                DailyPay = 500
            ElseIf lblPositionInput.Text = "Accountant" Then
                DailyPay = 1200
            ElseIf lblPositionInput.Text = "IT" Then
                DailyPay = 850
            End If
            Dim total = DailyPay * Convert.ToInt32(txtWorkDays.Text)
            rtbSalary.Text = "Employee Id:        " + txtEmployeeId.Text + vbCrLf + "Employee Name:        " + lblFirstNameInput.Text + " " + lblSecondNameInput.Text + vbCrLf + "Employee position:        " + lblPositionInput.Text + vbCrLf + "Days Worked:        " + txtWorkDays.Text + vbCrLf + "Daily Salary Rs:        " + Convert.ToString(DailyPay) + vbCrLf + "Total Amount Rs:        " + Convert.ToString(total)
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Employee Management System", New Font("Century Gothic", 25), Brushes.DarkBlue, 180, 40)
        e.Graphics.DrawString("***PAYSLIP***", New Font("Arial", 20), Brushes.Crimson, 330, 100)
        e.Graphics.DrawString(rtbSalary.Text, New Font("Century Gothic", 20), Brushes.Black, 150, 190)

        e.Graphics.DrawString("**********Thanks For Your Services**********", New Font("Century Gothic", 15), Brushes.DarkBlue, 150, 500)


    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Show()
    End Sub
End Class