Public Class Consultar

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Alterar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProgguaritaDataSet.cadastro' table. You can move, or remove it, as needed.
        Me.CadastroTableAdapter.Fill(Me.ProgguaritaDataSet.cadastro)
        'TODO: This line of code loads data into the 'ProgguaritaDataSet.cadastro' table. You can move, or remove it, as needed.
        Me.CadastroTableAdapter.Fill(Me.ProgguaritaDataSet.cadastro)


        MaskedTextBox1.Clear()
        PlacaTextBox.Clear()
        CpfTextBox.Clear()


    End Sub

    Private Sub CadastroBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CadastroBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProgguaritaDataSet)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Alterar.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Menus.Show()
        Me.Close()
    End Sub

    Private Sub PlacaTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles PlacaTextBox.MaskInputRejected
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        MaskedTextBox1.Text = ""
        MaskedTextBox1.Mask = "AAA-AAAA"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        MaskedTextBox1.Text = ""
        MaskedTextBox1.Mask = "AAA.AAA.AAA-AA"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        TextBox1.Text = MaskedTextBox1.Text

        PlacaTextBox.Text = PlacaTextBox.Text.ToUpper()

        If RadioButton1.Checked Then

            If TextBox1.TextLength = 8 Then
                MaskedTextBox1.Text = MaskedTextBox1.Text.ToUpper()
                If MaskedTextBox1.Text = Me.CadastroTableAdapter.compara(MaskedTextBox1.Text) Then
                    Try
                        If MaskedTextBox1.Text = Me.CadastroTableAdapter.compara(MaskedTextBox1.Text) Then
                            PlacaTextBox.Text = Me.CadastroTableAdapter.PuxaPlaca(MaskedTextBox1.Text)
                            CpfTextBox.Text = Me.CadastroTableAdapter.PuxaCpf(MaskedTextBox1.Text)
                            CadastroDataGridView.DataSource = Me.ProgguaritaDataSet.cadastro.Select("placa like '%" & MaskedTextBox1.Text & "%'")
                        Else
                            MessageBox.Show("Não existe uma pessoa cadastrada com a placa inserida!, ou, o campo esta vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                End If
            Else
                MessageBox.Show("Não existe a placa com tamanho menor que 7, ou, vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf RadioButton3.Checked Then
            If TextBox1.TextLength = 14 Then
                MaskedTextBox1.Text = MaskedTextBox1.Text.ToUpper()
                If MaskedTextBox1.Text = Me.CadastroTableAdapter.comparaC(MaskedTextBox1.Text) Then
                    Try
                        If MaskedTextBox1.Text = Me.CadastroTableAdapter.comparaC(MaskedTextBox1.Text) Then
                            PlacaTextBox.Text = Me.CadastroTableAdapter.PuxaPlacaC(MaskedTextBox1.Text)
                            CpfTextBox.Text = Me.CadastroTableAdapter.PuxaCpfC(MaskedTextBox1.Text)
                            CadastroDataGridView.DataSource = Me.ProgguaritaDataSet.cadastro.Select("cpf like '%" & MaskedTextBox1.Text & "%'")

                        End If

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                Else
                    MessageBox.Show("Não existe uma pessoa cadastrada com o CPF inserido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Não existe um CPF com tamanho menos de 11 caractéres, ou, vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

    Private Sub NomeTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MaskedTextBox1.Clear()
        PlacaTextBox.Clear()
        CpfTextBox.Clear()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

            If TextBox1.TextLength > 1 Then

                If MessageBox.Show("Deseja mesmo excluir os dados do cadastro? Clique 'Sim' para continuar, ou, 'Não' para cancelar esta ação", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

                    If RadioButton1.Checked Then
                        If MaskedTextBox1.Text = Me.CadastroTableAdapter.compara(MaskedTextBox1.Text) Then


                            Me.CadastroTableAdapter.ExcluirP(MaskedTextBox1.Text)
                            MessageBox.Show("Dados excluídos com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Não existe uma pessoa cadastrada com a placa inserida, ou, o campo esta vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                    ElseIf RadioButton3.Checked Then
                    If MaskedTextBox1.Text = Me.CadastroTableAdapter.comparaC(MaskedTextBox1.Text) Then

                        Me.CadastroTableAdapter.ExcluirC(MaskedTextBox1.Text)
                        MessageBox.Show("Dados excluídos com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Não existe uma pessoa cadastrada com o CPF inserido, ou, o campo esta vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    End If

                    MaskedTextBox1.Clear()
                    PlacaTextBox.Clear()
                    CpfTextBox.Clear()


                Else
                    MessageBox.Show("Processo cancelado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Não é possível excluir os dados porque não foi especificado qual cadastro deve ser excluído... Pesquise a placa ou cpf, clique no botão de pesquisa e em seguida exclua-os", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            MaskedTextBox1.Clear()
            PlacaTextBox.Clear()
        CpfTextBox.Clear()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.CadastroTableAdapter.Fill(ProgguaritaDataSet.cadastro)
    End Sub

    Private Sub CpfTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles CpfTextBox.MaskInputRejected

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        CadastroDataGridView.DataSource = Me.ProgguaritaDataSet.cadastro
        CadastroTableAdapter.Fill(Me.ProgguaritaDataSet.cadastro)
    End Sub

    Private Sub CadastroDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub CadastroBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CadastroBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProgguaritaDataSet)

    End Sub

    Private Sub CadastroBindingNavigator_RefreshItems(sender As Object, e As EventArgs)

    End Sub

    Private Sub CadastroDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub CadastroBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CadastroBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProgguaritaDataSet)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CadastroDataGridView_CellContentClick_2(sender As Object, e As DataGridViewCellEventArgs) Handles CadastroDataGridView.CellContentClick

    End Sub
End Class