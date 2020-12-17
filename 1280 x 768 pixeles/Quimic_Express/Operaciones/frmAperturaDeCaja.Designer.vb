<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAperturaDeCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAperturaDeCaja))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtCodigo = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPApertura = New System.Windows.Forms.NumericUpDown()
        Me.txtGApertura = New System.Windows.Forms.NumericUpDown()
        Me.txtRApertura = New System.Windows.Forms.NumericUpDown()
        Me.txtDApertura = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txtNombreUsuario = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtCodigoUsuario = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnCancelarApertura = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnGuardarApertura = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtPApertura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGApertura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRApertura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDApertura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Panel1.Controls.Add(Me.dtpFecha)
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txtNombreUsuario)
        Me.Panel1.Controls.Add(Me.txtCodigoUsuario)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.btnCancelarApertura)
        Me.Panel1.Controls.Add(Me.btnGuardarApertura)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1066, 723)
        Me.Panel1.TabIndex = 369
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpFecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dtpFecha.Location = New System.Drawing.Point(493, 95)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(291, 20)
        Me.dtpFecha.TabIndex = 427
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
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtCodigo.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.isPassword = False
        Me.txtCodigo.Location = New System.Drawing.Point(390, 88)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(96, 30)
        Me.txtCodigo.TabIndex = 426
        Me.txtCodigo.Text = "0"
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.txtPApertura)
        Me.GroupBox1.Controls.Add(Me.txtGApertura)
        Me.GroupBox1.Controls.Add(Me.txtRApertura)
        Me.GroupBox1.Controls.Add(Me.txtDApertura)
        Me.GroupBox1.Controls.Add(Me.PictureBox6)
        Me.GroupBox1.Controls.Add(Me.PictureBox8)
        Me.GroupBox1.Controls.Add(Me.PictureBox5)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(384, 333)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 278)
        Me.GroupBox1.TabIndex = 420
        Me.GroupBox1.TabStop = False
        '
        'txtPApertura
        '
        Me.txtPApertura.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPApertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPApertura.DecimalPlaces = 2
        Me.txtPApertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtPApertura.Location = New System.Drawing.Point(137, 223)
        Me.txtPApertura.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtPApertura.Name = "txtPApertura"
        Me.txtPApertura.Size = New System.Drawing.Size(171, 26)
        Me.txtPApertura.TabIndex = 425
        Me.txtPApertura.ThousandsSeparator = True
        '
        'txtGApertura
        '
        Me.txtGApertura.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtGApertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGApertura.DecimalPlaces = 2
        Me.txtGApertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtGApertura.Location = New System.Drawing.Point(137, 35)
        Me.txtGApertura.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtGApertura.Name = "txtGApertura"
        Me.txtGApertura.Size = New System.Drawing.Size(171, 26)
        Me.txtGApertura.TabIndex = 422
        Me.txtGApertura.ThousandsSeparator = True
        '
        'txtRApertura
        '
        Me.txtRApertura.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRApertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRApertura.DecimalPlaces = 2
        Me.txtRApertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtRApertura.Location = New System.Drawing.Point(137, 159)
        Me.txtRApertura.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtRApertura.Name = "txtRApertura"
        Me.txtRApertura.Size = New System.Drawing.Size(171, 26)
        Me.txtRApertura.TabIndex = 424
        Me.txtRApertura.ThousandsSeparator = True
        '
        'txtDApertura
        '
        Me.txtDApertura.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDApertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDApertura.DecimalPlaces = 2
        Me.txtDApertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtDApertura.Location = New System.Drawing.Point(137, 95)
        Me.txtDApertura.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtDApertura.Name = "txtDApertura"
        Me.txtDApertura.Size = New System.Drawing.Size(171, 26)
        Me.txtDApertura.TabIndex = 423
        Me.txtDApertura.ThousandsSeparator = True
        '
        'PictureBox6
        '
        Me.PictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(30, 149)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(72, 48)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 394
        Me.PictureBox6.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(28, 23)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(74, 48)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 418
        Me.PictureBox8.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(30, 212)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(72, 48)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 395
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(30, 85)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(72, 48)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 396
        Me.PictureBox4.TabStop = False
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNombreUsuario.BackColor = System.Drawing.Color.White
        Me.txtNombreUsuario.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtNombreUsuario.BorderColorIdle = System.Drawing.Color.White
        Me.txtNombreUsuario.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtNombreUsuario.BorderThickness = 2
        Me.txtNombreUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Black
        Me.txtNombreUsuario.isPassword = False
        Me.txtNombreUsuario.Location = New System.Drawing.Point(493, 134)
        Me.txtNombreUsuario.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(291, 34)
        Me.txtNombreUsuario.TabIndex = 390
        Me.txtNombreUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtCodigoUsuario
        '
        Me.txtCodigoUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCodigoUsuario.BackColor = System.Drawing.Color.White
        Me.txtCodigoUsuario.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtCodigoUsuario.BorderColorIdle = System.Drawing.Color.White
        Me.txtCodigoUsuario.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtCodigoUsuario.BorderThickness = 2
        Me.txtCodigoUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodigoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtCodigoUsuario.ForeColor = System.Drawing.Color.Black
        Me.txtCodigoUsuario.isPassword = False
        Me.txtCodigoUsuario.Location = New System.Drawing.Point(390, 134)
        Me.txtCodigoUsuario.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCodigoUsuario.Name = "txtCodigoUsuario"
        Me.txtCodigoUsuario.Size = New System.Drawing.Size(96, 34)
        Me.txtCodigoUsuario.TabIndex = 389
        Me.txtCodigoUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(475, 295)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 20)
        Me.Label5.TabIndex = 377
        Me.Label5.Text = "Ingrese el Monto en Caja"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(500, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 24)
        Me.Label4.TabIndex = 375
        Me.Label4.Text = "Efectivo Inicial:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(318, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 374
        Me.Label3.Text = "Cajero:"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(318, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 20)
        Me.Label9.TabIndex = 371
        Me.Label9.Text = "Codigo:"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(436, 13)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(223, 31)
        Me.Label16.TabIndex = 370
        Me.Label16.Text = "Apertura De Caja"
        '
        'btnCancelarApertura
        '
        Me.btnCancelarApertura.ActiveBorderThickness = 2
        Me.btnCancelarApertura.ActiveCornerRadius = 10
        Me.btnCancelarApertura.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnCancelarApertura.ActiveForecolor = System.Drawing.Color.White
        Me.btnCancelarApertura.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnCancelarApertura.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancelarApertura.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btnCancelarApertura.BackgroundImage = CType(resources.GetObject("btnCancelarApertura.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelarApertura.ButtonText = "Cancelar"
        Me.btnCancelarApertura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelarApertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarApertura.ForeColor = System.Drawing.Color.White
        Me.btnCancelarApertura.IdleBorderThickness = 2
        Me.btnCancelarApertura.IdleCornerRadius = 10
        Me.btnCancelarApertura.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnCancelarApertura.IdleForecolor = System.Drawing.Color.White
        Me.btnCancelarApertura.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnCancelarApertura.Location = New System.Drawing.Point(558, 644)
        Me.btnCancelarApertura.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCancelarApertura.Name = "btnCancelarApertura"
        Me.btnCancelarApertura.Size = New System.Drawing.Size(226, 54)
        Me.btnCancelarApertura.TabIndex = 366
        Me.btnCancelarApertura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGuardarApertura
        '
        Me.btnGuardarApertura.ActiveBorderThickness = 2
        Me.btnGuardarApertura.ActiveCornerRadius = 10
        Me.btnGuardarApertura.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnGuardarApertura.ActiveForecolor = System.Drawing.Color.White
        Me.btnGuardarApertura.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnGuardarApertura.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGuardarApertura.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btnGuardarApertura.BackgroundImage = CType(resources.GetObject("btnGuardarApertura.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardarApertura.ButtonText = "Guardar"
        Me.btnGuardarApertura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardarApertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarApertura.ForeColor = System.Drawing.Color.White
        Me.btnGuardarApertura.IdleBorderThickness = 2
        Me.btnGuardarApertura.IdleCornerRadius = 10
        Me.btnGuardarApertura.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnGuardarApertura.IdleForecolor = System.Drawing.Color.White
        Me.btnGuardarApertura.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnGuardarApertura.Location = New System.Drawing.Point(322, 644)
        Me.btnGuardarApertura.Margin = New System.Windows.Forms.Padding(5)
        Me.btnGuardarApertura.Name = "btnGuardarApertura"
        Me.btnGuardarApertura.Size = New System.Drawing.Size(226, 54)
        Me.btnGuardarApertura.TabIndex = 365
        Me.btnGuardarApertura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAperturaDeCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 723)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAperturaDeCaja"
        Me.Text = "frmAperturaDeCaja"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtPApertura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGApertura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRApertura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDApertura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtNombreUsuario As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtCodigoUsuario As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnCancelarApertura As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnGuardarApertura As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtPApertura As NumericUpDown
    Friend WithEvents txtGApertura As NumericUpDown
    Friend WithEvents txtRApertura As NumericUpDown
    Friend WithEvents txtDApertura As NumericUpDown
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtCodigo As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
