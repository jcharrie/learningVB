﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWords = New System.Windows.Forms.TextBox()
        Me.radCountChars = New System.Windows.Forms.RadioButton()
        Me.radCountWords = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter some text for counting"
        '
        'txtWords
        '
        Me.txtWords.Location = New System.Drawing.Point(13, 30)
        Me.txtWords.Multiline = True
        Me.txtWords.Name = "txtWords"
        Me.txtWords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtWords.Size = New System.Drawing.Size(350, 217)
        Me.txtWords.TabIndex = 1
        '
        'radCountChars
        '
        Me.radCountChars.AutoSize = True
        Me.radCountChars.Checked = True
        Me.radCountChars.Location = New System.Drawing.Point(13, 264)
        Me.radCountChars.Name = "radCountChars"
        Me.radCountChars.Size = New System.Drawing.Size(52, 17)
        Me.radCountChars.TabIndex = 2
        Me.radCountChars.TabStop = True
        Me.radCountChars.Text = "Chars"
        Me.radCountChars.UseVisualStyleBackColor = True
        '
        'radCountWords
        '
        Me.radCountWords.AutoSize = True
        Me.radCountWords.Location = New System.Drawing.Point(110, 264)
        Me.radCountWords.Name = "radCountWords"
        Me.radCountWords.Size = New System.Drawing.Size(56, 17)
        Me.radCountWords.TabIndex = 3
        Me.radCountWords.Text = "Words"
        Me.radCountWords.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "The results are:"
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(259, 268)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(0, 13)
        Me.lblResults.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 293)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.radCountWords)
        Me.Controls.Add(Me.radCountChars)
        Me.Controls.Add(Me.txtWords)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Word Counter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtWords As TextBox
    Friend WithEvents radCountChars As RadioButton
    Friend WithEvents radCountWords As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents lblResults As Label
End Class
