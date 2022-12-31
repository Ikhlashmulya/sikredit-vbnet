<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inputDataTagihan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdNasabah = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdTagihan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.simpan = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tanggal = New System.Windows.Forms.DateTimePicker()
        Me.cbCicilan = New System.Windows.Forms.ComboBox()
        Me.cbTenor = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Nasabah"
        '
        'txtIdNasabah
        '
        Me.txtIdNasabah.Location = New System.Drawing.Point(215, 103)
        Me.txtIdNasabah.Name = "txtIdNasabah"
        Me.txtIdNasabah.Size = New System.Drawing.Size(199, 20)
        Me.txtIdNasabah.TabIndex = 1
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(215, 141)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(199, 20)
        Me.txtNama.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Nasabah"
        '
        'txtIdTagihan
        '
        Me.txtIdTagihan.Location = New System.Drawing.Point(215, 181)
        Me.txtIdTagihan.Name = "txtIdTagihan"
        Me.txtIdTagihan.Size = New System.Drawing.Size(199, 20)
        Me.txtIdTagihan.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID Tagihan"
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Location = New System.Drawing.Point(215, 226)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Size = New System.Drawing.Size(199, 20)
        Me.txtNamaBarang.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(118, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nama Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(152, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(225, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "INPUT DATA TAGIHAN"
        '
        'simpan
        '
        Me.simpan.Location = New System.Drawing.Point(213, 451)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(85, 33)
        Me.simpan.TabIndex = 17
        Me.simpan.Text = "Simpan"
        Me.simpan.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(329, 451)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 33)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Kembali"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(215, 307)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(199, 20)
        Me.txtHarga.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(118, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Total Harga"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(118, 355)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Cicilan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(118, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Tanggal"
        '
        'tanggal
        '
        Me.tanggal.Location = New System.Drawing.Point(215, 266)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(199, 20)
        Me.tanggal.TabIndex = 9
        '
        'cbCicilan
        '
        Me.cbCicilan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCicilan.FormattingEnabled = True
        Me.cbCicilan.Items.AddRange(New Object() {"Tahun", "Bulan"})
        Me.cbCicilan.Location = New System.Drawing.Point(215, 352)
        Me.cbCicilan.Name = "cbCicilan"
        Me.cbCicilan.Size = New System.Drawing.Size(199, 21)
        Me.cbCicilan.TabIndex = 13
        '
        'cbTenor
        '
        Me.cbTenor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTenor.FormattingEnabled = True
        Me.cbTenor.Items.AddRange(New Object() {"3", "6", "9", "12", "15"})
        Me.cbTenor.Location = New System.Drawing.Point(215, 397)
        Me.cbTenor.Name = "cbTenor"
        Me.cbTenor.Size = New System.Drawing.Size(199, 21)
        Me.cbTenor.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(118, 400)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Tenor"
        '
        'inputDataTagihan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 540)
        Me.Controls.Add(Me.cbTenor)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbCicilan)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNamaBarang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtIdTagihan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdNasabah)
        Me.Controls.Add(Me.Label1)
        Me.Name = "inputDataTagihan"
        Me.Text = "Input Data Nasabah"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIdNasabah As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIdTagihan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents simpan As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbCicilan As System.Windows.Forms.ComboBox
    Friend WithEvents cbTenor As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
