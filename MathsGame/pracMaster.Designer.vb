<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pracMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pracMaster))
        Me.back = New System.Windows.Forms.Button()
        Me.shapeDesc = New System.Windows.Forms.PictureBox()
        Me.shapeFormula = New System.Windows.Forms.PictureBox()
        Me.txtInput1 = New System.Windows.Forms.TextBox()
        Me.txtInput3 = New System.Windows.Forms.TextBox()
        Me.txtInput2 = New System.Windows.Forms.TextBox()
        Me.lblInput1 = New System.Windows.Forms.Label()
        Me.lblInput2 = New System.Windows.Forms.Label()
        Me.lblInput3 = New System.Windows.Forms.Label()
        Me.info = New System.Windows.Forms.PictureBox()
        CType(Me.shapeDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shapeFormula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(1177, 645)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(75, 24)
        Me.back.TabIndex = 0
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = True
        '
        'shapeDesc
        '
        Me.shapeDesc.Location = New System.Drawing.Point(802, 12)
        Me.shapeDesc.Name = "shapeDesc"
        Me.shapeDesc.Size = New System.Drawing.Size(450, 450)
        Me.shapeDesc.TabIndex = 1
        Me.shapeDesc.TabStop = False
        '
        'shapeFormula
        '
        Me.shapeFormula.Location = New System.Drawing.Point(802, 468)
        Me.shapeFormula.Name = "shapeFormula"
        Me.shapeFormula.Size = New System.Drawing.Size(450, 63)
        Me.shapeFormula.TabIndex = 2
        Me.shapeFormula.TabStop = False
        '
        'txtInput1
        '
        Me.txtInput1.Location = New System.Drawing.Point(802, 558)
        Me.txtInput1.Name = "txtInput1"
        Me.txtInput1.Size = New System.Drawing.Size(100, 20)
        Me.txtInput1.TabIndex = 3
        '
        'txtInput3
        '
        Me.txtInput3.Location = New System.Drawing.Point(1152, 558)
        Me.txtInput3.Name = "txtInput3"
        Me.txtInput3.Size = New System.Drawing.Size(100, 20)
        Me.txtInput3.TabIndex = 4
        '
        'txtInput2
        '
        Me.txtInput2.Location = New System.Drawing.Point(983, 558)
        Me.txtInput2.Name = "txtInput2"
        Me.txtInput2.Size = New System.Drawing.Size(100, 20)
        Me.txtInput2.TabIndex = 5
        '
        'lblInput1
        '
        Me.lblInput1.AutoSize = True
        Me.lblInput1.Location = New System.Drawing.Point(799, 534)
        Me.lblInput1.Name = "lblInput1"
        Me.lblInput1.Size = New System.Drawing.Size(39, 13)
        Me.lblInput1.TabIndex = 6
        Me.lblInput1.Text = "Label1"
        '
        'lblInput2
        '
        Me.lblInput2.AutoSize = True
        Me.lblInput2.Location = New System.Drawing.Point(980, 534)
        Me.lblInput2.Name = "lblInput2"
        Me.lblInput2.Size = New System.Drawing.Size(39, 13)
        Me.lblInput2.TabIndex = 7
        Me.lblInput2.Text = "Label2"
        '
        'lblInput3
        '
        Me.lblInput3.AutoSize = True
        Me.lblInput3.Location = New System.Drawing.Point(1149, 534)
        Me.lblInput3.Name = "lblInput3"
        Me.lblInput3.Size = New System.Drawing.Size(39, 13)
        Me.lblInput3.TabIndex = 8
        Me.lblInput3.Text = "Label3"
        '
        'info
        '
        Me.info.Location = New System.Drawing.Point(12, 12)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(784, 450)
        Me.info.TabIndex = 9
        Me.info.TabStop = False
        '
        'pracMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.lblInput3)
        Me.Controls.Add(Me.lblInput2)
        Me.Controls.Add(Me.lblInput1)
        Me.Controls.Add(Me.txtInput2)
        Me.Controls.Add(Me.txtInput3)
        Me.Controls.Add(Me.txtInput1)
        Me.Controls.Add(Me.shapeFormula)
        Me.Controls.Add(Me.shapeDesc)
        Me.Controls.Add(Me.back)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pracMaster"
        Me.Text = "Try this shape!"
        CType(Me.shapeDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shapeFormula, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents back As Button
    Friend WithEvents shapeDesc As PictureBox
    Friend WithEvents shapeFormula As PictureBox
    Friend WithEvents txtInput1 As TextBox
    Friend WithEvents txtInput3 As TextBox
    Friend WithEvents txtInput2 As TextBox
    Friend WithEvents lblInput1 As Label
    Friend WithEvents lblInput2 As Label
    Friend WithEvents lblInput3 As Label
    Friend WithEvents info As PictureBox
End Class
