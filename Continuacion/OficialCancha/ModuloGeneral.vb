Imports MySql.Data.MySqlClient
Module ModuloGeneral
    Public conexion As MySqlConnection
    Public gNombreUsuario As String
    Public gNivelDeUsuario As String
    Public Sub AbrirConexion()
        Try
            conexion = New MySqlConnection
            conexion.ConnectionString = "Server=localhost;" & "Database=reservadecanchaoficial;" & "Uid=root;" & "Pwd=123456;"
            conexion.Open()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub CerrarConexion()
        Try
            conexion = New MySqlConnection
            conexion.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
