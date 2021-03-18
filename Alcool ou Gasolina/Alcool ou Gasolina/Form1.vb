Imports System.Globalization

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblResultado.Visible = False
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Declara variaveis
        Dim vlralcool As Decimal
        Dim vlrgas As Decimal
        Dim resultado As Decimal

        'Atribui valor as variaveis
        vlralcool = Convert.ToDecimal(tbAlcool.Text,CultureInfo.InvariantCulture)
        vlrgas = Convert.ToDecimal(tbGasolina.Text, CultureInfo.InvariantCulture)
        resultado = vlralcool / vlrgas

        'Faz a operação
        If resultado > 0.07 Then
            lblResultado.Text = UCase("Abasteça com Alcool")
            lblResultado.Visible = True
            lblResultado.ForeColor = Color.Green
        Else
            lblResultado.Text = UCase("Abasteça com Gasolina")
            lblResultado.Visible = True
            lblResultado.ForeColor = Color.Green
        End If
    End Sub
End Class
