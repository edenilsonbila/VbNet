<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcdonibus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcdonibus))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnpesquisarplaca = New System.Windows.Forms.Button()
        Me.btnpesquisar = New System.Windows.Forms.Button()
        Me.tbchassi = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbano = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnselimg = New System.Windows.Forms.Button()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.ckar = New System.Windows.Forms.CheckBox()
        Me.ckace = New System.Windows.Forms.CheckBox()
        Me.cbtipo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbmarca = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbpoltronas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbmodelo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbplaca = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbprefixo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.selimagem = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnsair = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnnovo = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnlimpar = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnexcluir = New System.Windows.Forms.Button()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnpesquisarplaca)
        Me.GroupBox1.Controls.Add(Me.btnpesquisar)
        Me.GroupBox1.Controls.Add(Me.tbchassi)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tbano)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.ckar)
        Me.GroupBox1.Controls.Add(Me.ckace)
        Me.GroupBox1.Controls.Add(Me.cbtipo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbmarca)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbpoltronas)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbmodelo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbplaca)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbprefixo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 366)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cadastrar onibus"
        '
        'btnpesquisarplaca
        '
        Me.btnpesquisarplaca.BackgroundImage = Global.CTRL_Fisc.My.Resources.Resources.lupa_png_by_hannaabigail1_d4q6jmc
        Me.btnpesquisarplaca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnpesquisarplaca.Location = New System.Drawing.Point(296, 17)
        Me.btnpesquisarplaca.Name = "btnpesquisarplaca"
        Me.btnpesquisarplaca.Size = New System.Drawing.Size(22, 20)
        Me.btnpesquisarplaca.TabIndex = 31
        Me.btnpesquisarplaca.UseVisualStyleBackColor = True
        '
        'btnpesquisar
        '
        Me.btnpesquisar.BackgroundImage = Global.CTRL_Fisc.My.Resources.Resources.lupa_png_by_hannaabigail1_d4q6jmc
        Me.btnpesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnpesquisar.Location = New System.Drawing.Point(136, 16)
        Me.btnpesquisar.Name = "btnpesquisar"
        Me.btnpesquisar.Size = New System.Drawing.Size(22, 20)
        Me.btnpesquisar.TabIndex = 30
        Me.btnpesquisar.UseVisualStyleBackColor = True
        '
        'tbchassi
        '
        Me.tbchassi.Enabled = False
        Me.tbchassi.Location = New System.Drawing.Point(176, 103)
        Me.tbchassi.Name = "tbchassi"
        Me.tbchassi.Size = New System.Drawing.Size(141, 20)
        Me.tbchassi.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(132, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Chassi:"
        '
        'tbano
        '
        Me.tbano.Enabled = False
        Me.tbano.Location = New System.Drawing.Point(43, 103)
        Me.tbano.Name = "tbano"
        Me.tbano.Size = New System.Drawing.Size(84, 20)
        Me.tbano.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Ano:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnselimg)
        Me.GroupBox2.Controls.Add(Me.pb1)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 171)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Imagem:"
        '
        'btnselimg
        '
        Me.btnselimg.Enabled = False
        Me.btnselimg.Location = New System.Drawing.Point(183, 141)
        Me.btnselimg.Name = "btnselimg"
        Me.btnselimg.Size = New System.Drawing.Size(114, 23)
        Me.btnselimg.TabIndex = 0
        Me.btnselimg.Text = "Selecionar Imagem..."
        Me.btnselimg.UseVisualStyleBackColor = True
        '
        'pb1
        '
        Me.pb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb1.Location = New System.Drawing.Point(6, 19)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(291, 116)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb1.TabIndex = 9
        Me.pb1.TabStop = False
        '
        'ckar
        '
        Me.ckar.AutoSize = True
        Me.ckar.Enabled = False
        Me.ckar.Location = New System.Drawing.Point(187, 155)
        Me.ckar.Name = "ckar"
        Me.ckar.Size = New System.Drawing.Size(36, 17)
        Me.ckar.TabIndex = 9
        Me.ckar.Text = "Ar"
        Me.ckar.UseVisualStyleBackColor = True
        '
        'ckace
        '
        Me.ckace.AutoSize = True
        Me.ckace.Enabled = False
        Me.ckace.Location = New System.Drawing.Point(187, 132)
        Me.ckace.Name = "ckace"
        Me.ckace.Size = New System.Drawing.Size(93, 17)
        Me.ckace.TabIndex = 8
        Me.ckace.Text = "Acessibilidade"
        Me.ckace.UseVisualStyleBackColor = True
        '
        'cbtipo
        '
        Me.cbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbtipo.Enabled = False
        Me.cbtipo.FormattingEnabled = True
        Me.cbtipo.Items.AddRange(New Object() {"Micro ônibus", "Biarticulado", "Superarticulados", "Comum", "BRT"})
        Me.cbtipo.Location = New System.Drawing.Point(43, 142)
        Me.cbtipo.Name = "cbtipo"
        Me.cbtipo.Size = New System.Drawing.Size(121, 21)
        Me.cbtipo.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Tipo:"
        '
        'tbmarca
        '
        Me.tbmarca.Enabled = False
        Me.tbmarca.Location = New System.Drawing.Point(182, 75)
        Me.tbmarca.Name = "tbmarca"
        Me.tbmarca.Size = New System.Drawing.Size(135, 20)
        Me.tbmarca.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(136, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Marca:"
        '
        'tbpoltronas
        '
        Me.tbpoltronas.Enabled = False
        Me.tbpoltronas.Location = New System.Drawing.Point(70, 75)
        Me.tbpoltronas.Name = "tbpoltronas"
        Me.tbpoltronas.Size = New System.Drawing.Size(60, 20)
        Me.tbpoltronas.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Poltronas:"
        '
        'tbmodelo
        '
        Me.tbmodelo.Enabled = False
        Me.tbmodelo.Location = New System.Drawing.Point(55, 46)
        Me.tbmodelo.Name = "tbmodelo"
        Me.tbmodelo.Size = New System.Drawing.Size(262, 20)
        Me.tbmodelo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Modelo:"
        '
        'tbplaca
        '
        Me.tbplaca.Location = New System.Drawing.Point(207, 17)
        Me.tbplaca.Name = "tbplaca"
        Me.tbplaca.Size = New System.Drawing.Size(85, 20)
        Me.tbplaca.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Placa:"
        '
        'tbprefixo
        '
        Me.tbprefixo.Location = New System.Drawing.Point(47, 17)
        Me.tbprefixo.Name = "tbprefixo"
        Me.tbprefixo.Size = New System.Drawing.Size(83, 20)
        Me.tbprefixo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Prefixo:"
        '
        'selimagem
        '
        Me.selimagem.DefaultExt = "jpg"
        Me.selimagem.Title = "Selecionar Imagem"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.btnsair)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.btncancel)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.btnnovo)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.btnlimpar)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.btnexcluir)
        Me.GroupBox4.Controls.Add(Me.btnsalvar)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox4.Location = New System.Drawing.Point(4, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(323, 71)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(282, 54)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(25, 13)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "Sair"
        '
        'btnsair
        '
        Me.btnsair.BackgroundImage = Global.CTRL_Fisc.My.Resources.Resources.Sair
        Me.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsair.Location = New System.Drawing.Point(271, 9)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(47, 42)
        Me.btnsair.TabIndex = 5
        Me.btnsair.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(164, 54)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 13)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Cancelar"
        '
        'btncancel
        '
        Me.btncancel.BackgroundImage = Global.CTRL_Fisc.My.Resources.Resources.Excluir
        Me.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancel.Enabled = False
        Me.btncancel.Location = New System.Drawing.Point(165, 9)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(47, 42)
        Me.btncancel.TabIndex = 3
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(222, 54)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(38, 13)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "Limpar"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(117, 54)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 13)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Salvar"
        '
        'btnnovo
        '
        Me.btnnovo.BackgroundImage = Global.CTRL_Fisc.My.Resources.Resources.Novo
        Me.btnnovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnovo.Location = New System.Drawing.Point(6, 9)
        Me.btnnovo.Name = "btnnovo"
        Me.btnnovo.Size = New System.Drawing.Size(47, 42)
        Me.btnnovo.TabIndex = 0
        Me.btnnovo.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(63, 54)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 13)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Excluir"
        '
        'btnlimpar
        '
        Me.btnlimpar.BackgroundImage = Global.CTRL_Fisc.My.Resources.Resources.Limpar
        Me.btnlimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlimpar.Location = New System.Drawing.Point(218, 9)
        Me.btnlimpar.Name = "btnlimpar"
        Me.btnlimpar.Size = New System.Drawing.Size(47, 42)
        Me.btnlimpar.TabIndex = 4
        Me.btnlimpar.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(13, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Novo"
        '
        'btnexcluir
        '
        Me.btnexcluir.BackgroundImage = Global.CTRL_Fisc.My.Resources.Resources.Excluir
        Me.btnexcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnexcluir.Enabled = False
        Me.btnexcluir.Location = New System.Drawing.Point(59, 9)
        Me.btnexcluir.Name = "btnexcluir"
        Me.btnexcluir.Size = New System.Drawing.Size(47, 42)
        Me.btnexcluir.TabIndex = 1
        Me.btnexcluir.UseVisualStyleBackColor = True
        '
        'btnsalvar
        '
        Me.btnsalvar.BackgroundImage = Global.CTRL_Fisc.My.Resources.Resources.Salvar
        Me.btnsalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsalvar.Enabled = False
        Me.btnsalvar.Location = New System.Drawing.Point(112, 9)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(47, 42)
        Me.btnsalvar.TabIndex = 2
        Me.btnsalvar.UseVisualStyleBackColor = True
        '
        'frmcdonibus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(341, 426)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmcdonibus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Ônibus"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbmodelo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbplaca As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbprefixo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnselimg As System.Windows.Forms.Button
    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents tbmarca As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbpoltronas As System.Windows.Forms.TextBox
    Friend WithEvents selimagem As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnsair As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnnovo As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnlimpar As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnexcluir As System.Windows.Forms.Button
    Friend WithEvents btnsalvar As System.Windows.Forms.Button
    Friend WithEvents tbchassi As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbano As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ckar As System.Windows.Forms.CheckBox
    Friend WithEvents ckace As System.Windows.Forms.CheckBox
    Friend WithEvents cbtipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnpesquisarplaca As System.Windows.Forms.Button
    Friend WithEvents btnpesquisar As System.Windows.Forms.Button
End Class