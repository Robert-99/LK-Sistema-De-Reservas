Imports MySql.Data.MySqlClient
Public Class FormClientes
    Public Operacion As String
    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrilla("")
    End Sub
    Public Sub CargarGrilla(condicion As String)
        Dim sql As String
        Dim consulta As New MySqlDataAdapter
        Dim resultado As New DataSet
        Try
            Call AbrirConexion()
            sql = "select * from clientes " + condicion
            consulta = New MySqlDataAdapter(sql, conexion)
            consulta.Fill(resultado, "rsClienteResultado")
            Grilla.DataSource = resultado.Tables("rsClienteResultado")
            Call CerrarConexion()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cargarRegistro(id As String, op As String)
        If op = "MODIFICAR" Then
            Dim SQL As String
            Dim consulta As New MySqlDataAdapter
            Dim resultado As New DataSet
            Try
                Call AbrirConexion()
                SQL = "select * from clientes where IDClientes=" + id
                consulta = New MySqlDataAdapter(SQL, conexion)
                consulta.Fill(resultado, "rsClientes")
                TxtModificarID.Text = resultado.Tables("rsClientes").Rows(0).Item("IDClientes")
                TxtModificarNombre.Text = resultado.Tables("rsClientes").Rows(0).Item("Nombres")
                TxtModificarApellidos.Text = resultado.Tables("rsClientes").Rows(0).Item("Apellidos")
                TxtModificarNroDeCe.Text = resultado.Tables("rsClientes").Rows(0).Item("NroDeCedula")
                TxtModificarTelefono.Text = resultado.Tables("rsClientes").Rows(0).Item("Telefono")
                Call CerrarConexion()
            Catch msgError As MySqlException
                MsgBox(msgError.Message)
            End Try
        ElseIf op = "AGREGAR" Then
            TxtIdCliente.Text = "0"
        End If
    End Sub
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Call cargarRegistro(0, "AGREGAR")
        Operacion = "AGREGAR"
        Call agregarRegistro()
        TxtIdCliente.Text = ""
        TxtNombreCliente.Text = ""
        TxtApellidosClientes.Text = ""
        TxtNroDeCedulaClientes.Text = ""
        TxtTelefonoClientes.Text = ""
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        TxtIdCliente.Text = ""
        TxtNombreCliente.Text = ""
        TxtApellidosClientes.Text = ""
        TxtNroDeCedulaClientes.Text = ""
        TxtTelefonoClientes.Text = ""
    End Sub
    Public Sub agregarRegistro()
        Dim sql As String
        Dim comando As MySqlCommand
        sql = "insert into clientes(Nombres,Apellidos,NroDeCedula,Telefono) values(@nom,@ape,@NroC,@Tel)"
        Try
            Call AbrirConexion()
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@nom", TxtNombreCliente.Text)
            comando.Parameters.AddWithValue("@ape", TxtApellidosClientes.Text)
            comando.Parameters.AddWithValue("@NroC", TxtNroDeCedulaClientes.Text)
            comando.Parameters.AddWithValue("@Tel", TxtTelefonoClientes.Text)
            comando.ExecuteNonQuery()
            Call CerrarConexion()
            MsgBox("Registro Actualizado correctamente")
            CargarGrilla("")
        Catch msgError As MySqlException
            MsgBox(msgError.Message)
        End Try
    End Sub
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        PanelCargarRegistro.Enabled = False
        PanelModificar.Enabled = True
        'PanelDeMenu.Enabled = False
        BtnEliminar.Enabled = False
        Dim codigo As Integer
        codigo = Grilla.Item(0, Grilla.CurrentRow.Index).Value
        cargarRegistro(codigo, "MODIFICAR")
        Operacion = "MODIFICAR"
    End Sub
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        PanelCargarRegistro.Enabled = True
        PanelModificar.Enabled = False
        ' PanelDeMenu.Enabled = True
        BtnEliminar.Enabled = True
        Call ModificarRegistro()
        TxtModificarID.Text = ""
        TxtModificarNombre.Text = ""
        TxtModificarApellidos.Text = ""
        TxtModificarNroDeCe.Text = ""
        TxtModificarTelefono.Text = ""
    End Sub
    Public Sub ModificarRegistro()
        Dim sql As String
        Dim comando As MySqlCommand
        sql = "update clientes set Nombres=@nom,Apellidos=@ape,NroDeCedula=@NroC,Telefono=@Tel where IDClientes=@id"
        Try
            Call AbrirConexion()
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@nom", TxtModificarNombre.Text)
            comando.Parameters.AddWithValue("@ape", TxtModificarApellidos.Text)
            comando.Parameters.AddWithValue("@NroC", TxtModificarNroDeCe.Text)
            comando.Parameters.AddWithValue("@Tel", TxtModificarTelefono.Text)
            comando.Parameters.AddWithValue("@id", TxtModificarID.Text)
            comando.ExecuteNonQuery()
            Call CerrarConexion()
            MsgBox("Registro Actualizado correctamente")
            CargarGrilla("")
        Catch msgError As MySqlException
            MsgBox(msgError.Message)
        End Try
    End Sub
    Private Sub BtnTodoAlaNormalidad_Click(sender As Object, e As EventArgs) Handles BtnTodoAlaNormalidad.Click
        TxtModificarID.Text = ""
        TxtModificarNombre.Text = ""
        TxtModificarApellidos.Text = ""
        TxtModificarNroDeCe.Text = ""
        TxtModificarTelefono.Text = ""
        PanelCargarRegistro.Enabled = True
        PanelModificar.Enabled = False
        'PanelDeMenu.Enabled = True
        BtnEliminar.Enabled = True
    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If MsgBox("Desea eliminar Registro?", MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            Dim comando As MySqlCommand
            Dim sql As String
            Dim codigo As String

            codigo = Grilla.Item(0, Grilla.CurrentRow.Index).Value
            Try
                Call AbrirConexion()
                sql = "delete from clientes where IDClientes=@id"
                comando = New MySqlCommand(sql, conexion)
                comando.Parameters.AddWithValue("@id", codigo)
                comando.ExecuteNonQuery()
                Call CerrarConexion()
                MsgBox("Registro eliminado")
                Call CargarGrilla("")
            Catch ex As MySqlException
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub TxtBuscarClientes_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarClientes.TextChanged
        Dim operacion As String
        operacion = "WHERE Nombres LIKE '%" + TxtBuscarClientes.Text + "%' OR Apellidos LIKE '%" + TxtBuscarClientes.Text + "%' OR NroDeCedula like '%" + TxtBuscarClientes.Text + "%' OR Telefono  LIKE '%" + TxtBuscarClientes.Text + "%'"
        Call CargarGrilla(operacion)
    End Sub
End Class