<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.CrystalReport42 = New SKRIPSI_LOGISTIK_SENPI.CrystalReport4()
        Me.CrystalReport41 = New SKRIPSI_LOGISTIK_SENPI.CrystalReport4()
        Me.btn_cetak_log = New System.Windows.Forms.Button()
        Me.btn_cetak_pin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_cetak_log
        '
        Me.btn_cetak_log.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cetak_log.Location = New System.Drawing.Point(104, 37)
        Me.btn_cetak_log.Name = "btn_cetak_log"
        Me.btn_cetak_log.Size = New System.Drawing.Size(237, 59)
        Me.btn_cetak_log.TabIndex = 0
        Me.btn_cetak_log.Text = "PRINT DATA LOGISTIK"
        Me.btn_cetak_log.UseVisualStyleBackColor = True
        '
        'btn_cetak_pin
        '
        Me.btn_cetak_pin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cetak_pin.Location = New System.Drawing.Point(104, 112)
        Me.btn_cetak_pin.Name = "btn_cetak_pin"
        Me.btn_cetak_pin.Size = New System.Drawing.Size(237, 59)
        Me.btn_cetak_pin.TabIndex = 1
        Me.btn_cetak_pin.Text = "PRINT DATA PINJAM"
        Me.btn_cetak_pin.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 227)
        Me.Controls.Add(Me.btn_cetak_pin)
        Me.Controls.Add(Me.btn_cetak_log)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HALAMAN BA UR LOG"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReport41 As SKRIPSI_LOGISTIK_SENPI.CrystalReport4
    Friend WithEvents CrystalReport42 As SKRIPSI_LOGISTIK_SENPI.CrystalReport4
    Friend WithEvents btn_cetak_log As System.Windows.Forms.Button
    Friend WithEvents btn_cetak_pin As System.Windows.Forms.Button
End Class
