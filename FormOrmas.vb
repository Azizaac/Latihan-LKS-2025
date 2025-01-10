Imports System.Data
Imports System.Data.SqlClient

Public Class FormOrmas
    Private cmd As SqlCommand
    Private adapter As SqlDataAdapter
    Private dt As DataTable

    ' Memuat data Ormas ke DataGridView
    Private Sub LoadData()
        Dim query As String = "SELECT o.id_ormas, o.nama_ormas, o.status_legalitas, o.alamat_kesekretariatan, " &
                              "k.nama_kecamatan, l.nama_kelurahan, o.nama_ketua, o.no_hp_ketua, o.surat_permohonan, o.status " &
                              "FROM ormas_lks_ormas o " &
                              "JOIN ormas_lks_kecamatan k ON o.id_kecamatan = k.id_kecamatan " &
                              "JOIN ormas_lks_kelurahan l ON o.id_kelurahan = l.id_kelurahan"

        Using conn As SqlConnection = Koneksi.GetConnection()
            Try
                conn.Open()
                adapter = New SqlDataAdapter(query, conn)
                dt = New DataTable()
                adapter.Fill(dt)
                dataGridOrmas.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Memuat data Kecamatan dan Kelurahan ke ComboBox
    Private Sub LoadComboBox()
        Using conn As SqlConnection = Koneksi.GetConnection()
            Try
                conn.Open()
                ' Load data untuk ComboBox Kecamatan dan Kelurahan
                LoadComboBoxData(cmbKecamatan, "SELECT * FROM ormas_lks_kecamatan", "nama_kecamatan", "id_kecamatan", conn)
                LoadComboBoxData(cmbKelurahan, "SELECT * FROM ormas_lks_kelurahan", "nama_kelurahan", "id_kelurahan", conn)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Fungsi untuk mengisi data ComboBox
    Private Sub LoadComboBoxData(cmb As ComboBox, query As String, displayMember As String, valueMember As String, conn As SqlConnection)
        Dim dt As New DataTable()
        adapter = New SqlDataAdapter(query, conn)
        adapter.Fill(dt)
        cmb.DataSource = dt
        cmb.DisplayMember = displayMember
        cmb.ValueMember = valueMember
    End Sub

    ' Fungsi untuk mendapatkan ID user yang sedang login
    Private Function GetCurrentUserId() As Integer
        Return 1 ' Gantilah dengan logika otentikasi yang sesuai
    End Function

    ' Event Form Load
    Private Sub FormOrmas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        LoadComboBox()
    End Sub

    ' Tombol Tambah Data
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using conn As SqlConnection = Koneksi.GetConnection()
            Try
                conn.Open()
                Dim query As String = "INSERT INTO ormas_lks_ormas (nama_ormas, status_legalitas, alamat_kesekretariatan, id_kecamatan, id_kelurahan, nama_ketua, no_hp_ketua, surat_permohonan, status, id_user) " &
                                      "VALUES (@nama_ormas, @status_legalitas, @alamat_kesekretariatan, @id_kecamatan, @id_kelurahan, @nama_ketua, @no_hp_ketua, @surat_permohonan, @status, @id_user)"

                cmd = New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nama_ormas", txtNamaOrmas.Text)
                cmd.Parameters.AddWithValue("@status_legalitas", "Berbadan Hukum")
                cmd.Parameters.AddWithValue("@alamat_kesekretariatan", txtAlamat.Text)
                cmd.Parameters.AddWithValue("@id_kecamatan", cmbKecamatan.SelectedValue)
                cmd.Parameters.AddWithValue("@id_kelurahan", cmbKelurahan.SelectedValue)
                cmd.Parameters.AddWithValue("@nama_ketua", txtNamaKetua.Text)
                cmd.Parameters.AddWithValue("@no_hp_ketua", txtNoHPKetua.Text)
                cmd.Parameters.AddWithValue("@surat_permohonan", txtSuratPermohonan.Text)
                cmd.Parameters.AddWithValue("@status", "Daftar")
                cmd.Parameters.AddWithValue("@id_user", GetCurrentUserId())

                cmd.ExecuteNonQuery()

                MessageBox.Show("Data berhasil ditambahkan!")
                LoadData()
                ClearFormFields()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Tombol Edit Data
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dataGridOrmas.SelectedRows.Count > 0 Then
            Dim idOrmas As Integer = Convert.ToInt32(dataGridOrmas.SelectedRows(0).Cells("id_ormas").Value)
            Using conn As SqlConnection = Koneksi.GetConnection()
                Try
                    conn.Open()
                    Dim query As String = "UPDATE ormas_lks_ormas SET nama_ormas = @nama_ormas, status_legalitas = @status_legalitas, " &
                                          "alamat_kesekretariatan = @alamat_kesekretariatan, id_kecamatan = @id_kecamatan, " &
                                          "id_kelurahan = @id_kelurahan, nama_ketua = @nama_ketua, no_hp_ketua = @no_hp_ketua, " &
                                          "surat_permohonan = @surat_permohonan, status = @status WHERE id_ormas = @id_ormas"

                    cmd = New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_ormas", idOrmas)
                    cmd.Parameters.AddWithValue("@nama_ormas", txtNamaOrmas.Text)
                    cmd.Parameters.AddWithValue("@status_legalitas", "Berbadan Hukum")
                    cmd.Parameters.AddWithValue("@alamat_kesekretariatan", txtAlamat.Text)
                    cmd.Parameters.AddWithValue("@id_kecamatan", cmbKecamatan.SelectedValue)
                    cmd.Parameters.AddWithValue("@id_kelurahan", cmbKelurahan.SelectedValue)
                    cmd.Parameters.AddWithValue("@nama_ketua", txtNamaKetua.Text)
                    cmd.Parameters.AddWithValue("@no_hp_ketua", txtNoHPKetua.Text)
                    cmd.Parameters.AddWithValue("@surat_permohonan", txtSuratPermohonan.Text)
                    cmd.Parameters.AddWithValue("@status", "Daftar")

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Data berhasil diperbarui!")
                    LoadData()
                    ClearFormFields()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Pilih data yang akan diedit!")
        End If
    End Sub

    ' Tombol Hapus Data
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dataGridOrmas.SelectedRows.Count > 0 Then
            Dim idOrmas As Integer = Convert.ToInt32(dataGridOrmas.SelectedRows(0).Cells("id_ormas").Value)
            Using conn As SqlConnection = Koneksi.GetConnection()
                Try
                    conn.Open()
                    Dim query As String = "DELETE FROM ormas_lks_ormas WHERE id_ormas = @id_ormas"
                    cmd = New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_ormas", idOrmas)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Data berhasil dihapus!")
                    LoadData()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Pilih data yang akan dihapus!")
        End If
    End Sub

    ' Clear form fields after Add or Edit
    Private Sub ClearFormFields()
        txtNamaOrmas.Clear()
        txtAlamat.Clear()
        txtNamaKetua.Clear()
        txtNoHPKetua.Clear()
        txtSuratPermohonan.Clear()
        cmbKecamatan.SelectedIndex = -1
        cmbKelurahan.SelectedIndex = -1
    End Sub

End Class
