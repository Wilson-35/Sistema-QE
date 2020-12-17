Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class frmSeleccionarProveedorInventario
    Private Sub frmSeleccionarProveedorInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargarRegistros("")
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter
    Public Sub cargarRegistros(condicion As String)
        Dim sql As String
        datos = New DataSet
        sql = "SELECT * FROM consultaproveedor " & condicion
        Try
            Call abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            adaptador.Fill(datos)
            grilla.DataSource = datos.Tables(0)
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Sub
    Private Sub buscarRegistros(condicion As String)
        Dim sql As String
        sql = "select * from consultaproveedor" & condicion
        Try
            Call abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "consultaproveedor")
            If datos.Tables("consultaproveedor").Rows.Count > 0 Then
                grilla.DataSource = datos.Tables("consultaproveedor")
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ejecutarConsulta()
        Dim condicion As String = ""
        condicion = " where nombre like '%" & txtBuscar.Text & "%'"
        Call cargarRegistros(condicion)
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim condicion As String = ""
        condicion = " where nombre like '%" & txtBuscar.Text & "%'"
        Call cargarRegistros(condicion)
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub grilla_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla.CellDoubleClick
        If operacionABM = "editar" Then
            Dim frm As frmEditarInventario = CType(Owner, frmEditarInventario)
            frm.txtProveedor.Text = grilla.CurrentRow.Cells(0).Value.ToString()
            frm.txtNombreProveedor.Text = grilla.CurrentRow.Cells(1).Value.ToString()
        ElseIf operacionABM = "nuevo" Then
            Dim frm As frmRegistroInventario = CType(Owner, frmRegistroInventario)
            frm.txtProveedor.Text = grilla.CurrentRow.Cells(0).Value.ToString()
            frm.txtNombreProveedor.Text = grilla.CurrentRow.Cells(1).Value.ToString()
        ElseIf operacionABM = "almacen" Then
            Dim frm As frmAlmacen_Inventario = CType(Owner, frmAlmacen_Inventario)
            frm.txtProveedor.Text = grilla.CurrentRow.Cells(0).Value.ToString()
            frm.txtNombreProveedor.Text = grilla.CurrentRow.Cells(1).Value.ToString()
        End If
        Me.Close()
    End Sub
    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim condicion As String = ""
            condicion = " where nombre like '%" & txtBuscar.Text & "%'"
            Call cargarRegistros(condicion)
        End If
    End Sub

    Private Sub lbltitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles lbltitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelContenedor.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class