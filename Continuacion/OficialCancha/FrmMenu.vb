Imports MySql.Data.MySqlClient
Public Class FrmMenuPrincipal
    Dim ejecutar As New EventoDelTextbox
    Public Operacion As String
    Private Sub FrmMenuPrincipal_Load(sender As Object, e As EventArgs)
        'Call CargarGrilla("")
    End Sub
    'Public Sub CargarGrilla(condicion As String)
    '    Dim sql As String
    '    Dim consulta As New MySqlDataAdapter
    '    Dim resultado As New DataSet
    '    Try
    '        Call AbrirConexion()
    '        sql = "select * from clientes " + condicion
    '        consulta = New MySqlDataAdapter(sql, conexion)
    '        consulta.Fill(resultado, "rsClienteResultado")
    '        Grilla.DataSource = resultado.Tables("rsClienteResultado")
    '        Call CerrarConexion()
    '    Catch ex As MySqlException
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        'TabPrincipal.SelectedIndex = 2
        AbrirFormulario(New FormClientes)
        Me.DoubleBuffered = True
        'Call CargarGrilla("")
    End Sub
#Region "Textbox Eventos"
    Private Sub TxtIdCliente_KeyPress(sender As Object, e As KeyPressEventArgs)
        ejecutar.numeroKeyPress(e)
    End Sub
    Private Sub TxtNombreCliente_KeyPress(sender As Object, e As KeyPressEventArgs)
        ejecutar.textoKeyPress(e)
    End Sub
    Private Sub TxtApellidosClientes_KeyPress(sender As Object, e As KeyPressEventArgs)
        ejecutar.textoKeyPress(e)
    End Sub
    Private Sub TxtNroDeCedulaClientes_KeyPress(sender As Object, e As KeyPressEventArgs)
        ejecutar.numeroKeyPress(e)
    End Sub
    Private Sub TxtTelefonoClientes_KeyPress(sender As Object, e As KeyPressEventArgs)
        ejecutar.numeroKeyPress(e)
    End Sub
#End Region
    Private Sub FrmMenuPrincipal_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        LblNiveldeUsuario.Text = gNivelDeUsuario
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
        Login.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If PanelDeMenu.Width = 158 Then
            PanelDeMenu.Width = 58
        Else
            PanelDeMenu.Visible = True
            PanelDeMenu.Width = 158
        End If
    End Sub

    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        AbrirFormulario(New FormUsuarios)
    End Sub

    Private Sub AbrirFormulario(frmhijo As Object)
        If (Panel2.Controls.Count > 0) Then
            Panel2.Controls.RemoveAt(0)
        Else
            Dim frm As Form
            frm = frmhijo
            frm.TopLevel = False
            frm.FormBorderStyle = FormBorderStyle.None
            frm.Dock = DockStyle.Fill
            Panel2.Controls.Add(frm)
            Panel2.Tag = frm
            frm.Show()
            frm.BringToFront()
        End If
    End Sub

End Class

