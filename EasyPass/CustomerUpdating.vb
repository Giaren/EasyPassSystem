
Imports System.Data.SqlClient
Public Class CustomerUpdating

    Dim strFile As String = ""
    Dim Strname As String = "Scheme.mdf"

    Dim strUserDocFldr As String = Environment.CurrentDirectory
    Dim strUserDocFldrSimpl As String = System.IO.Path.GetFullPath(strUserDocFldr).Replace("bin\Debug", "")
    Dim newFullPath As String = System.IO.Path.Combine(strUserDocFldrSimpl, Strname)

    Dim connection As New SqlConnection(("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & newFullPath & ";Integrated Security=True"))

    Private Sub btnCustomerInformation_Click(sender As Object, e As EventArgs) Handles btnCustomerInformation.Click
        CustomerInformation.Show()
    End Sub

    Private Sub btnUpdateTolls_Click(sender As Object, e As EventArgs) Handles btnUpdateTolls.Click
        Me.Hide()
        UpdateTolls.Show()
    End Sub

    Private Sub btnTagInventory_Click(sender As Object, e As EventArgs) Handles btnTagInventory.Click
        Me.Hide()
        TagInventory.Show()
    End Sub

    Private Sub btnReturnedTag_Click(sender As Object, e As EventArgs) Handles btnReturnedTag.Click
        Me.Hide()
        ReturnedTags.Show()
    End Sub

    Private Sub btnTransactions_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click
        Me.Hide()
        TransactionsRecord.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Toll_Revenue.Show()
    End Sub

    Private Sub CustomerRevenue_Click(sender As Object, e As EventArgs) Handles btnCustomerRevenue.Click
        CustomerRevenue.Show()
    End Sub
End Class