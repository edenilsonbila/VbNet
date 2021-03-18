Public Class Form1

    'Variaveis

    Public vlr1 As Double
    Public vlr2 As Double
    Public resultado As String
    Public operação As String


    Private Sub tbvlhr1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbvlr1.KeyPress, tbvlr1.KeyPress
        Dim allowedChars As String = ""
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        tbvlr2.Select()
        tbvlr1.TextAlign = HorizontalAlignment.Right
        tbvlr2.TextAlign = HorizontalAlignment.Right
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        tbvlr2.Text += Convert.ToString(1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        tbvlr2.Text += Convert.ToString(4)
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        tbvlr2.Text += Convert.ToString(7)
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        tbvlr2.Text += Convert.ToString(8)
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        tbvlr2.Text += Convert.ToString(5)
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        tbvlr2.Text += Convert.ToString(2)
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        tbvlr2.Text += Convert.ToString(0)
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        tbvlr2.Text += Convert.ToString(9)
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        tbvlr2.Text += Convert.ToString(6)
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        tbvlr2.Text += Convert.ToString(3)
    End Sub

    Private Sub btnigual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnigual.Click
        If tbvlr1.Text = "" Then
        ElseIf tbvlr2.Text = "" Then
        Else



            vlr2 = tbvlr2.Text

            Select Case operação
                Case "/"
                    resultado = vlr1 / vlr2
                Case "+"
                    resultado = vlr1 + vlr2
                Case "-"
                    resultado = vlr1 - vlr2
                Case "*"
                    resultado = vlr1 * vlr2
            End Select

            'tbvlr1.Text = ""
            tbvlr2.Text = ""
            tbvlr2.Text = resultado
        End If
    End Sub

    Private Sub btndivisao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndivisao.Click
        If tbvlr2.Text = "" Then
            MsgBox("Campo em branco")
        Else
            vlr1 = tbvlr2.Text
            operação = "/"
            tbvlr1.Text = vlr1 & operação
            tbvlr2.Text = ""
            tbvlr2.Select()
        End If
    End Sub

    Private Sub btnmais_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmais.Click
        If tbvlr2.Text = "" Then
            MsgBox("Campo em branco")
        Else
            vlr1 = tbvlr2.Text
            operação = "+"
            tbvlr1.Text += vlr1 & operação
            tbvlr2.Text = ""
            tbvlr2.Select()
        End If
    End Sub

    Private Sub btnmenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenos.Click
        If tbvlr2.Text = "" Then
            MsgBox("Campo em branco")
        Else
            vlr1 = tbvlr2.Text
            operação = "-"
            tbvlr1.Text = vlr1 & operação
            tbvlr2.Text = ""
            tbvlr2.Select()
        End If
    End Sub

    Private Sub btnvezes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvezes.Click
        If tbvlr2.Text = "" Then
            MsgBox("Campo em branco")
        Else
            vlr1 = tbvlr2.Text
            operação = "*"
            tbvlr1.Text = vlr1 & operação
            tbvlr2.Text = ""
            tbvlr2.Select()
        End If
    End Sub

    Private Sub btnponto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnponto.Click
        tbvlr1.Text = ""
        tbvlr2.Text = ""
    End Sub
End Class
