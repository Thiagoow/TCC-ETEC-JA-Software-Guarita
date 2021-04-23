Public Class inicio

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click, Timer1.Tick
        Label4.Text = DateTime.Now.ToLongTimeString()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Label5.Text = Today
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Menus.Show()
        Me.Close()
    End Sub
End Class