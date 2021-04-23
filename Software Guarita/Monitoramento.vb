Public Class Monitoramento

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Menus.Show()
        Me.Close()
    End Sub

    Private Sub EntradaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EntradaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProgguaritaDataSet)

    End Sub

    Private Sub Monitoramento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProgguaritaDataSet.cadastro' table. You can move, or remove it, as needed.
        Me.CadastroTableAdapter.Fill(Me.ProgguaritaDataSet.cadastro)
        'TODO: This line of code loads data into the 'ProgguaritaDataSet.saida' table. You can move, or remove it, as needed.
        Me.SaidaTableAdapter.Fill(Me.ProgguaritaDataSet.saida)
        'TODO: This line of code loads data into the 'ProgguaritaDataSet.entrada' table. You can move, or remove it, as needed.
        Me.EntradaTableAdapter.Fill(Me.ProgguaritaDataSet.entrada)
        'TODO: This line of code loads data into the 'ProgguaritaDataSet.cadastro' table. You can move, or remove it, as needed.
        Me.CadastroTableAdapter.Fill(Me.ProgguaritaDataSet.cadastro)
        'TODO: This line of code loads data into the 'ProgguaritaDataSet.saida' table. You can move, or remove it, as needed.
        Me.SaidaTableAdapter.Fill(Me.ProgguaritaDataSet.saida)
        'TODO: This line of code loads data into the 'ProgguaritaDataSet.entrada' table. You can move, or remove it, as needed.
        Me.EntradaTableAdapter.Fill(Me.ProgguaritaDataSet.entrada)

        Timer1.Start()
        DataL.Text = Today

    End Sub

    Private Sub PlacaLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = PlacaTextBox.Text

        PlacaTextBox.Text = PlacaTextBox.Text.ToUpper()

        If TextBox1.TextLength < 8 Then
            MessageBox.Show("Não é possivel salvar o campo 'Placa' com tamanho menor que 7, ou, vazio")
        Else
            If PlacaTextBox.Text = Me.CadastroTableAdapter.compara(PlacaTextBox.Text) Then
                Try
                    If PlacaTextBox.TextLength = 0 Or ModeloTextBox.TextLength = 0 Or NomeTextBox.TextLength = 0 Or CpfTextBox.TextLength = 0 Or TipoTextBox.TextLength = 0 Or FuncaoTextBox.TextLength = 0 Or HoraTextBox.TextLength = 0 Or DataTextBox.TextLength = 0 Then
                        MessageBox.Show("Algum campo não foi preenchido... Preencha-o primeiro para depois salvar")

                    Else
                        If PlacaTextBox.Text = Me.CadastroTableAdapter.compara(PlacaTextBox.Text) Then
                            Me.EntradaTableAdapter.InsertQuery(PlacaTextBox.Text, ModeloTextBox.Text, NomeTextBox.Text, CpfTextBox.Text, TipoTextBox.Text, FuncaoTextBox.Text, DataTextBox.Text, HoraTextBox.Text)
                            Me.EntradaTableAdapter.Fill(Me.ProgguaritaDataSet.entrada)
                            MessageBox.Show("Usuario salvo com sucesso")
                            PlacaTextBox.Clear()
                            ModeloTextBox.Clear()
                            NomeTextBox.Clear()
                            CpfTextBox.Clear()
                            TipoTextBox.Clear()
                            FuncaoTextBox.Clear()
                            HoraTextBox.Clear()
                            DataTextBox.Clear()
                            ModeloL.Text = ""
                            NomeL.Text = ""
                            CpfL.Text = ""
                            TipoL.Text = ""
                            FuncaoL.Text = ""
                            HoraL.Text = ""
                            DataL.Text = ""
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MessageBox.Show("Não existe uma pessoa cadastrada com a placa inserida!")
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = PlacaTextBox.Text

        PlacaTextBox.Text = PlacaTextBox.Text.ToUpper()

        If TextBox1.TextLength < 8 Then
            MessageBox.Show("Não é possivel salvar o campo 'CPF' com tamanho menor que 11, ou, vazio")
        Else
            If PlacaTextBox.Text = Me.CadastroTableAdapter.compara(PlacaTextBox.Text) Then
                Try
                    If PlacaTextBox.TextLength = 0 Or ModeloTextBox.TextLength = 0 Or NomeTextBox.TextLength = 0 Or CpfTextBox.TextLength = 0 Or TipoTextBox.TextLength = 0 Or FuncaoTextBox.TextLength = 0 Or HoraTextBox.TextLength = 0 Or DataTextBox.TextLength = 0 Then
                        MessageBox.Show("Não é possível salvar os campos vazios... Preencha-os primeiro para depois salvar")

                    Else

                        If PlacaTextBox.Text = Me.CadastroTableAdapter.compara(PlacaTextBox.Text) Then
                            Me.SaidaTableAdapter.InsertQuery(PlacaTextBox.Text, ModeloTextBox.Text, NomeTextBox.Text, CpfTextBox.Text, TipoTextBox.Text, FuncaoTextBox.Text, DataTextBox.Text, HoraTextBox.Text)
                            Me.SaidaTableAdapter.Fill(Me.ProgguaritaDataSet.saida)
                            MessageBox.Show("Usuario salvo com sucesso")
                            PlacaTextBox.Clear()
                            ModeloTextBox.Clear()
                            NomeTextBox.Clear()
                            CpfTextBox.Clear()
                            TipoTextBox.Clear()
                            FuncaoTextBox.Clear()
                            HoraTextBox.Clear()
                            DataTextBox.Clear()
                            ModeloL.Text = ""
                            NomeL.Text = ""
                            CpfL.Text = ""
                            TipoL.Text = ""
                            FuncaoL.Text = ""
                            HoraL.Text = ""
                            DataL.Text = ""
                        End If

                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MessageBox.Show("Não existe uma pessoa cadastrada com o CPF inserido!")
            End If
        End If
    End Sub

    Private Sub HoraL_Click(sender As Object, e As EventArgs) Handles HoraL.Click, Timer1.Tick
        HoraL.Text = DateTime.Now.ToLongTimeString()
    End Sub

    Private Sub DataL_Click(sender As Object, e As EventArgs) Handles DataL.Click, Timer1.Tick
        DataL.Text = Today
    End Sub

    Private Sub PlacaTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If PlacaTextBox.TextLength < 1 Then
            MessageBox.Show("Não é possivel salvar a placa com tamanho menor que 8, ou, vazio")
        Else
            If PlacaTextBox.Text = Me.CadastroTableAdapter.compara(PlacaTextBox.Text) Then
                Try
                    If PlacaTextBox.Text = Me.CadastroTableAdapter.compara(PlacaTextBox.Text) Then
                        CpfL.Text = Me.CadastroTableAdapter.PuxaCpf(PlacaTextBox.Text)
                        ModeloL.Text = Me.CadastroTableAdapter.PuxaModelo(PlacaTextBox.Text)
                        TipoL.Text = Me.CadastroTableAdapter.PuxaNome(PlacaTextBox.Text)
                        TipoL.Text = Me.CadastroTableAdapter.PuxaTipo(PlacaTextBox.Text)
                        FuncaoL.Text = Me.CadastroTableAdapter.PuxaFuncao(PlacaTextBox.Text)
                    End If
                    ModeloTextBox.Text = ModeloL.Text
                    NomeTextBox.Text = NomeL.Text
                    CpfTextBox.Text = CpfL.Text
                    TipoTextBox.Text = TipoL.Text
                    FuncaoTextBox.Text = FuncaoL.Text
                    HoraTextBox.Text = HoraL.Text
                    DataTextBox.Text = DataL.Text

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MessageBox.Show("Não existe uma pessoa cadastrada com a placa inserida!")
            End If
        End If
    End Sub

    Public Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = PlacaTextBox.Text

        PlacaTextBox.Text = PlacaTextBox.Text.ToUpper()

        If TextBox1.TextLength < 8 Then
            MessageBox.Show("Não é possivel salvar a placa com tamanho menor que 8, ou, vazio")
        Else
            If PlacaTextBox.Text = Me.CadastroTableAdapter.compara(PlacaTextBox.Text) Then
                Try
                    If PlacaTextBox.Text = Me.CadastroTableAdapter.compara(PlacaTextBox.Text) Then
                        CpfL.Text = Me.CadastroTableAdapter.PuxaCpf(PlacaTextBox.Text)
                        ModeloL.Text = Me.CadastroTableAdapter.PuxaModelo(PlacaTextBox.Text)
                        NomeL.Text = Me.CadastroTableAdapter.PuxaNome(PlacaTextBox.Text)
                        TipoL.Text = Me.CadastroTableAdapter.PuxaTipo(PlacaTextBox.Text)
                        FuncaoL.Text = Me.CadastroTableAdapter.PuxaFuncao(PlacaTextBox.Text)
                    End If
                    ModeloTextBox.Text = ModeloL.Text
                    NomeTextBox.Text = NomeL.Text
                    CpfTextBox.Text = CpfL.Text
                    TipoTextBox.Text = TipoL.Text
                    FuncaoTextBox.Text = FuncaoL.Text
                    HoraTextBox.Text = HoraL.Text
                    DataTextBox.Text = DataL.Text

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MessageBox.Show("Não existe uma pessoa cadastrada com a placa inserida!")
            End If
        End If
    End Sub

    Private Sub PlacaTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles PlacaTextBox.MaskInputRejected

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Cadastro.Button3.Visible = False
        Cadastro.Button1.Visible = True
        Cadastro.Show()

    End Sub
End Class