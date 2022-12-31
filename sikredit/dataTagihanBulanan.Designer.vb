<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dataTagihanBulanan
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDTagihan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namaNasabah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sisaTagihan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.perbaharui = New System.Windows.Forms.Button()
        Me.kembali = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDTagihan, Me.namaNasabah, Me.NamaBarang, Me.totalHarga, Me.sisaTagihan})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(544, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'IDTagihan
        '
        Me.IDTagihan.HeaderText = "ID Tagihan"
        Me.IDTagihan.Name = "IDTagihan"
        '
        'namaNasabah
        '
        Me.namaNasabah.HeaderText = "Nama Nasabah"
        Me.namaNasabah.Name = "namaNasabah"
        '
        'NamaBarang
        '
        Me.NamaBarang.HeaderText = "Nama Barang"
        Me.NamaBarang.Name = "NamaBarang"
        '
        'totalHarga
        '
        Me.totalHarga.HeaderText = "Total Harga"
        Me.totalHarga.Name = "totalHarga"
        '
        'sisaTagihan
        '
        Me.sisaTagihan.HeaderText = "Sisa Tagihan"
        Me.sisaTagihan.Name = "sisaTagihan"
        '
        'perbaharui
        '
        Me.perbaharui.Location = New System.Drawing.Point(364, 238)
        Me.perbaharui.Name = "perbaharui"
        Me.perbaharui.Size = New System.Drawing.Size(93, 33)
        Me.perbaharui.TabIndex = 1
        Me.perbaharui.Text = "perbaharui"
        Me.perbaharui.UseVisualStyleBackColor = True
        '
        'kembali
        '
        Me.kembali.Location = New System.Drawing.Point(463, 238)
        Me.kembali.Name = "kembali"
        Me.kembali.Size = New System.Drawing.Size(93, 33)
        Me.kembali.TabIndex = 2
        Me.kembali.Text = "Kembali"
        Me.kembali.UseVisualStyleBackColor = True
        '
        'dataTagihanBulanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 386)
        Me.Controls.Add(Me.kembali)
        Me.Controls.Add(Me.perbaharui)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "dataTagihanBulanan"
        Me.Text = "Data Tagihan Bulanan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IDTagihan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namaNasabah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalHarga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sisaTagihan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents perbaharui As System.Windows.Forms.Button
    Friend WithEvents kembali As System.Windows.Forms.Button
End Class
