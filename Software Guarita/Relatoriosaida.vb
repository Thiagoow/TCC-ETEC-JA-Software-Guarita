Public Class Relatoriosaida

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Saidas.Show()
        Me.Close()
    End Sub

    Private Sub Relatoriosaida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'progguaritaDataSet.saida' table. You can move, or remove it, as needed.
        Me.saidaTableAdapter.Fill(Me.progguaritaDataSet.saida)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class