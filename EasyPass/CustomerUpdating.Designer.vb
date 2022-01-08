<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerUpdating
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
        Me.btnCustomerInformation = New System.Windows.Forms.Button()
        Me.btnUpdateTolls = New System.Windows.Forms.Button()
        Me.btnTagInventory = New System.Windows.Forms.Button()
        Me.btnReturnedTag = New System.Windows.Forms.Button()
        Me.btnTransactions = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCustomerRevenue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCustomerInformation
        '
        Me.btnCustomerInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerInformation.ForeColor = System.Drawing.Color.Red
        Me.btnCustomerInformation.Location = New System.Drawing.Point(12, 12)
        Me.btnCustomerInformation.Name = "btnCustomerInformation"
        Me.btnCustomerInformation.Size = New System.Drawing.Size(131, 58)
        Me.btnCustomerInformation.TabIndex = 0
        Me.btnCustomerInformation.Text = "Customer Information"
        Me.btnCustomerInformation.UseVisualStyleBackColor = True
        '
        'btnUpdateTolls
        '
        Me.btnUpdateTolls.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateTolls.ForeColor = System.Drawing.Color.Red
        Me.btnUpdateTolls.Location = New System.Drawing.Point(249, 12)
        Me.btnUpdateTolls.Name = "btnUpdateTolls"
        Me.btnUpdateTolls.Size = New System.Drawing.Size(131, 58)
        Me.btnUpdateTolls.TabIndex = 1
        Me.btnUpdateTolls.Text = "Update Tolls"
        Me.btnUpdateTolls.UseVisualStyleBackColor = True
        '
        'btnTagInventory
        '
        Me.btnTagInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTagInventory.ForeColor = System.Drawing.Color.Red
        Me.btnTagInventory.Location = New System.Drawing.Point(42, 268)
        Me.btnTagInventory.Name = "btnTagInventory"
        Me.btnTagInventory.Size = New System.Drawing.Size(131, 58)
        Me.btnTagInventory.TabIndex = 3
        Me.btnTagInventory.Text = "Tag Inventory"
        Me.btnTagInventory.UseVisualStyleBackColor = True
        '
        'btnReturnedTag
        '
        Me.btnReturnedTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnedTag.ForeColor = System.Drawing.Color.Red
        Me.btnReturnedTag.Location = New System.Drawing.Point(121, 120)
        Me.btnReturnedTag.Name = "btnReturnedTag"
        Me.btnReturnedTag.Size = New System.Drawing.Size(131, 58)
        Me.btnReturnedTag.TabIndex = 2
        Me.btnReturnedTag.Text = "Returned Tags Record"
        Me.btnReturnedTag.UseVisualStyleBackColor = True
        '
        'btnTransactions
        '
        Me.btnTransactions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransactions.ForeColor = System.Drawing.Color.Red
        Me.btnTransactions.Location = New System.Drawing.Point(423, 268)
        Me.btnTransactions.Name = "btnTransactions"
        Me.btnTransactions.Size = New System.Drawing.Size(131, 58)
        Me.btnTransactions.TabIndex = 4
        Me.btnTransactions.Text = "TransactionsRecord"
        Me.btnTransactions.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(481, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 58)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Toll Revenue "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCustomerRevenue
        '
        Me.btnCustomerRevenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerRevenue.ForeColor = System.Drawing.Color.Red
        Me.btnCustomerRevenue.Location = New System.Drawing.Point(374, 121)
        Me.btnCustomerRevenue.Name = "btnCustomerRevenue"
        Me.btnCustomerRevenue.Size = New System.Drawing.Size(131, 57)
        Me.btnCustomerRevenue.TabIndex = 6
        Me.btnCustomerRevenue.Text = "Customer Revenue"
        Me.btnCustomerRevenue.UseVisualStyleBackColor = True
        '
        'CustomerUpdating
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(624, 360)
        Me.Controls.Add(Me.btnCustomerRevenue)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnTransactions)
        Me.Controls.Add(Me.btnReturnedTag)
        Me.Controls.Add(Me.btnTagInventory)
        Me.Controls.Add(Me.btnUpdateTolls)
        Me.Controls.Add(Me.btnCustomerInformation)
        Me.Name = "CustomerUpdating"
        Me.Text = "CustomerUpdating"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCustomerInformation As Button
    Friend WithEvents btnUpdateTolls As Button
    Friend WithEvents btnTagInventory As Button
    Friend WithEvents btnReturnedTag As Button
    Friend WithEvents btnTransactions As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCustomerRevenue As Button
End Class
