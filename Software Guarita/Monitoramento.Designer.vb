<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Monitoramento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim PlacaLabel As System.Windows.Forms.Label
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim CpfLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim FuncaoLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim HoraLabel As System.Windows.Forms.Label
        Dim CodigoDaEntradaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Monitoramento))
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EntradaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProgguaritaDataSet = New Software_Guarita.progguaritaDataSet()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.CpfTextBox = New System.Windows.Forms.TextBox()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.FuncaoTextBox = New System.Windows.Forms.TextBox()
        Me.DataTextBox = New System.Windows.Forms.TextBox()
        Me.HoraTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoDaEntradaTextBox = New System.Windows.Forms.TextBox()
        Me.SaidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CadastroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CpfL = New System.Windows.Forms.Label()
        Me.HoraL = New System.Windows.Forms.Label()
        Me.DataL = New System.Windows.Forms.Label()
        Me.FuncaoL = New System.Windows.Forms.Label()
        Me.ModeloL = New System.Windows.Forms.Label()
        Me.TipoL = New System.Windows.Forms.Label()
        Me.NomeL = New System.Windows.Forms.Label()
        Me.EntradaTableAdapter = New Software_Guarita.progguaritaDataSetTableAdapters.entradaTableAdapter()
        Me.TableAdapterManager = New Software_Guarita.progguaritaDataSetTableAdapters.TableAdapterManager()
        Me.CadastroTableAdapter = New Software_Guarita.progguaritaDataSetTableAdapters.cadastroTableAdapter()
        Me.SaidaTableAdapter = New Software_Guarita.progguaritaDataSetTableAdapters.saidaTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PlacaTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        PlacaLabel = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        CpfLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        FuncaoLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        HoraLabel = New System.Windows.Forms.Label()
        CodigoDaEntradaLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout
        CType(Me.EntradaBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ProgguaritaDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SaidaBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CadastroBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox2.SuspendLayout
        Me.SuspendLayout
        '
        'PlacaLabel
        '
        PlacaLabel.AutoSize = true
        PlacaLabel.BackColor = System.Drawing.Color.Transparent
        PlacaLabel.Font = New System.Drawing.Font("Verdana", 20!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
        PlacaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        PlacaLabel.Location = New System.Drawing.Point(50, 175)
        PlacaLabel.Name = "PlacaLabel"
        PlacaLabel.Size = New System.Drawing.Size(107, 32)
        PlacaLabel.TabIndex = 0
        PlacaLabel.Text = "Placa:"
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = true
        ModeloLabel.BackColor = System.Drawing.Color.Transparent
        ModeloLabel.Font = New System.Drawing.Font("Verdana", 20!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
        ModeloLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        ModeloLabel.Location = New System.Drawing.Point(22, 227)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(136, 32)
        ModeloLabel.TabIndex = 0
        ModeloLabel.Text = "Modelo:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = true
        NomeLabel.BackColor = System.Drawing.Color.Transparent
        NomeLabel.Font = New System.Drawing.Font("Verdana", 20!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
        NomeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        NomeLabel.Location = New System.Drawing.Point(42, 280)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(115, 32)
        NomeLabel.TabIndex = 0
        NomeLabel.Text = "Nome:"
        '
        'CpfLabel
        '
        CpfLabel.AutoSize = true
        CpfLabel.BackColor = System.Drawing.Color.Transparent
        CpfLabel.Font = New System.Drawing.Font("Verdana", 20!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
        CpfLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        CpfLabel.Location = New System.Drawing.Point(73, 333)
        CpfLabel.Name = "CpfLabel"
        CpfLabel.Size = New System.Drawing.Size(84, 32)
        CpfLabel.TabIndex = 0
        CpfLabel.Text = "CPF:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = true
        TipoLabel.BackColor = System.Drawing.Color.Transparent
        TipoLabel.Font = New System.Drawing.Font("Verdana", 20!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
        TipoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        TipoLabel.Location = New System.Drawing.Point(66, 385)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(91, 32)
        TipoLabel.TabIndex = 0
        TipoLabel.Text = "Tipo:"
        '
        'FuncaoLabel
        '
        FuncaoLabel.AutoSize = true
        FuncaoLabel.BackColor = System.Drawing.Color.Transparent
        FuncaoLabel.Font = New System.Drawing.Font("Verdana", 20!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
        FuncaoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        FuncaoLabel.Location = New System.Drawing.Point(22, 434)
        FuncaoLabel.Name = "FuncaoLabel"
        FuncaoLabel.Size = New System.Drawing.Size(135, 32)
        FuncaoLabel.TabIndex = 0
        FuncaoLabel.Text = "Funcao:"
        '
        'DataLabel
        '
        DataLabel.AutoSize = true
        DataLabel.BackColor = System.Drawing.Color.Transparent
        DataLabel.Font = New System.Drawing.Font("Verdana", 20!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
        DataLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataLabel.Location = New System.Drawing.Point(61, 486)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(96, 32)
        DataLabel.TabIndex = 0
        DataLabel.Text = "Data:"
        '
        'HoraLabel
        '
        HoraLabel.AutoSize = true
        HoraLabel.BackColor = System.Drawing.Color.Transparent
        HoraLabel.Font = New System.Drawing.Font("Verdana", 20!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
        HoraLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        HoraLabel.Location = New System.Drawing.Point(58, 535)
        HoraLabel.Name = "HoraLabel"
        HoraLabel.Size = New System.Drawing.Size(99, 32)
        HoraLabel.TabIndex = 0
        HoraLabel.Text = "Hora:"
        '
        'CodigoDaEntradaLabel
        '
        CodigoDaEntradaLabel.BackColor = System.Drawing.Color.Transparent
        CodigoDaEntradaLabel.Font = New System.Drawing.Font("Verdana", 20!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
        CodigoDaEntradaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        CodigoDaEntradaLabel.Location = New System.Drawing.Point(370, 572)
        CodigoDaEntradaLabel.Name = "CodigoDaEntradaLabel"
        CodigoDaEntradaLabel.Size = New System.Drawing.Size(0, 0)
        CodigoDaEntradaLabel.TabIndex = 0
        CodigoDaEntradaLabel.Text = "Codigo:"
        CodigoDaEntradaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.PaleGreen
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.Button5.FlatAppearance.BorderSize = 2
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chartreuse
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button5.Location = New System.Drawing.Point(339, 627)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(168, 52)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "ENTROU!"
        Me.Button5.UseVisualStyleBackColor = false
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MistyRose
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button2.Location = New System.Drawing.Point(339, 685)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(168, 52)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "SAIU!"
        Me.Button2.UseVisualStyleBackColor = false
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(23, 637)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(137, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Voltar ao menu"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Lucida Sans", 48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button3.Image = Global.Software_Guarita.My.Resources.Resources.Voltar
        Me.Button3.Location = New System.Drawing.Point(6, 26)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 65)
        Me.Button3.TabIndex = 5
        Me.Button3.UseVisualStyleBackColor = false
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 36!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(514, 71)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Software Guaritas"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(89, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(324, 48)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Monitoramento"
        '
        'EntradaBindingSource
        '
        Me.EntradaBindingSource.DataMember = "entrada"
        Me.EntradaBindingSource.DataSource = Me.ProgguaritaDataSet
        '
        'ProgguaritaDataSet
        '
        Me.ProgguaritaDataSet.DataSetName = "progguaritaDataSet"
        Me.ProgguaritaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EntradaBindingSource, "modelo", true))
        Me.ModeloTextBox.Location = New System.Drawing.Point(155, 227)
        Me.ModeloTextBox.Multiline = true
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(339, 32)
        Me.ModeloTextBox.TabIndex = 0
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EntradaBindingSource, "nome", true))
        Me.NomeTextBox.Location = New System.Drawing.Point(155, 280)
        Me.NomeTextBox.Multiline = true
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(339, 32)
        Me.NomeTextBox.TabIndex = 0
        '
        'CpfTextBox
        '
        Me.CpfTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EntradaBindingSource, "cpf", true))
        Me.CpfTextBox.Location = New System.Drawing.Point(158, 333)
        Me.CpfTextBox.Multiline = true
        Me.CpfTextBox.Name = "CpfTextBox"
        Me.CpfTextBox.Size = New System.Drawing.Size(339, 32)
        Me.CpfTextBox.TabIndex = 0
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EntradaBindingSource, "tipo", true))
        Me.TipoTextBox.Location = New System.Drawing.Point(155, 385)
        Me.TipoTextBox.Multiline = true
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(339, 32)
        Me.TipoTextBox.TabIndex = 0
        '
        'FuncaoTextBox
        '
        Me.FuncaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EntradaBindingSource, "funcao", true))
        Me.FuncaoTextBox.Location = New System.Drawing.Point(158, 434)
        Me.FuncaoTextBox.Multiline = true
        Me.FuncaoTextBox.Name = "FuncaoTextBox"
        Me.FuncaoTextBox.Size = New System.Drawing.Size(339, 32)
        Me.FuncaoTextBox.TabIndex = 0
        '
        'DataTextBox
        '
        Me.DataTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EntradaBindingSource, "data", true))
        Me.DataTextBox.Location = New System.Drawing.Point(158, 486)
        Me.DataTextBox.Multiline = true
        Me.DataTextBox.Name = "DataTextBox"
        Me.DataTextBox.Size = New System.Drawing.Size(339, 32)
        Me.DataTextBox.TabIndex = 0
        '
        'HoraTextBox
        '
        Me.HoraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EntradaBindingSource, "hora", true))
        Me.HoraTextBox.Location = New System.Drawing.Point(158, 535)
        Me.HoraTextBox.Multiline = true
        Me.HoraTextBox.Name = "HoraTextBox"
        Me.HoraTextBox.Size = New System.Drawing.Size(339, 29)
        Me.HoraTextBox.TabIndex = 0
        '
        'CodigoDaEntradaTextBox
        '
        Me.CodigoDaEntradaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EntradaBindingSource, "CodigoDaEntrada", true))
        Me.CodigoDaEntradaTextBox.Font = New System.Drawing.Font("Verdana", 20!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
        Me.CodigoDaEntradaTextBox.Location = New System.Drawing.Point(514, 592)
        Me.CodigoDaEntradaTextBox.Multiline = true
        Me.CodigoDaEntradaTextBox.Name = "CodigoDaEntradaTextBox"
        Me.CodigoDaEntradaTextBox.Size = New System.Drawing.Size(0, 0)
        Me.CodigoDaEntradaTextBox.TabIndex = 0
        '
        'SaidaBindingSource
        '
        Me.SaidaBindingSource.DataMember = "saida"
        Me.SaidaBindingSource.DataSource = Me.ProgguaritaDataSet
        '
        'CadastroBindingSource
        '
        Me.CadastroBindingSource.DataMember = "cadastro"
        Me.CadastroBindingSource.DataSource = Me.ProgguaritaDataSet
        '
        'CpfL
        '
        Me.CpfL.Font = New System.Drawing.Font("Verdana", 20!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
        Me.CpfL.Location = New System.Drawing.Point(158, 333)
        Me.CpfL.Name = "CpfL"
        Me.CpfL.Size = New System.Drawing.Size(339, 32)
        Me.CpfL.TabIndex = 49
        Me.CpfL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HoraL
        '
        Me.HoraL.Font = New System.Drawing.Font("Verdana", 20!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
        Me.HoraL.Location = New System.Drawing.Point(158, 535)
        Me.HoraL.Name = "HoraL"
        Me.HoraL.Size = New System.Drawing.Size(339, 32)
        Me.HoraL.TabIndex = 51
        Me.HoraL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataL
        '
        Me.DataL.Font = New System.Drawing.Font("Verdana", 20!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
        Me.DataL.Location = New System.Drawing.Point(158, 486)
        Me.DataL.Name = "DataL"
        Me.DataL.Size = New System.Drawing.Size(339, 32)
        Me.DataL.TabIndex = 52
        Me.DataL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FuncaoL
        '
        Me.FuncaoL.Font = New System.Drawing.Font("Verdana", 20!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
        Me.FuncaoL.Location = New System.Drawing.Point(158, 434)
        Me.FuncaoL.Name = "FuncaoL"
        Me.FuncaoL.Size = New System.Drawing.Size(339, 32)
        Me.FuncaoL.TabIndex = 53
        Me.FuncaoL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ModeloL
        '
        Me.ModeloL.Font = New System.Drawing.Font("Verdana", 20!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
        Me.ModeloL.Location = New System.Drawing.Point(158, 227)
        Me.ModeloL.Name = "ModeloL"
        Me.ModeloL.Size = New System.Drawing.Size(339, 32)
        Me.ModeloL.TabIndex = 54
        Me.ModeloL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TipoL
        '
        Me.TipoL.Font = New System.Drawing.Font("Verdana", 20!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
        Me.TipoL.Location = New System.Drawing.Point(158, 385)
        Me.TipoL.Name = "TipoL"
        Me.TipoL.Size = New System.Drawing.Size(339, 32)
        Me.TipoL.TabIndex = 55
        Me.TipoL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NomeL
        '
        Me.NomeL.Font = New System.Drawing.Font("Verdana", 20!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
        Me.NomeL.Location = New System.Drawing.Point(158, 280)
        Me.NomeL.Name = "NomeL"
        Me.NomeL.Size = New System.Drawing.Size(339, 32)
        Me.NomeL.TabIndex = 56
        Me.NomeL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EntradaTableAdapter
        '
        Me.EntradaTableAdapter.ClearBeforeFill = true
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = false
        Me.TableAdapterManager.cadastroTableAdapter = Me.CadastroTableAdapter
        Me.TableAdapterManager.entradaTableAdapter = Me.EntradaTableAdapter
        Me.TableAdapterManager.saidaTableAdapter = Me.SaidaTableAdapter
        Me.TableAdapterManager.UpdateOrder = Software_Guarita.progguaritaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CadastroTableAdapter
        '
        Me.CadastroTableAdapter.ClearBeforeFill = true
        '
        'SaidaTableAdapter
        '
        Me.SaidaTableAdapter.ClearBeforeFill = true
        '
        'Timer1
        '
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.PaleGreen
        Me.Button4.BackgroundImage = Global.Software_Guarita.My.Resources.Resources.search
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.Button4.FlatAppearance.BorderSize = 2
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chartreuse
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button4.Location = New System.Drawing.Point(453, 175)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 40)
        Me.Button4.TabIndex = 2
        Me.Button4.UseVisualStyleBackColor = false
        '
        'PlacaTextBox
        '
        Me.PlacaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EntradaBindingSource, "placa", true))
        Me.PlacaTextBox.Font = New System.Drawing.Font("Verdana", 20!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
        Me.PlacaTextBox.Location = New System.Drawing.Point(158, 175)
        Me.PlacaTextBox.Mask = "AAA-AAAA"
        Me.PlacaTextBox.MaximumSize = New System.Drawing.Size(300, 32)
        Me.PlacaTextBox.MinimumSize = New System.Drawing.Size(280, 40)
        Me.PlacaTextBox.Name = "PlacaTextBox"
        Me.PlacaTextBox.Size = New System.Drawing.Size(289, 40)
        Me.PlacaTextBox.TabIndex = 1
        Me.PlacaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(181, 637)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(137, 100)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Cadastrar novo"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans", 48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button1.Image = Global.Software_Guarita.My.Resources.Resources.iconfinder_icon_62_document_table_314520
        Me.Button1.Location = New System.Drawing.Point(6, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 65)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = false
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(187, 185)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(8, 20)
        Me.TextBox1.TabIndex = 58
        '
        'Monitoramento
        '
        Me.AcceptButton = Me.Button4
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = true
        Me.BackgroundImage = Global.Software_Guarita.My.Resources.Resources.textura
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(537, 761)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PlacaTextBox)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.NomeL)
        Me.Controls.Add(Me.TipoL)
        Me.Controls.Add(Me.ModeloL)
        Me.Controls.Add(Me.FuncaoL)
        Me.Controls.Add(Me.DataL)
        Me.Controls.Add(Me.HoraL)
        Me.Controls.Add(Me.CpfL)
        Me.Controls.Add(PlacaLabel)
        Me.Controls.Add(ModeloLabel)
        Me.Controls.Add(Me.ModeloTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(CpfLabel)
        Me.Controls.Add(Me.CpfTextBox)
        Me.Controls.Add(TipoLabel)
        Me.Controls.Add(Me.TipoTextBox)
        Me.Controls.Add(FuncaoLabel)
        Me.Controls.Add(Me.FuncaoTextBox)
        Me.Controls.Add(DataLabel)
        Me.Controls.Add(Me.DataTextBox)
        Me.Controls.Add(HoraLabel)
        Me.Controls.Add(Me.HoraTextBox)
        Me.Controls.Add(CodigoDaEntradaLabel)
        Me.Controls.Add(Me.CodigoDaEntradaTextBox)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(553, 800)
        Me.MinimumSize = New System.Drawing.Size(553, 800)
        Me.Name = "Monitoramento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MONITORAMENTO"
        Me.GroupBox1.ResumeLayout(false)
        CType(Me.EntradaBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ProgguaritaDataSet,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SaidaBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CadastroBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox2.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProgguaritaDataSet As Software_Guarita.progguaritaDataSet
    Friend WithEvents EntradaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EntradaTableAdapter As Software_Guarita.progguaritaDataSetTableAdapters.entradaTableAdapter
    Friend WithEvents TableAdapterManager As Software_Guarita.progguaritaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SaidaTableAdapter As Software_Guarita.progguaritaDataSetTableAdapters.saidaTableAdapter
    Friend WithEvents ModeloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CpfTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FuncaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HoraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodigoDaEntradaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaidaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CadastroTableAdapter As Software_Guarita.progguaritaDataSetTableAdapters.cadastroTableAdapter
    Friend WithEvents CadastroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CpfL As System.Windows.Forms.Label
    Friend WithEvents HoraL As System.Windows.Forms.Label
    Friend WithEvents DataL As System.Windows.Forms.Label
    Friend WithEvents FuncaoL As System.Windows.Forms.Label
    Friend WithEvents ModeloL As System.Windows.Forms.Label
    Friend WithEvents TipoL As System.Windows.Forms.Label
    Friend WithEvents NomeL As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PlacaTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
