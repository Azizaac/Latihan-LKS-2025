Imports System.Data.SqlClient

Public Module Koneksi
    ' Properti untuk string koneksi
    Public ReadOnly Property ConnectionString As String
        Get
            Return "Server=LAPTOP-LSE5JD9C\SQLEXPRESS;Database=OrmasLKS;Trusted_Connection=True;TrustServerCertificate=True"
        End Get
    End Property

    ' Fungsi untuk mendapatkan koneksi database
    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(ConnectionString)
    End Function
End Module
