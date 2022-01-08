Imports System.Data.SqlClient
Public Class CustomerRevenue
    Dim strFile As String = ""
    Dim Strname As String = "Scheme.mdf"

    Dim strUserDocFldr As String = Environment.CurrentDirectory
    Dim strUserDocFldrSimpl As String = System.IO.Path.GetFullPath(strUserDocFldr).Replace("bin\Debug", "")
    Dim newFullPath As String = System.IO.Path.Combine(strUserDocFldrSimpl, Strname)

    Dim connection As New SqlConnection(("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & newFullPath & ";Integrated Security=True"))
    Private Sub CustomerRevenue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("SELECT FirstName,LastName,DateSD,Revenue FROM Register", connection)

        Dim table As New DataTable()

        adapter.Fill(table)

        CustomerRev.DataSource = table

        txtTotalRevenue.Text = (From row As DataGridViewRow In CustomerRev.Rows Where row.Cells(3).FormattedValue.ToString <> String.Empty Select Convert.ToDouble(row.Cells(3).FormattedValue)).Sum().ToString()

    End Sub

    Private Sub CustomerRev_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerRev.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mycommand As New SqlCommand
        Dim mydatareader As SqlDataReader
        connection.Open()
        mycommand.Connection = connection
        mycommand.CommandType = CommandType.Text
        mycommand.CommandText = "Select FirstName,LastName,DateSD,Revenue FROM Register Where FirstName='" & txtFirstName.Text & "' "
        mydatareader = mycommand.ExecuteReader

        If mydatareader.HasRows Then
            Dim adapter As New SqlDataAdapter("Select FirstName,LastName,DateSD,Revenue FROM Register Where FirstName='" & txtFirstName.Text & "' OR LastName= '" & txtLastName.Text & "' ", connection)

            Dim table As New DataTable()
            connection.Close()
            adapter.Fill(table)

            CustomerRev.DataSource = table
        Else
            MsgBox("There is no data matching", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim adapter As New SqlDataAdapter("SELECT FirstName,LastName,DateSD,Revenue FROM Register", connection)

        Dim table As New DataTable()

        adapter.Fill(table)

        CustomerRev.DataSource = table
    End Sub

    Private Sub btnsortLastName_Click(sender As Object, e As EventArgs) Handles btnsortLastName.Click
        CustomerRev.Sort(CustomerRev.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
End Class