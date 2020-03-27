Imports MySql.Data.MySqlClient
Public Class FormUsuarios
    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrillaUsuario("")
    End Sub
    Public Sub CargarGrillaUsuario(condicion As String)
        Dim sql As String
        Dim consulta As New MySqlDataAdapter
        Dim resultado As New DataSet
        Try
            Call AbrirConexion()
            sql = "select * from usuario " + condicion
            consulta = New MySqlDataAdapter(sql, conexion)
            consulta.Fill(resultado, "rsUsuarios")
            Tabla.DataSource = resultado.Tables("rsUsuarios")
            Call CerrarConexion()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnAceptarAgregar_Click(sender As Object, e As EventArgs) Handles BtnAceptarAgregar.Click

    End Sub

    Private Sub BtnCancelarAgregar_Click(sender As Object, e As EventArgs) Handles BtnCancelarAgregar.Click
        Me.Close()
    End Sub
    'Public Sub agregarRegistro()
    '    Dim sql As String
    '    Dim comando As MySqlCommand
    '    sql = "insert into clientes(Nombres,Apellidos,NroDeCedula,Telefono) values(@nom,@ape,@NroC,@Tel)"
    '    Try
    '        Call AbrirConexion()
    '        comando = New MySqlCommand(sql, conexion)
    '        comando.Parameters.AddWithValue("@nom", TxtNombreCliente.Text)
    '        comando.Parameters.AddWithValue("@ape", TxtApellidosClientes.Text)
    '        comando.Parameters.AddWithValue("@NroC", TxtNroDeCedulaClientes.Text)
    '        comando.Parameters.AddWithValue("@Tel", TxtTelefonoClientes.Text)
    '        comando.ExecuteNonQuery()
    '        Call CerrarConexion()
    '        MsgBox("Registro Actualizado correctamente")
    '        CargarGrillaUsuario("")
    '    Catch msgError As MySqlException
    '        MsgBox(msgError.Message)
    '    End Try
    'End Sub
End Class