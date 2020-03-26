Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim sql As String
        Dim encri As New CEncriptar()
        'Dim passEncrip As String'
        'passEncrip = CEncriptar.CEncriptar.SurroundingClass.EncryptData(TxtUsuario.Text, TxtContraseña.Text)'
        sql = "select * from usuario where Usuario = '" & TxtUsuario.Text & "' and Contraseña = '" & TxtContraseña.Text & "'"
        Dim comando As MySqlCommand
        Dim ejecutarresulatado As MySqlDataAdapter
        Dim resultado As New DataSet

        Try
            Call AbrirConexion()
            comando = New MySqlCommand(sql, conexion)
            ejecutarresulatado = New MySqlDataAdapter(sql, conexion)
            ejecutarresulatado.Fill(resultado, "rsUsuario")
            Dim leer As MySqlDataReader = comando.ExecuteReader()
            If resultado.Tables("rsUsuario").Rows.Count > 0 Then
                gNombreUsuario = resultado.Tables("rsUsuario").Rows(0).Item("NombreDeUsu")
                gNivelDeUsuario = resultado.Tables("rsUsuario").Rows(0).Item("Nivel")
            End If

            If leer.Read() Then
                Call FrmMenuPrincipal.Show()
                Me.Hide()
            Else
                MessageBox.Show("Error de Inicio de Sesion")
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class