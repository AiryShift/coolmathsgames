﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class exitForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(exitForm))
        Me.yes = New System.Windows.Forms.Button()
        Me.no = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'yes
        '
        Me.yes.Location = New System.Drawing.Point(12, 12)
        Me.yes.Name = "yes"
        Me.yes.Size = New System.Drawing.Size(244, 23)
        Me.yes.TabIndex = 0
        Me.yes.Text = "Yes"
        Me.yes.UseVisualStyleBackColor = True
        '
        'no
        '
        Me.no.Location = New System.Drawing.Point(262, 12)
        Me.no.Name = "no"
        Me.no.Size = New System.Drawing.Size(221, 23)
        Me.no.TabIndex = 1
        Me.no.Text = "No"
        Me.no.UseVisualStyleBackColor = True
        '
        'exitForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MathsGame.My.Resources.Resources.MapleStory_SVG
        Me.ClientSize = New System.Drawing.Size(495, 43)
        Me.Controls.Add(Me.no)
        Me.Controls.Add(Me.yes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "exitForm"
        Me.Text = "Are you sure that you want to go?"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents yes As System.Windows.Forms.Button
    Friend WithEvents no As System.Windows.Forms.Button
End Class
