Imports System.Data.SqlClient

Public Class FormLogin
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged, txtPassword.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Konfigurasi koneksi database

        Dim query As String = "SELECT level, status FROM ormas_lks_user WHERE username = @username AND password = @password"

        Using connection As SqlConnection = Koneksi.GetConnection()
            Try
                connection.Open()

                Using command As New SqlCommand(query, connection)
                    ' Parameter untuk mencegah SQL Injection
                    command.Parameters.AddWithValue("@username", txtUsername.Text)
                    command.Parameters.AddWithValue("@password", txtPassword.Text)

                    Dim reader As SqlDataReader = command.ExecuteReader()

                    If reader.Read() Then
                        Dim level As String = reader("level").ToString()
                        Dim status As String = reader("status").ToString()

                        If status = "Aktif" Then
                            If level = "Admin" Then
                                Dim adminForm As New FormAdmin()
                                adminForm.Show()
                                Me.Hide()
                            ElseIf level = "Ormas" Then
                                Dim ormasForm As New FormOrmas()
                                ormasForm.Show()
                                Me.Hide()
                            End If
                        Else
                            MessageBox.Show("Akun Anda tidak aktif.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        MessageBox.Show("Username atau password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label2.Click, Label3.Click

    End Sub

    Private Sub linkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkRegister.LinkClicked
        FormRegister.Show()
        Me.Hide()
    End Sub
End Class
