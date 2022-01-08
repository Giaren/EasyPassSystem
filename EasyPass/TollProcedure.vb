Imports System.Data.SqlClient
Public Class TollProcedure
    Dim strCustomerRevenue As String
    Dim dblBalance As Double
    Dim dblfinalBalance As Double
    Dim dblFare As Double
    Dim intTollcode As Integer
    Dim strPlateNumber As String
    Dim strTollTime As String
    Dim strFile As String = ""
    Dim Strname As String = "Scheme.mdf"
    Dim TollRevenueDBL As String
    Dim TollFarePriceDBL As String
    Dim NewCurrentRevenue As String

    Dim strUserDocFldr As String = Environment.CurrentDirectory
    Dim strUserDocFldrSimpl As String = System.IO.Path.GetFullPath(strUserDocFldr).Replace("bin\Debug", "")
    Dim newFullPath As String = System.IO.Path.Combine(strUserDocFldrSimpl, Strname)

    Dim connection As New SqlConnection(("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & newFullPath & ";Integrated Security=True"))

    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()

    End Sub
    Private Sub btnTollProcess_Click(sender As Object, e As EventArgs) Handles btnTollProcess.Click
        Dim begRevenue As String
        Dim dblRevenue As Double
        Dim dblFarePrice As Double
        strTollTime = Date.Now.ToString("hh:mm:ss")

        'If the funds added to the account is greater than 20 dollars, it will be applied
        If dblBalance < dblFare Then

            MsgBox("You dont have enough funds to complete this transaction", MsgBoxStyle.Critical)
        ElseIf dblBalance < 10 Then
            MsgBox("Your account balance is less than 10$, Your account is in a low Balance status", MsgBoxStyle.Critical)
        Else

            Dim tagcommand As New SqlCommand
            Dim tagdatareader As SqlDataReader

            Dim tagcommand1 As New SqlCommand
            'my connection string data source retrieved from the source service database path Scheme.mdf

            'opening of my connection
            connection.Open()
            'Assigns my variable which holds the sql commands to my sql connection
            tagcommand.Connection = connection
            tagcommand.CommandType = CommandType.Text
            tagcommand.CommandText = "Select * from TollDescription where TollName ='" & txtEntrypoint.Text & "' "
            tagdatareader = tagcommand.ExecuteReader
            If tagdatareader.HasRows Then
                connection.Close()
                Dim TollCodesql As New SqlCommand("SELECT Tollcode FROM TollDescription Where TollName ='" & txtEntrypoint.Text & "'", connection)
                connection.Open()
                intTollcode = Convert.ToInt32(TollCodesql.ExecuteScalar())
                connection.Close()

                Dim TollCurrentRev As New SqlCommand("SELECT Revenue FROM TollDescription Where TollCode ='" & intTollcode & "'", connection)
                connection.Open()
                begRevenue = Convert.ToString(TollCurrentRev.ExecuteScalar())
                connection.Close()

                Dim TollFarePrice As New SqlCommand("SELECT FarePaid FROM CustomerTollRegister Where TollCode ='" & intTollcode & "'", connection)
                connection.Open()
                TollFarePriceDBL = Convert.ToString(TollFarePrice.ExecuteScalar())
                connection.Close()

                Double.TryParse(begRevenue, dblRevenue)
                Double.TryParse(TollFarePriceDBL, dblFarePrice)

                dblRevenue = dblRevenue + dblFarePrice

                Dim RevenueUpdating As String = "Update TollDescription set Revenue = '" & dblRevenue & "' Where TollCode = " & intTollcode & " "
                ExecuteQuery(RevenueUpdating)
            Else
                'else if it does not exists it will be inserted and recorded inside of the table "TagInventory"'

                MsgBox("This Toll doesn't exist", MsgBoxStyle.Critical)
                connection.Close()
            End If

            Dim sqlPlateNumber As New SqlCommand("SELECT PlateNumber FROM Register Where TagId ='" & strTagID & "'", connection)
            connection.Open()
            strPlateNumber = Convert.ToString(sqlPlateNumber.ExecuteScalar())
            connection.Close()

            tagcommand1 = New SqlCommand("INSERT INTO CustomerTollRegister values('" & strTagID & "','" & intTollcode & "','" & strPlateNumber & "','" & strTollTime & "','" & dblFare & "','" & txtEntrypoint.Text & "')", connection)
            connection.Open()
            tagcommand1.ExecuteNonQuery()
            connection.Close()
            MsgBox("Transaction Complete", MsgBoxStyle.Information, "Success")

            Dim adapter As New SqlDataAdapter("Select * FROM CustomerTollRegister where TagID ='" & strTagID & "'", connection)

            Dim table As New DataTable()

            adapter.Fill(table)

            TollView.DataSource = table

            strCustomerRevenue = (From row As DataGridViewRow In TollView.Rows Where row.Cells(5).FormattedValue.ToString <> String.Empty Select Convert.ToDouble(row.Cells(5).FormattedValue)).Sum().ToString()
            connection.Close()


            Dim RevenueCommand As String = "Update Register set Revenue = '" & strCustomerRevenue & "' Where TagID = " & strTagID & " "
            ExecuteQuery(RevenueCommand)

            Dim UpdateQuery As String = "Update Register set Balance = '" & lblFinalBalance.Text & "' Where TagID = " & strTagID & " "
            ExecuteQuery(UpdateQuery)

            Dim adapter2 As New SqlDataAdapter("Select * FROM Register where TagID ='" & strTagID & "'", connection)

            Dim table2 As New DataTable()

            adapter2.Fill(table2)

            CustomersAccount.DataGridView1.DataSource = table2

            TollView.DataSource.Clear()



        End If

        Me.Hide()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEntrypoint.Text = String.Empty
        btnTollProcess.Enabled = False
        lblEndPoint.Text = String.Empty
        lblCurrentBalance.Visible = False
        lblFinalBalance.Visible = False
        lblFare.Visible = False
        lblLabelCurrent.Visible = False
        lblLabelFare.Visible = False
        lblLabelFinal.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tagcommand As New SqlCommand
        Dim tagdatareader As SqlDataReader
        'my connection string data source retrieved from the source service database path Scheme.mdf

        'opening of my connection
        connection.Open()
        'Assigns my variable which holds the sql commands to my sql connection
        tagcommand.Connection = connection
        tagcommand.CommandType = CommandType.Text
        tagcommand.CommandText = "Select * from CustomerTollRegister where TagID ='" & strTagID & "' "
        tagdatareader = tagcommand.ExecuteReader
        If tagdatareader.HasRows Then
            connection.Close()

            Dim adapter As New SqlDataAdapter("Select * FROM CustomerTollRegister where TagID ='" & strTagID & "'", connection)

            Dim table As New DataTable()

            adapter.Fill(table)

            TollView.DataSource = table
            strCustomerRevenue = (From row As DataGridViewRow In TollView.Rows Where row.Cells(5).FormattedValue.ToString <> String.Empty Select Convert.ToDouble(row.Cells(5).FormattedValue)).Sum().ToString()
            connection.Close()

        Else
            'else if it does not exists it will be inserted and recorded inside of the table "TagInventory"'
            strCustomerRevenue = "0"
            MsgBox("There are no transactions with this Account", MsgBoxStyle.Critical)
            connection.Close()
        End If
        Dim RevenueCommand As String = "Update Register set Revenue = '" & strCustomerRevenue & "' Where TagID = " & strTagID & " "
        ExecuteQuery(RevenueCommand)
    End Sub

    Private Sub TollProcedure_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select TollName, Fare, Tolltype, EndPoint FROM TollDescription", connection)

        Dim table As New DataTable()

        adapter.Fill(table)

        DGTollInformation.DataSource = table

        TollView.Rows.Clear()
    End Sub

    Private Sub DGTollInformation_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTollInformation.CellContentClick
        Dim index As Integer

        index = e.RowIndex

        Dim selectedRow As DataGridViewRow
        selectedRow = DGTollInformation.Rows(index)

        txtEntrypoint.Text = selectedRow.Cells(0).Value.ToString()
        lblFare.Text = selectedRow.Cells(1).Value.ToString()
        lblEndPoint.Text = selectedRow.Cells(3).Value.ToString()

        Double.TryParse(lblFare.Text, dblFare)
        Double.TryParse(strBalance, dblBalance)
        dblfinalBalance = dblBalance - dblFare

        lblCurrentBalance.Text = dblBalance
        lblFinalBalance.Text = dblfinalBalance

        btnTollProcess.Enabled = True
        lblCurrentBalance.Visible = True
        lblFare.Visible = True
        lblFinalBalance.Visible = True
        lblLabelCurrent.Visible = True
        lblLabelFare.Visible = True
        lblLabelFinal.Visible = True
    End Sub

    Private Sub TollView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TollView.CellContentClick

    End Sub
End Class

