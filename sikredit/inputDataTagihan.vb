Public Class inputDataTagihan

    Private Sub simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpan.Click
        Dim arr(2) As String
        arr(0) = cbCicilan.Text
        arr(1) = cbTenor.Text

        Dim namaNasabah As String = txtNama.Text
        Dim namaBarang As String = txtNamaBarang.Text
        Dim hargaBarang As Long = txtHarga.Text
        Dim tenor As Integer = Val(arr(1))

        Dim bunga As Single
        Dim textBunga As String

        If arr(0) = "Bulan" Then
            bunga = hargaBarang * 0.05
            textBunga = "5%"
        Else
            bunga = hargaBarang * 0.1
            textBunga = "10%"
        End If

        Dim angsuran As Integer = (hargaBarang / tenor) + bunga

        MessageBox.Show("Nama Nasabah: " & namaNasabah & vbCrLf &
                        "Nama Barang: " & namaBarang & vbCrLf &
                        "Harga Barang: " & hargaBarang & vbCrLf &
                        "Bunga: " & textBunga & vbCrLf &
                        "Tenor: " & tenor & arr(0) & vbCrLf &
                        "Angsuran: " & angsuran & "/" & arr(0) & vbCrLf,
                        "Hasil Total", MessageBoxButtons.OK, MessageBoxIcon.Information
                        )
    End Sub
End Class