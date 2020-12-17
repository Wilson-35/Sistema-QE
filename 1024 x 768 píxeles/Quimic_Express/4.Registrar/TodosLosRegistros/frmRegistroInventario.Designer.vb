<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistroInventario
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistroInventario))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.txtPrecioMinimo = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNuevo = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnEliminar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.grdInventario = New System.Windows.Forms.DataGridView()
        Me.btnEliminarFoto = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnBuscarFoto = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.pctFoto = New System.Windows.Forms.PictureBox()
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
        Me.btnCancelar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnGuardar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.InventarioBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventarioBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventarioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodigoBarraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.txtPrecioMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.PanelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelContenedor.Controls.Add(Me.txtPrecioMinimo)
        Me.PanelContenedor.Controls.Add(Me.Label1)
        Me.PanelContenedor.Controls.Add(Me.btnNuevo)
        Me.PanelContenedor.Controls.Add(Me.btnEliminar)
        Me.PanelContenedor.Controls.Add(Me.grdInventario)
        Me.PanelContenedor.Controls.Add(Me.btnEliminarFoto)
        Me.PanelContenedor.Controls.Add(Me.btnBuscarFoto)
        Me.PanelContenedor.Controls.Add(Me.pctFoto)
        Me.PanelContenedor.Controls.Add(Me.txtProveedor)
        Me.PanelContenedor.Controls.Add(Me.txtCategoria)
        Me.PanelContenedor.Controls.Add(Me.txtMarca)
        Me.PanelContenedor.Controls.Add(Me.txtNormal)
        Me.PanelContenedor.Controls.Add(Me.txtCosto)
        Me.PanelContenedor.Controls.Add(Me.txtStock)
        Me.PanelContenedor.Controls.Add(Me.dtpFecha)
        Me.PanelContenedor.Controls.Add(Me.btnGenerar)
        Me.PanelContenedor.Controls.Add(Me.lblCodigodeBarra)
        Me.PanelContenedor.Controls.Add(Me.PictureBox1)
        Me.PanelContenedor.Controls.Add(Me.txtNombreProveedor)
        Me.PanelContenedor.Controls.Add(Me.lblProveedor)
        Me.PanelContenedor.Controls.Add(Me.txtCodigoBarra)
        Me.PanelContenedor.Controls.Add(Me.lblCodigoBarra)
        Me.PanelContenedor.Controls.Add(Me.lblStock)
        Me.PanelContenedor.Controls.Add(Me.txtNombreCategoria)
        Me.PanelContenedor.Controls.Add(Me.txtNombreMarca)
        Me.PanelContenedor.Controls.Add(Me.txtDescripcion)
        Me.PanelContenedor.Controls.Add(Me.txtCodigo)
        Me.PanelContenedor.Controls.Add(Me.lblPrecioMinimo)
        Me.PanelContenedor.Controls.Add(Me.lblPrecioNormal)
        Me.PanelContenedor.Controls.Add(Me.lblCategoria)
        Me.PanelContenedor.Controls.Add(Me.lblMarca)
        Me.PanelContenedor.Controls.Add(Me.lblDescripcion)
        Me.PanelContenedor.Controls.Add(Me.lblCodigo)
        Me.PanelContenedor.Controls.Add(Me.btnCancelar)
        Me.PanelContenedor.Controls.Add(Me.btnGuardar)
        Me.PanelContenedor.Controls.Add(Me.lbltitulo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(842, 730)
        Me.PanelContenedor.TabIndex = 0
        '
        'txtPrecioMinimo
        '
        Me.txtPrecioMinimo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrecioMinimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioMinimo.DecimalPlaces = 2
        Me.txtPrecioMinimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPrecioMinimo.Location = New System.Drawing.Point(125, 356)
        Me.txtPrecioMinimo.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtPrecioMinimo.Name = "txtPrecioMinimo"
        Me.txtPrecioMinimo.Size = New System.Drawing.Size(171, 23)
        Me.txtPrecioMinimo.TabIndex = 448
        Me.txtPrecioMinimo.ThousandsSeparator = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 362)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 449
        Me.Label1.Text = "Precio Minimo:"
        '
        'btnNuevo
        '
        Me.btnNuevo.ActiveBorderThickness = 2
        Me.btnNuevo.ActiveCornerRadius = 10
        Me.btnNuevo.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnNuevo.ActiveForecolor = System.Drawing.Color.White
        Me.btnNuevo.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btnNuevo.BackgroundImage = CType(resources.GetObject("btnNuevo.BackgroundImage"), System.Drawing.Image)
        Me.btnNuevo.ButtonText = "Nuevo"
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.IdleBorderThickness = 2
        Me.btnNuevo.IdleCornerRadius = 10
        Me.btnNuevo.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnNuevo.IdleForecolor = System.Drawing.Color.White
        Me.btnNuevo.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnNuevo.Location = New System.Drawing.Point(425, 593)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(5)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(226, 54)
        Me.btnNuevo.TabIndex = 447
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnEliminar.Location = New System.Drawing.Point(189, 657)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(226, 54)
        Me.btnEliminar.TabIndex = 446
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grdInventario
        '
        Me.grdInventario.AllowUserToAddRows = False
        Me.grdInventario.AllowUserToDeleteRows = False
        Me.grdInventario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grdInventario.AutoGenerateColumns = False
        Me.grdInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdInventario.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.grdInventario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdInventario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdInventario.ColumnHeadersHeight = 30
        Me.grdInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoBarraDataGridViewTextBoxColumn, Me.DescripciónDataGridViewTextBoxColumn})
        Me.grdInventario.DataSource = Me.InventarioBindingSource3
        Me.grdInventario.EnableHeadersVisualStyles = False
        Me.grdInventario.GridColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdInventario.Location = New System.Drawing.Point(465, 316)
        Me.grdInventario.Margin = New System.Windows.Forms.Padding(4)
        Me.grdInventario.Name = "grdInventario"
        Me.grdInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdInventario.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.grdInventario.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.grdInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdInventario.Size = New System.Drawing.Size(371, 268)
        Me.grdInventario.TabIndex = 445
        '
        'btnEliminarFoto
        '
        Me.btnEliminarFoto.ActiveBorderThickness = 2
        Me.btnEliminarFoto.ActiveCornerRadius = 10
        Me.btnEliminarFoto.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnEliminarFoto.ActiveForecolor = System.Drawing.Color.White
        Me.btnEliminarFoto.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnEliminarFoto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEliminarFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btnEliminarFoto.BackgroundImage = CType(resources.GetObject("btnEliminarFoto.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminarFoto.ButtonText = "X"
        Me.btnEliminarFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarFoto.ForeColor = System.Drawing.Color.White
        Me.btnEliminarFoto.IdleBorderThickness = 2
        Me.btnEliminarFoto.IdleCornerRadius = 10
        Me.btnEliminarFoto.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnEliminarFoto.IdleForecolor = System.Drawing.Color.White
        Me.btnEliminarFoto.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnEliminarFoto.Location = New System.Drawing.Point(750, 146)
        Me.btnEliminarFoto.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEliminarFoto.Name = "btnEliminarFoto"
        Me.btnEliminarFoto.Size = New System.Drawing.Size(54, 45)
        Me.btnEliminarFoto.TabIndex = 18
        Me.btnEliminarFoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBuscarFoto
        '
        Me.btnBuscarFoto.ActiveBorderThickness = 2
        Me.btnBuscarFoto.ActiveCornerRadius = 10
        Me.btnBuscarFoto.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnBuscarFoto.ActiveForecolor = System.Drawing.Color.White
        Me.btnBuscarFoto.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnBuscarFoto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBuscarFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btnBuscarFoto.BackgroundImage = CType(resources.GetObject("btnBuscarFoto.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarFoto.ButtonText = "..."
        Me.btnBuscarFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarFoto.ForeColor = System.Drawing.Color.White
        Me.btnBuscarFoto.IdleBorderThickness = 2
        Me.btnBuscarFoto.IdleCornerRadius = 10
        Me.btnBuscarFoto.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnBuscarFoto.IdleForecolor = System.Drawing.Color.White
        Me.btnBuscarFoto.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnBuscarFoto.Location = New System.Drawing.Point(706, 146)
        Me.btnBuscarFoto.Margin = New System.Windows.Forms.Padding(5)
        Me.btnBuscarFoto.Name = "btnBuscarFoto"
        Me.btnBuscarFoto.Size = New System.Drawing.Size(34, 45)
        Me.btnBuscarFoto.TabIndex = 14
        Me.btnBuscarFoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pctFoto
        '
        Me.pctFoto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pctFoto.Location = New System.Drawing.Point(517, 146)
        Me.pctFoto.Name = "pctFoto"
        Me.pctFoto.Size = New System.Drawing.Size(181, 163)
        Me.pctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctFoto.TabIndex = 444
        Me.pctFoto.TabStop = False
        '
        'txtProveedor
        '
        Me.txtProveedor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtProveedor.Location = New System.Drawing.Point(125, 294)
        Me.txtProveedor.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(107, 23)
        Me.txtProveedor.TabIndex = 8
        Me.txtProveedor.ThousandsSeparator = True
        '
        'txtCategoria
        '
        Me.txtCategoria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCategoria.Location = New System.Drawing.Point(125, 264)
        Me.txtCategoria.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(106, 23)
        Me.txtCategoria.TabIndex = 5
        Me.txtCategoria.ThousandsSeparator = True
        '
        'txtMarca
        '
        Me.txtMarca.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtMarca.Location = New System.Drawing.Point(125, 233)
        Me.txtMarca.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(106, 23)
        Me.txtMarca.TabIndex = 3
        Me.txtMarca.ThousandsSeparator = True
        '
        'txtNormal
        '
        Me.txtNormal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNormal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNormal.DecimalPlaces = 2
        Me.txtNormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtNormal.Location = New System.Drawing.Point(125, 385)
        Me.txtNormal.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtNormal.Name = "txtNormal"
        Me.txtNormal.Size = New System.Drawing.Size(171, 23)
        Me.txtNormal.TabIndex = 11
        Me.txtNormal.ThousandsSeparator = True
        '
        'txtCosto
        '
        Me.txtCosto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCosto.DecimalPlaces = 2
        Me.txtCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCosto.Location = New System.Drawing.Point(125, 327)
        Me.txtCosto.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(171, 23)
        Me.txtCosto.TabIndex = 10
        Me.txtCosto.ThousandsSeparator = True
        '
        'txtStock
        '
        Me.txtStock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtStock.Location = New System.Drawing.Point(124, 414)
        Me.txtStock.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(171, 23)
        Me.txtStock.TabIndex = 12
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpFecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(237, 146)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(219, 20)
        Me.dtpFecha.TabIndex = 13
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
        Me.btnGenerar.Location = New System.Drawing.Point(306, 452)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(134, 53)
        Me.btnGenerar.TabIndex = 15
        Me.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCodigodeBarra
        '
        Me.lblCodigodeBarra.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCodigodeBarra.AutoSize = True
        Me.lblCodigodeBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigodeBarra.ForeColor = System.Drawing.Color.Black
        Me.lblCodigodeBarra.Location = New System.Drawing.Point(5, 476)
        Me.lblCodigodeBarra.Name = "lblCodigodeBarra"
        Me.lblCodigodeBarra.Size = New System.Drawing.Size(115, 17)
        Me.lblCodigodeBarra.TabIndex = 19
        Me.lblCodigodeBarra.Text = "Codigo de Barra:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Location = New System.Drawing.Point(124, 453)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 50)
        Me.PictureBox1.TabIndex = 434
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
        Me.txtNombreProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtNombreProveedor.ForeColor = System.Drawing.Color.Black
        Me.txtNombreProveedor.isPassword = False
        Me.txtNombreProveedor.Location = New System.Drawing.Point(237, 294)
        Me.txtNombreProveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Size = New System.Drawing.Size(220, 22)
        Me.txtNombreProveedor.TabIndex = 9
        Me.txtNombreProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblProveedor
        '
        Me.lblProveedor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor.ForeColor = System.Drawing.Color.Black
        Me.lblProveedor.Location = New System.Drawing.Point(5, 299)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(78, 17)
        Me.lblProveedor.TabIndex = 25
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
        Me.txtCodigoBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCodigoBarra.ForeColor = System.Drawing.Color.Black
        Me.txtCodigoBarra.isPassword = False
        Me.txtCodigoBarra.Location = New System.Drawing.Point(124, 174)
        Me.txtCodigoBarra.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoBarra.Name = "txtCodigoBarra"
        Me.txtCodigoBarra.Size = New System.Drawing.Size(334, 22)
        Me.txtCodigoBarra.TabIndex = 1
        Me.txtCodigoBarra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblCodigoBarra
        '
        Me.lblCodigoBarra.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCodigoBarra.AutoSize = True
        Me.lblCodigoBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoBarra.ForeColor = System.Drawing.Color.Black
        Me.lblCodigoBarra.Location = New System.Drawing.Point(5, 179)
        Me.lblCodigoBarra.Name = "lblCodigoBarra"
        Me.lblCodigoBarra.Size = New System.Drawing.Size(95, 17)
        Me.lblCodigoBarra.TabIndex = 21
        Me.lblCodigoBarra.Text = "Codigo Barra:"
        '
        'lblStock
        '
        Me.lblStock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStock.AutoSize = True
        Me.lblStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.ForeColor = System.Drawing.Color.Black
        Me.lblStock.Location = New System.Drawing.Point(5, 420)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(47, 17)
        Me.lblStock.TabIndex = 28
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
        Me.txtNombreCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtNombreCategoria.ForeColor = System.Drawing.Color.Black
        Me.txtNombreCategoria.isPassword = False
        Me.txtNombreCategoria.Location = New System.Drawing.Point(238, 264)
        Me.txtNombreCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreCategoria.Name = "txtNombreCategoria"
        Me.txtNombreCategoria.Size = New System.Drawing.Size(220, 22)
        Me.txtNombreCategoria.TabIndex = 7
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
        Me.txtNombreMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtNombreMarca.ForeColor = System.Drawing.Color.Black
        Me.txtNombreMarca.isPassword = False
        Me.txtNombreMarca.Location = New System.Drawing.Point(238, 234)
        Me.txtNombreMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreMarca.Name = "txtNombreMarca"
        Me.txtNombreMarca.Size = New System.Drawing.Size(220, 22)
        Me.txtNombreMarca.TabIndex = 4
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
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtDescripcion.ForeColor = System.Drawing.Color.Black
        Me.txtDescripcion.isPassword = False
        Me.txtDescripcion.Location = New System.Drawing.Point(124, 204)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(334, 22)
        Me.txtDescripcion.TabIndex = 2
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
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCodigo.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.isPassword = False
        Me.txtCodigo.Location = New System.Drawing.Point(124, 144)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(106, 22)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.Text = "0"
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblPrecioMinimo
        '
        Me.lblPrecioMinimo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPrecioMinimo.AutoSize = True
        Me.lblPrecioMinimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioMinimo.ForeColor = System.Drawing.Color.Black
        Me.lblPrecioMinimo.Location = New System.Drawing.Point(5, 333)
        Me.lblPrecioMinimo.Name = "lblPrecioMinimo"
        Me.lblPrecioMinimo.Size = New System.Drawing.Size(92, 17)
        Me.lblPrecioMinimo.TabIndex = 26
        Me.lblPrecioMinimo.Text = "Precio Costo:"
        '
        'lblPrecioNormal
        '
        Me.lblPrecioNormal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPrecioNormal.AutoSize = True
        Me.lblPrecioNormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioNormal.ForeColor = System.Drawing.Color.Black
        Me.lblPrecioNormal.Location = New System.Drawing.Point(5, 391)
        Me.lblPrecioNormal.Name = "lblPrecioNormal"
        Me.lblPrecioNormal.Size = New System.Drawing.Size(101, 17)
        Me.lblPrecioNormal.TabIndex = 27
        Me.lblPrecioNormal.Text = "Precio Normal:"
        '
        'lblCategoria
        '
        Me.lblCategoria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.ForeColor = System.Drawing.Color.Black
        Me.lblCategoria.Location = New System.Drawing.Point(5, 270)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(73, 17)
        Me.lblCategoria.TabIndex = 24
        Me.lblCategoria.Text = "Categoria:"
        '
        'lblMarca
        '
        Me.lblMarca.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.ForeColor = System.Drawing.Color.Black
        Me.lblMarca.Location = New System.Drawing.Point(5, 239)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(51, 17)
        Me.lblMarca.TabIndex = 23
        Me.lblMarca.Text = "Marca:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.Color.Black
        Me.lblDescripcion.Location = New System.Drawing.Point(5, 209)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(86, 17)
        Me.lblDescripcion.TabIndex = 22
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'lblCodigo
        '
        Me.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.Black
        Me.lblCodigo.Location = New System.Drawing.Point(5, 150)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblCodigo.TabIndex = 20
        Me.lblCodigo.Text = "Codigo"
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
        Me.btnCancelar.Location = New System.Drawing.Point(425, 657)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(226, 54)
        Me.btnCancelar.TabIndex = 17
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
        Me.btnGuardar.Location = New System.Drawing.Point(189, 593)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(226, 54)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltitulo
        '
        Me.lbltitulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.Black
        Me.lbltitulo.Location = New System.Drawing.Point(251, 28)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(338, 29)
        Me.lbltitulo.TabIndex = 19
        Me.lbltitulo.Text = "Registro de Inventario - Nuevo"
        '
        'InventarioBindingSource3
        '
        Me.InventarioBindingSource3.DataSource = GetType(Quimic_Express.Inventario)
        '
        'InventarioBindingSource2
        '
        Me.InventarioBindingSource2.DataSource = GetType(Quimic_Express.Inventario)
        '
        'InventarioBindingSource
        '
        Me.InventarioBindingSource.DataSource = GetType(Quimic_Express.Inventario)
        '
        'InventarioBindingSource1
        '
        Me.InventarioBindingSource1.DataSource = GetType(Quimic_Express.Inventario)
        '
        'CodigoBarraDataGridViewTextBoxColumn
        '
        Me.CodigoBarraDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Barra"
        Me.CodigoBarraDataGridViewTextBoxColumn.HeaderText = "Codigo_Barra"
        Me.CodigoBarraDataGridViewTextBoxColumn.Name = "CodigoBarraDataGridViewTextBoxColumn"
        Me.CodigoBarraDataGridViewTextBoxColumn.Width = 116
        '
        'DescripciónDataGridViewTextBoxColumn
        '
        Me.DescripciónDataGridViewTextBoxColumn.DataPropertyName = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.Name = "DescripciónDataGridViewTextBoxColumn"
        Me.DescripciónDataGridViewTextBoxColumn.Width = 104
        '
        'frmRegistroInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(842, 730)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistroInventario"
        Me.Text = "frmRegristroInventario"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelContenedor.PerformLayout()
        CType(Me.txtPrecioMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNormal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
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
    Friend WithEvents btnCancelar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnGuardar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lbltitulo As Label
    Friend WithEvents btnGenerar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblCodigodeBarra As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtStock As NumericUpDown
    Friend WithEvents txtCategoria As NumericUpDown
    Friend WithEvents txtMarca As NumericUpDown
    Friend WithEvents txtNormal As NumericUpDown
    Friend WithEvents txtCosto As NumericUpDown
    Friend WithEvents btnEliminarFoto As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnBuscarFoto As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents pctFoto As PictureBox
    Friend WithEvents grdInventario As DataGridView
    Friend WithEvents btnEliminar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnNuevo As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtProveedor As NumericUpDown
    Friend WithEvents txtNombreProveedor As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblProveedor As Label
    Friend WithEvents InventarioBindingSource2 As BindingSource
    Friend WithEvents InventarioBindingSource As BindingSource
    Friend WithEvents InventarioBindingSource1 As BindingSource
    Friend WithEvents txtPrecioMinimo As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents InventarioBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents CodigoBarraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
