<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmregiao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmregiao))
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnpesquisar = New System.Windows.Forms.Button()
        Me.cbcodr = New System.Windows.Forms.ComboBox()
        Me.tbcodr = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbconcessionaria = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbnome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbcor = New System.Windows.Forms.TextBox()
        Me.tbregiao = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbcodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupBox4.Location = New System.Drawing.Point(6, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(323, 71)
        Me.GroupBox4.TabIndex = 21
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnpesquisar)
        Me.GroupBox1.Controls.Add(Me.cbcodr)
        Me.GroupBox1.Controls.Add(Me.tbcodr)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbconcessionaria)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbnome)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbcor)
        Me.GroupBox1.Controls.Add(Me.tbregiao)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbcodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 105)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados da Região"
        '
        'btnpesquisar
        '
        Me.btnpesquisar.BackgroundImage = Global.CTRL_Fisc.My.Resources.Resources.lupa_png_by_hannaabigail1_d4q6jmc
        Me.btnpesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnpesquisar.Location = New System.Drawing.Point(294, 45)
        Me.btnpesquisar.Name = "btnpesquisar"
        Me.btnpesquisar.Size = New System.Drawing.Size(22, 20)
        Me.btnpesquisar.TabIndex = 30
        Me.btnpesquisar.UseVisualStyleBackColor = True
        '
        'cbcodr
        '
        Me.cbcodr.FormattingEnabled = True
        Me.cbcodr.Location = New System.Drawing.Point(121, 44)
        Me.cbcodr.Name = "cbcodr"
        Me.cbcodr.Size = New System.Drawing.Size(38, 21)
        Me.cbcodr.TabIndex = 12
        '
        'tbcodr
        '
        Me.tbcodr.Enabled = False
        Me.tbcodr.Location = New System.Drawing.Point(120, 44)
        Me.tbcodr.Name = "tbcodr"
        Me.tbcodr.Size = New System.Drawing.Size(29, 20)
        Me.tbcodr.TabIndex = 11
        Me.tbcodr.Text = "Cod"
        Me.tbcodr.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Concessionária:"
        '
        'tbconcessionaria
        '
        Me.tbconcessionaria.Enabled = False
        Me.tbconcessionaria.FormattingEnabled = True
        Me.tbconcessionaria.Location = New System.Drawing.Point(92, 75)
        Me.tbconcessionaria.Name = "tbconcessionaria"
        Me.tbconcessionaria.Size = New System.Drawing.Size(224, 21)
        Me.tbconcessionaria.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Distrito:"
        '
        'tbnome
        '
        Me.tbnome.Enabled = False
        Me.tbnome.Location = New System.Drawing.Point(165, 45)
        Me.tbnome.Name = "tbnome"
        Me.tbnome.Size = New System.Drawing.Size(125, 20)
        Me.tbnome.TabIndex = 7
        Me.tbnome.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cor:"
        '
        'tbcor
        '
        Me.tbcor.Enabled = False
        Me.tbcor.Location = New System.Drawing.Point(30, 45)
        Me.tbcor.Name = "tbcor"
        Me.tbcor.Size = New System.Drawing.Size(46, 20)
        Me.tbcor.TabIndex = 5
        '
        'tbregiao
        '
        Me.tbregiao.Enabled = False
        Me.tbregiao.FormattingEnabled = True
        Me.tbregiao.Items.AddRange(New Object() {"Noroeste", "Norte", "Nordeste", "Leste", "Sudeste", "Sul", "Sudoeste", "Oeste", "Centro"})
        Me.tbregiao.Location = New System.Drawing.Point(195, 19)
        Me.tbregiao.Name = "tbregiao"
        Me.tbregiao.Size = New System.Drawing.Size(121, 21)
        Me.tbregiao.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(148, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Região"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Codigo:"
        '
        'tbcodigo
        '
        Me.tbcodigo.Enabled = False
        Me.tbcodigo.Location = New System.Drawing.Point(59, 19)
        Me.tbcodigo.Name = "tbcodigo"
        Me.tbcodigo.Size = New System.Drawing.Size(83, 20)
        Me.tbcodigo.TabIndex = 1
        '
        'frmregiao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 193)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmregiao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manutenção de Regiões"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbcodigo As System.Windows.Forms.TextBox
    Friend WithEvents tbregiao As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbcor As System.Windows.Forms.TextBox
    Friend WithEvents tbcodr As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbconcessionaria As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbnome As System.Windows.Forms.TextBox
    Friend WithEvents cbcodr As System.Windows.Forms.ComboBox
    Friend WithEvents btnpesquisar As System.Windows.Forms.Button
End Class
