Imports System.Data.SqlClient


Public Class CustomersAccount
    Dim Lostdate As String
    Dim ReturnDate As String

    'Lost date and return date created as strings for recording of date customers returned or lost their tags
    Dim strFile As String = ""
    Dim Strname As String = "Scheme.mdf"

    Dim strUserDocFldr As String = Environment.CurrentDirectory
    Dim strUserDocFldrSimpl As String = System.IO.Path.GetFullPath(strUserDocFldr).Replace("bin\Debug", "")
    Dim newFullPath As String = System.IO.Path.Combine(strUserDocFldrSimpl, Strname)

    Dim connection As New SqlConnection(("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & newFullPath & ";Integrated Security=True"))

    Dim strFirstname As String
    Dim strLastName As String
    Dim strPhonenumber As String
    Dim strAddress As String
    Dim strPlateNumber As String
    Dim strYear As String
    Dim strModel As String
    Dim strstate As String
    Dim strMake As String

    Dim strDateSD As String
    Dim maxinfinity As Integer = 100
    Dim dom(maxinfinity) As Integer
    Dim customertag As Integer
    Dim status As String = "Active"
    Dim strTag As String

    Dim intTagId As Integer

    Private Sub CustomersAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim sqlTagID As New SqlCommand("SELECT TagID FROM Register Where Email ='" & stremail & "'", connection)
        connection.Open()
        intTagId = Convert.ToInt32(sqlTagID.ExecuteScalar())
        connection.Close()

        'When customers log in to their ez pass account they will see only their information on a data grid view
        'fills the dataset by emails
        Dim adapter As New SqlDataAdapter("Select FirstName, LastName, Address, Email, PhoneNumber, AccountNumber, State, Make, Model, Year, TagID, PlateNumber, Balance, DateSD FROM Register where email ='" & stremail & "'", connection)

        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table

        Dim FirstNameUp As New SqlCommand("SELECT FirstName FROM Register Where Email ='" & stremail & "'", connection)
        connection.Open()
        strFirstname = Convert.ToString(FirstNameUp.ExecuteScalar())
        connection.Close()

        FirstName.Text = strFirstname

        Dim LastNameUp As New SqlCommand("SELECT LastName FROM Register Where Email ='" & stremail & "'", connection)
        connection.Open()
        strLastName = Convert.ToString(LastNameUp.ExecuteScalar())
        connection.Close()

        LastName.Text = strLastName

        Dim PhoneNumberUp As New SqlCommand("SELECT PhoneNumber FROM Register Where Email ='" & stremail & "'", connection)
        connection.Open()
        strPhonenumber = Convert.ToString(PhoneNumberUp.ExecuteScalar())
        connection.Close()

        PhoneNumber.Text = strPhonenumber

        Dim AddressUp As New SqlCommand("SELECT Address FROM Register Where Email ='" & stremail & "'", connection)
        connection.Open()
        strAddress = Convert.ToString(AddressUp.ExecuteScalar())
        connection.Close()

        Address.Text = strAddress

        Dim PlateNumberUP As New SqlCommand("SELECT PlateNumber FROM Register Where Email ='" & stremail & "'", connection)
        connection.Open()
        strPlateNumber = Convert.ToString(PlateNumberUP.ExecuteScalar())
        connection.Close()

        PlateNumber.Text = strPlateNumber

        Dim YearUP As New SqlCommand("SELECT Year FROM Register Where Email ='" & stremail & "'", connection)
        connection.Open()
        strYear = Convert.ToString(YearUP.ExecuteScalar())
        connection.Close()

        Year.Text = strYear

        Dim ModelUP As New SqlCommand("SELECT Model FROM Register Where Email ='" & stremail & "'", connection)
        connection.Open()
        strModel = Convert.ToString(ModelUP.ExecuteScalar())
        connection.Close()

        Model.Text = strModel

        Dim MakeUp As New SqlCommand("SELECT Make FROM Register Where Email ='" & stremail & "'", connection)
        connection.Open()
        strMake = Convert.ToString(MakeUp.ExecuteScalar())
        connection.Close()

        Make.Text = strMake

        Dim StateUp As New SqlCommand("SELECT State FROM Register Where Email ='" & stremail & "'", connection)
        connection.Open()
        strstate = Convert.ToString(StateUp.ExecuteScalar())
        connection.Close()

        Statelst.Text = strstate

        Email.Text = stremail




    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cmd As New SqlCommand("SELECT CustomerId FROM Register Where email ='" & stremail & "'", connection)
        connection.Open()
        CustID = Convert.ToInt32(cmd.ExecuteScalar())
        connection.Close()

        Dim UpdateQuery As String = "Update Register set FirstName = '" & FirstName.Text & "', LastName = '" & LastName.Text & "', PhoneNumber = '" & PhoneNumber.Text & "', Address = '" & Address.Text & "', Email = '" & Email.Text & "', PlateNumber = '" & PlateNumber.Text & "', Year = '" & Year.Text & "', Model = '" & Model.Text & "', State = '" & Statelst.Text & "', Make = '" & Make.Text & "' Where TagID = " & intTagId & " "
        ExecuteQuery(UpdateQuery)

        Dim adapter As New SqlDataAdapter("Select FirstName, LastName, Address, Email, PhoneNumber, AccountNumber, State, Make, Model, Year, TagID, PlateNumber, Balance, DateSD FROM Register where TagID ='" & intTagId & "'", connection)

        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table

        Dim FirstNameUp As New SqlCommand("SELECT FirstName FROM Register Where TagID ='" & intTagId & "'", connection)
        connection.Open()
        strFirstname = Convert.ToString(FirstNameUp.ExecuteScalar())
        connection.Close()

        FirstName.Text = strFirstname

        Dim LastNameUp As New SqlCommand("SELECT LastName FROM Register Where TagId ='" & intTagId & "'", connection)
        connection.Open()
        strLastName = Convert.ToString(LastNameUp.ExecuteScalar())
        connection.Close()

        LastName.Text = strLastName

        Dim PhoneNumberUp As New SqlCommand("SELECT PhoneNumber FROM Register Where TagId ='" & intTagId & "'", connection)
        connection.Open()
        strPhonenumber = Convert.ToString(PhoneNumberUp.ExecuteScalar())
        connection.Close()

        PhoneNumber.Text = strPhonenumber

        Dim AddressUp As New SqlCommand("SELECT Address FROM Register Where TagId ='" & intTagId & "'", connection)
        connection.Open()
        strAddress = Convert.ToString(AddressUp.ExecuteScalar())
        connection.Close()

        Address.Text = strAddress

        Dim PlateNumberUP As New SqlCommand("SELECT PlateNumber FROM Register Where TagId ='" & intTagId & "'", connection)
        connection.Open()
        strPlateNumber = Convert.ToString(PlateNumberUP.ExecuteScalar())
        connection.Close()

        PlateNumber.Text = strPlateNumber

        Dim YearUP As New SqlCommand("SELECT Year FROM Register Where TagId ='" & intTagId & "'", connection)
        connection.Open()
        strYear = Convert.ToString(YearUP.ExecuteScalar())
        connection.Close()

        Year.Text = strYear

        Dim ModelUP As New SqlCommand("SELECT Model FROM Register Where TagId ='" & intTagId & "'", connection)
        connection.Open()
        strModel = Convert.ToString(ModelUP.ExecuteScalar())
        connection.Close()

        Model.Text = strModel

        Dim MakeUp As New SqlCommand("SELECT Make FROM Register Where TagId ='" & intTagId & "'", connection)
        connection.Open()
        strMake = Convert.ToString(MakeUp.ExecuteScalar())
        connection.Close()

        Make.Text = strMake

        Dim StateUp As New SqlCommand("SELECT State FROM Register Where TagId ='" & intTagId & "'", connection)
        connection.Open()
        strstate = Convert.ToString(StateUp.ExecuteScalar())
        connection.Close()

        Statelst.Text = strstate

        Dim EmailUP As New SqlCommand("SELECT email FROM Register Where TagId ='" & intTagId & "'", connection)
        connection.Open()
        stremail = Convert.ToString(EmailUP.ExecuteScalar())
        connection.Close()

        Email.Text = stremail

    End Sub

    Private Sub btnAddFunds_Click(sender As Object, e As EventArgs) Handles btnAddFunds.Click
        Dim intAddFunds As Double
        Dim IntBegBalance As Double
        Dim balUpdate As New SqlCommand("SELECT Balance FROM Register Where CustomerId ='" & CustID & "'", connection)
        connection.Open()
        BegBalance = Convert.ToString(balUpdate.ExecuteScalar())
        connection.Close()

        intAddFunds = CDbl(Int(txtAddfunds.Text))
        Double.TryParse(BegBalance, IntBegBalance)
        'If the funds added to the account is greater than 20 dollars, it will be applied
        If intAddFunds > 20 Then

            IntBegBalance = IntBegBalance + intAddFunds
            IntBegBalance.ToString()
            MessageBox.Show("Funds added")
            Dim UpdateQuery As String = "Update Register set Balance = '" & IntBegBalance & "' Where CustomerId = " & CustID & " "
            ExecuteQuery(UpdateQuery)

            Dim adapter As New SqlDataAdapter("Select FirstName, LastName, Address, Email, PhoneNumber, AccountNumber, State, Make, Model, Year, TagID, PlateNumber, Balance, DateSD FROM Register where TagID ='" & intTagId & "'", connection)

            Dim table As New DataTable()

            adapter.Fill(table)

            DataGridView1.DataSource = table
            txtAddfunds.Clear()
            'But if fund added is not greater than 20 dollars the following message will appear below
        Else
            MessageBox.Show("The minimum charge up is 20 dollars")
            txtAddfunds.Clear()
        End If




    End Sub

    Private Sub btnReturnTag_Click(sender As Object, e As EventArgs) Handles btnReturnTag.Click
        ReturnDate = Date.Now.ToString("dd-MM-yyyy")

        Dim kon2 As New SqlCommand
        Dim kon3 As New SqlCommand
        Dim kon4 As New SqlCommand
        Dim reason As String = Nothing

        reason = InputBox("What is your removal reason?")


        kon2 = New SqlCommand("INSERT INTO ReturnedTag values('" & intTagId & "','" & ReturnDate & "','" & reason & "')", connection)
        connection.Open()
        kon2.ExecuteNonQuery()
        connection.Close()
        MessageBox.Show("Returned Tag Recorded")

        kon3 = New SqlCommand("DELETE FROM TagInventory where TagID = '" & intTagId & "'", connection)
        connection.Open()
        kon3.ExecuteNonQuery()
        connection.Close()

        'puts the date customer requested a tag and signed up for ez pass
        'Assigns a random tag to a customer
        Dim rnd As New Random
        For i As Integer = 0 To maxinfinity - 1
            dom(i) = rnd.Next(0, 99)

            If dom(i) <= 1 Then
                customertag += 1
            End If

        Next
        strTag = customertag.ToString()

        'Try


        'Variables created to have a connection to the sql server database, sql command and to read sql data from the table
        Dim tagconnect As New SqlConnection
        Dim tagcommand As New SqlCommand
        Dim tagdatareader As SqlDataReader
        Dim Generator As New Random
        Dim myrand As Integer
        'my connection string data source retrieved from the source service database path Scheme.mdf
        strDateSD = Date.Now.ToString("dd-MM-yyyy")
        'opening of my connection
        connection.Open()
        'Assigns my variable which holds the sql commands to my sql connection
        tagcommand.Connection = connection
        tagcommand.CommandType = CommandType.Text
            tagcommand.CommandText = "Select * from Taginventory where TagID ='" & strTag & "' "
            tagdatareader = tagcommand.ExecuteReader
        Do
            'if the tag already exists for a customer it will give you the message below that "The tag is already taken"
            myrand = Generator.Next(1, 99)

        Loop While tagdatareader.HasRows
        strTag = myrand.ToString
  
        connection.Close()
        'else if it does not exists it will be inserted and recorded inside of the table "TagInventory"'
        connection.Open()
        tagcommand = New SqlCommand("INSERT INTO TagInventory values('" & status & "','" & strDateSD & "','" & strTag & "')", connection)

        tagcommand.ExecuteNonQuery()

        MsgBox("Tag Stored.", MsgBoxStyle.Information, "Success")

        connection.Close()

        Dim UpdateQuery As String = "Update Register set TagID = '" & strTag & "' Where CustomerId = " & CustID & " "
        ExecuteQuery(UpdateQuery)

        Dim adapter As New SqlDataAdapter("Select FirstName, LastName, Address, Email, PhoneNumber, AccountNumber, State, Make, Model, Year, TagID, PlateNumber, Balance, DateSD FROM Register where email ='" & CustID & "'", connection)

        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table

        Dim UpdateQuery2 As String = "Update CustomerTollRegister set TagID = '" & strTag & "' Where TagID = " & intTagId & " "
        ExecuteQuery(UpdateQuery2)
        'Catch ex As Exception
        ' MsgBox("Error")

        'End Try
        intTagId = strTag
    End Sub

    Private Sub btnLostTag_Click(sender As Object, e As EventArgs) Handles btnLostTag.Click
        Lostdate = Date.Now.ToString("dd-MM-yyyy")
        Dim intTagId As Integer
        Dim kon2 As New SqlCommand
        Dim Lost As String = "Lost"

        Dim sqlTagID As New SqlCommand("SELECT TagID FROM Register Where Email ='" & stremail & "'", connection)
        connection.Open()
        intTagId = Convert.ToInt32(sqlTagID.ExecuteScalar())
        connection.Close()

        kon2 = New SqlCommand("INSERT INTO CustomerTag values('" & intTagId & "','" & Lostdate & "')", connection)
        connection.Open()
        kon2.ExecuteNonQuery()
        connection.Close()
        MessageBox.Show("Lost Tag Recorded")

        Dim UpdateQuery As String = "Update TagInventory set Status = '" & Lost & "' Where TagID = " & intTagId & " "
        ExecuteQuery(UpdateQuery)

        Dim adapter As New SqlDataAdapter("Select FirstName, LastName, Address, Email, PhoneNumber, AccountNumber, State, Make, Model, Year, TagID, PlateNumber, Balance, DateSD FROM Register where email ='" & CustID & "'", connection)

        Dim table As New DataTable()

        adapter.Fill(table)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTollTransaction.Click
        TollProcedure.Show()
        strTagID = intTagId.ToString

        Dim sqlBalance As New SqlCommand("SELECT Balance FROM Register Where TagID ='" & strTagID & "'", connection)
        connection.Open()
        strBalance = Convert.ToString(sqlBalance.ExecuteScalar())
        connection.Close()

    End Sub

    Private Sub txtAddfunds_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddfunds.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then
        Else
            e.Handled = True
            MessageBox.Show("Numbers only")
        End If
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

    Private Sub LogOut_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmMenu.Show()
    End Sub
End Class