Imports System.Data.SqlClient
Public Class CustomerRegister
    'Creating an array of numbers
    Dim maxinfinity As Integer = 1000
    Dim dom(maxinfinity) As Integer
    Dim customertag As Integer
    Dim status As String = "Active"
    Dim strDateSD As String
    Dim rev As Double = 0
    Dim strFile As String = ""
    Dim Strname As String = "Scheme.mdf"

    Dim strUserDocFldr As String = Environment.CurrentDirectory
    Dim strUserDocFldrSimpl As String = System.IO.Path.GetFullPath(strUserDocFldr).Replace("bin\Debug", "")
    Dim newFullPath As String = System.IO.Path.Combine(strUserDocFldrSimpl, Strname)

    Dim connection As New SqlConnection(("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & newFullPath & ";Integrated Security=True"))
    Private Sub BtnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click

        If (FirstName.Text = "" Or LastName.Text = "" Or Address.Text = "" Or Email.Text = "" Or AccountNumber.Text = "" Or PhoneNumber.Text = "" Or Statelst.Text = "" Or Make.Text = "" Or Model.Text = "" Or Year.Text = "" Or Password.Text = "" Or PlateNumber.Text = "") Then
            MessageBox.Show("Please enter the details")
        Else
            'puts the date customer requested a tag and signed up for ez pass
            strDateSD = Date.Now.ToString("dd-MM-yyyy")
            DateSD.Text = strDateSD
            btnSignUp.Enabled = True
            'Assigns a random tag to a customer
            Dim rnd As New Random
            For i As Integer = 0 To maxinfinity - 1
                dom(i) = rnd.Next(0, 99)

                If dom(i) <= 1 Then
                    customertag += 1
                End If

            Next
            TagID.Text = customertag.ToString()

            'Try


            'Variables created to have a connection to the sql server database, sql command and to read sql data from the table

            Dim tagcommand As New SqlCommand
            Dim tagdatareader As SqlDataReader
            'my connection string data source retrieved from the source service database path Scheme.mdf

            'opening of my connection
            connection.Open()
            'Assigns my variable which holds the sql commands to my sql connection
            tagcommand.Connection = connection
            tagcommand.CommandType = CommandType.Text
            tagcommand.CommandText = "Select * from Taginventory where TagID ='" & TagID.Text & "' "
            tagdatareader = tagcommand.ExecuteReader
            If tagdatareader.HasRows Then
                'if the tag already exists for a customer it will give you the message below that "The tag is already taken"
                MsgBox("Tag is already taken", MsgBoxStyle.Critical)
                connection.Close()
            Else
                'else if it does not exists it will be inserted and recorded inside of the table "TagInventory"'
                connection.Close()
                connection.Open()
                tagcommand = New SqlCommand("INSERT INTO TagInventory values('" & status & "','" & DateSD.Text & "','" & TagID.Text & "')", connection)

                txtStatus.Text = status

                tagcommand.ExecuteNonQuery()

                MsgBox("Tag Stored.", MsgBoxStyle.Information, "Success")

                connection.Close()
            End If
            connection.Close()
        End If

        ' Catch ex As Exception
        ' MsgBox("Error")

        'End Try

    End Sub



    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Try


            'Variables created to have a connection to the sql server database, sql command and to read sql data from the table

            Dim mycommand As New SqlCommand
            Dim mydatareader As SqlDataReader
            'my connection string data source retrieved from the source service database path Scheme.mdf
            'opening of my connection
            connection.Open()
            'Assigns my variable which holds the sql commands to my sql connection
            mycommand.Connection = connection
            mycommand.CommandType = CommandType.Text
            mycommand.CommandText = "Select * from Register where email='" & Email.Text & "' "
            mydatareader = mycommand.ExecuteReader
            If mydatareader.HasRows Then
                'if email already exists it will give you the message below
                MsgBox("Email is already been taken", MsgBoxStyle.Critical)
                connection.Close()
            Else
                'else if it does not exists you will be fine and it will insert and be recorded into the table called register
                connection.Close()
                connection.Open()
                mycommand = New SqlCommand("INSERT INTO Register values('" & FirstName.Text & "','" & LastName.Text & "','" & Address.Text & "','" & Email.Text & "','" & PhoneNumber.Text & "','" & AccountNumber.Text & "','" & Statelst.Text & "','" & Make.Text & "','" & Model.Text & "','" & Year.Text & "','" & TagID.Text & "','" & Password.Text & "','" & PlateNumber.Text & "','" & Balance.Text & "','" & DateSD.Text & "', '" & rev & "')", connection)
                ' This means if the customers leaves the text box incomplete be putting nothing they will get a message
                If (FirstName.Text = "" Or LastName.Text = "" Or Address.Text = "" Or Email.Text = "" Or DateSD.Text = "" Or AccountNumber.Text = "" Or PhoneNumber.Text = "" Or Statelst.Text = "" Or Make.Text = "" Or Model.Text = "" Or Year.Text = "" Or TagID.Text = "" Or Password.Text = "" Or PlateNumber.Text = "" Or Balance.Text = "") Then
                    MessageBox.Show("Please enter the details")
                Else

                    txtStatus.Text = status
                    ' if the customer entered and filled the form they will be sucessfully registered

                    mycommand.ExecuteNonQuery()

                    MsgBox("You have registered for EZ PASS.", MsgBoxStyle.Information, "Success")
                    'Hides the current form CustomerRegister
                    Me.Hide()
                    'Opens up the Customer login form after they have successfully registered for ez pass
                    CustomerLogin.Show()
                    'Clears all text boxes in the CustomerRegister form
                    FirstName.Clear()
                    LastName.Clear()
                    Address.Clear()
                    Email.Clear()
                    DateSD.Clear()
                    AccountNumber.Clear()
                    PlateNumber.Clear()
                    Make.Clear()
                    Model.Clear()
                    Year.Clear()
                    TagID.Clear()
                    Password.Clear()
                    Balance.Clear()
                End If
                'Closing my connection
                connection.Close()


            End If
            connection.Close()




        Catch ex As Exception
            'If anything goes wrong while running ez pass will get this message"error"
            MsgBox("Error")

        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'hides the register form and sends user back to the frm menu
        Me.Hide()
        frmMenu.Show()

        FirstName.Clear()
        LastName.Clear()
        Address.Clear()
        Email.Clear()
        DateSD.Clear()
        AccountNumber.Clear()
        PlateNumber.Clear()

        Make.Clear()
        Model.Clear()
        Year.Clear()
        TagID.Clear()
        Password.Clear()
        Balance.Clear()
    End Sub

    Private Sub CustomerRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
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

    Private Sub AccountNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AccountNumber.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then
        Else
            e.Handled = True
            MessageBox.Show("Numbers only")
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

    Private Sub Balance_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Balance.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then
        Else
            e.Handled = True
            MessageBox.Show("Numbers only")
        End If
    End Sub
End Class