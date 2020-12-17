Imports MySql.Data.MySqlClient

Public Class frmcaja
    Dim total As Decimal
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter

    Private Sub frmcaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call cargarNotas()
        Call cargarCotizacion()

    End Sub

    Public Sub cargarRegistros(condicion As String)
        Dim sql As String
        datos = New DataSet
        sql = "SELECT * FROM venta " & condicion

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
        If optComprobante.Checked Then
            condicion = " where comprobante like '%" & txtBuscar.Text & "%'"
        End If

        Call cargarRegistros(condicion)
    End Sub
    Public Sub totalMonedas()
        TxtTotal.Text = Val(TxtCotiGs.Text) * Val(TxtApagar.Text)
        TxtTotalus.Text = Val(TxtApagar.Text) / Val(Txtcotius.Text)
        TxtTotalrs.Text = Val(TxtApagar.Text) / Val(Txtcotirs.Text)
        TxtTotalps.Text = Val(TxtApagar.Text) / Val(Txtcotips.Text)
    End Sub
    Public Sub cargarCotizacion()
        Dim adaptador As MySqlDataAdapter
        Dim datos As DataSet
        Dim sql As String
        Try
            sql = "select * from cotizacion where estado=1 order by id_cotización desc"
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "xCoti")
            If datos.Tables("xCoti").Rows.Count > 0 Then
                TxtCotiGs.Text = datos.Tables("xCoti").Rows(0).Item("guarani")
                Txtcotius.Text = datos.Tables("xCoti").Rows(0).Item("dolar")
                Txtcotirs.Text = datos.Tables("xCoti").Rows(0).Item("realb")
                Txtcotips.Text = datos.Tables("xCoti").Rows(0).Item("Peso")
                'Txtcoticr.Text = datos.Tables("xCoti").Rows(0).Item("cr")
            End If
            cerrarConexion()
        Catch ex As MySqlException
            MsgBox(ex.Message)
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


    Public Sub cargarNotas()
        Dim adaptador As MySqlDataAdapter
        Dim datos As DataSet
        Dim sql As String

        Try
            abrirConexion()
            sql = "select * from consultadescuentos"
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "xNotas")
            grillaPND.DataSource = datos.Tables(0)
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub insertarcobros()
        Dim sql As String
        Dim adaptador As New MySqlDataAdapter
        Dim comando As New MySqlCommand
        Try
            abrirConexion()


            sql = "insert into cobros(fecha,Cgs,Crs,Cus,Cps,idventa,subtotal,descuento,totalneto) values(@fecha,@Cgs,@Crs,@Cus,@Cps,@idventa,@subtotal,@descuento,@totalneto)"
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@fecha", txtfecha.Value)
            comando.Parameters.AddWithValue("@Cgs", txtCgs.Value)
            comando.Parameters.AddWithValue("@Crs", txtCrs.Value)
            comando.Parameters.AddWithValue("@Cus", txtCus.Value)
            comando.Parameters.AddWithValue("@Cps", txtCps.Value)
            comando.Parameters.AddWithValue("@descuento", TxtDescuento.Text)
            comando.Parameters.AddWithValue("@totalneto", TxtApagar.Text)
            comando.Parameters.AddWithValue("@idventa", txtidventa.Text)
            comando.Parameters.AddWithValue("@subtotal", TxtTotal1.Text)


            comando.ExecuteNonQuery()
            MsgBox("Registro Guardado")
            'Call Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'AbrirFormInPanel(New frmLogo)
    End Sub

    Private Sub calculoRs()
        Dim sql As String
        Dim comando As MySqlCommand
        Dim adaptador As New MySqlDataAdapter
        abrirConexion()
        Try
            Call abrirConexion() 'se abre una conexion con la base de datos
            sql = "update venta set  Crs ='" & Val(txtCrs.Value) * 0 & "' where id= @id"
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@id", txtidventa.Text)
            comando.Parameters.AddWithValue("@Crs", txtCrs.Value)

            comando.ExecuteNonQuery()

            Call insertarcobros()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try

    End Sub

    Private Sub calculoGs()
        Dim sql As String
        Dim comando As MySqlCommand
        Dim adaptador As New MySqlDataAdapter




        Try
            Call abrirConexion() 'se abre una conexion con la base de datos
            sql = "update venta set  Cgs ='" & Me.txtCgs.Value & "'  * 1   where id= @id"
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@id", txtidventa.Text)
            comando.Parameters.AddWithValue("@Cgs", txtCgs.Value)

            'txtStock.Text = Val(txtStock.Text) = Val(txtStock1.Text)
            comando.ExecuteNonQuery()

            Call insertarcobros()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try



    End Sub
    Private Sub calculoUs()
        Dim sql As String
        Dim comando As MySqlCommand
        Dim adaptador As New MySqlDataAdapter
        abrirConexion()
        Try
            Call abrirConexion() 'se abre una conexion con la base de datos
            sql = "update venta set  Cus ='" & Val(txtCus.Value) * 0 & "' where id= @id"
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@id", txtidventa.Text)
            comando.Parameters.AddWithValue("@Cus", txtCus.Value)

            comando.ExecuteNonQuery()
            Call insertarcobros()

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try

    End Sub
    Private Sub calculoPs()
        Dim sql As String
        Dim comando As MySqlCommand
        Dim adaptador As New MySqlDataAdapter
        abrirConexion()
        Try
            Call abrirConexion() 'se abre una conexion con la base de datos
            sql = "update venta set  Cps ='" & Val(txtCps.Value) * 0 & "' where id= @id"
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@id", txtidventa.Text)
            comando.Parameters.AddWithValue("@Cps", txtCps.Value)

            comando.ExecuteNonQuery()

            Call insertarcobros()

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' If Cbo1.Text = "Cobros de Creditos" Then
        'Call cargarDeudores("")
        '   Else
        'Cbo1.Text = "Cobros a Contado"
        'Call cargarNotas()

        ' End If


    End Sub

    Private Sub rptdescuento()
        If rptgs.Checked Then
            txtvuelto.Text = Val(txtEFE.Text) - Val(TxtApagar.Text)
        ElseIf rptrs.Checked Then
            txtvuelto.Text = Val(TxtApagar.Text) - Val(txtEFE.Text) * Val(Txtcotirs.Text)
        ElseIf rptus.Checked Then
            txtvuelto.Text = Val(TxtApagar.Text) - Val(txtEFE.Text) * Val(Txtcotius.Text)
        ElseIf rptps.Checked Then
            txtvuelto.Text = Val(TxtApagar.Text) - Val(txtEFE.Text) * Val(Txtcotips.Text)

        Else
            Call cargarNotas()
        End If
    End Sub
    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call ejecutarConsulta()
        End If
    End Sub

    Private Sub Btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim sql As String
        Dim adaptador As New MySqlDataAdapter
        Dim comando As New MySqlCommand
        Dim numVenta As Integer
        numVenta = txtidventa.Text
        sql = "update venta set estado=3   where id= @id"

        Try
            Call abrirConexion()
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@id", txtidventa.Text)
            comando.ExecuteNonQuery()
            MsgBox("Cobro Realizado")

            If txtCgs.Value = 0 And txtCus.Value = 0 And txtCps.Value = 0 Then
                Call calculoRs()
            ElseIf txtCgs.value = 0 And txtCrs.value = 0 And txtCps.value = 0 Then
                Call calculoUs()
            ElseIf txtCus.value = 0 And txtCrs.value = 0 And txtCps.value = 0 Then
                Call calculoGs()
            ElseIf txtCus.value = 0 And txtCgs.value = 0 And txtCrs.value = 0 Then
                Call calculoPs()
            End If


        Catch ex As Exception


        End Try
        AbrirFormInPanel(New frmcaja)

    End Sub

    Private Sub rptus_CheckedChanged(sender As Object, e As EventArgs) Handles rptus.CheckedChanged
        If rptus.Checked Then
            txtCus.Value = Val(TxtApagar.Text) / Val(Txtcotius.Text)
            txtCgs.Value = "0"
            txtCps.Value = "0"
            txtCrs.Value = "0"
        ElseIf rptps.Checked Then
            txtCps.Value = Val(TxtApagar.Text) / Val(Txtcotips.Text)
            txtCus.Value = "0"
            txtCgs.Value = "0"
            txtCrs.Value = "0"
        Else
            Call cargarNotas()
        End If
    End Sub

    Private Sub rptgs_CheckedChanged(sender As Object, e As EventArgs) Handles rptgs.CheckedChanged
        If rptgs.Checked Then
            txtCgs.Value = TxtApagar.Text
            txtCus.Value = "0"
            txtCps.Value = "0"
            txtCrs.Value = "0"
        ElseIf rptrs.Checked Then
            txtCrs.Value = Val(TxtApagar.Text) / Val(Txtcotirs.Text)
            txtCus.Value = "0"
            txtCps.Value = "0"
            txtCgs.Value = "0"
            'Call rpt()

        End If
    End Sub

    Private Sub txtEFE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEFE.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            ''Call saldo()
            Call rptdescuento()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If optComprobante.Checked Then
            Call ejecutarConsulta()
        Else
            Call cargarNotas()
        End If
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

    Private Sub grillaPND_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grillaPND.CellMouseDoubleClick
        txtidventa.Text = grillaPND.Item(0, grillaPND.CurrentRow.Index).Value
        txtNombre.Text = grillaPND.Item(1, grillaPND.CurrentRow.Index).Value
        txtruc.Text = grillaPND.Item(2, grillaPND.CurrentRow.Index).Value
        txtfecha.Value = Today
        'TxtDescuento.Text = grillaPND.Item(6, grillaPND.CurrentRow.Index).Value
        TxtTotal1.Text = grillaPND.Item(4, grillaPND.CurrentRow.Index).Value
        TxtApagar.Text = grillaPND.Item(7, grillaPND.CurrentRow.Index).Value

        txtCgs.Value = grillaPND.Item(9, grillaPND.CurrentRow.Index).Value
        txtCrs.Value = grillaPND.Item(10, grillaPND.CurrentRow.Index).Value
        txtCus.Value = grillaPND.Item(11, grillaPND.CurrentRow.Index).Value
        txtCps.Value = grillaPND.Item(12, grillaPND.CurrentRow.Index).Value

        TxtApagar.Text = TxtTotal1.Text
        total = Val(TxtApagar.Text)
        Call totalMonedas()
        'Call saldo()
    End Sub

    Private Sub TxtDescuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDescuento.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            TxtApagar.Text = Val(TxtTotal1.Text) - Val(TxtDescuento.Text)
            e.Handled = True
            total = Val(TxtApagar.Text)
            txtCgs.Value = total
            Call totalMonedas()
            'Call saldo()
        End If
    End Sub

    Private Sub TxtDescuento_Leave(sender As Object, e As EventArgs) Handles TxtDescuento.Leave
        TxtApagar.Text = Val(TxtTotal1.Text) - Val(TxtDescuento.Text)
        total = Val(TxtApagar.Text)
        txtCgs.Value = total
        Call totalMonedas()
        'Call saldo()
    End Sub
End Class