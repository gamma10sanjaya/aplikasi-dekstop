Imports System.Data.Odbc
Public Class Form4
    Dim con As OdbcConnection
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As OdbcCommand

    Sub koneksi()
        con = New OdbcConnection
        con.ConnectionString = "dsn=db_logistik_kompi"
        con.Open()
    End Sub
    Sub tampilsenpi()
        cmd = New OdbcCommand("select tb_logistik_id from tb_logistik", con)
        dr = cmd.ExecuteReader
        cbx_id_logistik_senjata.Items.Clear()
        Do While dr.Read
            cbx_id_logistik_senjata.Items.Add(dr.Item("tb_logistik_id"))
        Loop
    End Sub
    Sub tampil_nomor_senpi()
        Call koneksi()
        Rd = New OdbcDataAdapter("select tb_logistik_id, tb_logistik_detail_nosenpi from tb_logistik_detail", Conn)
        Ds = New DataSet
        Rd.Fill(Ds, "tb_logistik_detail")
        DataGridView5.DataSource = Ds.Tables("tb_logistik_detail")
        cbx_id_logistik_senjata.Text = "--PILIH ID SENJATA--"
    End Sub

    Sub bersih_nomor_senpi()
        txt_nomor_senjata.Text = ""
        cbx_id_logistik_senjata.Text = "--PILIH ID SENJATA--"
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampil_nomor_senpi()
        tampilsenpi()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            If cbx_id_logistik_senjata.Text = "--PILIH ID SENJATA--" Then
                MsgBox("ID Logistik tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_nomor_senjata.Text = "" Then
                MsgBox("Nomor senjata tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            Else
                Call koneksi()
                Dim simpan As String = "insert into tb_logistik_detail values ('" & cbx_id_logistik_senjata.Text & "','" & txt_nomor_senjata.Text & "')"
                Cmd = New OdbcCommand(simpan, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Input data berhasil")
                Call tampil_nomor_senpi()
                Call bersih_nomor_senpi()
            End If
        Catch ex As Exception
            MsgBox("Terdapat kesalahan" & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim a As String = DataGridView5.Item(1, DataGridView5.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Nilai yang dihapus belum DIPILIH")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan kode_nilai=" & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
                koneksi()
                cmd = New OdbcCommand("delete from tb_logistik_detail where tb_logistik_detail_nosenpi='" & a & "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus data nilai BERHASIL", vbInformation, "INFORMASI")
                con.Close()
                Call tampil_nomor_senpi()
            End If
        End If
    End Sub

    Private Sub DataGridView5_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView5.CellClick
        On Error Resume Next
        Dim row As DataGridViewRow = DataGridView5.CurrentRow
        Me.cbx_id_logistik_senjata.Text = row.Cells(0).Value.ToString()
        Me.txt_nomor_senjata.Text = row.Cells(1).Value.ToString()
    End Sub

    Private Sub cbx_id_logistik_senjata_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbx_id_logistik_senjata.KeyUp
        
    End Sub
End Class