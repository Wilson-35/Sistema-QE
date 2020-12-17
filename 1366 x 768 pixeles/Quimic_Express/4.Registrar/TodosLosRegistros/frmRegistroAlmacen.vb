Imports MySql.Data.MySqlClient
Imports iTextSharp.text.pdf
Imports System.Data.OleDb
Public Class frmRegistroAlmacen
    Dim adaptador As MySqlDataAdapter
    Dim comando As MySqlCommand
    Dim datos As DataSet

    Private Sub frmRegistroAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        operacionABM = "nuevo"
        Try
            grdAlmacen.DataSource = Almacen.RecuperarTodosLosAlmacenes
        Catch ex As Exception
            MessageBox.Show("Ocurrio Este Error: " & ex.Message)
        End Try

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call CargarNuevo()
    End Sub

    Private Sub CargarNuevo()
        Try
            Dim NuevoAlmacen As New Almacen
            Dim Id_Almacen As Integer

            NuevoAlmacen.Id_Almacen = txtCodigo.Text.Trim
            NuevoAlmacen.Descripción = txtDescripcion.Text.Trim
            NuevoAlmacen.Marca = txtMarca.Text.Trim
            NuevoAlmacen.Categoria = txtCategoria.Text.Trim
            NuevoAlmacen.CantidadLitro = txtCantidadLitro.Text.Trim
            NuevoAlmacen.CantidadKilo = txtCantidadKilos.Text.Trim
            NuevoAlmacen.PrecioCosto = txtPrecioCosto.Text.Trim
            NuevoAlmacen.PrecioReventa = txtPrecioReventa.Text.Trim
            NuevoAlmacen.PrecioLitro = txtPrecioLitro.Text.Trim
            NuevoAlmacen.Fecha = dtpFecha.Value


            If txtCodigo.Text = 0 Then
                Id_Almacen = Almacen.InsertarAlmacen(NuevoAlmacen)
            Else
                Almacen.EditarAlmacen(NuevoAlmacen)
            End If

            Call limpiarItemsDeAlmacen()
            grdAlmacen.DataSource = Almacen.RecuperarTodosLosAlmacenes
            btnCancelar.Focus()
            MessageBox.Show("Operacion Realizada")
        Catch ex As MySqlException
            MessageBox.Show("Ocurrio Este Error: " & ex.Message)
        End Try
    End Sub

    Public Sub limpiarItemsDeAlmacen()
        txtCodigo.Text = 0
        txtDescripcion.Text = ""
        txtMarca.Value = 0
        txtNombreMarca.Text = ""
        txtCategoria.Value = 0
        txtNombreCategoria.Text = ""
        txtCantidadLitro.Value = 0
        txtCantidadKilos.Value = 0
        txtPrecioCosto.Value = 0
        txtPrecioReventa.Value = 0
        txtPrecioLitro.Value = 0
        dtpFecha.Value = Now
        txtDescripcion.Focus()
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
                txtCantidadLitro.Focus()
            Else
                MessageBox.Show("Categoria no Encontrada", "QUIMIC EXPRESS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show("Abrir Formulario", "QUIMIC EXPRESS", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Dim frm As frmSeleccionarCategoriaAlmacen = New frmSeleccionarCategoriaAlmacen
                AddOwnedForm(frm)
                frm.Show()
                txtCantidadLitro.Focus()
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
            sql = "select * from marca where id_Marca= " & codigo
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
                Dim frm As frmSeleccionarMarcaAlmacen = New frmSeleccionarMarcaAlmacen
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


    Private Sub txtMarca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMarca.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If IsNumeric(txtMarca.Text) = False Or txtMarca.Text = "" Then
                MessageBox.Show("Abrir Formulario", "QUIMIC EXPRESS", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Else
                Call SeleccionarMarca(txtMarca.Text)
            End If

            If IsNumeric(txtMarca.Text) = False Or txtMarca.Text = "" Then
                Dim frm As frmSeleccionarMarcaAlmacen = New frmSeleccionarMarcaAlmacen
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
                Dim frm As frmSeleccionarCategoriaAlmacen = New frmSeleccionarCategoriaAlmacen
                AddOwnedForm(frm)
                frm.Show()
                txtCantidadLitro.Focus()
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
        AbrirFormInPanel(New frmRegistro)

    End Sub

    Private Sub txtDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtMarca.Focus()
        End If
    End Sub

    Private Sub txtMarca_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMarca.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCategoria.Focus()
        End If
    End Sub

    Private Sub txtCantidadLitro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCantidadLitro.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCantidadKilos.Focus()
        End If
    End Sub

    Private Sub txtCantidadBidon_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCantidadKilos.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPrecioCosto.Focus()
        End If
    End Sub

    Private Sub txtPrecioCosto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrecioCosto.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPrecioReventa.Focus()
        End If
    End Sub

    Private Sub txtPrecioReventa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrecioReventa.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPrecioLitro.Focus()
        End If
    End Sub

    Private Sub txtPrecioLitro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrecioLitro.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call CargarNuevo()
        End If
    End Sub

    Private Sub grdAlmacen_SelectionChanged(sender As Object, e As EventArgs) Handles grdAlmacen.SelectionChanged
        If grdAlmacen.SelectedRows.Count > 0 Then
            Dim Id_Almacen As Integer = grdAlmacen.SelectedRows(0).Cells(0).Value
            Dim AlmacenElegido As Almacen
            AlmacenElegido = Almacen.RecuperarUnAlmacen(Id_Almacen)

            txtCodigo.Text = AlmacenElegido.Id_Almacen
            txtDescripcion.Text = AlmacenElegido.Descripción
            txtMarca.Text = AlmacenElegido.Marca
            txtCategoria.Text = AlmacenElegido.Categoria
            txtCantidadLitro.Text = AlmacenElegido.CantidadLitro
            txtCantidadKilos.Text = AlmacenElegido.CantidadKilo
            txtPrecioCosto.Text = AlmacenElegido.PrecioCosto
            txtPrecioReventa.Text = AlmacenElegido.PrecioReventa
            txtPrecioLitro.Text = AlmacenElegido.PrecioLitro
            dtpFecha.Value = AlmacenElegido.Fecha
            Call SeleccionarMarca(txtMarca.Text)
            Call SeleccionarCategoria(txtCategoria.Text)
        End If
    End Sub

    Private Sub btnEliminar_Click_1(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("Quiere Eliminar el Registros?", "Eliminar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim NuevoAlmacen As New Almacen
            NuevoAlmacen.Id_Almacen = txtCodigo.Text
            Almacen.EliminarAlmacen(NuevoAlmacen)

            limpiarItemsDeAlmacen()
            grdAlmacen.DataSource = Almacen.RecuperarTodosLosAlmacenes

            MessageBox.Show("Operacion Realizada")
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Call limpiarItemsDeAlmacen()
    End Sub
End Class