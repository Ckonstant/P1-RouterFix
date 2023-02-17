<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.UbuntuTheme1 = New RouterFix.UbuntuTheme()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UbuntuButtonOrange1 = New RouterFix.UbuntuButtonOrange()
        Me.UbuntuCheckBox3 = New RouterFix.UbuntuCheckBox()
        Me.UbuntuCheckBox2 = New RouterFix.UbuntuCheckBox()
        Me.UbuntuCheckBox1 = New RouterFix.UbuntuCheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckUpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.UbuntuTheme1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 35
        '
        'Timer2
        '
        Me.Timer2.Interval = 6000
        '
        'UbuntuTheme1
        '
        Me.UbuntuTheme1.BackColor = System.Drawing.Color.Transparent
        Me.UbuntuTheme1.Controls.Add(Me.Label6)
        Me.UbuntuTheme1.Controls.Add(Me.Label5)
        Me.UbuntuTheme1.Controls.Add(Me.Label4)
        Me.UbuntuTheme1.Controls.Add(Me.ProgressBar1)
        Me.UbuntuTheme1.Controls.Add(Me.Panel3)
        Me.UbuntuTheme1.Controls.Add(Me.Label3)
        Me.UbuntuTheme1.Controls.Add(Me.Label2)
        Me.UbuntuTheme1.Controls.Add(Me.UbuntuButtonOrange1)
        Me.UbuntuTheme1.Controls.Add(Me.UbuntuCheckBox3)
        Me.UbuntuTheme1.Controls.Add(Me.UbuntuCheckBox2)
        Me.UbuntuTheme1.Controls.Add(Me.UbuntuCheckBox1)
        Me.UbuntuTheme1.Controls.Add(Me.Label1)
        Me.UbuntuTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UbuntuTheme1.Location = New System.Drawing.Point(0, 0)
        Me.UbuntuTheme1.Name = "UbuntuTheme1"
        Me.UbuntuTheme1.Size = New System.Drawing.Size(284, 218)
        Me.UbuntuTheme1.TabIndex = 0
        Me.UbuntuTheme1.Text = "Wireless Recovery(Kon)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label6.Location = New System.Drawing.Point(171, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Administrator."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(190, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Label5"
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Label4"
        Me.Label4.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(238, 104)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(10, 10)
        Me.ProgressBar1.TabIndex = 1
        Me.ProgressBar1.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel3.Location = New System.Drawing.Point(12, 187)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(257, 10)
        Me.Panel3.TabIndex = 18
        Me.Panel3.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Coral
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1, 10)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Coral
        Me.Label3.Location = New System.Drawing.Point(249, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "?"
        Me.ToolTip1.SetToolTip(Me.Label3, "About Wireless Recovery")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Coral
        Me.Label2.Location = New System.Drawing.Point(266, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "X"
        '
        'UbuntuButtonOrange1
        '
        Me.UbuntuButtonOrange1.BackColor = System.Drawing.Color.Transparent
        Me.UbuntuButtonOrange1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UbuntuButtonOrange1.Location = New System.Drawing.Point(71, 149)
        Me.UbuntuButtonOrange1.Name = "UbuntuButtonOrange1"
        Me.UbuntuButtonOrange1.Size = New System.Drawing.Size(120, 23)
        Me.UbuntuButtonOrange1.TabIndex = 15
        Me.UbuntuButtonOrange1.Text = "Apply Fixes"
        '
        'UbuntuCheckBox3
        '
        Me.UbuntuCheckBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.UbuntuCheckBox3.Checked = False
        Me.UbuntuCheckBox3.ForeColor = System.Drawing.Color.Black
        Me.UbuntuCheckBox3.Location = New System.Drawing.Point(12, 120)
        Me.UbuntuCheckBox3.Name = "UbuntuCheckBox3"
        Me.UbuntuCheckBox3.Size = New System.Drawing.Size(131, 14)
        Me.UbuntuCheckBox3.TabIndex = 14
        Me.UbuntuCheckBox3.Text = "Show Details(Beta)"
        '
        'UbuntuCheckBox2
        '
        Me.UbuntuCheckBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.UbuntuCheckBox2.Checked = True
        Me.UbuntuCheckBox2.ForeColor = System.Drawing.Color.Black
        Me.UbuntuCheckBox2.Location = New System.Drawing.Point(12, 100)
        Me.UbuntuCheckBox2.Name = "UbuntuCheckBox2"
        Me.UbuntuCheckBox2.Size = New System.Drawing.Size(131, 14)
        Me.UbuntuCheckBox2.TabIndex = 13
        Me.UbuntuCheckBox2.Text = "Reset Winsock"
        '
        'UbuntuCheckBox1
        '
        Me.UbuntuCheckBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.UbuntuCheckBox1.Checked = True
        Me.UbuntuCheckBox1.ForeColor = System.Drawing.Color.Black
        Me.UbuntuCheckBox1.Location = New System.Drawing.Point(12, 79)
        Me.UbuntuCheckBox1.Name = "UbuntuCheckBox1"
        Me.UbuntuCheckBox1.Size = New System.Drawing.Size(131, 14)
        Me.UbuntuCheckBox1.TabIndex = 12
        Me.UbuntuCheckBox1.Text = "Flush DNS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 26)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "This Programm needs administrative priviliges ," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  so make sure you run it as an " & _
    ""
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Wireless Recovery tool (working)"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.CheckUpdateToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(167, 70)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(166, 22)
        Me.ToolStripMenuItem1.Text = "Connection Test"
        Me.ToolStripMenuItem1.ToolTipText = "Integrity Checks on router."
        '
        'CheckUpdateToolStripMenuItem
        '
        Me.CheckUpdateToolStripMenuItem.Name = "CheckUpdateToolStripMenuItem"
        Me.CheckUpdateToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.CheckUpdateToolStripMenuItem.Text = "Check for Update"
        Me.CheckUpdateToolStripMenuItem.ToolTipText = "Searching for Updates."
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 218)
        Me.Controls.Add(Me.UbuntuTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Internet Fix Tool "
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.UbuntuTheme1.ResumeLayout(False)
        Me.UbuntuTheme1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UbuntuTheme1 As RouterFix.UbuntuTheme
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UbuntuButtonOrange1 As RouterFix.UbuntuButtonOrange
    Friend WithEvents UbuntuCheckBox3 As RouterFix.UbuntuCheckBox
    Friend WithEvents UbuntuCheckBox2 As RouterFix.UbuntuCheckBox
    Friend WithEvents UbuntuCheckBox1 As RouterFix.UbuntuCheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckUpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
