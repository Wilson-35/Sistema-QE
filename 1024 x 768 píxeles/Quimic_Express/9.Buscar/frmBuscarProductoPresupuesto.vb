Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class frmBuscarProductoPresupuesto
    Public frmOrigen As String
    Dim adaptador As MySqlDataAdapter
    Dim datos As DataSet
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub frmSeleccionarVehiculo_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub lbltitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles lbltitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub frmBuscarProductoPresupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call buscarProducto("")
    End Sub
    Private Sub buscarProducto(condicion As String)
        Dim sql As String
        sql = "select * from consultainventario " & condicion
        Try
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "rsInventario")
            grilla.DataSource = datos.Tables("rsInventario")
            conexion.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ejecutarConsulta()
        Dim condicion As String = ""
        If optCodigo.Checked Then
            condicion = " where Codigo like '%" & txtBuscar.Text & "%'"
        ElseIf optCodigoBarra.Checked Then
            condicion = " where CodigoBarra like '%" & txtBuscar.Text & "%'"
        ElseIf optDescripcion.Checked Then
            condicion = " where Descripción like '%" & txtBuscar.Text & "%'"
        ElseIf optMarca.Checked Then
            condicion = " where Marca like '%" & txtBuscar.Text & "%'"
        ElseIf optCategoria.Checked Then
            condicion = " where Categoria like '%" & txtBuscar.Text & "%'"
        ElseIf optProveedor.Checked Then
            condicion = " where Proveedor like '%" & txtBuscar.Text & "%'"
        End If
        Call buscarProducto(condicion)
    End Sub

    Private Sub optCodigo_Click(sender As Object, e As EventArgs) Handles optCodigo.Click
        txtBuscar.Focus()
    End Sub
    Private Sub optCodigoBarra_Click(sender As Object, e As EventArgs) Handles optCodigoBarra.Click
        txtBuscar.Focus()
    End Sub
    Private Sub optDescripcion_Click(sender As Object, e As EventArgs) Handles optDescripcion.Click
        txtBuscar.Focus()
    End Sub
    Private Sub optMarca_Click(sender As Object, e As EventArgs) Handles optMarca.Click
        txtBuscar.Focus()
    End Sub
    Private Sub optCategoria_Click(sender As Object, e As EventArgs) Handles optCategoria.Click
        txtBuscar.Focus()
    End Sub
    Private Sub optProveedor_Click(sender As Object, e As EventArgs) Handles optProveedor.Click
        txtBuscar.Focus()
    End Sub
    'Private Sub optcategoria_CheckedChanged(sender As Object, e As EventArgs) Handles optCategoria.CheckedChanged
    '    txtBuscar.Focus()
    'End Sub
    'Private Sub optestado_CheckedChanged(sender As Object, e As EventArgs) Handles optestado.CheckedChanged
    '    txtBuscar.Focus()
    'End Sub



    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call ejecutarConsulta()
        End If
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Dim frm As frmVentaPresupuesto = CType(Owner, frmVentaPresupuesto)
        If frmOrigen = "venta" Then
            frm.txtIdProducto.Text = grilla.Item(0, grilla.CurrentRow.Index).Value
            frm.txtDescripcion.Text = grilla.Item(2, grilla.CurrentRow.Index).Value
            frm.txtStock.Text = grilla.Item(8, grilla.CurrentRow.Index).Value
            frm.txtPrecio.Text = grilla.Item(7, grilla.CurrentRow.Index).Value
            frm.txtCantidad.Focus()
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click_1(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Call ejecutarConsulta()
    End Sub
End Class