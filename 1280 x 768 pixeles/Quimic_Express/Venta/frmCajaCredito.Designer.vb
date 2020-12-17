<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCajaCredito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCajaCredito))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCgs = New System.Windows.Forms.NumericUpDown()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtCus = New System.Windows.Forms.NumericUpDown()
        Me.txtCps = New System.Windows.Forms.NumericUpDown()
        Me.txtCrs = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtTotalus = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TxtTotalps = New System.Windows.Forms.NumericUpDown()
        Me.TxtTotalrs = New System.Windows.Forms.NumericUpDown()
        Me.TxtTotal = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtCotiGs = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txtcotirs = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txtcotius = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txtcotips = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btnguardar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.rptps = New System.Windows.Forms.RadioButton()
        Me.rptrs = New System.Windows.Forms.RadioButton()
        Me.rptus = New System.Windows.Forms.RadioButton()
        Me.rptgs = New System.Windows.Forms.RadioButton()
        Me.dpfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtcantidadcuota = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.optComprobante = New System.Windows.Forms.RadioButton()
        Me.btnseleccionar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Cbo1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRuc = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.CI = New System.Windows.Forms.Label()
        Me.txtNombres = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtIdCliente = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtCuotaNro = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMensualidad = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtidCredito = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtidVenta = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.grillaPND = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtBuscar = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTotalDeuda = New System.Windows.Forms.NumericUpDown()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txtCgs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCrs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TxtTotalus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTotalps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTotalrs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grillaPND, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalDeuda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtTotalDeuda)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.btnguardar)
        Me.Panel1.Controls.Add(Me.rptps)
        Me.Panel1.Controls.Add(Me.rptrs)
        Me.Panel1.Controls.Add(Me.rptus)
        Me.Panel1.Controls.Add(Me.rptgs)
        Me.Panel1.Controls.Add(Me.dpfecha)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.txtcantidadcuota)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.optComprobante)
        Me.Panel1.Controls.Add(Me.btnseleccionar)
        Me.Panel1.Controls.Add(Me.Cbo1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtRuc)
        Me.Panel1.Controls.Add(Me.CI)
        Me.Panel1.Controls.Add(Me.txtNombres)
        Me.Panel1.Controls.Add(Me.txtIdCliente)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.txtCuotaNro)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtMensualidad)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtidCredito)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.TxtidVenta)
        Me.Panel1.Controls.Add(Me.grillaPND)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1066, 723)
        Me.Panel1.TabIndex = 615
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.txtCgs)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.txtCus)
        Me.GroupBox3.Controls.Add(Me.txtCps)
        Me.GroupBox3.Controls.Add(Me.txtCrs)
        Me.GroupBox3.Location = New System.Drawing.Point(25, 623)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(453, 97)
        Me.GroupBox3.TabIndex = 685
        Me.GroupBox3.TabStop = False
        '
        'txtCgs
        '
        Me.txtCgs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCgs.DecimalPlaces = 2
        Me.txtCgs.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCgs.Location = New System.Drawing.Point(59, 10)
        Me.txtCgs.Maximum = New Decimal(New Integer() {-159383552, 46653770, 5421, 0})
        Me.txtCgs.Name = "txtCgs"
        Me.txtCgs.Size = New System.Drawing.Size(168, 32)
        Me.txtCgs.TabIndex = 662
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(26, 19)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(27, 16)
        Me.Label22.TabIndex = 657
        Me.Label22.Text = "GS"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(26, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 16)
        Me.Label5.TabIndex = 658
        Me.Label5.Text = "RS"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(235, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 16)
        Me.Label1.TabIndex = 659
        Me.Label1.Text = "US"
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(235, 62)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(26, 16)
        Me.Label26.TabIndex = 660
        Me.Label26.Text = "PS"
        '
        'txtCus
        '
        Me.txtCus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCus.DecimalPlaces = 2
        Me.txtCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCus.Location = New System.Drawing.Point(268, 10)
        Me.txtCus.Maximum = New Decimal(New Integer() {-159383552, 46653770, 5421, 0})
        Me.txtCus.Name = "txtCus"
        Me.txtCus.Size = New System.Drawing.Size(168, 32)
        Me.txtCus.TabIndex = 661
        '
        'txtCps
        '
        Me.txtCps.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCps.DecimalPlaces = 2
        Me.txtCps.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCps.Location = New System.Drawing.Point(268, 53)
        Me.txtCps.Maximum = New Decimal(New Integer() {-159383552, 46653770, 5421, 0})
        Me.txtCps.Name = "txtCps"
        Me.txtCps.Size = New System.Drawing.Size(168, 32)
        Me.txtCps.TabIndex = 663
        '
        'txtCrs
        '
        Me.txtCrs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCrs.DecimalPlaces = 2
        Me.txtCrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCrs.Location = New System.Drawing.Point(59, 53)
        Me.txtCrs.Maximum = New Decimal(New Integer() {-159383552, 46653770, 5421, 0})
        Me.txtCrs.Name = "txtCrs"
        Me.txtCrs.Size = New System.Drawing.Size(168, 32)
        Me.txtCrs.TabIndex = 664
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox4.Controls.Add(Me.TxtTotalus)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.TxtTotalps)
        Me.GroupBox4.Controls.Add(Me.TxtTotalrs)
        Me.GroupBox4.Controls.Add(Me.TxtTotal)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(484, 623)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(453, 97)
        Me.GroupBox4.TabIndex = 684
        Me.GroupBox4.TabStop = False
        '
        'TxtTotalus
        '
        Me.TxtTotalus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtTotalus.DecimalPlaces = 2
        Me.TxtTotalus.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalus.Location = New System.Drawing.Point(264, 10)
        Me.TxtTotalus.Maximum = New Decimal(New Integer() {-159383552, 46653770, 5421, 0})
        Me.TxtTotalus.Name = "TxtTotalus"
        Me.TxtTotalus.Size = New System.Drawing.Size(168, 32)
        Me.TxtTotalus.TabIndex = 679
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(231, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 16)
        Me.Label11.TabIndex = 676
        Me.Label11.Text = "US"
        '
        'Label31
        '
        Me.Label31.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(232, 62)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(26, 16)
        Me.Label31.TabIndex = 678
        Me.Label31.Text = "PS"
        '
        'TxtTotalps
        '
        Me.TxtTotalps.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtTotalps.DecimalPlaces = 2
        Me.TxtTotalps.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalps.Location = New System.Drawing.Point(264, 53)
        Me.TxtTotalps.Maximum = New Decimal(New Integer() {-159383552, 46653770, 5421, 0})
        Me.TxtTotalps.Name = "TxtTotalps"
        Me.TxtTotalps.Size = New System.Drawing.Size(168, 32)
        Me.TxtTotalps.TabIndex = 681
        '
        'TxtTotalrs
        '
        Me.TxtTotalrs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtTotalrs.DecimalPlaces = 2
        Me.TxtTotalrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalrs.Location = New System.Drawing.Point(56, 53)
        Me.TxtTotalrs.Maximum = New Decimal(New Integer() {-159383552, 46653770, 5421, 0})
        Me.TxtTotalrs.Name = "TxtTotalrs"
        Me.TxtTotalrs.Size = New System.Drawing.Size(168, 32)
        Me.TxtTotalrs.TabIndex = 682
        '
        'TxtTotal
        '
        Me.TxtTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtTotal.DecimalPlaces = 2
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(56, 10)
        Me.TxtTotal.Maximum = New Decimal(New Integer() {-159383552, 46653770, 5421, 0})
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(168, 32)
        Me.TxtTotal.TabIndex = 680
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(23, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 16)
        Me.Label14.TabIndex = 677
        Me.Label14.Text = "RS"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(23, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 16)
        Me.Label7.TabIndex = 675
        Me.Label7.Text = "GS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.TxtCotiGs)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Txtcotirs)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Txtcotius)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Txtcotips)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 123)
        Me.GroupBox1.TabIndex = 683
        Me.GroupBox1.TabStop = False
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
        Me.TxtCotiGs.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.TxtCotiGs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.TxtCotiGs.isPassword = False
        Me.TxtCotiGs.Location = New System.Drawing.Point(60, 35)
        Me.TxtCotiGs.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtCotiGs.Name = "TxtCotiGs"
        Me.TxtCotiGs.Size = New System.Drawing.Size(146, 34)
        Me.TxtCotiGs.TabIndex = 625
        Me.TxtCotiGs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(25, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 16)
        Me.Label9.TabIndex = 622
        Me.Label9.Text = "GS"
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
        Me.Txtcotirs.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Txtcotirs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Txtcotirs.isPassword = False
        Me.Txtcotirs.Location = New System.Drawing.Point(60, 79)
        Me.Txtcotirs.Margin = New System.Windows.Forms.Padding(5)
        Me.Txtcotirs.Name = "Txtcotirs"
        Me.Txtcotirs.Size = New System.Drawing.Size(146, 34)
        Me.Txtcotirs.TabIndex = 626
        Me.Txtcotirs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(25, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 16)
        Me.Label10.TabIndex = 623
        Me.Label10.Text = "RS"
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
        Me.Txtcotius.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Txtcotius.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Txtcotius.isPassword = False
        Me.Txtcotius.Location = New System.Drawing.Point(262, 35)
        Me.Txtcotius.Margin = New System.Windows.Forms.Padding(5)
        Me.Txtcotius.Name = "Txtcotius"
        Me.Txtcotius.Size = New System.Drawing.Size(146, 34)
        Me.Txtcotius.TabIndex = 627
        Me.Txtcotius.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(227, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 16)
        Me.Label8.TabIndex = 624
        Me.Label8.Text = "US"
        '
        'Txtcotips
        '
        Me.Txtcotips.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txtcotips.BackColor = System.Drawing.Color.White
        Me.Txtcotips.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Txtcotips.BorderColorIdle = System.Drawing.Color.White
        Me.Txtcotips.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Txtcotips.BorderThickness = 2
        Me.Txtcotips.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txtcotips.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Txtcotips.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Txtcotips.isPassword = False
        Me.Txtcotips.Location = New System.Drawing.Point(262, 79)
        Me.Txtcotips.Margin = New System.Windows.Forms.Padding(5)
        Me.Txtcotips.Name = "Txtcotips"
        Me.Txtcotips.Size = New System.Drawing.Size(146, 34)
        Me.Txtcotips.TabIndex = 646
        Me.Txtcotips.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(228, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 16)
        Me.Label2.TabIndex = 645
        Me.Label2.Text = "PS"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(174, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 16)
        Me.Label12.TabIndex = 628
        Me.Label12.Text = "Cotizacion Del Dia"
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(656, 603)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(131, 16)
        Me.Label28.TabIndex = 674
        Me.Label28.Text = "DETALLE DE PAGO"
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
        Me.btnguardar.ButtonText = "Cobrar Credito"
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.IdleBorderThickness = 2
        Me.btnguardar.IdleCornerRadius = 10
        Me.btnguardar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnguardar.IdleForecolor = System.Drawing.Color.White
        Me.btnguardar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnguardar.Location = New System.Drawing.Point(945, 658)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(116, 65)
        Me.btnguardar.TabIndex = 673
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rptps
        '
        Me.rptps.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rptps.AutoSize = True
        Me.rptps.Location = New System.Drawing.Point(392, 585)
        Me.rptps.Name = "rptps"
        Me.rptps.Size = New System.Drawing.Size(54, 17)
        Me.rptps.TabIndex = 672
        Me.rptps.Text = "PESO"
        Me.rptps.UseVisualStyleBackColor = True
        '
        'rptrs
        '
        Me.rptrs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rptrs.AutoSize = True
        Me.rptrs.Location = New System.Drawing.Point(265, 585)
        Me.rptrs.Name = "rptrs"
        Me.rptrs.Size = New System.Drawing.Size(53, 17)
        Me.rptrs.TabIndex = 670
        Me.rptrs.Text = "REAL"
        Me.rptrs.UseVisualStyleBackColor = True
        '
        'rptus
        '
        Me.rptus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rptus.AutoSize = True
        Me.rptus.Location = New System.Drawing.Point(324, 585)
        Me.rptus.Name = "rptus"
        Me.rptus.Size = New System.Drawing.Size(62, 17)
        Me.rptus.TabIndex = 668
        Me.rptus.Text = "DOLAR"
        Me.rptus.UseVisualStyleBackColor = True
        '
        'rptgs
        '
        Me.rptgs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rptgs.AutoSize = True
        Me.rptgs.Location = New System.Drawing.Point(185, 585)
        Me.rptgs.Name = "rptgs"
        Me.rptgs.Size = New System.Drawing.Size(74, 17)
        Me.rptgs.TabIndex = 666
        Me.rptgs.Text = "GUARANI"
        Me.rptgs.UseVisualStyleBackColor = True
        '
        'dpfecha
        '
        Me.dpfecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dpfecha.Location = New System.Drawing.Point(172, 559)
        Me.dpfecha.Name = "dpfecha"
        Me.dpfecha.Size = New System.Drawing.Size(288, 20)
        Me.dpfecha.TabIndex = 656
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(40, 563)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(56, 16)
        Me.Label24.TabIndex = 655
        Me.Label24.Text = "FECHA:"
        '
        'txtcantidadcuota
        '
        Me.txtcantidadcuota.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcantidadcuota.BackColor = System.Drawing.Color.White
        Me.txtcantidadcuota.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtcantidadcuota.BorderColorIdle = System.Drawing.Color.White
        Me.txtcantidadcuota.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtcantidadcuota.BorderThickness = 2
        Me.txtcantidadcuota.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcantidadcuota.Enabled = False
        Me.txtcantidadcuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtcantidadcuota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.txtcantidadcuota.isPassword = False
        Me.txtcantidadcuota.Location = New System.Drawing.Point(172, 475)
        Me.txtcantidadcuota.Margin = New System.Windows.Forms.Padding(5)
        Me.txtcantidadcuota.Name = "txtcantidadcuota"
        Me.txtcantidadcuota.Size = New System.Drawing.Size(288, 33)
        Me.txtcantidadcuota.TabIndex = 654
        Me.txtcantidadcuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(40, 492)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(130, 16)
        Me.Label27.TabIndex = 653
        Me.Label27.Text = "CANTIDAD CUOTA:"
        '
        'optComprobante
        '
        Me.optComprobante.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.optComprobante.AutoSize = True
        Me.optComprobante.Location = New System.Drawing.Point(735, 81)
        Me.optComprobante.Name = "optComprobante"
        Me.optComprobante.Size = New System.Drawing.Size(80, 17)
        Me.optComprobante.TabIndex = 651
        Me.optComprobante.TabStop = True
        Me.optComprobante.Text = "Nº De Nota"
        Me.optComprobante.UseVisualStyleBackColor = True
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
        Me.btnseleccionar.Location = New System.Drawing.Point(298, 21)
        Me.btnseleccionar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnseleccionar.Name = "btnseleccionar"
        Me.btnseleccionar.Size = New System.Drawing.Size(110, 51)
        Me.btnseleccionar.TabIndex = 644
        Me.btnseleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cbo1
        '
        Me.Cbo1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cbo1.FormattingEnabled = True
        Me.Cbo1.Items.AddRange(New Object() {"Cobros a Contado", "Cobros de Creditos", "Pagos de Caja"})
        Me.Cbo1.Location = New System.Drawing.Point(116, 43)
        Me.Cbo1.Name = "Cbo1"
        Me.Cbo1.Size = New System.Drawing.Size(174, 21)
        Me.Cbo1.TabIndex = 643
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(157, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 16)
        Me.Label4.TabIndex = 642
        Me.Label4.Text = "Tipo de Cobro"
        '
        'txtRuc
        '
        Me.txtRuc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRuc.BackColor = System.Drawing.Color.White
        Me.txtRuc.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtRuc.BorderColorIdle = System.Drawing.Color.White
        Me.txtRuc.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtRuc.BorderThickness = 2
        Me.txtRuc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRuc.Enabled = False
        Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtRuc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.txtRuc.isPassword = False
        Me.txtRuc.Location = New System.Drawing.Point(172, 346)
        Me.txtRuc.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(288, 33)
        Me.txtRuc.TabIndex = 641
        Me.txtRuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'CI
        '
        Me.CI.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CI.AutoSize = True
        Me.CI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CI.ForeColor = System.Drawing.Color.Black
        Me.CI.Location = New System.Drawing.Point(40, 363)
        Me.CI.Name = "CI"
        Me.CI.Size = New System.Drawing.Size(40, 16)
        Me.CI.TabIndex = 640
        Me.CI.Text = "RUC:"
        '
        'txtNombres
        '
        Me.txtNombres.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNombres.BackColor = System.Drawing.Color.White
        Me.txtNombres.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtNombres.BorderColorIdle = System.Drawing.Color.White
        Me.txtNombres.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtNombres.BorderThickness = 2
        Me.txtNombres.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtNombres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.txtNombres.isPassword = False
        Me.txtNombres.Location = New System.Drawing.Point(242, 303)
        Me.txtNombres.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(218, 33)
        Me.txtNombres.TabIndex = 639
        Me.txtNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtIdCliente.BackColor = System.Drawing.Color.White
        Me.txtIdCliente.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtIdCliente.BorderColorIdle = System.Drawing.Color.White
        Me.txtIdCliente.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtIdCliente.BorderThickness = 2
        Me.txtIdCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtIdCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.txtIdCliente.isPassword = False
        Me.txtIdCliente.Location = New System.Drawing.Point(172, 303)
        Me.txtIdCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(60, 33)
        Me.txtIdCliente.TabIndex = 638
        Me.txtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(40, 323)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(67, 16)
        Me.Label25.TabIndex = 637
        Me.Label25.Text = "CLIENTE:"
        '
        'txtCuotaNro
        '
        Me.txtCuotaNro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCuotaNro.BackColor = System.Drawing.Color.White
        Me.txtCuotaNro.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtCuotaNro.BorderColorIdle = System.Drawing.Color.White
        Me.txtCuotaNro.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtCuotaNro.BorderThickness = 2
        Me.txtCuotaNro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCuotaNro.Enabled = False
        Me.txtCuotaNro.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtCuotaNro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.txtCuotaNro.isPassword = False
        Me.txtCuotaNro.Location = New System.Drawing.Point(172, 518)
        Me.txtCuotaNro.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCuotaNro.Name = "txtCuotaNro"
        Me.txtCuotaNro.Size = New System.Drawing.Size(288, 33)
        Me.txtCuotaNro.TabIndex = 636
        Me.txtCuotaNro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(40, 535)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(135, 16)
        Me.Label23.TabIndex = 635
        Me.Label23.Text = "CUOTAS PAGADAS:"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(40, 449)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(106, 16)
        Me.Label18.TabIndex = 633
        Me.Label18.Text = "TOTAL DEUDA:"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(40, 406)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 16)
        Me.Label13.TabIndex = 632
        Me.Label13.Text = "MENSUALIDAD:"
        '
        'txtMensualidad
        '
        Me.txtMensualidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMensualidad.BackColor = System.Drawing.Color.White
        Me.txtMensualidad.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtMensualidad.BorderColorIdle = System.Drawing.Color.White
        Me.txtMensualidad.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtMensualidad.BorderThickness = 2
        Me.txtMensualidad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMensualidad.Enabled = False
        Me.txtMensualidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtMensualidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.txtMensualidad.isPassword = False
        Me.txtMensualidad.Location = New System.Drawing.Point(172, 389)
        Me.txtMensualidad.Margin = New System.Windows.Forms.Padding(5)
        Me.txtMensualidad.Name = "txtMensualidad"
        Me.txtMensualidad.Size = New System.Drawing.Size(288, 33)
        Me.txtMensualidad.TabIndex = 631
        Me.txtMensualidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(40, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 630
        Me.Label3.Text = "CREDITO NRO:"
        '
        'txtidCredito
        '
        Me.txtidCredito.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtidCredito.BackColor = System.Drawing.Color.White
        Me.txtidCredito.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtidCredito.BorderColorIdle = System.Drawing.Color.White
        Me.txtidCredito.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtidCredito.BorderThickness = 2
        Me.txtidCredito.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtidCredito.Enabled = False
        Me.txtidCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtidCredito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.txtidCredito.isPassword = False
        Me.txtidCredito.Location = New System.Drawing.Point(172, 217)
        Me.txtidCredito.Margin = New System.Windows.Forms.Padding(5)
        Me.txtidCredito.Name = "txtidCredito"
        Me.txtidCredito.Size = New System.Drawing.Size(288, 33)
        Me.txtidCredito.TabIndex = 629
        Me.txtidCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(202, 196)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(131, 16)
        Me.Label21.TabIndex = 621
        Me.Label21.Text = "DETALLE DE NOTA"
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(40, 277)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 16)
        Me.Label20.TabIndex = 620
        Me.Label20.Text = "VENTA NRO:"
        '
        'TxtidVenta
        '
        Me.TxtidVenta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtidVenta.BackColor = System.Drawing.Color.White
        Me.TxtidVenta.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.TxtidVenta.BorderColorIdle = System.Drawing.Color.White
        Me.TxtidVenta.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.TxtidVenta.BorderThickness = 2
        Me.TxtidVenta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtidVenta.Enabled = False
        Me.TxtidVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.TxtidVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.TxtidVenta.isPassword = False
        Me.TxtidVenta.Location = New System.Drawing.Point(172, 260)
        Me.TxtidVenta.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtidVenta.Name = "TxtidVenta"
        Me.TxtidVenta.Size = New System.Drawing.Size(288, 33)
        Me.TxtidVenta.TabIndex = 619
        Me.TxtidVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'grillaPND
        '
        Me.grillaPND.AllowUserToAddRows = False
        Me.grillaPND.AllowUserToDeleteRows = False
        Me.grillaPND.AllowUserToOrderColumns = True
        Me.grillaPND.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grillaPND.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.grillaPND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaPND.GridColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grillaPND.Location = New System.Drawing.Point(484, 106)
        Me.grillaPND.Name = "grillaPND"
        Me.grillaPND.ReadOnly = True
        Me.grillaPND.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.grillaPND.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grillaPND.Size = New System.Drawing.Size(577, 472)
        Me.grillaPND.TabIndex = 618
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
        Me.btnBuscar.ButtonText = "Bucar"
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.IdleBorderThickness = 2
        Me.btnBuscar.IdleCornerRadius = 10
        Me.btnBuscar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnBuscar.IdleForecolor = System.Drawing.Color.White
        Me.btnBuscar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnBuscar.Location = New System.Drawing.Point(904, 32)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(157, 45)
        Me.btnBuscar.TabIndex = 617
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
        Me.txtBuscar.Location = New System.Drawing.Point(567, 39)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(327, 34)
        Me.txtBuscar.TabIndex = 616
        Me.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(417, 3)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(233, 29)
        Me.Label15.TabIndex = 615
        Me.Label15.Text = "Caja Venta a Credito"
        '
        'txtTotalDeuda
        '
        Me.txtTotalDeuda.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTotalDeuda.DecimalPlaces = 2
        Me.txtTotalDeuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDeuda.Location = New System.Drawing.Point(172, 433)
        Me.txtTotalDeuda.Maximum = New Decimal(New Integer() {-159383552, 46653770, 5421, 0})
        Me.txtTotalDeuda.Name = "txtTotalDeuda"
        Me.txtTotalDeuda.Size = New System.Drawing.Size(288, 32)
        Me.txtTotalDeuda.TabIndex = 665
        '
        'frmCajaCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1066, 723)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCajaCredito"
        Me.Text = "frmCajaCredito"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.txtCgs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCrs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.TxtTotalus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTotalps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTotalrs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grillaPND, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalDeuda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtTotalrs As NumericUpDown
    Friend WithEvents TxtTotalps As NumericUpDown
    Friend WithEvents TxtTotal As NumericUpDown
    Friend WithEvents TxtTotalus As NumericUpDown
    Friend WithEvents Label31 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents btnguardar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents rptps As RadioButton
    Friend WithEvents rptrs As RadioButton
    Friend WithEvents rptus As RadioButton
    Friend WithEvents rptgs As RadioButton
    Friend WithEvents txtCrs As NumericUpDown
    Friend WithEvents txtCps As NumericUpDown
    Friend WithEvents txtCgs As NumericUpDown
    Friend WithEvents txtCus As NumericUpDown
    Friend WithEvents Label26 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents dpfecha As DateTimePicker
    Friend WithEvents Label24 As Label
    Friend WithEvents txtcantidadcuota As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label27 As Label
    Friend WithEvents optComprobante As RadioButton
    Friend WithEvents Txtcotips As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnseleccionar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Cbo1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRuc As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents CI As Label
    Friend WithEvents txtNombres As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtIdCliente As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtCuotaNro As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtMensualidad As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtidCredito As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label12 As Label
    Friend WithEvents Txtcotius As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Txtcotirs As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents TxtCotiGs As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtidVenta As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents grillaPND As DataGridView
    Friend WithEvents btnBuscar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtBuscar As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtTotalDeuda As NumericUpDown
End Class
