<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditarProveedor))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblnombres = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.txtCodigo = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtNombres = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtApellidos = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtDireccion = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtTelefono = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtRuc = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.btnCancelar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnGuardar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PanelContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(287, 222)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 21)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Codigo"
        '
        'lblnombres
        '
        Me.lblnombres.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblnombres.AutoSize = True
        Me.lblnombres.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.lblnombres.Location = New System.Drawing.Point(287, 263)
        Me.lblnombres.Name = "lblnombres"
        Me.lblnombres.Size = New System.Drawing.Size(83, 21)
        Me.lblnombres.TabIndex = 10
        Me.lblnombres.Text = "Nombres:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(287, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 21)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Apellidos:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(287, 345)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 21)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Direccion:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(287, 386)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 21)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Contacto:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(287, 427)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 21)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Ruc:"
        '
        'lbltitulo
        '
        Me.lbltitulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.lbltitulo.Location = New System.Drawing.Point(375, 138)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(378, 30)
        Me.lbltitulo.TabIndex = 8
        Me.lbltitulo.Text = "Registro de Proveedor - Nuevo"
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtCodigo.BorderColorIdle = System.Drawing.Color.White
        Me.txtCodigo.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtCodigo.BorderThickness = 2
        Me.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtCodigo.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.isPassword = False
        Me.txtCodigo.Location = New System.Drawing.Point(479, 213)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(140, 30)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtNombres
        '
        Me.txtNombres.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNombres.BackColor = System.Drawing.Color.White
        Me.txtNombres.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtNombres.BorderColorIdle = System.Drawing.Color.White
        Me.txtNombres.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtNombres.BorderThickness = 2
        Me.txtNombres.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombres.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtNombres.ForeColor = System.Drawing.Color.Black
        Me.txtNombres.isPassword = False
        Me.txtNombres.Location = New System.Drawing.Point(479, 254)
        Me.txtNombres.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(298, 30)
        Me.txtNombres.TabIndex = 1
        Me.txtNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtApellidos
        '
        Me.txtApellidos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtApellidos.BackColor = System.Drawing.Color.White
        Me.txtApellidos.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtApellidos.BorderColorIdle = System.Drawing.Color.White
        Me.txtApellidos.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtApellidos.BorderThickness = 2
        Me.txtApellidos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtApellidos.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtApellidos.ForeColor = System.Drawing.Color.Black
        Me.txtApellidos.isPassword = False
        Me.txtApellidos.Location = New System.Drawing.Point(479, 295)
        Me.txtApellidos.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(298, 30)
        Me.txtApellidos.TabIndex = 2
        Me.txtApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtDireccion
        '
        Me.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDireccion.BackColor = System.Drawing.Color.White
        Me.txtDireccion.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtDireccion.BorderColorIdle = System.Drawing.Color.White
        Me.txtDireccion.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtDireccion.BorderThickness = 2
        Me.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDireccion.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtDireccion.ForeColor = System.Drawing.Color.Black
        Me.txtDireccion.isPassword = False
        Me.txtDireccion.Location = New System.Drawing.Point(479, 336)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(298, 30)
        Me.txtDireccion.TabIndex = 3
        Me.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtTelefono
        '
        Me.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTelefono.BackColor = System.Drawing.Color.White
        Me.txtTelefono.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtTelefono.BorderColorIdle = System.Drawing.Color.White
        Me.txtTelefono.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtTelefono.BorderThickness = 2
        Me.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelefono.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtTelefono.ForeColor = System.Drawing.Color.Black
        Me.txtTelefono.isPassword = False
        Me.txtTelefono.Location = New System.Drawing.Point(479, 377)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(298, 30)
        Me.txtTelefono.TabIndex = 4
        Me.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtRuc
        '
        Me.txtRuc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRuc.BackColor = System.Drawing.Color.White
        Me.txtRuc.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtRuc.BorderColorIdle = System.Drawing.Color.White
        Me.txtRuc.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtRuc.BorderThickness = 2
        Me.txtRuc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRuc.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtRuc.ForeColor = System.Drawing.Color.Black
        Me.txtRuc.isPassword = False
        Me.txtRuc.Location = New System.Drawing.Point(479, 418)
        Me.txtRuc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(298, 30)
        Me.txtRuc.TabIndex = 5
        Me.txtRuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.PanelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelContenedor.Controls.Add(Me.btnCancelar)
        Me.PanelContenedor.Controls.Add(Me.btnGuardar)
        Me.PanelContenedor.Controls.Add(Me.txtRuc)
        Me.PanelContenedor.Controls.Add(Me.txtTelefono)
        Me.PanelContenedor.Controls.Add(Me.txtDireccion)
        Me.PanelContenedor.Controls.Add(Me.txtApellidos)
        Me.PanelContenedor.Controls.Add(Me.txtNombres)
        Me.PanelContenedor.Controls.Add(Me.txtCodigo)
        Me.PanelContenedor.Controls.Add(Me.lbltitulo)
        Me.PanelContenedor.Controls.Add(Me.Label3)
        Me.PanelContenedor.Controls.Add(Me.Label5)
        Me.PanelContenedor.Controls.Add(Me.Label4)
        Me.PanelContenedor.Controls.Add(Me.Label8)
        Me.PanelContenedor.Controls.Add(Me.lblnombres)
        Me.PanelContenedor.Controls.Add(Me.Label9)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1066, 768)
        Me.PanelContenedor.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.ActiveBorderThickness = 2
        Me.btnCancelar.ActiveCornerRadius = 10
        Me.btnCancelar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnCancelar.ActiveForecolor = System.Drawing.Color.White
        Me.btnCancelar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelar.ButtonText = "Cancelar"
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.IdleBorderThickness = 2
        Me.btnCancelar.IdleCornerRadius = 10
        Me.btnCancelar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnCancelar.IdleForecolor = System.Drawing.Color.White
        Me.btnCancelar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnCancelar.Location = New System.Drawing.Point(540, 522)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(226, 54)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGuardar
        '
        Me.btnGuardar.ActiveBorderThickness = 2
        Me.btnGuardar.ActiveCornerRadius = 10
        Me.btnGuardar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnGuardar.ActiveForecolor = System.Drawing.Color.White
        Me.btnGuardar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.ButtonText = "Guardar"
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.IdleBorderThickness = 2
        Me.btnGuardar.IdleCornerRadius = 10
        Me.btnGuardar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnGuardar.IdleForecolor = System.Drawing.Color.White
        Me.btnGuardar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnGuardar.Location = New System.Drawing.Point(304, 522)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(226, 54)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmEditarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 768)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEditarProveedor"
        Me.Text = "frmEditarProveedor"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelContenedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblnombres As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtNombres As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtApellidos As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtDireccion As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtTelefono As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtRuc As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents PanelContenedor As System.Windows.Forms.Panel
    Friend WithEvents btnCancelar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnGuardar As Bunifu.Framework.UI.BunifuThinButton2

End Class
