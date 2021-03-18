Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Jogador1 = TextBox1.Text
        Jogador2 = TextBox2.Text

        Form1.Show()
        Form1.Circulo.Visible = True
        Form1.Label1.Text = Jogador1 & ", é a sua vez."
        Form1.Joga1.Text = Jogador1 & ":"
        Form1.Joga2.Text = Jogador2 & ":"
        Me.Close()
        liga_desliga(True)
    End Sub
End Class