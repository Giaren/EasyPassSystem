Public Class frmMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CustomerRegister.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CustomerLogin.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CreatorLogin.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) 
        CustomersAccount.Show()
    End Sub
End Class
