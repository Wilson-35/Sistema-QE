Imports MySql.Data.MySqlClient
Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusuario.Focus()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        txtpassword.Focus()
        If CheckBox1.Checked = True Then
            txtpassword.isPassword = False
        Else
            txtpassword.isPassword = True
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        frmBienvenida.Close()

        Me.Close()
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Ingresar()
    End Sub

    Private Sub txtusuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtusuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpassword.Focus()
        End If
    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Ingresar()
        End If
    End Sub

    Private Sub Ingresar()
        Dim datos As New DataSet
        Dim adaptador As New MySqlDataAdapter
        Dim usuario, password As String
        usuario = txtusuario.Text
        password = txtpassword.Text
        Dim sql As String
        sql = "select * from usuario where NombreUsuario='" & usuario & "' and passwordUsuario='" & password & "'"
        Try
            Call abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            adaptador.Fill(datos, "xuser")
            If Me.ValidateChildren = True And txtusuario.Text <> "" And txtpassword.Text <> "" Then
                If datos.Tables("xuser").Rows.Count > 0 Then
                    'usuario = datos.Tables("xuser").Rows(0).Item("Id_Usuario")
                    nivelUsuario = datos.Tables("xuser").Rows(0).Item("Cargo")
                    'codigoUsuario = usuario
                    nombreUsuario = datos.Tables("xuser").Rows(0).Item("Nombre")
                    Permiso = datos.Tables("xuser").Rows(0).Item("nivel")
                    frmMenu.Show()
                    Me.Hide()
                    txtusuario.Text = ""
                    txtpassword.Text = ""
                Else
                    MsgBox("Usuario Incorrecto")
                End If
            Else
                MessageBox.Show("Debe Rellenar Todos Los Campos", "Registro de Usuario ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub
End Class