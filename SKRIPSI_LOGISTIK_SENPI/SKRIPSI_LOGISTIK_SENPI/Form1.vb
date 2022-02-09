Imports System.Data.Odbc
Imports System.Drawing.Printing
Public Class Form1
    Private searchIndex As Integer = -1
    Dim PPD As New PrintPreviewDialog

    Sub tampil_anggota()
        Call koneksi()
        Rd = New OdbcDataAdapter("select tb_anggota_id, tb_anggota_nrp, tb_anggota_nama, tb_anggota_pangkat, tb_anggota_jabatan, tb_anggota_kesatuan from tb_anggota", Conn)
        Ds = New DataSet
        Rd.Fill(Ds, "tb_anggota")
        DataGridView1.DataSource = Ds.Tables("tb_anggota")
        cbx_pangkatAng.Text = "--PILIH PANGKAT--"
        cbx_jabatanAng.Text = "--PILIH JABATAN--"
    End Sub

    Sub bersih_anggota()
        txt_idAng.Text = ""
        txt_nrpAng.Text = ""
        txt_namaAng.Text = ""
        cbx_pangkatAng.Text = "--PILIH PANGKAT--"
        cbx_jabatanAng.Text = "--PILIH JABATAN--"
        txt_kesatuanAng.Text = ""
        Call autoNumberAngota()
    End Sub

    Sub autoNumberAngota()
        Call koneksi()
        Dim auto As String
        auto = "select * from tb_anggota order by tb_anggota_id desc"
        Cmd = New OdbcCommand(auto, Conn)
        Dr = Cmd.ExecuteReader
        Dr.Read()
        If Not Dr.HasRows Then
            txt_idAng.Text = "AG" + "0001"
        Else
            txt_idAng.Text = Val(Microsoft.VisualBasic.Mid(Dr.Item("tb_anggota_id").ToString, 4, 3)) + 1
            If Len(txt_idAng.Text) = 1 Then
                txt_idAng.Text = "AG000" & txt_idAng.Text & ""
            ElseIf Len(txt_idAng.Text) = 2 Then
                txt_idAng.Text = "AG00" & txt_idAng.Text & ""
            ElseIf Len(txt_idAng.Text) = 3 Then
                txt_idAng.Text = "AG0" & txt_idAng.Text & ""
            End If
        End If
    End Sub

    Sub aturDGVanggota()
        'GANTI LEBAR COLOM HEADER
        DataGridView1.Columns(0).Width = 120
        DataGridView1.Columns(1).Width = 150
        DataGridView1.Columns(2).Width = 200
        DataGridView1.Columns(3).Width = 150
        DataGridView1.Columns(4).Width = 150
        DataGridView1.Columns(5).Width = 150

        'GANTI POSISI HEADER
        DataGridView1.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        'GANTI NAMA HEADER
        DataGridView1.Columns(0).HeaderText = "ID ANGGOTA"
        DataGridView1.Columns(1).HeaderText = "NRP ANGGOTA"
        DataGridView1.Columns(2).HeaderText = "NAMA ANGGOTA"
        DataGridView1.Columns(3).HeaderText = "PANGKAT ANGGOTA"
        DataGridView1.Columns(4).HeaderText = "JABATAN ANGGOTA"
        DataGridView1.Columns(5).HeaderText = "KESATUAN ANGGOTA"

        DataGridView1.RowsDefaultCellStyle.BackColor = Color.LightBlue
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub

    Sub tampil_logistik()
        Call koneksi()
        Rd = New OdbcDataAdapter("select tb_logistik_id, tb_logistik_nomor, tb_logistik_jenis, tb_logistik_status, tb_logistik_kode, tb_logistik_nama, tb_logistik_jumlah from tb_logistik", Conn)
        Ds = New DataSet
        Rd.Fill(Ds, "tb_logistik")
        DataGridView2.DataSource = Ds.Tables("tb_logistik")
        cbx_jenisLog.Text = "--PILIH JENIS--"
        cbx_statusLog.Text = "--PILIH STATUS--"
    End Sub

    Sub bersih_logistik()
        txt_idAng.Text = ""
        txt_nomorLog.Text = ""
        cbx_jenisLog.Text = "--PILIH JENIS--"
        cbx_statusLog.Text = "--PILIH STATUS--"
        txt_kodeLog.Text = ""
        txt_namaLog.Text = ""
        txt_jumlahLog.Text = ""
        Call autoNumberLogistik()
    End Sub

    Sub autoNumberLogistik()
        Call koneksi()
        Dim auto As String
        auto = "select * from tb_logistik order by tb_logistik_id desc"
        Cmd = New OdbcCommand(auto, Conn)
        Dr = Cmd.ExecuteReader
        Dr.Read()
        If Not Dr.HasRows Then
            txt_idLog.Text = "LG" + "0001"
        Else
            txt_idLog.Text = Val(Microsoft.VisualBasic.Mid(Dr.Item("tb_logistik_id").ToString, 4, 3)) + 1
            If Len(txt_idLog.Text) = 1 Then
                txt_idLog.Text = "LG000" & txt_idLog.Text & ""
            ElseIf Len(txt_idLog.Text) = 2 Then
                txt_idLog.Text = "LG00" & txt_idLog.Text & ""
            ElseIf Len(txt_idLog.Text) = 3 Then
                txt_idLog.Text = "LG0" & txt_idLog.Text & ""
            End If
        End If
    End Sub

    Sub aturDGVlogistik()
        'GANTI LEBAR COLOM HEADER
        DataGridView2.Columns(0).Width = 120
        DataGridView2.Columns(1).Width = 120
        DataGridView2.Columns(2).Width = 170
        DataGridView2.Columns(3).Width = 130
        DataGridView2.Columns(4).Width = 130
        DataGridView2.Columns(5).Width = 120
        DataGridView2.Columns(6).Width = 150

        'GANTI POSISI HEADER
        DataGridView2.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView2.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView2.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView2.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView2.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView2.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView2.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        'GANTI NAMA HEADER
        DataGridView2.Columns(0).HeaderText = "ID LOGISTIK"
        DataGridView2.Columns(1).HeaderText = "NOMOR SENPI"
        DataGridView2.Columns(2).HeaderText = "JENIS LOGISTIK"
        DataGridView2.Columns(3).HeaderText = "STATUS LOGISTIK"
        DataGridView2.Columns(4).HeaderText = "KODE LOGISTIK"
        DataGridView2.Columns(5).HeaderText = "NAMA LOGISTIK"
        DataGridView2.Columns(6).HeaderText = "JUMLAH LOGISTIK"

        DataGridView2.RowsDefaultCellStyle.BackColor = Color.LightBlue
        DataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub

    Sub tampil_pinjam_senpi()
        Call koneksi()
        Rd = New OdbcDataAdapter("select tb_pinjaman_id, tb_anggota_id, tb_logistik_id,tb_pinjaman_tanggal_pinjam, tb_pinjaman_tanggal_kembali, tb_pinjam_status, tb_pinjaman_nosenpi, tb_logistik_persetujuan from tb_pinjaman", Conn)
        Ds = New DataSet
        Rd.Fill(Ds, "tb_pinjaman")
        DataGridView3.DataSource = Ds.Tables("tb_pinjaman")
        DataGridView4.DataSource = Ds.Tables("tb_pinjaman")
        txt_statusPin.Text = "Di Pinjam"
        txt_persetujuan.Text = "Belum Disetujui"
        cbx_statusLogistik.Text = "--PILIH STATUS--"
    End Sub

    Sub cariAutoAnggota()
        Try
            Call koneksi()
            Dim str As String
            str = "select * from tb_anggota where tb_anggota_id = '" & txt_idAngPin.Text & "'"
            Cmd = New OdbcCommand(str, Conn)
            Dr = Cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                lb_namaAng.Text = Dr.Item("tb_anggota_nama")
                lb_pangkatAng.Text = Dr.Item("tb_anggota_pangkat")
                lb_NrpAng.Text = Dr.Item("tb_anggota_nrp")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub comboboxsenjata()
        Call koneksi()
        Cmd = New OdbcCommand("select * from tb_logistik_detail where tb_logistik_id = '" & txt_idLogPin.Text & "'", Conn)
        Dr = Cmd.ExecuteReader
        cbx_CariNoSenpi.Items.Clear()
        Do While Dr.Read
            cbx_CariNoSenpi.Items.Add(Dr.Item("tb_logistik_detail_nosenpi"))
        Loop
    End Sub
    Sub cariAutoSenjata()
        Try
            Call koneksi()
            Dim str As String
            str = "select * from tb_logistik where tb_logistik_id = '" & txt_idLogPin.Text & "'"
            Cmd = New OdbcCommand(str, Conn)
            Dr = Cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                lb_namaSen.Text = Dr.Item("tb_logistik_nama")
                lb_jumlahSen.Text = Dr.Item("tb_logistik_jumlah")

            End If
        Catch ex As Exception

        End Try
    End Sub
    

    Sub cariAutoSenjata2()
        Try
            Call koneksi()
            Dim str As String
            str = "select * from tb_logistik where tb_logistik_id = '" & txt_idLogistik.Text & "'"
            Cmd = New OdbcCommand(str, Conn)
            Dr = Cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                lb_nama_senpi.Text = Dr.Item("tb_logistik_nama")
                lb_nomor_senpi.Text = Dr.Item("tb_logistik_nomor")
                lb_jumlah_senpi.Text = Dr.Item("tb_logistik_jumlah")

            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub autoNumberPinjam()
        Call koneksi()
        Dim auto As String
        auto = "select * from tb_pinjaman order by tb_pinjaman_id desc"
        Cmd = New OdbcCommand(auto, Conn)
        Dr = Cmd.ExecuteReader
        Dr.Read()
        If Not Dr.HasRows Then
            txt_idPin.Text = "PI" + "0001"
        Else
            txt_idPin.Text = Val(Microsoft.VisualBasic.Mid(Dr.Item("tb_pinjaman_id").ToString, 4, 3)) + 1
            If Len(txt_idPin.Text) = 1 Then
                txt_idPin.Text = "PI000" & txt_idPin.Text & ""
            ElseIf Len(txt_idPin.Text) = 2 Then
                txt_idPin.Text = "PI00" & txt_idPin.Text & ""
            ElseIf Len(txt_idPin.Text) = 3 Then
                txt_idPin.Text = "PI0" & txt_idPin.Text & ""
            End If
        End If
    End Sub

    Sub bersih_pinjam_senpi()
        txt_idPin.Text = ""
        txt_idAngPin.Text = ""
        txt_idLogPin.Text = ""
        dtm_tglPin.Text = Now
        dtm_tglPin.Text = Now
        txt_statusPin.Text = "Di Pinjam"
        lb_namaAng.Text = "..."
        lb_pangkatAng.Text = "..."
        lb_NrpAng.Text = "..."
        lb_namaSen.Text = "..."
        cbx_CariNoSenpi.Text = "--PILIH NO SENPI--"
        lb_jumlahSen.Text = "..."
        lb_sisa.Text = "..."
        Call autoNumberPinjam()
    End Sub

    Sub aturDGVpinjam_senpi()
        'GANTI LEBAR COLOM HEADER
        DataGridView3.Columns(0).Width = 120
        DataGridView3.Columns(1).Width = 150
        DataGridView3.Columns(2).Width = 150
        DataGridView3.Columns(3).Width = 150
        DataGridView3.Columns(4).Width = 150
        DataGridView3.Columns(5).Width = 150
        DataGridView3.Columns(6).Width = 150
        DataGridView3.Columns(7).Width = 150

        'GANTI LEBAR COLOM HEADER
        DataGridView4.Columns(0).Width = 120
        DataGridView4.Columns(1).Width = 150
        DataGridView4.Columns(2).Width = 150
        DataGridView4.Columns(3).Width = 150
        DataGridView4.Columns(4).Width = 150
        DataGridView4.Columns(5).Width = 150

        'GANTI POSISI HEADER
        DataGridView3.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView3.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView3.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView3.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView3.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView3.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView3.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView3.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        'GANTI POSISI HEADER
        DataGridView4.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView4.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView4.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView4.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView4.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView4.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        'GANTI NAMA HEADER
        DataGridView3.Columns(0).HeaderText = "ID PINJAMAN"
        DataGridView3.Columns(1).HeaderText = "ID ANGGOTA"
        DataGridView3.Columns(2).HeaderText = "ID LOGISTIK"
        DataGridView3.Columns(3).HeaderText = "TANGGAL PINJAM"
        DataGridView3.Columns(4).HeaderText = "TANGGAL KEMBALI"
        DataGridView3.Columns(5).HeaderText = "STATUS"
        DataGridView3.Columns(6).HeaderText = "NO SENPI"
        DataGridView3.Columns(7).HeaderText = "PERSETUJUAN"

        'GANTI NAMA HEADER
        DataGridView4.Columns(0).HeaderText = "ID PINJAMAN"
        DataGridView4.Columns(1).HeaderText = "ID ANGGOTA"
        DataGridView4.Columns(2).HeaderText = "ID LOGISTIK"
        DataGridView4.Columns(3).HeaderText = "TANGGAL PINJAM"
        DataGridView4.Columns(4).HeaderText = "TANGGAL KEMBALI"
        DataGridView4.Columns(5).HeaderText = "STATUS"
        DataGridView4.Columns(6).HeaderText = "NO SENPI"

        DataGridView3.RowsDefaultCellStyle.BackColor = Color.LightBlue
        DataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

        DataGridView4.RowsDefaultCellStyle.BackColor = Color.LightBlue
        DataGridView4.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub

    Sub CariNomorSenpi()
        Call koneksi()
        Dim str As String
        str = "select * from tb_logistik_detail where tb_logistik_id ='" & txt_idLogPin.Text & "' "
        Cmd = New OdbcCommand(str, Conn)
        Dr = Cmd.ExecuteReader
        If Dr.HasRows Then
            Do While Dr.Read
                cbx_CariNoSenpi.Items.Add(Dr("tb_logistik_detail_nosenpi"))
            Loop
        Else

        End If
    End Sub

    Sub bersih_kembali_senpi()
        txt_idPeminjaman.Text = ""
        dtm_kembali.Text = Now
        cbx_statusLogistik.Text = "--PILIH STATUS--"
        lb_ketdetailanggota.Text = "..."
        lb_tgl_awal.Text = "..."
        lb_tgl_akhir.Text = "..."
        lb_nama_senpi.Text = "..."
        lb_nomor_senpi.Text = "..."
        lb_jumlah_senpi.Text = "..."
        lb_sisa_senpi.Text = "..."
    End Sub


    Private Sub btn_cencel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cencel.Click
        Me.Close()
    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        If txt_username.Text = "" Or txt_password.Text = "" Then
            MsgBox("data login belum lengkap")

        Else
            If txt_username.Text = "admin" Or txt_password.Text = "admin" Then
                Panggota.Show()
                Psenjata.Show()
                Ppinjam.Show()
                Pkembali.Show()
                p_keluar.Show()
                Plogin.Hide()
            ElseIf txt_username.Text = "baurlog" Or txt_password.Text = "baurlog" Then
                Form6.Show()
            ElseIf txt_username.Text = "danki" Or txt_password.Text = "danki" Then
                Form7.Show()
            End If

            End If
    End Sub

    Private Sub Panggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panggota.Click
        Pdataanggota.Show()
        Pdatasenjata.Hide()
        Ppeminjaman.Hide()
        Ppengembalian.Hide()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Pdataanggota.Hide()
        Pdatasenjata.Hide()
        Ppeminjaman.Hide()
        Ppengembalian.Hide()
        Call tampil_anggota()
        Call autoNumberAngota()
        Call aturDGVanggota()
        Call tampil_logistik()
        Call autoNumberLogistik()
        Call aturDGVlogistik()
        Call tampil_pinjam_senpi()
        Call autoNumberPinjam()
        Call aturDGVpinjam_senpi()
        Call CariNomorSenpi()


    End Sub

    Private Sub btn_bersihAng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bersihAng.Click
        Call bersih_anggota()
    End Sub

    Private Sub btn_simpanAng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpanAng.Click
        Try
            If txt_idAng.Text = "" Then
                MsgBox("ID anggota tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_nrpAng.Text = "" Then
                MsgBox("NRP anggota tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_namaAng.Text = "" Then
                MsgBox("Nama anggota tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf cbx_pangkatAng.Text = "--PILIH PANGKAT--" Then
                MsgBox("Pangkat anggota tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf cbx_jabatanAng.Text = "--PILIH JABATAN--" Then
                MsgBox("Jabatan anggota tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_kesatuanAng.Text = "" Then
                MsgBox("Kesatuan anggota tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            Else
                Call koneksi()
                Dim simpan As String = "insert into tb_anggota values ('" & txt_idAng.Text & "','" & txt_nrpAng.Text & "','" & txt_namaAng.Text & "','" & cbx_pangkatAng.Text & "','" & cbx_jabatanAng.Text & "','" & txt_kesatuanAng.Text & "')"
                Cmd = New OdbcCommand(simpan, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Input data berhasil")
                Call tampil_anggota()
                Call bersih_anggota()
            End If
        Catch ex As Exception
            MsgBox("Terdapat kesalahan" & ex.Message)
        End Try
    End Sub

    Private Sub btn_hapusAng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hapusAng.Click
        Dim a As String = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("data yang akan di hapus belum dipilih")
        Else
            Try
                If (MessageBox.Show("Anda yakin ingin menghapus data dengan ID ANGGOTA =" & a & "....?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
                    Call koneksi()
                    Cmd = New OdbcCommand("delete from tb_anggota where tb_anggota_id='" & a & "'", Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Mengahapus data BERHASIL", vbInformation, "Informasi")
                    Conn.Close()
                    Call tampil_anggota()
                    Call bersih_anggota()
                End If
            Catch ex As Exception
                MsgBox("Menghapus data GAGAL", vbInformation, "Informasi")
            End Try
        End If
    End Sub

    Private Sub btn_ubahAng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ubahAng.Click
        Try
            If txt_idAng.Text = "" Then
                MsgBox("ID anggota tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_nrpAng.Text = "" Then
                MsgBox("NRP anggota tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_namaAng.Text = "" Then
                MsgBox("Nama anggota tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf cbx_pangkatAng.Text = "--PILIH PANGKAT--" Then
                MsgBox("Pangkat anggota tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf cbx_jabatanAng.Text = "--PILIH JABATAN--" Then
                MsgBox("Jabatan anggota tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_kesatuanAng.Text = "" Then
                MsgBox("Kesatuan anggota tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            Else
                Call koneksi()
                Dim update As String = "update tb_anggota set tb_anggota_nrp = '" & txt_nrpAng.Text & "',tb_anggota_nama = '" & txt_namaAng.Text & "', tb_anggota_pangkat ='" & cbx_pangkatAng.Text & "', tb_anggota_jabatan = '" & cbx_jabatanAng.Text & "', tb_anggota_kesatuan = '" & txt_kesatuanAng.Text & "' where tb_anggota_id = '" & txt_idAng.Text & "'"
                Cmd = New OdbcCommand(update, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil diUpdate")
                Call tampil_anggota()
                Call bersih_anggota()
            End If
        Catch ex As Exception
            MsgBox("Terdapat kesalahan" & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        On Error Resume Next
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Me.txt_idAng.Text = row.Cells(0).Value.ToString()
        Me.txt_nrpAng.Text = row.Cells(1).Value.ToString()
        Me.txt_namaAng.Text = row.Cells(2).Value.ToString()
        Me.cbx_pangkatAng.Text = row.Cells(3).Value.ToString()
        Me.cbx_jabatanAng.Text = row.Cells(4).Value.ToString()
        Me.txt_kesatuanAng.Text = row.Cells(5).Value.ToString()
    End Sub

    Private Sub btn_cariAng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cariAng.Click
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            searchIndex = (searchIndex + 1) Mod DataGridView1.Rows.Count
            Dim row As DataGridViewRow = DataGridView1.Rows(searchIndex)
            If row.Cells("tb_anggota_id").Value Is Nothing Then
                MsgBox("Item Not Found", MsgBoxStyle.Critical, "Info")
                txt_cariAng.Focus()
                Continue For
            End If

            If row.Cells("tb_anggota_id").Value.ToString().Trim() = txt_cariAng.Text Then
                DataGridView1.CurrentCell = row.Cells("tb_anggota_id")
                DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.Rows(row.Index).Index
                txt_cariAng.Clear()
                Return
            End If
        Next
    End Sub

    Private Sub txt_cariAng_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cariAng.TextChanged
        searchIndex = -1
    End Sub

    Private Sub Psenjata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Psenjata.Click
        Pdatasenjata.Show()
    End Sub

    Private Sub btn_simpanlog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpanlog.Click
        Try
            If txt_idLog.Text = "" Then
                MsgBox("ID logistik tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_nomorLog.Text = "" Then
                MsgBox("Nomor logistik tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf cbx_jenisLog.Text = "--PILIH JENIS--" Then
                MsgBox("Jenis logistik tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf cbx_statusLog.Text = "--PILIH STATUS--" Then
                MsgBox("Status logistik tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_namaLog.Text = "" Then
                MsgBox("Nama logistik tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_kodeLog.Text = "" Then
                MsgBox("Kode logistik tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_jumlahLog.Text = "" Then
                MsgBox("Jumlah logistik tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            Else
                Call koneksi()
                Dim simpan As String = "insert into tb_logistik values ('" & txt_idLog.Text & "','" & txt_nomorLog.Text & "','" & cbx_jenisLog.Text & "','" & cbx_statusLog.Text & "','" & txt_kodeLog.Text & "','" & txt_namaLog.Text & "','" & txt_jumlahLog.Text & "')"
                Cmd = New OdbcCommand(simpan, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Input data berhasil")
                Call tampil_logistik()
                Call bersih_logistik()
            End If
        Catch ex As Exception
            MsgBox("Terdapat kesalahan" & ex.Message)
        End Try
    End Sub

    Private Sub btn_hapuslog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hapuslog.Click
        Dim a As String = DataGridView2.Item(0, DataGridView2.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("data yang akan di hapus belum dipilih")
        Else
            Try
                If (MessageBox.Show("Anda yakin ingin menghapus data dengan ID LOGISTIK =" & a & "....?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
                    Call koneksi()
                    Cmd = New OdbcCommand("delete from tb_logistik where tb_logistik_id='" & a & "'", Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Mengahapus data BERHASIL", vbInformation, "Informasi")
                    Conn.Close()
                    Call tampil_logistik()
                    Call bersih_logistik()
                End If
            Catch ex As Exception
                MsgBox("Menghapus data GAGAL", vbInformation, "Informasi")
            End Try
        End If
    End Sub

    Private Sub btn_ubahlog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ubahlog.Click
        Try
            If txt_idLog.Text = "" Then
                MsgBox("ID logistik tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_nomorLog.Text = "" Then
                MsgBox("Nomor logistik tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf cbx_jenisLog.Text = "--PILIH JENIS--" Then
                MsgBox("Jenis logistik tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf cbx_statusLog.Text = "--PILIH STATUS--" Then
                MsgBox("Status logistik tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_namaLog.Text = "" Then
                MsgBox("Nama logistik tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_kodeLog.Text = "" Then
                MsgBox("Kode logistik tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_jumlahLog.Text = "" Then
                MsgBox("Jumlah logistik tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            Else
                Call koneksi()
                Dim update As String = "update tb_logistik set tb_logistik_nomor = '" & txt_nomorLog.Text & "', tb_logistik_jenis = '" & cbx_jenisLog.Text & "',tb_logistik_status = '" & cbx_statusLog.Text & "', tb_logistik_kode ='" & txt_kodeLog.Text & "', tb_logistik_nama = '" & txt_namaLog.Text & "', tb_logistik_jumlah = '" & txt_jumlahLog.Text & "' where tb_logistik_id = '" & txt_idLog.Text & "'"
                Cmd = New OdbcCommand(update, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil diUpdate")
                Call tampil_logistik()
                Call bersih_logistik()
            End If
        Catch ex As Exception
            MsgBox("Terdapat kesalahan" & ex.Message)
        End Try
    End Sub

    Private Sub btn_bersihlog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bersihlog.Click
        Call bersih_logistik()
    End Sub

    Private Sub btn_carilog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_carilog.Click
        For i As Integer = 0 To DataGridView2.Rows.Count - 1
            searchIndex = (searchIndex + 1) Mod DataGridView2.Rows.Count
            Dim row As DataGridViewRow = DataGridView2.Rows(searchIndex)
            If row.Cells("tb_logistik_id").Value Is Nothing Then
                MsgBox("Item Not Found", MsgBoxStyle.Critical, "Info")
                txt_cariLog.Focus()
                Continue For
            End If

            If row.Cells("tb_logistik_id").Value.ToString().Trim() = txt_cariLog.Text Then
                DataGridView2.CurrentCell = row.Cells("tb_logistik_id")
                DataGridView2.FirstDisplayedScrollingRowIndex = DataGridView2.Rows(row.Index).Index
                txt_cariLog.Clear()
                Return
            End If
        Next
    End Sub

    Private Sub DataGridView2_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        On Error Resume Next
        Dim row As DataGridViewRow = DataGridView2.CurrentRow
        Me.txt_idLog.Text = row.Cells(0).Value.ToString()
        Me.txt_nomorLog.Text = row.Cells(1).Value.ToString()
        Me.cbx_jenisLog.Text = row.Cells(2).Value.ToString()
        Me.cbx_statusLog.Text = row.Cells(3).Value.ToString()
        Me.txt_kodeLog.Text = row.Cells(4).Value.ToString()
        Me.txt_namaLog.Text = row.Cells(5).Value.ToString()
        Me.txt_jumlahLog.Text = row.Cells(6).Value.ToString()
    End Sub

    Private Sub txt_cariLog_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cariLog.TextChanged
        searchIndex = -1
    End Sub

    Private Sub Ppinjam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ppinjam.Click
        Ppeminjaman.Show()
    End Sub

    Private Sub txt_idAngPin_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_idAngPin.KeyUp
        Call cariAutoAnggota()
    End Sub

    Private Sub txt_idLogPin_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_idLogPin.KeyUp
        Call cariAutoSenjata()
        Call comboboxsenjata()
        lb_sisa.Text = Val(lb_jumlahSen.Text) - Val(lb_ketetapan.Text)
    End Sub

    Private Sub btn_bersihPin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bersihPin.Click
        Call bersih_pinjam_senpi()
    End Sub

    Private Sub btn_simpanPin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpanPin.Click
        Try
            If txt_idPin.Text = "" Then
                MsgBox("ID pinjaman tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_idAngPin.Text = "" Then
                MsgBox("ID anggota tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_idLogPin.Text = "" Then
                MsgBox("ID Logistik tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_statusPin.Text = "" Then
                MsgBox("Status Pinjam tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            Else
                Call koneksi()
                Dim simpan As String = "insert into tb_pinjaman values ('" & txt_idPin.Text & "','" & txt_idAngPin.Text & "','" & txt_idLogPin.Text & "','" & Format(dtm_tglPin.Value, "yyyy-MM-dd") & "','" & Format(dtm_tglKem.Value, "yyyy-MM-dd") & "','" & txt_statusPin.Text & "','" & cbx_CariNoSenpi.Text & "','" & txt_persetujuan.Text & "')"
                Cmd = New OdbcCommand(simpan, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Input data berhasil")
                Call koneksi()
                Dim update As String = "update tb_logistik set tb_logistik_jumlah = '" & lb_sisa.Text & "' where tb_logistik_id = '" & txt_idLogPin.Text & "'"
                Cmd = New OdbcCommand(update, Conn)
                Cmd.ExecuteNonQuery()
                Call tampil_pinjam_senpi()
                Call bersih_pinjam_senpi()
                Call tampil_logistik()
            End If
        Catch ex As Exception
            MsgBox("Terdapat kesalahan" & ex.Message)
        End Try
    End Sub

    Private Sub btn_hapusPin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hapusPin.Click
        Dim a As String = DataGridView3.Item(0, DataGridView3.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("data yang akan di hapus belum dipilih")
        Else
            Try
                If (MessageBox.Show("Anda yakin ingin menghapus data dengan ID PINJAMAN =" & a & "....?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
                    Call koneksi()
                    Cmd = New OdbcCommand("delete from tb_pinjaman where tb_pinjaman_id='" & a & "'", Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Mengahapus data BERHASIL", vbInformation, "Informasi")
                    Conn.Close()
                    Call tampil_pinjam_senpi()
                    Call bersih_pinjam_senpi()
                End If
            Catch ex As Exception
                MsgBox("Menghapus data GAGAL", vbInformation, "Informasi")
            End Try
        End If
    End Sub

    Private Sub btn_ubahPin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ubahPin.Click
        Try
            If txt_idPin.Text = "" Then
                MsgBox("ID pinjaman tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_idAngPin.Text = "" Then
                MsgBox("ID anggota tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_idLogPin.Text = "" Then
                MsgBox("ID Logistik tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_statusPin.Text = "" Then
                MsgBox("Status Pinjam tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            Else
                Call koneksi()
                Dim update As String = "update tb_pinjaman set tb_anggota_id = '" & txt_idAngPin.Text & "', tb_logistik_id = '" & txt_idLogPin.Text & "', tb_pinjaman_tanggal_pinjam = '" & Format(dtm_tglPin.Value, "yyyy-MM-dd") & "', tb_pinjaman_tanggal_kembali ='" & Format(dtm_tglKem.Value, "yyyy-MM-dd") & "', tb_pinjam_status = '" & txt_statusPin.Text & "', tb_pinjaman_nosenpi = '" & cbx_CariNoSenpi.Text & "' where tb_pinjaman_id = '" & txt_idPin.Text & "'"
                Cmd = New OdbcCommand(update, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil diUpdate")
                Call tampil_pinjam_senpi()
                Call bersih_pinjam_senpi()
            End If
        Catch ex As Exception
            MsgBox("Terdapat kesalahan" & ex.Message)
        End Try
    End Sub

    Private Sub btn_cariPin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cariPin.Click
        For i As Integer = 0 To DataGridView3.Rows.Count - 1
            searchIndex = (searchIndex + 1) Mod DataGridView3.Rows.Count
            Dim row As DataGridViewRow = DataGridView3.Rows(searchIndex)
            If row.Cells("tb_pinjaman_id").Value Is Nothing Then
                MsgBox("Item Not Found", MsgBoxStyle.Critical, "Info")
                txt_cariPin.Focus()
                Continue For
            End If

            If row.Cells("tb_pinjaman_id").Value.ToString().Trim() = txt_cariPin.Text Then
                DataGridView3.CurrentCell = row.Cells("tb_pinjaman_id")
                DataGridView3.FirstDisplayedScrollingRowIndex = DataGridView3.Rows(row.Index).Index
                txt_cariPin.Clear()
                Return
            End If
        Next
    End Sub

    Private Sub txt_cariPin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cariPin.TextChanged
        searchIndex = -1
    End Sub

    Private Sub DataGridView3_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        On Error Resume Next
        Call cariAutoAnggota()
        Call cariAutoSenjata()
        Dim row As DataGridViewRow = DataGridView3.CurrentRow
        Me.txt_idPin.Text = row.Cells(0).Value.ToString()
        Me.txt_idAngPin.Text = row.Cells(1).Value.ToString()
        Me.txt_idLogPin.Text = row.Cells(2).Value.ToString()
        Me.dtm_tglPin.Text = row.Cells(3).Value.ToString()
        Me.dtm_tglKem.Text = row.Cells(4).Value.ToString()
        Me.txt_statusPin.Text = row.Cells(5).Value.ToString()
        Me.cbx_CariNoSenpi.Text = row.Cells(6).Value.ToString()
        Me.txt_persetujuan.Text = row.Cells(7).Value.ToString()
        If txt_persetujuan.Text = "DI SETUJUI" Then
            gb_disetujui.Visible = True
            Exit Sub
        ElseIf txt_persetujuan.Text = "TIDAK DISETUJUI" Then
            gb_disetujui.Visible = False
            Exit Sub
        ElseIf txt_persetujuan.Text = "Belum Disetujui" Then
            gb_disetujui.Visible = False
            Exit Sub
        End If
    End Sub

    Private Sub btn_print_depan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print_depan.Click
        Try
            If txt_idPin.Text = "" Then
                MsgBox("ID pinjaman tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_idAngPin.Text = "" Then
                MsgBox("ID anggota tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_idLogPin.Text = "" Then
                MsgBox("ID Logistik tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_statusPin.Text = "" Then
                MsgBox("Status Pinjam tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            Else
                PPD.Document = PD1
                PPD.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("Terdapat kesalahan" & ex.Message)
        End Try
    End Sub

    Private Sub PD1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PD1.BeginPrint
        Dim Pagesetup As New PageSettings
        Pagesetup.PaperSize = New PaperSize("Custom", 340, 189)
        PD1.DefaultPageSettings = Pagesetup
    End Sub

    Private Sub PD1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PD1.PrintPage
        Dim f10 As New Font("Times New Roman", 7, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD1.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD1.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD1.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim NewImage As Image = Image.FromFile("F:\bu Risma\gambar\logo.jpg")

        Dim garis As String
        garis = "----------------------------------------------------------------------------------------------------------"
        e.Graphics.DrawString("KARTU PINJAM SENPI", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, centermargin, 20, tengah)
        e.Graphics.DrawString("ID Pinjam", f10, Brushes.Black, 0, 30)
        e.Graphics.DrawString(":", f10, Brushes.Black, 150, 30)
        e.Graphics.DrawString(txt_idPin.Text, f10, Brushes.Black, 160, 30)

        e.Graphics.DrawImage(NewImage, 115, 30)

        e.Graphics.DrawString("ID Anggota", f10, Brushes.Black, 0, 45)
        e.Graphics.DrawString(":", f10, Brushes.Black, 150, 45)
        e.Graphics.DrawString(txt_idAngPin.Text, f10, Brushes.Black, 160, 45)

        e.Graphics.DrawString("Nama Anggota", f10, Brushes.Black, 0, 60)
        e.Graphics.DrawString(":", f10, Brushes.Black, 150, 60)
        e.Graphics.DrawString(lb_namaAng.Text, f10, Brushes.Black, 160, 60)

        e.Graphics.DrawString("Pangkat", f10, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f10, Brushes.Black, 150, 75)
        e.Graphics.DrawString(lb_pangkatAng.Text, f10, Brushes.Black, 160, 75)

        e.Graphics.DrawString("NRP", f10, Brushes.Black, 0, 90)
        e.Graphics.DrawString(":", f10, Brushes.Black, 150, 90)
        e.Graphics.DrawString(lb_NrpAng.Text, f10, Brushes.Black, 160, 90)

        e.Graphics.DrawString("Mengetahui", f10, Brushes.Black, 180, 105)
        e.Graphics.DrawString("Komandan Kompi 1 Yon C Por", f10, Brushes.Black, 140, 120)
        e.Graphics.DrawString("SATBRIMOB POLDA JATENG", f10, Brushes.Black, 140, 130)
        e.Graphics.DrawString("Edy Sulistiyono, SH", f10, Brushes.Black, 140, 165)
        e.Graphics.DrawString("INSPEKTUR POLISI SATU NRP.7604004411", f10, Brushes.Black, 140, 175)

    End Sub

    Private Sub btn_print_belakang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print_belakang.Click
        Try
            If txt_idPin.Text = "" Then
                MsgBox("ID pinjaman tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_idAngPin.Text = "" Then
                MsgBox("ID anggota tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_idLogPin.Text = "" Then
                MsgBox("ID Logistik tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txt_statusPin.Text = "" Then
                MsgBox("Status Pinjam tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            Else
                PPD.Document = PD2
                PPD.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("Terdapat kesalahan" & ex.Message)
        End Try
    End Sub

    Private Sub PD2_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PD2.BeginPrint
        Dim Pagesetup As New PageSettings
        Pagesetup.PaperSize = New PaperSize("Custom", 340, 189)
        PD2.DefaultPageSettings = Pagesetup
    End Sub

    Private Sub PD2_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PD2.PrintPage
        Dim f10 As New Font("Times New Roman", 7, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD2.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD2.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD2.DefaultPageSettings.PaperSize.Width

        Dim NewImage As Image = Image.FromFile("F:\bu Risma\gambar\logo.jpg")

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "----------------------------------------------------------------------------------------------------------"
        e.Graphics.DrawString("DATA NAMA SENPI", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString(garis, f10, Brushes.Black, centermargin, 20, tengah)

        e.Graphics.DrawImage(NewImage, 115, 30)

        e.Graphics.DrawString("ID Logistik", f10, Brushes.Black, 0, 30)
        e.Graphics.DrawString(":", f10, Brushes.Black, 150, 30)
        e.Graphics.DrawString(txt_idLogPin.Text, f10, Brushes.Black, 160, 30)

        e.Graphics.DrawString("Nama Senpi", f10, Brushes.Black, 0, 45)
        e.Graphics.DrawString(":", f10, Brushes.Black, 150, 45)
        e.Graphics.DrawString(lb_namaSen.Text, f10, Brushes.Black, 160, 45)

        e.Graphics.DrawString("Nomor Senpi", f10, Brushes.Black, 0, 60)
        e.Graphics.DrawString(":", f10, Brushes.Black, 150, 60)
        e.Graphics.DrawString(cbx_CariNoSenpi.Text, f10, Brushes.Black, 160, 60)

        e.Graphics.DrawString("Tanggal Pinjam", f10, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f10, Brushes.Black, 150, 75)
        e.Graphics.DrawString(dtm_tglPin.Text, f10, Brushes.Black, 160, 75)

        e.Graphics.DrawString("Tanggal Kembali", f10, Brushes.Black, 0, 90)
        e.Graphics.DrawString(":", f10, Brushes.Black, 150, 90)
        e.Graphics.DrawString(dtm_tglKem.Text, f10, Brushes.Black, 160, 90)

        e.Graphics.DrawString("Di Terima", f10, Brushes.Black, 180, 105)
        e.Graphics.DrawString(lb_namaAng.Text, f10, Brushes.Black, 180, 140)
        e.Graphics.DrawString((lb_pangkatAng.Text + " NRP." + lb_NrpAng.Text), f10, Brushes.Black, 180, 150)
    End Sub

    Private Sub Pkembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pkembali.Click
        Ppengembalian.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If txt_idPeminjaman.Text = "" Then
                MsgBox("ID pinjaman tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf cbx_statusLogistik.Text = "--PILIH STATUS--" Then
                MsgBox("status Logistik tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            Else
                Call koneksi()
                Dim update As String = "update tb_pinjaman set tb_pinjaman_tanggal_kembali ='" & Format(dtm_tglKem.Value, "yyyy-MM-dd") & "', tb_pinjam_status = '" & cbx_statusLogistik.Text & "' where tb_pinjaman_id = '" & txt_idPeminjaman.Text & "'"
                Cmd = New OdbcCommand(update, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil diUpdate")
                Call koneksi()
                Dim update1 As String = "update tb_logistik set tb_logistik_jumlah = '" & lb_sisa_senpi.Text & "' where tb_logistik_id = '" & txt_idLogistik.Text & "'"
                Cmd = New OdbcCommand(update1, Conn)
                Cmd.ExecuteNonQuery()
                Call tampil_pinjam_senpi()
                Call bersih_kembali_senpi()
                Call tampil_logistik()
            End If
        Catch ex As Exception
            MsgBox("Terdapat kesalahan" & ex.Message)
        End Try
    End Sub

    Private Sub txt_idPeminjaman_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_idPeminjaman.KeyUp
        Try
            Call koneksi()
            Dim str As String
            str = "select * from tb_pinjaman where tb_pinjaman_id = '" & txt_idPeminjaman.Text & "'"
            Cmd = New OdbcCommand(str, Conn)
            Dr = Cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                lb_ketdetailanggota.Text = Dr.Item("tb_anggota_id")
                lb_tgl_awal.Text = Dr.Item("tb_pinjaman_tanggal_pinjam")
                lb_tgl_akhir.Text = Dr.Item("tb_pinjaman_tanggal_kembali")

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Call bersih_kembali_senpi()
    End Sub

    Private Sub txt_idLogistik_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_idLogistik.KeyUp
        Try
            Call cariAutoSenjata2()
            lb_sisa_senpi.Text = Val(lb_jumlah_senpi.Text) + Val(lb_ketetapan.Text)
            Call koneksi()
            Dim str As String
            str = "select * from tb_anggota where tb_anggota_id = '" & lb_ketdetailanggota.Text & "'"
            Cmd = New OdbcCommand(str, Conn)
            Dr = Cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                lb_nama_anggota.Text = Dr.Item("tb_anggota_nama")
                lb_pangkat_anggota.Text = Dr.Item("tb_anggota_pangkat")
                lb_nrp_anggota.Text = Dr.Item("tb_anggota_nrp")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_printLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_printLog.Click
        Form3.Show()
    End Sub

    Private Sub btn_printAng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_printAng.Click
        Form2.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form4.Show()
    End Sub

    Private Sub btn_print_laporan_peminjaman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print_laporan_peminjaman.Click
        Form5.Show()
    End Sub

    Private Sub p_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p_keluar.Click
        Pdataanggota.Visible = False
        Ppengembalian.Visible = False
        Ppeminjaman.Visible = False
        Panggota.Visible = False
        Psenjata.Visible = False
        Ppinjam.Visible = False
        Pkembali.Visible = False
        p_keluar.Visible = False
        Plogin.Visible = True
    End Sub
End Class
