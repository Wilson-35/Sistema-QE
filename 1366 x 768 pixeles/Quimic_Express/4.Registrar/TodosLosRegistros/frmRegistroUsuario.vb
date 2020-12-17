Imports MySql.Data.MySqlClient

Public Class frmRegistroUsuario
    Dim comando As MySqlCommand
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter

    Private Sub frmRegistroUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        operacionABM = "nuevo"
        Try
            grdUsuario.DataSource = Usuario1.RecuperarTodosLosUsuarios
        Catch ex As Exception
            MessageBox.Show("Ocurrio Este Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call CargarNuevo()
    End Sub

    Private Sub CargarNuevo()

        Try
            If txtPassword1.Text <> txtPassword2.Text Then
                MessageBox.Show("Las Contraseñas Ingresadas No Coincide", "Verificar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim NuevoUsuario As New Usuario1
            Dim Id_Usuario As Integer

            NuevoUsuario.Id_Usuario = txtCodigo.Text.Trim
            NuevoUsuario.Nombre = txtNombre.Text.Trim
            NuevoUsuario.NombreUsuario = txtUsuario.Text.Trim
            NuevoUsuario.PasswordUsuario = txtPassword1.Text.Trim
            NuevoUsuario.Cargo = txtCargo.Text.Trim
            NuevoUsuario.Correo_Electronico = txtCorreo.Text.Trim
            NuevoUsuario.Contacto = txtContacto.Text.Trim
            NuevoUsuario.Estado = txtEstado.Text.Trim
            NuevoUsuario.Nivel = txtNivel.Text.Trim
            NuevoUsuario.Fecha = dtpFecha.Value


            If txtCodigo.Text = 0 Then
                Id_Usuario = Usuario1.InsertarUsuario(NuevoUsuario)
            Else
                Usuario1.EditarUsuario(NuevoUsuario)
            End If

            Call limpiarItemsDeUsuario()
            grdUsuario.DataSource = Usuario1.RecuperarTodosLosUsuarios
            btnCancelar.Focus()
            MessageBox.Show("Operacion Realizada")
        Catch ex As MySqlException
            MessageBox.Show("Ocurrio Este Error: " & ex.Message)
        End Try
    End Sub

    Public Sub limpiarItemsDeUsuario()
        txtCodigo.Text = 0
        txtNombre.Text = ""
        txtUsuario.Text = ""
        txtPassword1.Text = ""
        txtPassword2.Text = ""
        txtCargo.Text = ""
        txtCorreo.Text = ""
        txtContacto.Text = ""
        txtEstado.Text = 0
        txtNivel.Text = 0
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

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtUsuario.Focus()
        End If
    End Sub

    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPassword1.Focus()
        End If
    End Sub

    Private Sub txtPassword1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPassword2.Focus()
        End If
    End Sub

    Private Sub txtCorreo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCorreo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtContacto.Focus()
        End If
    End Sub

    Private Sub txtCargo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCargo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCorreo.Focus()
        End If
    End Sub

    Private Sub txtContacto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContacto.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNivel.Focus()
        End If
    End Sub

    Private Sub grdUsuario_SelectionChanged(sender As Object, e As EventArgs) Handles grdUsuario.SelectionChanged
        If grdUsuario.SelectedRows.Count > 0 Then
            Dim Id_Usuario As Integer = grdUsuario.SelectedRows(0).Cells(0).Value
            Dim UsuarioElegido As Usuario1
            UsuarioElegido = Usuario1.RecuperarUnUsuario(Id_Usuario)

            txtCodigo.Text = UsuarioElegido.Id_Usuario
            txtNombre.Text = UsuarioElegido.Nombre
            txtUsuario.Text = UsuarioElegido.NombreUsuario
            txtPassword1.Text = UsuarioElegido.PasswordUsuario
            txtPassword2.Text = UsuarioElegido.PasswordUsuario
            txtCargo.Text = UsuarioElegido.Cargo
            txtCorreo.Text = UsuarioElegido.Correo_Electronico
            txtContacto.Text = UsuarioElegido.Contacto
            txtEstado.Text = UsuarioElegido.Estado
            txtNivel.Text = UsuarioElegido.Nivel
            dtpFecha.Value = UsuarioElegido.Fecha
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Call limpiarItemsDeUsuario()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("Quiere Eliminar el Registros?", "Eliminar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim NuevoUsuario As New Usuario1
            NuevoUsuario.Id_Usuario = txtCodigo.Text
            Usuario1.EliminarUsuario(NuevoUsuario)

            limpiarItemsDeUsuario()
            grdUsuario.DataSource = Usuario1.RecuperarTodosLosUsuarios

            MessageBox.Show("Operacion Realizada")
        End If
    End Sub

    Private Sub txtPassword2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCargo.Focus()
        End If
    End Sub

    Private Sub txtNivel_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNivel.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call CargarNuevo()
        End If
    End Sub


    'Private Sub btnGuardar_Click2(sender As Object, e As EventArgs)
    '    Dim sql As String
    '    If Me.ValidateChildren = True And txtNombre.Text <> "" And txtUsuario.Text <> "" And txtPassword1.Text <> "" And txtPassword2.Text <> "" And txtCargo.Text <> "" And txtCorreo.Text <> "" And txtContacto.Text <> "" Then
    '        If txtPassword1.Text <> txtPassword2.Text Then
    '            MessageBox.Show("Las Contraseñas Ingresadas No Coincide", "Verificar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Exit Sub
    '        End If
    '        Try
    '            abrirConexion()
    '            If operacionABM = "nuevo" Then
    '                sql = "insert into usuario(nombre,NombreUsuario,passwordUsuario,cargo,correoelectronico,contacto) values(@nombre,@NombreUsuario,@passwordUsuario,@cargo,@correoelectronico,@contacto)"
    '                comando = New MySqlCommand(sql, conexion)
    '                comando.Parameters.AddWithValue("@nombre", txtNombre.Text)
    '                comando.Parameters.AddWithValue("@NombreUsuario", txtUsuario.Text)
    '                comando.Parameters.AddWithValue("@passwordUsuario", txtPassword1.Text)
    '                comando.Parameters.AddWithValue("@cargo", txtCargo.Text)
    '                comando.Parameters.AddWithValue("@correoelectronico", txtCorreo.Text)
    '                comando.Parameters.AddWithValue("@contacto", txtContacto.Text)
    '            End If
    '            comando.ExecuteNonQuery()
    '            MsgBox("Registro Guardado")
    '            txtNombre.Text = ""
    '            txtUsuario.Text = ""
    '            txtPassword1.Text = ""
    '            txtPassword2.Text = ""
    '            txtCargo.Text = ""
    '            txtCorreo.Text = ""
    '            txtContacto.Text = ""
    '            txtNombre.Focus()
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    Else
    '        MessageBox.Show("Debe Rellenar Todos Los Campos", "Registro de Usuario ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    '    'Call cargarRegistros("")
    'End Sub

End Class