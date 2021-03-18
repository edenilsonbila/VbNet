Imports System.Data.OleDb
Public Class frmcadastro

    Private Sub btnselectpic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnselectpic.Click
        Call selecionarimagem()
        pb3x4.ImageLocation = nameimg
    End Sub

    Private Sub frmcadastro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()
        frmprincipal.Show()
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbcodigo.KeyPress
        'Valida entrada somente numeros
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbmatricula.KeyPress
        'Valida entrada somente numeros
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub


    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbnumero.KeyPress
        'Valida entrada somente numeros
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub MaskedTextBox7_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbcep.KeyPress
        'Valida entrada somente numeros
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub MaskedTextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbdta.KeyPress
        'Valida entrada somente numeros
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub MaskedTextBox5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbinicio.KeyPress
        'Valida entrada somente numeros
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub MaskedTextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbdtd.KeyPress
        'Valida entrada somente numeros
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub MaskedTextBox6_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbnascimento.KeyPress
        'Valida entrada somente numeros
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub MaskedTextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbcpf.KeyPress
        'Valida entrada somente numeros
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbdv.KeyPress

    End Sub

    Private Sub MaskedTextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbrg.KeyPress
        'Valida entrada somente numeros
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox10_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbdddc.KeyPress, tbcel.KeyPress, tbtel.KeyPress, tbddd.KeyPress
        'Valida entrada somente numeros
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbnome_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbcidade.KeyPress, tbrecado.KeyPress, tbnome.KeyPress, tbsexo.KeyPress, cbcargo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoLETRAS(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub

    Private Sub btnlimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpar.Click
        btnexcluir.Enabled = False
        cbcargo.Text = ""
        cbuf.Text = ""
        tbinicio.Text = ""
        tbmatricula.Text = ""
        tbnascimento.Text = ""
        tbnome.Text = ""
        tbnumero.Text = ""
        tbrecado.Text = ""
        tbrg.Text = ""
        tbsexo.Text = ""
        tbtel.Text = ""
        tbusuario.Text = ""
        tbbairro.Text = ""
        tbcel.Text = ""
        tbcep.Text = ""
        tbcidade.Text = ""
        tbcodigo.Text = ""
        tbcomplemento.Text = ""
        tbcpf.Text = ""
        tbddd.Text = ""
        tbdddc.Text = ""
        tbdta.Text = ""
        tbddd.Text = ""
        tbdv.Text = ""
        tbendereco.Text = ""
        tbdtd.Text = ""
        tbemail.Text = ""
        pb3x4.Image = Nothing
    End Sub

    Private Sub btnnovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnovo.Click
        tbcodigo.Enabled = False
        cbcargo.Enabled = True
        cbuf.Enabled = True
        tbinicio.Enabled = True
        tbmatricula.Enabled = True
        tbnascimento.Enabled = True
        tbnome.Enabled = True
        tbnumero.Enabled = True
        tbrecado.Enabled = True
        tbrg.Enabled = True
        tbsexo.Enabled = True
        tbtel.Enabled = True
        tbusuario.Enabled = True
        tbbairro.Enabled = True
        tbcel.Enabled = True
        tbcep.Enabled = True
        tbcidade.Enabled = True
        tbcodigo.Enabled = True
        tbcomplemento.Enabled = True
        tbcpf.Enabled = True
        tbddd.Enabled = True
        tbdddc.Enabled = True
        tbdta.Enabled = True
        tbddd.Enabled = True
        tbdv.Enabled = True
        tbendereco.Enabled = True
        tbdtd.Enabled = True
        tbemail.Enabled = True
        btncancel.Enabled = True
        btnlimpar.Enabled = True
        btnsalvar.Enabled = True
        btnselectpic.Enabled = True
        pb3x4.Enabled = True
        cbcargo.Text = ""
        cbuf.Text = ""
        tbinicio.Text = ""
        tbmatricula.Text = ""
        tbnascimento.Text = ""
        tbnome.Text = ""
        tbnumero.Text = ""
        tbrecado.Text = ""
        tbrg.Text = ""
        tbsexo.Text = ""
        tbtel.Text = ""
        tbusuario.Text = ""
        tbbairro.Text = ""
        tbcel.Text = ""
        tbcep.Text = ""
        tbcidade.Text = ""
        tbcodigo.Text = ""
        tbcomplemento.Text = ""
        tbcpf.Text = ""
        tbddd.Text = ""
        tbdddc.Text = ""
        tbdta.Text = ""
        tbddd.Text = ""
        tbdv.Text = ""
        tbendereco.Text = ""
        tbdtd.Text = ""
        tbemail.Text = ""
        pb3x4.Image = Nothing
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        cbcargo.Enabled = False
        cbuf.Enabled = False
        tbinicio.Enabled = False
        'tbmatricula.Enabled = False
        tbnascimento.Enabled = False
        tbnome.Enabled = False
        tbnumero.Enabled = False
        tbrecado.Enabled = False
        tbrg.Enabled = False
        tbsexo.Enabled = False
        tbtel.Enabled = False
        tbusuario.Enabled = False
        tbbairro.Enabled = False
        tbcel.Enabled = False
        tbcep.Enabled = False
        tbcidade.Enabled = False
        tbcodigo.Enabled = True
        tbcomplemento.Enabled = False
        tbcpf.Enabled = False
        tbddd.Enabled = False
        tbdddc.Enabled = False
        tbdta.Enabled = False
        tbddd.Enabled = False
        tbdv.Enabled = False
        tbendereco.Enabled = False
        tbdtd.Enabled = False
        tbemail.Enabled = False
        btncancel.Enabled = False
        btnlimpar.Enabled = False
        btnsalvar.Enabled = False
        btnselectpic.Enabled = False
        pb3x4.Enabled = False
        cbcargo.Text = ""
        cbuf.Text = ""
        tbinicio.Text = ""
        tbmatricula.Text = ""
        tbnascimento.Text = ""
        tbnome.Text = ""
        tbnumero.Text = ""
        tbrecado.Text = ""
        tbrg.Text = ""
        tbsexo.Text = ""
        tbtel.Text = ""
        tbusuario.Text = ""
        tbbairro.Text = ""
        tbcel.Text = ""
        tbcep.Text = ""
        tbcidade.Text = ""
        tbcodigo.Text = ""
        tbcomplemento.Text = ""
        tbcpf.Text = ""
        tbddd.Text = ""
        tbdddc.Text = ""
        tbdta.Text = ""
        tbddd.Text = ""
        tbdv.Text = ""
        tbendereco.Text = ""
        tbdtd.Text = ""
        tbemail.Text = ""
        pb3x4.Image = Nothing
    End Sub

    Private Sub btnsalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalvar.Click
        Call cadastrarfunc()
    End Sub

    Private Sub tbnome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnome.TextChanged

    End Sub

    Private Sub btnpesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpesquisar.Click
        escolha = 0
        Call pesquisarfunc()
    End Sub

    Private Sub btnexcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexcluir.Click
        Call excluirfunc()
        If excluirsuce = 1 Then
            cbcargo.Enabled = False
            cbuf.Enabled = False
            tbinicio.Enabled = False
            'tbmatricula.Enabled = False
            tbnascimento.Enabled = False
            tbnome.Enabled = False
            tbnumero.Enabled = False
            tbrecado.Enabled = False
            tbrg.Enabled = False
            tbsexo.Enabled = False
            tbtel.Enabled = False
            tbusuario.Enabled = False
            tbbairro.Enabled = False
            tbcel.Enabled = False
            tbcep.Enabled = False
            tbcidade.Enabled = False
            tbcodigo.Enabled = True
            tbcomplemento.Enabled = False
            tbcpf.Enabled = False
            tbddd.Enabled = False
            tbdddc.Enabled = False
            tbdta.Enabled = False
            tbddd.Enabled = False
            tbdv.Enabled = False
            tbendereco.Enabled = False
            tbdtd.Enabled = False
            tbemail.Enabled = False
            btncancel.Enabled = False
            btnlimpar.Enabled = False
            btnsalvar.Enabled = False
            btnselectpic.Enabled = False
            pb3x4.Enabled = False
            cbcargo.Text = ""
            cbuf.Text = ""
            tbinicio.Text = ""
            tbmatricula.Text = ""
            tbnascimento.Text = ""
            tbnome.Text = ""
            tbnumero.Text = ""
            tbrecado.Text = ""
            tbrg.Text = ""
            tbsexo.Text = ""
            tbtel.Text = ""
            tbusuario.Text = ""
            tbbairro.Text = ""
            tbcel.Text = ""
            tbcep.Text = ""
            tbcidade.Text = ""
            tbcodigo.Text = ""
            tbcomplemento.Text = ""
            tbcpf.Text = ""
            tbddd.Text = ""
            tbdddc.Text = ""
            tbdta.Text = ""
            tbddd.Text = ""
            tbdv.Text = ""
            tbendereco.Text = ""
            tbdtd.Text = ""
            tbemail.Text = ""
            pb3x4.Image = Nothing
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        escolha = 1
        Call pesquisarfunc()
    End Sub
End Class