Imports MySql.Data.MySqlClient
Public Class frmRegistroCliente
    Dim comando As MySqlCommand
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter
    Private Sub frmRegistroCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        operacionABM = "nuevo"
        Try
            grdCliente.DataSource = Cliente.RecuperarTodosLosClientes
        Catch ex As Exception
            MessageBox.Show("Ocurrio Este Error: " & ex.Message)
        End Try
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call CargarNuevo()
    End Sub

    Private Sub CargarNuevo()

        Try
            Dim NuevoCliente As New Cliente
            Dim Id_Cliente As Integer

            NuevoCliente.Id_Cliente = txtCodigo.Text.Trim
            NuevoCliente.Nombre = txtNombre.Text.Trim
            NuevoCliente.Dirección = txtDireccion.Text.Trim
            NuevoCliente.Contacto = txtContacto.Text.Trim
            NuevoCliente.Ruc = txtRuc.Text.Trim
            NuevoCliente.Correo_Electronico = txtCorreoElectronico.Text.Trim
            NuevoCliente.FechaDeNacimiento = dtpFechaDeNacimiento.Value
            NuevoCliente.Fecha = dtpFecha.Value


            If txtCodigo.Text = 0 Then
                Id_Cliente = Cliente.InsertarCliente(NuevoCliente)
            Else
                Cliente.EditarCliente(NuevoCliente)
            End If

            Call limpiarItemsDeCliente()
            grdCliente.DataSource = Cliente.RecuperarTodosLosClientes
            btnCancelar.Focus()
            MessageBox.Show("Operacion Realizada")
        Catch ex As MySqlException
            MessageBox.Show("Ocurrio Este Error: " & ex.Message)
        End Try
    End Sub


    Public Sub limpiarItemsDeCliente()
        txtCodigo.Text = 0
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtContacto.Text = ""
        txtRuc.Text = ""
        txtCorreoElectronico.Text = ""
        dtpFechaDeNacimiento.Value = Now
        dtpFecha.Value = Now
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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        AbrirFormInPanel(New frmRegistro)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Call limpiarItemsDeCliente()
    End Sub

    Private Sub grdCliente_SelectionChanged(sender As Object, e As EventArgs) Handles grdCliente.SelectionChanged
        If grdCliente.SelectedRows.Count > 0 Then
            Dim Id_Cliente As Integer = grdCliente.SelectedRows(0).Cells(0).Value
            Dim ClienteElegido As Cliente
            ClienteElegido = Cliente.RecuperarUnCliente(Id_Cliente)

            txtCodigo.Text = ClienteElegido.Id_Cliente
            txtNombre.Text = ClienteElegido.Nombre
            txtDireccion.Text = ClienteElegido.Dirección
            txtContacto.Text = ClienteElegido.Contacto
            txtRuc.Text = ClienteElegido.Ruc
            txtCorreoElectronico.Text = ClienteElegido.Correo_Electronico
            dtpFechaDeNacimiento.Value = ClienteElegido.FechaDeNacimiento
            dtpFecha.Value = ClienteElegido.Fecha
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("Quiere Eliminar el Registros?", "Eliminar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim NuevoCliente As New Cliente
            NuevoCliente.Id_Cliente = txtCodigo.Text
            Cliente.EliminarCliente(NuevoCliente)

            limpiarItemsDeCliente()
            grdCliente.DataSource = Cliente.RecuperarTodosLosClientes

            MessageBox.Show("Operacion Realizada")
        End If
    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDireccion.Focus()
        End If
    End Sub

    Private Sub txtDireccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDireccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtContacto.Focus()
        End If
    End Sub

    Private Sub txtContacto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContacto.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtRuc.Focus()
        End If
    End Sub

    Private Sub txtRuc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRuc.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCorreoElectronico.Focus()
        End If
    End Sub

    Private Sub txtCorreoElectronico_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCorreoElectronico.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtpFechaDeNacimiento.Focus()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    'Private Sub btnGuardar_Click(sender As Object, e As EventArgs)
    '    Dim sql As String
    '    If Me.ValidateChildren = True And txtNombre.Text <> "" And txtApellidos.Text <> "" And txtDireccion.Text <> "" And txtContacto.Text <> "" And txtfechadenacimiento.Text <> "" And txtRuc.Text <> "" And txtCorreoE.Text <> "" Then
    '        Try
    '            abrirConexion()
    '            If operacionABM = "nuevo" Then
    '                sql = "insert into cliente(nombres,apellidos,direccion,contacto,fechadenacimiento,ruc,correoelectronico) values(@nombres,@apellidos,@direccion,@contacto,@fechadenacimiento,@ruc,@correoelectronico)"
    '                comando = New MySqlCommand(sql, conexion)
    '                comando.Parameters.AddWithValue("@nombres", txtNombre.Text)
    '                comando.Parameters.AddWithValue("@apellidos", txtApellidos.Text)
    '                comando.Parameters.AddWithValue("@direccion", txtDireccion.Text)
    '                comando.Parameters.AddWithValue("@contacto", txtContacto.Text)
    '                comando.Parameters.AddWithValue("@fechadenacimiento", txtfechadenacimiento.Text)
    '                comando.Parameters.AddWithValue("@ruc", txtRuc.Text)
    '                comando.Parameters.AddWithValue("@correoelectronico", txtCorreoE.Text)
    '            End If
    '            comando.ExecuteNonQuery()
    '            MsgBox("Registro Guardado")
    '            txtNombre.Text = ""
    '            txtApellidos.Text = ""
    '            txtDireccion.Text = ""
    '            txtContacto.Text = ""
    '            txtfechadenacimiento.Text = ""
    '            txtRuc.Text = ""
    '            txtCorreoE.Text = ""
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    Else
    '        MessageBox.Show("Debe Rellenar Todos Los Campos", "Registro de Usuario ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    '    Call cargarRegistros("")
    'End Sub
End Class