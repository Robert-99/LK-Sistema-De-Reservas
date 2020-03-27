<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Tabla = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnCancelarAgregar = New System.Windows.Forms.Button()
        Me.BtnAceptarAgregar = New System.Windows.Forms.Button()
        Me.LblTipoDeNivel = New System.Windows.Forms.Label()
        Me.TxtNombreDelUsuario = New System.Windows.Forms.TextBox()
        Me.LblNombreDelUsuario = New System.Windows.Forms.Label()
        Me.CmbNivelDeUsuario = New System.Windows.Forms.ComboBox()
        Me.TxtConfirmarContraseña = New System.Windows.Forms.TextBox()
        Me.LblConfirmarContraseña = New System.Windows.Forms.Label()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.LblContraseña = New System.Windows.Forms.Label()
        Me.TxtUsuarioNuevo = New System.Windows.Forms.TextBox()
        Me.LblUsuarioNuevo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tabla
        '
        Me.Tabla.AllowUserToAddRows = False
        Me.Tabla.AllowUserToDeleteRows = False
        Me.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla.Location = New System.Drawing.Point(257, 50)
        Me.Tabla.Name = "Tabla"
        Me.Tabla.ReadOnly = True
        Me.Tabla.Size = New System.Drawing.Size(541, 233)
        Me.Tabla.TabIndex = 26
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(818, 44)
        Me.Panel1.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BtnCancelarAgregar)
        Me.Panel2.Controls.Add(Me.BtnAceptarAgregar)
        Me.Panel2.Controls.Add(Me.LblTipoDeNivel)
        Me.Panel2.Controls.Add(Me.TxtNombreDelUsuario)
        Me.Panel2.Controls.Add(Me.LblNombreDelUsuario)
        Me.Panel2.Controls.Add(Me.CmbNivelDeUsuario)
        Me.Panel2.Controls.Add(Me.TxtConfirmarContraseña)
        Me.Panel2.Controls.Add(Me.LblConfirmarContraseña)
        Me.Panel2.Controls.Add(Me.TxtContraseña)
        Me.Panel2.Controls.Add(Me.LblContraseña)
        Me.Panel2.Controls.Add(Me.TxtUsuarioNuevo)
        Me.Panel2.Controls.Add(Me.LblUsuarioNuevo)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(242, 418)
        Me.Panel2.TabIndex = 28
        '
        'BtnCancelarAgregar
        '
        Me.BtnCancelarAgregar.Location = New System.Drawing.Point(142, 367)
        Me.BtnCancelarAgregar.Name = "BtnCancelarAgregar"
        Me.BtnCancelarAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelarAgregar.TabIndex = 38
        Me.BtnCancelarAgregar.Text = "Cancelar"
        Me.BtnCancelarAgregar.UseVisualStyleBackColor = True
        '
        'BtnAceptarAgregar
        '
        Me.BtnAceptarAgregar.Location = New System.Drawing.Point(29, 367)
        Me.BtnAceptarAgregar.Name = "BtnAceptarAgregar"
        Me.BtnAceptarAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptarAgregar.TabIndex = 37
        Me.BtnAceptarAgregar.Text = "Aceptar"
        Me.BtnAceptarAgregar.UseVisualStyleBackColor = True
        '
        'LblTipoDeNivel
        '
        Me.LblTipoDeNivel.AutoSize = True
        Me.LblTipoDeNivel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipoDeNivel.Location = New System.Drawing.Point(25, 289)
        Me.LblTipoDeNivel.Name = "LblTipoDeNivel"
        Me.LblTipoDeNivel.Size = New System.Drawing.Size(139, 19)
        Me.LblTipoDeNivel.TabIndex = 36
        Me.LblTipoDeNivel.Text = "Nombre del Usuario"
        '
        'TxtNombreDelUsuario
        '
        Me.TxtNombreDelUsuario.Location = New System.Drawing.Point(29, 257)
        Me.TxtNombreDelUsuario.Name = "TxtNombreDelUsuario"
        Me.TxtNombreDelUsuario.Size = New System.Drawing.Size(168, 20)
        Me.TxtNombreDelUsuario.TabIndex = 35
        '
        'LblNombreDelUsuario
        '
        Me.LblNombreDelUsuario.AutoSize = True
        Me.LblNombreDelUsuario.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreDelUsuario.Location = New System.Drawing.Point(25, 235)
        Me.LblNombreDelUsuario.Name = "LblNombreDelUsuario"
        Me.LblNombreDelUsuario.Size = New System.Drawing.Size(139, 19)
        Me.LblNombreDelUsuario.TabIndex = 34
        Me.LblNombreDelUsuario.Text = "Nombre del Usuario"
        '
        'CmbNivelDeUsuario
        '
        Me.CmbNivelDeUsuario.FormattingEnabled = True
        Me.CmbNivelDeUsuario.Items.AddRange(New Object() {"ADMINISTRADOR", "EMPLEADO", "CAJERO"})
        Me.CmbNivelDeUsuario.Location = New System.Drawing.Point(29, 324)
        Me.CmbNivelDeUsuario.Name = "CmbNivelDeUsuario"
        Me.CmbNivelDeUsuario.Size = New System.Drawing.Size(168, 21)
        Me.CmbNivelDeUsuario.TabIndex = 33
        '
        'TxtConfirmarContraseña
        '
        Me.TxtConfirmarContraseña.Location = New System.Drawing.Point(29, 201)
        Me.TxtConfirmarContraseña.Name = "TxtConfirmarContraseña"
        Me.TxtConfirmarContraseña.Size = New System.Drawing.Size(168, 20)
        Me.TxtConfirmarContraseña.TabIndex = 32
        '
        'LblConfirmarContraseña
        '
        Me.LblConfirmarContraseña.AutoSize = True
        Me.LblConfirmarContraseña.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConfirmarContraseña.Location = New System.Drawing.Point(25, 179)
        Me.LblConfirmarContraseña.Name = "LblConfirmarContraseña"
        Me.LblConfirmarContraseña.Size = New System.Drawing.Size(156, 19)
        Me.LblConfirmarContraseña.TabIndex = 31
        Me.LblConfirmarContraseña.Text = "Confirmar Contraseña"
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Location = New System.Drawing.Point(29, 148)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(168, 20)
        Me.TxtContraseña.TabIndex = 30
        '
        'LblContraseña
        '
        Me.LblContraseña.AutoSize = True
        Me.LblContraseña.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContraseña.Location = New System.Drawing.Point(25, 126)
        Me.LblContraseña.Name = "LblContraseña"
        Me.LblContraseña.Size = New System.Drawing.Size(84, 19)
        Me.LblContraseña.TabIndex = 29
        Me.LblContraseña.Text = "Contraseña"
        '
        'TxtUsuarioNuevo
        '
        Me.TxtUsuarioNuevo.Location = New System.Drawing.Point(29, 90)
        Me.TxtUsuarioNuevo.Name = "TxtUsuarioNuevo"
        Me.TxtUsuarioNuevo.Size = New System.Drawing.Size(168, 20)
        Me.TxtUsuarioNuevo.TabIndex = 28
        '
        'LblUsuarioNuevo
        '
        Me.LblUsuarioNuevo.AutoSize = True
        Me.LblUsuarioNuevo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuarioNuevo.Location = New System.Drawing.Point(25, 68)
        Me.LblUsuarioNuevo.Name = "LblUsuarioNuevo"
        Me.LblUsuarioNuevo.Size = New System.Drawing.Size(107, 19)
        Me.LblUsuarioNuevo.TabIndex = 27
        Me.LblUsuarioNuevo.Text = "Usuario Nuevo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(25, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 21)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Agregar Nuevo Usuario"
        '
        'FormUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 462)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Tabla)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormUsuarios"
        Me.Text = "FormUsuarios"
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tabla As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnCancelarAgregar As Button
    Friend WithEvents BtnAceptarAgregar As Button
    Friend WithEvents LblTipoDeNivel As Label
    Friend WithEvents TxtNombreDelUsuario As TextBox
    Friend WithEvents LblNombreDelUsuario As Label
    Friend WithEvents CmbNivelDeUsuario As ComboBox
    Friend WithEvents TxtConfirmarContraseña As TextBox
    Friend WithEvents LblConfirmarContraseña As Label
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents LblContraseña As Label
    Friend WithEvents TxtUsuarioNuevo As TextBox
    Friend WithEvents LblUsuarioNuevo As Label
    Friend WithEvents Label7 As Label
End Class
