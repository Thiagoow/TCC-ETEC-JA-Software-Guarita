Public Class Saidas

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Entradas.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Menus.Show()
        Me.Close()

    End Sub

    Private Sub SaidaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.SaidaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProgguaritaDataSet)

    End Sub

    Private Sub Saidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'ProgguaritaDataSet.saida'. Você pode movê-la ou removê-la conforme necessário.
        Me.SaidaTableAdapter.Fill(Me.ProgguaritaDataSet.saida)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.SaidaTableAdapter.Fill(ProgguaritaDataSet.saida)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Botão de cancelar pesquisa na datagrid"

        TextBox1.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False
        RadioButton8.Checked = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
     
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Relatoriosaida.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'Código de filtrar na datagridview, com oq foi digitado na textbox1"

        If RadioButton1.Checked Then
            SaidaDataGridView.DataSource = Me.ProgguaritaDataSet.saida.Select("placa like '%" & TextBox1.Text & "%'")
        ElseIf RadioButton2.Checked Then
            SaidaDataGridView.DataSource = Me.ProgguaritaDataSet.saida.Select("modelo like '%" & TextBox1.Text & "%'")
        ElseIf RadioButton3.Checked Then
            SaidaDataGridView.DataSource = Me.ProgguaritaDataSet.saida.Select("nome like '%" & TextBox1.Text & "%'")
        ElseIf RadioButton4.Checked Then
            SaidaDataGridView.DataSource = Me.ProgguaritaDataSet.saida.Select("cpf like '%" & TextBox1.Text & "%'")
        ElseIf RadioButton5.Checked Then
            SaidaDataGridView.DataSource = Me.ProgguaritaDataSet.saida.Select("tipo like '%" & TextBox1.Text & "%'")
        ElseIf RadioButton6.Checked Then
            SaidaDataGridView.DataSource = Me.ProgguaritaDataSet.saida.Select("funcao like '%" & TextBox1.Text & "%'")
        ElseIf RadioButton7.Checked Then
            SaidaDataGridView.DataSource = Me.ProgguaritaDataSet.saida.Select("data like '%" & TextBox1.Text & "%'")
        ElseIf RadioButton8.Checked Then
            SaidaDataGridView.DataSource = Me.ProgguaritaDataSet.saida.Select("hora like '%" & TextBox1.Text & "%'")
        End If
    End Sub
End Class