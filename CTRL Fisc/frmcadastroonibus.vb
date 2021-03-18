Public Class frmcdonibus

    Private Sub FlowLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnselimg.Click
        Call selecionarimagem()
        Me.pb1.ImageLocation = nameimg
    End Sub

    Private Sub pb1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1.Click

    End Sub

    Private Sub frmcdonibus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        btnnovo.Enabled = True
        tbano.Enabled = False
        tbchassi.Enabled = False
        tbmarca.Enabled = False
        tbmodelo.Enabled = False
        ' tbplaca.Enabled = False
        tbpoltronas.Enabled = False
        'tbprefixo.Enabled = False
        btnselimg.Enabled = False
        ckace.Enabled = False
        ckar.Enabled = False
        cbtipo.Enabled = False
        btncancel.Enabled = False
        btnlimpar.Enabled = False
        btnsalvar.Enabled = False

        tbano.Text = ""
        tbchassi.Text = ""
        tbmarca.Text = ""
        tbmodelo.Text = ""
        tbplaca.Text = ""
        tbpoltronas.Text = ""
        tbprefixo.Text = ""
        cbtipo.Text = ""
        'tbmatricula.Enabled = False
        'cbcargo.Text = ""

        ' pb3x4.Image = Nothing
    End Sub

    Private Sub btnnovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnovo.Click
        btnnovo.Enabled = False
        tbano.Enabled = True
        tbchassi.Enabled = True
        tbmarca.Enabled = True
        tbmodelo.Enabled = True
        tbplaca.Enabled = True
        tbpoltronas.Enabled = True
        tbprefixo.Enabled = True
        btnselimg.Enabled = True
        ckace.Enabled = True
        ckar.Enabled = True
        cbtipo.Enabled = True
        btncancel.Enabled = True
        btnlimpar.Enabled = True
        btnsalvar.Enabled = True

        tbano.Text = ""
        tbchassi.Text = ""
        tbmarca.Text = ""
        tbmodelo.Text = ""
        tbplaca.Text = ""
        tbpoltronas.Text = ""
        tbprefixo.Text = ""
        cbtipo.Text = ""
    End Sub

    Private Sub btnlimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpar.Click
        tbano.Text = ""
        tbchassi.Text = ""
        tbmarca.Text = ""
        tbmodelo.Text = ""
        tbplaca.Text = ""
        tbpoltronas.Text = ""
        tbprefixo.Text = ""
        cbtipo.Text = ""
        ckar.Checked = False
        ckace.Checked = False
        pb1.Image = Nothing


    End Sub

    Private Sub btnsalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalvar.Click
        Call cadastraronibus()
        btnnovo.Enabled = True
        tbano.Enabled = False
        tbchassi.Enabled = False
        tbmarca.Enabled = False
        tbmodelo.Enabled = False
        ' tbplaca.Enabled = False
        tbpoltronas.Enabled = False
        'tbprefixo.Enabled = False
        btnselimg.Enabled = False
        ckace.Enabled = False
        ckar.Enabled = False
        cbtipo.Enabled = False
        btncancel.Enabled = False
        btnlimpar.Enabled = False
        btnsalvar.Enabled = False

        tbano.Text = ""
        tbchassi.Text = ""
        tbmarca.Text = ""
        tbmodelo.Text = ""
        tbplaca.Text = ""
        tbpoltronas.Text = ""
        tbprefixo.Text = ""
        cbtipo.Text = ""
        pb1.Image = Nothing
    End Sub

    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub

    Private Sub btnpesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpesquisar.Click
        escolha = 0
        Call pesquisaronibus()

    End Sub

    Private Sub btnpesquisarplaca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpesquisarplaca.Click
        escolha = 1
        Call pesquisaronibus()
    End Sub

    Private Sub btnexcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexcluir.Click
        Call excluirbus()

    End Sub
End Class