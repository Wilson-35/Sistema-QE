Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class frmSeleccionarUsuario
    Public frmOrigen As String
    Dim adaptador As MySqlDataAdapter
    Dim datos As DataSet
    Private Sub frmSeleccionarusuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call buscarUsuario(" ")
    End Sub
    Private Sub buscarUsuario(condicion As String)
        Dim sql As String
        sql = "select * from consultausuario " & condicion
        Try
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "rsusuario")
            grilla.DataSource = datos.Tables("rsusuario")
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
        buscarUsuario(" where nombre like '%" & txtBuscar.Text & "%'")
    End Sub
    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            buscarUsuario(" where nombre like '%" & txtBuscar.Text & "%'")
        End If
    End Sub

    Private Sub btnSelccion_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Dim frm As frmAperturaDeCaja = CType(Owner, frmAperturaDeCaja)
        If frmOrigen = "Apertura" Then
            frm.txtCodigoUsuario.Text = grilla.Item(0, grilla.CurrentRow.Index).Value
            frm.txtNombreUsuario.Text = grilla.Item(1, grilla.CurrentRow.Index).Value
            frm.txtGApertura.Focus()
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