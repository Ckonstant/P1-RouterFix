﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.UbuntuTheme1 = New RouterFix.UbuntuTheme()
        Me.UbuntuButtonOrange1 = New RouterFix.UbuntuButtonOrange()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UbuntuTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UbuntuTheme1
        '
        Me.UbuntuTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.UbuntuTheme1.Controls.Add(Me.Label2)
        Me.UbuntuTheme1.Controls.Add(Me.UbuntuButtonOrange1)
        Me.UbuntuTheme1.Controls.Add(Me.Label1)
        Me.UbuntuTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UbuntuTheme1.Location = New System.Drawing.Point(0, 0)
        Me.UbuntuTheme1.Name = "UbuntuTheme1"
        Me.UbuntuTheme1.Size = New System.Drawing.Size(156, 210)
        Me.UbuntuTheme1.TabIndex = 0
        Me.UbuntuTheme1.Text = "About Recover"
        '
        'UbuntuButtonOrange1
        '
        Me.UbuntuButtonOrange1.BackColor = System.Drawing.Color.Transparent
        Me.UbuntuButtonOrange1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UbuntuButtonOrange1.Location = New System.Drawing.Point(24, 174)
        Me.UbuntuButtonOrange1.Name = "UbuntuButtonOrange1"
        Me.UbuntuButtonOrange1.Size = New System.Drawing.Size(95, 28)
        Me.UbuntuButtonOrange1.TabIndex = 1
        Me.UbuntuButtonOrange1.Text = "OK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 117)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Wireless Recover" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Copyright 2018 ©" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All rights Reserved," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Konstantinides Christ" & _
    "os ®" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Version :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Thanks for Supporting!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(59, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Alpha Test"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(156, 210)
        Me.Controls.Add(Me.UbuntuTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.UbuntuTheme1.ResumeLayout(False)
        Me.UbuntuTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UbuntuTheme1 As RouterFix.UbuntuTheme
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UbuntuButtonOrange1 As RouterFix.UbuntuButtonOrange
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
