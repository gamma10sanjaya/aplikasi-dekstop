Imports System.Data.Odbc
Public Class Form7

    Sub tampil_setuju()
        Call koneksi()
        Rd = New OdbcDataAdapter("select tb_pinjaman_id, tb_anggota_id,tb_pinjaman_tanggal_pinjam, tb_pinjaman_tanggal_kembali, tb_pinjam_status, tb_pinjaman_nosenpi, tb_logistik_persetujuan from tb_pinjaman", Conn)
        Ds = New DataSet
        Rd.Fill(Ds, "tb_pinjaman")
        DataGridView1.DataSource = Ds.Tables("tb_pinjaman")
        cbx_persetujuan.Text = "--PILIH PERSETUJUAN--"

    End Sub

    Sub bersih_setuju()
        cbx_persetujuan.Text = "--PILIH PERSETUJUAN--"
    End Sub


    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbx_persetujuan.Text = "--PILIH PERSETUJUAN--"
        Call tampil_setuju()
    End Sub

    Private Sub btn_ok_danki_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok_danki.Click
        Try
            If cbx_persetujuan.Text = "--PILIH PERSETUJUAN--" Then
                MsgBox("Belum dipersetujui", vbExclamation, "Pesan")
                Exit Sub
            Else
                Call koneksi()
                Dim update As String = "update tb_pinjaman set tb_logistik_persetujuan = '" & cbx_persetujuan.Text & "' where tb_pinjaman_id = '" & id_danki.Text & "'"
                Cmd = New OdbcCommand(update, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Disetujui")
                Call tampil_setuju()
                Call bersih_setuju()
            End If
        Catch ex As Exception
            MsgBox("Terdapat kesalahan" & ex.Message)
        End Try
    End Sub

    Private Sub cbx_persetujuan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_persetujuan.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Me.id_danki.Text = row.Cells(0).Value.ToString()
        Try
            Call koneksi()
            Dim str As String
            str = "select * from tb_anggota where tb_anggota_id = '" & row.Cells(1).Value.ToString() & "'"
            Cmd = New OdbcCommand(str, Conn)
            Dr = Cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                txt_nama_danki.Text = Dr.Item("tb_anggota_nama")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class