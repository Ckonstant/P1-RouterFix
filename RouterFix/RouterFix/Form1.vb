Imports System.Net
Public Class Form1

    Public Class MyUtilities
        Shared Sub RunCommandCom(command As String, arguments As String, permanent As Boolean)
            Dim p As Process = New Process()
            Dim pi As ProcessStartInfo = New ProcessStartInfo()
            'pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
            pi.FileName = "cmd.exe"
            p.StartInfo = pi
            pi.RedirectStandardInput = True
            pi.RedirectStandardOutput = True
            pi.UseShellExecute = False
            pi.CreateNoWindow = False
            p.Start()
            Dim SR As System.IO.StreamReader = p.StandardOutput
            Dim SW As System.IO.StreamWriter = p.StandardInput
            SW.WriteLine("cd C:\Windows\System32")
            SW.WriteLine("ipconfig /all")
            MessageBox.Show(SR.ReadToEnd)
            SW.Close()
            SR.Close()
        End Sub
    End Class

    Private Sub flushDns()
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        'pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
        pi.FileName = "cmd.exe"
        p.StartInfo = pi
        pi.RedirectStandardInput = True
        pi.RedirectStandardOutput = True
        pi.UseShellExecute = False
        pi.CreateNoWindow = True
        p.Start()
        Dim SR As System.IO.StreamReader = p.StandardOutput
        Dim SW As System.IO.StreamWriter = p.StandardInput
        SW.WriteLine("cd C:\Windows\System32")
        SW.WriteLine("ipconfig /flushdns")
        SW.WriteLine("exit")
        p.CloseMainWindow()
        Form3.RichTextBox1.Text = SR.ReadToEnd
        


        SW.Close()
        SR.Close()
    End Sub
    Private Sub winsockReset()
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        'pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
        pi.FileName = "cmd.exe"
        p.StartInfo = pi
        pi.RedirectStandardInput = True
        pi.RedirectStandardOutput = True
        pi.UseShellExecute = False
        pi.CreateNoWindow = True
        p.Start()
        Dim SR As System.IO.StreamReader = p.StandardOutput
        Dim SW As System.IO.StreamWriter = p.StandardInput
        SW.WriteLine("cd C:\Windows\System32")
        SW.WriteLine("netsh winsock reset")
        SW.WriteLine("exit")
        p.CloseMainWindow()
       
        Form3.RichTextBox1.Text = SR.ReadToEnd
        SW.Close()
        SR.Close()
    End Sub

    Private Sub UbuntuButtonGray1_Click(sender As Object, e As EventArgs)
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        'pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
        pi.FileName = "cmd.exe"
        p.StartInfo = pi
        pi.RedirectStandardInput = True
        pi.RedirectStandardOutput = True
        pi.UseShellExecute = False
        pi.CreateNoWindow = True
        p.Start()
        Dim SR As System.IO.StreamReader = p.StandardOutput
        Dim SW As System.IO.StreamWriter = p.StandardInput
        SW.WriteLine("cd C:\Windows\System32")
        SW.WriteLine("ipconfig /flushdns")
        SW.WriteLine("exit")
        p.CloseMainWindow()
        MessageBox.Show(SR.ReadToEnd)

        SW.Close()
        SR.Close()
    End Sub

    Private Sub UbuntuTheme1_Click(sender As Object, e As EventArgs) Handles UbuntuTheme1.Click

    End Sub
    Public Function HaveInternetConnection() As Boolean

        Try
            Return My.Computer.Network.Ping("www.google.com")
        Catch
            Return False
        End Try

    End Function
    Function Net() As Boolean
        Return My.Computer.Network.Ping("216.58.209.142")
    End Function



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer2.Stop()
        Dim p1 As String
        Dim p2 As String
        Dim p3 As String
        p1 = ""
        p2 = ""
        p3 = ""
        If UbuntuCheckBox1.Checked = True Then
            p1 = "DNS Succesfully Flushed "

        End If
        If UbuntuCheckBox2.Checked = True Then
            p2 = "Winsock Succesfully Reseted "
        End If
        If UbuntuCheckBox3.Checked = True Then
            p3 = "Ip Renewed"
        End If
        Label5.Visible = True
        Label4.Visible = True
        UbuntuCheckBox1.Enabled = False
        UbuntuCheckBox2.Enabled = False
        UbuntuCheckBox3.Enabled = False

        ProgressBar1.Increment(1)
        Label5.Text = ProgressBar1.Value & "%" & " Proccessed."
        PictureBox1.Width = CInt(ProgressBar1.Value * 2.57)
        If ProgressBar1.Value = 2 Then
            Label4.Text = "Testing Internet Connectivity.."
            Form3.RichTextBox1.Text += vbLf + "Testing Internet Connectivity.."
        ElseIf ProgressBar1.Value = 20 Then
            Form3.RichTextBox1.Text += vbLf + "Gathering Connection Status.."
            Label4.Text = "Gathering Connection Status.."
        ElseIf ProgressBar1.Value = 50 Then
            Timer1.Interval = 80
            If p1 <> "" Then
                Form3.RichTextBox1.Text += vbLf + "Flushing DNS.."
                Label4.Text = "Flushing DNS.."
                flushDns()
            End If

        ElseIf ProgressBar1.Value = 76 Then
            If p2 <> "" Then
                Form3.RichTextBox1.Text += vbLf + "Resetting Winsock socks.."
                Label4.Text = "Resetting Winsock socks.."
                winsockReset()
            End If
        ElseIf ProgressBar1.Value = 92 Then
            Timer1.Interval = 170
            Label4.Text = "Finalizing.."
        End If
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            PictureBox1.Visible = False
            Panel3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            PictureBox1.Width = 1
            ProgressBar1.Value = 1
            UbuntuCheckBox1.Enabled = True
            UbuntuCheckBox2.Enabled = True
            UbuntuCheckBox3.Enabled = True
            Timer1.Interval = 35
            Timer2.Start()
            MessageBox.Show("Succesfully Fixed,Restart Required.", "Wireless Recovery", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer2.Start()

        If Not My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then
            MessageBox.Show("You Should run this as Administator in order to work!")
        End If
    End Sub

    Private Sub UbuntuButtonOrange1_Click(sender As Object, e As EventArgs) Handles UbuntuButtonOrange1.Click

        
        If UbuntuCheckBox1.Checked = False AndAlso UbuntuCheckBox2.Checked = False Then
            MessageBox.Show("No options checked to be proccessed.", "Wireless Recovery :Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            NotifyIcon1.BalloonTipTitle = "Wireless Recovery"
            NotifyIcon1.BalloonTipText = "Applying fixes.."
            NotifyIcon1.ShowBalloonTip(0)
            Timer1.Start()
            PictureBox1.Visible = True
            Panel3.Visible = True
        End If
        
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Application.Exit()
    End Sub


    Private Sub Label2_MouseMove(sender As Object, e As MouseEventArgs)

    End Sub
    Private Sub Label2_MouseHover(sender As Object, e As EventArgs)

    End Sub
    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs)

    End Sub
    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'Dim req As System.Net.WebRequest
        ' Dim res As System.Net.WebResponse

        'req = System.Net.WebRequest.Create("http://google.com")
        'req.Proxy = Nothing
        Label4.Visible = True
        Try
            If HaveInternetConnection() Then
                'Label4.ForeColor = Color.FromArgb(242, 148, 110)
                Label4.Text = "Connected to Internet."

            Else
                Label4.Text = "Not Connected to Internet."
            End If

        Catch ex As WebException
            Label4.Text = "Not Connected to Internet."
        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Hide()
        Form2.Show()
    End Sub

    
    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        MessageBox.Show("Nothing to establish.", "Information: Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub CheckUpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckUpdateToolStripMenuItem.Click
        MessageBox.Show("No Updates available!", "Information: Updates", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub UbuntuCheckBox3_CheckedChanged(sender As Object) Handles UbuntuCheckBox3.CheckedChanged
        If UbuntuCheckBox3.Checked = True Then
            Form3.Show()
            Form3.ShowInTaskbar = False
            Form3.Location = New Point(Me.Location.X + Me.Width + 5, Me.Location.Y)
        Else
            Form3.Hide()
        End If

    End Sub
End Class
