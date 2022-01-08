Imports System.Data.SqlClient
Public Class CustomerLogin


    Dim Strname As String = "Scheme.mdf"

    Dim strUserDocFldr As String = Environment.CurrentDirectory
    Dim strUserDocFldrSimpl As String = System.IO.Path.GetFullPath(strUserDocFldr).Replace("bin\Debug", "")
    Dim newFullPath As String = System.IO.Path.Combine(strUserDocFldrSimpl, Strname)

    Dim connection As New SqlConnection(("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & newFullPath & ";Integrated Security=True"))


    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Creating variables to have a sql connection and a sql command

        Dim mycommand As New SqlCommand
        'connection string data source retrieved from the source service database path Scheme.mdf


        Dim connection2 As SqlConnection = Nothing
        Dim mycommand2 As SqlCommand = Nothing

        Try
            connection2 = New SqlConnection(("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & newFullPath & ";Integrated Security=True"))
            connection2.Open()
            'Selecting everything from register table where the email is equal to our email textbox and the password 
            'is equal to the password textbox in our customer login form so basically what ever text or numbers the user enters in the
            'email and password text box if the data is stored in the table register it will execute and give u the message below
            Dim collectNow As String = "Select * from Register where Email ='" & Email.Text & "' AND password ='" & Password.Text & "' "

            mycommand2 = New SqlCommand(collectNow, connection2)

            Dim readata As SqlDataReader = mycommand2.ExecuteReader
            If readata.Read Then
                'if the data is read with no error the login will be successful
                MessageBox.Show("Login sucessful")
                stremail = Email.Text
                Dim cmd As New SqlCommand("SELECT CustomerId FROM Register Where email ='" & stremail & "'", connection)
                connection.Open()
                CustID = Convert.ToInt32(cmd.ExecuteScalar())
                connection.Close()
                Me.Hide()
                CustomersAccount.Show()

            Else
                'if user enters something wrong or if the data wasnt read perfectly you will get the following message
                MessageBox.Show("Wrong Username or Password")
                Email.Clear()
                Password.Clear()
            End If


        Catch ex As Exception
            'if anything goes wrong during runtime "error has occured while running"
            MessageBox.Show("Error has occured while running")
        End Try
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        'button that takes user back to the frm menu
        Email.Clear()
        Password.Clear()
        Me.Hide()
        frmMenu.Show()
    End Sub

    Private Sub CustomerLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Email.Clear()
        Password.Clear()
    End Sub
End Class