<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmailApp
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
        Me.fromLabel = New System.Windows.Forms.Label()
        Me.subjectLabel = New System.Windows.Forms.Label()
        Me.toLabel = New System.Windows.Forms.Label()
        Me.messageLabel = New System.Windows.Forms.Label()
        Me.fromTextBox = New System.Windows.Forms.TextBox()
        Me.subjectTextBox = New System.Windows.Forms.TextBox()
        Me.toTextBox = New System.Windows.Forms.TextBox()
        Me.messageTextBox = New System.Windows.Forms.TextBox()
        Me.sendButton = New System.Windows.Forms.Button()
        Me.senderEmailTextBox = New System.Windows.Forms.TextBox()
        Me.passwdTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fromLabel
        '
        Me.fromLabel.AutoSize = True
        Me.fromLabel.Location = New System.Drawing.Point(29, 86)
        Me.fromLabel.Name = "fromLabel"
        Me.fromLabel.Size = New System.Drawing.Size(88, 32)
        Me.fromLabel.TabIndex = 0
        Me.fromLabel.Text = "From:"
        '
        'subjectLabel
        '
        Me.subjectLabel.AutoSize = True
        Me.subjectLabel.Location = New System.Drawing.Point(29, 164)
        Me.subjectLabel.Name = "subjectLabel"
        Me.subjectLabel.Size = New System.Drawing.Size(119, 32)
        Me.subjectLabel.TabIndex = 1
        Me.subjectLabel.Text = "Subject:"
        '
        'toLabel
        '
        Me.toLabel.AutoSize = True
        Me.toLabel.Location = New System.Drawing.Point(29, 235)
        Me.toLabel.Name = "toLabel"
        Me.toLabel.Size = New System.Drawing.Size(56, 32)
        Me.toLabel.TabIndex = 2
        Me.toLabel.Text = "To:"
        '
        'messageLabel
        '
        Me.messageLabel.AutoSize = True
        Me.messageLabel.Location = New System.Drawing.Point(29, 328)
        Me.messageLabel.Name = "messageLabel"
        Me.messageLabel.Size = New System.Drawing.Size(138, 32)
        Me.messageLabel.TabIndex = 3
        Me.messageLabel.Text = "Message:"
        '
        'fromTextBox
        '
        Me.fromTextBox.Location = New System.Drawing.Point(173, 79)
        Me.fromTextBox.Name = "fromTextBox"
        Me.fromTextBox.Size = New System.Drawing.Size(362, 39)
        Me.fromTextBox.TabIndex = 4
        '
        'subjectTextBox
        '
        Me.subjectTextBox.Location = New System.Drawing.Point(173, 157)
        Me.subjectTextBox.Name = "subjectTextBox"
        Me.subjectTextBox.Size = New System.Drawing.Size(362, 39)
        Me.subjectTextBox.TabIndex = 5
        '
        'toTextBox
        '
        Me.toTextBox.Location = New System.Drawing.Point(173, 232)
        Me.toTextBox.Name = "toTextBox"
        Me.toTextBox.Size = New System.Drawing.Size(362, 39)
        Me.toTextBox.TabIndex = 6
        '
        'messageTextBox
        '
        Me.messageTextBox.Location = New System.Drawing.Point(173, 325)
        Me.messageTextBox.Multiline = True
        Me.messageTextBox.Name = "messageTextBox"
        Me.messageTextBox.Size = New System.Drawing.Size(505, 292)
        Me.messageTextBox.TabIndex = 7
        '
        'sendButton
        '
        Me.sendButton.Location = New System.Drawing.Point(173, 655)
        Me.sendButton.Name = "sendButton"
        Me.sendButton.Size = New System.Drawing.Size(197, 75)
        Me.sendButton.TabIndex = 8
        Me.sendButton.Text = "Send Mail"
        Me.sendButton.UseVisualStyleBackColor = True
        '
        'senderEmailTextBox
        '
        Me.senderEmailTextBox.Location = New System.Drawing.Point(17, 38)
        Me.senderEmailTextBox.Name = "senderEmailTextBox"
        Me.senderEmailTextBox.Size = New System.Drawing.Size(244, 39)
        Me.senderEmailTextBox.TabIndex = 9
        '
        'passwdTextBox
        '
        Me.passwdTextBox.Location = New System.Drawing.Point(17, 92)
        Me.passwdTextBox.Name = "passwdTextBox"
        Me.passwdTextBox.Size = New System.Drawing.Size(244, 39)
        Me.passwdTextBox.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.senderEmailTextBox)
        Me.GroupBox1.Controls.Add(Me.passwdTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(723, 744)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 158)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SMTP Credentials"
        '
        'EmailApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 923)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.sendButton)
        Me.Controls.Add(Me.messageTextBox)
        Me.Controls.Add(Me.toTextBox)
        Me.Controls.Add(Me.subjectTextBox)
        Me.Controls.Add(Me.fromTextBox)
        Me.Controls.Add(Me.messageLabel)
        Me.Controls.Add(Me.toLabel)
        Me.Controls.Add(Me.subjectLabel)
        Me.Controls.Add(Me.fromLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "EmailApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmailApp"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fromLabel As Label
    Friend WithEvents subjectLabel As Label
    Friend WithEvents toLabel As Label
    Friend WithEvents messageLabel As Label
    Friend WithEvents fromTextBox As TextBox
    Friend WithEvents subjectTextBox As TextBox
    Friend WithEvents toTextBox As TextBox
    Friend WithEvents messageTextBox As TextBox
    Friend WithEvents sendButton As Button
    Friend WithEvents senderEmailTextBox As TextBox
    Friend WithEvents passwdTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
