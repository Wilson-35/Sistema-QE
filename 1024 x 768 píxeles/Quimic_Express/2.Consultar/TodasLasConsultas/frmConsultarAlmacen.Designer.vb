﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarAlmacen
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultarAlmacen))
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.btnCinventario = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnReporte = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.rdbCategoria = New System.Windows.Forms.RadioButton()
        Me.rdbMarca = New System.Windows.Forms.RadioButton()
        Me.rdbDescripcion = New System.Windows.Forms.RadioButton()
        Me.rdbCodigo = New System.Windows.Forms.RadioButton()
        Me.btnEliminar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnSalir = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnBuscar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtBuscar = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EfectoGrilla = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PanelContenedor.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.PanelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelContenedor.Controls.Add(Me.grilla)
        Me.PanelContenedor.Controls.Add(Me.btnCinventario)
        Me.PanelContenedor.Controls.Add(Me.btnReporte)
        Me.PanelContenedor.Controls.Add(Me.rdbCategoria)
        Me.PanelContenedor.Controls.Add(Me.rdbMarca)
        Me.PanelContenedor.Controls.Add(Me.rdbDescripcion)
        Me.PanelContenedor.Controls.Add(Me.rdbCodigo)
        Me.PanelContenedor.Controls.Add(Me.btnEliminar)
        Me.PanelContenedor.Controls.Add(Me.btnSalir)
        Me.PanelContenedor.Controls.Add(Me.btnBuscar)
        Me.PanelContenedor.Controls.Add(Me.txtBuscar)
        Me.PanelContenedor.Controls.Add(Me.Label1)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1066, 723)
        Me.PanelContenedor.TabIndex = 0
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grilla.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.grilla.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grilla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.grilla.ColumnHeadersHeight = 30
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grilla.DefaultCellStyle = DataGridViewCellStyle10
        Me.grilla.EnableHeadersVisualStyles = False
        Me.grilla.GridColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grilla.Location = New System.Drawing.Point(13, 119)
        Me.grilla.Margin = New System.Windows.Forms.Padding(4)
        Me.grilla.MultiSelect = False
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grilla.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        Me.grilla.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grilla.Size = New System.Drawing.Size(1039, 539)
        Me.grilla.TabIndex = 395
        '
        'btnCinventario
        '
        Me.btnCinventario.ActiveBorderThickness = 2
        Me.btnCinventario.ActiveCornerRadius = 10
        Me.btnCinventario.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnCinventario.ActiveForecolor = System.Drawing.Color.White
        Me.btnCinventario.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnCinventario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCinventario.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btnCinventario.BackgroundImage = CType(resources.GetObject("btnCinventario.BackgroundImage"), System.Drawing.Image)
        Me.btnCinventario.ButtonText = "Pasar a Inventario"
        Me.btnCinventario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCinventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCinventario.ForeColor = System.Drawing.Color.White
        Me.btnCinventario.IdleBorderThickness = 2
        Me.btnCinventario.IdleCornerRadius = 10
        Me.btnCinventario.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnCinventario.IdleForecolor = System.Drawing.Color.White
        Me.btnCinventario.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnCinventario.Location = New System.Drawing.Point(340, 667)
        Me.btnCinventario.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCinventario.Name = "btnCinventario"
        Me.btnCinventario.Size = New System.Drawing.Size(170, 54)
        Me.btnCinventario.TabIndex = 394
        Me.btnCinventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReporte
        '
        Me.btnReporte.ActiveBorderThickness = 2
        Me.btnReporte.ActiveCornerRadius = 10
        Me.btnReporte.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnReporte.ActiveForecolor = System.Drawing.Color.White
        Me.btnReporte.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnReporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btnReporte.BackgroundImage = CType(resources.GetObject("btnReporte.BackgroundImage"), System.Drawing.Image)
        Me.btnReporte.ButtonText = "Reporte"
        Me.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte.ForeColor = System.Drawing.Color.White
        Me.btnReporte.IdleBorderThickness = 2
        Me.btnReporte.IdleCornerRadius = 10
        Me.btnReporte.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnReporte.IdleForecolor = System.Drawing.Color.White
        Me.btnReporte.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnReporte.Location = New System.Drawing.Point(520, 667)
        Me.btnReporte.Margin = New System.Windows.Forms.Padding(5)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(170, 54)
        Me.btnReporte.TabIndex = 391
        Me.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rdbCategoria
        '
        Me.rdbCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rdbCategoria.AutoSize = True
        Me.rdbCategoria.Location = New System.Drawing.Point(547, 95)
        Me.rdbCategoria.Name = "rdbCategoria"
        Me.rdbCategoria.Size = New System.Drawing.Size(70, 17)
        Me.rdbCategoria.TabIndex = 390
        Me.rdbCategoria.Text = "Categoria"
        Me.rdbCategoria.UseVisualStyleBackColor = True
        '
        'rdbMarca
        '
        Me.rdbMarca.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rdbMarca.AutoSize = True
        Me.rdbMarca.Location = New System.Drawing.Point(486, 95)
        Me.rdbMarca.Name = "rdbMarca"
        Me.rdbMarca.Size = New System.Drawing.Size(55, 17)
        Me.rdbMarca.TabIndex = 389
        Me.rdbMarca.Text = "Marca"
        Me.rdbMarca.UseVisualStyleBackColor = True
        '
        'rdbDescripcion
        '
        Me.rdbDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rdbDescripcion.AutoSize = True
        Me.rdbDescripcion.Location = New System.Drawing.Point(399, 95)
        Me.rdbDescripcion.Name = "rdbDescripcion"
        Me.rdbDescripcion.Size = New System.Drawing.Size(81, 17)
        Me.rdbDescripcion.TabIndex = 388
        Me.rdbDescripcion.Text = "Descripción"
        Me.rdbDescripcion.UseVisualStyleBackColor = True
        '
        'rdbCodigo
        '
        Me.rdbCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rdbCodigo.AutoSize = True
        Me.rdbCodigo.Checked = True
        Me.rdbCodigo.Location = New System.Drawing.Point(335, 95)
        Me.rdbCodigo.Name = "rdbCodigo"
        Me.rdbCodigo.Size = New System.Drawing.Size(58, 17)
        Me.rdbCodigo.TabIndex = 387
        Me.rdbCodigo.TabStop = True
        Me.rdbCodigo.Text = "Codigo"
        Me.rdbCodigo.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.ActiveBorderThickness = 2
        Me.btnEliminar.ActiveCornerRadius = 10
        Me.btnEliminar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnEliminar.ActiveForecolor = System.Drawing.Color.White
        Me.btnEliminar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminar.ButtonText = "Eliminar"
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.IdleBorderThickness = 2
        Me.btnEliminar.IdleCornerRadius = 10
        Me.btnEliminar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnEliminar.IdleForecolor = System.Drawing.Color.White
        Me.btnEliminar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnEliminar.Location = New System.Drawing.Point(700, 667)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(170, 54)
        Me.btnEliminar.TabIndex = 384
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSalir
        '
        Me.btnSalir.ActiveBorderThickness = 2
        Me.btnSalir.ActiveCornerRadius = 10
        Me.btnSalir.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnSalir.ActiveForecolor = System.Drawing.Color.White
        Me.btnSalir.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), System.Drawing.Image)
        Me.btnSalir.ButtonText = "Sailr"
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.IdleBorderThickness = 2
        Me.btnSalir.IdleCornerRadius = 10
        Me.btnSalir.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnSalir.IdleForecolor = System.Drawing.Color.White
        Me.btnSalir.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(880, 667)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(170, 54)
        Me.btnSalir.TabIndex = 383
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBuscar
        '
        Me.btnBuscar.ActiveBorderThickness = 2
        Me.btnBuscar.ActiveCornerRadius = 10
        Me.btnBuscar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnBuscar.ActiveForecolor = System.Drawing.Color.White
        Me.btnBuscar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top
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
        Me.btnBuscar.Location = New System.Drawing.Point(679, 42)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(226, 54)
        Me.btnBuscar.TabIndex = 362
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBuscar.BackColor = System.Drawing.Color.White
        Me.txtBuscar.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtBuscar.BorderColorIdle = System.Drawing.Color.White
        Me.txtBuscar.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtBuscar.BorderThickness = 2
        Me.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.txtBuscar.isPassword = False
        Me.txtBuscar.Location = New System.Drawing.Point(242, 53)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(427, 34)
        Me.txtBuscar.TabIndex = 352
        Me.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(440, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 29)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "Consutar Almacen"
        '
        'EfectoGrilla
        '
        Me.EfectoGrilla.ElipseRadius = 20
        Me.EfectoGrilla.TargetControl = Me.grilla
        '
        'frmConsultarAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 723)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConsultarAlmacen"
        Me.Text = "frmConsultarAlmacen"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelContenedor.PerformLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents btnEliminar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnSalir As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnBuscar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtBuscar As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents rdbCodigo As RadioButton
    Friend WithEvents rdbCategoria As RadioButton
    Friend WithEvents rdbMarca As RadioButton
    Friend WithEvents rdbDescripcion As RadioButton
    Friend WithEvents btnReporte As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnCinventario As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents grilla As DataGridView
    Friend WithEvents EfectoGrilla As Bunifu.Framework.UI.BunifuElipse
End Class
