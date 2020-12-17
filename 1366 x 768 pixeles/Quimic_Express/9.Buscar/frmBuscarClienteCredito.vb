Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class frmBuscarClienteCredito
    Public frmOrigen As String
    Dim adaptador As MySqlDataAdapter
    Dim datos As DataSet
    Private Sub frmBuscarClienteCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call buscarCliente(" ")
    End Sub
    Private Sub buscarCliente(condicion As String)
        Dim sql As String
        sql = "select * from cliente " & condicion
        Try
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "rsCliente")
            grilla.DataSource = datos.Tables("rsCliente")
            conexion.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscarCliente(" where ruc like '%" & txtBuscar.Text & "%'")
    End Sub
    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            buscarCliente(" where ruc like '%" & txtBuscar.Text & "%'")
        End If
    End Sub

    Private Sub btnSeleccion_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Dim frmx As frmVentaCredito = CType(Owner, frmVentaCredito)
        If frmOrigen = "venta" Then
            frmx.txtIdCliente.Text = grilla.Item(0, grilla.CurrentRow.Index).Value
            frmx.txtNomCliente.Text = grilla.Item(1, grilla.CurrentRow.Index).Value
            frmx.txtRucCliente.Text = grilla.Item(4, grilla.CurrentRow.Index).Value
            frmx.txtIdProducto.Focus()
            Me.Close()
        End If
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub lbltitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles lbltitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PanelContenedor_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelContenedor.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class