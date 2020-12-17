<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInformeInventario
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInformeInventario))
        Me.td_InventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsInventario = New Quimic_Express.dsInventario()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rptContenedor = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnSalir = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.td_InventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'td_InventarioBindingSource
        '
        Me.td_InventarioBindingSource.DataMember = "td_Inventario"
        Me.td_InventarioBindingSource.DataSource = Me.dsInventario
        '
        'dsInventario
        '
        Me.dsInventario.DataSetName = "dsInventario"
        Me.dsInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.rptContenedor)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 768)
        Me.Panel1.TabIndex = 1
        '
        'rptContenedor
        '
        Me.rptContenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rptContenedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        ReportDataSource1.Name = "cd_inventario"
        ReportDataSource1.Value = Me.td_InventarioBindingSource
        Me.rptContenedor.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptContenedor.LocalReport.ReportEmbeddedResource = "Quimic_Express.rptProductos.rdlc"
        Me.rptContenedor.Location = New System.Drawing.Point(10, 86)
        Me.rptContenedor.Name = "rptContenedor"
        Me.rptContenedor.ServerReport.BearerToken = Nothing
        Me.rptContenedor.Size = New System.Drawing.Size(1005, 615)
        Me.rptContenedor.TabIndex = 391
        '
        'btnSalir
        '
        Me.btnSalir.ActiveBorderThickness = 2
        Me.btnSalir.ActiveCornerRadius = 10
        Me.btnSalir.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnSalir.ActiveForecolor = System.Drawing.Color.White
        Me.btnSalir.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.White
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
        Me.btnSalir.Location = New System.Drawing.Point(868, 709)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(147, 54)
        Me.btnSalir.TabIndex = 390
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmInformeInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmInformeInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInformeInventario"
        Me.TopMost = True
        CType(Me.td_InventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents td_InventarioBindingSource As BindingSource
    Friend WithEvents dsInventario As dsInventario
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rptContenedor As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnSalir As Bunifu.Framework.UI.BunifuThinButton2
End Class
