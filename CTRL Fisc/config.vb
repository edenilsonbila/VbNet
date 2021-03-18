Imports System.Data.OleDb
Public Class config
    Dim cm As OleDbCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim vlr As Decimal

        If Not MaskedTextBox1.MaskCompleted Then
            MsgBox("Favor digite o valor da passagem", MsgBoxStyle.Information)
        Else
            vlr = Convert.ToDecimal(MaskedTextBox1.Text)
            Try
                cm = New OleDbCommand("update param set vlr='" & vlr & "'", conecta)
                cm.ExecuteNonQuery()
                MsgBox("Parâmetros Salvos com Sucesso", MsgBoxStyle.Information)
                Me.Close()
            Catch n As Exception
                MsgBox("Erro", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
End Class