Imports System.Net.WebRequestMethods
Imports System.Web
Imports System.Data.OleDb

Public Class frmprincipal

    Private Sub BombeirosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BombeirosToolStripMenuItem.Click
        Dim bombeiro As String = "http://www.corpodebombeiros.sp.gov.br/"
        frmwb.Show()
        frmwb.wbem.Navigate(bombeiro)
        'wbemergencia.Show()
    End Sub

    Private Sub SamuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SamuToolStripMenuItem.Click
        Dim bombeiro As String = "http://samu.saude.sc.gov.br/"
        frmwb.Show()
        frmwb.wbem.Navigate(bombeiro)
        'wbemergencia.Show()
    End Sub

    Private Sub PoliciaMilitarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PoliciaMilitarToolStripMenuItem.Click
        Dim bombeiro As String = "http://www.pm.sp.gov.br/"
        frmwb.Show()
        frmwb.wbem.Navigate(bombeiro)
        'wbemergencia.Show()
    End Sub

    Private Sub DetranSPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetranSPToolStripMenuItem.Click
        Dim bombeiro As String = "http://www.detran.sp.gov.br/"
        frmwb.Show()
        frmwb.wbem.Navigate(bombeiro)
        'wbemergencia.Show()
    End Sub

    Private Sub CadastrarFiscalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarFiscalToolStripMenuItem.Click
        frmcadastro.Show()
    End Sub

    Private Sub CadastrarOnibusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarOnibusToolStripMenuItem.Click
        frmcdonibus.Show()
    End Sub

    Private Sub frmprincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conectar()

        'Atribui nome as Tab
        TabPage1.Text = "Registrar Viagem"
        TabPage2.Text = "Consultar Registros"

        dataadpt = New OleDbDataAdapter("Select * from param", conecta)
        dataadpt.TableMappings.Add("Table", "Dados")
        dataadpt.Fill(dtset)

        MaskedTextBox1.Text = dtset.Tables(0).Rows(0).Item(0)
    End Sub
    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub SobreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpresaToolStripMenuItem.Click
        frmcadempresa.Show()
    End Sub

    Private Sub RegiãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegiãoToolStripMenuItem.Click
        frmregiao.Show()
    End Sub

    Private Sub CadastrarLinhaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarLinhaToolStripMenuItem.Click
        frmlinha.Show()
    End Sub

    Private Sub cblinha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cblinha.Click
        'Combo linha
        Dim dtlinha As New DataSet
        dtlinha.Clear()
        dataadpt = New OleDbDataAdapter("Select * from linha", conecta)
        dataadpt.TableMappings.Add("Table", "Dados")
        dataadpt.Fill(dtlinha)
        cblinha.DataSource = dtlinha.Tables(0)
        cblinha.Refresh()
        cblinha.DisplayMember = "nome_linha"
    End Sub

    Private Sub cbmotorista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbmotorista.Click
        'Combo Motorista
        Dim dtmotorista As New DataSet
        dtmotorista.Clear()
        dataadpt = New OleDbDataAdapter("Select * from funcionario where cargo= 'Motorista'", conecta)
        dataadpt.TableMappings.Add("Table", "Dados")
        dataadpt.Fill(dtmotorista)
        cbmotorista.DataSource = dtmotorista.Tables(0)
        cbmotorista.Refresh()
        cbmotorista.DisplayMember = "Usuario"

    End Sub

    Private Sub cbcobrador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbcobrador.Click
        'Combo Cobrador
        Dim dtcobrador As New DataSet
        dtcobrador.Clear()
        dataadpt = New OleDbDataAdapter("Select * from funcionario where cargo= 'Cobrador'", conecta)
        dataadpt.TableMappings.Add("Table", "Dados")
        dataadpt.Fill(dtcobrador)
        cbcobrador.DataSource = dtcobrador.Tables(0)
        cbcobrador.Refresh()
        cbcobrador.DisplayMember = "Usuario"

    End Sub

    Private Sub cbonibus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbonibus.Click
        Dim dtonibus As New DataSet
        dtonibus.Clear()
        dataadpt = New OleDbDataAdapter("Select * from onibus", conecta)
        dataadpt.TableMappings.Add("Table", "Dados")
        dataadpt.Fill(dtonibus)
        cbonibus.DataSource = dtonibus.Tables(0)
        cbonibus.DisplayMember = "prefixo"
        cbonibus.Refresh()
    End Sub

    Private Sub cbonibus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbonibus.SelectedIndexChanged
       
    End Sub

    Private Sub cbfiscal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbfiscal.Click
        Dim dtfiscal As New DataSet
        dtfiscal.Clear()
        dataadpt = New OleDbDataAdapter("Select * from funcionario where cargo= 'Fiscal'", conecta)
        dataadpt.TableMappings.Add("Table", "Dados")
        dataadpt.Fill(dtfiscal)
        cbfiscal.DataSource = dtfiscal.Tables(0)
        cbfiscal.DisplayMember = "Nome"
        cbfiscal.Refresh()
    End Sub

    Private Sub btngravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngravar.Click
        Call gravarfisc()
    End Sub

    Private Sub tbtotal_p_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtotal_p.Click
        If tbcatraca_i.Text = "" Then
            MsgBox("Informe a catraca inicial", MsgBoxStyle.Exclamation)
        ElseIf tbcatraca_f.Text = "" Then
            MsgBox("Informe a catraca final", MsgBoxStyle.Exclamation)
        Else

            Dim catraca_i As Integer = tbcatraca_i.Text
            Dim catraca_f As Integer = tbcatraca_f.Text

            If catraca_i > catraca_f Then
                MsgBox("Catraca inical não pode ser menor que o valor da catraca final", MsgBoxStyle.Exclamation, "Divergencia")
            Else

                tbtotal_p.Text = catraca_f - catraca_i
            End If
        End If
    End Sub

    Private Sub ValorDaPassagemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValorDaPassagemToolStripMenuItem.Click
        config.Show()
    End Sub

    Private Sub tbtotal_v_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tbtotal_v_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtotal_v.Click
        If tbcatraca_i.Text = "" Then
            MsgBox("Informe a catraca inicial", MsgBoxStyle.Exclamation)
        ElseIf tbcatraca_f.Text = "" Then
            MsgBox("Informe a catraca final", MsgBoxStyle.Exclamation)
        Else
            Dim catraca_i As Integer = tbcatraca_i.Text
            Dim catraca_f As Integer = tbcatraca_f.Text
            Dim total As Integer
            Dim vlr As Integer

            If catraca_i > catraca_f Then
                MsgBox("Catraca inical não pode ser menor que o valor da catraca final", MsgBoxStyle.Exclamation, "Divergencia")
            Else
                vlr = MaskedTextBox1.Text
                total = catraca_f - catraca_i
                tbtotal_v.Text = total * vlr
            End If
        End If
    End Sub

    Private Sub tbtotal_v_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles tbtotal_v.MaskInputRejected

    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged

    End Sub
End Class