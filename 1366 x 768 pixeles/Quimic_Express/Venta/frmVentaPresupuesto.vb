﻿Imports MySql.Data.MySqlClient
Public Class frmVentaPresupuesto
    Dim total, iva, subtotal, descuento As Double
    Private Sub cargarCotizacion()
        Dim sql As String
        Dim adaptador As MySqlDataAdapter
        Dim datos As DataSet
        sql = "select * from cotizacion where estado='1' "
        Try
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "coti")
            If datos.Tables("coti").Rows.Count > 0 Then
                txtTgs.Text = datos.Tables("coti").Rows(0).Item("guarani")
                txtTus.Text = datos.Tables("coti").Rows(0).Item("dolar")
                txtTps.Text = datos.Tables("coti").Rows(0).Item("Peso")
                txtTrs.Text = datos.Tables("coti").Rows(0).Item("realb")
            Else
                txtTgs.Text = "1"
                txtTus.Text = "1"
                txtTps.Text = "1"
                txtTrs.Text = "1"
            End If
            conexion.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub totalMonedas()
        txtgs.Text = total
        txtus.Text = total * Val(txtTgs.Text / txtTus.Text)
        txtrs.Text = total * Val(txtTgs.Text / txtTrs.Text)
        txtps.Text = total * Val(txtTgs.Text / txtTps.Text)
    End Sub

    Private Sub cargarGrilla()
        Dim nuevaFila As Integer
        If txtIdProducto.Text <> "" And IsNumeric(txtPrecio.Text) = True And IsNumeric(txtCantidad.Text) = True Then
            nuevaFila = grilla.RowCount
            grilla.Rows.Add()

            grilla.Item(0, nuevaFila).Value = nuevaFila + 1
            grilla.Item(1, nuevaFila).Value = txtIdProducto.Text
            grilla.Item(2, nuevaFila).Value = txtDescripcion.Text
            grilla.Item(3, nuevaFila).Value = txtPrecio.Text
            grilla.Item(4, nuevaFila).Value = TxtDescuento.Text
            grilla.Item(5, nuevaFila).Value = txtCantidad.Text
            grilla.Item(6, nuevaFila).Value = Val(txtPrecio.Text) * Val(txtCantidad.Text)

            subtotal = subtotal + (Val(txtPrecio.Text) * Val(txtCantidad.Text))
            descuento = Val(txtPrecio.Text) - Val(TxtDescuento.Text)
            iva = (subtotal / 11)
            total = subtotal

            txtsubtotal.Text = subtotal

            txtiva.Text = iva
            txttotal.Text = total

            Call totalMonedas()
            Call limpiarItems()
            txtIdProducto.Focus()

        End If
    End Sub


    Private Sub limpiarItems()
        txtDescripcion.Text = ""
        txtStock.Text = ""
        txtPrecio.Text = ""
        txtIdProducto.Text = ""
        txtCantidad.Text = ""
        txtMarca.Text = ""
        TxtDescuento.Text = 0
        txtCategoria.Text = ""
        txtProveedor.Text = ""

    End Sub

    Private Sub limpiarNota()

    End Sub

    Private Sub frmventa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargarCotizacion()
        verificarVenta()

    End Sub


    Private Sub agregarItems()
        'agregar productos a la tabla venta_items
        Dim comando As MySqlCommand
        Dim sql As String
        Dim cant, c As Integer
        cant = grilla.Rows.Count
        c = 0
        While c < cant
            Try
                sql = "insert into venta_items_presupuesto (idventa,idproducto,descripcion,precio,cantidad,iva,estadodescuento) values(@idventa,@idproducto,@descripcion,@precio,@cantidad,@iva,@estado,@descuento)"
                abrirConexion()
                comando = New MySqlCommand(sql, conexion)
                comando.Parameters.AddWithValue("@idventa", txtidVenta.Text)
                comando.Parameters.AddWithValue("@idproducto", grilla.Item(1, c).Value)
                comando.Parameters.AddWithValue("@descripcion", grilla.Item(2, c).Value)
                comando.Parameters.AddWithValue("@precio", grilla.Item(3, c).Value)
                comando.Parameters.AddWithValue("@descuento", grilla.Item(4, c).Value)
                comando.Parameters.AddWithValue("@cantidad", grilla.Item(5, c).Value)
                comando.Parameters.AddWithValue("@iva", 10)
                comando.Parameters.AddWithValue("@estado", 1)
                comando.ExecuteNonQuery()
                conexion.Close()
            Catch ex As MySqlException
                MsgBox(ex.Message)
            End Try
            c = c + 1
        End While
    End Sub
    Private Sub ActualizarVenta()
        Dim comando As MySqlCommand
        Dim sql As String

        Dim transaccion As MySqlTransaction

        Call abrirConexion() 'se abre una conexion con la base de datos
        transaccion = conexion.BeginTransaction  'se inicia una transaccion con la base de datos, acontinuacion se inicia procesos multiples

        sql = "update ventapresupuesto set comprobante= @comp, idcliente=@idcli, fecha=@fecha, subtotal=@subt,iva=@iva, descuento=@desc, totalneto=@totalneto, idusuario=@iduser, estado=@estado, ruc=@ruc where id=@id"
        Try
            'inicia primer proceso
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@comp", txtComprobante.Text)
            comando.Parameters.AddWithValue("@idcli", txtIdCliente.Text)
            comando.Parameters.AddWithValue("@fecha", dpFechaVenta.Value)
            comando.Parameters.AddWithValue("@subt", txtsubtotal.Text)
            comando.Parameters.AddWithValue("@iva", txtiva.Text)
            comando.Parameters.AddWithValue("@desc", "0")
            comando.Parameters.AddWithValue("@totalneto", txttotal.Text)
            comando.Parameters.AddWithValue("@iduser", usuario)
            comando.Parameters.AddWithValue("@estado", "1")
            comando.Parameters.AddWithValue("@id", txtidVenta.Text)
            comando.Parameters.AddWithValue("@ruc", txtRucCliente.Text)
            comando.ExecuteNonQuery()

            'inicia segundo proces0
            Dim cant, c As Integer
            cant = grilla.Rows.Count
            c = 0
            While c < cant
                'sql = "Update inventario set Stock=Stock-@cantidad where Id_Inventario=@idproducto"
                'comando = New MySqlCommand(sql, conexion)
                'comando.Parameters.AddWithValue("@idproducto", grilla.Item(1, c).Value)
                'comando.Parameters.AddWithValue("@cantidad", grilla.Item(5, c).Value)
                'comando.ExecuteNonQuery()


                sql = "insert into venta_items_presupuesto (idventa,idproducto,descripcion,precio,cantidad,iva,estado,ruc,descuento,subtotal) values(@idventa,@idproducto,@descripcion,@precio,@cantidad,@iva,@estado,@ruc,@descuento,@subtotal)"
                comando = New MySqlCommand(sql, conexion)
                comando.Parameters.AddWithValue("@idventa", txtidVenta.Text)
                comando.Parameters.AddWithValue("@idproducto", grilla.Item(1, c).Value)
                comando.Parameters.AddWithValue("@descripcion", grilla.Item(2, c).Value)
                comando.Parameters.AddWithValue("@precio", grilla.Item(3, c).Value)
                comando.Parameters.AddWithValue("@descuento", grilla.Item(4, c).Value)
                comando.Parameters.AddWithValue("@cantidad", grilla.Item(5, c).Value)
                comando.Parameters.AddWithValue("@subtotal", grilla.Item(6, c).Value)
                comando.Parameters.AddWithValue("@iva", 10)
                comando.Parameters.AddWithValue("@estado", 1)
                comando.Parameters.AddWithValue("@ruc", txtRucCliente.Text)
                comando.ExecuteNonQuery()

                c = c + 1
            End While

            transaccion.Commit()
            cerrarConexion()
        Catch ex As MySqlException
            MsgBox(ex.Message)
            transaccion.Rollback()
        End Try
    End Sub






    Public Sub verificarVenta()
        Dim sql As String
        Dim datos As New DataSet
        Dim adaptador As MySqlDataAdapter
        usuario = 1
        sql = "select * from ventapresupuesto where idusuario='" & usuario & "' and estado=0"

        Try
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            adaptador.Fill(datos, "xventa")

            If datos.Tables("xventa").Rows.Count > 0 Then
                txtComprobante.Text = datos.Tables("xventa").Rows(0).Item("comprobante")
                txtIdCliente.Text = datos.Tables("xventa").Rows(0).Item("idcliente")
                txtidVenta.Text = datos.Tables("xventa").Rows(0).Item("id")
                Call buscarCliente()
                txtIdProducto.Focus()
                operacionABM = "editar"
            Else
                'seleccionando el ultimo comprobante registrado
                sql = "select max(cast(comprobante as unsigned)) as comprobante from ventapresupuesto"
                adaptador = New MySqlDataAdapter(sql, conexion)
                Dim nuevaVenta As New DataSet
                adaptador.Fill(nuevaVenta, "xNuevaVenta")
                txtComprobante.Text = nuevaVenta.Tables("xNuevaVenta").Rows(0).Item("comprobante") + 1
                txtidVenta.Text = 0

                'insertando nueva venta
                sql = "INSERT INTO ventapresupuesto(comprobante,idcliente,fecha,subtotal,iva,descuento,totalneto,idusuario,estado,ruc) values(@comprobante,@idcliente,@fecha,@subtotal,@iva,@descuento,@totalneto,@idusuario,@estado,ruc)"
                Dim comando As MySqlCommand
                comando = New MySqlCommand(sql, conexion)
                comando.Parameters.AddWithValue("@comprobante", txtComprobante.Text)
                comando.Parameters.AddWithValue("@idcliente", 1)
                comando.Parameters.AddWithValue("@fecha", Today())
                comando.Parameters.AddWithValue("@subtotal", 0)
                comando.Parameters.AddWithValue("@iva", 0)
                comando.Parameters.AddWithValue("@descuento", 0)
                comando.Parameters.AddWithValue("@totalneto", 0)
                comando.Parameters.AddWithValue("@idusuario", usuario)
                comando.Parameters.AddWithValue("@estado", 0)
                comando.Parameters.AddWithValue("@ruc", 0)
                comando.ExecuteNonQuery()
                'recuperar venta insertada y cargar  en el formulario
                sql = "select * from ventapresupuesto where idusuario='" & usuario & "' and estado=0 order by id desc limit 1"
                Dim newVenta As New DataSet
                adaptador = New MySqlDataAdapter(sql, conexion)
                adaptador.Fill(newVenta, "nVenta")
                If newVenta.Tables("nVenta").Rows.Count > 0 Then
                    txtComprobante.Text = newVenta.Tables("nVenta").Rows(0).Item("comprobante")
                    txtidVenta.Text = newVenta.Tables("nVenta").Rows(0).Item("id")
                End If
                conexion.Close()
            End If

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub F6BuscarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles F6BuscarClienteToolStripMenuItem.Click
        Dim frm As frmBuscarClientePresupuesto = New frmBuscarClientePresupuesto
        AddOwnedForm(frm)
        frm.Show()
        frm.frmOrigen = "venta"
    End Sub


    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.F6 Then
            Dim frm As frmBuscarClientePresupuesto = New frmBuscarClientePresupuesto
            AddOwnedForm(frm)
            frm.Show()
            frm.frmOrigen = "venta"
        ElseIf keyData = Keys.F5 Then
            Dim frm As frmBuscarProductoPresupuesto = New frmBuscarProductoPresupuesto
            AddOwnedForm(frm)
            frm.Show()
            frm.frmOrigen = "venta"
        End If
        Return False

    End Function
    Private Sub F5BuscarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles F5BuscarProductoToolStripMenuItem.Click
        Dim frm As frmBuscarProductoPresupuesto = New frmBuscarProductoPresupuesto
        AddOwnedForm(frm)
        frm.Show()
        frm.frmOrigen = "venta"
    End Sub

    Private Sub buscarCliente()
        Dim sql As String
        Dim adaptador As MySqlDataAdapter
        Dim datos As DataSet
        sql = "select * from cliente where id_Cliente='" & txtIdCliente.Text & "'"
        Try
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "rsCliente")
            If datos.Tables("rsCliente").Rows.Count > 0 Then
                txtNomCliente.Text = datos.Tables("rsCliente").Rows(0).Item("nombre")
                txtRucCliente.Text = datos.Tables("rsCliente").Rows(0).Item("ruc")
            Else
                txtNomCliente.Text = ""
                txtIdCliente.Text = ""
                txtRucCliente.Text = ""
                MessageBox.Show("Cliente no Encontrado", "QUIMIC EXPRESS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show("Abrir Formulario", "QUIMIC EXPRESS", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Dim frmx As frmBuscarClientePresupuesto = New frmBuscarClientePresupuesto
                AddOwnedForm(frmx)
                frmx.Show()
                frmx.frmOrigen = "venta"

            End If
            conexion.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub buscarProducto()
        Dim sql As String
        Dim adaptador As MySqlDataAdapter
        Dim datos As DataSet
        sql = "select * from consultainventario where codigo='" & txtIdProducto.Text & "'"

        Try
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "busqProducto")
            If datos.Tables("busqProducto").Rows.Count > 0 Then
                txtDescripcion.Text = datos.Tables("busqProducto").Rows(0).Item("descripción")
                txtStock.Text = datos.Tables("busqProducto").Rows(0).Item("stock")
                txtPrecio.Text = datos.Tables("busqProducto").Rows(0).Item("precionormal")
                txtIdProducto.Text = datos.Tables("busqProducto").Rows(0).Item("codigo")
                txtMarca.Text = datos.Tables("busqProducto").Rows(0).Item("marca")
                txtCategoria.Text = datos.Tables("busqProducto").Rows(0).Item("categoria")
                txtProveedor.Text = datos.Tables("busqProducto").Rows(0).Item("proveedor")
                txtCantidad.Focus()
            Else
                txtDescripcion.Text = ""
                txtStock.Text = ""
                txtPrecio.Text = ""
                txtIdProducto.Focus()
                MessageBox.Show("producto no Encontrada", "QUIMIC EXPRESS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show("Abrir Formulario", "QUIMIC EXPRESS", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Dim frm As frmBuscarProductoPresupuesto = New frmBuscarProductoPresupuesto
                AddOwnedForm(frm)
                frm.Show()
                frm.frmOrigen = "venta"

            End If
            conexion.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub verificarStock()
        If IsNumeric(txtCantidad.Text) = True Then
            If Val(txtCantidad.Text) <= Val(txtStock.Text) Then
                txtPrecio.Focus()
            Else
                MsgBox("Stock Insuficiente")
                txtCantidad.Focus()

            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Call ActualizarVenta()

        Call limpiarNota()
        MsgBox("Presupuesto Realizado")
        Call cargarCotizacion()

        frmPrintVentaPresupuesto.Show()
        frmPrintVentaPresupuesto.imprimirVenta(txtidVenta.Text)
    End Sub

    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        AbrirFormInPanel(New frmLogo)
    End Sub


    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            If IsNumeric(txtPrecio.Text) = True Then
                TxtDescuento.Focus()


            End If

        End If

    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If txtStock.Text <> "" Then
                Call verificarStock()
            End If
        End If
    End Sub

    Private Sub txtCantidad_Leave(sender As Object, e As EventArgs) Handles txtCantidad.Leave
        If txtStock.Text <> "" Then
            Call verificarStock()
        End If
    End Sub

    'Private Sub txtDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescripcion.KeyDown
    '    Dim frm As frmBuscarProducto = New frmBuscarProducto
    '    AddOwnedForm(frm)
    '    frm.Show()
    '    frm.frmOrigen = "venta"
    'End Sub

    Private Sub txtdProducto_Leave(sender As Object, e As EventArgs) Handles txtIdProducto.Leave
        If txtIdProducto.Text <> "" Then
            Call buscarProducto()
        End If
    End Sub

    Private Sub txtIdCliente_Leave(sender As Object, e As EventArgs) Handles txtIdCliente.Leave
        If (txtIdCliente.Text <> "") Then
            Call buscarCliente()
        End If
    End Sub

    Private Sub txtIdCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdCliente.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If IsNumeric(txtIdCliente.Text) = True Then
                Call buscarCliente()
                txtIdProducto.Focus()
                e.Handled = True
            Else
                Dim frmx As frmBuscarClientePresupuesto = New frmBuscarClientePresupuesto
                AddOwnedForm(frmx)
                frmx.Show()
                frmx.frmOrigen = "venta"

            End If

        End If
    End Sub

    Private Sub TxtDescuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDescuento.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If IsNumeric(TxtDescuento.Text) = True Then
                descuento = Val(txtPrecio.Text) - Val(TxtDescuento.Text)
                txtPrecio.Text = descuento
                Call cargarGrilla()


            End If
        End If
    End Sub

    Private Sub txtIdProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdProducto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If txtIdProducto.Text <> "" Then
                Call buscarProducto()
                e.Handled = True
            Else
                Dim frmx As frmBuscarProductoPresupuesto = New frmBuscarProductoPresupuesto
                AddOwnedForm(frmx)
                frmx.Show()
                frmx.frmOrigen = "venta"
            End If
        End If
    End Sub



    Private Sub PanelContenedor_Paint(sender As Object, e As PaintEventArgs) Handles PanelContenedor.Paint

    End Sub
    Public Sub AbrirFormInPanel(ByVal Formhijo As Object)
        If (frmMenu.PanelContenedor.Controls.Count > 0) Then
            frmMenu.PanelContenedor.Controls.RemoveAt(0)
        End If

        Dim De As Form = CType(Formhijo, Form)
        De.TopLevel = False
        De.Dock = DockStyle.Fill
        frmMenu.PanelContenedor.Controls.Add(De)
        frmMenu.PanelContenedor.Tag = De
        De.Show()
    End Sub
End Class