Public Class Manualconsulta

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Manualmenu.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Manualalterar.Show()
        Me.Close()

    End Sub

    Private Sub Manualconsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class