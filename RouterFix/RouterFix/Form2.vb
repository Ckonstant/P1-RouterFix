Public Class Form2

   

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form1.Show()
    End Sub

   
    Private Sub UbuntuButtonOrange1_Click(sender As Object, e As EventArgs) Handles UbuntuButtonOrange1.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class