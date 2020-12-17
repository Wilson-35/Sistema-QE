<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCotizacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCotizacion))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.NumericUpDown()
        Me.txtGuarani = New System.Windows.Forms.NumericUpDown()
        Me.txtReal = New System.Windows.Forms.NumericUpDown()
        Me.txtDolar = New System.Windows.Forms.NumericUpDown()
        Me.txtEstado = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dpFechaCotizacion = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.txtUsuarioCotizacion = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnCancelar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnGuardar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.txtPeso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGuarani, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDolar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtPeso)
        Me.Panel1.Controls.Add(Me.txtGuarani)
        Me.Panel1.Controls.Add(Me.txtReal)
        Me.Panel1.Controls.Add(Me.txtDolar)
        Me.Panel1.Controls.Add(Me.txtEstado)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dpFechaCotizacion)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.PictureBox8)
        Me.Panel1.Controls.Add(Me.txtUsuarioCotizacion)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1066, 723)
        Me.Panel1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(354, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 430
        Me.Label2.Text = "Fecha:"
        '
        'txtPeso
        '
        Me.txtPeso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPeso.DecimalPlaces = 2
        Me.txtPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtPeso.Location = New System.Drawing.Point(579, 492)
        Me.txtPeso.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(171, 29)
        Me.txtPeso.TabIndex = 429
        Me.txtPeso.ThousandsSeparator = True
        '
        'txtGuarani
        '
        Me.txtGuarani.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtGuarani.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGuarani.DecimalPlaces = 2
        Me.txtGuarani.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtGuarani.Location = New System.Drawing.Point(579, 263)
        Me.txtGuarani.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtGuarani.Name = "txtGuarani"
        Me.txtGuarani.Size = New System.Drawing.Size(171, 29)
        Me.txtGuarani.TabIndex = 426
        Me.txtGuarani.ThousandsSeparator = True
        '
        'txtReal
        '
        Me.txtReal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtReal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReal.DecimalPlaces = 2
        Me.txtReal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtReal.Location = New System.Drawing.Point(579, 418)
        Me.txtReal.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtReal.Name = "txtReal"
        Me.txtReal.Size = New System.Drawing.Size(171, 29)
        Me.txtReal.TabIndex = 428
        Me.txtReal.ThousandsSeparator = True
        '
        'txtDolar
        '
        Me.txtDolar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDolar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDolar.DecimalPlaces = 2
        Me.txtDolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtDolar.Location = New System.Drawing.Point(579, 335)
        Me.txtDolar.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtDolar.Name = "txtDolar"
        Me.txtDolar.Size = New System.Drawing.Size(171, 29)
        Me.txtDolar.TabIndex = 427
        Me.txtDolar.ThousandsSeparator = True
        '
        'txtEstado
        '
        Me.txtEstado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEstado.BackColor = System.Drawing.Color.White
        Me.txtEstado.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtEstado.BorderColorIdle = System.Drawing.Color.White
        Me.txtEstado.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtEstado.BorderThickness = 2
        Me.txtEstado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEstado.Enabled = False
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtEstado.ForeColor = System.Drawing.Color.Black
        Me.txtEstado.isPassword = False
        Me.txtEstado.Location = New System.Drawing.Point(439, 165)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(131, 34)
        Me.txtEstado.TabIndex = 389
        Me.txtEstado.Text = "1"
        Me.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(354, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 388
        Me.Label1.Text = "Estado:"
        '
        'dpFechaCotizacion
        '
        Me.dpFechaCotizacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dpFechaCotizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpFechaCotizacion.Location = New System.Drawing.Point(439, 88)
        Me.dpFechaCotizacion.Name = "dpFechaCotizacion"
        Me.dpFechaCotizacion.Size = New System.Drawing.Size(276, 22)
        Me.dpFechaCotizacion.TabIndex = 387
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(317, 268)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 20)
        Me.Label20.TabIndex = 382
        Me.Label20.Text = "Guaraní"
        '
        'PictureBox8
        '
        Me.PictureBox8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(418, 247)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(87, 58)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 381
        Me.PictureBox8.TabStop = False
        '
        'txtUsuarioCotizacion
        '
        Me.txtUsuarioCotizacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsuarioCotizacion.BackColor = System.Drawing.Color.White
        Me.txtUsuarioCotizacion.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtUsuarioCotizacion.BorderColorIdle = System.Drawing.Color.White
        Me.txtUsuarioCotizacion.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtUsuarioCotizacion.BorderThickness = 2
        Me.txtUsuarioCotizacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsuarioCotizacion.Enabled = False
        Me.txtUsuarioCotizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtUsuarioCotizacion.ForeColor = System.Drawing.Color.Black
        Me.txtUsuarioCotizacion.isPassword = False
        Me.txtUsuarioCotizacion.Location = New System.Drawing.Point(439, 121)
        Me.txtUsuarioCotizacion.Margin = New System.Windows.Forms.Padding(5)
        Me.txtUsuarioCotizacion.Name = "txtUsuarioCotizacion"
        Me.txtUsuarioCotizacion.Size = New System.Drawing.Size(199, 34)
        Me.txtUsuarioCotizacion.TabIndex = 371
        Me.txtUsuarioCotizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(354, 135)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 20)
        Me.Label17.TabIndex = 370
        Me.Label17.Text = "Usuario:"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(352, 46)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(297, 31)
        Me.Label16.TabIndex = 369
        Me.Label16.Text = "COTIZACIÓN DEL DÍA"
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
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.IdleBorderThickness = 2
        Me.btnCancelar.IdleCornerRadius = 10
        Me.btnCancelar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnCancelar.IdleForecolor = System.Drawing.Color.White
        Me.btnCancelar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnCancelar.Location = New System.Drawing.Point(556, 609)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(141, 54)
        Me.btnCancelar.TabIndex = 361
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
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.IdleBorderThickness = 2
        Me.btnGuardar.IdleCornerRadius = 10
        Me.btnGuardar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnGuardar.IdleForecolor = System.Drawing.Color.White
        Me.btnGuardar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnGuardar.Location = New System.Drawing.Point(405, 609)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(141, 54)
        Me.btnGuardar.TabIndex = 360
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(317, 497)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 20)
        Me.Label8.TabIndex = 337
        Me.Label8.Text = "Peso"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(317, 423)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 20)
        Me.Label5.TabIndex = 334
        Me.Label5.Text = "Real"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(317, 340)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 20)
        Me.Label9.TabIndex = 331
        Me.Label9.Text = "Dolar"
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(418, 323)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(87, 58)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(418, 478)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(87, 58)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(418, 404)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(87, 58)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 3
        Me.PictureBox6.TabStop = False
        '
        'frmCotizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 723)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCotizacion"
        Me.Text = "frmCorizacion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtPeso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGuarani, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDolar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtEstado As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dpFechaCotizacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents txtUsuarioCotizacion As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnGuardar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents txtPeso As NumericUpDown
    Friend WithEvents txtGuarani As NumericUpDown
    Friend WithEvents txtReal As NumericUpDown
    Friend WithEvents txtDolar As NumericUpDown
    Friend WithEvents Label2 As Label
End Class
