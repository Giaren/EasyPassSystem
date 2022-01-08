Imports System.Data.SqlClient

Public Class CustomerInformation
    Dim Strname As String = "Scheme.mdf"

    Dim strUserDocFldr As String = Environment.CurrentDirectory
    Dim strUserDocFldrSimpl As String = System.IO.Path.GetFullPath(strUserDocFldr).Replace("bin\Debug", "")
    Dim newFullPath As String = System.IO.Path.Combine(strUserDocFldrSimpl, Strname)

    Dim connection As New SqlConnection(("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & newFullPath & ";Integrated Security=True"))

    Private Sub CustomerInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim adapter As New SqlDataAdapter("Select CustomerId, FirstName, LastName, Address, Email, PhoneNumber, AccountNumber, State, Make, Model, Year, TagID, Password, PlateNumber, Balance, DateSD, Revenue FROM Register", connection)

        Dim table As New DataTable()

        adapter.Fill(table)

        CustomerInfo.DataSource = table

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerInfo.CellContentClick
        Dim index As Integer

        index = e.RowIndex

        Dim selectedRow As DataGridViewRow
        selectedRow = CustomerInfo.Rows(index)

        FirstName.Text = selectedRow.Cells(1).Value.ToString()
        LastName.Text = selectedRow.Cells(2).Value.ToString()
        Address.Text = selectedRow.Cells(3).Value.ToString()
        Email.Text = selectedRow.Cells(4).Value.ToString()
        PhoneNumber.Text = selectedRow.Cells(5).Value.ToString()
        PlateNumber.Text = selectedRow.Cells(13).Value.ToString()
        Statelst.Text = selectedRow.Cells(7).Value.ToString()
        Make.Text = selectedRow.Cells(8).Value.ToString()
        Model.Text = selectedRow.Cells(9).Value.ToString()
        Year.Text = selectedRow.Cells(10).Value.ToString()
        lblTagID.Text = selectedRow.Cells(11).Value.ToString()

        FirstName.ReadOnly = False
        LastName.ReadOnly = False
        Address.ReadOnly = False
        Email.ReadOnly = False
        PhoneNumber.ReadOnly = False
        PlateNumber.ReadOnly = False
        Make.ReadOnly = False
        Model.ReadOnly = False
        Year.ReadOnly = False
        btnUpdate.Enabled = True
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles lblTagID.Click

    End Sub
    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()

    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim UpdateQuery As String = "Update Register set FirstName = '" & FirstName.Text & "', LastName = '" & LastName.Text & "', PhoneNumber = '" & PhoneNumber.Text & "', Address = '" & Address.Text & "', Email = '" & Email.Text & "', PlateNumber = '" & PlateNumber.Text & "', Year = '" & Year.Text & "', Model = '" & Model.Text & "', State = '" & Statelst.Text & "', Make = '" & Make.Text & "' Where TagID = " & lblTagID.Text & " "
        ExecuteQuery(UpdateQuery)

        Dim adapter As New SqlDataAdapter("Select * FROM Register", connection)

        Dim table As New DataTable()

        adapter.Fill(table)

        CustomerInfo.DataSource = table
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Search.Show()
    End Sub

    Private Sub FirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FirstName.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                e.Handled = True
                MessageBox.Show("You can only enter letters a to z here")
            End If
        End If
    End Sub

    Private Sub LastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LastName.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                e.Handled = True
                MessageBox.Show("You can only enter letters a to z here")
            End If
        End If
    End Sub

    Private Sub State_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                e.Handled = True
                MessageBox.Show("You can only enter letters a to z here")
            End If
        End If
    End Sub

    Private Sub Make_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Make.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                e.Handled = True
                MessageBox.Show("You can only enter letters a to z here")
            End If
        End If
    End Sub

    Private Sub Model_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Model.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                e.Handled = True
                MessageBox.Show("You can only enter letters a to z here")
            End If
        End If
    End Sub
End Class