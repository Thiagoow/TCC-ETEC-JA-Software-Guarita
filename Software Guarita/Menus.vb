Public Class Menus

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cadastro.Show()
        Cadastro.Button1.Visible = False
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Monitoramento.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Entradas.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Saidas.Show()
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Timer1.Tick
        Label2.Text = DateTime.Now.ToLongTimeString()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
     
    End Sub

    Private Sub Menus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Label3.Text = Today
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Consultar.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Alterar.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Manualmenu.Show()
    End Sub
End Class