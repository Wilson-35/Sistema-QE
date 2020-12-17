Imports MySql.Data.MySqlClient
Public Class frmEditarInventario
    Private Sub frmEditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodigoBarra.Focus()

        If operacionABM = "editar" Then
            lbltitulo.Text = "Consulta de Inventario - Editar: " & codigoABM
            Call buscarRegistro(codigoABM)
        End If
    End Sub

    Dim adaptador As MySqlDataAdapter
    Dim comando As MySqlCommand
    Dim datos As DataSet


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
    Private Sub buscarRegistro(codigo As Integer)
        Dim sql As String
        sql = "select * from inventario where id_inventario=" & codigo
        Try
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "xalmacen")
            txtCodigo.Text = datos.Tables("xalmacen").Rows(0).Item("id_inventario")
            txtCodigoBarra.Text = datos.Tables("xalmacen").Rows(0).Item("idcodigobarra")
            txtDescripcion.Text = datos.Tables("xalmacen").Rows(0).Item("Descripción")
            txtMarca.Text = datos.Tables("xalmacen").Rows(0).Item("idMarca")
            txtCategoria.Text = datos.Tables("xalmacen").Rows(0).Item("idCategoria")
            txtProveedor.Text = datos.Tables("xalmacen").Rows(0).Item("idproveedor")
            txtcosto.Text = datos.Tables("xalmacen").Rows(0).Item("preciominimo")
            txtnormal.Text = datos.Tables("xalmacen").Rows(0).Item("precioNormal")
            txtStock.Text = datos.Tables("xalmacen").Rows(0).Item("stock")
            Call SeleccionarMarca(txtMarca.Text)
            Call SeleccionarCategoria(txtCategoria.Text)
            Call SeleccionarProveedor(txtProveedor.Text)
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim sql As String
        'If Me.ValidateChildren = True And txtmarca.Text <> "" And txtmodelo.Text <> "" And txtcategoria.Text <> "" And txtaño.Text <> "" And txtmatricula.Text <> "" And txtchasis.Text <> "" And txtVCostoOrigen.Text <> "" And txtVDespacho.Text <> "" And txtVFlete.Text <> "" And txtVCambioVolante.Text <> "" And txtVReformas.Text <> "" And txtCostoFinal.Text <> "" And txtPrecioMinimo.Text <> "" And txtPrecioNormal.Text <> "" And txtestado.Text <> "" And txtidusuario.Text <> "" Then
        Try
            abrirConexion()

            sql = "update inventario set idcodigobarra= @idcodigobarra, Descripción= @Descripción, idmarca=@idmarca,idcategoria=@idcategoria, idproveedor=@idproveedor, preciominimo=@precioMinimo, precioNormal=@precioNormal, stock=@stock where id=@id"
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@id_inventario", txtCodigo.Text)
            comando.Parameters.AddWithValue("@idcodigobarra", txtCodigoBarra.Text)
            comando.Parameters.AddWithValue("@Descripción", txtDescripcion.Text)
            comando.Parameters.AddWithValue("@idmarca", txtMarca.Text)
            comando.Parameters.AddWithValue("@idcategoria", txtCategoria.Text)
            comando.Parameters.AddWithValue("@idproveedor", txtProveedor.Text)
            comando.Parameters.AddWithValue("@precioMinimo", txtcosto.Text)
            comando.Parameters.AddWithValue("@precioNormal", txtnormal.Text)
            comando.Parameters.AddWithValue("@stock", txtStock.Text)
            comando.ExecuteNonQuery()
            MsgBox("Registro Guardado")
            Me.Close()
            frmConsultarAlmacen.cargarRegistros("")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Else
        '    MessageBox.Show("Debe Rellenar Todos Los Campos", "Registro de Usuario ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
        AbrirFormInPanel(New frmConsultarInventario)
    End Sub

    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        AbrirFormInPanel(New frmConsultarInventario)
    End Sub
    Private Sub SeleccionarCategoria(codigo As Integer)
        Dim sql As String
        Try
            sql = "select * from categoria where id= " & codigo
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
            sql = "select * from marca where id= " & codigo
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
            sql = "select * from proveedor where id= " & codigo
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "proveedor")
            If datos.Tables("proveedor").Rows.Count > 0 Then
                txtNombreProveedor.Text = datos.Tables("proveedor").Rows(0).Item("nombre")
                txtcosto.Focus()
            Else
                MessageBox.Show("Marca no Encontrada", "QUIMIC EXPRESS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show("Abrir Formulario", "QUIMIC EXPRESS", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Dim frm As frmSeleccionarProveedorInventario = New frmSeleccionarProveedorInventario
                AddOwnedForm(frm)
                frm.Show()
                txtcosto.Focus()
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Sub

    Private Sub txtcategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCategoria.KeyPress
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

    Private Sub txtmarca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMarca.KeyPress
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
                txtcosto.Focus()
            End If
        End If
    End Sub
End Class