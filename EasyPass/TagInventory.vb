Imports System.Data.SqlClient
Public Class TagInventory
    Dim Strname As String = "Scheme.mdf"

    Dim strUserDocFldr As String = Environment.CurrentDirectory
    Dim strUserDocFldrSimpl As String = System.IO.Path.GetFullPath(strUserDocFldr).Replace("bin\Debug", "")
    Dim newFullPath As String = System.IO.Path.Combine(strUserDocFldrSimpl, Strname)
    Dim connection As New SqlConnection(("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & newFullPath & ";Integrated Security=True"))
    Private Sub TagInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select Status, Date, TagID FROM TagInventory", connection)

        Dim table As New DataTable()

        adapter.Fill(table)

        TagstatusTable.DataSource = table
    End Sub

    Private Sub rdtActiveTags_CheckedChanged(sender As Object, e As EventArgs) Handles rdtActiveTags.CheckedChanged
        Dim adapter As New SqlDataAdapter("Select Status, Date, TagID FROM TagInventory where Status='" & "Active" & "' ", connection)

        Dim table As New DataTable()

        adapter.Fill(table)

        TagstatusTable.DataSource = table
    End Sub

    Private Sub rdtLossTags_CheckedChanged(sender As Object, e As EventArgs) Handles rdtLossTags.CheckedChanged
        Dim adapter As New SqlDataAdapter("Select Status, Date, TagID FROM TagInventory where Status='" & "Lost" & "' ", connection)

        Dim table As New DataTable()

        adapter.Fill(table)

        TagstatusTable.DataSource = table
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        CustomerUpdating.Show()
    End Sub
End Class