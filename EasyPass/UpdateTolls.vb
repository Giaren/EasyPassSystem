Imports System.Data.SqlClient

Public Class UpdateTolls

    Dim Strname As String = "Scheme.mdf"
    Dim strTollCode As String
    Dim strUserDocFldr As String = Environment.CurrentDirectory
    Dim strUserDocFldrSimpl As String = System.IO.Path.GetFullPath(strUserDocFldr).Replace("bin\Debug", "")
    Dim newFullPath As String = System.IO.Path.Combine(strUserDocFldrSimpl, Strname)

    Dim connection As New SqlConnection(("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & newFullPath & ";Integrated Security=True"))
    Private Sub UpdateTolls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select TollCode, TollName, Fare, TollType, EndPoint FROM TollDescription", connection)

        Dim table As New DataTable()

        adapter.Fill(table)

        TollInformation.DataSource = table
    End Sub

    Private Sub TollInformation_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TollInformation.CellContentClick

        Dim index As Integer

        index = e.RowIndex

        Dim selectedRow As DataGridViewRow
        selectedRow = TollInformation.Rows(index)

        txtFarePrice.Text = selectedRow.Cells(2).Value.ToString()
        strTollCode = selectedRow.Cells(0).Value.ToString()
        btnUpdateFare.Enabled = True
        txtFarePrice.ReadOnly = False
    End Sub

    Private Sub btnUpdateFare_Click(sender As Object, e As EventArgs) Handles btnUpdateFare.Click
        Dim UpdateQuery As String = "Update TollDescription set Fare = '" & txtFarePrice.Text & "'Where TollCode = " & strTollCode & " "
        ExecuteQuery(UpdateQuery)

        Dim adapter As New SqlDataAdapter("Select TollCode, TollName, Fare, TollType, EndPoint FROM TollDescription", connection)

        Dim table As New DataTable()

        adapter.Fill(table)

        TollInformation.DataSource = table
    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()

    End Sub

    Private Sub btnaddtoll_Click(sender As Object, e As EventArgs) Handles btnaddtoll.Click
        AddToll.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        CustomerUpdating.Show()
    End Sub
End Class