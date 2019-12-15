Public Class Principal

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub btnDuplaSena_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDuplaSena.Click
        DuplaSena.Show()
        Me.Hide()
    End Sub

    Private Sub btnLoteca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoteca.Click
        Loteca.Show()
        Me.Hide()
    End Sub

    Private Sub btnLotofacil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLotofacil.Click
        Lotofacil.Show()
        Me.Hide()
    End Sub

    Private Sub btnLotogol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLotogol.Click
        Lotogol.Show()
        Me.Hide()
    End Sub

    Private Sub btnTimemania_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimemania.Click
        Timemania.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.facebook.com/pages/Dr-Hardware/385320148204842?bookmark_t=page")
    End Sub
End Class