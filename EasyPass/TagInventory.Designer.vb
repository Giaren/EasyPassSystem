<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TagInventory
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
        Me.TagstatusTable = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdtLossTags = New System.Windows.Forms.RadioButton()
        Me.rdtActiveTags = New System.Windows.Forms.RadioButton()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.TagstatusTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TagstatusTable
        '
        Me.TagstatusTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TagstatusTable.Location = New System.Drawing.Point(68, 68)
        Me.TagstatusTable.Name = "TagstatusTable"
        Me.TagstatusTable.Size = New System.Drawing.Size(370, 442)
        Me.TagstatusTable.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.rdtLossTags)
        Me.GroupBox1.Controls.Add(Me.rdtActiveTags)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(210, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(244, 44)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tag Status"
        '
        'rdtLossTags
        '
        Me.rdtLossTags.AutoSize = True
        Me.rdtLossTags.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdtLossTags.Location = New System.Drawing.Point(133, 17)
        Me.rdtLossTags.Name = "rdtLossTags"
        Me.rdtLossTags.Size = New System.Drawing.Size(95, 20)
        Me.rdtLossTags.TabIndex = 1
        Me.rdtLossTags.TabStop = True
        Me.rdtLossTags.Text = "Lost Tags"
        Me.rdtLossTags.UseVisualStyleBackColor = True
        '
        'rdtActiveTags
        '
        Me.rdtActiveTags.AutoSize = True
        Me.rdtActiveTags.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdtActiveTags.Location = New System.Drawing.Point(18, 17)
        Me.rdtActiveTags.Name = "rdtActiveTags"
        Me.rdtActiveTags.Size = New System.Drawing.Size(109, 20)
        Me.rdtActiveTags.TabIndex = 0
        Me.rdtActiveTags.TabStop = True
        Me.rdtActiveTags.Text = "Active Tags"
        Me.rdtActiveTags.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Red
        Me.btnBack.Location = New System.Drawing.Point(12, 18)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(106, 32)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'TagInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(556, 543)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TagstatusTable)
        Me.Name = "TagInventory"
        Me.Text = "TagInventory"
        CType(Me.TagstatusTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TagstatusTable As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdtLossTags As RadioButton
    Friend WithEvents rdtActiveTags As RadioButton
    Friend WithEvents btnBack As Button
End Class
