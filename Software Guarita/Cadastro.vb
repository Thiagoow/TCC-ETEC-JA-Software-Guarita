Public Class Cadastro

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Menus.Show()
        Me.Close()

    End Sub

    Private Sub Cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProgguaritaDataSet.cadastro' table. You can move, or remove it, as needed.
        Me.CadastroTableAdapter.Fill(Me.ProgguaritaDataSet.cadastro)
        'TODO: esta linha de código carrega dados na tabela 'ProgguaritaDataSet.cadastro'. Você pode movê-la ou removê-la conforme necessário.
        Me.CadastroTableAdapter.Fill(Me.ProgguaritaDataSet.cadastro)

        If Button1.Visible = True Then
            GroupBox1.Text = "Fechar"
        ElseIf Button1.Visible = False Then
            GroupBox1.Text = "Voltar ao menu"
        End If


        PlacaTextBox.Clear()
        ModeloTextBox.Clear()
        NomeTextBox.Clear()
        CpfTextBox.Text = ""
        TipoTextBox.Text = ""
        FuncaoTextBox.Text = ""

    End Sub

    Private Sub CadastroBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CadastroBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProgguaritaDataSet)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Label4.Text = PlacaTextBox.TextLength
        TextBox1.Text = PlacaTextBox.Text

        Label5.Text = CpfTextBox.TextLength
        TextBox2.Text = CpfTextBox.Text

        TextBox3.Text = TipoTextBox.Text

        TextBox4.Text = FuncaoTextBox.Text



        PlacaTextBox.Text = PlacaTextBox.Text.ToUpper()
        ModeloTextBox.Text = ModeloTextBox.Text.ToUpper()
        NomeTextBox.Text = NomeTextBox.Text.ToUpper()
        CpfTextBox.Text = CpfTextBox.Text.ToUpper()
        TipoTextBox.Text = TipoTextBox.Text.ToUpper()
        FuncaoTextBox.Text = FuncaoTextBox.Text.ToUpper()

        If TextBox2.TextLength = 14 Then
            If TextBox1.TextLength = 8 Then
                If ModeloTextBox.TextLength <> 0 And NomeTextBox.TextLength <> 0 And TextBox3.TextLength <> 0 And TextBox4.TextLength <> 0 Then
                    If PlacaTextBox.Text = Me.CadastroTableAdapter.compara(PlacaTextBox.Text) Then
                        MessageBox.Show("Já existe um cadastro com a placa inserida! É possivel cadastrar um ou mais carros no nome de uma pessoa, mas não é possível cadastrar um carro no nome de duas.", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                    Else
                        Try
                            Me.CadastroTableAdapter.InsertQuery(PlacaTextBox.Text, ModeloTextBox.Text, NomeTextBox.Text, CpfTextBox.Text, TipoTextBox.Text, FuncaoTextBox.Text)
                            Me.CadastroTableAdapter.Fill(Me.ProgguaritaDataSet.cadastro)
                            MessageBox.Show("Usuario salvo com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                        PlacaTextBox.Clear()
                        ModeloTextBox.Clear()
                        NomeTextBox.Clear()
                        CpfTextBox.Text = ""
                        TipoTextBox.Text = ""
                        FuncaoTextBox.Text = ""
                    End If
                Else
                    MessageBox.Show("Algum campo não foi preenchido... Preencha-os para depois salvar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Faltam caracteres no campo 'Placa'! É preciso inserir 7 caracteres", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

            End If
        Else
            MessageBox.Show("Faltam caracteres no campo 'CPF'! É preciso inserir 11 caracteres", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PlacaTextBox.Clear()
        ModeloTextBox.Clear()
        NomeTextBox.Clear()
        CpfTextBox.Text = ""
        TipoTextBox.Text = ""
        FuncaoTextBox.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Consultar.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub PlacaTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles PlacaTextBox.MaskInputRejected

    End Sub
End Class