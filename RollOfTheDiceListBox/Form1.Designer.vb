<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.RollButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox
        '
        Me.ListBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ListBox.BackColor = System.Drawing.Color.Thistle
        Me.ListBox.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.ItemHeight = 14
        Me.ListBox.Location = New System.Drawing.Point(12, 72)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(444, 368)
        Me.ListBox.TabIndex = 3
        '
        'RollButton
        '
        Me.RollButton.BackColor = System.Drawing.Color.CadetBlue
        Me.RollButton.Location = New System.Drawing.Point(12, 12)
        Me.RollButton.Name = "RollButton"
        Me.RollButton.Size = New System.Drawing.Size(205, 54)
        Me.RollButton.TabIndex = 0
        Me.RollButton.Text = "Roll The Dice"
        Me.ToolTip1.SetToolTip(Me.RollButton, "Press this to roll two dice 1000 times")
        Me.RollButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.CadetBlue
        Me.ExitButton.Location = New System.Drawing.Point(416, 12)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(40, 23)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Press this to exit the program")
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.CadetBlue
        Me.ClearButton.Location = New System.Drawing.Point(223, 12)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(187, 54)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(466, 449)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.RollButton)
        Me.Controls.Add(Me.ListBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox As ListBox
    Friend WithEvents RollButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ClearButton As Button
End Class
