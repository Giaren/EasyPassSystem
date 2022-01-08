<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateTolls
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
        Me.TollInformation = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdateFare = New System.Windows.Forms.Button()
        Me.txtFarePrice = New System.Windows.Forms.TextBox()
        Me.btnaddtoll = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.TollInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TollInformation
        '
        Me.TollInformation.AllowUserToOrderColumns = True
        Me.TollInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TollInformation.Location = New System.Drawing.Point(56, 56)
        Me.TollInformation.Name = "TollInformation"
        Me.TollInformation.Size = New System.Drawing.Size(485, 261)
        Me.TollInformation.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(218, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Toll Information"
        '
        'btnUpdateFare
        '
        Me.btnUpdateFare.Enabled = False
        Me.btnUpdateFare.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateFare.ForeColor = System.Drawing.Color.Red
        Me.btnUpdateFare.Location = New System.Drawing.Point(35, 323)
        Me.btnUpdateFare.Name = "btnUpdateFare"
        Me.btnUpdateFare.Size = New System.Drawing.Size(113, 60)
        Me.btnUpdateFare.TabIndex = 2
        Me.btnUpdateFare.Text = "Update Fare Price"
        Me.btnUpdateFare.UseVisualStyleBackColor = True
        '
        'txtFarePrice
        '
        Me.txtFarePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFarePrice.Location = New System.Drawing.Point(164, 340)
        Me.txtFarePrice.Name = "txtFarePrice"
        Me.txtFarePrice.ReadOnly = True
        Me.txtFarePrice.Size = New System.Drawing.Size(98, 26)
        Me.txtFarePrice.TabIndex = 3
        '
        'btnaddtoll
        '
        Me.btnaddtoll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddtoll.ForeColor = System.Drawing.Color.Red
        Me.btnaddtoll.Location = New System.Drawing.Point(374, 334)
        Me.btnaddtoll.Name = "btnaddtoll"
        Me.btnaddtoll.Size = New System.Drawing.Size(128, 38)
        Me.btnaddtoll.TabIndex = 4
        Me.btnaddtoll.Text = "Add New Toll"
        Me.btnaddtoll.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Red
        Me.btnBack.Location = New System.Drawing.Point(12, 18)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(106, 32)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'UpdateTolls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(598, 395)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnaddtoll)
        Me.Controls.Add(Me.txtFarePrice)
        Me.Controls.Add(Me.btnUpdateFare)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TollInformation)
        Me.Name = "UpdateTolls"
        Me.Text = "UpdateTolls"
        CType(Me.TollInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TollInformation As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpdateFare As Button
    Friend WithEvents txtFarePrice As TextBox
    Friend WithEvents btnaddtoll As Button
    Friend WithEvents btnBack As Button
End Class
