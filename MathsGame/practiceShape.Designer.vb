<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class practiceShape
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
        Me.shapeBox = New System.Windows.Forms.PictureBox()
        Me.field_1_input = New System.Windows.Forms.TextBox()
        Me.field_1 = New System.Windows.Forms.Label()
        Me.field_2 = New System.Windows.Forms.Label()
        Me.field_2_input = New System.Windows.Forms.TextBox()
        CType(Me.shapeBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'shapeBox
        '
        Me.shapeBox.Location = New System.Drawing.Point(420, 120)
        Me.shapeBox.Name = "shapeBox"
        Me.shapeBox.Size = New System.Drawing.Size(450, 350)
        Me.shapeBox.TabIndex = 0
        Me.shapeBox.TabStop = False
        '
        'field_1_input
        '
        Me.field_1_input.Location = New System.Drawing.Point(420, 512)
        Me.field_1_input.Name = "field_1_input"
        Me.field_1_input.Size = New System.Drawing.Size(100, 20)
        Me.field_1_input.TabIndex = 1
        '
        'field_1
        '
        Me.field_1.AutoSize = True
        Me.field_1.Location = New System.Drawing.Point(417, 486)
        Me.field_1.Name = "field_1"
        Me.field_1.Size = New System.Drawing.Size(41, 13)
        Me.field_1.TabIndex = 2
        Me.field_1.Text = "Field_1"
        '
        'field_2
        '
        Me.field_2.AutoSize = True
        Me.field_2.Location = New System.Drawing.Point(831, 486)
        Me.field_2.Name = "field_2"
        Me.field_2.Size = New System.Drawing.Size(41, 13)
        Me.field_2.TabIndex = 3
        Me.field_2.Text = "Field_2"
        '
        'field_2_input
        '
        Me.field_2_input.Location = New System.Drawing.Point(770, 512)
        Me.field_2_input.Name = "field_2_input"
        Me.field_2_input.Size = New System.Drawing.Size(100, 20)
        Me.field_2_input.TabIndex = 4
        '
        'practiceShape
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 682)
        Me.Controls.Add(Me.field_2_input)
        Me.Controls.Add(Me.field_2)
        Me.Controls.Add(Me.field_1)
        Me.Controls.Add(Me.field_1_input)
        Me.Controls.Add(Me.shapeBox)
        Me.Name = "practiceShape"
        Me.Text = "practiceShape"
        CType(Me.shapeBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents shapeBox As System.Windows.Forms.PictureBox
    Friend WithEvents field_1_input As System.Windows.Forms.TextBox
    Friend WithEvents field_1 As System.Windows.Forms.Label
    Friend WithEvents field_2 As System.Windows.Forms.Label
    Friend WithEvents field_2_input As System.Windows.Forms.TextBox
End Class
