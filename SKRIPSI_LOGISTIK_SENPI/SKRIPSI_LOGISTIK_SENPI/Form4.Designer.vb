<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.PtambahNoSenpi = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.txt_nomor_senjata = New System.Windows.Forms.TextBox()
        Me.cbx_id_logistik_senjata = New System.Windows.Forms.ComboBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.PtambahNoSenpi.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PtambahNoSenpi
        '
        Me.PtambahNoSenpi.Controls.Add(Me.Button4)
        Me.PtambahNoSenpi.Controls.Add(Me.Button2)
        Me.PtambahNoSenpi.Controls.Add(Me.DataGridView5)
        Me.PtambahNoSenpi.Controls.Add(Me.txt_nomor_senjata)
        Me.PtambahNoSenpi.Controls.Add(Me.cbx_id_logistik_senjata)
        Me.PtambahNoSenpi.Controls.Add(Me.Label55)
        Me.PtambahNoSenpi.Controls.Add(Me.Label54)
        Me.PtambahNoSenpi.Controls.Add(Me.Label53)
        Me.PtambahNoSenpi.Location = New System.Drawing.Point(2, 1)
        Me.PtambahNoSenpi.Name = "PtambahNoSenpi"
        Me.PtambahNoSenpi.Size = New System.Drawing.Size(613, 319)
        Me.PtambahNoSenpi.TabIndex = 36
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(212, 270)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "SIMPAN"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(293, 270)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "HAPUS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView5
        '
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(116, 123)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.Size = New System.Drawing.Size(390, 136)
        Me.DataGridView5.TabIndex = 5
        '
        'txt_nomor_senjata
        '
        Me.txt_nomor_senjata.Location = New System.Drawing.Point(175, 93)
        Me.txt_nomor_senjata.Name = "txt_nomor_senjata"
        Me.txt_nomor_senjata.Size = New System.Drawing.Size(245, 20)
        Me.txt_nomor_senjata.TabIndex = 4
        '
        'cbx_id_logistik_senjata
        '
        Me.cbx_id_logistik_senjata.FormattingEnabled = True
        Me.cbx_id_logistik_senjata.Location = New System.Drawing.Point(175, 62)
        Me.cbx_id_logistik_senjata.Name = "cbx_id_logistik_senjata"
        Me.cbx_id_logistik_senjata.Size = New System.Drawing.Size(246, 21)
        Me.cbx_id_logistik_senjata.TabIndex = 3
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(47, 92)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(109, 19)
        Me.Label55.TabIndex = 2
        Me.Label55.Text = "Nomor Senjata"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(47, 61)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(86, 19)
        Me.Label54.TabIndex = 1
        Me.Label54.Text = "ID Logistik"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(148, 8)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(291, 22)
        Me.Label53.TabIndex = 0
        Me.Label53.Text = "TAMBAH DATA NOMOR SENPI"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 320)
        Me.Controls.Add(Me.PtambahNoSenpi)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Nomor Senpi"
        Me.PtambahNoSenpi.ResumeLayout(False)
        Me.PtambahNoSenpi.PerformLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PtambahNoSenpi As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView5 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_nomor_senjata As System.Windows.Forms.TextBox
    Friend WithEvents cbx_id_logistik_senjata As System.Windows.Forms.ComboBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
End Class
