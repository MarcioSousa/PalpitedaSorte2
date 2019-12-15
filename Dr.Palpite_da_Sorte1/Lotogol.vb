Public Class Lotogol
    Dim loto(9) As Integer

    Private Sub carregamento_loto()
        For t = 0 To 9
            loto(t) = CStr(Int(Rnd() * 100))
        Next
    End Sub

    Private Sub limpa_campos()
        lbl10.BackColor = Color.White
        lbl11.BackColor = Color.White
        lbl12.BackColor = Color.White
        lbl13.BackColor = Color.White
        lbl14.BackColor = Color.White
        lbl100.BackColor = Color.White
        lbl101.BackColor = Color.White
        lbl102.BackColor = Color.White
        lbl103.BackColor = Color.White
        lbl104.BackColor = Color.White

        lbl20.BackColor = Color.White
        lbl21.BackColor = Color.White
        lbl22.BackColor = Color.White
        lbl23.BackColor = Color.White
        lbl24.BackColor = Color.White
        lbl200.BackColor = Color.White
        lbl201.BackColor = Color.White
        lbl202.BackColor = Color.White
        lbl203.BackColor = Color.White
        lbl204.BackColor = Color.White

        lbl30.BackColor = Color.White
        lbl31.BackColor = Color.White
        lbl32.BackColor = Color.White
        lbl33.BackColor = Color.White
        lbl34.BackColor = Color.White
        lbl300.BackColor = Color.White
        lbl301.BackColor = Color.White
        lbl302.BackColor = Color.White
        lbl303.BackColor = Color.White
        lbl304.BackColor = Color.White

        lbl40.BackColor = Color.White
        lbl41.BackColor = Color.White
        lbl42.BackColor = Color.White
        lbl43.BackColor = Color.White
        lbl44.BackColor = Color.White
        lbl400.BackColor = Color.White
        lbl401.BackColor = Color.White
        lbl402.BackColor = Color.White
        lbl403.BackColor = Color.White
        lbl404.BackColor = Color.White

        lbl50.BackColor = Color.White
        lbl51.BackColor = Color.White
        lbl52.BackColor = Color.White
        lbl53.BackColor = Color.White
        lbl54.BackColor = Color.White
        lbl500.BackColor = Color.White
        lbl501.BackColor = Color.White
        lbl502.BackColor = Color.White
        lbl503.BackColor = Color.White
        lbl504.BackColor = Color.White
    End Sub
 
    Private Sub btnJogar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJogar.Click
        '30% = 0, 25% = 1, 20% = 2, 13% = 3, 12% = +

        limpa_campos()
        carregamento_loto()
        For t = 0 To 0
            If loto(t) < 30 Then
                lbl10.BackColor = Color.Blue
            ElseIf loto(t) < 55 Then
                lbl11.BackColor = Color.Blue
            ElseIf loto(t) < 75 Then
                lbl12.BackColor = Color.Blue
            ElseIf loto(t) < 88 Then
                lbl13.BackColor = Color.Blue
            Else
                lbl14.BackColor = Color.Blue
            End If
        Next

        For t = 1 To 1
            If loto(t) < 30 Then
                lbl100.BackColor = Color.Blue
            ElseIf loto(t) < 55 Then
                lbl101.BackColor = Color.Blue
            ElseIf loto(t) < 75 Then
                lbl102.BackColor = Color.Blue
            ElseIf loto(t) < 88 Then
                lbl103.BackColor = Color.Blue
            Else
                lbl104.BackColor = Color.Blue
            End If
        Next

        For t = 2 To 2
            If loto(t) < 30 Then
                lbl20.BackColor = Color.Blue
            ElseIf loto(t) < 55 Then
                lbl21.BackColor = Color.Blue
            ElseIf loto(t) < 75 Then
                lbl22.BackColor = Color.Blue
            ElseIf loto(t) < 88 Then
                lbl23.BackColor = Color.Blue
            Else
                lbl24.BackColor = Color.Blue
            End If
        Next

        For t = 3 To 3
            If loto(t) < 30 Then
                lbl200.BackColor = Color.Blue
            ElseIf loto(t) < 55 Then
                lbl201.BackColor = Color.Blue
            ElseIf loto(t) < 75 Then
                lbl202.BackColor = Color.Blue
            ElseIf loto(t) < 88 Then
                lbl203.BackColor = Color.Blue
            Else
                lbl204.BackColor = Color.Blue
            End If
        Next

        For t = 4 To 4
            If loto(t) < 30 Then
                lbl30.BackColor = Color.Blue
            ElseIf loto(t) < 55 Then
                lbl31.BackColor = Color.Blue
            ElseIf loto(t) < 75 Then
                lbl32.BackColor = Color.Blue
            ElseIf loto(t) < 88 Then
                lbl33.BackColor = Color.Blue
            Else
                lbl34.BackColor = Color.Blue
            End If
        Next

        For t = 5 To 5
            If loto(t) < 30 Then
                lbl300.BackColor = Color.Blue
            ElseIf loto(t) < 55 Then
                lbl301.BackColor = Color.Blue
            ElseIf loto(t) < 75 Then
                lbl302.BackColor = Color.Blue
            ElseIf loto(t) < 88 Then
                lbl303.BackColor = Color.Blue
            Else
                lbl304.BackColor = Color.Blue
            End If
        Next

        For t = 6 To 6
            If loto(t) < 30 Then
                lbl40.BackColor = Color.Blue
            ElseIf loto(t) < 55 Then
                lbl41.BackColor = Color.Blue
            ElseIf loto(t) < 75 Then
                lbl42.BackColor = Color.Blue
            ElseIf loto(t) < 88 Then
                lbl43.BackColor = Color.Blue
            Else
                lbl44.BackColor = Color.Blue
            End If
        Next

        For t = 7 To 7
            If loto(t) < 30 Then
                lbl400.BackColor = Color.Blue
            ElseIf loto(t) < 55 Then
                lbl401.BackColor = Color.Blue
            ElseIf loto(t) < 75 Then
                lbl402.BackColor = Color.Blue
            ElseIf loto(t) < 88 Then
                lbl403.BackColor = Color.Blue
            Else
                lbl404.BackColor = Color.Blue
            End If
        Next

        For t = 8 To 8
            If loto(t) < 30 Then
                lbl50.BackColor = Color.Blue
            ElseIf loto(t) < 55 Then
                lbl51.BackColor = Color.Blue
            ElseIf loto(t) < 75 Then
                lbl52.BackColor = Color.Blue
            ElseIf loto(t) < 88 Then
                lbl53.BackColor = Color.Blue
            Else
                lbl54.BackColor = Color.Blue
            End If
        Next

        For t = 9 To 9
            If loto(t) < 30 Then
                lbl500.BackColor = Color.Blue
            ElseIf loto(t) < 55 Then
                lbl501.BackColor = Color.Blue
            ElseIf loto(t) < 75 Then
                lbl502.BackColor = Color.Blue
            ElseIf loto(t) < 88 Then
                lbl503.BackColor = Color.Blue
            Else
                lbl504.BackColor = Color.Blue
            End If
        Next
    End Sub

    Private Sub Lotogol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        MessageBox.Show("Desejamos boa sorte", "Boa Sorte", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Principal.Show()
        Close()
    End Sub
End Class