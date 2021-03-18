Public Class Form1
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form2.Show()
    End Sub

    Private Sub Tel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tel1.Click
        Tel1.Image = Draw(Joga_Vez, "Tel1")
        Tel1.Enabled = False
    End Sub

    Private Sub Tel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tel2.Click
        Tel2.Image = Draw(Joga_Vez, "Tel2")
        Tel2.Enabled = False
    End Sub

    Private Sub Tel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tel3.Click
        Tel3.Image = Draw(Joga_Vez, "Tel3")
        Tel3.Enabled = False
    End Sub

    Private Sub Tel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tel4.Click
        Tel4.Image = Draw(Joga_Vez, "Tel4")
        Tel4.Enabled = False
    End Sub

    Private Sub Tel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tel5.Click
        Tel5.Image = Draw(Joga_Vez, "Tel5")
        Tel5.Enabled = False
    End Sub

    Private Sub Tel6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tel6.Click
        Tel6.Image = Draw(Joga_Vez, "Tel6")
        Tel6.Enabled = False
    End Sub

    Private Sub Tel7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tel7.Click
        Tel7.Image = Draw(Joga_Vez, "Tel7")
        Tel7.Enabled = False
    End Sub

    Private Sub Tel8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tel8.Click
        Tel8.Image = Draw(Joga_Vez, "Tel8")
        Tel8.Enabled = False
    End Sub

    Private Sub Tel9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tel9.Click
        Tel9.Image = Draw(Joga_Vez, "Tel9")
        Tel9.Enabled = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MsgBox("Deseja realmente sair?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Tem Certeza") = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        lima_tabuleiro()
        liga_desliga(True)
    End Sub
End Class
