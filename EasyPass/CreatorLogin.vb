Public Class CreatorLogin
    Private Sub BtnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        'boolean for the admin to login basically means if the email textbox recognizes "aboodhoo@gmail.com, "giaren@gmail.com" 
        'And the password textbox recgonizes "5825" and "12345" we will have access to the customers database of ez pass.
        If (Email.Text = "aboodhoo@gmail.com" And Password.Text = "5825" Or Email.Text = "giaren@gmail.com" And Password.Text = "12345") Then
            'if email and password is correct we will get the message below
            MessageBox.Show("You have sucessfully log in")
            'And we are redirected to the customer updating database
            CustomerUpdating.Show()
        Else
            'if email and password is incorrect we will get the message below
            MessageBox.Show("Wrong credentials")
        End If
        Me.Hide()


    End Sub

    Private Sub CreatorLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class