Imports System.Data.SqlClient

Public Class FormRegister
    Private Sub linkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim LoginForm As New FormLogin()
        LoginForm.Show()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim query As String = "INSERT INTO ormas_lks_user (username, password, nama_lengkap, email, no_hp, level, status) " &
                               "VALUES (@username, @password, @nama_lengkap, @email, @no_hp, 'Ormas', 'Aktif')"

        Using connection As SqlConnection = Koneksi.GetConnection()
            Try
                connection.Open()

                ' Validasi input
                If txtUsername.Text = "" Or txtPassword.Text = "" Or txtNamaLengkap.Text = "" Or txtEmail.Text = "" Or txtNoHp.Text = "" Then
                    MessageBox.Show("Semua field wajib diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@username", txtUsername.Text)
                    command.Parameters.AddWithValue("@password", txtPassword.Text)
                    command.Parameters.AddWithValue("@nama_lengkap", txtNamaLengkap.Text)
                    command.Parameters.AddWithValue("@email", txtEmail.Text)
                    command.Parameters.AddWithValue("@no_hp", txtNoHp.Text)

                    command.ExecuteNonQuery()
                    MessageBox.Show("Registrasi berhasil! Silakan login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    FormLogin.Show()
                    Me.Hide()
                End Using
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        FormLogin.Show()
        Me.Hide()
    End Sub
End Class