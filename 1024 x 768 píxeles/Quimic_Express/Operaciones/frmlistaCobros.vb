Imports MySql.Data.MySqlClient
Public Class frmlistaCobros
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter
    Private Sub frmlistaCobros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargarRegistros("")
    End Sub
    Public Sub cargarRegistros(condicion As String)
        Dim sql As String
        datos = New DataSet
        sql = "SELECT * FROM cobros " & condicion

        Try
            Call abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            adaptador.Fill(datos)
            grillaPND.DataSource = datos.Tables(0)
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
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
    Private Sub ejecutarConsulta()
        Dim condicion As String = ""
        If optCodigo.Checked Then
            condicion = " where id like '%" & txtBuscar.Text & "%'"
        ElseIf optidcredito.Checked Then
            condicion = " where idcredito like '%" & txtBuscar.Text & "%'"
        ElseIf optidventa.Checked Then
            condicion = " where idventa like '%" & txtBuscar.Text & "%'"
        ElseIf optfecha.Checked Then
            condicion = " where fecha like '%" & txtBuscar.Text & "%'"

        End If
        Call cargarRegistros(condicion)
    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        Call ejecutarConsulta()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Call ejecutarConsulta()
    End Sub

    Private Sub optCodigo_Click(sender As Object, e As EventArgs) Handles optCodigo.Click
        txtBuscar.Focus()
    End Sub

    Private Sub optfecha_Click(sender As Object, e As EventArgs) Handles optfecha.Click
        txtBuscar.Focus()
    End Sub

    Private Sub optidcredito_Click(sender As Object, e As EventArgs) Handles optidcredito.Click
        txtBuscar.Focus()
    End Sub

    Private Sub optidventa_Click(sender As Object, e As EventArgs) Handles optidventa.Click
        txtBuscar.Focus()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        AbrirFormInPanel(New frmOperaciones)
    End Sub
End Class