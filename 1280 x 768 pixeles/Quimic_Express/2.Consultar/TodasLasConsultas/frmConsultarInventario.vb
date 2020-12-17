﻿Imports MySql.Data.MySqlClient
Public Class frmConsultarInventario
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter
    Private Sub frmConsultarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargarRegistros("")
        txtBuscar.Focus()
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
    Public Sub cargarRegistros(condicion As String)
        Dim sql As String
        datos = New DataSet
        sql = "SELECT * FROM consultainventario " & condicion

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
    Private Sub ejecutarConsulta()
        Dim condicion As String = ""
        If rdbCodigo.Checked Then
            condicion = " where codigo like '%" & txtBuscar.Text & "%'"
        ElseIf rdbCodigoBarra.Checked Then
            condicion = " where codigobarra like '%" & txtBuscar.Text & "%'"
        ElseIf rdbDescripcion.Checked Then
            condicion = " where Descripción like '%" & txtBuscar.Text & "%'"
        ElseIf rdbMarca.Checked Then
            condicion = " where marca like '%" & txtBuscar.Text & "%'"
        ElseIf rdbCategoria.Checked Then
            condicion = " where categoria like '%" & txtBuscar.Text & "%'"
        ElseIf rdbProveedor.Checked Then
            condicion = " where proveedor like '%" & txtBuscar.Text & "%'"
        ElseIf rdbStock.Checked Then
            condicion = " where stock like '%" & txtBuscar.Text & "%'"
        End If
        Call cargarRegistros(condicion)
    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call ejecutarConsulta()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Call ejecutarConsulta()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim sql As String
        Dim codigo As Integer
        Dim comando As New MySqlCommand
        codigo = grilla.Item(0, grilla.CurrentRow.Index).Value
        Try
            If MsgBox("Desea eliminar el registro", vbYesNo, "Confirmar") = MsgBoxResult.Yes Then
                sql = "delete from inventario where id_Inventario=" & codigo
                abrirConexion()
                comando = New MySqlCommand(sql, conexion)
                comando.ExecuteNonQuery()
                MsgBox("Registro Eliminado")
                Call cargarRegistros("")
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        AbrirFormInPanel(New frmConsultar)
    End Sub

    Private Sub rdbCodigo_Click(sender As Object, e As EventArgs) Handles rdbCodigo.Click
        txtBuscar.Focus()
    End Sub

    Private Sub rdbCodigoBarra_Click(sender As Object, e As EventArgs) Handles rdbCodigoBarra.Click
        txtBuscar.Focus()
    End Sub

    Private Sub rdbDescripcion_Click(sender As Object, e As EventArgs) Handles rdbDescripcion.Click
        txtBuscar.Focus()
    End Sub

    Private Sub rdbMarca_Click(sender As Object, e As EventArgs) Handles rdbMarca.Click
        txtBuscar.Focus()
    End Sub

    Private Sub rdbCategoria_Click(sender As Object, e As EventArgs) Handles rdbCategoria.Click
        txtBuscar.Focus()
    End Sub

    Private Sub rdbProveedor_Click(sender As Object, e As EventArgs) Handles rdbProveedor.Click
        txtBuscar.Focus()
    End Sub

    Private Sub rdbStock_Click(sender As Object, e As EventArgs) Handles rdbStock.Click
        txtBuscar.Focus()
    End Sub

    Private Sub btnReporto_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        FrmInformeInventario.Show()
    End Sub
End Class