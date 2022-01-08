<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TollProcedure
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
        Me.btnTollProcess = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEndPoint = New System.Windows.Forms.Label()
        Me.TollView = New System.Windows.Forms.DataGridView()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblFare = New System.Windows.Forms.Label()
        Me.lblFinalBalance = New System.Windows.Forms.Label()
        Me.lblCurrentBalance = New System.Windows.Forms.Label()
        Me.lblLabelFinal = New System.Windows.Forms.Label()
        Me.lblLabelCurrent = New System.Windows.Forms.Label()
        Me.lblLabelFare = New System.Windows.Forms.Label()
        Me.DGTollInformation = New System.Windows.Forms.DataGridView()
        Me.txtEntrypoint = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.TollView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGTollInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTollProcess
        '
        Me.btnTollProcess.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnTollProcess.Enabled = False
        Me.btnTollProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTollProcess.ForeColor = System.Drawing.Color.Maroon
        Me.btnTollProcess.Location = New System.Drawing.Point(49, 149)
        Me.btnTollProcess.Name = "btnTollProcess"
        Me.btnTollProcess.Size = New System.Drawing.Size(107, 36)
        Me.btnTollProcess.TabIndex = 2
        Me.btnTollProcess.Text = "Process"
        Me.btnTollProcess.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(110, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Entry Point"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(110, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "End point"
        '
        'lblEndPoint
        '
        Me.lblEndPoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEndPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndPoint.Location = New System.Drawing.Point(24, 107)
        Me.lblEndPoint.Name = "lblEndPoint"
        Me.lblEndPoint.Size = New System.Drawing.Size(265, 30)
        Me.lblEndPoint.TabIndex = 5
        '
        'TollView
        '
        Me.TollView.AllowUserToAddRows = False
        Me.TollView.AllowUserToDeleteRows = False
        Me.TollView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TollView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TollView.Location = New System.Drawing.Point(196, 345)
        Me.TollView.Name = "TollView"
        Me.TollView.ReadOnly = True
        Me.TollView.Size = New System.Drawing.Size(683, 134)
        Me.TollView.TabIndex = 6
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Maroon
        Me.btnClear.Location = New System.Drawing.Point(193, 149)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 36)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(436, 485)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(198, 37)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Retrieve Transactions"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblFare
        '
        Me.lblFare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFare.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFare.Location = New System.Drawing.Point(172, 210)
        Me.lblFare.Name = "lblFare"
        Me.lblFare.Size = New System.Drawing.Size(100, 23)
        Me.lblFare.TabIndex = 9
        Me.lblFare.Visible = False
        '
        'lblFinalBalance
        '
        Me.lblFinalBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFinalBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalBalance.Location = New System.Drawing.Point(172, 294)
        Me.lblFinalBalance.Name = "lblFinalBalance"
        Me.lblFinalBalance.Size = New System.Drawing.Size(100, 23)
        Me.lblFinalBalance.TabIndex = 10
        Me.lblFinalBalance.Visible = False
        '
        'lblCurrentBalance
        '
        Me.lblCurrentBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrentBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentBalance.Location = New System.Drawing.Point(172, 258)
        Me.lblCurrentBalance.Name = "lblCurrentBalance"
        Me.lblCurrentBalance.Size = New System.Drawing.Size(100, 20)
        Me.lblCurrentBalance.TabIndex = 11
        Me.lblCurrentBalance.Visible = False
        '
        'lblLabelFinal
        '
        Me.lblLabelFinal.AutoSize = True
        Me.lblLabelFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabelFinal.ForeColor = System.Drawing.Color.Maroon
        Me.lblLabelFinal.Location = New System.Drawing.Point(33, 294)
        Me.lblLabelFinal.Name = "lblLabelFinal"
        Me.lblLabelFinal.Size = New System.Drawing.Size(133, 20)
        Me.lblLabelFinal.TabIndex = 12
        Me.lblLabelFinal.Text = "Final Balance ="
        Me.lblLabelFinal.Visible = False
        '
        'lblLabelCurrent
        '
        Me.lblLabelCurrent.AutoSize = True
        Me.lblLabelCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabelCurrent.ForeColor = System.Drawing.Color.Maroon
        Me.lblLabelCurrent.Location = New System.Drawing.Point(12, 258)
        Me.lblLabelCurrent.Name = "lblLabelCurrent"
        Me.lblLabelCurrent.Size = New System.Drawing.Size(154, 20)
        Me.lblLabelCurrent.TabIndex = 13
        Me.lblLabelCurrent.Text = "Current Balance ="
        Me.lblLabelCurrent.Visible = False
        '
        'lblLabelFare
        '
        Me.lblLabelFare.AutoSize = True
        Me.lblLabelFare.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabelFare.ForeColor = System.Drawing.Color.Maroon
        Me.lblLabelFare.Location = New System.Drawing.Point(60, 210)
        Me.lblLabelFare.Name = "lblLabelFare"
        Me.lblLabelFare.Size = New System.Drawing.Size(106, 20)
        Me.lblLabelFare.TabIndex = 14
        Me.lblLabelFare.Text = "Fare Price ="
        Me.lblLabelFare.Visible = False
        '
        'DGTollInformation
        '
        Me.DGTollInformation.AllowUserToAddRows = False
        Me.DGTollInformation.AllowUserToDeleteRows = False
        Me.DGTollInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGTollInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTollInformation.Location = New System.Drawing.Point(402, 60)
        Me.DGTollInformation.Name = "DGTollInformation"
        Me.DGTollInformation.ReadOnly = True
        Me.DGTollInformation.Size = New System.Drawing.Size(550, 234)
        Me.DGTollInformation.TabIndex = 15
        '
        'txtEntrypoint
        '
        Me.txtEntrypoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEntrypoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntrypoint.Location = New System.Drawing.Point(24, 34)
        Me.txtEntrypoint.Name = "txtEntrypoint"
        Me.txtEntrypoint.Size = New System.Drawing.Size(265, 30)
        Me.txtEntrypoint.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(572, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(343, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Please click on the entry point you are going through"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(646, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Then click on process"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(320, 318)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(472, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Click Retrieve transaction to view your statements of all the trips you took"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(12, 496)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(274, 15)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Note: You can only take one trip at a time "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(12, 538)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(717, 15)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "The form will close after you process your trip and you will manually have to ope" &
    "n it back to view your statement"
        '
        'TollProcedure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1065, 560)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEntrypoint)
        Me.Controls.Add(Me.DGTollInformation)
        Me.Controls.Add(Me.lblLabelFare)
        Me.Controls.Add(Me.lblLabelCurrent)
        Me.Controls.Add(Me.lblLabelFinal)
        Me.Controls.Add(Me.lblCurrentBalance)
        Me.Controls.Add(Me.lblFinalBalance)
        Me.Controls.Add(Me.lblFare)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.TollView)
        Me.Controls.Add(Me.lblEndPoint)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTollProcess)
        Me.Name = "TollProcedure"
        Me.Text = "TollProcedure"
        CType(Me.TollView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGTollInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTollProcess As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblEndPoint As Label
    Friend WithEvents TollView As DataGridView
    Friend WithEvents btnClear As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblFare As Label
    Friend WithEvents lblFinalBalance As Label
    Friend WithEvents lblCurrentBalance As Label
    Friend WithEvents lblLabelFinal As Label
    Friend WithEvents lblLabelCurrent As Label
    Friend WithEvents lblLabelFare As Label
    Friend WithEvents DGTollInformation As DataGridView
    Friend WithEvents txtEntrypoint As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
