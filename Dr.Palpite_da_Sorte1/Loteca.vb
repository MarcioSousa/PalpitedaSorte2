Public Class Loteca
    Dim sorteio(14) As Integer
    Dim campos(42) As String
    Dim especial As Integer

    Private Sub limpa_campos()
        Label1.BackColor = Color.White
        Label2.BackColor = Color.White
        Label3.BackColor = Color.White
        Label4.BackColor = Color.White
        Label5.BackColor = Color.White
        Label6.BackColor = Color.White
        Label7.BackColor = Color.White
        Label8.BackColor = Color.White
        Label9.BackColor = Color.White
        Label10.BackColor = Color.White
        Label11.BackColor = Color.White
        Label12.BackColor = Color.White
        Label13.BackColor = Color.White
        Label14.BackColor = Color.White
        Label15.BackColor = Color.White
        Label16.BackColor = Color.White
        Label17.BackColor = Color.White
        Label18.BackColor = Color.White
        Label19.BackColor = Color.White
        Label20.BackColor = Color.White
        Label21.BackColor = Color.White
        Label22.BackColor = Color.White
        Label23.BackColor = Color.White
        Label24.BackColor = Color.White
        Label25.BackColor = Color.White
        Label26.BackColor = Color.White
        Label27.BackColor = Color.White
        Label28.BackColor = Color.White
        Label29.BackColor = Color.White
        Label30.BackColor = Color.White
        Label31.BackColor = Color.White
        Label32.BackColor = Color.White
        Label33.BackColor = Color.White
        Label34.BackColor = Color.White
        Label35.BackColor = Color.White
        Label36.BackColor = Color.White
        Label37.BackColor = Color.White
        Label38.BackColor = Color.White
        Label39.BackColor = Color.White
        Label40.BackColor = Color.White
        Label41.BackColor = Color.White
        Label42.BackColor = Color.White

    End Sub

    Private Sub btnJogar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJogar.Click
        Dim passou As Boolean = True
        limpa_campos()

        '-------------linha 01----------
        sorteio(1) = CStr(Int(Rnd() * 3))
        If sorteio(1) = 1 Then
            Label1.BackColor = Color.Blue
        ElseIf sorteio(1) = 2 Then
            Label3.BackColor = Color.Blue
        Else
            Label2.BackColor = Color.Blue
        End If


        '-------------linha 02----------
        sorteio(2) = CStr(Int(Rnd() * 3))
        If sorteio(2) = 1 Then
            Label4.BackColor = Color.Blue
        ElseIf sorteio(2) = 2 Then
            Label6.BackColor = Color.Blue
        Else
            Label5.BackColor = Color.Blue
        End If


        '-------------linha 03----------
        sorteio(3) = CStr(Int(Rnd() * 3))
        If sorteio(3) = 1 Then
            Label7.BackColor = Color.Blue
        ElseIf sorteio(3) = 2 Then
            Label9.BackColor = Color.Blue
        Else
            Label8.BackColor = Color.Blue
        End If


        '-------------linha 04----------
        sorteio(4) = CStr(Int(Rnd() * 3))
        If sorteio(4) = 1 Then
            Label10.BackColor = Color.Blue
        ElseIf sorteio(4) = 2 Then
            Label12.BackColor = Color.Blue
        Else
            Label11.BackColor = Color.Blue
        End If


        '-------------linha 05----------
        sorteio(5) = CStr(Int(Rnd() * 3))
        If sorteio(5) = 1 Then
            Label13.BackColor = Color.Blue
        ElseIf sorteio(5) = 2 Then
            Label15.BackColor = Color.Blue
        Else
            Label14.BackColor = Color.Blue
        End If


        '-------------linha 06----------
        sorteio(6) = CStr(Int(Rnd() * 3))
        If sorteio(6) = 1 Then
            Label16.BackColor = Color.Blue
        ElseIf sorteio(6) = 2 Then
            Label18.BackColor = Color.Blue
        Else
            Label17.BackColor = Color.Blue
        End If


        '-------------linha 07----------
        sorteio(7) = CStr(Int(Rnd() * 3))
        If sorteio(7) = 1 Then
            Label19.BackColor = Color.Blue
        ElseIf sorteio(7) = 2 Then
            Label21.BackColor = Color.Blue
        Else
            Label20.BackColor = Color.Blue
        End If


        '-------------linha 08----------
        sorteio(8) = CStr(Int(Rnd() * 3))
        If sorteio(8) = 1 Then
            Label22.BackColor = Color.Blue
        ElseIf sorteio(8) = 2 Then
            Label24.BackColor = Color.Blue
        Else
            Label23.BackColor = Color.Blue
        End If


        '-------------linha 09----------
        sorteio(9) = CStr(Int(Rnd() * 3))
        If sorteio(9) = 1 Then
            Label25.BackColor = Color.Blue
        ElseIf sorteio(9) = 2 Then
            Label27.BackColor = Color.Blue
        Else
            Label26.BackColor = Color.Blue
        End If


        '-------------linha 10----------
        sorteio(10) = CStr(Int(Rnd() * 3))
        If sorteio(10) = 1 Then
            Label28.BackColor = Color.Blue
        ElseIf sorteio(10) = 2 Then
            Label30.BackColor = Color.Blue
        Else
            Label29.BackColor = Color.Blue
        End If


        '-------------linha 11----------
        sorteio(11) = CStr(Int(Rnd() * 3))
        If sorteio(11) = 1 Then
            Label31.BackColor = Color.Blue
        ElseIf sorteio(11) = 2 Then
            Label33.BackColor = Color.Blue
        Else
            Label32.BackColor = Color.Blue
        End If


        '-------------linha 12----------
        sorteio(12) = CStr(Int(Rnd() * 3))
        If sorteio(12) = 1 Then
            Label34.BackColor = Color.Blue
        ElseIf sorteio(12) = 2 Then
            Label36.BackColor = Color.Blue
        Else
            Label35.BackColor = Color.Blue
        End If


        '-------------linha 13----------
        sorteio(13) = CStr(Int(Rnd() * 3))
        If sorteio(13) = 1 Then
            Label37.BackColor = Color.Blue
        ElseIf sorteio(13) = 2 Then
            Label39.BackColor = Color.Blue
        Else
            Label38.BackColor = Color.Blue
        End If


        '-------------linha 14----------
        sorteio(14) = CStr(Int(Rnd() * 3))
        If sorteio(14) = 1 Then
            Label40.BackColor = Color.Blue
        ElseIf sorteio(14) = 2 Then
            Label42.BackColor = Color.Blue
        Else
            Label41.BackColor = Color.Blue
        End If

        '-----------------------------------------
        '---------O DUPLO ESPECIAL----------------
        For t = 1 To 1
            especial = CStr(Int(Rnd() * 43))
            If especial = 0 Then
                t = 0
            End If
        Next

        While passou = True
            passou = False

            If especial = 1 Then
                If Label1.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label1.BackColor = Color.Blue
                End If
            End If



            If especial = 2 Then
                If Label2.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 2 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label2.BackColor = Color.Blue
                End If
            End If


            If especial = 3 Then
                If Label3.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 3 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label3.BackColor = Color.Blue
                End If
            End If


            If especial = 4 Then
                If Label4.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 4 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label4.BackColor = Color.Blue
                End If
            End If


            If especial = 5 Then
                If Label5.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 5 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label5.BackColor = Color.Blue
                End If
            End If


            If especial = 6 Then
                If Label6.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 6 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label6.BackColor = Color.Blue
                End If
            End If


            If especial = 7 Then
                If Label7.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 7 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label7.BackColor = Color.Blue
                End If
            End If


            If especial = 8 Then
                If Label8.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 8 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label8.BackColor = Color.Blue
                End If
            End If


            If especial = 9 Then
                If Label9.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 9 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label9.BackColor = Color.Blue
                End If
            End If


            If especial = 10 Then
                If Label10.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 10 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label10.BackColor = Color.Blue
                End If
            End If


            If especial = 11 Then
                If Label11.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 11 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label11.BackColor = Color.Blue
                End If
            End If


            If especial = 12 Then
                If Label12.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 12 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label12.BackColor = Color.Blue
                End If
            End If


            If especial = 13 Then
                If Label13.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 13 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label13.BackColor = Color.Blue
                End If
            End If


            If especial = 14 Then
                If Label14.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 14 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label14.BackColor = Color.Blue
                End If
            End If


            If especial = 15 Then
                If Label15.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 15 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label15.BackColor = Color.Blue
                End If
            End If


            If especial = 16 Then
                If Label16.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 16 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label16.BackColor = Color.Blue
                End If
            End If


            If especial = 17 Then
                If Label17.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 17 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label17.BackColor = Color.Blue
                End If
            End If


            If especial = 18 Then
                If Label18.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 18 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label18.BackColor = Color.Blue
                End If
            End If


            If especial = 19 Then
                If Label19.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 19 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label19.BackColor = Color.Blue
                End If
            End If


            If especial = 20 Then
                If Label20.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 20 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label20.BackColor = Color.Blue
                End If
            End If


            If especial = 21 Then
                If Label21.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 21 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label21.BackColor = Color.Blue
                End If
            End If


            If especial = 22 Then
                If Label22.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 22 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label22.BackColor = Color.Blue
                End If
            End If


            If especial = 23 Then
                If Label23.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 23 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label23.BackColor = Color.Blue
                End If
            End If


            If especial = 24 Then
                If Label24.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 24 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label24.BackColor = Color.Blue
                End If
            End If


            If especial = 25 Then
                If Label25.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 25 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label25.BackColor = Color.Blue
                End If
            End If


            If especial = 26 Then
                If Label26.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 26 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label26.BackColor = Color.Blue
                End If
            End If


            If especial = 27 Then
                If Label27.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 27 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label27.BackColor = Color.Blue
                End If
            End If


            If especial = 28 Then
                If Label28.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 28 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label28.BackColor = Color.Blue
                End If
            End If


            If especial = 29 Then
                If Label29.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 29 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label29.BackColor = Color.Blue
                End If
            End If


            If especial = 30 Then
                If Label30.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 30 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label30.BackColor = Color.Blue
                End If
            End If


            If especial = 31 Then
                If Label31.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 31 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label31.BackColor = Color.Blue
                End If
            End If

            If especial = 32 Then
                If Label32.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 32 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label32.BackColor = Color.Blue
                End If
            End If


            If especial = 33 Then
                If Label33.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 33 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label33.BackColor = Color.Blue
                End If
            End If


            If especial = 34 Then
                If Label34.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 34 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label34.BackColor = Color.Blue
                End If
            End If


            If especial = 35 Then
                If Label35.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 35 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label35.BackColor = Color.Blue
                End If
            End If


            If especial = 36 Then
                If Label36.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 36 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label36.BackColor = Color.Blue
                End If
            End If


            If especial = 37 Then
                If Label37.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 37 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label37.BackColor = Color.Blue
                End If
            End If


            If especial = 38 Then
                If Label38.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 38 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label38.BackColor = Color.Blue
                End If
            End If


            If especial = 39 Then
                If Label39.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 39 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label39.BackColor = Color.Blue
                End If
            End If


            If especial = 40 Then
                If Label40.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 40 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label40.BackColor = Color.Blue
                End If
            End If


            If especial = 41 Then
                If Label41.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 41 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label41.BackColor = Color.Blue
                End If
            End If


            If especial = 42 Then
                If Label42.BackColor = Color.Blue Then
                    For t = 1 To 1
                        especial = CStr(Int(Rnd() * 43))
                        If especial < 42 Then
                            passou = True
                        End If
                        If especial = 0 Then
                            t = 0
                            passou = True
                        End If
                    Next
                Else
                    Label42.BackColor = Color.Blue
                End If
            End If

        End While

    End Sub

    Private Sub Loteca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        limpa_campos()
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        MessageBox.Show("Desejamos boa sorte", "Boa Sorte", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Principal.Show()
        Close()
    End Sub
End Class