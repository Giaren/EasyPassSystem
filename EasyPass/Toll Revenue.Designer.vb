<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Toll_Revenue
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
        Me.TollRevenue = New System.Windows.Forms.DataGridView()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.GrandTotal = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTollName = New System.Windows.Forms.TextBox()
        Me.btnSortFare = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.TollRevenue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TollRevenue
        '
        Me.TollRevenue.AllowUserToOrderColumns = True
        Me.TollRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TollRevenue.Location = New System.Drawing.Point(94, 72)
        Me.TollRevenue.Name = "TollRevenue"
        Me.TollRevenue.Size = New System.Drawing.Size(445, 189)
        Me.TollRevenue.TabIndex = 0
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Red
        Me.label1.Location = New System.Drawing.Point(233, 23)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(203, 24)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Toll Revenue Report"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Red
        Me.label2.Location = New System.Drawing.Point(47, 332)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(146, 24)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Total Revenue"
        '
        'GrandTotal
        '
        Me.GrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrandTotal.Location = New System.Drawing.Point(199, 334)
        Me.GrandTotal.Name = "GrandTotal"
        Me.GrandTotal.Size = New System.Drawing.Size(146, 24)
        Me.GrandTotal.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Red
        Me.btnSearch.Location = New System.Drawing.Point(358, 373)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(102, 40)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(217, 372)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 41)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(380, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Toll Name"
        '
        'txtTollName
        '
        Me.txtTollName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTollName.Location = New System.Drawing.Point(474, 332)
        Me.txtTollName.Name = "txtTollName"
        Me.txtTollName.Size = New System.Drawing.Size(158, 26)
        Me.txtTollName.TabIndex = 21
        '
        'btnSortFare
        '
        Me.btnSortFare.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSortFare.ForeColor = System.Drawing.Color.Red
        Me.btnSortFare.Location = New System.Drawing.Point(442, 39)
        Me.btnSortFare.Name = "btnSortFare"
        Me.btnSortFare.Size = New System.Drawing.Size(190, 27)
        Me.btnSortFare.TabIndex = 26
        Me.btnSortFare.Text = "Sort By Lowest Fare"
        Me.btnSortFare.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(22, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 27)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Sort By highest Fare"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(512, 372)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 40)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Sort By Name"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Toll_Revenue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(641, 452)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSortFare)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTollName)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.GrandTotal)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.TollRevenue)
        Me.Name = "Toll_Revenue"
        Me.Text = "Toll_Revenue"
        CType(Me.TollRevenue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TollRevenue As DataGridView
    Friend WithEvents label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents GrandTotal As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTollName As TextBox
    Friend WithEvents btnSortFare As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
