<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
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
        Me.dataBulanan = New System.Windows.Forms.Button()
        Me.dataTahunan = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InputDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputDataNasabahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputDataTagihanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Tagihan"
        '
        'dataBulanan
        '
        Me.dataBulanan.Location = New System.Drawing.Point(158, 153)
        Me.dataBulanan.Name = "dataBulanan"
        Me.dataBulanan.Size = New System.Drawing.Size(151, 27)
        Me.dataBulanan.TabIndex = 2
        Me.dataBulanan.Text = "Data Tagihan Bulanan"
        Me.dataBulanan.UseVisualStyleBackColor = True
        '
        'dataTahunan
        '
        Me.dataTahunan.Location = New System.Drawing.Point(158, 186)
        Me.dataTahunan.Name = "dataTahunan"
        Me.dataTahunan.Size = New System.Drawing.Size(151, 27)
        Me.dataTahunan.TabIndex = 4
        Me.dataTahunan.Text = "Data Tagihan Tahunan"
        Me.dataTahunan.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputDataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(475, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InputDataToolStripMenuItem
        '
        Me.InputDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputDataNasabahToolStripMenuItem, Me.InputDataTagihanToolStripMenuItem})
        Me.InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        Me.InputDataToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.InputDataToolStripMenuItem.Text = "Input Data"
        '
        'InputDataNasabahToolStripMenuItem
        '
        Me.InputDataNasabahToolStripMenuItem.Name = "InputDataNasabahToolStripMenuItem"
        Me.InputDataNasabahToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.InputDataNasabahToolStripMenuItem.Text = "Input data nasabah"
        '
        'InputDataTagihanToolStripMenuItem
        '
        Me.InputDataTagihanToolStripMenuItem.Name = "InputDataTagihanToolStripMenuItem"
        Me.InputDataTagihanToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.InputDataTagihanToolStripMenuItem.Text = "Input data tagihan"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 368)
        Me.Controls.Add(Me.dataTahunan)
        Me.Controls.Add(Me.dataBulanan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "SiKredit"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dataBulanan As System.Windows.Forms.Button
    Friend WithEvents dataTahunan As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputDataNasabahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputDataTagihanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
