Imports MySql.Data.MySqlClient

Public Class frmCajaCredito
    Dim total As Decimal
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter


    Private Sub insertarcobros()
        Dim sql As String
        Dim adaptador As New MySqlDataAdapter
        Dim comando As New MySqlCommand
        Try
                abrirConexion()


            sql = "insert into cobros(fecha,Cgs,Crs,Cus,Cps,idcredito,idventa,totalneto) values(@fecha,@Cgs,@Crs,@Cus,@Cps,@idcredito,@idventa,@totalneto)"
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@fecha", dpfecha.Value)
            comando.Parameters.AddWithValue("@Cgs", txtCgs.value)
            comando.Parameters.AddWithValue("@Crs", txtCrs.Value)
            comando.Parameters.AddWithValue("@Cus", txtCus.Value)
            comando.Parameters.AddWithValue("@Cps", txtCps.Value)
            comando.Parameters.AddWithValue("@idcredito", txtidCredito.Text)
            comando.Parameters.AddWithValue("@idventa", TxtidVenta.Text)
            comando.Parameters.AddWithValue("@totalneto", txtMensualidad.Text)



            comando.ExecuteNonQuery()
            MsgBox("Registro Guardado")
            frmInformeNotaCobrada.Show()
            'Call Limpiar()
        Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        'AbrirFormInPanel(New frmLogo)
    End Sub





    Private Sub SumaCuota()
        Dim sql As String
        Dim comando As MySqlCommand
        Dim adaptador As New MySqlDataAdapter

        Try
            Call abrirConexion() 'se abre una conexion con la base de datos
            sql = "update deudores set  cuotasPagadas ='" & Me.txtCuotaNro.Text & "'  +1  where id= @id"
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@id", txtidCredito.Text)
            'txtStock.Text = Val(txtStock.Text) = Val(txtStock1.Text)
            comando.ExecuteNonQuery()
            MsgBox("Registro Guardado")

            Call insertarcobros()


            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try



    End Sub

    Private Sub restadeuda()
        Dim sql As String
        Dim comando As MySqlCommand
        Dim adaptador As New MySqlDataAdapter




        Try
            Call abrirConexion()
            sql = "update deudores set totaldeuda = '" & Me.txtTotalDeuda.Value & "' - '" & Me.txtCgs.Value & "'  where id= @id"


            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@id", txtidCredito.Text)
            'txtStock.Text = Val(txtStock.Text) = Val(txtStock1.Text)
            comando.ExecuteNonQuery()
            Call calculoGs()

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try



    End Sub

    Private Sub restadeudaRs()
        Dim sql As String
        Dim comando As MySqlCommand
        Dim adaptador As New MySqlDataAdapter
        Dim calculo As String

        calculo = Val(txtCrs.Value) * Val(Txtcotirs.Text)


        Try
            sql = "update deudores set  totaldeuda = '" & Me.txtTotalDeuda.Value & "' - '" & calculo & "' where id= @id"
            Call abrirConexion() 'se abre una conexion con la base de datos
            '" & Me.txtTotalDeuda.Text & "'
            'Txtcotirs.Text = Val(Txtcotirs.Text) = Val(txtCgs.Value)
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@id", txtidCredito.Text)
            'txtStock.Text = Val(txtStock.Text) = Val(txtStock1.Text)
            comando.ExecuteNonQuery()

            'Call SumaCuota()
            Call calculoRs()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try



    End Sub
    Private Sub calculoRs()
        Dim sql As String
        Dim comando As MySqlCommand
        Dim adaptador As New MySqlDataAdapter
        abrirConexion()
        Try
            Call abrirConexion() 'se abre una conexion con la base de datos
            sql = "update deudores set  Crs ='" & Val(txtCrs.Value) * 0 & "' where id= @id"
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@id", txtidCredito.Text)
            comando.Parameters.AddWithValue("@Crs", txtCrs.Value)

            comando.ExecuteNonQuery()

            Call SumaCuota()
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
            sql = "update deudores set  Cgs ='" & Me.txtCgs.Value & "'  * 0  where id= @id"
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@id", txtidCredito.Text)
            comando.Parameters.AddWithValue("@Cgs", txtCgs.Value)

            'txtStock.Text = Val(txtStock.Text) = Val(txtStock1.Text)
            comando.ExecuteNonQuery()

            Call SumaCuota()
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
            sql = "update deudores set  Cus ='" & Val(txtCus.Value) * 0 & "' where id= @id"
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@id", txtidCredito.Text)
            comando.Parameters.AddWithValue("@Cus", txtCus.Value)

            comando.ExecuteNonQuery()


            Call SumaCuota()
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
            sql = "update deudores set  Cps ='" & Val(txtCps.Value) * 0 & "' where id= @id"
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@id", txtidCredito.Text)
            comando.Parameters.AddWithValue("@Cps", txtCps.Value)

            comando.ExecuteNonQuery()


            Call SumaCuota()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try

    End Sub
    Private Sub restadeudaUs()
        Dim sql As String
        Dim comando As MySqlCommand
        Dim adaptador As New MySqlDataAdapter
        Dim calculo As String

        calculo = Val(txtCus.Value) * Val(Txtcotius.Text)



        Try
            sql = "update deudores set  totaldeuda = '" & Me.txtTotalDeuda.Value & "' - '" & calculo & "' where id= @id"
            Call abrirConexion() 'se abre una conexion con la base de datos
            '" & Me.txtTotalDeuda.Text & "'
            'Txtcotius.Text = Val(Txtcotius.Text) = Val(txtCgs.Text)
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@id", txtidCredito.Text)
            'txtStock.Text = Val(txtStock.Text) = Val(txtStock1.Text)
            comando.ExecuteNonQuery()
            Call calculoUs()
            'Call SumaCuota()

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try

    End Sub
    Private Sub restadeudaPs()
        Dim sql As String
        Dim comando As MySqlCommand
        Dim adaptador As New MySqlDataAdapter
        Dim calculo As String

        calculo = Val(txtCps.Value) * Val(Txtcotips.Text)



        Try
            sql = "update deudores set  totaldeuda = '" & Me.txtTotalDeuda.Value & "' - '" & calculo & "' where id= @id"
            Call abrirConexion() 'se abre una conexion con la base de datos
            '" & Me.txtTotalDeuda.Text & "'
            'Txtcotius.Text = Val(Txtcotius.Text) = Val(txtCgs.Text)
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@id", txtidCredito.Text)
            'txtStock.Text = Val(txtStock.Text) = Val(txtStock1.Text)
            comando.ExecuteNonQuery()
            Call calculoPs()
            'Call SumaCuota()

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try

    End Sub



    Public Sub totalMonedas()
        TxtTotal.Value = Val(TxtCotiGs.Text) * Val(txtMensualidad.Text)
        TxtTotalus.Value = Val(txtMensualidad.Text) / Val(Txtcotius.Text)
        TxtTotalrs.Value = Val(txtMensualidad.Text) / Val(Txtcotirs.Text)
        TxtTotalps.Value = Val(txtMensualidad.Text) / Val(Txtcotips.Text)


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

        sql = "Select * FROM consultadeudores " & condicion

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
                Txtcotips.Text = datos.Tables("xCoti").Rows(0).Item("Peso")
                'Txtcoticr.Text = datos.Tables("xCoti").Rows(0).Item("cr")
            End If
            cerrarConexion()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ejecutarConsulta()
        Dim condicion As String = ""

        If optComprobante.Checked Then
            condicion = " where comprobante like '%" & txtBuscar.Text & "%'"
        End If
        Call cargarRegistros(condicion)
    End Sub
    Private Sub frmcajacredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call cargarDeudores("")
        Call cargarCotizacion()
        Call cargarRegistros("")
    End Sub

    Private Sub grillaPND_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        'txtidCredito.Text = grillaPND.Item(0, grillaPND.CurrentRow.Index).Value
        'txtNombres.Text = grillaPND.Item(4, grillaPND.CurrentRow.Index).Value
        'TxtidVenta.Text = grillaPND.Item(2, grillaPND.CurrentRow.Index).Value
        'txtTotalDeuda.Text = grillaPND.Item(11, grillaPND.CurrentRow.Index).Value
        'txtMensualidad.Text = grillaPND.Item(12, grillaPND.CurrentRow.Index).Value
        'txtcantidadcuota.Text = grillaPND.Item(13, grillaPND.CurrentRow.Index).Value
        'txtIdCliente.Text = grillaPND.Item(3, grillaPND.CurrentRow.Index).Value
        'txtCuotaNro.Text = grillaPND.Item(15, grillaPND.CurrentRow.Index).Value
        'txtRuc.Text = grillaPND.Item(5, grillaPND.CurrentRow.Index).Value
        'txtCgs.Text = grillaPND.Item(16, grillaPND.CurrentRow.Index).Value
        'txtCrs.Text = grillaPND.Item(17, grillaPND.CurrentRow.Index).Value
        'txtCus.Text = grillaPND.Item(18, grillaPND.CurrentRow.Index).Value
        'txtCps.Text = grillaPND.Item(19, grillaPND.CurrentRow.Index).Value
        'dpfecha.Value = grillaPND.Item(6, grillaPND.CurrentRow.Index).Value
        ''TxtApagar.Text = TxtApagar.Text
        ''total = Val(TxtApagar.Text)
        'Call totalMonedas()
    End Sub

    Private Sub guardar()
        Dim sql As String
        Dim adaptador As New MySqlDataAdapter
        Dim comando As New MySqlCommand

        If txtCuotaNro.Text = txtcantidadcuota.Text - 1 Then
            sql = "update deudores set estado  = 3  where id= @id"

        Else
            sql = "update deudores set estado  = 2  where id= @id"

        End If
        Try
            Call abrirConexion()
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@id", txtidCredito.Text)

            comando.ExecuteNonQuery()
            MsgBox("Cobro Realizado")


            If txtCgs.Value = 0 And txtCus.Value = 0 And txtCps.Value = 0 Then
                Call restadeudaRs()
            ElseIf txtCgs.value = 0 And txtCrs.value = 0 And txtCps.value = 0 Then
                Call restadeudaUs()
            ElseIf txtCus.value = 0 And txtCrs.value = 0 And txtCps.value = 0 Then
                Call restadeuda()
            ElseIf txtCus.value = 0 And txtCgs.value = 0 And txtCrs.value = 0 Then
                Call restadeudaPs()
            End If






            Call cargarRegistros("")
            TxtidVenta.Text = ""
            txtidCredito.Text = ""
            txtIdCliente.Text = ""
            txtNombres.Text = ""
            txtRuc.Text = ""
            txtMensualidad.Text = ""
            txtTotalDeuda.Value = ""

            txtCuotaNro.Text = ""
            dpfecha.Value = Today
            'TxtApagar.Text = ""


        Catch ex As Exception


        End Try
    End Sub

    Private Sub grillaPND_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grillaPND.CellMouseDoubleClick
        txtidCredito.Text = grillaPND.Item(0, grillaPND.CurrentRow.Index).Value
        txtNombres.Text = grillaPND.Item(4, grillaPND.CurrentRow.Index).Value
        TxtidVenta.Text = grillaPND.Item(2, grillaPND.CurrentRow.Index).Value
        txtTotalDeuda.Value = grillaPND.Item(11, grillaPND.CurrentRow.Index).Value
        txtMensualidad.Text = grillaPND.Item(12, grillaPND.CurrentRow.Index).Value
        txtcantidadcuota.Text = grillaPND.Item(13, grillaPND.CurrentRow.Index).Value
        txtIdCliente.Text = grillaPND.Item(3, grillaPND.CurrentRow.Index).Value
        txtCuotaNro.Text = grillaPND.Item(15, grillaPND.CurrentRow.Index).Value
        txtRuc.Text = grillaPND.Item(5, grillaPND.CurrentRow.Index).Value
        txtCgs.Value = grillaPND.Item(16, grillaPND.CurrentRow.Index).Value
        txtCrs.Value = grillaPND.Item(17, grillaPND.CurrentRow.Index).Value
        txtCus.Value = grillaPND.Item(18, grillaPND.CurrentRow.Index).Value
        txtCps.Value = grillaPND.Item(19, grillaPND.CurrentRow.Index).Value
        dpfecha.Value = Today
        'TxtApagar.Text = TxtApagar.Text
        'total = Val(TxtApagar.Text)
        Call totalMonedas()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Call guardar()
        AbrirFormInPanel(New frmCajaCredito)
    End Sub

    Private Sub rptus_CheckedChanged(sender As Object, e As EventArgs) Handles rptus.CheckedChanged
        If rptus.Checked Then
            txtCus.Value = Val(txtMensualidad.Text) / Val(Txtcotius.Text)
            txtCgs.Value = "0"
            txtCps.Value = "0"
            txtCrs.Value = "0"
        ElseIf rptps.Checked Then
            txtCps.Value = Val(txtMensualidad.Text) / Val(Txtcotips.Text)
            txtCus.Value = "0"
            txtCgs.Value = "0"
            txtCrs.Value = "0"

        End If
    End Sub

    Private Sub rptgs_CheckedChanged(sender As Object, e As EventArgs) Handles rptgs.CheckedChanged
        If rptgs.Checked Then
            txtCgs.Value = txtMensualidad.Text
            txtCus.Value = "0"
            txtCps.Value = "0"
            txtCrs.Value = "0"
        ElseIf rptrs.Checked Then
            txtCrs.Value = Val(txtMensualidad.Text) / Val(Txtcotirs.Text)
            txtCus.Value = "0"
            txtCps.Value = "0"
            txtCgs.Value = "0"
            'Call rpt()

        End If
    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        Call ejecutarConsulta()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If optComprobante.Checked Then
            Call ejecutarConsulta()

        Else
            'Call cargarDeudores("")
            Call cargarRegistros("")
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



    'Private Sub grillaPND_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillaPND.CellContentDoubleClick
    '    txtidCredito.Text = grillaPND.Item(0, grillaPND.CurrentRow.Index).Value
    '    txtNombres.Text = grillaPND.Item(4, grillaPND.CurrentRow.Index).Value
    '    TxtidVenta.Text = grillaPND.Item(2, grillaPND.CurrentRow.Index).Value
    '    txtTotalDeuda.Text = grillaPND.Item(11, grillaPND.CurrentRow.Index).Value
    '    txtMensualidad.Text = grillaPND.Item(12, grillaPND.CurrentRow.Index).Value
    '    txtcantidadcuota.Text = grillaPND.Item(13, grillaPND.CurrentRow.Index).Value
    '    txtIdCliente.Text = grillaPND.Item(3, grillaPND.CurrentRow.Index).Value
    '    txtCuotaNro.Text = grillaPND.Item(15, grillaPND.CurrentRow.Index).Value
    '    txtRuc.Text = grillaPND.Item(5, grillaPND.CurrentRow.Index).Value
    '    txtCgs.Text = grillaPND.Item(16, grillaPND.CurrentRow.Index).Value
    '    txtCrs.Text = grillaPND.Item(17, grillaPND.CurrentRow.Index).Value
    '    txtCus.Text = grillaPND.Item(18, grillaPND.CurrentRow.Index).Value
    '    txtCps.Text = grillaPND.Item(19, grillaPND.CurrentRow.Index).Value
    '    dpfecha.Value = grillaPND.Item(6, grillaPND.CurrentRow.Index).Value
    '    'TxtApagar.Text = TxtApagar.Text
    '    'total = Val(TxtApagar.Text)
    '    Call totalMonedas()
    'End Sub
End Class