Public Class Form

    Private Sub InputDataTagihanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputDataTagihanToolStripMenuItem.Click
        inputDataTagihan.ShowDialog()
    End Sub

    Private Sub InputDataNasabahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputDataNasabahToolStripMenuItem.Click
        inputDataNasabah.ShowDialog()
    End Sub

    Private Sub dataBulanan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dataBulanan.Click
        dataTagihanBulanan.ShowDialog()
    End Sub

    Private Sub dataTahunan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dataTahunan.Click
        dataTagihanTahunan.ShowDialog()
    End Sub
End Class
