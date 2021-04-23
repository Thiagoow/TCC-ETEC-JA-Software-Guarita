<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastro))
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgguaritaDataSet = New Software_Guarita.progguaritaDataSet()
        Me.CadastroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CadastroTableAdapter = New Software_Guarita.progguaritaDataSetTableAdapters.cadastroTableAdapter()
        Me.TableAdapterManager = New Software_Guarita.progguaritaDataSetTableAdapters.TableAdapterManager()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.PlacaTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TipoTextBox = New System.Windows.Forms.ComboBox()
        Me.FuncaoTextBox = New System.Windows.Forms.ComboBox()
        Me.CpfTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        PlacaLabel = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        CpfLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        FuncaoLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProgguaritaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CadastroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlacaLabel
        '
        PlacaLabel.AutoSize = True
        PlacaLabel.BackColor = System.Drawing.Color.Transparent
        PlacaLabel.Font = New System.Drawing.Font("Verdana", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        PlacaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        PlacaLabel.Location = New System.Drawing.Point(78, 170)
        PlacaLabel.Name = "PlacaLabel"
        PlacaLabel.Size = New System.Drawing.Size(107, 32)
        PlacaLabel.TabIndex = 29
        PlacaLabel.Text = "Placa:"
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.BackColor = System.Drawing.Color.Transparent
        ModeloLabel.Font = New System.Drawing.Font("Verdana", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        ModeloLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        ModeloLabel.Location = New System.Drawing.Point(46, 228)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(136, 32)
        ModeloLabel.TabIndex = 31
        ModeloLabel.Text = "Modelo:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.BackColor = System.Drawing.Color.Transparent
        NomeLabel.Font = New System.Drawing.Font("Verdana", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        NomeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        NomeLabel.Location = New System.Drawing.Point(70, 285)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(115, 32)
        NomeLabel.TabIndex = 33
        NomeLabel.Text = "Nome:"
        '
        'CpfLabel
        '
        CpfLabel.AutoSize = True
        CpfLabel.BackColor = System.Drawing.Color.Transparent
        CpfLabel.Font = New System.Drawing.Font("Verdana", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        CpfLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        CpfLabel.Location = New System.Drawing.Point(101, 340)
        CpfLabel.Name = "CpfLabel"
        CpfLabel.Size = New System.Drawing.Size(84, 32)
        CpfLabel.TabIndex = 35
        CpfLabel.Text = "CPF:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.BackColor = System.Drawing.Color.Transparent
        TipoLabel.Font = New System.Drawing.Font("Verdana", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        TipoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        TipoLabel.Location = New System.Drawing.Point(94, 395)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(91, 32)
        TipoLabel.TabIndex = 37
        TipoLabel.Text = "Tipo:"
        '
        'FuncaoLabel
        '
        FuncaoLabel.AutoSize = True
        FuncaoLabel.BackColor = System.Drawing.Color.Transparent
        FuncaoLabel.Font = New System.Drawing.Font("Verdana", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        FuncaoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        FuncaoLabel.Location = New System.Drawing.Point(50, 449)
        FuncaoLabel.Name = "FuncaoLabel"
        FuncaoLabel.Size = New System.Drawing.Size(135, 32)
        FuncaoLabel.TabIndex = 39
        FuncaoLabel.Text = "Funcao:"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.Button5.FlatAppearance.BorderSize = 2
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(379, 536)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(220, 54)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "SALVAR"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(379, 599)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(220, 54)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "LIMPAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 550)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(137, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
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
        Me.Button3.Font = New System.Drawing.Font("Lucida Sans", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Software_Guarita.My.Resources.Resources.Voltar
        Me.Button3.Location = New System.Drawing.Point(6, 29)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 65)
        Me.Button3.TabIndex = 9
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Software_Guarita.My.Resources.Resources.Sair
        Me.Button1.Location = New System.Drawing.Point(6, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 65)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(49, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(513, 71)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Software Guaritas"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(206, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 48)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cadastro"
        '
        'ProgguaritaDataSet
        '
        Me.ProgguaritaDataSet.DataSetName = "progguaritaDataSet"
        Me.ProgguaritaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CadastroBindingSource
        '
        Me.CadastroBindingSource.DataMember = "cadastro"
        Me.CadastroBindingSource.DataSource = Me.ProgguaritaDataSet
        '
        'CadastroTableAdapter
        '
        Me.CadastroTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cadastroTableAdapter = Me.CadastroTableAdapter
        Me.TableAdapterManager.entradaTableAdapter = Nothing
        Me.TableAdapterManager.saidaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Software_Guarita.progguaritaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "modelo", True))
        Me.ModeloTextBox.Font = New System.Drawing.Font("Verdana", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ModeloTextBox.Location = New System.Drawing.Point(186, 228)
        Me.ModeloTextBox.Multiline = True
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(339, 32)
        Me.ModeloTextBox.TabIndex = 2
        Me.ModeloTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "nome", True))
        Me.NomeTextBox.Font = New System.Drawing.Font("Verdana", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.NomeTextBox.Location = New System.Drawing.Point(186, 285)
        Me.NomeTextBox.Multiline = True
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(339, 32)
        Me.NomeTextBox.TabIndex = 3
        Me.NomeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PlacaTextBox
        '
        Me.PlacaTextBox.Font = New System.Drawing.Font("Verdana", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.PlacaTextBox.Location = New System.Drawing.Point(186, 170)
        Me.PlacaTextBox.Mask = "AAA-AAAA"
        Me.PlacaTextBox.MaximumSize = New System.Drawing.Size(339, 32)
        Me.PlacaTextBox.MinimumSize = New System.Drawing.Size(339, 32)
        Me.PlacaTextBox.Name = "PlacaTextBox"
        Me.PlacaTextBox.Size = New System.Drawing.Size(339, 40)
        Me.PlacaTextBox.TabIndex = 1
        Me.PlacaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "tipo", True))
        Me.TipoTextBox.Font = New System.Drawing.Font("Verdana", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TipoTextBox.FormattingEnabled = True
        Me.TipoTextBox.Items.AddRange(New Object() {"Carro", "Moto", "Van"})
        Me.TipoTextBox.Location = New System.Drawing.Point(186, 392)
        Me.TipoTextBox.MaximumSize = New System.Drawing.Size(339, 0)
        Me.TipoTextBox.MinimumSize = New System.Drawing.Size(339, 0)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(339, 40)
        Me.TipoTextBox.TabIndex = 5
        '
        'FuncaoTextBox
        '
        Me.FuncaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "funcao", True))
        Me.FuncaoTextBox.Font = New System.Drawing.Font("Verdana", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.FuncaoTextBox.FormattingEnabled = True
        Me.FuncaoTextBox.Items.AddRange(New Object() {"Aluno", "Professor", "Funcionário Terceirizado", "Funcionário de Gestão"})
        Me.FuncaoTextBox.Location = New System.Drawing.Point(186, 446)
        Me.FuncaoTextBox.Name = "FuncaoTextBox"
        Me.FuncaoTextBox.Size = New System.Drawing.Size(339, 40)
        Me.FuncaoTextBox.TabIndex = 6
        '
        'CpfTextBox
        '
        Me.CpfTextBox.Font = New System.Drawing.Font("Verdana", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.CpfTextBox.Location = New System.Drawing.Point(186, 340)
        Me.CpfTextBox.Mask = "AAA.AAA.AAA-AA"
        Me.CpfTextBox.MaximumSize = New System.Drawing.Size(339, 32)
        Me.CpfTextBox.MinimumSize = New System.Drawing.Size(339, 32)
        Me.CpfTextBox.Name = "CpfTextBox"
        Me.CpfTextBox.Size = New System.Drawing.Size(339, 40)
        Me.CpfTextBox.TabIndex = 4
        Me.CpfTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(186, 170)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 40
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(186, 340)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 41
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(186, 407)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(392, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(392, 347)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 45
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(186, 449)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 46
        '
        'Cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.Software_Guarita.My.Resources.Resources.textura
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(611, 665)
        Me.Controls.Add(Me.CpfTextBox)
        Me.Controls.Add(Me.FuncaoTextBox)
        Me.Controls.Add(Me.TipoTextBox)
        Me.Controls.Add(Me.PlacaTextBox)
        Me.Controls.Add(PlacaLabel)
        Me.Controls.Add(ModeloLabel)
        Me.Controls.Add(Me.ModeloTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(CpfLabel)
        Me.Controls.Add(TipoLabel)
        Me.Controls.Add(FuncaoLabel)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO"
        Me.GroupBox1.ResumeLayout(false)
        CType(Me.ProgguaritaDataSet,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CadastroBindingSource,System.ComponentModel.ISupportInitialize).EndInit
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
    Friend WithEvents CadastroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CadastroTableAdapter As Software_Guarita.progguaritaDataSetTableAdapters.cadastroTableAdapter
    Friend WithEvents TableAdapterManager As Software_Guarita.progguaritaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ModeloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlacaTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TipoTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents FuncaoTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents CpfTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
