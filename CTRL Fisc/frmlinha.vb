Imports System.Data.OleDb
Public Class frmlinha

    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub

    Private Sub btnlimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpar.Click
        tbcor.Text = ""
        tbnome.Text = ""
        'tbnomedis.Text = ""
        tbprefixo.Text = ""
        tbregiao.Text = ""
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        btnsalvar.Enabled = False
        btnexcluir.Enabled = False
        btncancel.Enabled = False
        btnnovo.Enabled = True

        cbcodr.Enabled = False
        tbcor.Enabled = False
        tbnome.Enabled = False
        'tbnomedis.Enabled = False
        tbregiao.Enabled = False
    End Sub

    Private Sub btnnovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnovo.Click
        btnsalvar.Enabled = True
        btnexcluir.Enabled = True
        btncancel.Enabled = True
        btnnovo.Enabled = False

        'cbcodr.Enabled = True
        tbcor.Enabled = True
        tbnome.Enabled = True
        'tbnomedis.Enabled = True
        tbregiao.Enabled = True
    End Sub

    Private Sub btnsalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalvar.Click
        Call cadastrarlinha()
    End Sub

    Private Sub frmlinha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub cbcodr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbcodr.Click
        Dim regiao As String = tbregiao.Text
        cbcodr.DisplayMember = Nothing
        dtset.Clear()
        dataadpt = New OleDbDataAdapter("select * from regiao where regiao = '" & regiao & "'", conecta)
        dataadpt.TableMappings.Add("Table", "Dados")
        dataadpt.Fill(dtset)

        cbcodr.DataSource = dtset.Tables(0)
        cbcodr.DisplayMember = "distrito"

    End Sub

    Private Sub cbcodr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbcodr.SelectedIndexChanged

    End Sub

    Private Sub cbcodr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbcodr.TextChanged
       
    End Sub

    Private Sub tbregiao_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbregiao.TextChanged
        If tbregiao.Text <> "" Then
            cbcodr.Enabled = True
        Else
            cbcodr.Enabled = False
        End If
        Dim regiao As String = tbregiao.Text
        Select Case regiao
            Case "Noroeste"
                tbcor.Enabled = True
                'tbcodigo.Text = 1
                tbcor.BackColor = Color.LightGreen
                tbcor.Text = "Verde"
                tbcor.ReadOnly = True
            Case "Norte"
                'tbcodigo.Text = 2
                tbcor.BackColor = Color.Blue
                tbcor.Text = "Azul Escuro"
                tbcor.ReadOnly = True
            Case "Nordeste"
                'tbcodigo.Text = 3
                tbcor.BackColor = Color.LightYellow
                tbcor.Text = "Amarelo"
                tbcor.ReadOnly = True
            Case "Leste"
                'tbcodigo.Text = 4
                tbcor.BackColor = Color.Red
                tbcor.Text = "Vermelho"
                tbcor.ReadOnly = True
            Case "Sudeste"
                ' tbcodigo.Text = 5
                tbcor.BackColor = Color.Green
                tbcor.Text = "Verde Escuro"
                tbcor.ReadOnly = True
            Case "Sul"
                ' tbcodigo.Text = 6
                tbcor.BackColor = Color.LightBlue
                tbcor.Text = "Azul"
                tbcor.ReadOnly = True
            Case "Sudoeste"
                '  tbcodigo.Text = 7
                tbcor.BackColor = Color.Brown
                tbcor.Text = "Marrom"
                tbcor.ReadOnly = True
            Case "Oeste"
                'tbcodigo.Text = 8
                tbcor.BackColor = Color.MediumPurple
                tbcor.Text = "Vinho"
                tbcor.ReadOnly = True
            Case "Centro"
                ' tbcodigo.Text = 9
                tbcor.BackColor = Color.LightGray
                tbcor.Text = "Cinza"
                tbcor.ReadOnly = True
        End Select
    End Sub

    Private Sub tbregiao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbregiao.Click
        
    End Sub

    Private Sub tbregiao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbregiao.SelectedIndexChanged

    End Sub
End Class