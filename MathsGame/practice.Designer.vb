<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class practiceMain
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
        Me.area = New System.Windows.Forms.Button()
        Me.volume = New System.Windows.Forms.Button()
        Me.shape1 = New System.Windows.Forms.Button()
        Me.shape2 = New System.Windows.Forms.Button()
        Me.shape3 = New System.Windows.Forms.Button()
        Me.shape4 = New System.Windows.Forms.Button()
        Me.shape5 = New System.Windows.Forms.Button()
        Me.shape6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'area
        '
        Me.area.Location = New System.Drawing.Point(12, 12)
        Me.area.Name = "area"
        Me.area.Size = New System.Drawing.Size(100, 100)
        Me.area.TabIndex = 0
        Me.area.Text = "Select Area"
        Me.area.UseVisualStyleBackColor = True
        '
        'volume
        '
        Me.volume.Location = New System.Drawing.Point(12, 118)
        Me.volume.Name = "volume"
        Me.volume.Size = New System.Drawing.Size(100, 100)
        Me.volume.TabIndex = 1
        Me.volume.Text = "Select Volume"
        Me.volume.UseVisualStyleBackColor = True
        '
        'shape1
        '
        Me.shape1.Location = New System.Drawing.Point(12, 224)
        Me.shape1.Name = "shape1"
        Me.shape1.Size = New System.Drawing.Size(100, 23)
        Me.shape1.TabIndex = 2
        Me.shape1.Text = "Button1"
        Me.shape1.UseVisualStyleBackColor = True
        '
        'shape2
        '
        Me.shape2.Location = New System.Drawing.Point(12, 253)
        Me.shape2.Name = "shape2"
        Me.shape2.Size = New System.Drawing.Size(100, 23)
        Me.shape2.TabIndex = 3
        Me.shape2.Text = "Button2"
        Me.shape2.UseVisualStyleBackColor = True
        '
        'shape3
        '
        Me.shape3.Location = New System.Drawing.Point(12, 282)
        Me.shape3.Name = "shape3"
        Me.shape3.Size = New System.Drawing.Size(100, 23)
        Me.shape3.TabIndex = 4
        Me.shape3.Text = "Button3"
        Me.shape3.UseVisualStyleBackColor = True
        '
        'shape4
        '
        Me.shape4.Location = New System.Drawing.Point(12, 311)
        Me.shape4.Name = "shape4"
        Me.shape4.Size = New System.Drawing.Size(100, 23)
        Me.shape4.TabIndex = 5
        Me.shape4.Text = "Button4"
        Me.shape4.UseVisualStyleBackColor = True
        '
        'shape5
        '
        Me.shape5.Location = New System.Drawing.Point(12, 340)
        Me.shape5.Name = "shape5"
        Me.shape5.Size = New System.Drawing.Size(100, 23)
        Me.shape5.TabIndex = 6
        Me.shape5.Text = "Button5"
        Me.shape5.UseVisualStyleBackColor = True
        '
        'shape6
        '
        Me.shape6.Location = New System.Drawing.Point(12, 369)
        Me.shape6.Name = "shape6"
        Me.shape6.Size = New System.Drawing.Size(100, 23)
        Me.shape6.TabIndex = 7
        Me.shape6.Text = "Button6"
        Me.shape6.UseVisualStyleBackColor = True
        '
        'practiceMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 682)
        Me.Controls.Add(Me.shape6)
        Me.Controls.Add(Me.shape5)
        Me.Controls.Add(Me.shape4)
        Me.Controls.Add(Me.shape3)
        Me.Controls.Add(Me.shape2)
        Me.Controls.Add(Me.shape1)
        Me.Controls.Add(Me.volume)
        Me.Controls.Add(Me.area)
        Me.Name = "practiceMain"
        Me.Text = "Practice"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents area As System.Windows.Forms.Button
    Friend WithEvents volume As System.Windows.Forms.Button
    Friend WithEvents shape1 As System.Windows.Forms.Button
    Friend WithEvents shape2 As System.Windows.Forms.Button
    Friend WithEvents shape3 As System.Windows.Forms.Button
    Friend WithEvents shape4 As System.Windows.Forms.Button
    Friend WithEvents shape5 As System.Windows.Forms.Button
    Friend WithEvents shape6 As System.Windows.Forms.Button
End Class
