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
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.LblNiveldeUsuario = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelDeMenu = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnUsuarios = New System.Windows.Forms.Button()
        Me.BtnMenuPrincipal = New System.Windows.Forms.Button()
        Me.BtnCaja = New System.Windows.Forms.Button()
        Me.BtnReservas = New System.Windows.Forms.Button()
        Me.BtnVentas = New System.Windows.Forms.Button()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.BtnProductos = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PanelDeMenu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1084, 491)
        Me.Panel1.TabIndex = 2
        '
        'PanelDeMenu
        '
        Me.PanelDeMenu.BackColor = System.Drawing.Color.Green
        Me.PanelDeMenu.Controls.Add(Me.Button1)
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
        Me.PanelDeMenu.Size = New System.Drawing.Size(158, 491)
        Me.PanelDeMenu.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
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
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(158, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(926, 491)
        Me.Panel2.TabIndex = 1
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
    Friend WithEvents LblNiveldeUsuario As Label
    Friend WithEvents LblUsuario As Label
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
End Class
