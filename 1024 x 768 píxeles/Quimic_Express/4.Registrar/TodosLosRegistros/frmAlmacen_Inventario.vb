Imports MySql.Data.MySqlClient
Imports iTextSharp.text.pdf
Public Class frmAlmacen_Inventario
    Dim adaptador As MySqlDataAdapter
    Dim comando As MySqlCommand
    Dim datos As DataSet
    Private Sub frmALMACEN_INVENTARIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If operacionABM = "almacen" Then
            Call buscarAlmacen(codigoABM)
        End If
    End Sub


    Private Sub buscarAlmacen(codigo As Integer)
        Dim sql As String
        Try
            sql = "select* from almacen where Id_Almacen=" & codigo
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "xalmacn")
            txtidAlmacen.Text = datos.Tables("xalmacn").Rows(0).Item("Id_Almacen")
            txtTotal.Text = datos.Tables("xalmacn").Rows(0).Item("CantidadLitro")
            txttotalKilos.Text = datos.Tables("xalmacn").Rows(0).Item("CantidadKilos")

            If txtTotal.Text = 0 Then
                txtTotal.Visible = False
                Label3.Visible = False
                txtinventarioLitros.Visible = False
                Label4.Visible = False

            ElseIf txttotalKilos.Text = 0 Then
                txttotalKilos.Visible = False
                kilos.Visible = False
                Label6.Visible = False
                txtkilos.Visible = False
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            cerrarConexion()

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call cargarNuevo()
    End Sub

    Private Sub cargarNuevo()
        Try
            Dim nuevoInventario As New Inventario
            Dim Id_inventario As Integer

            nuevoInventario.Id_Inventario = txtCodigo.Text.Trim
            nuevoInventario.Codigo_Barra = txtCodigoBarra.Text.Trim
            nuevoInventario.Descripción = txtDescripcion.Text.Trim
            nuevoInventario.Marca = txtMarca.Text.Trim
            nuevoInventario.Categoria = txtCategoria.Text.Trim
            nuevoInventario.Proveedor = txtProveedor.Text.Trim
            nuevoInventario.Precio_Costo = txtCosto.Text.Trim
            nuevoInventario.Precio_Minimo = txtPrecioMinimo.Text.Trim
            nuevoInventario.Precio_Normal = txtNormal.Text.Trim
            nuevoInventario.Stock = txtStock.Text.Trim
            nuevoInventario.Fecha = dtpFecha.Value

            If txtCodigo.Text = 0 Then
                Id_inventario = Inventario.InsertarInventario(nuevoInventario)
            Else
                Inventario.EditarInventario(nuevoInventario)

            End If


            Call restarAlmacen()
            Call limpiarItemsDeInventario()
            btnCancelar.Focus()
            MessageBox.Show("Operacion Realizada")
        Catch ex As MySqlException
            MessageBox.Show("Ocurrio este error:" & ex.Message)

        End Try
    End Sub
    Public Sub limpiarItemsDeInventario()
        txtCodigo.Text = 0
        txtCodigoBarra.Text = ""
        txtDescripcion.Text = ""
        txtMarca.Value = 0
        txtNombreMarca.Text = ""
        txtCategoria.Value = 0
        txtNombreCategoria.Text = ""
        txtProveedor.Value = 0
        txtNombreProveedor.Text = ""
        txtCosto.Value = 0
        txtPrecioMinimo.Value = 0
        txtNormal.Value = 0
        txtStock.Text = ""
        txtidAlmacen.Text = ""
        txtTotal.Text = ""
        txttotalKilos.Text = ""
        txtkilos.Text = ""
        txtinventarioLitros.Text = ""
        dtpFecha.Value = Now
        txtCodigoBarra.Focus()
    End Sub

    Private Sub SeleccionarCategoria(codigo As Integer)
        Dim sql As String
        Try
            sql = "select * from categoria where id_categoria= " & codigo
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "categoria")
            If datos.Tables("categoria").Rows.Count > 0 Then
                txtNombreCategoria.Text = datos.Tables("categoria").Rows(0).Item("Descripción")
                txtProveedor.Focus()
            Else
                MessageBox.Show("Categoria no Encontrada", "QUIMIC EXPRESS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show("Abrir Formulario", "QUIMIC EXPRESS", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Dim frm As frmSeleccionarCategoriaInventario = New frmSeleccionarCategoriaInventario
                AddOwnedForm(frm)
                frm.Show()
                txtProveedor.Focus()
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Sub

    Private Sub SeleccionarMarca(codigo As Integer)
        Dim sql As String
        Try
            sql = "select * from marca where id_marca= " & codigo
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "marca")
            If datos.Tables("marca").Rows.Count > 0 Then
                txtNombreMarca.Text = datos.Tables("marca").Rows(0).Item("Descripción")
                txtCategoria.Focus()
            Else
                MessageBox.Show("Marca no Encontrada", "QUIMIC EXPRESS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show("Abrir Formulario", "QUIMIC EXPRESS", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Dim frm As frmSeleccionarMarcaInventario = New frmSeleccionarMarcaInventario
                AddOwnedForm(frm)
                frm.Show()
                txtCategoria.Focus()
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Sub

    Private Sub SeleccionarProveedor(codigo As Integer)
        Dim sql As String
        Try
            sql = "select * from proveedor where id_Proveedor= " & codigo
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "proveedor")
            If datos.Tables("proveedor").Rows.Count > 0 Then
                txtNombreProveedor.Text = datos.Tables("proveedor").Rows(0).Item("nombre")
                txtCosto.Focus()
            Else
                MessageBox.Show("Proveedor no Encontrado", "QUIMIC EXPRESS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show("Abrir Formulario", "QUIMIC EXPRESS", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Dim frm As frmSeleccionarProveedorInventario = New frmSeleccionarProveedorInventario
                AddOwnedForm(frm)
                frm.Show()
                txtCosto.Focus()
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try

    End Sub

    Private Sub txtProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProveedor.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If IsNumeric(txtProveedor.Text) = False Or txtProveedor.Text = "" Then
                MessageBox.Show("Abrir Formulario", "QUIMIC EXPRESS", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Else
                Call SeleccionarProveedor(txtProveedor.Text)
            End If

            If IsNumeric(txtProveedor.Text) = False Or txtProveedor.Text = "" Then
                Dim frm As frmSeleccionarProveedorInventario = New frmSeleccionarProveedorInventario
                AddOwnedForm(frm)
                frm.Show()
                txtCosto.Focus()
            End If
        End If
    End Sub

    Private Sub txtMarca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMarca.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If IsNumeric(txtMarca.Text) = False Or txtMarca.Text = "" Then
                MessageBox.Show("Abrir Formulario", "QUIMIC EXPRESS", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Else
                Call SeleccionarMarca(txtMarca.Text)
            End If

            If IsNumeric(txtMarca.Text) = False Or txtMarca.Text = "" Then
                Dim frm As frmSeleccionarMarcaInventario = New frmSeleccionarMarcaInventario
                AddOwnedForm(frm)
                frm.Show()
                txtCategoria.Focus()
            End If
        End If
    End Sub

    Private Sub txtCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCategoria.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If IsNumeric(txtCategoria.Text) = False Or txtCategoria.Text = "" Then
                MessageBox.Show("Abrir Formulario", "QUIMIC EXPRESS", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Else
                Call SeleccionarCategoria(txtCategoria.Text)
            End If

            If IsNumeric(txtCategoria.Text) = False Or txtCategoria.Text = "" Then
                Dim frm As frmSeleccionarCategoriaInventario = New frmSeleccionarCategoriaInventario
                AddOwnedForm(frm)
                frm.Show()
                txtProveedor.Focus()
            End If
        End If
    End Sub

    Public Sub AbrirFormInPanel(ByVal Formhijo As Object)
        If (frmMenu.PanelContenedor.Controls.Count > 0) Then
            frmMenu.PanelContenedor.Controls.RemoveAt(0)
        End If

        Dim fh As Form = CType(Formhijo, Form)
        fh.TopLevel = False
        fh.Dock = DockStyle.Fill
        frmMenu.PanelContenedor.Controls.Add(fh)
        frmMenu.PanelContenedor.Tag = fh
        fh.Show()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        AbrirFormInPanel(New frmConsultarAlmacen)
    End Sub


    Private Sub txtCodigoBarra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoBarra.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDescripcion.Focus()
        End If
    End Sub

    Private Sub txtDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtMarca.Focus()
        End If
    End Sub

    Private Sub txtCosto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCosto.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPrecioMinimo.Focus()
        End If
    End Sub

    Private Sub txtPrecioMinimo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrecioMinimo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNormal.Focus()
        End If
    End Sub

    Private Sub txtNormal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNormal.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtStock.Focus()
        End If
    End Sub

    Private Sub txtStock_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStock.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call cargarNuevo()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("Quiere Eliminar el Registros?", "Eliminar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim NuevoInventario As New Inventario
            NuevoInventario.Id_Inventario = txtCodigo.Text
            Inventario.EliminarInventario(NuevoInventario)

            limpiarItemsDeInventario()
            MessageBox.Show("Operacion Realizada")
        End If
    End Sub

    Private Sub txtMarca_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMarca.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCategoria.Focus()
        End If
    End Sub

    Private Sub txtCategoria_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCategoria.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtProveedor.Focus()
        End If
    End Sub

    Private Sub txtProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPrecioMinimo.Focus()
        End If
    End Sub

    Private Sub restarAlmacen()
        Dim sql As String
        Dim comando As MySqlCommand
        Dim adaptador As New MySqlDataAdapter

        Try
            If txtTotal.Visible = False Then
                sql = "update almacen set CantidadKilos='" & Me.txttotalKilos.Text & "'  -'" & Me.txtkilos.Text & "'  where Id_Almacen= @idAlmacen"
                Call abrirConexion()
                comando = New MySqlCommand(sql, conexion)
                comando.Parameters.AddWithValue("@idAlmacen", txtidAlmacen.Text)
                comando.ExecuteNonQuery()

            ElseIf txttotalKilos.Visible = False Then
                sql = "update almacen set CantidadLitro='" & Me.txtTotal.Text & "'  -'" & Me.txtinventarioLitros.Text & "'  where Id_Almacen= @idAlmacen"
                Call abrirConexion()
                comando = New MySqlCommand(sql, conexion)
                comando.Parameters.AddWithValue("@idAlmacen", txtidAlmacen.Text)
                comando.ExecuteNonQuery()
            End If


        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            cerrarConexion()

        End Try
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim bcode As New Barcode128
        bcode.BarHeight = 50
        bcode.Code = txtCodigoBarra.Text
        bcode.GenerateChecksum = True
        bcode.CodeType = Barcode.CODE128
        Try
            Dim bm As New Bitmap(bcode.CreateDrawingImage(Color.Black, Color.White))
            Dim img As Image
            img = New Bitmap(bm.Width, bm.Height)
            Dim g As Graphics = Graphics.FromImage(img)
            g.FillRectangle(New SolidBrush(Color.White), 0, 0, bm.Width, bm.Height)
            g.DrawImage(bm, 0, 0)
            PictureBox1.Image = img
        Catch ex As Exception
            MsgBox("no se pudo generar el codigo de barras")

        End Try
    End Sub
End Class