Imports System.Data.SqlClient
Public Class TransactionsRecord
    Dim Strname As String = "Scheme.mdf"

    Dim strUserDocFldr As String = Environment.CurrentDirectory
    Dim strUserDocFldrSimpl As String = System.IO.Path.GetFullPath(strUserDocFldr).Replace("bin\Debug", "")
    Dim newFullPath As String = System.IO.Path.Combine(strUserDocFldrSimpl, Strname)
    Dim connection As New SqlConnection(("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & newFullPath & ";Integrated Security=True"))
    Private Sub TransactionsRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select TagID, PlateNumber, EffectiveDate, FarePaid, EntryPoint FROM CustomerTollRegister", connection)

        Dim table As New DataTable()

        adapter.Fill(table)

        TransactionsInfo.DataSource = table
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim mycommand As New SqlCommand
        Dim mydatareader As SqlDataReader
        connection.Open()
        mycommand.Connection = connection
        mycommand.CommandType = CommandType.Text
        mycommand.CommandText = "Select * from CustomerTollRegister Where TagID='" & txtTagID.Text & "' "
        mydatareader = mycommand.ExecuteReader

        If mydatareader.HasRows Then

            Dim adapter As New SqlDataAdapter("Select TagID, TollCode, PlateNumber, EffectiveDate, FarePaid, EntryPoint FROM CustomerTollRegister Where Tagid='" & txtTagID.Text & "' ", connection)

            Dim table As New DataTable()
            connection.Close()
            adapter.Fill(table)

            TransactionsInfo.DataSource = table

        Else

            MsgBox("There is no data matching", MsgBoxStyle.Critical)
        End If
        connection.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        CustomerUpdating.Show()
    End Sub
End Class