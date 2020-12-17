<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenta))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.txtiva = New System.Windows.Forms.NumericUpDown()
        Me.txttotal = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtDescuento = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnCredito = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtsubtotal = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FiltroDeBusquedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.F5BuscarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.F6BuscarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtPrecio = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtCantidad = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtIdProducto = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtStock = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtProveedor = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtCategoria = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtMarca = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtDescripcion = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnCancelar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnGuardar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtTps = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtTrs = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtTus = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtTgs = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtps = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtus = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtrs = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtgs = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dpFechaVenta = New System.Windows.Forms.DateTimePicker()
        Me.txtRucCliente = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtNomCliente = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtIdCliente = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtidVenta = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtComprobante = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.colNro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.txtiva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.PanelContenedor.Controls.Add(Me.txtiva)
        Me.PanelContenedor.Controls.Add(Me.txttotal)
        Me.PanelContenedor.Controls.Add(Me.Label12)
        Me.PanelContenedor.Controls.Add(Me.TxtDescuento)
        Me.PanelContenedor.Controls.Add(Me.Label10)
        Me.PanelContenedor.Controls.Add(Me.btnCredito)
        Me.PanelContenedor.Controls.Add(Me.txtsubtotal)
        Me.PanelContenedor.Controls.Add(Me.MenuStrip1)
        Me.PanelContenedor.Controls.Add(Me.txtPrecio)
        Me.PanelContenedor.Controls.Add(Me.txtCantidad)
        Me.PanelContenedor.Controls.Add(Me.txtIdProducto)
        Me.PanelContenedor.Controls.Add(Me.GroupBox3)
        Me.PanelContenedor.Controls.Add(Me.btnCancelar)
        Me.PanelContenedor.Controls.Add(Me.btnGuardar)
        Me.PanelContenedor.Controls.Add(Me.GroupBox4)
        Me.PanelContenedor.Controls.Add(Me.Label22)
        Me.PanelContenedor.Controls.Add(Me.GroupBox1)
        Me.PanelContenedor.Controls.Add(Me.GroupBox2)
        Me.PanelContenedor.Controls.Add(Me.grilla)
        Me.PanelContenedor.Controls.Add(Me.Label8)
        Me.PanelContenedor.Controls.Add(Me.Label7)
        Me.PanelContenedor.Controls.Add(Me.Label6)
        Me.PanelContenedor.Controls.Add(Me.Label5)
        Me.PanelContenedor.Controls.Add(Me.Label4)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1066, 723)
        Me.PanelContenedor.TabIndex = 6
        '
        'txtiva
        '
        Me.txtiva.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtiva.DecimalPlaces = 2
        Me.txtiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtiva.Location = New System.Drawing.Point(617, 607)
        Me.txtiva.Maximum = New Decimal(New Integer() {-159383552, 46653770, 5421, 0})
        Me.txtiva.Name = "txtiva"
        Me.txtiva.Size = New System.Drawing.Size(149, 26)
        Me.txtiva.TabIndex = 518
        '
        'txttotal
        '
        Me.txttotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txttotal.DecimalPlaces = 2
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(909, 569)
        Me.txttotal.Maximum = New Decimal(New Integer() {-159383552, 46653770, 5421, 0})
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(145, 62)
        Me.txttotal.TabIndex = 517
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(65, 647)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 16)
        Me.Label12.TabIndex = 444
        Me.Label12.Text = "DESCUENTO:"
        '
        'TxtDescuento
        '
        Me.TxtDescuento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtDescuento.BackColor = System.Drawing.Color.White
        Me.TxtDescuento.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.TxtDescuento.BorderColorIdle = System.Drawing.Color.White
        Me.TxtDescuento.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.TxtDescuento.BorderThickness = 2
        Me.TxtDescuento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.TxtDescuento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.TxtDescuento.isPassword = False
        Me.TxtDescuento.Location = New System.Drawing.Point(169, 632)
        Me.TxtDescuento.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtDescuento.Name = "TxtDescuento"
        Me.TxtDescuento.Size = New System.Drawing.Size(149, 31)
        Me.TxtDescuento.TabIndex = 443
        Me.TxtDescuento.Text = "0"
        Me.TxtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(773, 590)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 20)
        Me.Label10.TabIndex = 442
        Me.Label10.Text = "TOTAL VENTA:"
        '
        'btnCredito
        '
        Me.btnCredito.ActiveBorderThickness = 2
        Me.btnCredito.ActiveCornerRadius = 10
        Me.btnCredito.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnCredito.ActiveForecolor = System.Drawing.Color.White
        Me.btnCredito.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnCredito.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btnCredito.BackgroundImage = CType(resources.GetObject("btnCredito.BackgroundImage"), System.Drawing.Image)
        Me.btnCredito.ButtonText = "Credito"
        Me.btnCredito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredito.ForeColor = System.Drawing.Color.White
        Me.btnCredito.IdleBorderThickness = 2
        Me.btnCredito.IdleCornerRadius = 10
        Me.btnCredito.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnCredito.IdleForecolor = System.Drawing.Color.White
        Me.btnCredito.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnCredito.Location = New System.Drawing.Point(257, 671)
        Me.btnCredito.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCredito.Name = "btnCredito"
        Me.btnCredito.Size = New System.Drawing.Size(185, 54)
        Me.btnCredito.TabIndex = 441
        Me.btnCredito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsubtotal.BackColor = System.Drawing.Color.White
        Me.txtsubtotal.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtsubtotal.BorderColorIdle = System.Drawing.Color.White
        Me.txtsubtotal.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtsubtotal.BorderThickness = 2
        Me.txtsubtotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtsubtotal.ForeColor = System.Drawing.Color.Black
        Me.txtsubtotal.isPassword = False
        Me.txtsubtotal.Location = New System.Drawing.Point(617, 564)
        Me.txtsubtotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(149, 30)
        Me.txtsubtotal.TabIndex = 438
        Me.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FiltroDeBusquedaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1066, 24)
        Me.MenuStrip1.TabIndex = 437
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FiltroDeBusquedaToolStripMenuItem
        '
        Me.FiltroDeBusquedaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.F5BuscarProductoToolStripMenuItem, Me.F6BuscarClienteToolStripMenuItem})
        Me.FiltroDeBusquedaToolStripMenuItem.Name = "FiltroDeBusquedaToolStripMenuItem"
        Me.FiltroDeBusquedaToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
        Me.FiltroDeBusquedaToolStripMenuItem.Text = "Filtro de busqueda"
        '
        'F5BuscarProductoToolStripMenuItem
        '
        Me.F5BuscarProductoToolStripMenuItem.Name = "F5BuscarProductoToolStripMenuItem"
        Me.F5BuscarProductoToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.F5BuscarProductoToolStripMenuItem.Text = "F5 - Buscar Producto"
        '
        'F6BuscarClienteToolStripMenuItem
        '
        Me.F6BuscarClienteToolStripMenuItem.Name = "F6BuscarClienteToolStripMenuItem"
        Me.F6BuscarClienteToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.F6BuscarClienteToolStripMenuItem.Text = "F6 - Buscar Cliente"
        '
        'txtPrecio
        '
        Me.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrecio.BackColor = System.Drawing.Color.White
        Me.txtPrecio.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtPrecio.BorderColorIdle = System.Drawing.Color.White
        Me.txtPrecio.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtPrecio.BorderThickness = 2
        Me.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtPrecio.ForeColor = System.Drawing.Color.Black
        Me.txtPrecio.isPassword = False
        Me.txtPrecio.Location = New System.Drawing.Point(326, 564)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(149, 30)
        Me.txtPrecio.TabIndex = 436
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtCantidad
        '
        Me.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCantidad.BackColor = System.Drawing.Color.White
        Me.txtCantidad.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtCantidad.BorderColorIdle = System.Drawing.Color.White
        Me.txtCantidad.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtCantidad.BorderThickness = 2
        Me.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtCantidad.ForeColor = System.Drawing.Color.Black
        Me.txtCantidad.isPassword = False
        Me.txtCantidad.Location = New System.Drawing.Point(169, 564)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(149, 30)
        Me.txtCantidad.TabIndex = 430
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtIdProducto.BackColor = System.Drawing.Color.White
        Me.txtIdProducto.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtIdProducto.BorderColorIdle = System.Drawing.Color.White
        Me.txtIdProducto.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtIdProducto.BorderThickness = 2
        Me.txtIdProducto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtIdProducto.ForeColor = System.Drawing.Color.Black
        Me.txtIdProducto.isPassword = False
        Me.txtIdProducto.Location = New System.Drawing.Point(12, 564)
        Me.txtIdProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(149, 30)
        Me.txtIdProducto.TabIndex = 429
        Me.txtIdProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.txtStock)
        Me.GroupBox3.Controls.Add(Me.txtProveedor)
        Me.GroupBox3.Controls.Add(Me.txtCategoria)
        Me.GroupBox3.Controls.Add(Me.txtMarca)
        Me.GroupBox3.Controls.Add(Me.txtDescripcion)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 153)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(665, 157)
        Me.GroupBox3.TabIndex = 423
        Me.GroupBox3.TabStop = False
        '
        'txtStock
        '
        Me.txtStock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtStock.BackColor = System.Drawing.Color.White
        Me.txtStock.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtStock.BorderColorIdle = System.Drawing.Color.White
        Me.txtStock.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtStock.BorderThickness = 2
        Me.txtStock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtStock.ForeColor = System.Drawing.Color.Black
        Me.txtStock.isPassword = False
        Me.txtStock.Location = New System.Drawing.Point(526, 103)
        Me.txtStock.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(132, 30)
        Me.txtStock.TabIndex = 428
        Me.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtProveedor
        '
        Me.txtProveedor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtProveedor.BackColor = System.Drawing.Color.White
        Me.txtProveedor.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtProveedor.BorderColorIdle = System.Drawing.Color.White
        Me.txtProveedor.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtProveedor.BorderThickness = 2
        Me.txtProveedor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtProveedor.ForeColor = System.Drawing.Color.Black
        Me.txtProveedor.isPassword = False
        Me.txtProveedor.Location = New System.Drawing.Point(273, 103)
        Me.txtProveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(245, 30)
        Me.txtProveedor.TabIndex = 427
        Me.txtProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtCategoria
        '
        Me.txtCategoria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCategoria.BackColor = System.Drawing.Color.White
        Me.txtCategoria.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtCategoria.BorderColorIdle = System.Drawing.Color.White
        Me.txtCategoria.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtCategoria.BorderThickness = 2
        Me.txtCategoria.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtCategoria.ForeColor = System.Drawing.Color.Black
        Me.txtCategoria.isPassword = False
        Me.txtCategoria.Location = New System.Drawing.Point(23, 103)
        Me.txtCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(235, 30)
        Me.txtCategoria.TabIndex = 425
        Me.txtCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtMarca
        '
        Me.txtMarca.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMarca.BackColor = System.Drawing.Color.White
        Me.txtMarca.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtMarca.BorderColorIdle = System.Drawing.Color.White
        Me.txtMarca.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtMarca.BorderThickness = 2
        Me.txtMarca.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtMarca.ForeColor = System.Drawing.Color.Black
        Me.txtMarca.isPassword = False
        Me.txtMarca.Location = New System.Drawing.Point(273, 37)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(246, 30)
        Me.txtMarca.TabIndex = 424
        Me.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.txtDescripcion.Location = New System.Drawing.Point(23, 37)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(235, 30)
        Me.txtDescripcion.TabIndex = 423
        Me.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(522, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 376
        Me.Label3.Text = "Stock:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(19, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 375
        Me.Label2.Text = "Descripcion:"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(269, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 20)
        Me.Label13.TabIndex = 396
        Me.Label13.Text = "Marca:"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(19, 78)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 20)
        Me.Label19.TabIndex = 398
        Me.Label19.Text = "Categoria:"
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(269, 78)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(85, 20)
        Me.Label20.TabIndex = 400
        Me.Label20.Text = "Proveedor:"
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
        Me.btnCancelar.Location = New System.Drawing.Point(647, 671)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(185, 54)
        Me.btnCancelar.TabIndex = 406
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
        Me.btnGuardar.Location = New System.Drawing.Point(452, 671)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(185, 54)
        Me.btnGuardar.TabIndex = 405
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox4.Controls.Add(Me.txtTps)
        Me.GroupBox4.Controls.Add(Me.txtTrs)
        Me.GroupBox4.Controls.Add(Me.txtTus)
        Me.GroupBox4.Controls.Add(Me.txtTgs)
        Me.GroupBox4.Controls.Add(Me.txtps)
        Me.GroupBox4.Controls.Add(Me.txtus)
        Me.GroupBox4.Controls.Add(Me.txtrs)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(682, 104)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(377, 206)
        Me.GroupBox4.TabIndex = 404
        Me.GroupBox4.TabStop = False
        '
        'txtTps
        '
        Me.txtTps.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTps.BackColor = System.Drawing.Color.White
        Me.txtTps.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtTps.BorderColorIdle = System.Drawing.Color.White
        Me.txtTps.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtTps.BorderThickness = 2
        Me.txtTps.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTps.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtTps.ForeColor = System.Drawing.Color.Black
        Me.txtTps.isPassword = False
        Me.txtTps.Location = New System.Drawing.Point(69, 161)
        Me.txtTps.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTps.Name = "txtTps"
        Me.txtTps.Size = New System.Drawing.Size(136, 30)
        Me.txtTps.TabIndex = 436
        Me.txtTps.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtTrs
        '
        Me.txtTrs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTrs.BackColor = System.Drawing.Color.White
        Me.txtTrs.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtTrs.BorderColorIdle = System.Drawing.Color.White
        Me.txtTrs.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtTrs.BorderThickness = 2
        Me.txtTrs.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtTrs.ForeColor = System.Drawing.Color.Black
        Me.txtTrs.isPassword = False
        Me.txtTrs.Location = New System.Drawing.Point(69, 121)
        Me.txtTrs.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTrs.Name = "txtTrs"
        Me.txtTrs.Size = New System.Drawing.Size(136, 30)
        Me.txtTrs.TabIndex = 435
        Me.txtTrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtTus
        '
        Me.txtTus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTus.BackColor = System.Drawing.Color.White
        Me.txtTus.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtTus.BorderColorIdle = System.Drawing.Color.White
        Me.txtTus.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtTus.BorderThickness = 2
        Me.txtTus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtTus.ForeColor = System.Drawing.Color.Black
        Me.txtTus.isPassword = False
        Me.txtTus.Location = New System.Drawing.Point(69, 81)
        Me.txtTus.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTus.Name = "txtTus"
        Me.txtTus.Size = New System.Drawing.Size(136, 30)
        Me.txtTus.TabIndex = 434
        Me.txtTus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtTgs
        '
        Me.txtTgs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTgs.BackColor = System.Drawing.Color.White
        Me.txtTgs.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtTgs.BorderColorIdle = System.Drawing.Color.White
        Me.txtTgs.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtTgs.BorderThickness = 2
        Me.txtTgs.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTgs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtTgs.ForeColor = System.Drawing.Color.Black
        Me.txtTgs.isPassword = False
        Me.txtTgs.Location = New System.Drawing.Point(69, 41)
        Me.txtTgs.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTgs.Name = "txtTgs"
        Me.txtTgs.Size = New System.Drawing.Size(136, 30)
        Me.txtTgs.TabIndex = 433
        Me.txtTgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtps
        '
        Me.txtps.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtps.BackColor = System.Drawing.Color.White
        Me.txtps.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtps.BorderColorIdle = System.Drawing.Color.White
        Me.txtps.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtps.BorderThickness = 2
        Me.txtps.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtps.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtps.ForeColor = System.Drawing.Color.Black
        Me.txtps.isPassword = False
        Me.txtps.Location = New System.Drawing.Point(220, 161)
        Me.txtps.Margin = New System.Windows.Forms.Padding(4)
        Me.txtps.Name = "txtps"
        Me.txtps.Size = New System.Drawing.Size(136, 30)
        Me.txtps.TabIndex = 432
        Me.txtps.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtus
        '
        Me.txtus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtus.BackColor = System.Drawing.Color.White
        Me.txtus.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtus.BorderColorIdle = System.Drawing.Color.White
        Me.txtus.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtus.BorderThickness = 2
        Me.txtus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtus.ForeColor = System.Drawing.Color.Black
        Me.txtus.isPassword = False
        Me.txtus.Location = New System.Drawing.Point(220, 81)
        Me.txtus.Margin = New System.Windows.Forms.Padding(4)
        Me.txtus.Name = "txtus"
        Me.txtus.Size = New System.Drawing.Size(136, 30)
        Me.txtus.TabIndex = 431
        Me.txtus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtrs
        '
        Me.txtrs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtrs.BackColor = System.Drawing.Color.White
        Me.txtrs.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtrs.BorderColorIdle = System.Drawing.Color.White
        Me.txtrs.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtrs.BorderThickness = 2
        Me.txtrs.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtrs.ForeColor = System.Drawing.Color.Black
        Me.txtrs.isPassword = False
        Me.txtrs.Location = New System.Drawing.Point(220, 121)
        Me.txtrs.Margin = New System.Windows.Forms.Padding(4)
        Me.txtrs.Name = "txtrs"
        Me.txtrs.Size = New System.Drawing.Size(136, 30)
        Me.txtrs.TabIndex = 430
        Me.txtrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(111, 8)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(140, 20)
        Me.Label24.TabIndex = 403
        Me.Label24.Text = "Cotización del Dia:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(16, 164)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(27, 20)
        Me.Label25.TabIndex = 25
        Me.Label25.Text = "Ps"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(16, 84)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(29, 20)
        Me.Label26.TabIndex = 24
        Me.Label26.Text = "Us"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(16, 124)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(29, 20)
        Me.Label27.TabIndex = 23
        Me.Label27.Text = "Rs"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(16, 44)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(30, 20)
        Me.Label28.TabIndex = 22
        Me.Label28.Text = "Gs"
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(698, 94)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(0, 20)
        Me.Label22.TabIndex = 402
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.txtgs)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Location = New System.Drawing.Point(682, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(377, 85)
        Me.GroupBox1.TabIndex = 394
        Me.GroupBox1.TabStop = False
        '
        'txtgs
        '
        Me.txtgs.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtgs.BackColor = System.Drawing.Color.White
        Me.txtgs.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtgs.BorderColorIdle = System.Drawing.Color.White
        Me.txtgs.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtgs.BorderThickness = 2
        Me.txtgs.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtgs.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.txtgs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.txtgs.isPassword = False
        Me.txtgs.Location = New System.Drawing.Point(144, 10)
        Me.txtgs.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.txtgs.Name = "txtgs"
        Me.txtgs.Size = New System.Drawing.Size(225, 70)
        Me.txtgs.TabIndex = 403
        Me.txtgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(1, 30)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(128, 26)
        Me.Label21.TabIndex = 402
        Me.Label21.Text = "Total Venta:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.dpFechaVenta)
        Me.GroupBox2.Controls.Add(Me.txtRucCliente)
        Me.GroupBox2.Controls.Add(Me.txtNomCliente)
        Me.GroupBox2.Controls.Add(Me.txtIdCliente)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtidVenta)
        Me.GroupBox2.Controls.Add(Me.txtComprobante)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(665, 134)
        Me.GroupBox2.TabIndex = 393
        Me.GroupBox2.TabStop = False
        '
        'dpFechaVenta
        '
        Me.dpFechaVenta.Location = New System.Drawing.Point(379, 22)
        Me.dpFechaVenta.Name = "dpFechaVenta"
        Me.dpFechaVenta.Size = New System.Drawing.Size(251, 20)
        Me.dpFechaVenta.TabIndex = 423
        '
        'txtRucCliente
        '
        Me.txtRucCliente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRucCliente.BackColor = System.Drawing.Color.White
        Me.txtRucCliente.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtRucCliente.BorderColorIdle = System.Drawing.Color.White
        Me.txtRucCliente.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtRucCliente.BorderThickness = 2
        Me.txtRucCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRucCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtRucCliente.ForeColor = System.Drawing.Color.Black
        Me.txtRucCliente.isPassword = False
        Me.txtRucCliente.Location = New System.Drawing.Point(452, 93)
        Me.txtRucCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRucCliente.Name = "txtRucCliente"
        Me.txtRucCliente.Size = New System.Drawing.Size(211, 30)
        Me.txtRucCliente.TabIndex = 422
        Me.txtRucCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtNomCliente
        '
        Me.txtNomCliente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNomCliente.BackColor = System.Drawing.Color.White
        Me.txtNomCliente.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtNomCliente.BorderColorIdle = System.Drawing.Color.White
        Me.txtNomCliente.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtNomCliente.BorderThickness = 2
        Me.txtNomCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNomCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtNomCliente.ForeColor = System.Drawing.Color.Black
        Me.txtNomCliente.isPassword = False
        Me.txtNomCliente.Location = New System.Drawing.Point(266, 93)
        Me.txtNomCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNomCliente.Name = "txtNomCliente"
        Me.txtNomCliente.Size = New System.Drawing.Size(178, 30)
        Me.txtNomCliente.TabIndex = 421
        Me.txtNomCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtIdCliente.BackColor = System.Drawing.Color.White
        Me.txtIdCliente.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtIdCliente.BorderColorIdle = System.Drawing.Color.White
        Me.txtIdCliente.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtIdCliente.BorderThickness = 2
        Me.txtIdCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtIdCliente.ForeColor = System.Drawing.Color.Black
        Me.txtIdCliente.isPassword = False
        Me.txtIdCliente.Location = New System.Drawing.Point(80, 93)
        Me.txtIdCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(178, 30)
        Me.txtIdCliente.TabIndex = 420
        Me.txtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(3, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 20)
        Me.Label15.TabIndex = 419
        Me.Label15.Text = "Comprobante:"
        '
        'txtidVenta
        '
        Me.txtidVenta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtidVenta.BackColor = System.Drawing.Color.White
        Me.txtidVenta.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtidVenta.BorderColorIdle = System.Drawing.Color.White
        Me.txtidVenta.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtidVenta.BorderThickness = 2
        Me.txtidVenta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtidVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtidVenta.ForeColor = System.Drawing.Color.Black
        Me.txtidVenta.isPassword = False
        Me.txtidVenta.Location = New System.Drawing.Point(165, 55)
        Me.txtidVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidVenta.Name = "txtidVenta"
        Me.txtidVenta.Size = New System.Drawing.Size(178, 30)
        Me.txtidVenta.TabIndex = 417
        Me.txtidVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtComprobante
        '
        Me.txtComprobante.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtComprobante.BackColor = System.Drawing.Color.White
        Me.txtComprobante.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtComprobante.BorderColorIdle = System.Drawing.Color.White
        Me.txtComprobante.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtComprobante.BorderThickness = 2
        Me.txtComprobante.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtComprobante.ForeColor = System.Drawing.Color.Black
        Me.txtComprobante.isPassword = False
        Me.txtComprobante.Location = New System.Drawing.Point(165, 17)
        Me.txtComprobante.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComprobante.Name = "txtComprobante"
        Me.txtComprobante.Size = New System.Drawing.Size(178, 30)
        Me.txtComprobante.TabIndex = 416
        Me.txtComprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(3, 59)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 20)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Factura De Venta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cliente:"
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grilla.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.grilla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grilla.ColumnHeadersHeight = 30
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNro, Me.colCodigo, Me.colDescripcion, Me.colPrecio, Me.Column1, Me.colCantidad, Me.colSubTotal})
        Me.grilla.EnableHeadersVisualStyles = False
        Me.grilla.GridColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grilla.Location = New System.Drawing.Point(12, 317)
        Me.grilla.Margin = New System.Windows.Forms.Padding(4)
        Me.grilla.Name = "grilla"
        Me.grilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grilla.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.grilla.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.grilla.Size = New System.Drawing.Size(1047, 239)
        Me.grilla.TabIndex = 392
        '
        'colNro
        '
        Me.colNro.HeaderText = "Nro"
        Me.colNro.Name = "colNro"
        '
        'colCodigo
        '
        Me.colCodigo.HeaderText = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        '
        'colDescripcion
        '
        Me.colDescripcion.HeaderText = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        '
        'colPrecio
        '
        Me.colPrecio.HeaderText = "Precio"
        Me.colPrecio.Name = "colPrecio"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Descuento"
        Me.Column1.Name = "Column1"
        '
        'colCantidad
        '
        Me.colCantidad.HeaderText = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        '
        'colSubTotal
        '
        Me.colSubTotal.HeaderText = "SubTotal"
        Me.colSubTotal.Name = "colSubTotal"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(561, 611)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 20)
        Me.Label8.TabIndex = 381
        Me.Label8.Text = "IVA:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(514, 573)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 20)
        Me.Label7.TabIndex = 380
        Me.Label7.Text = "SUB TOTAL:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(322, 607)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 379
        Me.Label6.Text = "Precio:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(165, 607)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 378
        Me.Label5.Text = "Cantidad:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 622)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 377
        Me.Label4.Text = "Codigo:"
        '
        'frmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 723)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVenta"
        Me.Text = "frmVenta"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelContenedor.PerformLayout()
        CType(Me.txtiva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelContenedor As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnCredito As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtsubtotal As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FiltroDeBusquedaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents F5BuscarProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents F6BuscarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtPrecio As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtCantidad As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtIdProducto As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtStock As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtProveedor As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtCategoria As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtMarca As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtDescripcion As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnGuardar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTps As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtTrs As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtTus As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtTgs As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtps As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtus As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtrs As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtgs As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dpFechaVenta As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRucCliente As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtNomCliente As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtIdCliente As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtidVenta As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtComprobante As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grilla As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtDescuento As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents colNro As DataGridViewTextBoxColumn
    Friend WithEvents colCodigo As DataGridViewTextBoxColumn
    Friend WithEvents colDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents colPrecio As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents colCantidad As DataGridViewTextBoxColumn
    Friend WithEvents colSubTotal As DataGridViewTextBoxColumn
    Friend WithEvents txtiva As NumericUpDown
    Friend WithEvents txttotal As NumericUpDown
End Class
