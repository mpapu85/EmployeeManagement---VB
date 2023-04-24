Imports System.Data.SqlClient

Public Class Employee
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Milan\OneDrive\Documents\EmployeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Dim key = 0
    Private Sub pbBack_Click(sender As Object, e As EventArgs) Handles pbBack.Click
        Me.Hide()
        Dim Home = New MainForm
        Home.Show()
    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub
    Private Sub Populate()
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If
        Dim sql = "select * from EmployeeTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        dgvTableView.DataSource = ds.Tables(0)
        Con.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Con.Open()
            Dim Query As String
            Query = "insert into EmployeeTbl values ('" & txtFirstName.Text & "','" & txtSecondName.Text & "','" & txtAddress.Text & "','" & txtPhone.Text & "','" & cbGender.SelectedItem.ToString() & "','" & cbPosition.SelectedItem.ToString() & "','" & cbEducation.SelectedItem.ToString() & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Employee Added")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Con.Close()
        End Try
        Populate()
        Clear()
    End Sub
    Private Sub Clear()
        txtFirstName.Clear()
        txtSecondName.Clear()
        txtAddress.Clear()
        txtPhone.Clear()
        cbGender.Text = ""
        cbPosition.Text = ""
        cbEducation.Text = ""
        key = 0
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If key = 0 Then
            MsgBox("Select the employee to delete")
        Else
            Try

                Con.Open()
                Dim Query As String
                Query = "delete from EmployeeTbl where EmployeeId = '" & key & "'"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Employee Deleted Successfully")


            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Con.Close()
            End Try
            Populate()
            Clear()
        End If


    End Sub

    Private Sub dgvTableView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvTableView.CellMouseClick
        Dim row As DataGridViewRow = dgvTableView.Rows(e.RowIndex)
        key = Convert.ToInt32(row.Cells(0).Value.ToString())
        txtFirstName.Text = row.Cells(1).Value.ToString()
        txtSecondName.Text = row.Cells(2).Value.ToString()
        txtAddress.Text = row.Cells(3).Value.ToString()
        txtPhone.Text = row.Cells(4).Value.ToString()
        cbGender.Text = row.Cells(5).Value.ToString()
        cbPosition.Text = row.Cells(6).Value.ToString()
        cbEducation.Text = row.Cells(7).Value.ToString()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtFirstName.Text = "" Or txtSecondName.Text = "" Or txtAddress.Text = "" Or txtPhone.Text = "" Then
            MsgBox("Missing information")
        Else
            Con.Open()
            Dim Query As String
            Query = "update EmployeeTbl set FirstName = '" & txtFirstName.Text & "',SecondName = '" & txtSecondName.Text & "', Address = '" & txtAddress.Text & "', Phone = '" & txtPhone.Text & "', Gender = '" & cbGender.SelectedItem.ToString() & "', Position = '" & cbPosition.SelectedItem.ToString() & "', Education = '" & cbEducation.SelectedItem.ToString() & "' where EmployeeId = '" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Employee Updated")
            Con.Close()
            Populate()
            Clear()

        End If
    End Sub

    Private Sub lblX_Click(sender As Object, e As EventArgs) Handles lblX.Click
        Application.Exit()

    End Sub

End Class