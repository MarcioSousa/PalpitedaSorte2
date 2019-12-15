Public Class Timemania
    Dim time(80) As String
    Dim numerotm(6) As Integer

    Private Sub ordenacao()
        Dim reserva As Integer
        For t = 0 To 5
            If numerotm(t) > numerotm(t + 1) Then
                reserva = numerotm(t)
                numerotm(t) = numerotm(t + 1)
                numerotm(t + 1) = reserva
                t = -1
            End If
        Next

    End Sub

    Private Sub btnJogar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJogar.Click
        Dim repeticao As Boolean = True
        Dim timedocoracao As Integer

        While repeticao
            repeticao = False
            For t = 0 To 6
                numerotm(t) = CStr(Int(Rnd() * 81))
                If numerotm(t) = 0 Then
                    t = t - 1
                    repeticao = True
                End If
            Next
            ordenacao()
            For t = 0 To 5
                If numerotm(t) = numerotm(t + 1) Then
                    numerotm(t + 1) = CStr(Int(Rnd() * 81))
                    repeticao = True
                End If
            Next
        End While


        '------------------------TIME DO CORAÇÃO---------------
        Time_Coracao()
        For t = 0 To 0
            timedocoracao = CStr(Int(Rnd() * 81))
            If timedocoracao = 0 Then
                t = -1
            End If
        Next



        lblTimeN.Text = timedocoracao
        lblTimeM.Text = time(timedocoracao)

        Label1.Text = numerotm(0)
        Label2.Text = numerotm(1)
        Label3.Text = numerotm(2)
        Label4.Text = numerotm(3)
        Label5.Text = numerotm(4)
        Label6.Text = numerotm(5)
        Label7.Text = numerotm(6)

    End Sub

    Private Sub Time_Coracao()
        time(1) = "FLAMENGO/RJ"
        time(2) = "CORINTHIANS/SP"
        time(3) = "SAO PAULO/SP"
        time(4) = "SANTOS/SP"
        time(5) = "PALMEIRAS/SP"
        time(6) = "GREMIO/RS"
        time(7) = "VASCO DA GAMA/RJ"
        time(8) = "INTERNACIONAL/RS	"
        time(9) = "CRUZEIRO/MG"
        time(10) = "BOTAFOGO/RJ"
        time(11) = "ATLETICO/MG"
        time(12) = "FLUMINENSE/RJ"
        time(13) = "BAHIA/BA"
        time(14) = "FORTALEZA/CE"
        time(15) = "GOIAS/GO"
        time(16) = "ATLETICO/PR"
        time(17) = "CORITIBA/PR"
        time(18) = "VITORIA/BA"
        time(19) = "ABC/RN"
        time(20) = "CEARA/CE"
        time(21) = "AVAI/SC"
        time(22) = "SANTA CRUZ/PE"
        time(23) = "TREZE/PB"
        time(24) = "GUARANI/SP"
        time(25) = "SPORT/PE"
        time(26) = "ATLETICO/GO"
        time(27) = "GAMA/DF"
        time(28) = "LONDRINA/PR"
        time(29) = "NAUTICO/PE"
        time(30) = "PORT DESPORT/SP"
        time(31) = "AMERICA/RJ"
        time(32) = "JOINVILLE/SC"
        time(33) = "REMO/PA"
        time(34) = "AMERICA/MG"
        time(35) = "BOTAFOGO/PB"
        time(36) = "JUVENTUDE/RS"
        time(37) = "BANGU/RJ"
        time(38) = "MOTO CLUBE/MA"
        time(39) = "RIVER/PI"
        time(40) = "PONTE PRETA/SP"
        time(41) = "AMERICA/RN"
        time(42) = "MARILIA/SP"
        time(43) = "ITUANO/SP"
        time(44) = "INTER LIMEIRA/SP"
        time(45) = "IPATINGA/MG"
        time(46) = "SAO CAETANO/SP"
        time(47) = "JI-PARANA/RO"
        time(48) = "PAYSANDU/PA"
        time(49) = "FIGUEIRENSE/SC"
        time(50) = "SANTO ANDRE/SP"
        time(51) = "SAMP CORREA/MA"
        time(52) = "BRAGANTINO/SP"
        time(53) = "JUVENTUS/SP"
        time(54) = "CRICIUMA/SC"
        time(55) = "PARANA/PR"
        time(56) = "MIXTO/MT"
        time(57) = "BRASILIENSE/DF"
        time(58) = "PALMAS/TO"
        time(59) = "SERGIPE/SE"
        time(60) = "AMERICANO/RJ"
        time(61) = "VILA NOVA/GO"
        time(62) = "RIO BRANCO/ES"
        time(63) = "BARUERI/SP"
        time(64) = "S RAIMUNDO/AM"
        time(65) = "OLARIA/RJ"
        time(66) = "NACIONAL/AM"
        time(67) = "TUNA LUSO/PA"
        time(68) = "CRB/AL"
        time(69) = "RORAIMA/RR"
        time(70) = "UBERLANDIA/MG"
        time(71) = "OPERARIO/MS"
        time(72) = "RIO BRANCO/AC"
        time(73) = "YPIRANGA/AP"
        time(74) = "CSA/AL"
        time(75) = "XV PIRACICABA/SP"
        time(76) = "UNIAO S JOAO/SP"
        time(77) = "DESPORTIVA/ES"
        time(78) = "VILLA NOVA/MG"
        time(79) = "PAULISTA/SP"
        time(80) = "U BARBARENSE/SP"
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        MessageBox.Show("Desejamos boa sorte", "Boa Sorte", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Principal.Show()
        Close()
    End Sub

    Private Sub Timemania_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

End Class