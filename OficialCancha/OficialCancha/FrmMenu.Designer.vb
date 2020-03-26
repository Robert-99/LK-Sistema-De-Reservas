<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuPrincipal))
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.LblNiveldeUsuario = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabPrincipal = New System.Windows.Forms.TabControl()
        Me.TabMenuPrincipal = New System.Windows.Forms.TabPage()
        Me.TabReservas = New System.Windows.Forms.TabPage()
        Me.TabClientes = New System.Windows.Forms.TabPage()
        Me.PanelModificar = New System.Windows.Forms.Panel()
        Me.TxtModificarID = New System.Windows.Forms.TextBox()
        Me.ID = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxtModificarTelefono = New System.Windows.Forms.TextBox()
        Me.BtnTodoAlaNormalidad = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtModificarNroDeCe = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtModificarApellidos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtModificarNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.PanelCargarRegistro = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TabControlClientes = New System.Windows.Forms.TabControl()
        Me.TabRegistroClientes = New System.Windows.Forms.TabPage()
        Me.TxtTelefonoClientes = New System.Windows.Forms.TextBox()
        Me.LblTelefonoCliente = New System.Windows.Forms.Label()
        Me.TxtNroDeCedulaClientes = New System.Windows.Forms.TextBox()
        Me.LblNroDeCedula = New System.Windows.Forms.Label()
        Me.TxtApellidosClientes = New System.Windows.Forms.TextBox()
        Me.LblApellidosClientes = New System.Windows.Forms.Label()
        Me.TxtNombreCliente = New System.Windows.Forms.TextBox()
        Me.LblNombreCliente = New System.Windows.Forms.Label()
        Me.TxtIdCliente = New System.Windows.Forms.TextBox()
        Me.LblID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabCredito = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxtBuscarClientes = New System.Windows.Forms.TextBox()
        Me.LabelBuscar = New System.Windows.Forms.Label()
        Me.LabelClientes = New System.Windows.Forms.Label()
        Me.TabProductos = New System.Windows.Forms.TabPage()
        Me.TabVentas = New System.Windows.Forms.TabPage()
        Me.TabCaja = New System.Windows.Forms.TabPage()
        Me.TabUsuarios = New System.Windows.Forms.TabPage()
        Me.PanelDeMenu = New System.Windows.Forms.Panel()
        Me.BtnUsuarios = New System.Windows.Forms.Button()
        Me.BtnMenuPrincipal = New System.Windows.Forms.Button()
        Me.BtnCaja = New System.Windows.Forms.Button()
        Me.BtnReservas = New System.Windows.Forms.Button()
        Me.BtnVentas = New System.Windows.Forms.Button()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.BtnProductos = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabPrincipal.SuspendLayout()
        Me.TabClientes.SuspendLayout()
        Me.PanelModificar.SuspendLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCargarRegistro.SuspendLayout()
        Me.TabControlClientes.SuspendLayout()
        Me.TabRegistroClientes.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanelDeMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.Green
        Me.PanelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTitulo.Controls.Add(Me.BtnCerrar)
        Me.PanelTitulo.Controls.Add(Me.LblNiveldeUsuario)
        Me.PanelTitulo.Controls.Add(Me.LblUsuario)
        Me.PanelTitulo.Controls.Add(Me.PictureBox1)
        Me.PanelTitulo.Controls.Add(Me.Label1)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(1084, 73)
        Me.PanelTitulo.TabIndex = 0
        '
        'LblNiveldeUsuario
        '
        Me.LblNiveldeUsuario.AutoSize = True
        Me.LblNiveldeUsuario.BackColor = System.Drawing.Color.Green
        Me.LblNiveldeUsuario.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNiveldeUsuario.ForeColor = System.Drawing.SystemColors.Control
        Me.LblNiveldeUsuario.Location = New System.Drawing.Point(891, 32)
        Me.LblNiveldeUsuario.Name = "LblNiveldeUsuario"
        Me.LblNiveldeUsuario.Size = New System.Drawing.Size(13, 19)
        Me.LblNiveldeUsuario.TabIndex = 3
        Me.LblNiveldeUsuario.Text = "."
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.ForeColor = System.Drawing.SystemColors.Control
        Me.LblUsuario.Location = New System.Drawing.Point(807, 32)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(66, 19)
        Me.LblUsuario.TabIndex = 2
        Me.LblUsuario.Text = "Usuario:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(105, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sistema de Reservas"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabPrincipal)
        Me.Panel1.Controls.Add(Me.PanelDeMenu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1084, 491)
        Me.Panel1.TabIndex = 2
        '
        'TabPrincipal
        '
        Me.TabPrincipal.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabPrincipal.Controls.Add(Me.TabMenuPrincipal)
        Me.TabPrincipal.Controls.Add(Me.TabReservas)
        Me.TabPrincipal.Controls.Add(Me.TabClientes)
        Me.TabPrincipal.Controls.Add(Me.TabProductos)
        Me.TabPrincipal.Controls.Add(Me.TabVentas)
        Me.TabPrincipal.Controls.Add(Me.TabCaja)
        Me.TabPrincipal.Controls.Add(Me.TabUsuarios)
        Me.TabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPrincipal.Location = New System.Drawing.Point(152, 0)
        Me.TabPrincipal.Name = "TabPrincipal"
        Me.TabPrincipal.SelectedIndex = 0
        Me.TabPrincipal.Size = New System.Drawing.Size(932, 491)
        Me.TabPrincipal.TabIndex = 3
        '
        'TabMenuPrincipal
        '
        Me.TabMenuPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabMenuPrincipal.Location = New System.Drawing.Point(4, 4)
        Me.TabMenuPrincipal.Name = "TabMenuPrincipal"
        Me.TabMenuPrincipal.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMenuPrincipal.Size = New System.Drawing.Size(924, 465)
        Me.TabMenuPrincipal.TabIndex = 0
        Me.TabMenuPrincipal.Text = "Menu Principal"
        Me.TabMenuPrincipal.UseVisualStyleBackColor = True
        '
        'TabReservas
        '
        Me.TabReservas.Location = New System.Drawing.Point(4, 4)
        Me.TabReservas.Name = "TabReservas"
        Me.TabReservas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabReservas.Size = New System.Drawing.Size(924, 465)
        Me.TabReservas.TabIndex = 1
        Me.TabReservas.Text = "Reservas"
        Me.TabReservas.UseVisualStyleBackColor = True
        '
        'TabClientes
        '
        Me.TabClientes.Controls.Add(Me.PanelModificar)
        Me.TabClientes.Controls.Add(Me.BtnEliminar)
        Me.TabClientes.Controls.Add(Me.BtnModificar)
        Me.TabClientes.Controls.Add(Me.Grilla)
        Me.TabClientes.Controls.Add(Me.PanelCargarRegistro)
        Me.TabClientes.Controls.Add(Me.Panel4)
        Me.TabClientes.Location = New System.Drawing.Point(4, 4)
        Me.TabClientes.Name = "TabClientes"
        Me.TabClientes.Size = New System.Drawing.Size(924, 465)
        Me.TabClientes.TabIndex = 2
        Me.TabClientes.Text = "Clientes"
        Me.TabClientes.UseVisualStyleBackColor = True
        '
        'PanelModificar
        '
        Me.PanelModificar.Controls.Add(Me.TxtModificarID)
        Me.PanelModificar.Controls.Add(Me.ID)
        Me.PanelModificar.Controls.Add(Me.BtnAceptar)
        Me.PanelModificar.Controls.Add(Me.TxtModificarTelefono)
        Me.PanelModificar.Controls.Add(Me.BtnTodoAlaNormalidad)
        Me.PanelModificar.Controls.Add(Me.Label6)
        Me.PanelModificar.Controls.Add(Me.TxtModificarNroDeCe)
        Me.PanelModificar.Controls.Add(Me.Label5)
        Me.PanelModificar.Controls.Add(Me.TxtModificarApellidos)
        Me.PanelModificar.Controls.Add(Me.Label4)
        Me.PanelModificar.Controls.Add(Me.TxtModificarNombre)
        Me.PanelModificar.Controls.Add(Me.Label3)
        Me.PanelModificar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelModificar.Enabled = False
        Me.PanelModificar.Location = New System.Drawing.Point(269, 318)
        Me.PanelModificar.Name = "PanelModificar"
        Me.PanelModificar.Size = New System.Drawing.Size(655, 147)
        Me.PanelModificar.TabIndex = 5
        '
        'TxtModificarID
        '
        Me.TxtModificarID.Location = New System.Drawing.Point(52, 4)
        Me.TxtModificarID.Name = "TxtModificarID"
        Me.TxtModificarID.Size = New System.Drawing.Size(48, 20)
        Me.TxtModificarID.TabIndex = 25
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Location = New System.Drawing.Point(28, 7)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(18, 13)
        Me.ID.TabIndex = 24
        Me.ID.Text = "ID"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(551, 34)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 23
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxtModificarTelefono
        '
        Me.TxtModificarTelefono.Location = New System.Drawing.Point(318, 91)
        Me.TxtModificarTelefono.Name = "TxtModificarTelefono"
        Me.TxtModificarTelefono.Size = New System.Drawing.Size(188, 20)
        Me.TxtModificarTelefono.TabIndex = 22
        '
        'BtnTodoAlaNormalidad
        '
        Me.BtnTodoAlaNormalidad.Location = New System.Drawing.Point(551, 88)
        Me.BtnTodoAlaNormalidad.Name = "BtnTodoAlaNormalidad"
        Me.BtnTodoAlaNormalidad.Size = New System.Drawing.Size(75, 23)
        Me.BtnTodoAlaNormalidad.TabIndex = 4
        Me.BtnTodoAlaNormalidad.Text = "Cancelar"
        Me.BtnTodoAlaNormalidad.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(315, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Telefono"
        '
        'TxtModificarNroDeCe
        '
        Me.TxtModificarNroDeCe.Location = New System.Drawing.Point(318, 49)
        Me.TxtModificarNroDeCe.Name = "TxtModificarNroDeCe"
        Me.TxtModificarNroDeCe.Size = New System.Drawing.Size(188, 20)
        Me.TxtModificarNroDeCe.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(315, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Número de Cedula"
        '
        'TxtModificarApellidos
        '
        Me.TxtModificarApellidos.Location = New System.Drawing.Point(33, 91)
        Me.TxtModificarApellidos.Name = "TxtModificarApellidos"
        Me.TxtModificarApellidos.Size = New System.Drawing.Size(188, 20)
        Me.TxtModificarApellidos.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Apelldos"
        '
        'TxtModificarNombre
        '
        Me.TxtModificarNombre.Location = New System.Drawing.Point(33, 49)
        Me.TxtModificarNombre.Name = "TxtModificarNombre"
        Me.TxtModificarNombre.Size = New System.Drawing.Size(188, 20)
        Me.TxtModificarNombre.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nombres"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(527, 281)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(97, 23)
        Me.BtnEliminar.TabIndex = 3
        Me.BtnEliminar.Text = "EliminarRegistro"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(317, 281)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 3
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'Grilla
        '
        Me.Grilla.AllowUserToAddRows = False
        Me.Grilla.AllowUserToDeleteRows = False
        Me.Grilla.BackgroundColor = System.Drawing.Color.White
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Dock = System.Windows.Forms.DockStyle.Top
        Me.Grilla.Location = New System.Drawing.Point(269, 51)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.ReadOnly = True
        Me.Grilla.Size = New System.Drawing.Size(655, 218)
        Me.Grilla.TabIndex = 2
        '
        'PanelCargarRegistro
        '
        Me.PanelCargarRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelCargarRegistro.Controls.Add(Me.BtnCancelar)
        Me.PanelCargarRegistro.Controls.Add(Me.BtnAgregar)
        Me.PanelCargarRegistro.Controls.Add(Me.TabControlClientes)
        Me.PanelCargarRegistro.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelCargarRegistro.Location = New System.Drawing.Point(0, 51)
        Me.PanelCargarRegistro.Name = "PanelCargarRegistro"
        Me.PanelCargarRegistro.Size = New System.Drawing.Size(269, 414)
        Me.PanelCargarRegistro.TabIndex = 1
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(137, 319)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 2
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(24, 319)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 1
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TabControlClientes
        '
        Me.TabControlClientes.Controls.Add(Me.TabRegistroClientes)
        Me.TabControlClientes.Controls.Add(Me.TabCredito)
        Me.TabControlClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControlClientes.Location = New System.Drawing.Point(0, 0)
        Me.TabControlClientes.Name = "TabControlClientes"
        Me.TabControlClientes.SelectedIndex = 0
        Me.TabControlClientes.Size = New System.Drawing.Size(267, 298)
        Me.TabControlClientes.TabIndex = 0
        '
        'TabRegistroClientes
        '
        Me.TabRegistroClientes.Controls.Add(Me.TxtTelefonoClientes)
        Me.TabRegistroClientes.Controls.Add(Me.LblTelefonoCliente)
        Me.TabRegistroClientes.Controls.Add(Me.TxtNroDeCedulaClientes)
        Me.TabRegistroClientes.Controls.Add(Me.LblNroDeCedula)
        Me.TabRegistroClientes.Controls.Add(Me.TxtApellidosClientes)
        Me.TabRegistroClientes.Controls.Add(Me.LblApellidosClientes)
        Me.TabRegistroClientes.Controls.Add(Me.TxtNombreCliente)
        Me.TabRegistroClientes.Controls.Add(Me.LblNombreCliente)
        Me.TabRegistroClientes.Controls.Add(Me.TxtIdCliente)
        Me.TabRegistroClientes.Controls.Add(Me.LblID)
        Me.TabRegistroClientes.Controls.Add(Me.Label2)
        Me.TabRegistroClientes.Location = New System.Drawing.Point(4, 22)
        Me.TabRegistroClientes.Name = "TabRegistroClientes"
        Me.TabRegistroClientes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRegistroClientes.Size = New System.Drawing.Size(259, 272)
        Me.TabRegistroClientes.TabIndex = 0
        Me.TabRegistroClientes.Text = "Registro De Clientes"
        Me.TabRegistroClientes.UseVisualStyleBackColor = True
        '
        'TxtTelefonoClientes
        '
        Me.TxtTelefonoClientes.Location = New System.Drawing.Point(20, 244)
        Me.TxtTelefonoClientes.Name = "TxtTelefonoClientes"
        Me.TxtTelefonoClientes.Size = New System.Drawing.Size(188, 20)
        Me.TxtTelefonoClientes.TabIndex = 12
        '
        'LblTelefonoCliente
        '
        Me.LblTelefonoCliente.AutoSize = True
        Me.LblTelefonoCliente.Location = New System.Drawing.Point(17, 228)
        Me.LblTelefonoCliente.Name = "LblTelefonoCliente"
        Me.LblTelefonoCliente.Size = New System.Drawing.Size(49, 13)
        Me.LblTelefonoCliente.TabIndex = 11
        Me.LblTelefonoCliente.Text = "Telefono"
        '
        'TxtNroDeCedulaClientes
        '
        Me.TxtNroDeCedulaClientes.Location = New System.Drawing.Point(20, 198)
        Me.TxtNroDeCedulaClientes.Name = "TxtNroDeCedulaClientes"
        Me.TxtNroDeCedulaClientes.Size = New System.Drawing.Size(188, 20)
        Me.TxtNroDeCedulaClientes.TabIndex = 10
        '
        'LblNroDeCedula
        '
        Me.LblNroDeCedula.AutoSize = True
        Me.LblNroDeCedula.Location = New System.Drawing.Point(17, 182)
        Me.LblNroDeCedula.Name = "LblNroDeCedula"
        Me.LblNroDeCedula.Size = New System.Drawing.Size(95, 13)
        Me.LblNroDeCedula.TabIndex = 9
        Me.LblNroDeCedula.Text = "Número de Cedula"
        '
        'TxtApellidosClientes
        '
        Me.TxtApellidosClientes.Location = New System.Drawing.Point(20, 153)
        Me.TxtApellidosClientes.Name = "TxtApellidosClientes"
        Me.TxtApellidosClientes.Size = New System.Drawing.Size(188, 20)
        Me.TxtApellidosClientes.TabIndex = 8
        '
        'LblApellidosClientes
        '
        Me.LblApellidosClientes.AutoSize = True
        Me.LblApellidosClientes.Location = New System.Drawing.Point(17, 137)
        Me.LblApellidosClientes.Name = "LblApellidosClientes"
        Me.LblApellidosClientes.Size = New System.Drawing.Size(47, 13)
        Me.LblApellidosClientes.TabIndex = 7
        Me.LblApellidosClientes.Text = "Apelldos"
        '
        'TxtNombreCliente
        '
        Me.TxtNombreCliente.Location = New System.Drawing.Point(20, 107)
        Me.TxtNombreCliente.Name = "TxtNombreCliente"
        Me.TxtNombreCliente.Size = New System.Drawing.Size(188, 20)
        Me.TxtNombreCliente.TabIndex = 6
        '
        'LblNombreCliente
        '
        Me.LblNombreCliente.AutoSize = True
        Me.LblNombreCliente.Location = New System.Drawing.Point(17, 91)
        Me.LblNombreCliente.Name = "LblNombreCliente"
        Me.LblNombreCliente.Size = New System.Drawing.Size(49, 13)
        Me.LblNombreCliente.TabIndex = 5
        Me.LblNombreCliente.Text = "Nombres"
        '
        'TxtIdCliente
        '
        Me.TxtIdCliente.Enabled = False
        Me.TxtIdCliente.Location = New System.Drawing.Point(20, 59)
        Me.TxtIdCliente.Name = "TxtIdCliente"
        Me.TxtIdCliente.Size = New System.Drawing.Size(188, 20)
        Me.TxtIdCliente.TabIndex = 4
        Me.TxtIdCliente.Text = "0"
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Location = New System.Drawing.Point(17, 43)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(70, 13)
        Me.LblID.TabIndex = 3
        Me.LblID.Text = "ID del Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(32, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Información del Cliente"
        '
        'TabCredito
        '
        Me.TabCredito.Location = New System.Drawing.Point(4, 22)
        Me.TabCredito.Name = "TabCredito"
        Me.TabCredito.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCredito.Size = New System.Drawing.Size(259, 272)
        Me.TabCredito.TabIndex = 1
        Me.TabCredito.Text = "Créditos"
        Me.TabCredito.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.TxtBuscarClientes)
        Me.Panel4.Controls.Add(Me.LabelBuscar)
        Me.Panel4.Controls.Add(Me.LabelClientes)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(924, 51)
        Me.Panel4.TabIndex = 0
        '
        'TxtBuscarClientes
        '
        Me.TxtBuscarClientes.Location = New System.Drawing.Point(479, 17)
        Me.TxtBuscarClientes.Name = "TxtBuscarClientes"
        Me.TxtBuscarClientes.Size = New System.Drawing.Size(190, 20)
        Me.TxtBuscarClientes.TabIndex = 2
        '
        'LabelBuscar
        '
        Me.LabelBuscar.AutoSize = True
        Me.LabelBuscar.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelBuscar.Location = New System.Drawing.Point(347, 11)
        Me.LabelBuscar.Name = "LabelBuscar"
        Me.LabelBuscar.Size = New System.Drawing.Size(81, 27)
        Me.LabelBuscar.TabIndex = 1
        Me.LabelBuscar.Text = "Buscar"
        '
        'LabelClientes
        '
        Me.LabelClientes.AutoSize = True
        Me.LabelClientes.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelClientes.Location = New System.Drawing.Point(19, 10)
        Me.LabelClientes.Name = "LabelClientes"
        Me.LabelClientes.Size = New System.Drawing.Size(92, 27)
        Me.LabelClientes.TabIndex = 0
        Me.LabelClientes.Text = "Clientes"
        '
        'TabProductos
        '
        Me.TabProductos.Location = New System.Drawing.Point(4, 4)
        Me.TabProductos.Name = "TabProductos"
        Me.TabProductos.Size = New System.Drawing.Size(924, 465)
        Me.TabProductos.TabIndex = 3
        Me.TabProductos.Text = "Productos"
        Me.TabProductos.UseVisualStyleBackColor = True
        '
        'TabVentas
        '
        Me.TabVentas.Location = New System.Drawing.Point(4, 4)
        Me.TabVentas.Name = "TabVentas"
        Me.TabVentas.Size = New System.Drawing.Size(924, 465)
        Me.TabVentas.TabIndex = 4
        Me.TabVentas.Text = "Ventas"
        Me.TabVentas.UseVisualStyleBackColor = True
        '
        'TabCaja
        '
        Me.TabCaja.Location = New System.Drawing.Point(4, 4)
        Me.TabCaja.Name = "TabCaja"
        Me.TabCaja.Size = New System.Drawing.Size(924, 465)
        Me.TabCaja.TabIndex = 5
        Me.TabCaja.Text = "Caja"
        Me.TabCaja.UseVisualStyleBackColor = True
        '
        'TabUsuarios
        '
        Me.TabUsuarios.Location = New System.Drawing.Point(4, 4)
        Me.TabUsuarios.Name = "TabUsuarios"
        Me.TabUsuarios.Size = New System.Drawing.Size(924, 465)
        Me.TabUsuarios.TabIndex = 6
        Me.TabUsuarios.Text = "Usuarios"
        Me.TabUsuarios.UseVisualStyleBackColor = True
        '
        'PanelDeMenu
        '
        Me.PanelDeMenu.BackColor = System.Drawing.Color.Green
        Me.PanelDeMenu.Controls.Add(Me.BtnUsuarios)
        Me.PanelDeMenu.Controls.Add(Me.BtnMenuPrincipal)
        Me.PanelDeMenu.Controls.Add(Me.BtnCaja)
        Me.PanelDeMenu.Controls.Add(Me.BtnReservas)
        Me.PanelDeMenu.Controls.Add(Me.BtnVentas)
        Me.PanelDeMenu.Controls.Add(Me.BtnClientes)
        Me.PanelDeMenu.Controls.Add(Me.BtnProductos)
        Me.PanelDeMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelDeMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelDeMenu.Name = "PanelDeMenu"
        Me.PanelDeMenu.Size = New System.Drawing.Size(152, 491)
        Me.PanelDeMenu.TabIndex = 0
        '
        'BtnUsuarios
        '
        Me.BtnUsuarios.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUsuarios.Location = New System.Drawing.Point(0, 388)
        Me.BtnUsuarios.Name = "BtnUsuarios"
        Me.BtnUsuarios.Size = New System.Drawing.Size(151, 34)
        Me.BtnUsuarios.TabIndex = 25
        Me.BtnUsuarios.Text = "Usuarios"
        Me.BtnUsuarios.UseVisualStyleBackColor = True
        '
        'BtnMenuPrincipal
        '
        Me.BtnMenuPrincipal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnMenuPrincipal.BackColor = System.Drawing.SystemColors.Control
        Me.BtnMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMenuPrincipal.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMenuPrincipal.ForeColor = System.Drawing.Color.Black
        Me.BtnMenuPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMenuPrincipal.Location = New System.Drawing.Point(0, 70)
        Me.BtnMenuPrincipal.Name = "BtnMenuPrincipal"
        Me.BtnMenuPrincipal.Size = New System.Drawing.Size(151, 34)
        Me.BtnMenuPrincipal.TabIndex = 19
        Me.BtnMenuPrincipal.Text = "Menu Principal"
        Me.BtnMenuPrincipal.UseVisualStyleBackColor = False
        '
        'BtnCaja
        '
        Me.BtnCaja.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCaja.Location = New System.Drawing.Point(0, 334)
        Me.BtnCaja.Name = "BtnCaja"
        Me.BtnCaja.Size = New System.Drawing.Size(151, 34)
        Me.BtnCaja.TabIndex = 24
        Me.BtnCaja.Text = "Caja"
        Me.BtnCaja.UseVisualStyleBackColor = True
        '
        'BtnReservas
        '
        Me.BtnReservas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReservas.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReservas.Location = New System.Drawing.Point(0, 121)
        Me.BtnReservas.Name = "BtnReservas"
        Me.BtnReservas.Size = New System.Drawing.Size(151, 34)
        Me.BtnReservas.TabIndex = 20
        Me.BtnReservas.Text = "Reservas"
        Me.BtnReservas.UseVisualStyleBackColor = True
        '
        'BtnVentas
        '
        Me.BtnVentas.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentas.Location = New System.Drawing.Point(0, 285)
        Me.BtnVentas.Name = "BtnVentas"
        Me.BtnVentas.Size = New System.Drawing.Size(151, 34)
        Me.BtnVentas.TabIndex = 23
        Me.BtnVentas.Text = "Ventas"
        Me.BtnVentas.UseVisualStyleBackColor = True
        '
        'BtnClientes
        '
        Me.BtnClientes.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientes.Location = New System.Drawing.Point(0, 174)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(151, 34)
        Me.BtnClientes.TabIndex = 21
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'BtnProductos
        '
        Me.BtnProductos.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductos.Location = New System.Drawing.Point(0, 230)
        Me.BtnProductos.Name = "BtnProductos"
        Me.BtnProductos.Size = New System.Drawing.Size(151, 34)
        Me.BtnProductos.TabIndex = 22
        Me.BtnProductos.Text = "Productos"
        Me.BtnProductos.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.Red
        Me.BtnCerrar.ForeColor = System.Drawing.Color.White
        Me.BtnCerrar.Location = New System.Drawing.Point(1052, 3)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(27, 24)
        Me.BtnCerrar.TabIndex = 4
        Me.BtnCerrar.Text = "X"
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'FrmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 564)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "FrmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Cancha"
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TabPrincipal.ResumeLayout(False)
        Me.TabClientes.ResumeLayout(False)
        Me.PanelModificar.ResumeLayout(False)
        Me.PanelModificar.PerformLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCargarRegistro.ResumeLayout(False)
        Me.TabControlClientes.ResumeLayout(False)
        Me.TabRegistroClientes.ResumeLayout(False)
        Me.TabRegistroClientes.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.PanelDeMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelDeMenu As Panel
    Friend WithEvents BtnUsuarios As Button
    Friend WithEvents BtnMenuPrincipal As Button
    Friend WithEvents BtnCaja As Button
    Friend WithEvents BtnReservas As Button
    Friend WithEvents BtnVentas As Button
    Friend WithEvents BtnClientes As Button
    Friend WithEvents BtnProductos As Button
    Friend WithEvents TabPrincipal As TabControl
    Friend WithEvents TabMenuPrincipal As TabPage
    Friend WithEvents TabReservas As TabPage
    Friend WithEvents TabClientes As TabPage
    Friend WithEvents PanelCargarRegistro As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TabProductos As TabPage
    Friend WithEvents TabVentas As TabPage
    Friend WithEvents TabCaja As TabPage
    Friend WithEvents TabUsuarios As TabPage
    Friend WithEvents TabControlClientes As TabControl
    Friend WithEvents TabRegistroClientes As TabPage
    Friend WithEvents LblTelefonoCliente As Label
    Friend WithEvents TxtNroDeCedulaClientes As TextBox
    Friend WithEvents LblNroDeCedula As Label
    Friend WithEvents TxtApellidosClientes As TextBox
    Friend WithEvents LblApellidosClientes As Label
    Friend WithEvents TxtNombreCliente As TextBox
    Friend WithEvents LblNombreCliente As Label
    Friend WithEvents TxtIdCliente As TextBox
    Friend WithEvents LblID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabCredito As TabPage
    Friend WithEvents TxtBuscarClientes As TextBox
    Friend WithEvents LabelBuscar As Label
    Friend WithEvents LabelClientes As Label
    Friend WithEvents Grilla As DataGridView
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents TxtTelefonoClientes As TextBox
    Friend WithEvents BtnTodoAlaNormalidad As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents PanelModificar As Panel
    Friend WithEvents TxtModificarTelefono As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtModificarNroDeCe As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtModificarApellidos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtModificarNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents TxtModificarID As TextBox
    Friend WithEvents ID As Label
    Friend WithEvents LblNiveldeUsuario As Label
    Friend WithEvents LblUsuario As Label
    Friend WithEvents BtnCerrar As Button
End Class
