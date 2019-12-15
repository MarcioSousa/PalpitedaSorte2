Public Class DuplaSena
    Dim numerodd(5) As Integer

    Private Sub organizacao()
        Dim armaz As Integer
        For t = 0 To 4
            If numerodd(t) > numerodd(t + 1) Then
                armaz = numerodd(t)
                numerodd(t) = numerodd(t + 1)
                numerodd(t + 1) = armaz
                t = -1
            End If
        Next
    End Sub

    Private Sub btnJogar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJogar.Click
        Dim entrou As Boolean = True

        While entrou = True
            entrou = False
            For t = 0 To 5
                numerodd(t) = CStr(Int(Rnd() * 51))
                If numerodd(t) = 0 Then
                    t = t - 1
                    entrou = True
                End If
            Next
            organizacao()
            For t = 1 To 5
                If numerodd(t - 1) = numerodd(t) Then
                    numerodd(t) = CStr(Int(Rnd() * 51))
                    entrou = True
                End If
            Next
        End While

        Label1.Text = numerodd(0)
        Label2.Text = numerodd(1)
        Label3.Text = numerodd(2)
        Label4.Text = numerodd(3)
        Label5.Text = numerodd(4)
        Label6.Text = numerodd(5)

    End Sub

    Private Sub DuplaSena_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        MessageBox.Show("Desejamos boa sorte", "Boa Sorte", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Principal.Show()
        Close()
    End Sub
End Class