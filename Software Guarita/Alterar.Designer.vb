<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alterar
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim PlacaLabel_Upt As System.Windows.Forms.Label
        Dim ModeloLabel_Upt As System.Windows.Forms.Label
        Dim NomeLabel_Upt As System.Windows.Forms.Label
        Dim CpfLabel_Upt As System.Windows.Forms.Label
        Dim TipoLabel_Upt As System.Windows.Forms.Label
        Dim FuncaoLabel_Upt As System.Windows.Forms.Label
        Dim PlacaLabel As System.Windows.Forms.Label
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim CpfLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim FuncaoLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alterar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CpfTxt_Upt = New System.Windows.Forms.MaskedTextBox()
        Me.PlacaTxt_Upt = New System.Windows.Forms.MaskedTextBox()
        Me.ModeloTxt_Upt = New System.Windows.Forms.TextBox()
        Me.NomeTxt_Upt = New System.Windows.Forms.TextBox()
        Me.TipoTxt_Upt = New System.Windows.Forms.ComboBox()
        Me.FuncaoTxt_Upt = New System.Windows.Forms.ComboBox()
        Me.BtnPreencher = New System.Windows.Forms.Button()
        Me.CpfTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PlacaTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.TipoComboBox = New System.Windows.Forms.ComboBox()
        Me.FuncaoComboBox = New System.Windows.Forms.ComboBox()
        Me.BtnAlterar = New System.Windows.Forms.Button()
        Me.CadastroTableAdapter = New Software_Guarita.progguaritaDataSetTableAdapters.cadastroTableAdapter()
        Me.ProgguaritaDataSet = New Software_Guarita.progguaritaDataSet()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.EntradaTableAdapter = New Software_Guarita.progguaritaDataSetTableAdapters.entradaTableAdapter()
        Me.SaidaTableAdapter = New Software_Guarita.progguaritaDataSetTableAdapters.saidaTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        PlacaLabel_Upt = New System.Windows.Forms.Label()
        ModeloLabel_Upt = New System.Windows.Forms.Label()
        NomeLabel_Upt = New System.Windows.Forms.Label()
        CpfLabel_Upt = New System.Windows.Forms.Label()
        TipoLabel_Upt = New System.Windows.Forms.Label()
        FuncaoLabel_Upt = New System.Windows.Forms.Label()
        PlacaLabel = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        CpfLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        FuncaoLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        CType(Me.ProgguaritaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PlacaLabel_Upt
        '
        PlacaLabel_Upt.AutoSize = True
        PlacaLabel_Upt.BackColor = System.Drawing.Color.Transparent
        PlacaLabel_Upt.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PlacaLabel_Upt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        PlacaLabel_Upt.Location = New System.Drawing.Point(420, 101)
        PlacaLabel_Upt.Name = "PlacaLabel_Upt"
        PlacaLabel_Upt.Size = New System.Drawing.Size(95, 29)
        PlacaLabel_Upt.TabIndex = 97
        PlacaLabel_Upt.Text = "Placa:"
        '
        'ModeloLabel_Upt
        '
        ModeloLabel_Upt.AutoSize = True
        ModeloLabel_Upt.BackColor = System.Drawing.Color.Transparent
        ModeloLabel_Upt.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ModeloLabel_Upt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        ModeloLabel_Upt.Location = New System.Drawing.Point(419, 257)
        ModeloLabel_Upt.Name = "ModeloLabel_Upt"
        ModeloLabel_Upt.Size = New System.Drawing.Size(119, 29)
        ModeloLabel_Upt.TabIndex = 98
        ModeloLabel_Upt.Text = "Modelo:"
        '
        'NomeLabel_Upt
        '
        NomeLabel_Upt.AutoSize = True
        NomeLabel_Upt.BackColor = System.Drawing.Color.Transparent
        NomeLabel_Upt.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel_Upt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        NomeLabel_Upt.Location = New System.Drawing.Point(419, 335)
        NomeLabel_Upt.Name = "NomeLabel_Upt"
        NomeLabel_Upt.Size = New System.Drawing.Size(100, 29)
        NomeLabel_Upt.TabIndex = 100
        NomeLabel_Upt.Text = "Nome:"
        '
        'CpfLabel_Upt
        '
        CpfLabel_Upt.AutoSize = True
        CpfLabel_Upt.BackColor = System.Drawing.Color.Transparent
        CpfLabel_Upt.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CpfLabel_Upt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        CpfLabel_Upt.Location = New System.Drawing.Point(420, 179)
        CpfLabel_Upt.Name = "CpfLabel_Upt"
        CpfLabel_Upt.Size = New System.Drawing.Size(74, 29)
        CpfLabel_Upt.TabIndex = 102
        CpfLabel_Upt.Text = "CPF:"
        '
        'TipoLabel_Upt
        '
        TipoLabel_Upt.AutoSize = True
        TipoLabel_Upt.BackColor = System.Drawing.Color.Transparent
        TipoLabel_Upt.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoLabel_Upt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        TipoLabel_Upt.Location = New System.Drawing.Point(420, 413)
        TipoLabel_Upt.Name = "TipoLabel_Upt"
        TipoLabel_Upt.Size = New System.Drawing.Size(120, 29)
        TipoLabel_Upt.TabIndex = 103
        TipoLabel_Upt.Text = "Veículo:"
        '
        'FuncaoLabel_Upt
        '
        FuncaoLabel_Upt.AutoSize = True
        FuncaoLabel_Upt.BackColor = System.Drawing.Color.Transparent
        FuncaoLabel_Upt.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FuncaoLabel_Upt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        FuncaoLabel_Upt.Location = New System.Drawing.Point(420, 491)
        FuncaoLabel_Upt.Name = "FuncaoLabel_Upt"
        FuncaoLabel_Upt.Size = New System.Drawing.Size(119, 29)
        FuncaoLabel_Upt.TabIndex = 105
        FuncaoLabel_Upt.Text = "Função:"
        '
        'PlacaLabel
        '
        PlacaLabel.AutoSize = True
        PlacaLabel.BackColor = System.Drawing.Color.Transparent
        PlacaLabel.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PlacaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        PlacaLabel.Location = New System.Drawing.Point(19, 101)
        PlacaLabel.Name = "PlacaLabel"
        PlacaLabel.Size = New System.Drawing.Size(95, 29)
        PlacaLabel.TabIndex = 84
        PlacaLabel.Text = "Placa:"
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.BackColor = System.Drawing.Color.Transparent
        ModeloLabel.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ModeloLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        ModeloLabel.Location = New System.Drawing.Point(20, 257)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(119, 29)
        ModeloLabel.TabIndex = 85
        ModeloLabel.Text = "Modelo:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.BackColor = System.Drawing.Color.Transparent
        NomeLabel.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        NomeLabel.Location = New System.Drawing.Point(20, 335)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(100, 29)
        NomeLabel.TabIndex = 87
        NomeLabel.Text = "Nome:"
        '
        'CpfLabel
        '
        CpfLabel.AutoSize = True
        CpfLabel.BackColor = System.Drawing.Color.Transparent
        CpfLabel.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CpfLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        CpfLabel.Location = New System.Drawing.Point(19, 179)
        CpfLabel.Name = "CpfLabel"
        CpfLabel.Size = New System.Drawing.Size(74, 29)
        CpfLabel.TabIndex = 89
        CpfLabel.Text = "CPF:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.BackColor = System.Drawing.Color.Transparent
        TipoLabel.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        TipoLabel.Location = New System.Drawing.Point(19, 413)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(120, 29)
        TipoLabel.TabIndex = 90
        TipoLabel.Text = "Veículo:"
        '
        'FuncaoLabel
        '
        FuncaoLabel.AutoSize = True
        FuncaoLabel.BackColor = System.Drawing.Color.Transparent
        FuncaoLabel.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FuncaoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        FuncaoLabel.Location = New System.Drawing.Point(19, 491)
        FuncaoLabel.Name = "FuncaoLabel"
        FuncaoLabel.Size = New System.Drawing.Size(119, 29)
        FuncaoLabel.TabIndex = 92
        FuncaoLabel.Text = "Função:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.Transparent
        Label6.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Italic)
        Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label6.Location = New System.Drawing.Point(548, 271)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(56, 17)
        Label6.TabIndex = 131
        Label6.Text = "(Novo)"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Italic)
        Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label4.Location = New System.Drawing.Point(519, 116)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(56, 17)
        Label4.TabIndex = 132
        Label4.Text = "(Novo)"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.Color.Transparent
        Label5.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Italic)
        Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label5.Location = New System.Drawing.Point(499, 193)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(56, 17)
        Label5.TabIndex = 133
        Label5.Text = "(Novo)"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.BackColor = System.Drawing.Color.Transparent
        Label7.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Italic)
        Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label7.Location = New System.Drawing.Point(534, 349)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(56, 17)
        Label7.TabIndex = 134
        Label7.Text = "(Novo)"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.BackColor = System.Drawing.Color.Transparent
        Label8.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Italic)
        Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label8.Location = New System.Drawing.Point(548, 427)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(56, 17)
        Label8.TabIndex = 135
        Label8.Text = "(Novo)"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.BackColor = System.Drawing.Color.Transparent
        Label9.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Italic)
        Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label9.Location = New System.Drawing.Point(548, 505)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(56, 17)
        Label9.TabIndex = 136
        Label9.Text = "(Novo)"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 26.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(28, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 43)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Software Guaritas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(567, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 42)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Alterar"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(397, -21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 85)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "_____"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CpfTxt_Upt
        '
        Me.CpfTxt_Upt.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CpfTxt_Upt.Location = New System.Drawing.Point(426, 214)
        Me.CpfTxt_Upt.Mask = "AAA.AAA.AAA-AA"
        Me.CpfTxt_Upt.MinimumSize = New System.Drawing.Size(272, 40)
        Me.CpfTxt_Upt.Name = "CpfTxt_Upt"
        Me.CpfTxt_Upt.Size = New System.Drawing.Size(321, 37)
        Me.CpfTxt_Upt.TabIndex = 4
        Me.CpfTxt_Upt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PlacaTxt_Upt
        '
        Me.PlacaTxt_Upt.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlacaTxt_Upt.Location = New System.Drawing.Point(426, 136)
        Me.PlacaTxt_Upt.Mask = "AAA-AAAA"
        Me.PlacaTxt_Upt.MinimumSize = New System.Drawing.Size(200, 32)
        Me.PlacaTxt_Upt.Name = "PlacaTxt_Upt"
        Me.PlacaTxt_Upt.Size = New System.Drawing.Size(321, 37)
        Me.PlacaTxt_Upt.TabIndex = 3
        Me.PlacaTxt_Upt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ModeloTxt_Upt
        '
        Me.ModeloTxt_Upt.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModeloTxt_Upt.Location = New System.Drawing.Point(425, 292)
        Me.ModeloTxt_Upt.Multiline = True
        Me.ModeloTxt_Upt.Name = "ModeloTxt_Upt"
        Me.ModeloTxt_Upt.Size = New System.Drawing.Size(321, 40)
        Me.ModeloTxt_Upt.TabIndex = 5
        '
        'NomeTxt_Upt
        '
        Me.NomeTxt_Upt.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeTxt_Upt.Location = New System.Drawing.Point(425, 370)
        Me.NomeTxt_Upt.Multiline = True
        Me.NomeTxt_Upt.Name = "NomeTxt_Upt"
        Me.NomeTxt_Upt.Size = New System.Drawing.Size(321, 40)
        Me.NomeTxt_Upt.TabIndex = 6
        '
        'TipoTxt_Upt
        '
        Me.TipoTxt_Upt.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoTxt_Upt.ForeColor = System.Drawing.Color.Black
        Me.TipoTxt_Upt.Items.AddRange(New Object() {"Carro", "Moto", "Van"})
        Me.TipoTxt_Upt.Location = New System.Drawing.Point(426, 448)
        Me.TipoTxt_Upt.Name = "TipoTxt_Upt"
        Me.TipoTxt_Upt.Size = New System.Drawing.Size(321, 37)
        Me.TipoTxt_Upt.TabIndex = 7
        '
        'FuncaoTxt_Upt
        '
        Me.FuncaoTxt_Upt.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FuncaoTxt_Upt.ForeColor = System.Drawing.Color.Black
        Me.FuncaoTxt_Upt.Items.AddRange(New Object() {"Aluno", "Professor", "Funcionário Terceirizado", "Funcionário de Gestão"})
        Me.FuncaoTxt_Upt.Location = New System.Drawing.Point(426, 526)
        Me.FuncaoTxt_Upt.Name = "FuncaoTxt_Upt"
        Me.FuncaoTxt_Upt.Size = New System.Drawing.Size(321, 37)
        Me.FuncaoTxt_Upt.TabIndex = 8
        '
        'BtnPreencher
        '
        Me.BtnPreencher.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPreencher.BackgroundImage = Global.Software_Guarita.My.Resources.Resources.search
        Me.BtnPreencher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPreencher.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BtnPreencher.FlatAppearance.BorderSize = 3
        Me.BtnPreencher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnPreencher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnPreencher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPreencher.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPreencher.Location = New System.Drawing.Point(305, 136)
        Me.BtnPreencher.Name = "BtnPreencher"
        Me.BtnPreencher.Size = New System.Drawing.Size(41, 40)
        Me.BtnPreencher.TabIndex = 2
        Me.BtnPreencher.UseVisualStyleBackColor = False
        '
        'CpfTextBox
        '
        Me.CpfTextBox.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CpfTextBox.Location = New System.Drawing.Point(25, 214)
        Me.CpfTextBox.Mask = "AAA.AAA.AAA-AA"
        Me.CpfTextBox.MinimumSize = New System.Drawing.Size(272, 40)
        Me.CpfTextBox.Name = "CpfTextBox"
        Me.CpfTextBox.Size = New System.Drawing.Size(321, 37)
        Me.CpfTextBox.TabIndex = 95
        Me.CpfTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PlacaTextBox
        '
        Me.PlacaTextBox.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlacaTextBox.Location = New System.Drawing.Point(25, 136)
        Me.PlacaTextBox.Mask = "AAA-AAAA"
        Me.PlacaTextBox.MinimumSize = New System.Drawing.Size(200, 32)
        Me.PlacaTextBox.Name = "PlacaTextBox"
        Me.PlacaTextBox.Size = New System.Drawing.Size(274, 37)
        Me.PlacaTextBox.TabIndex = 1
        Me.PlacaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModeloTextBox.Location = New System.Drawing.Point(26, 292)
        Me.ModeloTextBox.Multiline = True
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(321, 40)
        Me.ModeloTextBox.TabIndex = 86
        '
        'NomeTextBox
        '
        Me.NomeTextBox.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeTextBox.Location = New System.Drawing.Point(26, 370)
        Me.NomeTextBox.Multiline = True
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(321, 40)
        Me.NomeTextBox.TabIndex = 88
        '
        'TipoComboBox
        '
        Me.TipoComboBox.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoComboBox.ForeColor = System.Drawing.Color.Black
        Me.TipoComboBox.Items.AddRange(New Object() {"Carro", "Moto", "Van"})
        Me.TipoComboBox.Location = New System.Drawing.Point(25, 448)
        Me.TipoComboBox.Name = "TipoComboBox"
        Me.TipoComboBox.Size = New System.Drawing.Size(321, 37)
        Me.TipoComboBox.TabIndex = 91
        '
        'FuncaoComboBox
        '
        Me.FuncaoComboBox.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FuncaoComboBox.ForeColor = System.Drawing.Color.Black
        Me.FuncaoComboBox.Items.AddRange(New Object() {"Aluno", "Professor", "Funcionário Terceirizado", "Funcionário de Gestão"})
        Me.FuncaoComboBox.Location = New System.Drawing.Point(25, 526)
        Me.FuncaoComboBox.Name = "FuncaoComboBox"
        Me.FuncaoComboBox.Size = New System.Drawing.Size(321, 37)
        Me.FuncaoComboBox.TabIndex = 93
        '
        'BtnAlterar
        '
        Me.BtnAlterar.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.BtnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.BtnAlterar.FlatAppearance.BorderSize = 2
        Me.BtnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.BtnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chartreuse
        Me.BtnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAlterar.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlterar.Location = New System.Drawing.Point(545, 605)
        Me.BtnAlterar.Name = "BtnAlterar"
        Me.BtnAlterar.Size = New System.Drawing.Size(201, 54)
        Me.BtnAlterar.TabIndex = 10
        Me.BtnAlterar.Text = "SALVAR"
        Me.BtnAlterar.UseVisualStyleBackColor = False
        '
        'CadastroTableAdapter
        '
        Me.CadastroTableAdapter.ClearBeforeFill = True
        '
        'ProgguaritaDataSet
        '
        Me.ProgguaritaDataSet.DataSetName = "progguaritaDataSet"
        Me.ProgguaritaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Yellow
        Me.Label10.Location = New System.Drawing.Point(196, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 17)
        Me.Label10.TabIndex = 137
        Me.Label10.Text = "campo obrigatório*"
        Me.Label10.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Yellow
        Me.Label11.Location = New System.Drawing.Point(196, 257)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(150, 17)
        Me.Label11.TabIndex = 138
        Me.Label11.Text = "campo obrigatório*"
        Me.Label11.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(196, 335)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(150, 17)
        Me.Label12.TabIndex = 139
        Me.Label12.Text = "campo obrigatório*"
        Me.Label12.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(197, 413)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(150, 17)
        Me.Label13.TabIndex = 140
        Me.Label13.Text = "campo obrigatório*"
        Me.Label13.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Yellow
        Me.Label14.Location = New System.Drawing.Point(196, 491)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(150, 17)
        Me.Label14.TabIndex = 141
        Me.Label14.Text = "campo obrigatório*"
        Me.Label14.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Yellow
        Me.Label15.Location = New System.Drawing.Point(197, 569)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(150, 17)
        Me.Label15.TabIndex = 142
        Me.Label15.Text = "campo obrigatório*"
        Me.Label15.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Yellow
        Me.Label16.Location = New System.Drawing.Point(597, 179)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(150, 17)
        Me.Label16.TabIndex = 143
        Me.Label16.Text = "campo obrigatório*"
        Me.Label16.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Yellow
        Me.Label17.Location = New System.Drawing.Point(597, 257)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(150, 17)
        Me.Label17.TabIndex = 144
        Me.Label17.Text = "campo obrigatório*"
        Me.Label17.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Yellow
        Me.Label18.Location = New System.Drawing.Point(597, 335)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(150, 17)
        Me.Label18.TabIndex = 145
        Me.Label18.Text = "campo obrigatório*"
        Me.Label18.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Yellow
        Me.Label19.Location = New System.Drawing.Point(597, 413)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(150, 17)
        Me.Label19.TabIndex = 146
        Me.Label19.Text = "campo obrigatório*"
        Me.Label19.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Yellow
        Me.Label20.Location = New System.Drawing.Point(597, 491)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(150, 17)
        Me.Label20.TabIndex = 147
        Me.Label20.Text = "campo obrigatório*"
        Me.Label20.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Yellow
        Me.Label21.Location = New System.Drawing.Point(597, 569)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(150, 17)
        Me.Label21.TabIndex = 148
        Me.Label21.Text = "campo obrigatório*"
        Me.Label21.Visible = False
        '
        'EntradaTableAdapter
        '
        Me.EntradaTableAdapter.ClearBeforeFill = True
        '
        'SaidaTableAdapter
        '
        Me.SaidaTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Crimson
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(545, 665)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 54)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "LIMPAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(12, 619)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox3.Size = New System.Drawing.Size(192, 100)
        Me.GroupBox3.TabIndex = 150
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Retornar a Consulta"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Software_Guarita.My.Resources.Resources.iconfinder_icon_62_document_table_314520
        Me.Button2.Location = New System.Drawing.Point(6, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 69)
        Me.Button2.TabIndex = 12
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Alterar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Software_Guarita.My.Resources.Resources.textura2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(776, 732)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.BtnAlterar)
        Me.Controls.Add(Me.CpfTxt_Upt)
        Me.Controls.Add(Me.PlacaTxt_Upt)
        Me.Controls.Add(PlacaLabel_Upt)
        Me.Controls.Add(ModeloLabel_Upt)
        Me.Controls.Add(Me.ModeloTxt_Upt)
        Me.Controls.Add(NomeLabel_Upt)
        Me.Controls.Add(Me.NomeTxt_Upt)
        Me.Controls.Add(CpfLabel_Upt)
        Me.Controls.Add(TipoLabel_Upt)
        Me.Controls.Add(Me.TipoTxt_Upt)
        Me.Controls.Add(FuncaoLabel_Upt)
        Me.Controls.Add(Me.FuncaoTxt_Upt)
        Me.Controls.Add(Me.BtnPreencher)
        Me.Controls.Add(Me.CpfTextBox)
        Me.Controls.Add(Me.PlacaTextBox)
        Me.Controls.Add(PlacaLabel)
        Me.Controls.Add(ModeloLabel)
        Me.Controls.Add(Me.ModeloTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(CpfLabel)
        Me.Controls.Add(TipoLabel)
        Me.Controls.Add(Me.TipoComboBox)
        Me.Controls.Add(FuncaoLabel)
        Me.Controls.Add(Me.FuncaoComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Alterar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ALTERAR"
        CType(Me.ProgguaritaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CpfTxt_Upt As MaskedTextBox
    Friend WithEvents PlacaTxt_Upt As MaskedTextBox
    Friend WithEvents ModeloTxt_Upt As TextBox
    Friend WithEvents NomeTxt_Upt As TextBox
    Friend WithEvents TipoTxt_Upt As ComboBox
    Friend WithEvents FuncaoTxt_Upt As ComboBox
    Friend WithEvents BtnPreencher As Button
    Friend WithEvents CpfTextBox As MaskedTextBox
    Friend WithEvents PlacaTextBox As MaskedTextBox
    Friend WithEvents ModeloTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents TipoComboBox As ComboBox
    Friend WithEvents FuncaoComboBox As ComboBox
    Friend WithEvents BtnAlterar As Button
    Friend WithEvents CadastroTableAdapter As progguaritaDataSetTableAdapters.cadastroTableAdapter
    Friend WithEvents ProgguaritaDataSet As progguaritaDataSet
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents EntradaTableAdapter As Software_Guarita.progguaritaDataSetTableAdapters.entradaTableAdapter
    Friend WithEvents SaidaTableAdapter As Software_Guarita.progguaritaDataSetTableAdapters.saidaTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
