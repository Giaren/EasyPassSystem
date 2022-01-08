Imports System.Data.SqlClient
Public Class Toll_Revenue
    Dim RevenueToll As String
    Dim countT As Integer
    Dim strFile As String = ""
    Dim Strname As String = "Scheme.mdf"

    Dim strUserDocFldr As String = Environment.CurrentDirectory
    Dim strUserDocFldrSimpl As String = System.IO.Path.GetFullPath(strUserDocFldr).Replace("bin\Debug", "")
    Dim newFullPath As String = System.IO.Path.Combine(strUserDocFldrSimpl, Strname)

    Dim connection As New SqlConnection(("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & newFullPath & ";Integrated Security=True"))
    Private Sub Toll_Revenue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select TollCode, TollName, Fare, Revenue FROM TollDescription", connection)

        Dim table As New DataTable()

        adapter.Fill(table)

        TollRevenue.DataSource = table

        GrandTotal.Text = (From row As DataGridViewRow In TollRevenue.Rows Where row.Cells(3).FormattedValue.ToString <> String.Empty Select Convert.ToDouble(row.Cells(3).FormattedValue)).Sum().ToString()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim mycommand As New SqlCommand
        Dim mydatareader As SqlDataReader
        connection.Open()
        mycommand.Connection = connection
        mycommand.CommandType = CommandType.Text
        mycommand.CommandText = "Select TollCode, TollName, Fare, Revenue FROM TollDescription Where TollName='" & txtTollName.Text & "' "
        mydatareader = mycommand.ExecuteReader

        If mydatareader.HasRows Then
            Dim adapter As New SqlDataAdapter("Select TollCode, TollName, Fare, Revenue FROM TollDescription Where TollName='" & txtTollName.Text & "' ", connection)

            Dim table As New DataTable()
            connection.Close()
            adapter.Fill(table)

            TollRevenue.DataSource = table


        Else

            MsgBox("There is no data matching", MsgBoxStyle.Critical)
        End If
        connection.Close()
    End Sub

    Private Sub TollRevenue_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TollRevenue.CellContentClick
        Dim index As Integer

        index = e.RowIndex

        Dim selectedRow As DataGridViewRow
        selectedRow = TollRevenue.Rows(index)

        txtTollName.Text = selectedRow.Cells(1).Value.ToString()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim adapter As New SqlDataAdapter("Select TollCode, TollName, Fare, Revenue FROM TollDescription", connection)

        Dim table As New DataTable()

        adapter.Fill(table)

        TollRevenue.DataSource = table

        GrandTotal.Text = (From row As DataGridViewRow In TollRevenue.Rows Where row.Cells(3).FormattedValue.ToString <> String.Empty Select Convert.ToDouble(row.Cells(3).FormattedValue)).Sum().ToString()
        txtTollName.Clear()
    End Sub

    Private Sub btnSortFare_Click(sender As Object, e As EventArgs) Handles btnSortFare.Click
        TollRevenue.Sort(TollRevenue.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TollRevenue.Sort(TollRevenue.Columns(2), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TollRevenue.Sort(TollRevenue.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

End Class