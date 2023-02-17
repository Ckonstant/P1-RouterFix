<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.UbuntuTheme1 = New RouterFix.UbuntuTheme()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.UbuntuButtonOrange1 = New RouterFix.UbuntuButtonOrange()
        Me.UbuntuTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-2, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Command Line Details view:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5
        '
        'UbuntuTheme1
        '
        Me.UbuntuTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.UbuntuTheme1.Controls.Add(Me.RichTextBox1)
        Me.UbuntuTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UbuntuTheme1.Location = New System.Drawing.Point(0, 0)
        Me.UbuntuTheme1.Name = "UbuntuTheme1"
        Me.UbuntuTheme1.Size = New System.Drawing.Size(392, 218)
        Me.UbuntuTheme1.TabIndex = 3
        Me.UbuntuTheme1.Text = "Command Line Details:"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.ForeColor = System.Drawing.Color.OrangeRed
        Me.RichTextBox1.Location = New System.Drawing.Point(1, 26)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(389, 193)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'UbuntuButtonOrange1
        '
        Me.UbuntuButtonOrange1.BackColor = System.Drawing.Color.Transparent
        Me.UbuntuButtonOrange1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UbuntuButtonOrange1.Location = New System.Drawing.Point(363, 2)
        Me.UbuntuButtonOrange1.Name = "UbuntuButtonOrange1"
        Me.UbuntuButtonOrange1.Size = New System.Drawing.Size(27, 23)
        Me.UbuntuButtonOrange1.TabIndex = 1
        Me.UbuntuButtonOrange1.Text = "X"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 218)
        Me.Controls.Add(Me.UbuntuTheme1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UbuntuButtonOrange1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form3"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.UbuntuTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UbuntuButtonOrange1 As RouterFix.UbuntuButtonOrange
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents UbuntuTheme1 As RouterFix.UbuntuTheme
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
End Class
