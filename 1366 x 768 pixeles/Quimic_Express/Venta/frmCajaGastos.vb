Imports MySql.Data.MySqlClient
Public Class frmCajaGastos
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter
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
    Private Sub btnseleccionar_Click(sender As Object, e As EventArgs) Handles btnseleccionar.Click
        If Cbo1.Text = "Cobros de Creditos" Then
            Call AbrirFormInPanel(New frmCajaCredito)
        ElseIf Cbo1.Text = "Cobros a Contado" Then
            Call AbrirFormInPanel(New frmcaja)
        ElseIf Cbo1.Text = "Pagos de Caja" Then
            Call AbrirFormInPanel(New frmCajaGastos)
        End If

        Me.Close()

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim sql As String
        Dim adaptador As New MySqlDataAdapter
        Dim comando As New MySqlCommand
        Dim numPago As Integer

        numPago = txtid.Text

        sql = "update gastos set estado= 1 where id_Gasto= @id"

        Try
            abrirConexion()
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@id", txtid.Text)

            comando.ExecuteNonQuery()
            MsgBox("Nota Pagada")
            Call cargarRegistros("")

            txtid.Text = ""
            dpfecha.Value = Today

            txtDescripcion.Text = ""
            txtGs.Value = 0
            txtUs.Value = 0
            txtRs.Value = 0
            txtPs.Value = 0
            txtEstado.Text = ""

        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            cerrarConexion()

        End Try
        AbrirFormInPanel(New frmCajaGastos)
    End Sub



    Private Sub frmCajaGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargarRegistros("")
        Call cargarCotizacion()

    End Sub

    Public Sub cargarRegistros(condicion As String)
        Dim sql As String
        datos = New DataSet

        sql = "select * from gastos where estado = 0 " & condicion

        Try
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            adaptador.Fill(datos)
            grilla.DataSource = datos.Tables(0)

        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            cerrarConexion()

        End Try
    End Sub
    Public Sub cargarCotizacion()
        Dim adaptador As MySqlDataAdapter
        Dim datos As DataSet
        Dim sql As String
        Try
            sql = "Select * from cotizacion where estado=1 order by id_cotización desc"
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "xCoti")
            If datos.Tables("xCoti").Rows.Count > 0 Then
                TxtCotiGs.Text = datos.Tables("xCoti").Rows(0).Item("guarani")
                Txtcotius.Text = datos.Tables("xCoti").Rows(0).Item("dolar")
                Txtcotirs.Text = datos.Tables("xCoti").Rows(0).Item("realb")
                'Txtcotips.Text = datos.Tables("xCoti").Rows(0).Item("ps")
                'Txtcoticr.Text = datos.Tables("xCoti").Rows(0).Item("cr")
            End If
            cerrarConexion()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ejecutarConsulta()
        Dim condicion As String = ""
        If optCodigo.Checked Then
            condicion = " where id_Gasto like '%" & txtBuscar.Text & "%'"
        ElseIf optComprobante.Checked Then
            condicion = " where comprobante like '%" & txtBuscar.Text & "%'"
        ElseIf optDescripcion.Checked Then
            condicion = " where descripción like '%" & txtBuscar.Text & "%'"
        End If

        Call cargarRegistros(condicion)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Call ejecutarConsulta()

    End Sub

    Private Sub grilla_SelectionChanged(sender As Object, e As EventArgs) Handles grilla.SelectionChanged
        txtid.Text = grilla.Item(0, grilla.CurrentRow.Index).Value

        dpfecha.Value = grilla.Item(1, grilla.CurrentRow.Index).Value
        txtDescripcion.Text = grilla.Item(2, grilla.CurrentRow.Index).Value
        txtGs.Value = grilla.Item(3, grilla.CurrentRow.Index).Value
        txtUs.Value = grilla.Item(4, grilla.CurrentRow.Index).Value
        txtRs.Value = grilla.Item(5, grilla.CurrentRow.Index).Value
        txtPs.Value = grilla.Item(6, grilla.CurrentRow.Index).Value
        txtEstado.Text = grilla.Item(7, grilla.CurrentRow.Index).Value

    End Sub


End Class