<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlmacen_Inventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlmacen_Inventario))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttotalKilos = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.kilos = New System.Windows.Forms.Label()
        Me.txtkilos = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtidAlmacen = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEliminar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtinventarioLitros = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtTotal = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btnCancelar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnGuardar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.txtPrecioMinimo = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProveedor = New System.Windows.Forms.NumericUpDown()
        Me.txtCategoria = New System.Windows.Forms.NumericUpDown()
        Me.txtMarca = New System.Windows.Forms.NumericUpDown()
        Me.txtNormal = New System.Windows.Forms.NumericUpDown()
        Me.txtCosto = New System.Windows.Forms.NumericUpDown()
        Me.txtStock = New System.Windows.Forms.NumericUpDown()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnGenerar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblCodigodeBarra = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtNombreProveedor = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.txtCodigoBarra = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblCodigoBarra = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.txtNombreCategoria = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtNombreMarca = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtDescripcion = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtCodigo = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblPrecioMinimo = New System.Windows.Forms.Label()
        Me.lblPrecioNormal = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.txtPrecioMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txttotalKilos)
        Me.Panel1.Controls.Add(Me.kilos)
        Me.Panel1.Controls.Add(Me.txtkilos)
        Me.Panel1.Controls.Add(Me.txtidAlmacen)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtinventarioLitros)
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.lbltitulo)
        Me.Panel1.Controls.Add(Me.txtPrecioMinimo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtProveedor)
        Me.Panel1.Controls.Add(Me.txtCategoria)
        Me.Panel1.Controls.Add(Me.txtMarca)
        Me.Panel1.Controls.Add(Me.txtNormal)
        Me.Panel1.Controls.Add(Me.txtCosto)
        Me.Panel1.Controls.Add(Me.txtStock)
        Me.Panel1.Controls.Add(Me.dtpFecha)
        Me.Panel1.Controls.Add(Me.btnGenerar)
        Me.Panel1.Controls.Add(Me.lblCodigodeBarra)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.txtNombreProveedor)
        Me.Panel1.Controls.Add(Me.lblProveedor)
        Me.Panel1.Controls.Add(Me.txtCodigoBarra)
        Me.Panel1.Controls.Add(Me.lblCodigoBarra)
        Me.Panel1.Controls.Add(Me.lblStock)
        Me.Panel1.Controls.Add(Me.txtNombreCategoria)
        Me.Panel1.Controls.Add(Me.txtNombreMarca)
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Controls.Add(Me.lblPrecioMinimo)
        Me.Panel1.Controls.Add(Me.lblPrecioNormal)
        Me.Panel1.Controls.Add(Me.lblCategoria)
        Me.Panel1.Controls.Add(Me.lblMarca)
        Me.Panel1.Controls.Add(Me.lblDescripcion)
        Me.Panel1.Controls.Add(Me.lblCodigo)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1066, 725)
        Me.Panel1.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(643, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 20)
        Me.Label6.TabIndex = 491
        Me.Label6.Text = "Cantidad Total:"
        '
        'txttotalKilos
        '
        Me.txttotalKilos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txttotalKilos.BackColor = System.Drawing.Color.White
        Me.txttotalKilos.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txttotalKilos.BorderColorIdle = System.Drawing.Color.White
        Me.txttotalKilos.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txttotalKilos.BorderThickness = 2
        Me.txttotalKilos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttotalKilos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txttotalKilos.ForeColor = System.Drawing.Color.Black
        Me.txttotalKilos.isPassword = False
        Me.txttotalKilos.Location = New System.Drawing.Point(800, 189)
        Me.txttotalKilos.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotalKilos.Name = "txttotalKilos"
        Me.txttotalKilos.Size = New System.Drawing.Size(182, 30)
        Me.txttotalKilos.TabIndex = 490
        Me.txttotalKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'kilos
        '
        Me.kilos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.kilos.AutoSize = True
        Me.kilos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kilos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.kilos.Location = New System.Drawing.Point(643, 241)
        Me.kilos.Name = "kilos"
        Me.kilos.Size = New System.Drawing.Size(133, 20)
        Me.kilos.TabIndex = 489
        Me.kilos.Text = "Kilos a Inventario:"
        '
        'txtkilos
        '
        Me.txtkilos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtkilos.BackColor = System.Drawing.Color.White
        Me.txtkilos.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtkilos.BorderColorIdle = System.Drawing.Color.White
        Me.txtkilos.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtkilos.BorderThickness = 2
        Me.txtkilos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtkilos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtkilos.ForeColor = System.Drawing.Color.Black
        Me.txtkilos.isPassword = False
        Me.txtkilos.Location = New System.Drawing.Point(800, 231)
        Me.txtkilos.Margin = New System.Windows.Forms.Padding(4)
        Me.txtkilos.Name = "txtkilos"
        Me.txtkilos.Size = New System.Drawing.Size(182, 30)
        Me.txtkilos.TabIndex = 488
        Me.txtkilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtidAlmacen
        '
        Me.txtidAlmacen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtidAlmacen.BackColor = System.Drawing.Color.White
        Me.txtidAlmacen.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtidAlmacen.BorderColorIdle = System.Drawing.Color.White
        Me.txtidAlmacen.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtidAlmacen.BorderThickness = 2
        Me.txtidAlmacen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtidAlmacen.Enabled = False
        Me.txtidAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtidAlmacen.ForeColor = System.Drawing.Color.Black
        Me.txtidAlmacen.isPassword = False
        Me.txtidAlmacen.Location = New System.Drawing.Point(800, 146)
        Me.txtidAlmacen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidAlmacen.Name = "txtidAlmacen"
        Me.txtidAlmacen.Size = New System.Drawing.Size(182, 30)
        Me.txtidAlmacen.TabIndex = 486
        Me.txtidAlmacen.Text = "0"
        Me.txtidAlmacen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(643, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 20)
        Me.Label5.TabIndex = 487
        Me.Label5.Text = "Codigo Almacen"
        '
        'btnEliminar
        '
        Me.btnEliminar.ActiveBorderThickness = 2
        Me.btnEliminar.ActiveCornerRadius = 10
        Me.btnEliminar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnEliminar.ActiveForecolor = System.Drawing.Color.White
        Me.btnEliminar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminar.ButtonText = "Eliminar"
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.IdleBorderThickness = 2
        Me.btnEliminar.IdleCornerRadius = 10
        Me.btnEliminar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnEliminar.IdleForecolor = System.Drawing.Color.White
        Me.btnEliminar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnEliminar.Location = New System.Drawing.Point(433, 643)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(226, 54)
        Me.btnEliminar.TabIndex = 485
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(643, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 20)
        Me.Label4.TabIndex = 484
        Me.Label4.Text = "Litros a inventario:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(643, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 20)
        Me.Label3.TabIndex = 483
        Me.Label3.Text = "Cantidad Total:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(700, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 29)
        Me.Label2.TabIndex = 482
        Me.Label2.Text = "Cantidad de Almacen"
        '
        'txtinventarioLitros
        '
        Me.txtinventarioLitros.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtinventarioLitros.BackColor = System.Drawing.Color.White
        Me.txtinventarioLitros.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtinventarioLitros.BorderColorIdle = System.Drawing.Color.White
        Me.txtinventarioLitros.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtinventarioLitros.BorderThickness = 2
        Me.txtinventarioLitros.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtinventarioLitros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtinventarioLitros.ForeColor = System.Drawing.Color.Black
        Me.txtinventarioLitros.isPassword = False
        Me.txtinventarioLitros.Location = New System.Drawing.Point(800, 233)
        Me.txtinventarioLitros.Margin = New System.Windows.Forms.Padding(4)
        Me.txtinventarioLitros.Name = "txtinventarioLitros"
        Me.txtinventarioLitros.Size = New System.Drawing.Size(182, 30)
        Me.txtinventarioLitros.TabIndex = 481
        Me.txtinventarioLitros.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtTotal.BorderColorIdle = System.Drawing.Color.White
        Me.txtTotal.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtTotal.BorderThickness = 2
        Me.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtTotal.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.isPassword = False
        Me.txtTotal.Location = New System.Drawing.Point(800, 190)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(182, 30)
        Me.txtTotal.TabIndex = 480
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.btnCancelar.Location = New System.Drawing.Point(685, 643)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(226, 54)
        Me.btnCancelar.TabIndex = 479
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
        Me.btnGuardar.Location = New System.Drawing.Point(182, 643)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(226, 54)
        Me.btnGuardar.TabIndex = 478
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltitulo
        '
        Me.lbltitulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.lbltitulo.Location = New System.Drawing.Point(376, 17)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(338, 29)
        Me.lbltitulo.TabIndex = 477
        Me.lbltitulo.Text = "Registro de Inventario - Nuevo"
        '
        'txtPrecioMinimo
        '
        Me.txtPrecioMinimo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrecioMinimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioMinimo.DecimalPlaces = 2
        Me.txtPrecioMinimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtPrecioMinimo.Location = New System.Drawing.Point(270, 404)
        Me.txtPrecioMinimo.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtPrecioMinimo.Name = "txtPrecioMinimo"
        Me.txtPrecioMinimo.Size = New System.Drawing.Size(171, 26)
        Me.txtPrecioMinimo.TabIndex = 475
        Me.txtPrecioMinimo.ThousandsSeparator = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(78, 410)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 476
        Me.Label1.Text = "Precio Minimo:"
        '
        'txtProveedor
        '
        Me.txtProveedor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtProveedor.Location = New System.Drawing.Point(270, 319)
        Me.txtProveedor.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(107, 26)
        Me.txtProveedor.TabIndex = 457
        Me.txtProveedor.ThousandsSeparator = True
        '
        'txtCategoria
        '
        Me.txtCategoria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtCategoria.Location = New System.Drawing.Point(270, 277)
        Me.txtCategoria.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(106, 26)
        Me.txtCategoria.TabIndex = 455
        Me.txtCategoria.ThousandsSeparator = True
        '
        'txtMarca
        '
        Me.txtMarca.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtMarca.Location = New System.Drawing.Point(270, 236)
        Me.txtMarca.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(106, 26)
        Me.txtMarca.TabIndex = 453
        Me.txtMarca.ThousandsSeparator = True
        '
        'txtNormal
        '
        Me.txtNormal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNormal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNormal.DecimalPlaces = 2
        Me.txtNormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtNormal.Location = New System.Drawing.Point(270, 447)
        Me.txtNormal.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtNormal.Name = "txtNormal"
        Me.txtNormal.Size = New System.Drawing.Size(171, 26)
        Me.txtNormal.TabIndex = 460
        Me.txtNormal.ThousandsSeparator = True
        '
        'txtCosto
        '
        Me.txtCosto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCosto.DecimalPlaces = 2
        Me.txtCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtCosto.Location = New System.Drawing.Point(270, 362)
        Me.txtCosto.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(171, 26)
        Me.txtCosto.TabIndex = 459
        Me.txtCosto.ThousandsSeparator = True
        '
        'txtStock
        '
        Me.txtStock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtStock.Location = New System.Drawing.Point(270, 490)
        Me.txtStock.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(171, 26)
        Me.txtStock.TabIndex = 461
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpFecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(384, 103)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(219, 20)
        Me.dtpFecha.TabIndex = 462
        '
        'btnGenerar
        '
        Me.btnGenerar.ActiveBorderThickness = 2
        Me.btnGenerar.ActiveCornerRadius = 10
        Me.btnGenerar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnGenerar.ActiveForecolor = System.Drawing.Color.White
        Me.btnGenerar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnGenerar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGenerar.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btnGenerar.BackgroundImage = CType(resources.GetObject("btnGenerar.BackgroundImage"), System.Drawing.Image)
        Me.btnGenerar.ButtonText = "Generar Barra"
        Me.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.ForeColor = System.Drawing.Color.White
        Me.btnGenerar.IdleBorderThickness = 2
        Me.btnGenerar.IdleCornerRadius = 10
        Me.btnGenerar.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnGenerar.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnGenerar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnGenerar.Location = New System.Drawing.Point(667, 552)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(134, 53)
        Me.btnGenerar.TabIndex = 463
        Me.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCodigodeBarra
        '
        Me.lblCodigodeBarra.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCodigodeBarra.AutoSize = True
        Me.lblCodigodeBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigodeBarra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.lblCodigodeBarra.Location = New System.Drawing.Point(266, 569)
        Me.lblCodigodeBarra.Name = "lblCodigodeBarra"
        Me.lblCodigodeBarra.Size = New System.Drawing.Size(128, 20)
        Me.lblCodigodeBarra.TabIndex = 464
        Me.lblCodigodeBarra.Text = "Codigo de Barra:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Location = New System.Drawing.Point(458, 553)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(201, 50)
        Me.PictureBox1.TabIndex = 474
        Me.PictureBox1.TabStop = False
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNombreProveedor.BackColor = System.Drawing.Color.White
        Me.txtNombreProveedor.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtNombreProveedor.BorderColorIdle = System.Drawing.Color.White
        Me.txtNombreProveedor.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtNombreProveedor.BorderThickness = 2
        Me.txtNombreProveedor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtNombreProveedor.ForeColor = System.Drawing.Color.Black
        Me.txtNombreProveedor.isPassword = False
        Me.txtNombreProveedor.Location = New System.Drawing.Point(384, 316)
        Me.txtNombreProveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Size = New System.Drawing.Size(220, 30)
        Me.txtNombreProveedor.TabIndex = 458
        Me.txtNombreProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblProveedor
        '
        Me.lblProveedor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.lblProveedor.Location = New System.Drawing.Point(78, 325)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(85, 20)
        Me.lblProveedor.TabIndex = 470
        Me.lblProveedor.Text = "Proveedor:"
        '
        'txtCodigoBarra
        '
        Me.txtCodigoBarra.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCodigoBarra.BackColor = System.Drawing.Color.White
        Me.txtCodigoBarra.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtCodigoBarra.BorderColorIdle = System.Drawing.Color.White
        Me.txtCodigoBarra.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtCodigoBarra.BorderThickness = 2
        Me.txtCodigoBarra.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodigoBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtCodigoBarra.ForeColor = System.Drawing.Color.Black
        Me.txtCodigoBarra.isPassword = False
        Me.txtCodigoBarra.Location = New System.Drawing.Point(270, 149)
        Me.txtCodigoBarra.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoBarra.Name = "txtCodigoBarra"
        Me.txtCodigoBarra.Size = New System.Drawing.Size(334, 30)
        Me.txtCodigoBarra.TabIndex = 451
        Me.txtCodigoBarra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblCodigoBarra
        '
        Me.lblCodigoBarra.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCodigoBarra.AutoSize = True
        Me.lblCodigoBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoBarra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.lblCodigoBarra.Location = New System.Drawing.Point(78, 158)
        Me.lblCodigoBarra.Name = "lblCodigoBarra"
        Me.lblCodigoBarra.Size = New System.Drawing.Size(106, 20)
        Me.lblCodigoBarra.TabIndex = 466
        Me.lblCodigoBarra.Text = "Codigo Barra:"
        '
        'lblStock
        '
        Me.lblStock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStock.AutoSize = True
        Me.lblStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.lblStock.Location = New System.Drawing.Point(78, 497)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(54, 20)
        Me.lblStock.TabIndex = 473
        Me.lblStock.Text = "Stock:"
        '
        'txtNombreCategoria
        '
        Me.txtNombreCategoria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNombreCategoria.BackColor = System.Drawing.Color.White
        Me.txtNombreCategoria.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtNombreCategoria.BorderColorIdle = System.Drawing.Color.White
        Me.txtNombreCategoria.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtNombreCategoria.BorderThickness = 2
        Me.txtNombreCategoria.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtNombreCategoria.ForeColor = System.Drawing.Color.Black
        Me.txtNombreCategoria.isPassword = False
        Me.txtNombreCategoria.Location = New System.Drawing.Point(384, 274)
        Me.txtNombreCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreCategoria.Name = "txtNombreCategoria"
        Me.txtNombreCategoria.Size = New System.Drawing.Size(220, 30)
        Me.txtNombreCategoria.TabIndex = 456
        Me.txtNombreCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtNombreMarca
        '
        Me.txtNombreMarca.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNombreMarca.BackColor = System.Drawing.Color.White
        Me.txtNombreMarca.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtNombreMarca.BorderColorIdle = System.Drawing.Color.White
        Me.txtNombreMarca.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtNombreMarca.BorderThickness = 2
        Me.txtNombreMarca.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtNombreMarca.ForeColor = System.Drawing.Color.Black
        Me.txtNombreMarca.isPassword = False
        Me.txtNombreMarca.Location = New System.Drawing.Point(384, 233)
        Me.txtNombreMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreMarca.Name = "txtNombreMarca"
        Me.txtNombreMarca.Size = New System.Drawing.Size(220, 30)
        Me.txtNombreMarca.TabIndex = 454
        Me.txtNombreMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDescripcion.BackColor = System.Drawing.Color.White
        Me.txtDescripcion.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtDescripcion.BorderColorIdle = System.Drawing.Color.White
        Me.txtDescripcion.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtDescripcion.BorderThickness = 2
        Me.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtDescripcion.ForeColor = System.Drawing.Color.Black
        Me.txtDescripcion.isPassword = False
        Me.txtDescripcion.Location = New System.Drawing.Point(270, 192)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(334, 30)
        Me.txtDescripcion.TabIndex = 452
        Me.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.txtCodigo.Location = New System.Drawing.Point(270, 103)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(106, 30)
        Me.txtCodigo.TabIndex = 450
        Me.txtCodigo.Text = "0"
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblPrecioMinimo
        '
        Me.lblPrecioMinimo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPrecioMinimo.AutoSize = True
        Me.lblPrecioMinimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioMinimo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.lblPrecioMinimo.Location = New System.Drawing.Point(78, 368)
        Me.lblPrecioMinimo.Name = "lblPrecioMinimo"
        Me.lblPrecioMinimo.Size = New System.Drawing.Size(103, 20)
        Me.lblPrecioMinimo.TabIndex = 471
        Me.lblPrecioMinimo.Text = "Precio Costo:"
        '
        'lblPrecioNormal
        '
        Me.lblPrecioNormal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPrecioNormal.AutoSize = True
        Me.lblPrecioNormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioNormal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.lblPrecioNormal.Location = New System.Drawing.Point(78, 453)
        Me.lblPrecioNormal.Name = "lblPrecioNormal"
        Me.lblPrecioNormal.Size = New System.Drawing.Size(111, 20)
        Me.lblPrecioNormal.TabIndex = 472
        Me.lblPrecioNormal.Text = "Precio Normal:"
        '
        'lblCategoria
        '
        Me.lblCategoria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.lblCategoria.Location = New System.Drawing.Point(78, 283)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(82, 20)
        Me.lblCategoria.TabIndex = 469
        Me.lblCategoria.Text = "Categoria:"
        '
        'lblMarca
        '
        Me.lblMarca.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.lblMarca.Location = New System.Drawing.Point(78, 242)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(57, 20)
        Me.lblMarca.TabIndex = 468
        Me.lblMarca.Text = "Marca:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.lblDescripcion.Location = New System.Drawing.Point(78, 201)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(96, 20)
        Me.lblDescripcion.TabIndex = 467
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'lblCodigo
        '
        Me.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.lblCodigo.Location = New System.Drawing.Point(78, 112)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(59, 20)
        Me.lblCodigo.TabIndex = 465
        Me.lblCodigo.Text = "Codigo"
        '
        'frmAlmacen_Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 723)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAlmacen_Inventario"
        Me.Text = "frmAlmacen_Inventario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtPrecioMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNormal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtidAlmacen As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnEliminar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtinventarioLitros As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtTotal As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnCancelar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnGuardar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lbltitulo As Label
    Friend WithEvents txtPrecioMinimo As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProveedor As NumericUpDown
    Friend WithEvents txtCategoria As NumericUpDown
    Friend WithEvents txtMarca As NumericUpDown
    Friend WithEvents txtNormal As NumericUpDown
    Friend WithEvents txtCosto As NumericUpDown
    Friend WithEvents txtStock As NumericUpDown
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents btnGenerar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblCodigodeBarra As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtNombreProveedor As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblProveedor As Label
    Friend WithEvents txtCodigoBarra As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblCodigoBarra As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents txtNombreCategoria As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtNombreMarca As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtDescripcion As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtCodigo As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblPrecioMinimo As Label
    Friend WithEvents lblPrecioNormal As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents lblMarca As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents kilos As Label
    Friend WithEvents txtkilos As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents txttotalKilos As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
