Public Class Lotofacil
    Dim numerolt(14) As Integer

    Private Sub arrumacao()
        Dim armazenam As Integer
        For t = 0 To 13
            If numerolt(t) > numerolt(t + 1) Then
                armazenam = numerolt(t)
                numerolt(t) = numerolt(t + 1)
                numerolt(t + 1) = armazenam
                t = -1
            End If
        Next
    End Sub

    Private Sub btnJogar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJogar.Click
        Dim modo As Boolean = True

        While modo
            modo = False
            For t = 0 To 14
                numerolt(t) = CStr(Int(Rnd() * 26))
                If numerolt(t) = 0 Then
                    t = t - 1
                    modo = True
                End If
            Next
            arrumacao()
            For t = 0 To 13
                If numerolt(t) = numerolt(t + 1) Then
                    numerolt(t + 1) = CStr(Int(Rnd() * 26))
                    modo = True
                End If
            Next
        End While

        Label1.Text = numerolt(0)
        Label2.Text = numerolt(1)
        Label3.Text = numerolt(2)
        Label4.Text = numerolt(3)
        Label5.Text = numerolt(4)
        Label6.Text = numerolt(5)
        Label7.Text = numerolt(6)
        Label8.Text = numerolt(7)
        Label9.Text = numerolt(8)
        Label10.Text = numerolt(9)
        Label11.Text = numerolt(10)
        Label12.Text = numerolt(11)
        Label13.Text = numerolt(12)
        Label14.Text = numerolt(13)
        Label15.Text = numerolt(14)

    End Sub

    Private Sub Lotofacil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        MessageBox.Show("Desejamos boa sorte", "Boa Sorte", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Principal.Show()
        Close()
    End Sub


End Class