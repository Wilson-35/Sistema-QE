<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroCategoria
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistroCategoria))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.btnNuevo = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnEliminar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.grdCategoria = New System.Windows.Forms.DataGridView()
        Me.IdCategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtDescripcion = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblCodigoBarra = New System.Windows.Forms.Label()
        Me.txtCodigo = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.btnCancelar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnGuardar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelContenedor.SuspendLayout()
        CType(Me.grdCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.PanelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelContenedor.Controls.Add(Me.btnNuevo)
        Me.PanelContenedor.Controls.Add(Me.btnEliminar)
        Me.PanelContenedor.Controls.Add(Me.grdCategoria)
        Me.PanelContenedor.Controls.Add(Me.dtpFecha)
        Me.PanelContenedor.Controls.Add(Me.txtDescripcion)
        Me.PanelContenedor.Controls.Add(Me.lblCodigoBarra)
        Me.PanelContenedor.Controls.Add(Me.txtCodigo)
        Me.PanelContenedor.Controls.Add(Me.lblCodigo)
        Me.PanelContenedor.Controls.Add(Me.btnCancelar)
        Me.PanelContenedor.Controls.Add(Me.btnGuardar)
        Me.PanelContenedor.Controls.Add(Me.lbltitulo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1066, 723)
        Me.PanelContenedor.TabIndex = 0
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
        Me.btnNuevo.Location = New System.Drawing.Point(301, 654)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(5)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(226, 54)
        Me.btnNuevo.TabIndex = 8
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
        Me.btnEliminar.Location = New System.Drawing.Point(537, 654)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(226, 54)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grdCategoria
        '
        Me.grdCategoria.AllowUserToAddRows = False
        Me.grdCategoria.AllowUserToDeleteRows = False
        Me.grdCategoria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grdCategoria.AutoGenerateColumns = False
        Me.grdCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdCategoria.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.grdCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdCategoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdCategoria.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdCategoria.ColumnHeadersHeight = 30
        Me.grdCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdCategoria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCategoriaDataGridViewTextBoxColumn, Me.DescripciónDataGridViewTextBoxColumn})
        Me.grdCategoria.DataSource = Me.CategoriaBindingSource1
        Me.grdCategoria.EnableHeadersVisualStyles = False
        Me.grdCategoria.GridColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdCategoria.Location = New System.Drawing.Point(593, 252)
        Me.grdCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.grdCategoria.Name = "grdCategoria"
        Me.grdCategoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdCategoria.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.grdCategoria.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.grdCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdCategoria.Size = New System.Drawing.Size(413, 201)
        Me.grdCategoria.TabIndex = 3
        '
        'IdCategoriaDataGridViewTextBoxColumn
        '
        Me.IdCategoriaDataGridViewTextBoxColumn.DataPropertyName = "Id_Categoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.HeaderText = "Id_Categoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.Name = "IdCategoriaDataGridViewTextBoxColumn"
        '
        'DescripciónDataGridViewTextBoxColumn
        '
        Me.DescripciónDataGridViewTextBoxColumn.DataPropertyName = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.Name = "DescripciónDataGridViewTextBoxColumn"
        '
        'CategoriaBindingSource1
        '
        Me.CategoriaBindingSource1.DataSource = GetType(Quimic_Express.Categoria)
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpFecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(365, 258)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(219, 20)
        Me.dtpFecha.TabIndex = 2
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
        Me.txtDescripcion.Location = New System.Drawing.Point(251, 298)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(334, 30)
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblCodigoBarra
        '
        Me.lblCodigoBarra.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCodigoBarra.AutoSize = True
        Me.lblCodigoBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoBarra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.lblCodigoBarra.Location = New System.Drawing.Point(59, 307)
        Me.lblCodigoBarra.Name = "lblCodigoBarra"
        Me.lblCodigoBarra.Size = New System.Drawing.Size(96, 20)
        Me.lblCodigoBarra.TabIndex = 5
        Me.lblCodigoBarra.Text = "Descripción:"
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
        Me.txtCodigo.Location = New System.Drawing.Point(251, 252)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(106, 30)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.Text = "0"
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblCodigo
        '
        Me.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.lblCodigo.Location = New System.Drawing.Point(59, 261)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(59, 20)
        Me.lblCodigo.TabIndex = 4
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
        Me.btnCancelar.Location = New System.Drawing.Point(773, 654)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(226, 54)
        Me.btnCancelar.TabIndex = 10
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
        Me.btnGuardar.Location = New System.Drawing.Point(65, 654)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(226, 54)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltitulo
        '
        Me.lbltitulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.lbltitulo.Location = New System.Drawing.Point(344, 13)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(339, 29)
        Me.lbltitulo.TabIndex = 6
        Me.lbltitulo.Text = "Registro de Categoria - Nuevo"
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataSource = GetType(Quimic_Express.Categoria)
        '
        'frmRegistroCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 723)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistroCategoria"
        Me.Text = "frmRegistroCategoria"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelContenedor.PerformLayout()
        CType(Me.grdCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents btnNuevo As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnEliminar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents grdCategoria As DataGridView
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtDescripcion As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblCodigoBarra As Label
    Friend WithEvents txtCodigo As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents btnCancelar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnGuardar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lbltitulo As Label
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoriaBindingSource As BindingSource
    Friend WithEvents IdCategoriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripciónDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoriaBindingSource1 As System.Windows.Forms.BindingSource
End Class
