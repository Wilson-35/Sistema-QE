Imports MySql.Data.MySqlClient
Public Class frmConsultarDeudor
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter

    Private Sub frmConsultarDeudor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargarRegistros("")
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
    Public Sub cargarRegistros(condicion As String)
        Dim sql As String
        datos = New DataSet
        sql = "SELECT * FROM deudores " & condicion

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

    Private Sub ejecutarConsulta()
        Dim condicion As String = ""
        If optCodigo.Checked Then
            condicion = " where id like '%" & txtBuscar.Text & "%'"
        ElseIf optNombres.Checked Then
            condicion = " where nombres like '%" & txtBuscar.Text & "%'"


        ElseIf optRuc.Checked Then
            condicion = " where ruc like '%" & txtBuscar.Text & "%'"

        End If
        Call cargarRegistros(condicion)
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        FrmInformeDeudores.Show()
    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        Call ejecutarConsulta()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim sql As String
        Dim codigo As Integer
        Dim comando As New MySqlCommand
        codigo = grillaPND.Item(0, grillaPND.CurrentRow.Index).Value
        Try
            If MsgBox("Desea eliminar el registro", vbYesNo, "Confirmar") = MsgBoxResult.Yes Then
                sql = "delete from deudores where id=" & codigo
                abrirConexion()
                comando = New MySqlCommand(sql, conexion)
                comando.ExecuteNonQuery()
                MsgBox("Deudor eliminado")
                Call cargarRegistros("")
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Call ejecutarConsulta()
    End Sub

    Private Sub optCodigo_Click(sender As Object, e As EventArgs) Handles optCodigo.Click
        txtBuscar.Focus()
    End Sub

    Private Sub optNombres_Click(sender As Object, e As EventArgs) Handles optNombres.Click
        txtBuscar.Focus()
    End Sub

    Private Sub optRuc_Click(sender As Object, e As EventArgs) Handles optRuc.Click
        txtBuscar.Focus()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class