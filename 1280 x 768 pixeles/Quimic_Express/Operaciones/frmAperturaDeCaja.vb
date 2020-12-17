Imports MySql.Data.MySqlClient
Public Class frmAperturaDeCaja
    Dim comando As MySqlCommand
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

    Private Sub frmAperturaDeCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        operacionABM = "nuevo"
        txtGApertura.Focus()
        'txtCodigoUsuario.Text = codigoUsuario
        'txtNombreUsuario.Text = nombreUsuario
    End Sub

    ''Private Sub txtGApertura_Enter(sender As Object, e As EventArgs)
    ''    If txtGApertura.Text = "GUARANIES" Then
    ''        txtGApertura.Text = ""
    ''        txtGApertura.ForeColor = Color.Red
    ''    End If
    ''End Sub

    ''Private Sub txtGApertura_Leave(sender As Object, e As EventArgs)
    ''    If txtGApertura.Text = "" Then
    ''        txtGApertura.Text = "GUARANIES"
    ''        txtGApertura.ForeColor = Color.Red
    ''    End If
    ''End Sub

    ''Private Sub txtDApertura_Enter(sender As Object, e As EventArgs)
    ''    If txtDApertura.Text = "DOLAR" Then
    ''        txtDApertura.Text = ""
    ''        txtDApertura.ForeColor = Color.Red
    ''    End If
    ''End Sub

    ''Private Sub txtDApertura_Leave(sender As Object, e As EventArgs)
    ''    If txtDApertura.Text = "" Then
    ''        txtDApertura.Text = "DOLAR"
    ''        txtDApertura.ForeColor = Color.Red
    ''    End If
    ''End Sub

    ''Private Sub txtRApertura_Enter(sender As Object, e As EventArgs)
    ''    If txtRApertura.Text = "REAL" Then
    ''        txtRApertura.Text = ""
    ''        txtRApertura.ForeColor = Color.Red
    ''    End If
    ''End Sub

    ''Private Sub txtRApertura_Leave(sender As Object, e As EventArgs)
    ''    If txtRApertura.Text = "" Then
    ''        txtRApertura.Text = "REAL"
    ''        txtRApertura.ForeColor = Color.Red
    ''    End If
    ''End Sub

    ''Private Sub txtPApertura_Enter(sender As Object, e As EventArgs)
    ''    If txtPApertura.Text = "PESO" Then
    ''        txtPApertura.Text = ""
    ''        txtPApertura.ForeColor = Color.Red
    ''    End If
    ''End Sub

    ''Private Sub txtPApertura_Leave(sender As Object, e As EventArgs)
    ''    If txtPApertura.Text = "" Then
    ''        txtPApertura.Text = "PESO"
    ''        txtPApertura.ForeColor = Color.Red
    ''    End If
    ''End Sub

    Private Sub btnCancelarApertura_Click(sender As Object, e As EventArgs) Handles btnCancelarApertura.Click
        Me.Close()
        AbrirFormInPanel(New frmOperaciones)
    End Sub

    Private Sub btnGuardarApertura_Click(sender As Object, e As EventArgs) Handles btnGuardarApertura.Click
        Dim sql As String
        If Me.ValidateChildren = True And txtGApertura.Text <> "" And txtDApertura.Text <> "" And txtRApertura.Text <> "" And txtPApertura.Text <> "" Then
            Try
                abrirConexion()
                If operacionABM = "nuevo" Then
                    sql = "insert into apertura(CodigoUsuario,NombreUsuario,Guarani,Dolar,Realb,Peso,Fecha) values(@CodigoUsuario,@NombreUsuario,@Guarani,@Dolar,@Realb,@Peso,@Fecha)"
                    comando = New MySqlCommand(sql, conexion)
                    comando.Parameters.AddWithValue("@CodigoUsuario", txtCodigoUsuario.Text)
                    comando.Parameters.AddWithValue("@NombreUsuario", txtNombreUsuario.Text)
                    comando.Parameters.AddWithValue("@Guarani", txtGApertura.Value)
                    comando.Parameters.AddWithValue("@Dolar", txtDApertura.Value)
                    comando.Parameters.AddWithValue("@Realb", txtRApertura.Value)
                    comando.Parameters.AddWithValue("@Peso", txtPApertura.Value)
                    comando.Parameters.AddWithValue("@Fecha", dtpFecha.Value)
                End If
                comando.ExecuteNonQuery()
                MsgBox("Registro Guardado")
                Call Limpiar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Debe Rellenar Todos Los Campos", "Registro de Usuario ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Limpiar()
        txtCodigoUsuario.Text = ""
        txtNombreUsuario.Text = ""
        txtGApertura.Value = 0
        txtDApertura.Value = 0
        txtRApertura.Value = 0
        txtPApertura.Value = 0
        dtpFecha.Value = Now

    End Sub

    Private Sub buscarUsuario()
        Dim sql As String
        Dim adaptador As MySqlDataAdapter
        Dim datos As DataSet
        sql = "select * from consultausuario where id_usuario='" & txtCodigoUsuario.Text & "'"
        Try
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "rsUsuario")
            If datos.Tables("rsUsuario").Rows.Count > 0 Then
                txtNombreUsuario.Text = datos.Tables("rsUsuario").Rows(0).Item("nombre")
            Else
                txtNombreUsuario.Text = ""
                txtCodigoUsuario.Text = ""
                txtGApertura.Focus()
                MessageBox.Show("cliente no Encontrada", "QUIMIC EXPRESS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show("Abrir Formulario", "QWUIMIC EXPRESS", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Dim frm As frmSeleccionarUsuario = New frmSeleccionarUsuario
                AddOwnedForm(frm)
                frm.Show()
                frm.frmOrigen = "Apertura"

            End If
            conexion.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtCodigoUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoUsuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If IsNumeric(txtCodigoUsuario.Text) = True Then
                Call buscarUsuario()
                txtCodigoUsuario.Focus()
                e.Handled = True
            Else
                MessageBox.Show("cliente no Encontrada", "QUIMIC EXPRESS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show("Abrir Formulario", "QWUIMIC EXPRESS", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Dim frm As frmSeleccionarUsuario = New frmSeleccionarUsuario
                AddOwnedForm(frm)
                frm.Show()
                frm.frmOrigen = "Apertura"

            End If

        End If
    End Sub
End Class