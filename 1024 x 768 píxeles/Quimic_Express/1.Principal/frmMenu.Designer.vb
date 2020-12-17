<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
        Dim Animation9 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Dim Animation10 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.lblusuario1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Minimizar = New System.Windows.Forms.PictureBox()
        Me.Cerrar = New System.Windows.Forms.PictureBox()
        Me.Sidebar = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnPresupuesto = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnCaja = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnCotizacion = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnVenta = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnOperaciones = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LineaSidebar = New Bunifu.Framework.UI.BunifuSeparator()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.btnRegistros = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnConsultas = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.AnimacionSidebar = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.SidebarWrapper = New System.Windows.Forms.Panel()
        Me.MenuTop = New System.Windows.Forms.Panel()
        Me.MenuSidebar = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.AnimacionSidebarBack = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.HorayFecha = New System.Windows.Forms.Timer(Me.components)
        Me.CurvaSidebar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        CType(Me.Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sidebar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SidebarWrapper.SuspendLayout()
        Me.MenuTop.SuspendLayout()
        CType(Me.MenuSidebar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblusuario1
        '
        Me.lblusuario1.AutoSize = True
        Me.lblusuario1.BackColor = System.Drawing.Color.Black
        Me.AnimacionSidebar.SetDecoration(Me.lblusuario1, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.lblusuario1, BunifuAnimatorNS.DecorationType.None)
        Me.lblusuario1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusuario1.ForeColor = System.Drawing.Color.White
        Me.lblusuario1.Location = New System.Drawing.Point(142, 9)
        Me.lblusuario1.Name = "lblusuario1"
        Me.lblusuario1.Size = New System.Drawing.Size(40, 20)
        Me.lblusuario1.TabIndex = 54
        Me.lblusuario1.Text = "user"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.AnimacionSidebar.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(41, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 20)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Bienvenido :"
        '
        'Minimizar
        '
        Me.Minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionSidebar.SetDecoration(Me.Minimizar, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.Minimizar, BunifuAnimatorNS.DecorationType.None)
        Me.Minimizar.Image = CType(resources.GetObject("Minimizar.Image"), System.Drawing.Image)
        Me.Minimizar.Location = New System.Drawing.Point(966, 9)
        Me.Minimizar.Name = "Minimizar"
        Me.Minimizar.Size = New System.Drawing.Size(20, 20)
        Me.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Minimizar.TabIndex = 39
        Me.Minimizar.TabStop = False
        '
        'Cerrar
        '
        Me.Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionSidebar.SetDecoration(Me.Cerrar, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.Cerrar, BunifuAnimatorNS.DecorationType.None)
        Me.Cerrar.Image = CType(resources.GetObject("Cerrar.Image"), System.Drawing.Image)
        Me.Cerrar.Location = New System.Drawing.Point(992, 9)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(20, 20)
        Me.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Cerrar.TabIndex = 2
        Me.Cerrar.TabStop = False
        '
        'Sidebar
        '
        Me.Sidebar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Sidebar.BackgroundImage = CType(resources.GetObject("Sidebar.BackgroundImage"), System.Drawing.Image)
        Me.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Sidebar.Controls.Add(Me.btnPresupuesto)
        Me.Sidebar.Controls.Add(Me.btnCaja)
        Me.Sidebar.Controls.Add(Me.btnCotizacion)
        Me.Sidebar.Controls.Add(Me.btnVenta)
        Me.Sidebar.Controls.Add(Me.btnOperaciones)
        Me.Sidebar.Controls.Add(Me.Label1)
        Me.Sidebar.Controls.Add(Me.PictureBox1)
        Me.Sidebar.Controls.Add(Me.LineaSidebar)
        Me.Sidebar.Controls.Add(Me.lblFecha)
        Me.Sidebar.Controls.Add(Me.lblHora)
        Me.Sidebar.Controls.Add(Me.btnRegistros)
        Me.Sidebar.Controls.Add(Me.btnConsultas)
        Me.AnimacionSidebarBack.SetDecoration(Me.Sidebar, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me.Sidebar, BunifuAnimatorNS.DecorationType.None)
        Me.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Sidebar.GradientBottomRight = System.Drawing.Color.White
        Me.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Sidebar.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Sidebar.Location = New System.Drawing.Point(6, 3)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.Quality = 10
        Me.Sidebar.Size = New System.Drawing.Size(176, 724)
        Me.Sidebar.TabIndex = 0
        '
        'btnPresupuesto
        '
        Me.btnPresupuesto.Activecolor = System.Drawing.Color.Transparent
        Me.btnPresupuesto.BackColor = System.Drawing.Color.Transparent
        Me.btnPresupuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPresupuesto.BorderRadius = 0
        Me.btnPresupuesto.ButtonText = "PRESUPUESTO"
        Me.btnPresupuesto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionSidebarBack.SetDecoration(Me.btnPresupuesto, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me.btnPresupuesto, BunifuAnimatorNS.DecorationType.None)
        Me.btnPresupuesto.DisabledColor = System.Drawing.Color.Gray
        Me.btnPresupuesto.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPresupuesto.Iconimage = CType(resources.GetObject("btnPresupuesto.Iconimage"), System.Drawing.Image)
        Me.btnPresupuesto.Iconimage_right = Nothing
        Me.btnPresupuesto.Iconimage_right_Selected = Nothing
        Me.btnPresupuesto.Iconimage_Selected = Nothing
        Me.btnPresupuesto.IconMarginLeft = 20
        Me.btnPresupuesto.IconMarginRight = 0
        Me.btnPresupuesto.IconRightVisible = True
        Me.btnPresupuesto.IconRightZoom = 0R
        Me.btnPresupuesto.IconVisible = True
        Me.btnPresupuesto.IconZoom = 50.0R
        Me.btnPresupuesto.IsTab = False
        Me.btnPresupuesto.Location = New System.Drawing.Point(0, 338)
        Me.btnPresupuesto.Name = "btnPresupuesto"
        Me.btnPresupuesto.Normalcolor = System.Drawing.Color.Transparent
        Me.btnPresupuesto.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnPresupuesto.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPresupuesto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnPresupuesto.selected = False
        Me.btnPresupuesto.Size = New System.Drawing.Size(169, 51)
        Me.btnPresupuesto.TabIndex = 67
        Me.btnPresupuesto.Text = "PRESUPUESTO"
        Me.btnPresupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPresupuesto.Textcolor = System.Drawing.Color.White
        Me.btnPresupuesto.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        '
        'btnCaja
        '
        Me.btnCaja.Activecolor = System.Drawing.Color.Transparent
        Me.btnCaja.BackColor = System.Drawing.Color.Transparent
        Me.btnCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCaja.BorderRadius = 0
        Me.btnCaja.ButtonText = "                     CAJA"
        Me.btnCaja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionSidebarBack.SetDecoration(Me.btnCaja, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me.btnCaja, BunifuAnimatorNS.DecorationType.None)
        Me.btnCaja.DisabledColor = System.Drawing.Color.Gray
        Me.btnCaja.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCaja.Iconimage = CType(resources.GetObject("btnCaja.Iconimage"), System.Drawing.Image)
        Me.btnCaja.Iconimage_right = Nothing
        Me.btnCaja.Iconimage_right_Selected = Nothing
        Me.btnCaja.Iconimage_Selected = Nothing
        Me.btnCaja.IconMarginLeft = 20
        Me.btnCaja.IconMarginRight = 0
        Me.btnCaja.IconRightVisible = True
        Me.btnCaja.IconRightZoom = 0R
        Me.btnCaja.IconVisible = True
        Me.btnCaja.IconZoom = 50.0R
        Me.btnCaja.IsTab = False
        Me.btnCaja.Location = New System.Drawing.Point(0, 395)
        Me.btnCaja.Name = "btnCaja"
        Me.btnCaja.Normalcolor = System.Drawing.Color.Transparent
        Me.btnCaja.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnCaja.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCaja.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnCaja.selected = False
        Me.btnCaja.Size = New System.Drawing.Size(169, 51)
        Me.btnCaja.TabIndex = 66
        Me.btnCaja.Text = "                     CAJA"
        Me.btnCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCaja.Textcolor = System.Drawing.Color.White
        Me.btnCaja.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        '
        'btnCotizacion
        '
        Me.btnCotizacion.Activecolor = System.Drawing.Color.Transparent
        Me.btnCotizacion.BackColor = System.Drawing.Color.Transparent
        Me.btnCotizacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCotizacion.BorderRadius = 0
        Me.btnCotizacion.ButtonText = "       COTIZACIÓN"
        Me.btnCotizacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionSidebarBack.SetDecoration(Me.btnCotizacion, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me.btnCotizacion, BunifuAnimatorNS.DecorationType.None)
        Me.btnCotizacion.DisabledColor = System.Drawing.Color.Gray
        Me.btnCotizacion.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCotizacion.Iconimage = CType(resources.GetObject("btnCotizacion.Iconimage"), System.Drawing.Image)
        Me.btnCotizacion.Iconimage_right = Nothing
        Me.btnCotizacion.Iconimage_right_Selected = Nothing
        Me.btnCotizacion.Iconimage_Selected = Nothing
        Me.btnCotizacion.IconMarginLeft = 20
        Me.btnCotizacion.IconMarginRight = 0
        Me.btnCotizacion.IconRightVisible = True
        Me.btnCotizacion.IconRightZoom = 0R
        Me.btnCotizacion.IconVisible = True
        Me.btnCotizacion.IconZoom = 50.0R
        Me.btnCotizacion.IsTab = False
        Me.btnCotizacion.Location = New System.Drawing.Point(0, 224)
        Me.btnCotizacion.Name = "btnCotizacion"
        Me.btnCotizacion.Normalcolor = System.Drawing.Color.Transparent
        Me.btnCotizacion.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnCotizacion.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCotizacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnCotizacion.selected = False
        Me.btnCotizacion.Size = New System.Drawing.Size(169, 51)
        Me.btnCotizacion.TabIndex = 65
        Me.btnCotizacion.Text = "       COTIZACIÓN"
        Me.btnCotizacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCotizacion.Textcolor = System.Drawing.Color.White
        Me.btnCotizacion.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        '
        'btnVenta
        '
        Me.btnVenta.Activecolor = System.Drawing.Color.Transparent
        Me.btnVenta.BackColor = System.Drawing.Color.Transparent
        Me.btnVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVenta.BorderRadius = 0
        Me.btnVenta.ButtonText = "                  VENTA"
        Me.btnVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionSidebarBack.SetDecoration(Me.btnVenta, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me.btnVenta, BunifuAnimatorNS.DecorationType.None)
        Me.btnVenta.DisabledColor = System.Drawing.Color.Gray
        Me.btnVenta.Iconcolor = System.Drawing.Color.Transparent
        Me.btnVenta.Iconimage = CType(resources.GetObject("btnVenta.Iconimage"), System.Drawing.Image)
        Me.btnVenta.Iconimage_right = Nothing
        Me.btnVenta.Iconimage_right_Selected = Nothing
        Me.btnVenta.Iconimage_Selected = Nothing
        Me.btnVenta.IconMarginLeft = 20
        Me.btnVenta.IconMarginRight = 0
        Me.btnVenta.IconRightVisible = True
        Me.btnVenta.IconRightZoom = 0R
        Me.btnVenta.IconVisible = True
        Me.btnVenta.IconZoom = 60.0R
        Me.btnVenta.IsTab = False
        Me.btnVenta.Location = New System.Drawing.Point(-3, 281)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Normalcolor = System.Drawing.Color.Transparent
        Me.btnVenta.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnVenta.OnHoverTextColor = System.Drawing.Color.White
        Me.btnVenta.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnVenta.selected = False
        Me.btnVenta.Size = New System.Drawing.Size(169, 51)
        Me.btnVenta.TabIndex = 64
        Me.btnVenta.Text = "                  VENTA"
        Me.btnVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVenta.Textcolor = System.Drawing.Color.White
        Me.btnVenta.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        '
        'btnOperaciones
        '
        Me.btnOperaciones.Activecolor = System.Drawing.Color.Transparent
        Me.btnOperaciones.BackColor = System.Drawing.Color.Transparent
        Me.btnOperaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOperaciones.BorderRadius = 0
        Me.btnOperaciones.ButtonText = "   OPERACIONES"
        Me.btnOperaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionSidebarBack.SetDecoration(Me.btnOperaciones, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me.btnOperaciones, BunifuAnimatorNS.DecorationType.None)
        Me.btnOperaciones.DisabledColor = System.Drawing.Color.Gray
        Me.btnOperaciones.Iconcolor = System.Drawing.Color.Transparent
        Me.btnOperaciones.Iconimage = CType(resources.GetObject("btnOperaciones.Iconimage"), System.Drawing.Image)
        Me.btnOperaciones.Iconimage_right = Nothing
        Me.btnOperaciones.Iconimage_right_Selected = Nothing
        Me.btnOperaciones.Iconimage_Selected = Nothing
        Me.btnOperaciones.IconMarginLeft = 20
        Me.btnOperaciones.IconMarginRight = 0
        Me.btnOperaciones.IconRightVisible = True
        Me.btnOperaciones.IconRightZoom = 0R
        Me.btnOperaciones.IconVisible = True
        Me.btnOperaciones.IconZoom = 60.0R
        Me.btnOperaciones.IsTab = False
        Me.btnOperaciones.Location = New System.Drawing.Point(0, 167)
        Me.btnOperaciones.Name = "btnOperaciones"
        Me.btnOperaciones.Normalcolor = System.Drawing.Color.Transparent
        Me.btnOperaciones.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnOperaciones.OnHoverTextColor = System.Drawing.Color.White
        Me.btnOperaciones.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnOperaciones.selected = False
        Me.btnOperaciones.Size = New System.Drawing.Size(169, 51)
        Me.btnOperaciones.TabIndex = 63
        Me.btnOperaciones.Text = "   OPERACIONES"
        Me.btnOperaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOperaciones.Textcolor = System.Drawing.Color.White
        Me.btnOperaciones.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionSidebar.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 17)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "QUIMIC EXPRESS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionSidebar.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 33)
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        '
        'LineaSidebar
        '
        Me.LineaSidebar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineaSidebar.BackColor = System.Drawing.Color.Transparent
        Me.AnimacionSidebarBack.SetDecoration(Me.LineaSidebar, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me.LineaSidebar, BunifuAnimatorNS.DecorationType.None)
        Me.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.LineaSidebar.LineThickness = 1
        Me.LineaSidebar.Location = New System.Drawing.Point(9, 37)
        Me.LineaSidebar.Name = "LineaSidebar"
        Me.LineaSidebar.Size = New System.Drawing.Size(158, 10)
        Me.LineaSidebar.TabIndex = 56
        Me.LineaSidebar.Transparency = 255
        Me.LineaSidebar.Vertical = False
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.AnimacionSidebar.SetDecoration(Me.lblFecha, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.lblFecha, BunifuAnimatorNS.DecorationType.None)
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.Black
        Me.lblFecha.Location = New System.Drawing.Point(33, 693)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(46, 16)
        Me.lblFecha.TabIndex = 49
        Me.lblFecha.Text = "Fecha"
        '
        'lblHora
        '
        Me.lblHora.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.Color.Transparent
        Me.AnimacionSidebar.SetDecoration(Me.lblHora, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.lblHora, BunifuAnimatorNS.DecorationType.None)
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.Black
        Me.lblHora.Location = New System.Drawing.Point(43, 659)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(58, 25)
        Me.lblHora.TabIndex = 48
        Me.lblHora.Text = "Hora"
        '
        'btnRegistros
        '
        Me.btnRegistros.Activecolor = System.Drawing.Color.Transparent
        Me.btnRegistros.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegistros.BorderRadius = 0
        Me.btnRegistros.ButtonText = "        REGISTROS"
        Me.btnRegistros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionSidebarBack.SetDecoration(Me.btnRegistros, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me.btnRegistros, BunifuAnimatorNS.DecorationType.None)
        Me.btnRegistros.DisabledColor = System.Drawing.Color.Gray
        Me.btnRegistros.Iconcolor = System.Drawing.Color.Transparent
        Me.btnRegistros.Iconimage = CType(resources.GetObject("btnRegistros.Iconimage"), System.Drawing.Image)
        Me.btnRegistros.Iconimage_right = Nothing
        Me.btnRegistros.Iconimage_right_Selected = Nothing
        Me.btnRegistros.Iconimage_Selected = Nothing
        Me.btnRegistros.IconMarginLeft = 20
        Me.btnRegistros.IconMarginRight = 0
        Me.btnRegistros.IconRightVisible = True
        Me.btnRegistros.IconRightZoom = 0R
        Me.btnRegistros.IconVisible = True
        Me.btnRegistros.IconZoom = 60.0R
        Me.btnRegistros.IsTab = False
        Me.btnRegistros.Location = New System.Drawing.Point(0, 110)
        Me.btnRegistros.Name = "btnRegistros"
        Me.btnRegistros.Normalcolor = System.Drawing.Color.Transparent
        Me.btnRegistros.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnRegistros.OnHoverTextColor = System.Drawing.Color.White
        Me.btnRegistros.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnRegistros.selected = False
        Me.btnRegistros.Size = New System.Drawing.Size(169, 51)
        Me.btnRegistros.TabIndex = 17
        Me.btnRegistros.Text = "        REGISTROS"
        Me.btnRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistros.Textcolor = System.Drawing.Color.White
        Me.btnRegistros.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        '
        'btnConsultas
        '
        Me.btnConsultas.Activecolor = System.Drawing.Color.Transparent
        Me.btnConsultas.BackColor = System.Drawing.Color.Transparent
        Me.btnConsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConsultas.BorderRadius = 0
        Me.btnConsultas.ButtonText = "      CONSULTAS"
        Me.btnConsultas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionSidebarBack.SetDecoration(Me.btnConsultas, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me.btnConsultas, BunifuAnimatorNS.DecorationType.None)
        Me.btnConsultas.DisabledColor = System.Drawing.Color.Gray
        Me.btnConsultas.Iconcolor = System.Drawing.Color.Transparent
        Me.btnConsultas.Iconimage = CType(resources.GetObject("btnConsultas.Iconimage"), System.Drawing.Image)
        Me.btnConsultas.Iconimage_right = Nothing
        Me.btnConsultas.Iconimage_right_Selected = Nothing
        Me.btnConsultas.Iconimage_Selected = Nothing
        Me.btnConsultas.IconMarginLeft = 20
        Me.btnConsultas.IconMarginRight = 0
        Me.btnConsultas.IconRightVisible = True
        Me.btnConsultas.IconRightZoom = 0R
        Me.btnConsultas.IconVisible = True
        Me.btnConsultas.IconZoom = 50.0R
        Me.btnConsultas.IsTab = False
        Me.btnConsultas.Location = New System.Drawing.Point(0, 53)
        Me.btnConsultas.Name = "btnConsultas"
        Me.btnConsultas.Normalcolor = System.Drawing.Color.Transparent
        Me.btnConsultas.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnConsultas.OnHoverTextColor = System.Drawing.Color.White
        Me.btnConsultas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnConsultas.selected = False
        Me.btnConsultas.Size = New System.Drawing.Size(169, 51)
        Me.btnConsultas.TabIndex = 16
        Me.btnConsultas.Text = "      CONSULTAS"
        Me.btnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultas.Textcolor = System.Drawing.Color.White
        Me.btnConsultas.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        '
        'AnimacionSidebar
        '
        Me.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Particles
        Me.AnimacionSidebar.Cursor = Nothing
        Animation9.AnimateOnlyDifferences = True
        Animation9.BlindCoeff = CType(resources.GetObject("Animation9.BlindCoeff"), System.Drawing.PointF)
        Animation9.LeafCoeff = 0!
        Animation9.MaxTime = 1.0!
        Animation9.MinTime = 0!
        Animation9.MosaicCoeff = CType(resources.GetObject("Animation9.MosaicCoeff"), System.Drawing.PointF)
        Animation9.MosaicShift = CType(resources.GetObject("Animation9.MosaicShift"), System.Drawing.PointF)
        Animation9.MosaicSize = 1
        Animation9.Padding = New System.Windows.Forms.Padding(100, 50, 100, 150)
        Animation9.RotateCoeff = 0!
        Animation9.RotateLimit = 0!
        Animation9.ScaleCoeff = CType(resources.GetObject("Animation9.ScaleCoeff"), System.Drawing.PointF)
        Animation9.SlideCoeff = CType(resources.GetObject("Animation9.SlideCoeff"), System.Drawing.PointF)
        Animation9.TimeCoeff = 2.0!
        Animation9.TransparencyCoeff = 0!
        Me.AnimacionSidebar.DefaultAnimation = Animation9
        Me.AnimacionSidebar.Interval = 80
        Me.AnimacionSidebar.TimeStep = 0.05!
        '
        'SidebarWrapper
        '
        Me.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.SidebarWrapper.Controls.Add(Me.Sidebar)
        Me.AnimacionSidebarBack.SetDecoration(Me.SidebarWrapper, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me.SidebarWrapper, BunifuAnimatorNS.DecorationType.None)
        Me.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left
        Me.SidebarWrapper.Location = New System.Drawing.Point(0, 38)
        Me.SidebarWrapper.Name = "SidebarWrapper"
        Me.SidebarWrapper.Size = New System.Drawing.Size(182, 730)
        Me.SidebarWrapper.TabIndex = 5
        '
        'MenuTop
        '
        Me.MenuTop.BackColor = System.Drawing.Color.Black
        Me.MenuTop.Controls.Add(Me.Minimizar)
        Me.MenuTop.Controls.Add(Me.Cerrar)
        Me.MenuTop.Controls.Add(Me.MenuSidebar)
        Me.MenuTop.Controls.Add(Me.Label4)
        Me.MenuTop.Controls.Add(Me.lblusuario1)
        Me.AnimacionSidebarBack.SetDecoration(Me.MenuTop, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me.MenuTop, BunifuAnimatorNS.DecorationType.None)
        Me.MenuTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuTop.Location = New System.Drawing.Point(0, 0)
        Me.MenuTop.Name = "MenuTop"
        Me.MenuTop.Size = New System.Drawing.Size(1024, 38)
        Me.MenuTop.TabIndex = 4
        '
        'MenuSidebar
        '
        Me.MenuSidebar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionSidebar.SetDecoration(Me.MenuSidebar, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me.MenuSidebar, BunifuAnimatorNS.DecorationType.None)
        Me.MenuSidebar.Image = CType(resources.GetObject("MenuSidebar.Image"), System.Drawing.Image)
        Me.MenuSidebar.Location = New System.Drawing.Point(15, 9)
        Me.MenuSidebar.Name = "MenuSidebar"
        Me.MenuSidebar.Size = New System.Drawing.Size(20, 20)
        Me.MenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MenuSidebar.TabIndex = 0
        Me.MenuSidebar.TabStop = False
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.AnimacionSidebarBack.SetDecoration(Me.PanelContenedor, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebar.SetDecoration(Me.PanelContenedor, BunifuAnimatorNS.DecorationType.None)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(182, 38)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(842, 730)
        Me.PanelContenedor.TabIndex = 6
        '
        'AnimacionSidebarBack
        '
        Me.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.AnimacionSidebarBack.Cursor = Nothing
        Animation10.AnimateOnlyDifferences = True
        Animation10.BlindCoeff = CType(resources.GetObject("Animation10.BlindCoeff"), System.Drawing.PointF)
        Animation10.LeafCoeff = 0!
        Animation10.MaxTime = 1.0!
        Animation10.MinTime = 0!
        Animation10.MosaicCoeff = CType(resources.GetObject("Animation10.MosaicCoeff"), System.Drawing.PointF)
        Animation10.MosaicShift = CType(resources.GetObject("Animation10.MosaicShift"), System.Drawing.PointF)
        Animation10.MosaicSize = 0
        Animation10.Padding = New System.Windows.Forms.Padding(0)
        Animation10.RotateCoeff = 0!
        Animation10.RotateLimit = 0!
        Animation10.ScaleCoeff = CType(resources.GetObject("Animation10.ScaleCoeff"), System.Drawing.PointF)
        Animation10.SlideCoeff = CType(resources.GetObject("Animation10.SlideCoeff"), System.Drawing.PointF)
        Animation10.TimeCoeff = 0!
        Animation10.TransparencyCoeff = 0!
        Me.AnimacionSidebarBack.DefaultAnimation = Animation10
        '
        'HorayFecha
        '
        Me.HorayFecha.Enabled = True
        '
        'CurvaSidebar
        '
        Me.CurvaSidebar.ElipseRadius = 10
        Me.CurvaSidebar.TargetControl = Me.Sidebar
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.SidebarWrapper)
        Me.Controls.Add(Me.MenuTop)
        Me.AnimacionSidebar.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionSidebarBack.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMenu"
        Me.Text = "frmMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Sidebar.ResumeLayout(False)
        Me.Sidebar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SidebarWrapper.ResumeLayout(False)
        Me.MenuTop.ResumeLayout(False)
        Me.MenuTop.PerformLayout()
        CType(Me.MenuSidebar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AnimacionSidebarBack As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents AnimacionSidebar As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents lblusuario1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents HorayFecha As Timer
    Friend WithEvents Minimizar As PictureBox
    Friend WithEvents Cerrar As PictureBox
    Friend WithEvents Sidebar As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents LineaSidebar As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
    Private WithEvents btnRegistros As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btnConsultas As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents SidebarWrapper As Panel
    Friend WithEvents MenuTop As Panel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents btnOperaciones As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btnVenta As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btnCotizacion As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btnCaja As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btnPresupuesto As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MenuSidebar As PictureBox
    Friend WithEvents CurvaSidebar As Bunifu.Framework.UI.BunifuElipse
End Class
