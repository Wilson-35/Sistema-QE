<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCajaGastos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCajaGastos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtid = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.optDescripcion = New System.Windows.Forms.RadioButton()
        Me.optComprobante = New System.Windows.Forms.RadioButton()
        Me.optCodigo = New System.Windows.Forms.RadioButton()
        Me.dpfecha = New System.Windows.Forms.DateTimePicker()
        Me.btnseleccionar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Cbo1 = New System.Windows.Forms.ComboBox()
        Me.btnguardar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEstado = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPs = New System.Windows.Forms.NumericUpDown()
        Me.txtRs = New System.Windows.Forms.NumericUpDown()
        Me.lblPrecioNormal = New System.Windows.Forms.Label()
        Me.txtUs = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGs = New System.Windows.Forms.NumericUpDown()
        Me.lblPrecioMinimo = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Txtcotius = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Txtcotirs = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.TxtCotiGs = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnBuscar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtBuscar = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtid)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.optDescripcion)
        Me.Panel1.Controls.Add(Me.optComprobante)
        Me.Panel1.Controls.Add(Me.optCodigo)
        Me.Panel1.Controls.Add(Me.dpfecha)
        Me.Panel1.Controls.Add(Me.btnseleccionar)
        Me.Panel1.Controls.Add(Me.Cbo1)
        Me.Panel1.Controls.Add(Me.btnguardar)
        Me.Panel1.Controls.Add(Me.grilla)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtEstado)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtPs)
        Me.Panel1.Controls.Add(Me.txtRs)
        Me.Panel1.Controls.Add(Me.lblPrecioNormal)
        Me.Panel1.Controls.Add(Me.txtUs)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtGs)
        Me.Panel1.Controls.Add(Me.lblPrecioMinimo)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1066, 723)
        Me.Panel1.TabIndex = 0
        '
        'txtid
        '
        Me.txtid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtid.BackColor = System.Drawing.Color.White
        Me.txtid.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtid.BorderColorIdle = System.Drawing.Color.White
        Me.txtid.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtid.BorderThickness = 2
        Me.txtid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtid.Enabled = False
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.txtid.isPassword = False
        Me.txtid.Location = New System.Drawing.Point(164, 298)
        Me.txtid.Margin = New System.Windows.Forms.Padding(5)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(116, 34)
        Me.txtid.TabIndex = 498
        Me.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(41, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 497
        Me.Label4.Text = "CODIGO:"
        '
        'optDescripcion
        '
        Me.optDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.optDescripcion.AutoSize = True
        Me.optDescripcion.Location = New System.Drawing.Point(729, 91)
        Me.optDescripcion.Name = "optDescripcion"
        Me.optDescripcion.Size = New System.Drawing.Size(81, 17)
        Me.optDescripcion.TabIndex = 496
        Me.optDescripcion.TabStop = True
        Me.optDescripcion.Text = "Descripción"
        Me.optDescripcion.UseVisualStyleBackColor = True
        '
        'optComprobante
        '
        Me.optComprobante.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.optComprobante.AutoSize = True
        Me.optComprobante.Location = New System.Drawing.Point(635, 91)
        Me.optComprobante.Name = "optComprobante"
        Me.optComprobante.Size = New System.Drawing.Size(88, 17)
        Me.optComprobante.TabIndex = 495
        Me.optComprobante.TabStop = True
        Me.optComprobante.Text = "Comprobante"
        Me.optComprobante.UseVisualStyleBackColor = True
        '
        'optCodigo
        '
        Me.optCodigo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.optCodigo.AutoSize = True
        Me.optCodigo.Location = New System.Drawing.Point(571, 91)
        Me.optCodigo.Name = "optCodigo"
        Me.optCodigo.Size = New System.Drawing.Size(58, 17)
        Me.optCodigo.TabIndex = 494
        Me.optCodigo.TabStop = True
        Me.optCodigo.Text = "Codigo"
        Me.optCodigo.UseVisualStyleBackColor = True
        '
        'dpfecha
        '
        Me.dpfecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dpfecha.Location = New System.Drawing.Point(164, 340)
        Me.dpfecha.Name = "dpfecha"
        Me.dpfecha.Size = New System.Drawing.Size(288, 20)
        Me.dpfecha.TabIndex = 493
        '
        'btnseleccionar
        '
        Me.btnseleccionar.ActiveBorderThickness = 2
        Me.btnseleccionar.ActiveCornerRadius = 10
        Me.btnseleccionar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnseleccionar.ActiveForecolor = System.Drawing.Color.White
        Me.btnseleccionar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnseleccionar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnseleccionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btnseleccionar.BackgroundImage = CType(resources.GetObject("btnseleccionar.BackgroundImage"), System.Drawing.Image)
        Me.btnseleccionar.ButtonText = "Seleccionar"
        Me.btnseleccionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnseleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnseleccionar.ForeColor = System.Drawing.Color.White
        Me.btnseleccionar.IdleBorderThickness = 2
        Me.btnseleccionar.IdleCornerRadius = 10
        Me.btnseleccionar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnseleccionar.IdleForecolor = System.Drawing.Color.White
        Me.btnseleccionar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnseleccionar.Location = New System.Drawing.Point(249, 114)
        Me.btnseleccionar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnseleccionar.Name = "btnseleccionar"
        Me.btnseleccionar.Size = New System.Drawing.Size(157, 45)
        Me.btnseleccionar.TabIndex = 492
        Me.btnseleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cbo1
        '
        Me.Cbo1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cbo1.FormattingEnabled = True
        Me.Cbo1.Items.AddRange(New Object() {"Cobros a Contado", "Cobros de Creditos", "Pagos de Caja"})
        Me.Cbo1.Location = New System.Drawing.Point(67, 133)
        Me.Cbo1.Name = "Cbo1"
        Me.Cbo1.Size = New System.Drawing.Size(174, 21)
        Me.Cbo1.TabIndex = 491
        '
        'btnguardar
        '
        Me.btnguardar.ActiveBorderThickness = 2
        Me.btnguardar.ActiveCornerRadius = 10
        Me.btnguardar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnguardar.ActiveForecolor = System.Drawing.Color.White
        Me.btnguardar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnguardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btnguardar.BackgroundImage = CType(resources.GetObject("btnguardar.BackgroundImage"), System.Drawing.Image)
        Me.btnguardar.ButtonText = "Pagar"
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.IdleBorderThickness = 2
        Me.btnguardar.IdleCornerRadius = 10
        Me.btnguardar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnguardar.IdleForecolor = System.Drawing.Color.White
        Me.btnguardar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnguardar.Location = New System.Drawing.Point(946, 664)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(115, 59)
        Me.btnguardar.TabIndex = 490
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.AllowUserToOrderColumns = True
        Me.grilla.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grilla.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.GridColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grilla.Location = New System.Drawing.Point(492, 114)
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.grilla.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grilla.Size = New System.Drawing.Size(562, 542)
        Me.grilla.TabIndex = 489
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(41, 582)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 464
        Me.Label3.Text = "ESTADO:"
        '
        'txtEstado
        '
        Me.txtEstado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEstado.BackColor = System.Drawing.Color.White
        Me.txtEstado.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtEstado.BorderColorIdle = System.Drawing.Color.White
        Me.txtEstado.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtEstado.BorderThickness = 2
        Me.txtEstado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEstado.Enabled = False
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.txtEstado.isPassword = False
        Me.txtEstado.Location = New System.Drawing.Point(164, 564)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(288, 34)
        Me.txtEstado.TabIndex = 463
        Me.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(40, 536)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 462
        Me.Label2.Text = "PESO:"
        '
        'txtPs
        '
        Me.txtPs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPs.DecimalPlaces = 2
        Me.txtPs.Enabled = False
        Me.txtPs.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtPs.Location = New System.Drawing.Point(164, 524)
        Me.txtPs.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtPs.Name = "txtPs"
        Me.txtPs.Size = New System.Drawing.Size(288, 32)
        Me.txtPs.TabIndex = 461
        Me.txtPs.ThousandsSeparator = True
        '
        'txtRs
        '
        Me.txtRs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRs.DecimalPlaces = 2
        Me.txtRs.Enabled = False
        Me.txtRs.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtRs.Location = New System.Drawing.Point(164, 486)
        Me.txtRs.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtRs.Name = "txtRs"
        Me.txtRs.Size = New System.Drawing.Size(288, 32)
        Me.txtRs.TabIndex = 459
        Me.txtRs.ThousandsSeparator = True
        '
        'lblPrecioNormal
        '
        Me.lblPrecioNormal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPrecioNormal.AutoSize = True
        Me.lblPrecioNormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioNormal.ForeColor = System.Drawing.Color.Black
        Me.lblPrecioNormal.Location = New System.Drawing.Point(40, 498)
        Me.lblPrecioNormal.Name = "lblPrecioNormal"
        Me.lblPrecioNormal.Size = New System.Drawing.Size(56, 20)
        Me.lblPrecioNormal.TabIndex = 460
        Me.lblPrecioNormal.Text = "REAL:"
        '
        'txtUs
        '
        Me.txtUs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUs.DecimalPlaces = 2
        Me.txtUs.Enabled = False
        Me.txtUs.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtUs.Location = New System.Drawing.Point(164, 448)
        Me.txtUs.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtUs.Name = "txtUs"
        Me.txtUs.Size = New System.Drawing.Size(288, 32)
        Me.txtUs.TabIndex = 457
        Me.txtUs.ThousandsSeparator = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(40, 460)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 458
        Me.Label1.Text = "DOLAR:"
        '
        'txtGs
        '
        Me.txtGs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtGs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGs.DecimalPlaces = 2
        Me.txtGs.Enabled = False
        Me.txtGs.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtGs.Location = New System.Drawing.Point(164, 410)
        Me.txtGs.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtGs.Name = "txtGs"
        Me.txtGs.Size = New System.Drawing.Size(288, 32)
        Me.txtGs.TabIndex = 455
        Me.txtGs.ThousandsSeparator = True
        '
        'lblPrecioMinimo
        '
        Me.lblPrecioMinimo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPrecioMinimo.AutoSize = True
        Me.lblPrecioMinimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioMinimo.ForeColor = System.Drawing.Color.Black
        Me.lblPrecioMinimo.Location = New System.Drawing.Point(40, 422)
        Me.lblPrecioMinimo.Name = "lblPrecioMinimo"
        Me.lblPrecioMinimo.Size = New System.Drawing.Size(88, 20)
        Me.lblPrecioMinimo.TabIndex = 456
        Me.lblPrecioMinimo.Text = "GUARANI:"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(41, 386)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 16)
        Me.Label13.TabIndex = 454
        Me.Label13.Text = "DESCRIPCION:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDescripcion.BackColor = System.Drawing.Color.White
        Me.txtDescripcion.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtDescripcion.BorderColorIdle = System.Drawing.Color.White
        Me.txtDescripcion.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtDescripcion.BorderThickness = 2
        Me.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.txtDescripcion.isPassword = False
        Me.txtDescripcion.Location = New System.Drawing.Point(164, 368)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(288, 34)
        Me.txtDescripcion.TabIndex = 453
        Me.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(41, 344)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 16)
        Me.Label22.TabIndex = 450
        Me.Label22.Text = "FECHA:"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(162, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 16)
        Me.Label12.TabIndex = 445
        Me.Label12.Text = "Cotizacion Del Dia"
        '
        'Txtcotius
        '
        Me.Txtcotius.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txtcotius.BackColor = System.Drawing.Color.White
        Me.Txtcotius.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Txtcotius.BorderColorIdle = System.Drawing.Color.White
        Me.Txtcotius.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Txtcotius.BorderThickness = 2
        Me.Txtcotius.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txtcotius.Enabled = False
        Me.Txtcotius.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Txtcotius.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Txtcotius.isPassword = False
        Me.Txtcotius.Location = New System.Drawing.Point(278, 37)
        Me.Txtcotius.Margin = New System.Windows.Forms.Padding(5)
        Me.Txtcotius.Name = "Txtcotius"
        Me.Txtcotius.Size = New System.Drawing.Size(147, 34)
        Me.Txtcotius.TabIndex = 444
        Me.Txtcotius.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Txtcotirs
        '
        Me.Txtcotirs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txtcotirs.BackColor = System.Drawing.Color.White
        Me.Txtcotirs.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Txtcotirs.BorderColorIdle = System.Drawing.Color.White
        Me.Txtcotirs.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Txtcotirs.BorderThickness = 2
        Me.Txtcotirs.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txtcotirs.Enabled = False
        Me.Txtcotirs.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Txtcotirs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Txtcotirs.isPassword = False
        Me.Txtcotirs.Location = New System.Drawing.Point(71, 81)
        Me.Txtcotirs.Margin = New System.Windows.Forms.Padding(5)
        Me.Txtcotirs.Name = "Txtcotirs"
        Me.Txtcotirs.Size = New System.Drawing.Size(147, 34)
        Me.Txtcotirs.TabIndex = 443
        Me.Txtcotirs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtCotiGs
        '
        Me.TxtCotiGs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtCotiGs.BackColor = System.Drawing.Color.White
        Me.TxtCotiGs.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.TxtCotiGs.BorderColorIdle = System.Drawing.Color.White
        Me.TxtCotiGs.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.TxtCotiGs.BorderThickness = 2
        Me.TxtCotiGs.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCotiGs.Enabled = False
        Me.TxtCotiGs.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.TxtCotiGs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.TxtCotiGs.isPassword = False
        Me.TxtCotiGs.Location = New System.Drawing.Point(71, 37)
        Me.TxtCotiGs.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtCotiGs.Name = "TxtCotiGs"
        Me.TxtCotiGs.Size = New System.Drawing.Size(147, 34)
        Me.TxtCotiGs.TabIndex = 442
        Me.TxtCotiGs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(243, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 16)
        Me.Label8.TabIndex = 441
        Me.Label8.Text = "US"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(36, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 16)
        Me.Label10.TabIndex = 440
        Me.Label10.Text = "RS"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(36, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 16)
        Me.Label9.TabIndex = 439
        Me.Label9.Text = "GS"
        '
        'btnBuscar
        '
        Me.btnBuscar.ActiveBorderThickness = 2
        Me.btnBuscar.ActiveCornerRadius = 10
        Me.btnBuscar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnBuscar.ActiveForecolor = System.Drawing.Color.White
        Me.btnBuscar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscar.ButtonText = "Buscar"
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.IdleBorderThickness = 2
        Me.btnBuscar.IdleCornerRadius = 10
        Me.btnBuscar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnBuscar.IdleForecolor = System.Drawing.Color.White
        Me.btnBuscar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnBuscar.Location = New System.Drawing.Point(904, 42)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(157, 45)
        Me.btnBuscar.TabIndex = 417
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBuscar.BackColor = System.Drawing.Color.White
        Me.txtBuscar.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtBuscar.BorderColorIdle = System.Drawing.Color.White
        Me.txtBuscar.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtBuscar.BorderThickness = 2
        Me.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.txtBuscar.isPassword = False
        Me.txtBuscar.Location = New System.Drawing.Point(492, 49)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(402, 34)
        Me.txtBuscar.TabIndex = 416
        Me.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(439, 9)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(188, 29)
        Me.Label15.TabIndex = 415
        Me.Label15.Text = "Pago De Gastos"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(107, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 16)
        Me.Label5.TabIndex = 595
        Me.Label5.Text = "Tipo de Cobro"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TxtCotiGs)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Txtcotirs)
        Me.GroupBox1.Controls.Add(Me.Txtcotius)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 123)
        Me.GroupBox1.TabIndex = 654
        Me.GroupBox1.TabStop = False
        '
        'frmCajaGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 723)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCajaGastos"
        Me.Text = "frmCajaGastos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtid As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents optDescripcion As RadioButton
    Friend WithEvents optComprobante As RadioButton
    Friend WithEvents optCodigo As RadioButton
    Friend WithEvents dpfecha As DateTimePicker
    Friend WithEvents btnseleccionar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Cbo1 As ComboBox
    Friend WithEvents btnguardar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents grilla As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEstado As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPs As NumericUpDown
    Friend WithEvents txtRs As NumericUpDown
    Friend WithEvents lblPrecioNormal As Label
    Friend WithEvents txtUs As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGs As NumericUpDown
    Friend WithEvents lblPrecioMinimo As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtDescripcion As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Txtcotius As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Txtcotirs As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents TxtCotiGs As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnBuscar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtBuscar As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
