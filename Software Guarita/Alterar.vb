Public Class Alterar
    Private Sub BtnAlterar_Click(sender As Object, e As EventArgs) Handles BtnAlterar.Click
        PlacaTxt_Upt.Text = PlacaTxt_Upt.Text.ToUpper
        ModeloTxt_Upt.Text = ModeloTxt_Upt.Text.ToUpper
        NomeTxt_Upt.Text = NomeTxt_Upt.Text.ToUpper
        CpfTxt_Upt.Text = CpfTxt_Upt.Text.ToUpper
        TipoTxt_Upt.Text = TipoTxt_Upt.Text.ToUpper
        FuncaoTxt_Upt.Text = FuncaoTxt_Upt.Text.ToUpper
        If PlacaTextBox.Text = "   -" Then
            Label10.Visible = True
        Else
            Label10.Visible = False
        End If

        If CpfTextBox.Text = "   ,   ,   -" Then
            Label11.Visible = True
        Else
            Label11.Visible = False
        End If

        If ModeloTextBox.Text = "" Then
            Label12.Visible = True
        Else
            Label12.Visible = False
        End If

        If NomeTextBox.Text = "" Then
            Label13.Visible = True
        Else
            Label13.Visible = False
        End If

        If TipoComboBox.Text = "" Then
            Label14.Visible = True
        Else
            Label14.Visible = False
        End If

        If FuncaoComboBox.Text = "" Then
            Label15.Visible = True
        Else
            Label15.Visible = False
        End If

        If PlacaTxt_Upt.Text = "   -" Then
            Label16.Visible = True
        Else
            Label16.Visible = False
        End If

        If CpfTxt_Upt.Text = "   ,   ,   -" Then
            Label17.Visible = True
        Else
            Label17.Visible = False
        End If

        If ModeloTxt_Upt.Text = "" Then
            Label18.Visible = True
        Else
            Label18.Visible = False
        End If

        If NomeTxt_Upt.Text = "" Then
            Label19.Visible = True
        Else
            Label19.Visible = False
        End If

        If TipoTxt_Upt.Text = "" Then
            Label20.Visible = True
        Else
            Label20.Visible = False
        End If

        If FuncaoTxt_Upt.Text = "" Then
            Label21.Visible = True
        Else
            Label21.Visible = False
        End If


        Try

            If PlacaTxt_Upt.Text = "" Or CpfTxt_Upt.Text = "" Or PlacaTextBox.Text = "" Or CpfTextBox.Text = "" Or ModeloTextBox.Text = "" Or NomeTextBox.Text = "" Or TipoComboBox.Text = "" Or PlacaTxt_Upt.Text = "" Or CpfTxt_Upt.Text = "" Or ModeloTxt_Upt.Text = "" Or NomeTxt_Upt.Text = "" Or TipoTxt_Upt.Text = "" Or FuncaoTxt_Upt.Text = "" Then
                MessageBox.Show("Preencha os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

                Me.CadastroTableAdapter.alterar(PlacaTxt_Upt.Text, ModeloTxt_Upt.Text, NomeTxt_Upt.Text, CpfTxt_Upt.Text, TipoTxt_Upt.Text, FuncaoTxt_Upt.Text, PlacaTextBox.Text, CpfTextBox.Text)
                Me.CadastroTableAdapter.Fill(Me.ProgguaritaDataSet.cadastro)

                Me.EntradaTableAdapter.alterar(PlacaTxt_Upt.Text, ModeloTxt_Upt.Text, NomeTxt_Upt.Text, CpfTxt_Upt.Text, TipoTxt_Upt.Text, FuncaoTxt_Upt.Text, PlacaTextBox.Text, CpfTextBox.Text)
                Me.EntradaTableAdapter.Fill(Me.ProgguaritaDataSet.entrada)

                Me.SaidaTableAdapter.alterar(PlacaTxt_Upt.Text, ModeloTxt_Upt.Text, NomeTxt_Upt.Text, CpfTxt_Upt.Text, TipoTxt_Upt.Text, FuncaoTxt_Upt.Text, PlacaTextBox.Text, CpfTextBox.Text)
                Me.SaidaTableAdapter.Fill(Me.ProgguaritaDataSet.saida)
                MessageBox.Show("Cadastro alterado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try




    End Sub

    Private Sub BtnPreencher_Click(sender As Object, e As EventArgs) Handles BtnPreencher.Click
        PlacaTextBox.Text = PlacaTextBox.Text.ToUpper
        If PlacaTextBox.TextLength < 8 Then
            MessageBox.Show("Não encontrado")
        Else
            If PlacaTextBox.Text = Me.CadastroTableAdapter.compara(PlacaTextBox.Text) Then
                Try
                    If PlacaTextBox.Text = Me.CadastroTableAdapter.compara(PlacaTextBox.Text) Then
                        CpfTextBox.Text = Me.CadastroTableAdapter.PuxaCpf(PlacaTextBox.Text)
                        ModeloTextBox.Text = Me.CadastroTableAdapter.PuxaModelo(PlacaTextBox.Text)
                        NomeTextBox.Text = Me.CadastroTableAdapter.PuxaNome(PlacaTextBox.Text)
                        TipoComboBox.Text = Me.CadastroTableAdapter.PuxaTipo(PlacaTextBox.Text)
                        FuncaoComboBox.Text = Me.CadastroTableAdapter.PuxaFuncao(PlacaTextBox.Text)

                    End If
                    ModeloTextBox.Text = ModeloTextBox.Text
                    NomeTextBox.Text = NomeTextBox.Text
                    CpfTextBox.Text = CpfTextBox.Text
                    TipoComboBox.Text = TipoComboBox.Text
                    FuncaoComboBox.Text = FuncaoComboBox.Text
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MessageBox.Show("Não existe uma pessoa cadastrada com a placa inserida!")
            End If
        End If
    End Sub

    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Consultar.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PlacaTextBox.Clear()
        PlacaTxt_Upt.Clear()
        CpfTextBox.Clear()
        CpfTxt_Upt.Clear()
        ModeloTextBox.Clear()
        ModeloTxt_Upt.Clear()
        NomeTextBox.Clear()
        NomeTxt_Upt.Clear()
        TipoComboBox.Text = ""
        TipoTxt_Upt.Text = ""
        FuncaoTxt_Upt.Text = ""
        FuncaoComboBox.Text = ""



    End Sub

    Private Sub Alterar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Consultar.Close()
    End Sub

    Private Sub PlacaTxt_Upt_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles PlacaTxt_Upt.MaskInputRejected

    End Sub
End Class