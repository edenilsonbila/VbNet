Imports System.Data.OleDb
Public Class frmregiao

    Private Sub btnnovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnovo.Click
        dtset.Clear()
        tbconcessionaria.DataSource = Nothing
        tbconcessionaria.Items.Clear()

        cbcodr.Visible = False
        cbcodr.SendToBack()
        tbcodr.Visible = True
        tbcodr.BringToFront()


        btnpesquisar.Enabled = False
        btnnovo.Enabled = False
        btncancel.Enabled = True
        btnlimpar.Enabled = True
        btnsalvar.Enabled = True

        tbregiao.Enabled = True
        tbcodr.Enabled = True
        tbconcessionaria.Enabled = True
        tbcor.Enabled = True
        tbnome.Enabled = True

        tbcor.BackColor = Color.White
        tbconcessionaria.Text = ""
        tbcor.Text = ""
        tbregiao.Text = ""

        dataadpt = New OleDbDataAdapter("Select * from empresa", conecta)
        dataadpt.TableMappings.Add("Table", "Dados")
        dataadpt.Fill(dtset)
        tbconcessionaria.DataSource = dtset.Tables(0)
        tbconcessionaria.DisplayMember = "razao"
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        btnnovo.Enabled = True
        btnpesquisar.Enabled = True
        btncancel.Enabled = False
        btnsalvar.Enabled = False

        cbcodr.Visible = True
        cbcodr.BringToFront()
        tbcodr.Visible = False
        tbcodr.SendToBack()

        tbregiao.Enabled = False
        tbcodr.Enabled = False
        tbconcessionaria.Enabled = False
        tbcor.Enabled = False
        tbnome.Enabled = False

        tbconcessionaria.Text = ""
        tbcor.Text = ""
        tbcor.BackColor = Color.White
        tbnome.Text = "Nome"
        tbcodr.Text = "Cod"
    End Sub

    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub

    Private Sub tbcodr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbcodr.TextChanged

    End Sub

    Private Sub tbcodr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbcodr.Click
        tbcodr.Text = ""
    End Sub

    Private Sub tbnome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnome.Click
        tbnome.Text = ""
    End Sub

    Private Sub btnlimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpar.Click
        tbconcessionaria.Text = ""
        tbcor.Text = ""
        tbnome.Text = "Nome"
        tbcodr.Text = "Cod"
        tbcor.BackColor = Color.White
    End Sub

    Private Sub tbregiao_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbregiao.TextChanged
        Dim regiao As String = tbregiao.Text
        Select Case regiao
            Case "Noroeste"
                tbcor.Enabled = True
                tbcodigo.Text = 1
                tbcor.BackColor = Color.LightGreen
                tbcor.Text = "Verde"
                tbcor.ReadOnly = True
            Case "Norte"
                tbcodigo.Text = 2
                tbcor.BackColor = Color.Blue
                tbcor.Text = "Azul Escuro"
                tbcor.ReadOnly = True
            Case "Nordeste"
                tbcodigo.Text = 3
                tbcor.BackColor = Color.LightYellow
                tbcor.Text = "Amarelo"
                tbcor.ReadOnly = True
            Case "Leste"
                tbcodigo.Text = 4
                tbcor.BackColor = Color.Red
                tbcor.Text = "Vermelho"
                tbcor.ReadOnly = True
            Case "Sudeste"
                tbcodigo.Text = 5
                tbcor.BackColor = Color.Green
                tbcor.Text = "Verde Escuro"
                tbcor.ReadOnly = True
            Case "Sul"
                tbcodigo.Text = 6
                tbcor.BackColor = Color.LightBlue
                tbcor.Text = "Azul"
                tbcor.ReadOnly = True
            Case "Sudoeste"
                tbcodigo.Text = 7
                tbcor.BackColor = Color.Brown
                tbcor.Text = "Marrom"
                tbcor.ReadOnly = True
            Case "Oeste"
                tbcodigo.Text = 8
                tbcor.BackColor = Color.MediumPurple
                tbcor.Text = "Vinho"
                tbcor.ReadOnly = True
            Case "Centro"
                tbcodigo.Text = 9
                tbcor.BackColor = Color.LightGray
                tbcor.Text = "Cinza"
                tbcor.ReadOnly = True
        End Select
    End Sub

    Public Sub frmregiao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnsalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalvar.Click
        Call caddistrito()
        tbconcessionaria.Text = ""
        tbcor.Text = ""
        tbnome.Text = "Nome"
        tbcodr.Text = "Cod"

        btnnovo.Enabled = True
        btncancel.Enabled = False
        btnsalvar.Enabled = False

        cbcodr.Visible = True
        cbcodr.BringToFront()
        tbcodr.Visible = False
        tbcodr.SendToBack()

        tbcodr.Enabled = False
        tbconcessionaria.Enabled = False
        tbcor.Enabled = False
        tbnome.Enabled = False

        tbconcessionaria.Text = ""
        tbcor.Text = ""
        tbcor.BackColor = Color.White
        tbcor.Enabled = False
        tbnome.Text = "Nome"
        tbcodr.Text = "Cod"
    End Sub

    Private Sub cbcodr_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbcodr.MouseClick
        cbcodr.DisplayMember = Nothing
        dtset.Clear()
        dataadpt = New OleDbDataAdapter("select * from regiao", conecta)
        dataadpt.TableMappings.Add("Table", "Dados")
        dataadpt.Fill(dtset)

        cbcodr.DataSource = dtset.Tables(0)
        cbcodr.DisplayMember = "codr"
    End Sub

    Private Sub btnpesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpesquisar.Click
        If cbcodr.Text = "" Then
            MsgBox("Selecione o codigo do distrito", MsgBoxStyle.Information, "Campo em branco")
        Else
            Dim cod As Integer = cbcodr.Text
            MsgBox(cod)
            dtset.Clear()
            dataadpt = New OleDbDataAdapter("select * from regiao where codr=" & cod & "", conecta)
            dataadpt.TableMappings.Add("Table", "Dados")
            dataadpt.Fill(dtset)

            tbnome.Text = dtset.Tables(0).Rows(0).Item(4)
            tbcodigo.Text = dtset.Tables(0).Rows(0).Item(0)
            tbregiao.Text = dtset.Tables(0).Rows(0).Item(1)
            tbcor.Text = dtset.Tables(0).Rows(0).Item(2)
            tbcodigo.Text = dtset.Tables(0).Rows(0).Item(3)
            tbconcessionaria.Text = dtset.Tables(0).Rows(0).Item(5)
        End If
    End Sub

    Private Sub cbcodr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbcodr.SelectedIndexChanged

    End Sub

    Private Sub tbregiao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbregiao.SelectedIndexChanged

    End Sub
End Class