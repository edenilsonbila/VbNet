Module Module1
    Public Jogador1 As String
    Public Jogador2 As String
    Public Joga_Vez As Integer = 0
    Public PlacarJoga_1 As Integer = 0
    Public PlacarJoga_2 As Integer = 0
    Public Tela1 As Integer = 3
    Public Tela2 As Integer = 3
    Public Tela3 As Integer = 3
    Public Tela4 As Integer = 3
    Public Tela5 As Integer = 3
    Public Tela6 As Integer = 3
    Public Tela7 As Integer = 3
    Public Tela8 As Integer = 3
    Public Tela9 As Integer = 3

    Public Function Draw(ByVal Valor_0_ou_1 As Integer, ByVal Tela As String) As System.Drawing.Image


        If Valor_0_ou_1 = 0 Then
            Select Case Tela
                Case "Tel1"
                    Tela1 = 0
                Case "Tel2"
                    Tela2 = 0
                Case "Tel3"
                    Tela3 = 0
                Case "Tel4"
                    Tela4 = 0
                Case "Tel5"
                    Tela5 = 0
                Case "Tel6"
                    Tela6 = 0
                Case "Tel7"
                    Tela7 = 0
                Case "Tel8"
                    Tela8 = 0
                Case "Tel9"
                    Tela9 = 0
            End Select
            Draw = Image.FromFile("Circulo.png")
            Ganhou(Joga_Vez)
            Joga_Vez = 1
            Form1.Circulo.Visible = False
            Form1.X.Visible = True
            Form1.Label1.Text = Jogador2 & ", é a sua vez"
        Else
            Select Case Tela
                Case "Tel1"
                    Tela1 = 1
                Case "Tel2"
                    Tela2 = 1
                Case "Tel3"
                    Tela3 = 1
                Case "Tel4"
                    Tela4 = 1
                Case "Tel5"
                    Tela5 = 1
                Case "Tel6"
                    Tela6 = 1
                Case "Tel7"
                    Tela7 = 1
                Case "Tel8"
                    Tela8 = 1
                Case "Tel9"
                    Tela9 = 1
            End Select
            Draw = Image.FromFile("x.png")
            Ganhou(Joga_Vez)
            Joga_Vez = 0
            Form1.Circulo.Visible = True
            Form1.X.Visible = False
            Form1.Label1.Text = Jogador1 & ", é a sua vez"
        End If
    End Function
    Public Sub liga_desliga(ByVal Valor As Boolean)
        If Valor = True Then
            Form1.Tel1.Enabled = True
            Form1.Tel2.Enabled = True
            Form1.Tel3.Enabled = True
            Form1.Tel4.Enabled = True
            Form1.Tel5.Enabled = True
            Form1.Tel6.Enabled = True
            Form1.Tel7.Enabled = True
            Form1.Tel8.Enabled = True
            Form1.Tel9.Enabled = True
        Else
            Form1.Tel1.Enabled = False
            Form1.Tel2.Enabled = False
            Form1.Tel3.Enabled = False
            Form1.Tel4.Enabled = False
            Form1.Tel5.Enabled = False
            Form1.Tel6.Enabled = False
            Form1.Tel7.Enabled = False
            Form1.Tel8.Enabled = False
            Form1.Tel9.Enabled = False
        End If
    End Sub
    Public Sub lima_tabuleiro()
        Tela1 = 3
        Tela2 = 3
        Tela3 = 3
        Tela4 = 3
        Tela5 = 3
        Tela6 = 3
        Tela7 = 3
        Tela8 = 3
        Tela9 = 3

        Form1.Tel1.Image = Form1.PictureBox1.Image
        Form1.Tel2.Image = Form1.PictureBox1.Image
        Form1.Tel3.Image = Form1.PictureBox1.Image
        Form1.Tel4.Image = Form1.PictureBox1.Image
        Form1.Tel5.Image = Form1.PictureBox1.Image
        Form1.Tel6.Image = Form1.PictureBox1.Image
        Form1.Tel7.Image = Form1.PictureBox1.Image
        Form1.Tel8.Image = Form1.PictureBox1.Image
        Form1.Tel9.Image = Form1.PictureBox1.Image
    End Sub
    Public Sub Ganhou(ByVal Jogador As Integer)
        If Jogador = 0 Then
            If Tela1 = 0 And Tela2 = 0 And Tela3 = 0 Then
                liga_desliga(False)
                PlacarJoga_1 = PlacarJoga_1 + 1
                Form1.Label2.Text = PlacarJoga_1
                MsgBox("Parabéns " & Jogador1 & ", você venceu esta rodada.", MsgBoxStyle.Information, "Você venceu!!!")
            ElseIf Tela4 = 0 And Tela5 = 0 And Tela6 = 0 Then
                liga_desliga(False)
                PlacarJoga_1 = PlacarJoga_1 + 1
                Form1.Label2.Text = PlacarJoga_1
                MsgBox("Parabéns " & Jogador1 & ", você venceu esta rodada.", MsgBoxStyle.Information, "Você venceu!!!")
            ElseIf Tela7 = 0 And Tela8 = 0 And Tela9 = 0 Then
                liga_desliga(False)
                PlacarJoga_1 = PlacarJoga_1 + 1
                Form1.Label2.Text = PlacarJoga_1
                MsgBox("Parabéns " & Jogador1 & ", você venceu esta rodada.", MsgBoxStyle.Information, "Você venceu!!!")
            ElseIf Tela1 = 0 And Tela4 = 0 And Tela7 = 0 Then
                liga_desliga(False)
                PlacarJoga_1 = PlacarJoga_1 + 1
                Form1.Label2.Text = PlacarJoga_1
                MsgBox("Parabéns " & Jogador1 & ", você venceu esta rodada.", MsgBoxStyle.Information, "Você venceu!!!")
            ElseIf Tela2 = 0 And Tela5 = 0 And Tela8 = 0 Then
                liga_desliga(False)
                PlacarJoga_1 = PlacarJoga_1 + 1
                Form1.Label2.Text = PlacarJoga_1
                MsgBox("Parabéns " & Jogador1 & ", você venceu esta rodada.", MsgBoxStyle.Information, "Você venceu!!!")
            ElseIf Tela3 = 0 And Tela6 = 0 And Tela9 = 0 Then
                liga_desliga(False)
                PlacarJoga_1 = PlacarJoga_1 + 1
                Form1.Label2.Text = PlacarJoga_1
                MsgBox("Parabéns " & Jogador1 & ", você venceu esta rodada.", MsgBoxStyle.Information, "Você venceu!!!")
            ElseIf Tela1 = 0 And Tela5 = 0 And Tela9 = 0 Then
                liga_desliga(False)
                PlacarJoga_1 = PlacarJoga_1 + 1
                Form1.Label2.Text = PlacarJoga_1
                MsgBox("Parabéns " & Jogador1 & ", você venceu esta rodada.", MsgBoxStyle.Information, "Você venceu!!!")
            ElseIf Tela3 = 0 And Tela5 = 0 And Tela7 = 0 Then
                liga_desliga(False)
                PlacarJoga_1 = PlacarJoga_1 + 1
                Form1.Label2.Text = PlacarJoga_1
                MsgBox("Parabéns " & Jogador1 & ", você venceu esta rodada.", MsgBoxStyle.Information, "Você venceu!!!")
            End If


        Else


            If Tela1 = 1 And Tela2 = 1 And Tela3 = 1 Then
                liga_desliga(False)
                PlacarJoga_2 = PlacarJoga_2 + 1
                Form1.Label3.Text = PlacarJoga_2
                MsgBox("Parabéns " & Jogador2 & ", você venceu esta rodada.", MsgBoxStyle.Information, "Você venceu!!!")
            ElseIf Tela4 = 1 And Tela5 = 1 And Tela6 = 1 Then
                liga_desliga(False)
                PlacarJoga_2 = PlacarJoga_2 + 1
                Form1.Label3.Text = PlacarJoga_2
                MsgBox("Parabéns " & Jogador2 & ", você venceu esta rodada.", MsgBoxStyle.Information, "Você venceu!!!")
            ElseIf Tela7 = 1 And Tela8 = 1 And Tela9 = 1 Then
                liga_desliga(False)
                PlacarJoga_2 = PlacarJoga_2 + 1
                Form1.Label3.Text = PlacarJoga_2
                MsgBox("Parabéns " & Jogador2 & ", você venceu esta rodada.", MsgBoxStyle.Information, "Você venceu!!!")
            ElseIf Tela1 = 1 And Tela4 = 1 And Tela7 = 1 Then
                liga_desliga(False)
                PlacarJoga_2 = PlacarJoga_2 + 1
                Form1.Label3.Text = PlacarJoga_2
                MsgBox("Parabéns " & Jogador2 & ", você venceu esta rodada.", MsgBoxStyle.Information, "Você venceu!!!")
            ElseIf Tela2 = 1 And Tela5 = 1 And Tela8 = 1 Then
                liga_desliga(False)
                PlacarJoga_2 = PlacarJoga_2 + 1
                Form1.Label3.Text = PlacarJoga_2
                MsgBox("Parabéns " & Jogador2 & ", você venceu esta rodada.", MsgBoxStyle.Information, "Você venceu!!!")
            ElseIf Tela3 = 1 And Tela6 = 1 And Tela9 = 1 Then
                liga_desliga(False)
                PlacarJoga_2 = PlacarJoga_2 + 1
                Form1.Label3.Text = PlacarJoga_2
                MsgBox("Parabéns " & Jogador2 & ", você venceu esta rodada.", MsgBoxStyle.Information, "Você venceu!!!")
            ElseIf Tela1 = 1 And Tela5 = 1 And Tela9 = 1 Then
                liga_desliga(False)
                PlacarJoga_2 = PlacarJoga_2 + 1
                Form1.Label3.Text = PlacarJoga_2
                MsgBox("Parabéns " & Jogador2 & ", você venceu esta rodada.", MsgBoxStyle.Information, "Você venceu!!!")
            ElseIf Tela3 = 1 And Tela5 = 1 And Tela7 = 1 Then
                liga_desliga(False)
                PlacarJoga_2 = PlacarJoga_2 + 1
                Form1.Label3.Text = PlacarJoga_2
                MsgBox("Parabéns " & Jogador2 & ", você venceu esta rodada.", MsgBoxStyle.Information, "Você venceu!!!")
            End If
        End If
        Velha()
    End Sub
    Public Sub limpa_tudo()
        Joga_Vez = 0
        PlacarJoga_1 = 0
        PlacarJoga_2 = 0
        lima_tabuleiro()
        liga_desliga(False)
        Form1.Joga1.Text = ""
        Form1.Joga2.Text = ""
        Form1.Label2.Text = "0"
        Form1.Label3.Text = "0"
    End Sub
    Public Sub Velha()
        Dim res As Integer = Tela1 + Tela2 + Tela3 + Tela4 + Tela5 + Tela6 + Tela7 + Tela8 + Tela9
        If res = 5 Or res = 4 Then
            MsgBox("Ninguém venceu esta rodada", MsgBoxStyle.Exclamation, "Deu velha!!!")
        End If
    End Sub
End Module
