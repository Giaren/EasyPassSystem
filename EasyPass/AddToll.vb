Imports System.Data.SqlClient
Public Class AddToll
    Dim maxinfinity As Integer = 9999
    Dim dom(maxinfinity) As Integer
    Dim TollCode As Integer
    Dim strTollcode As String
    Dim Strname As String = "Scheme.mdf"
    Dim fix As Double = 0
    Dim strUserDocFldr As String = Environment.CurrentDirectory
    Dim strUserDocFldrSimpl As String = System.IO.Path.GetFullPath(strUserDocFldr).Replace("bin\Debug", "")
    Dim newFullPath As String = System.IO.Path.Combine(strUserDocFldrSimpl, Strname)

    Dim connection As New SqlConnection(("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & newFullPath & ";Integrated Security=True"))
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Try


        'Variables created to have a connection to the sql server database, sql command and to read sql data from the table

        Dim mycommand As New SqlCommand
            Dim mydatareader As SqlDataReader
            'my connection string data source retrieved from the source service database path Scheme.mdf
            'opening of my connection
            connection.Open()
            'Assigns my variable which holds the sql commands to my sql connection
            mycommand.Connection = connection
            mycommand.CommandType = CommandType.Text
        mycommand.CommandText = "Select * from TollDescription where TollName='" & txtEntryPoint.Text & "' AND TollType='" & CmbTolltype.Text & "' "
        mydatareader = mycommand.ExecuteReader
        If mydatareader.HasRows Then
            'if email already exists it will give you the message below
            MsgBox("This toll already exists", MsgBoxStyle.Critical)
            connection.Close()
        Else
            connection.Close()

            Dim rnd As New Random
            For i As Integer = 1000 To maxinfinity - 1
                dom(i) = rnd.Next(1000, 9999)

                If dom(i) <= 1 Then
                    TollCode += 1
                End If

            Next
            strTollcode = TollCode.ToString()



            'Variables created to have a connection to the sql server database, sql command and to read sql data from the table
            Dim tagconnect As New SqlConnection
            Dim tagcommand As New SqlCommand
            Dim tagdatareader As SqlDataReader
            Dim Generator As New Random
            Dim myrand As Integer
            'my connection string data source retrieved from the source service database path Scheme.mdf

            'opening of my connection
            connection.Open()
            'Assigns my variable which holds the sql commands to my sql connection
            tagcommand.Connection = connection
            tagcommand.CommandType = CommandType.Text
            tagcommand.CommandText = "Select * from TollDescription where Tollcode ='" & strTollcode & "' "
            tagdatareader = tagcommand.ExecuteReader
            Do
                'if the tag already exists for a customer it will give you the message below that "The tag is already taken"
                myrand = Generator.Next(1000, 9999)

            Loop While tagdatareader.HasRows
            strTollcode = myrand.ToString
            'else if it does not exists you will be fine and it will insert and be recorded into the table called register
            connection.Close()
            connection.Open()
            mycommand = New SqlCommand("INSERT INTO TollDescription values('" & strTollcode & "','" & txtEntryPoint.Text & "','" & txtFareprice.Text & "','" & CmbTolltype.Text & "','" & txtEndpoint.Text & "','" & fix & "')", connection)
            ' This means if the customers leaves the text box incomplete be putting nothing they will get a message
            If (txtEndpoint.Text = "" Or txtFareprice.Text = "" Or txtEntryPoint.Text = "" Or CmbTolltype.Text = "") Then
                MessageBox.Show("Please enter the details")
            Else

                ' if the customer entered and filled the form they will be sucessfully registered

                mycommand.ExecuteNonQuery()

                MsgBox("You have added a new toll for EZ PASS.", MsgBoxStyle.Information, "Success")
                'Hides the current form CustomerRegister

                'Opens up the Customer login form after they have successfully registered for ez pass

                'Clears all text boxes in the CustomerRegister form
                txtEndpoint.Clear()
                txtEntryPoint.Clear()
                txtFareprice.Clear()

                Me.Hide()
            End If
            'Closing my connection
            connection.Close()

            Dim adapter As New SqlDataAdapter("Select TollCode, TollName, Fare, TollType, EndPoint FROM TollDescription", connection)

            Dim table2 As New DataTable()

            adapter.Fill(table2)

            UpdateTolls.TollInformation.DataSource = table2
        End If

        'Catch ex As Exception
        'If anything goes wrong while running ez pass will get this message"error"
        'MsgBox("Error")

        'End Try
    End Sub
    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()

    End Sub
    Private Sub AddToll_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEndpoint.Clear()
        txtEntryPoint.Clear()
        txtFareprice.Clear()
    End Sub

    Private Sub txtEntryPoint_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEntryPoint.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                e.Handled = True
                MessageBox.Show("You can only enter letters a to z here")
            End If
        End If
    End Sub

    Private Sub txtEndpoint_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEndpoint.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                e.Handled = True
                MessageBox.Show("You can only enter letters a to z here")
            End If
        End If
    End Sub
End Class