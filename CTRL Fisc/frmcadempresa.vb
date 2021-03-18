Public Class frmcadempresa

    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub

    Private Sub btnnovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnovo.Click
        btncancel.Enabled = True
        btnsalvar.Enabled = True
        btnlimpar.Enabled = True
        tbrazao.Enabled = True
        tbnomefantasia.Enabled = True
        tbendereco.Enabled = True
        tbnumero.Enabled = True
        tbbairro.Enabled = True
        tbcidade.Enabled = True
        cbuf.Enabled = True
        tbcomplemento.Enabled = True
        tbcep.Enabled = True
        tbddd.Enabled = True
        tbtel.Enabled = True
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        btncancel.Enabled = False
        btnsalvar.Enabled = False
        tbrazao.Enabled = False
        tbnomefantasia.Enabled = False
        tbendereco.Enabled = False
        tbnumero.Enabled = False
        tbbairro.Enabled = False
        tbcidade.Enabled = False
        cbuf.Enabled = False
        tbcomplemento.Enabled = False
        tbcep.Enabled = False
        tbddd.Enabled = False
        tbtel.Enabled = False
    End Sub

    Private Sub btnlimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpar.Click
        tbcodigo.Text = ""
        tbcnpj.Text = ""
        tbrazao.Text = ""
        tbnomefantasia.Text = ""
        tbendereco.Text = ""
        tbnumero.Text = ""
        tbbairro.Text = ""
        tbcidade.Text = ""
        cbuf.Text = ""
        tbcomplemento.Text = ""
        tbcep.Text = ""
        tbddd.Text = ""
        tbtel.Text = ""
    End Sub

    Private Sub btnsalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalvar.Click
        Call cadastrarempresa()
        tbcodigo.Text = ""
        tbcnpj.Text = ""
        tbrazao.Text = ""
        tbnomefantasia.Text = ""
        tbendereco.Text = ""
        tbnumero.Text = ""
        tbbairro.Text = ""
        tbcidade.Text = ""
        cbuf.Text = ""
        tbcomplemento.Text = ""
        tbcep.Text = ""
        tbddd.Text = ""
        tbtel.Text = ""
    End Sub

    Private Sub btnpesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpesquisar.Click
        escolha = 0
        Call pesquisarempresa()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        escolha = 1
        Call pesquisarempresa()
    End Sub

    Private Sub btnexcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexcluir.Click
        Call excluirempresa()
        'tbcodigo.Text = ""
        ' tbcnpj.Text = ""
        tbrazao.Text = ""
        tbnomefantasia.Text = ""
        tbendereco.Text = ""
        tbnumero.Text = ""
        tbbairro.Text = ""
        tbcidade.Text = ""
        cbuf.Text = ""
        tbcomplemento.Text = ""
        tbcep.Text = ""
        tbddd.Text = ""
        tbtel.Text = ""
    End Sub
End Class