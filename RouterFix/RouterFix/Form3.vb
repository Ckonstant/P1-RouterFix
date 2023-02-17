Public Class Form3

    Private Sub UbuntuButtonOrange1_Click(sender As Object, e As EventArgs) Handles UbuntuButtonOrange1.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Location = New Point(Form1.Location.X + Form1.Width + 5, Form1.Location.Y)
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class