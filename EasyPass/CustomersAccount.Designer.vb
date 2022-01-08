<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomersAccount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Model = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PlateNumber = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.LastName = New System.Windows.Forms.TextBox()
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Make = New System.Windows.Forms.TextBox()
        Me.btnAddFunds = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAddfunds = New System.Windows.Forms.TextBox()
        Me.btnLostTag = New System.Windows.Forms.Button()
        Me.btnReturnTag = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnTollTransaction = New System.Windows.Forms.Button()
        Me.PhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.Year = New System.Windows.Forms.MaskedTextBox()
        Me.Statelst = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1128, 167)
        Me.DataGridView1.TabIndex = 1
        '
        'Model
        '
        Me.Model.Location = New System.Drawing.Point(1026, 345)
        Me.Model.Name = "Model"
        Me.Model.Size = New System.Drawing.Size(100, 20)
        Me.Model.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(973, 382)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 20)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Year"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(963, 343)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Model"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(967, 266)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "State"
        '
        'PlateNumber
        '
        Me.PlateNumber.Location = New System.Drawing.Point(1026, 231)
        Me.PlateNumber.Name = "PlateNumber"
        Me.PlateNumber.Size = New System.Drawing.Size(100, 20)
        Me.PlateNumber.TabIndex = 16
        '
        'Email
        '
        Me.Email.Location = New System.Drawing.Point(749, 350)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(100, 20)
        Me.Email.TabIndex = 12
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(749, 311)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(100, 20)
        Me.Address.TabIndex = 10
        '
        'LastName
        '
        Me.LastName.Location = New System.Drawing.Point(749, 274)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(100, 20)
        Me.LastName.TabIndex = 8
        '
        'FirstName
        '
        Me.FirstName.Location = New System.Drawing.Point(749, 232)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(100, 20)
        Me.FirstName.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(908, 229)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "PlateNumber"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(690, 348)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(668, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(653, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "LastName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(652, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "FirstName"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Azure
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(967, 410)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(159, 39)
        Me.btnUpdate.TabIndex = 25
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(968, 308)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Make"
        '
        'Make
        '
        Me.Make.Location = New System.Drawing.Point(1026, 308)
        Me.Make.Name = "Make"
        Me.Make.Size = New System.Drawing.Size(100, 20)
        Me.Make.TabIndex = 20
        '
        'btnAddFunds
        '
        Me.btnAddFunds.BackColor = System.Drawing.Color.Azure
        Me.btnAddFunds.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddFunds.Location = New System.Drawing.Point(140, 213)
        Me.btnAddFunds.Name = "btnAddFunds"
        Me.btnAddFunds.Size = New System.Drawing.Size(132, 29)
        Me.btnAddFunds.TabIndex = 0
        Me.btnAddFunds.Text = "Add Funds "
        Me.btnAddFunds.UseCompatibleTextRendering = True
        Me.btnAddFunds.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Blue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(611, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 20)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "Update Personal information"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Blue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(904, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(223, 20)
        Me.Label6.TabIndex = 119
        Me.Label6.Text = "Update vehicle information"
        '
        'txtAddfunds
        '
        Me.txtAddfunds.Location = New System.Drawing.Point(278, 220)
        Me.txtAddfunds.Name = "txtAddfunds"
        Me.txtAddfunds.Size = New System.Drawing.Size(118, 20)
        Me.txtAddfunds.TabIndex = 1
        '
        'btnLostTag
        '
        Me.btnLostTag.BackColor = System.Drawing.Color.Azure
        Me.btnLostTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLostTag.Location = New System.Drawing.Point(15, 393)
        Me.btnLostTag.Name = "btnLostTag"
        Me.btnLostTag.Size = New System.Drawing.Size(131, 56)
        Me.btnLostTag.TabIndex = 3
        Me.btnLostTag.Text = "Report Lost Tag"
        Me.btnLostTag.UseVisualStyleBackColor = False
        '
        'btnReturnTag
        '
        Me.btnReturnTag.BackColor = System.Drawing.Color.Azure
        Me.btnReturnTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnTag.Location = New System.Drawing.Point(183, 393)
        Me.btnReturnTag.Name = "btnReturnTag"
        Me.btnReturnTag.Size = New System.Drawing.Size(131, 56)
        Me.btnReturnTag.TabIndex = 4
        Me.btnReturnTag.Text = "Return Tag"
        Me.btnReturnTag.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(616, 382)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Phone Number"
        '
        'btnTollTransaction
        '
        Me.btnTollTransaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTollTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTollTransaction.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnTollTransaction.Location = New System.Drawing.Point(336, 274)
        Me.btnTollTransaction.Name = "btnTollTransaction"
        Me.btnTollTransaction.Size = New System.Drawing.Size(149, 57)
        Me.btnTollTransaction.TabIndex = 2
        Me.btnTollTransaction.Text = "Toll Transaction"
        Me.btnTollTransaction.UseVisualStyleBackColor = False
        '
        'PhoneNumber
        '
        Me.PhoneNumber.Location = New System.Drawing.Point(749, 382)
        Me.PhoneNumber.Mask = "(999) 000-0000"
        Me.PhoneNumber.Name = "PhoneNumber"
        Me.PhoneNumber.Size = New System.Drawing.Size(100, 20)
        Me.PhoneNumber.TabIndex = 14
        '
        'Year
        '
        Me.Year.Location = New System.Drawing.Point(1026, 382)
        Me.Year.Mask = "0000"
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(100, 20)
        Me.Year.TabIndex = 24
        '
        'Statelst
        '
        Me.Statelst.FormattingEnabled = True
        Me.Statelst.Items.AddRange(New Object() {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.Statelst.Location = New System.Drawing.Point(1026, 265)
        Me.Statelst.Name = "Statelst"
        Me.Statelst.Size = New System.Drawing.Size(100, 21)
        Me.Statelst.TabIndex = 120
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Purple
        Me.Label13.Location = New System.Drawing.Point(129, 296)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(201, 15)
        Me.Label13.TabIndex = 121
        Me.Label13.Text = "Please click here to take a trip"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Purple
        Me.Label14.Location = New System.Drawing.Point(9, 375)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(458, 15)
        Me.Label14.TabIndex = 122
        Me.Label14.Text = "Please click here if you either want to report a lost a tag or return a tag"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Purple
        Me.Label15.Location = New System.Drawing.Point(1, 220)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(133, 13)
        Me.Label15.TabIndex = 123
        Me.Label15.Text = "Note: only $20 and up"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Purple
        Me.Label16.Location = New System.Drawing.Point(628, 423)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(333, 15)
        Me.Label16.TabIndex = 124
        Me.Label16.Text = "Overwrite information and click update if necessary"
        '
        'CustomersAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.ClientSize = New System.Drawing.Size(1152, 450)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Statelst)
        Me.Controls.Add(Me.Year)
        Me.Controls.Add(Me.PhoneNumber)
        Me.Controls.Add(Me.btnTollTransaction)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnReturnTag)
        Me.Controls.Add(Me.btnLostTag)
        Me.Controls.Add(Me.txtAddfunds)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddFunds)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Make)
        Me.Controls.Add(Me.Model)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PlateNumber)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "CustomersAccount"
        Me.Text = "CustomersAccount"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Model As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PlateNumber As TextBox
    Friend WithEvents Email As TextBox
    Friend WithEvents Address As TextBox
    Friend WithEvents LastName As TextBox
    Friend WithEvents FirstName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Make As TextBox
    Friend WithEvents btnAddFunds As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAddfunds As TextBox
    Friend WithEvents btnLostTag As Button
    Friend WithEvents btnReturnTag As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents btnTollTransaction As Button
    Friend WithEvents PhoneNumber As MaskedTextBox
    Friend WithEvents Year As MaskedTextBox
    Friend WithEvents Statelst As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
End Class
