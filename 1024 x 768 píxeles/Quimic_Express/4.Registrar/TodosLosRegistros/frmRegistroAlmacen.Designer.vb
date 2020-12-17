<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistroAlmacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistroAlmacen))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCantidadKilos = New System.Windows.Forms.NumericUpDown()
        Me.txtCantidadLitro = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrecioLitro = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNuevo = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnEliminar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.grdAlmacen = New System.Windows.Forms.DataGridView()
        Me.txtCategoria = New System.Windows.Forms.NumericUpDown()
        Me.txtMarca = New System.Windows.Forms.NumericUpDown()
        Me.txtPrecioReventa = New System.Windows.Forms.NumericUpDown()
        Me.txtPrecioCosto = New System.Windows.Forms.NumericUpDown()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
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
        Me.IdAlmacenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlmacenBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlmacenBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlmacenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.txtCantidadKilos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidadLitro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioLitro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioReventa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmacenBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmacenBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmacenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtCantidadKilos)
        Me.Panel1.Controls.Add(Me.txtCantidadLitro)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtPrecioLitro)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.grdAlmacen)
        Me.Panel1.Controls.Add(Me.txtCategoria)
        Me.Panel1.Controls.Add(Me.txtMarca)
        Me.Panel1.Controls.Add(Me.txtPrecioReventa)
        Me.Panel1.Controls.Add(Me.txtPrecioCosto)
        Me.Panel1.Controls.Add(Me.dtpFecha)
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
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.lbltitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(842, 730)
        Me.Panel1.TabIndex = 0
        '
        'txtCantidadKilos
        '
        Me.txtCantidadKilos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCantidadKilos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidadKilos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCantidadKilos.Location = New System.Drawing.Point(127, 375)
        Me.txtCantidadKilos.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtCantidadKilos.Name = "txtCantidadKilos"
        Me.txtCantidadKilos.Size = New System.Drawing.Size(171, 23)
        Me.txtCantidadKilos.TabIndex = 7
        '
        'txtCantidadLitro
        '
        Me.txtCantidadLitro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCantidadLitro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidadLitro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCantidadLitro.Location = New System.Drawing.Point(127, 346)
        Me.txtCantidadLitro.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtCantidadLitro.Name = "txtCantidadLitro"
        Me.txtCantidadLitro.Size = New System.Drawing.Size(171, 23)
        Me.txtCantidadLitro.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(20, 381)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Cantidad Kilos:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(20, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Cantidad Litros:"
        '
        'txtPrecioLitro
        '
        Me.txtPrecioLitro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrecioLitro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioLitro.DecimalPlaces = 2
        Me.txtPrecioLitro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPrecioLitro.Location = New System.Drawing.Point(127, 462)
        Me.txtPrecioLitro.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtPrecioLitro.Name = "txtPrecioLitro"
        Me.txtPrecioLitro.Size = New System.Drawing.Size(171, 23)
        Me.txtPrecioLitro.TabIndex = 10
        Me.txtPrecioLitro.ThousandsSeparator = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(20, 468)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Precio Litros:"
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
        Me.btnNuevo.Location = New System.Drawing.Point(426, 556)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(5)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(226, 54)
        Me.btnNuevo.TabIndex = 24
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
        Me.btnEliminar.Location = New System.Drawing.Point(190, 620)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(226, 54)
        Me.btnEliminar.TabIndex = 25
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grdAlmacen
        '
        Me.grdAlmacen.AllowUserToAddRows = False
        Me.grdAlmacen.AllowUserToDeleteRows = False
        Me.grdAlmacen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grdAlmacen.AutoGenerateColumns = False
        Me.grdAlmacen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdAlmacen.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.grdAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdAlmacen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdAlmacen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grdAlmacen.ColumnHeadersHeight = 30
        Me.grdAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdAlmacen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdAlmacenDataGridViewTextBoxColumn, Me.DescripciónDataGridViewTextBoxColumn})
        Me.grdAlmacen.DataSource = Me.AlmacenBindingSource2
        Me.grdAlmacen.EnableHeadersVisualStyles = False
        Me.grdAlmacen.GridColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdAlmacen.Location = New System.Drawing.Point(469, 234)
        Me.grdAlmacen.Margin = New System.Windows.Forms.Padding(4)
        Me.grdAlmacen.Name = "grdAlmacen"
        Me.grdAlmacen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdAlmacen.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.grdAlmacen.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.grdAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdAlmacen.Size = New System.Drawing.Size(353, 268)
        Me.grdAlmacen.TabIndex = 11
        '
        'txtCategoria
        '
        Me.txtCategoria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCategoria.Location = New System.Drawing.Point(127, 317)
        Me.txtCategoria.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(106, 23)
        Me.txtCategoria.TabIndex = 4
        Me.txtCategoria.ThousandsSeparator = True
        '
        'txtMarca
        '
        Me.txtMarca.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtMarca.Location = New System.Drawing.Point(128, 287)
        Me.txtMarca.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(106, 23)
        Me.txtMarca.TabIndex = 2
        Me.txtMarca.ThousandsSeparator = True
        '
        'txtPrecioReventa
        '
        Me.txtPrecioReventa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrecioReventa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioReventa.DecimalPlaces = 2
        Me.txtPrecioReventa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPrecioReventa.Location = New System.Drawing.Point(127, 433)
        Me.txtPrecioReventa.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtPrecioReventa.Name = "txtPrecioReventa"
        Me.txtPrecioReventa.Size = New System.Drawing.Size(171, 23)
        Me.txtPrecioReventa.TabIndex = 9
        Me.txtPrecioReventa.ThousandsSeparator = True
        '
        'txtPrecioCosto
        '
        Me.txtPrecioCosto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrecioCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioCosto.DecimalPlaces = 2
        Me.txtPrecioCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPrecioCosto.Location = New System.Drawing.Point(127, 404)
        Me.txtPrecioCosto.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txtPrecioCosto.Name = "txtPrecioCosto"
        Me.txtPrecioCosto.Size = New System.Drawing.Size(171, 23)
        Me.txtPrecioCosto.TabIndex = 8
        Me.txtPrecioCosto.ThousandsSeparator = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpFecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(242, 230)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(219, 20)
        Me.dtpFecha.TabIndex = 12
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
        Me.txtNombreCategoria.Location = New System.Drawing.Point(240, 317)
        Me.txtNombreCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreCategoria.Name = "txtNombreCategoria"
        Me.txtNombreCategoria.Size = New System.Drawing.Size(220, 22)
        Me.txtNombreCategoria.TabIndex = 5
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
        Me.txtNombreMarca.Location = New System.Drawing.Point(241, 287)
        Me.txtNombreMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreMarca.Name = "txtNombreMarca"
        Me.txtNombreMarca.Size = New System.Drawing.Size(220, 22)
        Me.txtNombreMarca.TabIndex = 3
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
        Me.txtDescripcion.Location = New System.Drawing.Point(127, 257)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(334, 22)
        Me.txtDescripcion.TabIndex = 1
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
        Me.txtCodigo.Location = New System.Drawing.Point(127, 228)
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
        Me.lblPrecioMinimo.Location = New System.Drawing.Point(20, 410)
        Me.lblPrecioMinimo.Name = "lblPrecioMinimo"
        Me.lblPrecioMinimo.Size = New System.Drawing.Size(92, 17)
        Me.lblPrecioMinimo.TabIndex = 20
        Me.lblPrecioMinimo.Text = "Precio Costo:"
        '
        'lblPrecioNormal
        '
        Me.lblPrecioNormal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPrecioNormal.AutoSize = True
        Me.lblPrecioNormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioNormal.ForeColor = System.Drawing.Color.Black
        Me.lblPrecioNormal.Location = New System.Drawing.Point(20, 439)
        Me.lblPrecioNormal.Name = "lblPrecioNormal"
        Me.lblPrecioNormal.Size = New System.Drawing.Size(109, 17)
        Me.lblPrecioNormal.TabIndex = 21
        Me.lblPrecioNormal.Text = "Precio Reventa:"
        '
        'lblCategoria
        '
        Me.lblCategoria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.ForeColor = System.Drawing.Color.Black
        Me.lblCategoria.Location = New System.Drawing.Point(20, 323)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(73, 17)
        Me.lblCategoria.TabIndex = 17
        Me.lblCategoria.Text = "Categoria:"
        '
        'lblMarca
        '
        Me.lblMarca.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.ForeColor = System.Drawing.Color.Black
        Me.lblMarca.Location = New System.Drawing.Point(20, 292)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(51, 17)
        Me.lblMarca.TabIndex = 16
        Me.lblMarca.Text = "Marca:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.Color.Black
        Me.lblDescripcion.Location = New System.Drawing.Point(20, 262)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(86, 17)
        Me.lblDescripcion.TabIndex = 15
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'lblCodigo
        '
        Me.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.Black
        Me.lblCodigo.Location = New System.Drawing.Point(20, 234)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblCodigo.TabIndex = 14
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
        Me.btnCancelar.Location = New System.Drawing.Point(426, 620)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(226, 54)
        Me.btnCancelar.TabIndex = 26
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
        Me.btnGuardar.Location = New System.Drawing.Point(190, 556)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(226, 54)
        Me.btnGuardar.TabIndex = 23
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltitulo
        '
        Me.lbltitulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.Black
        Me.lbltitulo.Location = New System.Drawing.Point(258, 50)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(327, 29)
        Me.lbltitulo.TabIndex = 13
        Me.lbltitulo.Text = "Registro de Almacen - Nuevo"
        '
        'IdAlmacenDataGridViewTextBoxColumn
        '
        Me.IdAlmacenDataGridViewTextBoxColumn.DataPropertyName = "Id_Almacen"
        Me.IdAlmacenDataGridViewTextBoxColumn.HeaderText = "Id_Almacen"
        Me.IdAlmacenDataGridViewTextBoxColumn.Name = "IdAlmacenDataGridViewTextBoxColumn"
        '
        'DescripciónDataGridViewTextBoxColumn
        '
        Me.DescripciónDataGridViewTextBoxColumn.DataPropertyName = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.Name = "DescripciónDataGridViewTextBoxColumn"
        '
        'AlmacenBindingSource2
        '
        Me.AlmacenBindingSource2.DataSource = GetType(Quimic_Express.Almacen)
        '
        'AlmacenBindingSource1
        '
        Me.AlmacenBindingSource1.DataSource = GetType(Quimic_Express.Almacen)
        '
        'AlmacenBindingSource
        '
        Me.AlmacenBindingSource.DataSource = GetType(Quimic_Express.Almacen)
        '
        'frmRegistroAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 730)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistroAlmacen"
        Me.Text = "frmRegistroAlmacen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtCantidadKilos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidadLitro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioLitro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioReventa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmacenBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmacenBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmacenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnNuevo As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnEliminar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents grdAlmacen As DataGridView
    Friend WithEvents txtCategoria As NumericUpDown
    Friend WithEvents txtMarca As NumericUpDown
    Friend WithEvents txtPrecioReventa As NumericUpDown
    Friend WithEvents txtPrecioCosto As NumericUpDown
    Friend WithEvents dtpFecha As DateTimePicker
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
    Friend WithEvents txtPrecioLitro As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCantidadKilos As NumericUpDown
    Friend WithEvents txtCantidadLitro As NumericUpDown
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlmacenBindingSource As BindingSource
    Friend WithEvents AlmacenBindingSource1 As BindingSource
    Friend WithEvents IdAlmacenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripciónDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlmacenBindingSource2 As System.Windows.Forms.BindingSource
End Class
