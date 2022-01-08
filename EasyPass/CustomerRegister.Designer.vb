<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerRegister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnRequest = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.TagID = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Make = New System.Windows.Forms.TextBox()
        Me.Model = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PlateNumber = New System.Windows.Forms.TextBox()
        Me.AccountNumber = New System.Windows.Forms.TextBox()
        Me.DateSD = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.LastName = New System.Windows.Forms.TextBox()
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Balance = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtStatus = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.Year = New System.Windows.Forms.MaskedTextBox()
        Me.Statelst = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(507, 323)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(100, 20)
        Me.Password.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(415, 323)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 20)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Password"
        '
        'btnRequest
        '
        Me.btnRequest.BackColor = System.Drawing.Color.Azure
        Me.btnRequest.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRequest.ForeColor = System.Drawing.Color.Red
        Me.btnRequest.Location = New System.Drawing.Point(527, 453)
        Me.btnRequest.Name = "btnRequest"
        Me.btnRequest.Size = New System.Drawing.Size(178, 40)
        Me.btnRequest.TabIndex = 32
        Me.btnRequest.Text = "Request Tag"
        Me.btnRequest.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(257, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(257, 28)
        Me.Label14.TabIndex = 88
        Me.Label14.Text = "EZ PASS SIGN UP FORM"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Azure
        Me.btnCancel.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Red
        Me.btnCancel.Location = New System.Drawing.Point(296, 453)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(178, 40)
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.Azure
        Me.btnSignUp.Enabled = False
        Me.btnSignUp.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.ForeColor = System.Drawing.Color.Red
        Me.btnSignUp.Location = New System.Drawing.Point(66, 453)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(178, 40)
        Me.btnSignUp.TabIndex = 30
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'TagID
        '
        Me.TagID.Location = New System.Drawing.Point(507, 282)
        Me.TagID.Name = "TagID"
        Me.TagID.ReadOnly = True
        Me.TagID.Size = New System.Drawing.Size(100, 20)
        Me.TagID.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(438, 280)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 20)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "TagID"
        '
        'Make
        '
        Me.Make.Location = New System.Drawing.Point(507, 162)
        Me.Make.Name = "Make"
        Me.Make.Size = New System.Drawing.Size(100, 20)
        Me.Make.TabIndex = 17
        '
        'Model
        '
        Me.Model.Location = New System.Drawing.Point(507, 199)
        Me.Model.Name = "Model"
        Me.Model.Size = New System.Drawing.Size(100, 20)
        Me.Model.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(454, 236)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 20)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Year"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(444, 197)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 20)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Model"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(449, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 20)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Make"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(448, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 20)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "State"
        '
        'PlateNumber
        '
        Me.PlateNumber.Location = New System.Drawing.Point(205, 362)
        Me.PlateNumber.Name = "PlateNumber"
        Me.PlateNumber.Size = New System.Drawing.Size(100, 20)
        Me.PlateNumber.TabIndex = 13
        '
        'AccountNumber
        '
        Me.AccountNumber.Location = New System.Drawing.Point(205, 282)
        Me.AccountNumber.Name = "AccountNumber"
        Me.AccountNumber.Size = New System.Drawing.Size(100, 20)
        Me.AccountNumber.TabIndex = 9
        '
        'DateSD
        '
        Me.DateSD.Location = New System.Drawing.Point(507, 403)
        Me.DateSD.Name = "DateSD"
        Me.DateSD.ReadOnly = True
        Me.DateSD.Size = New System.Drawing.Size(100, 20)
        Me.DateSD.TabIndex = 29
        '
        'Email
        '
        Me.Email.Location = New System.Drawing.Point(205, 238)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(100, 20)
        Me.Email.TabIndex = 7
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(205, 199)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(100, 20)
        Me.Address.TabIndex = 5
        '
        'LastName
        '
        Me.LastName.Location = New System.Drawing.Point(205, 162)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(100, 20)
        Me.LastName.TabIndex = 3
        '
        'FirstName
        '
        Me.FirstName.Location = New System.Drawing.Point(205, 120)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(100, 20)
        Me.FirstName.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(82, 362)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "PlateNumber"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(57, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "AccountNumber"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(428, 403)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "DateSD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(146, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(124, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(109, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "LastName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(108, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "FirstName"
        '
        'Balance
        '
        Me.Balance.Location = New System.Drawing.Point(507, 360)
        Me.Balance.Name = "Balance"
        Me.Balance.Size = New System.Drawing.Size(100, 20)
        Me.Balance.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(418, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Balance"
        '
        'txtStatus
        '
        Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStatus.Location = New System.Drawing.Point(636, 31)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(110, 26)
        Me.txtStatus.TabIndex = 94
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(62, 321)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(127, 20)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Phone Number"
        '
        'PhoneNumber
        '
        Me.PhoneNumber.Location = New System.Drawing.Point(205, 323)
        Me.PhoneNumber.Mask = "(999) 000-0000"
        Me.PhoneNumber.Name = "PhoneNumber"
        Me.PhoneNumber.Size = New System.Drawing.Size(100, 20)
        Me.PhoneNumber.TabIndex = 11
        '
        'Year
        '
        Me.Year.Location = New System.Drawing.Point(507, 238)
        Me.Year.Mask = "0000"
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(100, 20)
        Me.Year.TabIndex = 21
        '
        'Statelst
        '
        Me.Statelst.FormattingEnabled = True
        Me.Statelst.Items.AddRange(New Object() {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.Statelst.Location = New System.Drawing.Point(507, 120)
        Me.Statelst.Name = "Statelst"
        Me.Statelst.Size = New System.Drawing.Size(100, 21)
        Me.Statelst.TabIndex = 96
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(200, 66)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(371, 28)
        Me.Label17.TabIndex = 97
        Me.Label17.Text = "Please fill all fields before requesting a tag"
        '
        'CustomerRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.ClientSize = New System.Drawing.Size(764, 515)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Statelst)
        Me.Controls.Add(Me.Year)
        Me.Controls.Add(Me.PhoneNumber)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.Balance)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnRequest)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.TagID)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Make)
        Me.Controls.Add(Me.Model)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PlateNumber)
        Me.Controls.Add(Me.AccountNumber)
        Me.Controls.Add(Me.DateSD)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "CustomerRegister"
        Me.Text = "CustomerRegister"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Password As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnRequest As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSignUp As Button
    Friend WithEvents TagID As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Make As TextBox
    Friend WithEvents Model As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PlateNumber As TextBox
    Friend WithEvents AccountNumber As TextBox
    Friend WithEvents DateSD As TextBox
    Friend WithEvents Email As TextBox
    Friend WithEvents Address As TextBox
    Friend WithEvents LastName As TextBox
    Friend WithEvents FirstName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Balance As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtStatus As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PhoneNumber As MaskedTextBox
    Friend WithEvents Year As MaskedTextBox
    Friend WithEvents Statelst As ComboBox
    Friend WithEvents Label17 As Label
End Class
