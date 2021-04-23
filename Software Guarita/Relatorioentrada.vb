Public Class Relatorioentrada

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Entradas.Show()
        Me.Close()
    End Sub

    Private Sub Relatorioentrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'progguaritaDataSet.entrada' table. You can move, or remove it, as needed.
        Me.entradaTableAdapter.Fill(Me.progguaritaDataSet.entrada)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class