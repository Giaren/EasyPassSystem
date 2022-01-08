Imports System.Data.SqlClient

Public Class Search

    Dim Strname As String = "Scheme.mdf"

    Dim strUserDocFldr As String = Environment.CurrentDirectory
    Dim strUserDocFldrSimpl As String = System.IO.Path.GetFullPath(strUserDocFldr).Replace("bin\Debug", "")
    Dim newFullPath As String = System.IO.Path.Combine(strUserDocFldrSimpl, Strname)

    Dim connection As New SqlConnection(("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & newFullPath & ";Integrated Security=True"))
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtEmail.Clear()
        txtTagID.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim mycommand As New SqlCommand
        Dim mydatareader As SqlDataReader
        connection.Open()
        mycommand.Connection = connection
        mycommand.CommandType = CommandType.Text
        mycommand.CommandText = "Select * from Register Where email='" & txtEmail.Text & "' OR FirstName= '" & txtFirstName.Text & "' OR LastName= '" & txtLastName.Text & "' OR TagID= '" & txtTagID.Text & "' "
        mydatareader = mycommand.ExecuteReader

        If mydatareader.HasRows Then

            Me.Hide()
            Dim adapter As New SqlDataAdapter("Select CustomerId, FirstName, LastName, Address, Email, PhoneNumber, AccountNumber, State, Make, Model, Year, TagID, Password, PlateNumber, Balance, DateSD, Revenue FROM Register Where email='" & txtEmail.Text & "' OR FirstName= '" & txtFirstName.Text & "' OR LastName= '" & txtLastName.Text & "' OR TagID= '" & txtTagID.Text & "' ", connection)

            Dim table As New DataTable()
            connection.Close()
            adapter.Fill(table)

            CustomerInformation.CustomerInfo.DataSource = table

        Else

            MsgBox("There is no data matching", MsgBoxStyle.Critical)
        End If
        connection.Close()
    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                e.Handled = True
                MessageBox.Show("You can only enter letters a to z here")
            End If
        End If
    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                e.Handled = True
                MessageBox.Show("You can only enter letters a to z here")
            End If
        End If
    End Sub

    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class