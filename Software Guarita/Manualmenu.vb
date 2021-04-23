Public Class Manualmenu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Manualcadastrar.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Manualconsulta.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Manualmonitoramento.show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Manualentradas.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Manualsaidas.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

 


    Private Sub Manualmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class